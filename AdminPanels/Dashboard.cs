using ABC_Car_Traders.Data;
using iTextSharp.text.pdf;
using iTextSharp.text;
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

namespace ABC_Car_Traders
{
    public partial class Dashboard : UserControl
    {

        SQLConnection sql = new SQLConnection();

        public Dashboard()
        {
            InitializeComponent();
            LoadCarOrders(); // Load car orders when the UserControl is initialized
            LoadPartOrders(); // Load part orders when the UserControl is initialized
            LoadCounts(); 
        }

        // Method to load counts for users, car orders, and part orders
        private void LoadCounts()
        {
            int userCount = GetUserCount();
            int carOrderCount = GetCarOrderCount();
            int partOrderCount = GetPartOrderCount();

            // Format counts to add leading zero if count is less than 10
            dashboard_userCount.Text = FormatCount(userCount);
            dashboard_carOrderCount.Text = FormatCount(carOrderCount);
            dashboard_partOrderCount.Text = FormatCount(partOrderCount);
        }

        private void LoadCarOrders()
        {
            CarOrderData carOrderData = new CarOrderData();
            List<CarOrderData> carOrders = carOrderData.GetAllCarOrders();

            carOrdersDataGrid.DataSource = carOrders;

            carOrdersDataGrid.Columns["ImageUrl"].Visible = false;
            carOrdersDataGrid.Columns["Model"].Visible = false;
            carOrdersDataGrid.Columns["Make"].Visible = false;
            carOrdersDataGrid.Columns["OrderDate"].Visible = false;

            // Set DataGridView properties
            carOrdersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            carOrdersDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadPartOrders()
        {
            PartOrderData partOrderData = new PartOrderData();
            List<PartOrderData> partOrders = partOrderData.GetAllPartOrders();



            partOrdersDataGrid.DataSource = partOrders;

            partOrdersDataGrid.Columns["ImageUrl"].Visible = false;
            partOrdersDataGrid.Columns["Manufacturer"].Visible = false;
            partOrdersDataGrid.Columns["OrderDate"].Visible = false;



            // Set DataGridView properties
            partOrdersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            partOrdersDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // Event handler to generate PDF report for car orders
        private void carOrder_export_Click(object sender, EventArgs e)
        {
            CarOrderData carOrderData = new CarOrderData();
            List<CarOrderData> carOrders = carOrderData.GetAllCarOrders();

            GeneratePDFReport(carOrders, "CarOrdersReport.pdf", "Car Orders Report");
        }

        // Event handler to generate PDF report for part orders
        private void partOrder_export_Click(object sender, EventArgs e)
        {
            PartOrderData partOrderData = new PartOrderData();
            List<PartOrderData> partOrders = partOrderData.GetAllPartOrders();

            GeneratePDFReport(partOrders, "PartOrdersReport.pdf", "Part Orders Report");
        }

        // Method to generate a PDF report
        private void GeneratePDFReport<T>(List<T> orders, string defaultFileName, string reportTitle)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*",
                FileName = defaultFileName
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Document document = new Document(PageSize.A4, 25, 25, 30, 30);
                PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                document.Open();

                // Add title
                var titleFont = FontFactory.GetFont("Arial", 18, iTextSharp.text.Font.BOLD);
                Paragraph title = new Paragraph(reportTitle, titleFont)
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingAfter = 20
                };
                document.Add(title);

                // Get properties of the type T excluding ImageUrl
                var properties = typeof(T).GetProperties().Where(p => p.Name != "ImageUrl").ToList();

                // Add table headers
                PdfPTable table = new PdfPTable(properties.Count);
                table.WidthPercentage = 100;

                // Define table header font
                var headerFont = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD);

                foreach (var prop in properties)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(prop.Name, headerFont))
                    {
                        BackgroundColor = BaseColor.LIGHT_GRAY,
                        HorizontalAlignment = Element.ALIGN_CENTER
                    };
                    table.AddCell(cell);
                }

                // Add table data
                foreach (var order in orders)
                {
                    foreach (var prop in properties)
                    {
                        string value = prop.GetValue(order)?.ToString() ?? string.Empty;
                        PdfPCell cell = new PdfPCell(new Phrase(value))
                        {
                            HorizontalAlignment = Element.ALIGN_CENTER
                        };
                        table.AddCell(cell);
                    }
                }

                document.Add(table);
                document.Close();

                MessageBox.Show("PDF report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Method to get user count
        private int GetUserCount()
        {
            string query = "SELECT COUNT(*) FROM users";
            return sql.ExecuteScalarQuery(query);
        }

        // Method to get car order count
        private int GetCarOrderCount()
        {
            string query = "SELECT COUNT(*) FROM CarOrders";
            return sql.ExecuteScalarQuery(query);
        }

        // Method to get part order count
        private int GetPartOrderCount()
        {
            string query = "SELECT COUNT(*) FROM PartOrders";
            return sql.ExecuteScalarQuery(query);
        }

        // Method to format the count with leading zero if less than 10
        private string FormatCount(int count)
        {
            return count < 10 ? $"0{count}" : count.ToString();
        }
    }
}
