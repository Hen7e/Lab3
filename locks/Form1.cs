using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace locks
{
    public partial class Form1 : Form
    {
        public List<Locks> locks = new List<Locks>();
        public int number;

        public Form1()
        {
            InitializeComponent();
            ShowTable();
            comboBox1.SelectedIndex = 0;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57)) e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57)) e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57)) e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox6.Text == "")
            {
                MessageBox.Show("Выберите из списка");
            }
            else
            {
                label10.Text = "Выбран: " + comboBox6.Text;
                if (comboBox6.Text == "Врезной основной")
                {
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox3.Enabled = true;
                    textBox4.Enabled = true;
                    comboBox2.Enabled = true;
                    comboBox3.Enabled = true;
                    label4.Visible = true;
                    comboBox1.Visible = true;
                    label4.Enabled = true;
                    comboBox1.Enabled = true;
                    label7.Visible = false;
                    label7.Enabled = false;
                    comboBox5.Visible = false;
                    comboBox5.Enabled = false;
                    comboBox4.Visible = false;
                    comboBox4.Enabled = false;
                    button1.Visible = true;
                    button1.Enabled = true;
                    button4.Visible = false;
                    button4.Enabled = false;
                    button5.Visible = false;
                    button5.Enabled = false;
                    button6.Visible = false;
                    button6.Enabled = false;
                }
                else
                {
                    if (comboBox6.Text == "Врезной дополнительный")
                    {
                        textBox1.Enabled = true;
                        textBox2.Enabled = true;
                        textBox3.Enabled = true;
                        textBox4.Enabled = true;
                        comboBox2.Enabled = true;
                        comboBox3.Enabled = true;
                        label4.Visible = false;
                        comboBox1.Visible = false;
                        label4.Enabled = false;
                        comboBox1.Enabled = false;
                        label7.Visible = false;
                        label7.Enabled = false;
                        comboBox5.Visible = false;
                        comboBox5.Enabled = false;
                        comboBox4.Visible = false;
                        comboBox4.Enabled = false;
                        button1.Visible = false;
                        button1.Enabled = false;
                        button4.Visible = true;
                        button4.Enabled = true;
                        button5.Visible = false;
                        button5.Enabled = false;
                        button6.Visible = false;
                        button6.Enabled = false;
                    }
                    else
                    {
                        if (comboBox6.Text == "Навесной")
                        {
                            textBox1.Enabled = true;
                            textBox2.Enabled = true;
                            textBox3.Enabled = true;
                            textBox4.Enabled = true;
                            comboBox2.Enabled = true;
                            comboBox3.Enabled = true;
                            label7.Visible = true;
                            label7.Enabled = true;
                            comboBox5.Visible = true;
                            comboBox5.Enabled = true;

                            label4.Visible = false;
                            comboBox1.Visible = false;
                            label4.Enabled = false;
                            comboBox1.Enabled = false;
                            comboBox4.Visible = false;
                            comboBox4.Enabled = false;

                            button1.Visible = false;
                            button1.Enabled = false;
                            button4.Visible = false;
                            button4.Enabled = false;
                            button5.Visible = true;
                            button5.Enabled = true;
                            button6.Visible = false;
                            button6.Enabled = false;
                        }
                        else
                        {
                            textBox1.Enabled = true;
                            textBox2.Enabled = true;
                            textBox3.Enabled = true;
                            textBox4.Enabled = true;
                            comboBox2.Enabled = true;
                            comboBox3.Enabled = true;
                            label7.Visible = true;
                            label7.Enabled = true;
                            comboBox4.Visible = true;
                            comboBox4.Enabled = true;

                            label4.Visible = false;
                            comboBox1.Visible = false;
                            label4.Enabled = false;
                            comboBox1.Enabled = false;
                            comboBox5.Visible = false;
                            comboBox5.Enabled = false;

                            button1.Visible = false;
                            button1.Enabled = false;
                            button4.Visible = false;
                            button4.Enabled = false;
                            button5.Visible = false;
                            button5.Enabled = false;
                            button6.Visible = true;
                            button6.Enabled = true;
                        }
                    }
                }
            }
        }

        private void comboBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8) e.Handled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox6.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            locks.Add(new Mortise(textBox4.Text, comboBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text, comboBox2.Text, comboBox3.Text, "Врезной основной"));
            ShowTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            locks.Add(new AdMortise(textBox4.Text, comboBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text, comboBox2.Text, comboBox3.Text, "Врезной дополнительный"));
            ShowTable();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            locks.Add(new Hinged(textBox4.Text, comboBox5.Text, textBox1.Text, textBox2.Text, textBox3.Text, comboBox2.Text, comboBox3.Text, "Навесной"));
            ShowTable();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            locks.Add(new Overhead(textBox4.Text, comboBox4.Text, textBox1.Text, textBox2.Text, textBox3.Text, comboBox2.Text, comboBox3.Text, "Накладной"));
            ShowTable();
        }

        public void ShowTable()
        {

            if (locks.Count != 0)
            {
                dataGridView1.ColumnCount = 7;
                dataGridView1.RowCount = locks.Count;
                dataGridView1.Columns[0].HeaderCell.Value = "Модель";
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].HeaderCell.Value = "Длина";
                dataGridView1.Columns[1].Width = 45;
                dataGridView1.Columns[2].HeaderCell.Value = "Ширина";
                dataGridView1.Columns[2].Width = 50;
                dataGridView1.Columns[3].HeaderCell.Value = "Глубина";
                dataGridView1.Columns[3].Width = 50;
                dataGridView1.Columns[4].HeaderCell.Value = "Тип материала";
                dataGridView1.Columns[4].Width = 70;
                dataGridView1.Columns[5].HeaderCell.Value = "Предназначение";
                dataGridView1.Columns[5].Width = 100;
                dataGridView1.Columns[6].HeaderCell.Value = "Отличительное свойство";
                dataGridView1.Columns[6].Width = 100;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = locks[i].lockModel;
                    dataGridView1.Rows[i].Cells[1].Value = locks[i].lockLength;
                    dataGridView1.Rows[i].Cells[2].Value = locks[i].lockWeight;
                    dataGridView1.Rows[i].Cells[3].Value = locks[i].lockDepth;
                    dataGridView1.Rows[i].Cells[4].Value = locks[i].lockTypeOfMaterial;
                    dataGridView1.Rows[i].Cells[5].Value = locks[i].lockPredistination;
                    string type = locks[i].lockTypeOfLock;
                    switch (type)
                    {
                        case "Врезной основной":
                            dataGridView1.Rows[i].Cells[6].Value = type;
                            break;
                        case "Врезной дополнительный":
                            dataGridView1.Rows[i].Cells[6].Value = type;
                            break;
                        case "Навесной":
                            dataGridView1.Rows[i].Cells[6].Value = type;
                            break;
                        case "Накладной":
                            dataGridView1.Rows[i].Cells[6].Value = type;
                            break;
                    }
                }
            }
        }

        private void Serialize(Stream myStream)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Locks>));
            jsonFormatter.WriteObject(myStream, locks);
            myStream.Close();
        }

        private void Deserialize(Stream myStream)
        {
            locks.Clear();
            dataGridView1.Rows.Clear();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Locks>));
            List<Locks> temp = (List<Locks>)jsonFormatter.ReadObject(myStream);
            locks = temp;
            foreach (Locks obj in locks)
                dataGridView1.Rows.Add(obj.lockLength);
            ShowTable();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    Serialize(myStream);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            Deserialize(myStream);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Выберите из списка");
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            List<Locks> tempLocks = new List<Locks>();
            tempLocks = locks;
            if (textBox5.Text != "")
            {
                number = Convert.ToInt32(textBox5.Text)-1;
                string temp;
                //temp = dataGridView1.CurrentCell.Value.ToString();
                tempLocks[number].lockModel = dataGridView1.Rows[number].Cells[0].Value.ToString();
                tempLocks[number].lockLength = dataGridView1.Rows[number].Cells[1].Value.ToString();
                tempLocks[number].lockWeight = dataGridView1.Rows[number].Cells[2].Value.ToString();
                //temp= dataGridView1.Rows[number].Cells[2].Value.ToString();
                tempLocks[number].lockDepth = dataGridView1.Rows[number].Cells[3].Value.ToString();
                tempLocks[number].lockTypeOfMaterial = dataGridView1.Rows[number].Cells[4].Value.ToString();
                tempLocks[number].lockPredistination = dataGridView1.Rows[number].Cells[5].Value.ToString();
                //tempLocks[number].lockModel = dataGridView1.Rows[number].Cells[6].Value.ToString();
                //label11.Text = temp;

                locks = tempLocks;
            }
            else
            {
                MessageBox.Show("Выберите строку элемента");
            }
        }
    }
}
