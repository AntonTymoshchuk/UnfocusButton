using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnfocusButton
{
    public partial class Form1 : Form
    {
        NoFocusCueButton button;
        NoFocusCueButton button1;
        public Form1()
        {
            InitializeComponent();

            button = new NoFocusCueButton();
            button.TabStop = true;
            button.Location = new Point(20, 20);
            button.Size = new Size(120, 60);
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = Color.FromArgb(100, 100, 100);
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 120, 120);
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(140, 140, 140);
            button.FlatAppearance.BorderSize = 0;
            button.Font = new Font("Calibri", 12);
            button.ForeColor = Color.White;
            button.Text = "Button";
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.GotFocus += Button_GotFocus;
            button.LostFocus += Button_LostFocus;
            this.Controls.Add(button);

            button1 = new NoFocusCueButton();
            button1.TabStop = true;
            button1.Location = new Point(20, 120);
            button1.Size = new Size(120, 60);
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.FromArgb(100, 100, 100);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 120, 120);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(140, 140, 140);
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Calibri", 12);
            button1.ForeColor = Color.White;
            button1.Text = "Button";
            button1.TextAlign = ContentAlignment.MiddleCenter;
            button1.MouseClick += Button1_MouseClick;
            button1.GotFocus += Button_GotFocus;
            button1.LostFocus += Button_LostFocus;
            this.Controls.Add(button1);
        }

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(file.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                Process.Start(openFileDialog.FileName); 
        }

        private void Button_GotFocus(object sender, EventArgs e)
        {
            NoFocusCueButton ibutton = sender as NoFocusCueButton;
            ibutton.BackColor = Color.FromArgb(140, 140, 140);
        }

        private void Button_LostFocus(object sender, EventArgs e)
        {
            NoFocusCueButton ibutton = sender as NoFocusCueButton;
            ibutton.BackColor = Color.FromArgb(100, 100, 100);
        }
    }
}
