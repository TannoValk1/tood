using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string text;
        private List<string> ReadFromFile = new List<string>();
        DataTable table = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text + ".txt";
            text = name;
            var K = new List<string>();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                var result = "";
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        result = result + dataGridView1.Rows[i].Cells[j].Value.ToString();
                        result = result + " / ";
                    }
                    else
                    {
                        result = result + "null";
                        result = result + " / ";
                    }
                }
                K.Add(result);
            }
            using (StreamWriter sr = new StreamWriter(text))
            {
                foreach (string M in K)
                {
                    sr.WriteLine(M);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog diag = new FolderBrowserDialog())
            {
                if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    textBox2.Text = diag.SelectedPath;
                }
                else
                {
                    Console.WriteLine("You didn t select the folder");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines($@"C:/Users/mihke/OneDrive/Desktop/TARpe23/Homework/HomeWork_w12/HomeWork_W12_ex1/HomeWork_W12_ex1/bin/Debug/eee.txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('/');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                dataGridView1.Rows.Add(row);
            }
        }
        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show($"An error occurred while processing data: {e.Exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            e.ThrowException = false;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataError += DataGridView1_DataError;
        }
    }
}