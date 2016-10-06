using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servent.Domain
{
    public  class MaterialsMovement
    {
        private int _id;
        private DateTime _dateOfMovement;
        private  Material _material;
        private int _quantity;
        private double _totalBalance;
        private bool _isFromStock;

        public MaterialsMovement(DateTime dateOfMovement, Material materials, int id, Provider origin, double totalBalance,int qtd)
        {
            DateOfMovement = dateOfMovement;
            Material = materials;
            ID = id;
            TotalBalance = totalBalance;
            _quantity = qtd;

        }

        public MaterialsMovement()
        {
            TotalBalance = 0;
            _dateOfMovement = DateTime.Now;
            Material = new Material();
        }
        
        public DateTime DateOfMovement
        {
            get { return _dateOfMovement; }
            set { _dateOfMovement = value; }
        }

        public  Material Material
        {
            get { return _material; }
            set { _material = value; }
        }
         [Column(TypeName = "int")]
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

         [Column(TypeName = "int")]
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public double TotalBalance
        {
            get { return _totalBalance; }
            set { _totalBalance = value; }
        }
        public bool IsFromStock
        {
            get { return _isFromStock; }
            set { _isFromStock = value; }
        }
    }
}
