using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.ComponentModel.DataAnnotations;

namespace Servent.Domain
{
    public class Material:ICloneable
    {

        #region Fields

        private int _id;
        private string _name;
        private double _price;
        private string _description;
        private UnitType _typeOfUnit;
        
        #endregion

        #region Ctrs

        public Material(int id, string name, double price, string description, UnitType typeOfUnit)
        {
            ID = id;
            Name = name;
            Price = price;
            Description = description;
            TypeOfUnit = typeOfUnit;
        }

        public Material()
        {
            ID = 0;
            Name = string.Empty;
            Price = 0;
            Description = string.Empty;
            TypeOfUnit = new UnitType();
        }

        #endregion

        #region  Properties
         [Column(TypeName = "int")]
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        [Column(TypeName = "varchar")]
        [MaxLength(250)]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public UnitType TypeOfUnit
        {
            get { return _typeOfUnit; }
            set { _typeOfUnit = value; }
        }

        

        #endregion
        
        #region Override Methods

        public override string ToString()
        {
            return Name;
        }

        #endregion


        public object Clone()
        {
            return new Material
                   {
                       ID = 0,
                       Name = _name,
                       Price = _price,
                       Description = _description,
                       TypeOfUnit = _typeOfUnit
                   };
        }
    }
}
