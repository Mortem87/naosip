﻿using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_naosip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<MODEL.Articulo> lst_articulos = BUSSINES.Articulo.ObtenerArticulos();
            
            dgv_articulos.DataSource = lst_articulos;

        }
    }
}
