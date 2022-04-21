using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportSalesCoffee
{
    public partial class Food : Form
    {
        public Food()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
            Form2 form2 = new Form2();
            form2.Visible = true;
        }

        

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);
                string readAllText = File.ReadAllText(openFileDialog.FileName);

                for (int i = 2; i < readAllLine.Length; i++)
                {
                    string classfoodRAW = readAllLine[i];
                    string[] classfoodSplited = classfoodRAW.Split(',');
                    ClassFood classFood = new ClassFood(classfoodSplited[0], classfoodSplited[1], classfoodSplited[2], classfoodSplited[3]);
                    addDataToGridView(classfoodSplited[0], classfoodSplited[1], classfoodSplited[2], classfoodSplited[3]);
                }
            }
        }
        void addDataToGridView(string num, string name, string pirce, string date)
        {
            this.dataGridView1.Rows.Add(new string[] { num, name, pirce, date });
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filepath = string.Empty;
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV(*.csv)|*.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCSV[0] += columnNames;
                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCSV[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            File.WriteAllLines(sfd.FileName, outputCSV, Encoding.UTF8);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = textBoxNum.Text;
            dataGridView1.Rows[n].Cells[1].Value = comboBox1.Text + comboBox2.Text;
            dataGridView1.Rows[n].Cells[2].Value = textBoxAmount.Text;
            dataGridView1.Rows[n].Cells[3].Value = dateTimePicker1.Text;
            textBoxNum.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBoxAmount.Text = "";
        }
    }
}
