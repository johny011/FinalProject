﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Final_project
{
    public partial class View_account : Form
    {
        public View_account()
        {
            InitializeComponent();
            
        }

        private void View_account_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitallDataSet32.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.hospitallDataSet32.users);

        }
    }
}
