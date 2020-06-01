using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
    class Restaurant:Local
    {
        protected bool excTables;

        public void SetTables(bool tab)
        {
            this.excTables = tab;
        }

        public override string GetLocal()
        {
            if (excTables)
            {
                return ("RESTAURANT" + "\n" + "Local: " + name + "\n" + "Owner: " + owner + "\n" + "Numero ID: " + shopID + "\n" + "Horarios: " + openHours + "\n" + "Mesas exclusivas: Si" + "\n");
            }
            else
            {
                return ("RESTAURANT" + "\n" + "Local: " + name + "\n" + "Owner: " + owner + "\n" + "Numero ID: " + shopID + "\n" + "Horarios: " + openHours + "\n" + "Mesas exclusivas: No" + "\n");

            }
        }
    }
}
