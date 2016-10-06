using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infragistics.Win.UltraWinToolbars;
using Servent.BLL;
using Servent.DAL;
using Servent.Domain;
using Servent.Util;

namespace Servent.UI.Forms
{
    public partial class FormAdministration : Form
    {
        #region Fields

        private readonly ManangerStock _manangerStock;
        private readonly ManangerConstruction _manangerConstruction;
        TraceHelper _traceHelper = new TraceHelper("servent.txt","C:\\");

        #endregion
        #region Methods
        public FormAdministration()
        {
            
            _traceHelper.Write("Entrando no construtor FormAdministration() ");
            CheckForIllegalCrossThreadCalls = false;
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            //Splash screen só é lançada se o projeto não estiver sendo executado a partir do VS
            _traceHelper.Write("Chamando splash screen");
            if (!Process.GetCurrentProcess().ProcessName.Contains("_vshost"))
            {
                FormSplashScreen fscr = new FormSplashScreen();
                Task.Factory.StartNew(() =>
                {
                    Task.Factory.StartNew(() => fscr.ShowDialog(), cts.Token);
                    bool gurd = true;
                    while (gurd)
                    {
                        if (!token.IsCancellationRequested) continue;

                        fscr.Close();
                        gurd = false;
                    }
                }, cts.Token);
            }

            _traceHelper.Write("Inicializando componentes");
            InitializeComponent();
            _traceHelper.Write("Chamando manangerStock");
            _manangerStock = new ManangerStock();
            _traceHelper.Write("Chamando manangerConstruction");
            _manangerConstruction = new ManangerConstruction();
            LoadDataGridMaterials();
            cts.Cancel();
            UpdateMaterialsStatusBar();
            this.TopMost = true;
        }

        private void ServerConfig()
        {
        x:
            FormServerConfi confi = new FormServerConfi(Settings.ServerAddress, Settings.IsLocalServer);
            DialogResult dialogResult = confi.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                Settings.ServerAddress = confi.ServerAddress;
                Settings.IsLocalServer = confi.IsLocalServer;
            }
            else if (dialogResult == DialogResult.Retry) goto x;
        }

        private void ViewHistoric()
        {
            if (ultraGrid.Selected.Rows.Count == 0 || ultraGrid.Selected.Rows[0].IsGroupByRow)
                return;
            int id = 0;
            try
            {
                id = int.Parse((((DataRowView)ultraGrid.ActiveRow.ListObject).Row.ItemArray[0]).ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }

            Construction construction = _manangerConstruction.GetConstructionByID(id);
            LoaddataTableHistoric(construction);
            FormViwerHistoric viwerHistoric = new FormViwerHistoric(construction, tbServent.Tables[2]);
            viwerHistoric.ShowDialog();
        }

        private void FormAddMaterialFromStore()
        {
            if (ultraGrid.Selected.Rows.Count == 0 || ultraGrid.Selected.Rows[0].IsGroupByRow)
                return;
            int id = 0;
            try
            {
                id = int.Parse((((DataRowView)ultraGrid.ActiveRow.ListObject).Row.ItemArray[0]).ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }
            var nome = _manangerConstruction.GetConstructionById(id);
            FormAddMaterialFromStore form = new FormAddMaterialFromStore(nome, _manangerStock.GetAllUnitTypes());
            DialogResult dialog = form.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                _manangerConstruction.AddNewHistoricalMovement(form.ConstructionHistory, id);
            }
        }

        private void LoaddataTableHistoric(Construction construction)
        {
            tbServent.Tables[2].Clear();
            foreach (var m in construction.ConstructionHistory)
            {
                if (m.Provider != null && m.Provider.Name != string.Empty)
                    tbServent.Tables[2].Rows.Add(m.ID, m.Provider.Name, m.Provider.PhoneNumber, m.MaterialsMovements.Material.Name, m.MaterialsMovements.DateOfMovement, m.MaterialsMovements.Quantity,
                        m.MaterialsMovements.TotalBalance);
                else
                    tbServent.Tables[2].Rows.Add(m.ID, "Estoque", "         -              ", m.MaterialsMovements.Material.Name, m.MaterialsMovements.DateOfMovement, m.MaterialsMovements.Quantity,
                    m.MaterialsMovements.TotalBalance);
            }
        }

        private void DeleteConstruction()
        {
            if (ultraGrid.Selected.Rows.Count == 0 || ultraGrid.Selected.Rows[0].IsGroupByRow)
                return;
            int id = 0;
            try
            {
                id = int.Parse((((DataRowView)ultraGrid.ActiveRow.ListObject).Row.ItemArray[0]).ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(@"Erro: " + e.Message);
            }
            var c = _manangerConstruction.GetConstructionByID(id);
            var dialog = MessageBox.Show(@"Deseja realmente deletar a construção  " + c.Name + " ?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    _manangerConstruction.Delete(c);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro: " + e.Message);
                }
                LoadDataGridConstructions();
            }
        }

        private void LowMaterials()
        {
            LoadDataTableConstruction();
            if (tbServent.Tables[1].Rows.Count <= 0)
            {
                MessageBox.Show("Para fazer uma movimentação de estoque para uma obra certifique-se que há pelo menos uma obra cadastrada no sistema.",
                    Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ultraGrid.Selected.Rows.Count == 0 || ultraGrid.Selected.Rows[0].IsGroupByRow)
                return;
            int id = 0;
            try
            {
                id = int.Parse((((DataRowView)ultraGrid.ActiveRow.ListObject).Row.ItemArray[0]).ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }

            MaterialsMovement movement = _manangerStock.GetMaterialMovByID(id);
            if (movement.Quantity <= 0)
            {
                MessageBox.Show("A quantidade do material selecionado é menor ou igual a zero.", Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FormMovMaterialsToConstruction formMovMaterialsToConstruction =
                new FormMovMaterialsToConstruction(tbServent.Tables[1], movement);
            int originalQuntity = movement.Quantity;



            if (formMovMaterialsToConstruction.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    bool ok = _manangerStock.LowStock(formMovMaterialsToConstruction.MaterialMov, id);
                    ok = ok &&
                         _manangerConstruction.AddNewHistoricalMovement(
                             formMovMaterialsToConstruction.ConstructionHistory,
                             formMovMaterialsToConstruction.ConstructionID);
                    if (!ok) throw new Exception("Erro ao dar baixa no material: " + movement.Material.Name);
                    LoadDataGridMaterials();
                    MessageBox.Show("Baixa efetuada com sucesso.", Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception e)
                {
                    //Se der exceção não alterar a quantidade do material...
                    MessageBox.Show("Erro: " + e.Message + " stackTrace: " + e.StackTrace);

                    movement.Quantity = originalQuntity;
                    _manangerStock.UpdateMaterial(movement);
                }
                UpdateMaterialsStatusBar();
            }
        }

        private void LoadDataTableConstruction()
        {
            tbServent.Tables[1].Clear();
            foreach (var m in _manangerConstruction.GetAllConstructions())
            {
                tbServent.Tables[1].Rows.Add(m.ID, m.Name, m.Address.ToString(), m.Responsible, m.ResponsiblePhone, m.IsAlive,
                    m.Description);
            }
        }

        private void UpdateConstruction()
        {
            if (ultraGrid.Selected.Rows.Count == 0 || ultraGrid.Selected.Rows[0].IsGroupByRow)
                return;
            int id = 0;
            try
            {
                id = int.Parse((((DataRowView)ultraGrid.ActiveRow.ListObject).Row.ItemArray[0]).ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }

            Construction construction = _manangerConstruction.GetConstructionByID(id);
            FormAddConstruction form = new FormAddConstruction(construction);

            if (form.ShowDialog() == DialogResult.OK)
            {
                _manangerConstruction.UpdateConstruction(form.Construction);
                LoadDataGridConstructions();
            }
        }

        private void ManangerUnits()
        {
            FormManangerUnits formManangerUnits = new FormManangerUnits();
            formManangerUnits.ShowDialog();
        }

        private void AddConstructions()
        {
            FormAddConstruction formAddConstruction = new FormAddConstruction();
            var retorno = formAddConstruction.ShowDialog();
            if (retorno != DialogResult.OK) return;
            _manangerConstruction.AddConstructions(formAddConstruction.Construction);
            LoadDataGridConstructions();
        }

        private void DeleteMaterial()
        {
            if (ultraGrid.Selected.Rows.Count == 0 || ultraGrid.Selected.Rows[0].IsGroupByRow)
                return;
            int id = 0;
            try
            {
                id = int.Parse((((DataRowView)ultraGrid.ActiveRow.ListObject).Row.ItemArray[0]).ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }

            MaterialsMovement movement = _manangerStock.GetMaterialMovByID(id);
            var dialog = MessageBox.Show("Deseja realmente deletar todos os materiais do tipo: " + movement.Material.Name + " ?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                _manangerStock.DeleteMaterialMov(movement);
                LoadDataGridMaterials();
            }
        }

        private void AddMaterials()
        {
            FormAddMaterials form = new FormAddMaterials(_manangerStock.GetAllUnitTypes());
            var dialogResul = form.ShowDialog();
            switch (dialogResul)
            {
                case DialogResult.OK:
                    {
                        MaterialsMovement materialsMovement = form.MaterialsMovement;
                        _manangerStock.AddMaterialToStock(materialsMovement);
                        LoadDataGridMaterials();
                    }
                    break;
            }

            UpdateMaterialsStatusBar();
        }

        private void UpdateMaterial()
        {
            if (ultraGrid.Selected.Rows.Count == 0 || ultraGrid.Selected.Rows[0].IsGroupByRow)
                return;
            int id = 0;
            try
            {
                id = int.Parse((((DataRowView)ultraGrid.ActiveRow.ListObject).Row.ItemArray[0]).ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }

            MaterialsMovement movement = _manangerStock.GetmaterialByID(id);
            FormAddMaterials form = new FormAddMaterials(movement, _manangerStock.GetAllUnitTypes())
            {
                Text = "Edição de Materiais"
            };

            form.ShowDialog();
            if (form.DialogResult != DialogResult.OK) return;
            _manangerStock.UpdateMaterial(form.MaterialsMovement);
            LoadDataGridMaterials();

        }

        private void LoadDataGridMaterials()
        {
            tbServent.Tables[0].Clear();
            foreach (var m in _manangerStock.GetAllMaterialsMov())
            {
                try
                {
                    if (!m.IsFromStock)
                    {
                        tbServent.Tables[0].Rows.Add(m.ID, m.Material.Name, m.Quantity, m.Material.TypeOfUnit.Name, "R$ " + m.Material.Price,
                            m.DateOfMovement.ToShortDateString(), "R$ " + m.TotalBalance, m.Material.Description);
                    }
                }
                catch (Exception e)
                {
                    TraceHelper.WriteInEventVwr(e.Message, EventLogEntryType.Error);
                }
            }
            ultraGrid.DataSource = tbServent.Tables[0];

            ultraGrid.DisplayLayout.Bands[0].Columns[7].Width = 250;
            if (tbServent.Tables[0].Rows.Count < 1) return;
            ultraGrid.Rows[0].Selected = true;
            ultraGrid.ActiveRow = ultraGrid.Rows[0];
            UpdateMaterialsStatusBar();
        }

        private void LoadDataGridConstructions()
        {
            tbServent.Tables[1].Clear();
            foreach (var m in _manangerConstruction.GetAllConstructions())
            {
                tbServent.Tables[1].Rows.Add(m.ID, m.Name, m.Address.ToString(), m.Responsible, m.ResponsiblePhone, m.IsAlive,
                    m.Description);
            }
            ultraGrid.DataSource = tbServent.Tables[1];
            ultraGrid.DisplayLayout.Bands[0].Columns[6].Width = 250;
            ultraGrid.DisplayLayout.Bands[0].Columns[2].Width = 250;
            ultraGrid.DisplayLayout.Bands[0].Columns[1].Width = 250;
            if (tbServent.Tables[1].Rows.Count < 1) return;
            ultraGrid.Rows[0].Selected = true;
            ultraGrid.ActiveRow = ultraGrid.Rows[0];
            UpdateConstructionStatusBar();
        }

        private void UpdateMaterialsStatusBar()
        {
            toolStripStatusLabel1.Text = "Valor total de estoque:";
            lblValue.Text = String.Format("{0:c}", _manangerStock.GetTotalValueInStock());
            
        }

        private void UpdateConstructionStatusBar()
        {
            toolStripStatusLabel1.Text = "Total de obras gerenciadas: ";
            lblValue.Text = _manangerConstruction.GetAllConstructions().Count().ToString(CultureInfo.InvariantCulture);

        }

        #endregion 

        #region Events
        private void toolbarsManager_ToolClick(object sender, ToolClickEventArgs e)
        {
            switch (e.Tool.Key)
            {
                case "btnAddMaterials":
                    AddMaterials();
                    break;

                case "btnUpdateMaterial":
                    UpdateMaterial();
                    break;

                case "btnDelete":
                    DeleteMaterial();
                    break;

                case "btnMananger":
                    ManangerUnits();
                    break;

                case "btnLow":
                    LowMaterials();
                    break;

                //Construções
                case "btnAddConstruction":
                    AddConstructions();
                    break;

                case "btnUpdateConstruction":
                    UpdateConstruction();
                    break;

                case "btnDeleteConstruction":
                    DeleteConstruction();
                    break;

                case "btnAddMaterialFromStore":
                    FormAddMaterialFromStore();
                    break;

                case "btnHistoric":
                    ViewHistoric();
                    break;

                //File Menu
                case "btnExit":
                    Application.Exit();
                    break;

                case "btnServer":
                    ServerConfig();
                    break;
            }
        }

        private void toolbarsManager_AfterRibbonTabSelected(object sender, RibbonTabEventArgs e)
        {
            switch (toolbarsManager.Ribbon.SelectedTab.Index)
            {
                case 0:
                    LoadDataGridMaterials();
                    break;

                case 1:
                    LoadDataGridConstructions();
                    break;
            }
        }

        private void FormAdministration_Load(object sender, EventArgs e)
        {
            toolbarsManager.Ribbon.ApplicationMenu.ToolAreaRight.MaxWidth = 1;
            toolbarsManager.Ribbon.ApplicationMenu.ToolAreaRight.Settings.Appearance.BackColor = Color.WhiteSmoke;
            ultraGrid.DisplayLayout.GroupByBox.Prompt = "Arraste uma coluna aqui para agrupar.";
        }

        private void ultraGrid_DoubleClickRow(object sender, Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs e)
        {
            var row = ultraGrid.Rows.First(x => x.IsActiveRow);

            if (row != null && row.Cells.Count > 0)
            {
                switch (toolbarsManager.Ribbon.SelectedTab.Index)
                {
                    case 0:
                        UpdateMaterial();
                        break;

                    case 1:
                        UpdateConstruction();
                        break;
                }
            }
        }
        #endregion
    }
}