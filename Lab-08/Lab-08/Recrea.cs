using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
    class Recrea:Local
    {
        protected string recType;

        public void SetType(string type)
        {
            this.recType = type;
        }

        public override string GetLocal()
        {
            return ("RECREACIONAL"+"\n"+"Local: " + name + "\n" + "Owner: " + owner + "\n" + "Numero ID: " + shopID + "\n" + "Horarios: " + openHours + "\n" + "Tipo de recreacional:" + recType + "\n");
        }
    }
}
