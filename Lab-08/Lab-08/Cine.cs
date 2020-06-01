using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
    class Cine:Local
    {
        protected int rooms;

        public void SetRooms(int rooms)
        {
            this.rooms = rooms;
        }

        public override string GetLocal()
        {
            return ("Local: " + name + "\n" + "Owner: " + owner + "\n" + "Numero ID: " + shopID + "\n" + "Horarios: " + openHours + "\n" + "Total salas de cine: " + rooms + "\n");
        }
    }
}
