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
    public partial class ReportProductForm : UserControl
    {
        DateTime strDate;
        DateTime endDate;

        public ReportProductForm()
        {
            InitializeComponent();
        }

        private void LoadTransaction()
        {
            var reports = new List<ReportProductViewModel>();
            var context = new db();
            var trx = context.DetailProductTrxes
                .Where(x => x.HeaderTrx.Date >= strDate && x.HeaderTrx.Date <= endDate)
                .ToList();

            var prdt = context.Products.ToList();
            foreach (var p in prdt)
            {
                var qty = 0;
                var subtotal = 0;
                var profit = 0;
                var specific = trx.Where(x => x.ProductId == p.ProductId).ToList();
                foreach (var s in specific)
                {
                    qty += s.Qty;
                    subtotal += s.SellPrice * s.Qty;
                    profit = subtotal - (s.BuyPrice * s.Qty);
                }
                var report = new ReportProductViewModel()
                {
                    ID = p.ProductId,
                    Name = p.Name,
                    Qty = qty,
                    BuyPrice = p.BuyPrice,
                    SellPrice = p.SellPrice,
                    Subtotal = subtotal,
                    Profit = profit
                };
                reports.Add(report);
            }

            var totalSubtotal = 0;
            var totalProfit = 0;
            foreach (var r in reports)
            {
                totalSubtotal += r.Subtotal;
                totalProfit += r.Profit;
            }
            var addition = new ReportProductViewModel()
            {
                ID = "Total",
                Name = "",
                Subtotal = totalSubtotal,
                Profit = totalProfit
            };
            reports.Add(addition);

            dgv.DataSource = reports.Select(x => new
            {
                colID = x.ID,
                colName = x.Name,
                colQty = x.Qty,
                colBuy = SnippetCurrency.ConvertCurrency(x.BuyPrice),
                colSell = SnippetCurrency.ConvertCurrency(x.SellPrice),
                colSubtotal = SnippetCurrency.ConvertCurrency(x.Subtotal),
                colProfit = SnippetCurrency.ConvertCurrency(x.Profit)
            }).ToList();

        }

        private void iBtnPrint_Click(object sender, EventArgs e)
        {
            var table = new DataTable();
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                var headerText = dgv.Columns[i].HeaderText;
                if (i == 3 || i == 4) headerText = dgv.Columns[i].HeaderText.Replace(" ", "");
                table.Columns.Add(headerText);
            }

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                var row = table.NewRow();
                row[dgv.Columns[0].HeaderText] = dgv.Rows[i].Cells[0].Value.ToString();
                row[dgv.Columns[1].HeaderText] = dgv.Rows[i].Cells[1].Value.ToString();
                row[dgv.Columns[2].HeaderText] = dgv.Rows[i].Cells[2].Value.ToString();
                row[dgv.Columns[3].HeaderText.Replace(" ", "")] = dgv.Rows[i].Cells[3].Value.ToString();
                row[dgv.Columns[4].HeaderText.Replace(" ", "")] = dgv.Rows[i].Cells[4].Value.ToString();
                row[dgv.Columns[5].HeaderText] = dgv.Rows[i].Cells[5].Value.ToString();
                row[dgv.Columns[6].HeaderText] = dgv.Rows[i].Cells[6].Value.ToString();
                table.Rows.Add(row);
            }

            var workbook = new HSSFWorkbook();
            var sheet = workbook.CreateSheet("SPW Data");
            string json = JsonConvert.SerializeObject(table);
            var items = JsonConvert.DeserializeObject<List<SummaryProductClass>>(json);
            var headers = new[] {
                dgv.Columns[0].HeaderText,
                dgv.Columns[1].HeaderText,
                dgv.Columns[2].HeaderText,
                dgv.Columns[3].HeaderText.Replace(" ", ""),
                dgv.Columns[4].HeaderText.Replace(" ", ""),
                dgv.Columns[5].HeaderText,
                dgv.Columns[6].HeaderText
            };
            var headerRow = sheet.CreateRow(0);
            for (int i = 0; i < headers.Length; i++)
            {
                var cell = headerRow.CreateCell(i);
                cell.SetCellValue(headers[i]);
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
                LoadTransaction();
            }

            if (cBoxTrx.SelectedIndex == 1)
            {
                strDate = new DateTime(date.Year, date.Month, 1);
                endDate = strDate.AddMonths(1).AddSeconds(-1);
                LoadTransaction();
            }
        }

        private void ReportProductForm_Load(object sender, EventArgs e)
        {
            cBoxTrx.SelectedIndex = 0;
            LoadTransaction();
        }
    }

    public class SummaryProductClass
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public string BuyPrice { get; set; }
        public string SellPrice { get; set; }
        public string Subtotal { get; set; }
        public string Profit { get; set; }
    }
}
