using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servent.BLL;
using Servent.Domain;

namespace ServentConsoleApplication
{
    static class Program
    {
        static ManangerStock manangerStock = new ManangerStock();
        static ManangerConstruction _construction = new ManangerConstruction();
        static void Main(string[] args)
        {
            string pad = "12";
            pad = pad.PadLeft(3, '0');

           AddMov();
            AddConstruction();
            //   List<MaterialsMovement> allMaterialsMov = manangerStock.GetAllMaterialsMov();
        }

        private static void AddConstruction()
        {
            ManangerConstruction manangerConstruction = new ManangerConstruction();

            Construction construction = new Construction();
            construction.Name = "Girassol Madeiras";
            construction.Responsible = "Tiririca";
            construction.IsAlive = true;
            construction.Address = new Address("Alberto dos Santos","Santa Helena",589,"Prox. Ilza amaral");
            construction.Description = "Construção no bairro santa helena, rua alberto dos santos";
            manangerConstruction.AddConstructions(construction);
        }
        private static void AddMov()
        {

            for (int i = 0; i < 100; i++)
            {
                MaterialsMovement materialsMovement = new MaterialsMovement();
                materialsMovement.Material = new Material()
                                             {
                                                 Description = "teste description",
                                                 Name = "teste" + i,
                                                 Price = 10+i,
                                                  TypeOfUnit = new UnitType(){ Name = "Randon unit"+i}
                                             };

                materialsMovement.Quantity = 10+i;
                // materialsMovement.TotalBalance = 89;
                materialsMovement.DateOfMovement = DateTime.Now.AddDays(i);
                manangerStock.AddMaterialToStock(materialsMovement);
            }
        }
    }
}
