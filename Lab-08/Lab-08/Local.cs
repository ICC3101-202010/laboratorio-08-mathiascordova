using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
    class Local
    {
        protected string name;
        protected string owner;
        protected string shopID;
        protected string openHours;

        public void SetLocal(string name, string owner, string ID, string hour)
        {
            this.name = name;
            this.owner = owner;
            this.shopID = ID;
            this.openHours = hour;
        }

        public virtual string GetLocal()
        {
            return ("Local: " + name + "\n" + "Owner: " + owner + "\n" + "Numero ID: " + shopID + "\n" + "Horarios: " + openHours);
        }

        public string GetName()
        {
            return name;
        }
    }
}
