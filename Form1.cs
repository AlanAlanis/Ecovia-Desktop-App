using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ecovia.REST;
using Newtonsoft.Json;
using Ecovia.Models;
using DevExpress.XtraBars.Navigation;

namespace Ecovia
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Form1()
        {
            InitializeComponent();

            GridControl();
        }

        public void GridControl()
        {
            Client<object> restClient = new Client<object>();
            restClient.endPoint = Constantes.EndPoint.TowaRevenue.proyectos;
            var jsonResponse = JsonConvert.DeserializeObject<Client<Model.Proyecto>.Struct>(restClient.makeRequest());
            gridControl1.DataSource = jsonResponse.data;
        }

        private void fluentDesignFormControl1_Click(object sender, EventArgs e)
        {

        }



        ////
        //AccordionControlElement item = new AccordionControlElement() { Text = "Rutas", Style = ElementStyle.Item };
        //accordionControl1.Elements.Add(item);

    }
}
