using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Servent.Domain;

namespace Servent.UI.Forms
{
    public partial class FormMovMaterialsToConstruction : Form
    {
        private MaterialsMovement _movement;
        private ConstructionHistory _constructionHistory;
        private int _qtd;
        private int _constructionID;
        

        public FormMovMaterialsToConstruction()
        {
            InitializeComponent();
            
        }

        public FormMovMaterialsToConstruction(DataTable dataTable, MaterialsMovement movement)
        {
            InitializeComponent();
            this.dataTable = dataTable;
            /*this.MaterialMov = new MaterialsMovement(DateTime.Now, new Material(0, movement.Material.Name, movement.Material.Price, movement.Material.Description, new UnitType() { Description = movement.Material.TypeOfUnit.Description, Name = movement.Material.TypeOfUnit.Name})
                , 0, null, movement.TotalBalance, movement.Quantity);*/
            this.MaterialMov =new MaterialsMovement(){DateOfMovement = DateTime.Now,Material = (Material) movement.Material.Clone(),Quantity = movement.Quantity,IsFromStock = true};
            cmbConstructions.DataSource = this.dataTable;
            cmbConstructions.DisplayMember = this.dataTable.Columns[1].ToString();
            nudQtd.Maximum = MaterialMov.Quantity;
            txbMaterialName.Text = MaterialMov.Material.Name;
            txbValuePerunit.Text = MaterialMov.Material.Price.ToString();
            _qtd = movement.Quantity;
            _constructionHistory = new ConstructionHistory();
        }

        private void button2_Click(object sender, EventArgs e)
        {  
            // TODO: Arrumar uma opção de ativar e desativar obra
            if (int.Parse(nudQtd.Text) <= 0)
            {
                MessageBox.Show("Por favor, informe uma quantidade a ser movimentada  para a obra.",Text,MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            _constructionHistory.MaterialsMovements = _movement;
            _constructionHistory.MaterialsMovements.IsFromStock = true;
            _constructionHistory.Provider = null;
            _constructionID = Convert.ToInt32(cmbConstructions.SelectedRow.Cells[0].Value);
            DialogResult = DialogResult.OK;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            txbTotalValue.Text = (((NumericUpDown)sender).Value * (decimal)_movement.Material.Price).ToString();
            _movement.TotalBalance = (double) (((NumericUpDown) sender).Value*(decimal) _movement.Material.Price);
            _movement.Quantity = (int) ((NumericUpDown) sender).Value;
        }

        public ConstructionHistory ConstructionHistory
        {
            get { return _constructionHistory; }
            set { _constructionHistory = value; }
        }

        public int ConstructionID
        {
            get { return _constructionID; }
            set { _constructionID = value; }
        }

        private IEnumerable<Control> GetAllComponents<T>(Control control)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(GetAllComponents<T>)
                                      .Concat(controls)
                                      .Where(c => c.GetType() == typeof(T)).ToList();
        }

        public MaterialsMovement MaterialMov
        {
            get { return _movement; }
            set { _movement = value; }
        }
        
    }
}
