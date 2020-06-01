using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
    class Tienda:Local
    {
        protected List<string> categories = new List<string> ();

        public void SetCat(List<string> cats)
        {
            this.categories = cats;
        }

        public override string GetLocal()
        {
            string cats = "";

            for (int i = 0; i < categories.Count(); i++)
            {
                if (i == categories.Count() - 1)
                {
                    cats += categories[i];
                }
                else
                {
                    cats += categories[i] + ", ";
                }
            }

            return ("TIENDA"+"\n"+"Local: " + name + "\n" + "Owner: " + owner + "\n" + "Numero ID: " + shopID + "\n" + "Horarios: " + openHours + "\n" + "Tienda de: " + cats+ "\n");
        }
    }
}
