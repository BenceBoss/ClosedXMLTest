using ClosedXML.Excel;
namespace ClosedXMLTest
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = ".xlsx";
            if (sfd.ShowDialog() != DialogResult.OK) return;
            
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Sample Sheet");
            BikestoreModels.SeBikestoreContext context = new BikestoreModels.SeBikestoreContext();
            var bicók=context.Products.ToList();
            for (int i = 0; i < bicók.Count(); i++)
            {
                worksheet.Cell(i+1,1).Value = bicók[i].ProductName;
                worksheet.Cell(i + 1, 2).Value = bicók[i].ListPrice;
            }
            workbook.SaveAs(sfd.FileName);
        }
    }
}
