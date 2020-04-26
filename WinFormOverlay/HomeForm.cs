﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormOverlay
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 160 || m.Msg == 13)
            {
                LoadingForm.Current?.BringToFront();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            LoadingForm.Start(this);
            //try
            //{
            //    LoadingForm.Start(this);
            //    SqlConnection _Connection = new SqlConnection("Server=167.86.104.233;Database=Paiements;User Id=sa;Password=myPassword;");
            //    await _Connection.OpenAsync();
            //    LoadingForm.Stop();
            //    if (_Connection.State == ConnectionState.Open)
            //    {
            //        Debug.WriteLine("Opened");
            //    }
            //}
            //catch (Exception _Ex)
            //{
            //    LoadingForm.Stop();
            //    Debug.WriteLine(_Ex.Message);
            //}
        }
    }
}
