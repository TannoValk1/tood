using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_Click);
            this.Cursor = new Cursor(Cursor.Current.Handle);
            int posX = Cursor.Position.X;
            int posY = Cursor.Position.Y;

            label1.Text = $"Coordinates: {posX},{posY}";
        }

        private void label1_Click()
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}