
namespace WordAddInTest
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.MyGroup = this.Factory.CreateRibbonGroup();
            this.btnTest = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.MyGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.MyGroup);
            this.tab1.Label = "MyTab";
            this.tab1.Name = "tab1";
            // 
            // MyGroup
            // 
            this.MyGroup.Items.Add(this.btnTest);
            this.MyGroup.Label = "MyGroup";
            this.MyGroup.Name = "MyGroup";
            // 
            // btnTest
            // 
            this.btnTest.Label = "Test";
            this.btnTest.Name = "btnTest";
            this.btnTest.OfficeImageId = "FileInternetFax";
            this.btnTest.ShowImage = true;
            this.btnTest.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnTest_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.MyGroup.ResumeLayout(false);
            this.MyGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup MyGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnTest;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
