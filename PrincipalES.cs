﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerprintNetSample
{
    public partial class PrincipalES : Form
    {
        public PrincipalES()
        {
            InitializeComponent();
        }

        private void PrincipalES_Load(object sender, EventArgs e)
        {
            RegistrosES frm = new RegistrosES();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
