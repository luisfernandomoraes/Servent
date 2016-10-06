using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servent.Domain
{
    public class ConstructionHistory
    {
        private int _id;
        private MaterialsMovement _materialsMovements;
        private Provider _provider;

        public ConstructionHistory(MaterialsMovement materialsMovement, int id, Provider provider)
        {
            MaterialsMovements = materialsMovement;
            ID = id;
            Provider = provider;
        }

        public ConstructionHistory()
        {
            Provider = new Provider();
            _materialsMovements = new MaterialsMovement();
        }

        public  MaterialsMovement MaterialsMovements
        {
            get { return _materialsMovements; }
            set { _materialsMovements = value; }
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
    
        public Provider Provider
        {
            get { return _provider; }
            set { _provider = value; }
        }

        public override string ToString()
        {
            return string.Format("Nome: {0}\nQuantidade: {1}\nFornecedor: {2}\nData de movimentação: {3}",
                _materialsMovements.Material.Name, _materialsMovements.Quantity,(Provider == null || Provider.Name == "" ? "Estoque" : Provider.Name),
                _materialsMovements.DateOfMovement.ToString("d"));
        }
    }
}
