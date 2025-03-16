using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace BookHaven.Model
{
    public class ReceiptPrint
    {
        private string transactionID;
        private string customerName;
        private string totalAmount;
        private string discount;
        private string netRevenue;
        private DataGridView summaryGridView;

        public ReceiptPrint(string transactionID, string customerName, string totalAmount, string discount, string netRevenue, DataGridView summaryGridView)
        {
            this.transactionID = transactionID;
            this.customerName = customerName;
            this.totalAmount = totalAmount;
            this.discount = discount;
            this.netRevenue = netRevenue;
            this.summaryGridView = summaryGridView;
        }

        public void PrintReceipt()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintReceiptPage);
            PrintPreviewDialog printPreview = new PrintPreviewDialog
            {
                Document = printDocument
            };
            printPreview.ShowDialog();
        }

        private void PrintReceiptPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font titleFont = new Font("Courier New", 16, FontStyle.Bold);
            Font headerFont = new Font("Courier New", 12, FontStyle.Bold);
            Font contentFont = new Font("Courier New", 11);
            Brush brush = Brushes.Black;

            float startX = 20, startY = 20, offsetY = 25;

            // ✅ Store Name - Center Align
            StringFormat centerAlign = new StringFormat { Alignment = StringAlignment.Center };
            graphics.DrawString("📖 BookHaven Bookstore 📖", titleFont, brush, e.PageBounds.Width / 2, startY, centerAlign);
            startY += offsetY + 10;

            // ✅ Transaction ID & Date
            graphics.DrawString($"🆔 Transaction ID: {transactionID}", headerFont, brush, startX, startY);
            startY += offsetY;
            graphics.DrawString($"📅 Date: {DateTime.Now}", headerFont, brush, startX, startY);
            startY += offsetY;

            // ✅ Print Customer Name & Sales Clerk
            graphics.DrawString($"👤 Customer: {customerName ?? "Walk-in Customer"}", headerFont, brush, startX, startY);
            startY += offsetY;
            graphics.DrawString($"👔 Salesperson: {loginFrm.staffName}", headerFont, brush, startX, startY);
            startY += offsetY + 10;

            // ✅ Draw Table Headers
            graphics.DrawString("📚 Book", headerFont, brush, startX, startY);
            graphics.DrawString("Qty", headerFont, brush, startX + 200, startY);
            graphics.DrawString("💰 Price", headerFont, brush, startX + 300, startY);
            graphics.DrawString("🔹 Total", headerFont, brush, startX + 400, startY);
            startY += offsetY;

            graphics.DrawString("──────────────────────────────────────────", contentFont, brush, startX, startY);
            startY += offsetY;

            // ✅ Print Items from DataGridView (Formatted)
            foreach (DataGridViewRow row in summaryGridView.Rows)
            {
                if (row.Cells["BookName"].Value != null)
                {
                    string bookName = row.Cells["BookName"].Value.ToString();
                    string quantity = row.Cells["bookQuantity"].Value?.ToString() ?? "0";
                    string price = row.Cells["bookPrice"].Value?.ToString() ?? "0";
                    string total = row.Cells["Price"].Value?.ToString() ?? "0";

                    graphics.DrawString(bookName, contentFont, brush, startX, startY);
                    graphics.DrawString(quantity, contentFont, brush, startX + 200, startY);
                    graphics.DrawString(price, contentFont, brush, startX + 300, startY);
                    graphics.DrawString(total, contentFont, brush, startX + 400, startY);

                    startY += offsetY;
                }
            }

            // ✅ Print Total Amount & Discount
            startY += 10;
            graphics.DrawString("──────────────────────────────────────────", contentFont, brush, startX, startY);
            startY += offsetY;
            graphics.DrawString($"💲 Total Price: {totalAmount}", headerFont, brush, startX, startY);
            startY += offsetY;
            graphics.DrawString($"🔻 Discount: {discount}", headerFont, brush, startX, startY);
            startY += offsetY;

            // ✅ Highlight Net Revenue
            graphics.DrawString($"✅ Net Revenue: {netRevenue}", new Font("Courier New", 13, FontStyle.Bold), Brushes.Green, startX, startY);
            startY += offsetY + 20;

            // ✅ Print Thank You Message - Center Align
            graphics.DrawString("🙏 Thank You for Shopping with Us! 🙌", headerFont, brush, e.PageBounds.Width / 2, startY, centerAlign);
        }


    }
}
