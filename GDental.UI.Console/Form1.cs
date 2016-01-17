using GDental.Core.Data;
using GDental.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDental.UI.Console
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (var ctx = new GDentalContext())
            {
                Empresa emp = new Empresa() {
                    ChaveApi = "",
                    Cnpj = "83.756.386/0001-93",
                    CroResponsavel = "123456",
                    FimExpediente = "18:00",
                    InicioExpediente = "08:00",
                    NomeFantasia = "Dentitas SA",
                    RazaoSocial = "Dentistas SA"
                    


                };

                ctx.Empresas.Add(emp);
                ctx.SaveChanges();
            }
           
        }
    }
}
