﻿using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace AdminBackups
{
    public partial class MakeBackups : Form
    {
        string path;
        DateTime date;
        int amount;
        string Type;
        public MakeBackups()
        {
            InitializeComponent();

            progressBar1.Minimum = 0;

            timer1.Start();
            timer2.Stop();
        }

        //NotifyIcon
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            niMakingBackups.Visible = true;
        }

        //Resize
        private void MakeBackups_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                niMakingBackups.Visible = true;
            }
        }

        //Select folder
        private void btnFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();

            diag.ShowDialog();

            path = diag.SelectedPath.ToString();
        }

        //Make backup
        private void btnStartMakingBackups_Click(object sender, EventArgs e)
        {
            try
            {
                amount = Convert.ToInt32(tbAmount.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a int.");
                return;
            }

            if (rbMinutes.Checked == true)
            {
                date = DateTime.Now.AddMinutes(amount);
                progressBar1.Value = 0;
                progressBar1.Maximum = amount * 60;
                Type = "Minute";
            }
            else if (rbHours.Checked == true)
            {
                date = DateTime.Now.AddHours(amount);
                progressBar1.Value = 0;
                progressBar1.Maximum = amount * 60 *60;
                Type = "Hours";
            }
            else if (rbDays.Checked == true)
            {
                date = DateTime.Now.AddDays(amount);
                progressBar1.Value = 0;
                progressBar1.Maximum = amount * 60 * 60 * 24;
                Type = "Days";
            }

            timer2.Start();
        }

        //Timers
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (rbMinutes.Checked == true)
            {
                labAmount.Text = "Minutes: ";
            }
            else if (rbHours.Checked == true)
            {
                labAmount.Text = "Hours: ";
            }
            else if (rbDays.Checked == true)
            {
                labAmount.Text = "Days: ";
            }
            tbFolder.Text = path;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(path))
            {
                timer2.Stop();
                MessageBox.Show("Please select a folder.");
                return;
            }

            if (Type == "Minute")
            {
                if (progressBar1.Value != amount * 60 - 1)
                {
                    progressBar1.Value++;
                }
            }
            else if (Type == "Hours")
            {
                if (progressBar1.Value != amount * 60 * 60 - 1)
                {
                    progressBar1.Value++;
                }
            }
            else if (Type == "Days")
            {
                if (progressBar1.Value != amount * 60 *60 * 24 - 1)
                { 
                    progressBar1.Value++;
                }
            }

            if (DateTime.Now >= date)
            {
                progressBar1.Value++;

                string FileLocation = path + @"\Database-" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss"); ;

                string constring = "Server=studmysql01.fhict.local;Uid=dbi461266;Database=dbi461266;Pwd=Nijlpaard;SslMode =none;";

                using (MySqlConnection conn = new MySqlConnection(constring))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(FileLocation);
                            conn.Close();
                        }
                    }
                }
                progressBar1.Value = 0;

                if (rbMinutes.Checked == true)
                {
                    date = DateTime.Now.AddMinutes(amount);
                }
                else if (rbHours.Checked == true)
                {
                    date = DateTime.Now.AddHours(amount);
                }
                else if (rbDays.Checked == true)
                {
                    date = DateTime.Now.AddDays(amount);
                }
            }
        }
    }
}
