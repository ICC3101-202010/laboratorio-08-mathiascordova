using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_08
{
    public partial class Form1 : Form
    {

        Tienda store = new Tienda();
        Cine cine = new Cine();
        Restaurant resto = new Restaurant();
        Recrea rec = new Recrea();
        List<Local> allLocales = new List<Local>() {  };
        
        public Form1()
        {
            InitializeComponent();
            store.SetLocal("Jumbo", "Horst Paulmann", "123", "8:00-22:00");
            store.SetCat(new List<string>() { "Alimentos", "Electrodomesticos", "Papeleria", "Limpieza" });
            cine.SetLocal("Cine Hoyts", "Mathias Cordova", "420", "10:30-00:00");
            cine.SetRooms(6);
            resto.SetLocal("McDonalds", "Ronald McDonalds", "343", "24/7");
            resto.SetTables(true);
            rec.SetLocal("Snip Snap", "Edward Scissorhands", "999", "10:00-18:00");
            rec.SetType("Peluqueria");
            allLocales.Add(store);
            allLocales.Add(cine);
            allLocales.Add(resto);
            allLocales.Add(rec);

        }

        

        
        private void createLocal_Click(object sender, EventArgs e)
        {
            
            panelCreate.Visible = true;
        }

        private void buscarLocal_Click(object sender, EventArgs e)
        {
            panelBusq.Visible = true;
            
        }

        private void verLocales_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            string loc = "";
            for (int i = 0; i < allLocales.Count(); i++)
            {
                loc += (i + 1) + ". " + allLocales[i].GetName() + "\n";
            }
            form2.GetLoc(loc);
            form2.Show();
        }

        private void salirCreate_Click(object sender, EventArgs e)
        {
            
            panelCreate.Visible = false;
        }

        private void crearTienda_Click(object sender, EventArgs e)
        {
            panelTienda.Visible = true;
        }

        private void crearCine_Click(object sender, EventArgs e)
        {
            panelCine.Visible = true;
        }

        private void crearRest_Click(object sender, EventArgs e)
        {
            panelResto.Visible = true;
        }

        private void crearRec_Click(object sender, EventArgs e)
        {
            panelRec.Visible = true;
        }

        private void nameEnter_Click(object sender, EventArgs e)
        {
            busqTB.Visible = true;
            bool found = false;
            int position = 0;
            string search = busqNombre.Text;
            for (int i =0; i < allLocales.Count(); i++)
            {
                if (search == allLocales[i].GetName())
                {
                    found = true;
                    position = i;
                }
            }
            if (found)
            {
                busqTB.Text = allLocales[position].GetLocal();
            }
            else if(found==false&&search!="")
            {
                busqTB.Text = "No se encontro ningun local con ese nombre";
            }
            else
            {
                busqTB.Text = "Por favor ingrese un nombre en el buscador";
            }
            busqNombre.Text = "";
        }

        private void busqBack_Click(object sender, EventArgs e)
        {
            busqNombre.Text = "";
            busqTB.Visible = false;
            busqTB.Text = "";
            panelBusq.Visible = false;
        }

        private void CreateTiendaEnter_Click(object sender, EventArgs e)
        {
            if (tbTiendaName.Text == "" || tbTiendaOwner.Text == "" || tbTiendaID.Text == "" || tbTiendaHor.Text == "" || tbTiendaCat.Text == "")
            {
                labelTiendaCr.Visible = true;
                labelTiendaCr.Text = "LLENE TODOS LOS CAMPOS";
            }
            else
            {
                labelTiendaCr.Visible = true;
                labelTiendaCr.Text = "TIENDA CREADA CON EXITO";
                Tienda tienda = new Tienda();
                tienda.SetLocal(tbTiendaName.Text, tbTiendaOwner.Text, tbTiendaID.Text, tbTiendaHor.Text);
                tienda.SetCat(new List<string>() { tbTiendaCat.Text });
                allLocales.Add(tienda);
                tbTiendaName.Text = "";
                tbTiendaOwner.Text = "";
                tbTiendaID.Text = "";
                tbTiendaHor.Text = "";
                tbTiendaCat.Text = "";
            }
        }

        private void backCrTienda_Click(object sender, EventArgs e)
        {
            tbTiendaName.Text = "";
            tbTiendaOwner.Text = "";
            tbTiendaID.Text = "";
            tbTiendaHor.Text = "";
            tbTiendaCat.Text = "";
            labelTiendaCr.Visible = false;
            labelTiendaCr.Text = "";
            panelTienda.Visible = false;
        }

        private void btEnterCine_Click(object sender, EventArgs e)
        {
            if (tbCineID.Text == "" || tbCineName.Text== ""|| tbCineOwner.Text == ""|| tbCineHor.Text == ""|| tbCineSalas.Text == "")
            {
                labelCine.Visible = true;
                labelCine.Text = "LLENE TODOS LOS CAMPOS";
            }
            else
            {
                labelCine.Visible = true;
                labelCine.Text = "CINE CREADO CON EXITO";
                Cine cine = new Cine();
                cine.SetLocal(tbCineName.Text, tbCineOwner.Text, tbCineID.Text, tbCineHor.Text);
                cine.SetRooms(Convert.ToInt32(tbCineSalas.Text));
                allLocales.Add(cine);
                tbCineName.Text = "";
                tbCineOwner.Text = "";
                tbCineID.Text = "";
                tbCineHor.Text = "";
                tbCineSalas.Text = "";
            }
        }

        private void BackCine_Click(object sender, EventArgs e)
        {
            labelCine.Text = "";
            labelCine.Visible = false;
            tbCineName.Text = "";
            tbCineOwner.Text = "";
            tbCineID.Text = "";
            tbCineHor.Text = "";
            tbCineSalas.Text = "";
            panelCine.Visible = false;
        }

        private void RestEnter_Click(object sender, EventArgs e)
        {
            if (tbRestName.Text == "" || tbRestOwner.Text == "" || tbRestID.Text == "" || tbRestHor.Text == "")
            {
                labelRest.Visible = true;
                labelRest.Text = "LLENE TODOS LOS CAMPOS";
            }
            else
            {
                labelRest.Visible = true;
                labelRest.Text = "RESTAURANT CREADO CON EXITO";
                Restaurant res = new Restaurant();
                res.SetLocal(tbRestName.Text, tbRestOwner.Text, tbRestID.Text, tbRestHor.Text);
                res.SetTables(cbRestExc.Checked);
                allLocales.Add(res);
                tbRestName.Text = "";
                tbRestOwner.Text = "";
                tbRestID.Text = "";
                tbRestHor.Text = "";
                cbRestExc.Checked = false;
            }
            
        }

        private void RestBack_Click(object sender, EventArgs e)
        {
            panelResto.Visible = false;
            tbRestName.Text = "";
            tbRestOwner.Text = "";
            tbRestID.Text = "";
            tbRestHor.Text = "";
            labelRest.Text = "";
            labelRest.Visible = false;
            cbRestExc.Checked = false;
            panelResto.Visible = false;
        }

        private void BackRec_Click(object sender, EventArgs e)
        {
            panelRec.Visible = false;
            labelRec.Text = "";
            labelRec.Visible = false;
            tbRecName.Text = "";
            tbRecOwner.Text = "";
            tbRecID.Text = "";
            tbRecHor.Text = "";
            tbRecType.Text = "";
        }

        private void EnterRec_Click(object sender, EventArgs e)
        {
            if (tbRecName.Text == "" || tbRecOwner.Text == "" || tbRecID.Text == "" || tbRecHor.Text == "" || tbRecType.Text == "")
            {
                labelRec.Visible = true;
                labelRec.Text = "LLENE TODOS LOS CAMPOS";
            }
            else
            {
                labelRec.Visible = true;
                labelRec.Text = "RECREACIONAL CREADO CON EXITO";
                Recrea rec = new Recrea();
                rec.SetLocal(tbRecName.Text, tbRecOwner.Text, tbRecID.Text, tbRecHor.Text);
                rec.SetType(tbRecType.Text);
                allLocales.Add(rec);
                tbRecName.Text = "";
                tbRecOwner.Text = "";
                tbRecID.Text = "";
                tbRecHor.Text = "";
                tbRecType.Text = "";
            }
        }
    }
}
