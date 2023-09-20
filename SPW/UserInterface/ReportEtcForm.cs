using Newtonsoft.Json;
using NPOI.HSSF.UserModel;
using SPW.Snippet;
using SPW.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPW.UserInterface
{
    public partial class ReportEtcForm : UserControl
    {
        DateTime strDate;
        DateTime endDate;

        public ReportEtcForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            var report = new List<ReportEtcViewModel>();
            var context = new db();

            var types = context.Types.ToList();
            foreach (var ty in types)
            {
                var trx = context.DetailEtcTrxes
                .Where(
                    x => x.HeaderTrx.Date >= strDate &&
                    x.HeaderTrx.Date <= endDate &&
                    x.TypeId == ty.TypeId)
                .Select(x => new
                {
                    x.Type.TypeId,
                    x.Type.Name,
                    x.Price
                })
                .ToList();

                var priceTotal = trx.Sum(x => x.Price);
                var item = new ReportEtcViewModel()
                {
                    ID = ty.TypeId.ToString(),
                    Name = ty.Name,
                    Price = priceTotal
                };
                report.Add(item);
            }

            var total = report.Sum(x => x.Price);
            var summary = new ReportEtcViewModel()
            {
                Name = "Total",
                Price = total
            };
            report.Add(summary);

            dgv.DataSource = report.Select(x => new
            {
                colId = x.ID,
                colName = x.Name,
                colPrice = SnippetCurrency.ConvertCurrency(x.Price)
            }).ToList();
        }

        private void iBtnPrint_Click(object sender, EventArgs e)
        {
            var table = new DataTable();
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                var headerText = dgv.Columns[i].HeaderText;
                table.Columns.Add(headerText);
            }

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                var row = table.NewRow();
                row[dgv.Columns[0].HeaderText] = dgv.Rows[i].Cells[0].Value == null ? "" : dgv.Rows[i].Cells[0].Value.ToString();
                row[dgv.Columns[1].HeaderText] = dgv.Rows[i].Cells[1].Value.ToString();
                row[dgv.Columns[2].HeaderText] = dgv.Rows[i].Cells[2].Value.ToString();
                table.Rows.Add(row);
            }

            var workbook = new HSSFWorkbook();
            var sheet = workbook.CreateSheet("SPW Data");
            string json = JsonConvert.SerializeObject(table);
            var items = JsonConvert.DeserializeObject<List<SummaryEtceraClass>>(json);
            var headers = new[]
            {
                dgv.Columns[0].HeaderText,
                dgv.Columns[1].HeaderText,
                dgv.Columns[2].HeaderText
            };
            var headerRow = sheet.CreateRow(0);
            for (int i = 0; i < headers.Length; i++)
            {
                var cells = headerRow.CreateCell(i);
                cells.SetCellValue(headers[i]);
            }

            for (int i = 0; i < items.Count; i++)
            {
                var rowIndex = i + 1;
                var row = sheet.CreateRow(rowIndex);

                for (int j = 0; j < headers.Length; j++)
                {
                    var cell = row.CreateCell(j);
                    var o = items[i];
                    cell.SetCellValue(o.GetType().GetProperty(headers[j]).GetValue(o, null).ToString());
                }
            }

            var stream = new MemoryStream();
            workbook.Write(stream);

            var choofdlog = new SaveFileDialog();
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                var path = $"{choofdlog.FileName}.xls";
                var file = new FileStream(path, FileMode.CreateNew, FileAccess.Write);
                stream.WriteTo(file);
                file.Close();
                stream.Close();
                SnippetMbox.MboxInformation("Export Success", "Report Form");
            }
        }

        private void cBoxTrx_SelectedIndexChanged(object sender, EventArgs e)
        {
            var date = DateTime.Now;
            if (cBoxTrx.SelectedIndex == 0)
            {
                strDate = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
                endDate = strDate.AddDays(1).AddSeconds(-1);
            }
            if (cBoxTrx.SelectedIndex == 1)
            {
                strDate = new DateTime(date.Year, date.Month, 1);
                endDate = strDate.AddMonths(1).AddSeconds(-1);
            }

            LoadData();
        }

        private void ReportEtcForm_Load(object sender, EventArgs e)
        {
            cBoxTrx.SelectedIndex = 0;
            LoadData();
        }
    }

    public class SummaryEtceraClass
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }
}
