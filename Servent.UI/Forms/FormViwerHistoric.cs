using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Servent.BLL;
using Servent.Domain;

namespace Servent.UI.Forms
{
    public partial class FormViwerHistoric : Form
    {
        private Domain.Construction _construction;
        private ManangerConstruction _manangerConstruction;
        private DataTable _dataTable;
        public FormViwerHistoric(Construction construction, DataTable dataTable)
        {
            _construction = construction;
            InitializeComponent();
            txbName.Text = construction.Name;
            txbTotal.Text = construction.GetTotalBalance().ToString(CultureInfo.InvariantCulture);
            _manangerConstruction = new ManangerConstruction();
            _dataTable = dataTable;
            LoadDataGrid(_dataTable);
        }

        private void LoadDataGrid(DataTable dataTable)
        {
            gridHistoric.DataSource = dataTable;
        }

        private void LoadDataGrid(Construction construction)
        {
            _dataTable.Clear();
            foreach (var m in construction.ConstructionHistory)
            {
                if (m.Provider != null && m.Provider.Name != string.Empty)
                    _dataTable.Rows.Add(m.ID, m.Provider.Name, m.Provider.PhoneNumber, m.MaterialsMovements.Material.Name, m.MaterialsMovements.DateOfMovement, m.MaterialsMovements.Quantity,
                        m.MaterialsMovements.TotalBalance);
                else
                    _dataTable.Rows.Add(m.ID, "Estoque", "         -              ", m.MaterialsMovements.Material.Name, m.MaterialsMovements.DateOfMovement, m.MaterialsMovements.Quantity,
                    m.MaterialsMovements.TotalBalance);
            }
            txbTotal.Text = construction.GetTotalBalance().ToString(CultureInfo.InvariantCulture);
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            if (gridHistoric.Selected.Rows.Count == 0 || gridHistoric.Selected.Rows[0].IsGroupByRow)
                return;
            int id = 0;
            try
            {
                id = int.Parse((((DataRowView)gridHistoric.ActiveRow.ListObject).Row.ItemArray[0]).ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            ConstructionHistory constructionHistory;
            try
            {
                 constructionHistory = _construction.ConstructionHistory.Find(history => history.ID == id);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao buscar id da movimentação de materiais.");
            }

            DialogResult dialogResult = MessageBox.Show("Deseja realmente deletar a seguinte movimentação de materiais:\n"+constructionHistory,"Confirmação",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult ==  DialogResult.Yes)
            {
                _construction.ConstructionHistory.Remove(constructionHistory);
                _manangerConstruction.UpdateConstruction(_construction);
                LoadDataGrid(_construction);
            }
        }
    }
}
