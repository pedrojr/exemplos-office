using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;

namespace WordAddInTest
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnTest_Click(object sender, RibbonControlEventArgs e)
        {
            Word.Document document = Globals.ThisAddIn.Application.ActiveDocument;
            document.Content.Text += "Test\r\n";
        }
    }
}
