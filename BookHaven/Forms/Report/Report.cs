using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace BookHaven.Forms.Report
{
    public partial class ReportForm : UserControl
    {
        private DataTable reportTable = new DataTable();
        private bool isFormLoaded = false;

        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            ReportTypeComboBox.SelectedIndex = 0; // Default report
            reportFromDateTimePicker.ShowCheckBox = true;
            ReportToDateTimePicker.ShowCheckBox = true;
            reportFromDateTimePicker.Checked = false;
            ReportToDateTimePicker.Checked = false;
            LoadSelectedReport(); // This will load full data with no filter
            isFormLoaded = true;
        }

        private void LoadSelectedReport()
        {
            string selectedType = ReportTypeComboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedType)) return;

            switch (selectedType)
            {
                case "Sales Report":
                    reportTable = ReportGenerator.GetSalesReport();
                    break;
                case "Book Sales Summary":
                    reportTable = ReportGenerator.GetBookSalesSummary();
                    break;
                case "Customer Purchase History":
                    reportTable = ReportGenerator.GetCustomerPurchaseHistory();
                    break;
                default:
                    MessageBox.Show("Unknown report type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            ApplyDateFilter(); // Apply filter only if any date is checked
        }

        private void ApplyDateFilter()
        {
            if (reportTable == null || reportTable.Rows.Count == 0)
            {
                reportDataGridview.DataSource = null;
                return;
            }

            // Detect valid date column
            string[] possibleDateColumns = { "TransactionDate", "OrderDate", "PurchaseDate", "CreatedAt" };
            string dateColumn = possibleDateColumns.FirstOrDefault(col => reportTable.Columns.Contains(col));

            if (string.IsNullOrEmpty(dateColumn))
            {
                reportDataGridview.DataSource = reportTable;
                return;
            }

            bool filterFrom = reportFromDateTimePicker.Checked;
            bool filterTo = ReportToDateTimePicker.Checked;

            // No filter selected, show all
            if (!filterFrom && !filterTo)
            {
                reportDataGridview.DataSource = reportTable;
                return;
            }

            DateTime from = filterFrom ? reportFromDateTimePicker.Value.Date : DateTime.MinValue;
            DateTime to = filterTo ? ReportToDateTimePicker.Value.Date.AddDays(1).AddSeconds(-1) : DateTime.MaxValue;

            var filteredRows = reportTable.AsEnumerable()
                .Where(row =>
                {
                    if (row[dateColumn] == DBNull.Value) return false;
                    DateTime rowDate = Convert.ToDateTime(row[dateColumn]);
                    return rowDate >= from && rowDate <= to;
                });

            if (filteredRows.Any())
            {
                reportDataGridview.DataSource = filteredRows.CopyToDataTable();
            }
            else
            {
                reportDataGridview.DataSource = null;


                if (!filteredRows.Any())
                {
                    reportDataGridview.DataSource = null;

                    // Show message only if it's not during form load
                    if (isFormLoaded)
                    {
                        MessageBox.Show("No matching records found for the selected date range.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }


        private void ReportTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedReport();
        }

        private void reportFromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ApplyDateFilter();
        }

        private void ReportToDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ApplyDateFilter();
        }

        private void DownloadReportButton_Click(object sender, EventArgs e)
        {
            if (reportDataGridview.Rows.Count == 0)
            {
                MessageBox.Show("No data to download.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string reportType = ReportTypeComboBox.SelectedItem?.ToString() ?? "Report";
            string fileName = $"{reportType.Replace(" ", "_")}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string fullPath = Path.Combine(downloadsPath, fileName);

            try
            {
                Document doc = new Document(PageSize.A4, 10f, 10f, 20f, 20f);
                PdfWriter.GetInstance(doc, new FileStream(fullPath, FileMode.Create));
                doc.Open();

                Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                Paragraph title = new Paragraph(reportType + "\n\n", titleFont)
                {
                    Alignment = Element.ALIGN_CENTER
                };
                doc.Add(title);

                PdfPTable pdfTable = new PdfPTable(reportDataGridview.Columns.Count)
                {
                    WidthPercentage = 100
                };

                foreach (DataGridViewColumn column in reportDataGridview.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD)))
                    {
                        HorizontalAlignment = Element.ALIGN_CENTER,
                        BackgroundColor = new BaseColor(240, 240, 240)
                    };
                    pdfTable.AddCell(cell);
                }

                foreach (DataGridViewRow row in reportDataGridview.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(new Phrase(cell.Value?.ToString() ?? "", FontFactory.GetFont("Arial", 9)));
                        }
                    }
                }

                doc.Add(pdfTable);
                doc.Close();

                MessageBox.Show($"PDF saved to: {fullPath}", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
