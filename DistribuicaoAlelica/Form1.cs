using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace DistribuicaoAlelica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Visible = false;

            TemaEscuro();
        }

        string[] valores = { "aabb", "aaBb", "Aabb", "AABB", "AABb", "AaBB", "AaBb", "aaBB", "AAbb", "AabB", "AAbB", "aABB", "aAbB", "aABb", "aAbb", "aabB", };
         

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length == 0 || comboBox2.Text.Length == 0)
            {
                MessageBox.Show("Selecione alguma opção correspondente a sua !!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string pai = comboBox1.Text;
                string mae = comboBox2.Text;

                dataGridView1.EnableHeadersVisualStyles = false;

                //Inserindo valores do pai
                dataGridView1.Columns[1].HeaderText = pai[0].ToString() + pai[2].ToString(); //Coluna 1
                dataGridView1.Columns[2].HeaderText = pai[0].ToString() + pai[3].ToString(); //Coluna 2
                dataGridView1.Columns[3].HeaderText = pai[1].ToString() + pai[2].ToString(); //Coluna 3
                dataGridView1.Columns[4].HeaderText = pai[1].ToString() + pai[3].ToString(); //Coluna 4

                //Inserindo valores da mãe
                dataGridView1.Rows.Add(mae[0].ToString() + mae[2].ToString());
                dataGridView1.Rows.Add(mae[0].ToString() + mae[3].ToString());
                dataGridView1.Rows.Add(mae[1].ToString() + mae[2].ToString());
                dataGridView1.Rows.Add(mae[1].ToString() + mae[3].ToString());

                // inseri valores na tabela
                dataGridView1.Rows[0].Cells[1].Value = (mae[0].ToString() + pai[0].ToString() + mae[2].ToString() + pai[2].ToString()); // Coluna  1
                dataGridView1.Rows[1].Cells[1].Value = (mae[0].ToString() + pai[0].ToString() + mae[3].ToString() + pai[2].ToString()); // Coluna  1
                dataGridView1.Rows[2].Cells[1].Value = (mae[1].ToString() + pai[0].ToString() + mae[2].ToString() + pai[2].ToString()); // Coluna  1
                dataGridView1.Rows[3].Cells[1].Value = (mae[1].ToString() + pai[0].ToString() + mae[3].ToString() + pai[2].ToString()); // Coluna  1

                dataGridView1.Rows[0].Cells[2].Value = (mae[0].ToString() + pai[0].ToString() + mae[2].ToString() + pai[3].ToString()); // Coluna  2
                dataGridView1.Rows[1].Cells[2].Value = (mae[0].ToString() + pai[0].ToString() + mae[3].ToString() + pai[3].ToString()); // Coluna  2
                dataGridView1.Rows[2].Cells[2].Value = (mae[1].ToString() + pai[0].ToString() + mae[2].ToString() + pai[3].ToString()); // Coluna  2
                dataGridView1.Rows[3].Cells[2].Value = (mae[1].ToString() + pai[0].ToString() + mae[3].ToString() + pai[3].ToString()); // Coluna  2

                dataGridView1.Rows[0].Cells[3].Value = (mae[0].ToString() + pai[1].ToString() + mae[2].ToString() + pai[2].ToString()); // Coluna  3
                dataGridView1.Rows[1].Cells[3].Value = (mae[0].ToString() + pai[1].ToString() + mae[3].ToString() + pai[2].ToString()); // Coluna  3
                dataGridView1.Rows[2].Cells[3].Value = (mae[1].ToString() + pai[1].ToString() + mae[2].ToString() + pai[2].ToString()); // Coluna  3
                dataGridView1.Rows[3].Cells[3].Value = (mae[1].ToString() + pai[1].ToString() + mae[3].ToString() + pai[2].ToString()); // Coluna  3

                dataGridView1.Rows[0].Cells[4].Value = (mae[0].ToString() + pai[1].ToString() + mae[2].ToString() + pai[3].ToString()); // Coluna  4
                dataGridView1.Rows[1].Cells[4].Value = (mae[0].ToString() + pai[1].ToString() + mae[3].ToString() + pai[3].ToString()); // Coluna  4
                dataGridView1.Rows[2].Cells[4].Value = (mae[1].ToString() + pai[1].ToString() + mae[2].ToString() + pai[3].ToString()); // Coluna  4
                dataGridView1.Rows[3].Cells[4].Value = (mae[1].ToString() + pai[1].ToString() + mae[3].ToString() + pai[3].ToString()); // Coluna  4


                //Comparar e ver semelhança
                string valor1coluna0 = mae[0].ToString() + pai[0].ToString() + mae[2].ToString() + pai[2].ToString();
                string valor2coluna0 = mae[0].ToString() + pai[0].ToString() + mae[2].ToString() + pai[3].ToString();
                string valor3coluna0 = mae[0].ToString() + pai[1].ToString() + mae[2].ToString() + pai[2].ToString();
                string valor4coluna0 = mae[0].ToString() + pai[1].ToString() + mae[2].ToString() + pai[3].ToString();

                string valor1coluna1 = mae[0].ToString() + pai[1].ToString() + mae[2].ToString() + pai[3].ToString();
                string valor2coluna1 = mae[0].ToString() + pai[1].ToString() + mae[3].ToString() + pai[3].ToString();
                string valor3coluna1 = mae[0].ToString() + pai[1].ToString() + mae[2].ToString() + pai[3].ToString();
                string valor4coluna1 = mae[0].ToString() + pai[1].ToString() + mae[3].ToString() + pai[3].ToString();

                string valor1coluna2 = mae[0].ToString() + pai[1].ToString() + mae[2].ToString() + pai[2].ToString();
                string valor2coluna2 = mae[0].ToString() + pai[1].ToString() + mae[2].ToString() + pai[3].ToString();
                string valor3coluna2 = mae[1].ToString() + pai[1].ToString() + mae[2].ToString() + pai[2].ToString();
                string valor4coluna2 = mae[1].ToString() + pai[1].ToString() + mae[2].ToString() + pai[3].ToString();

                string valor1coluna3 = mae[0].ToString() + pai[1].ToString() + mae[2].ToString() + pai[3].ToString();
                string valor2coluna3 = mae[0].ToString() + pai[1].ToString() + mae[3].ToString() + pai[3].ToString();
                string valor3coluna3 = mae[1].ToString() + pai[1].ToString() + mae[2].ToString() + pai[3].ToString();
                string valor4coluna3 = mae[1].ToString() + pai[1].ToString() + mae[3].ToString() + pai[3].ToString();

                string resultadoAlelo = "";

                for (int x = 1; x < 5; x++)
                    for (int f = 0; f < 4; f++)
                    {
                        if (("valor" + f.ToString() + "coluna" + x.ToString() == "valor" + f.ToString() + "coluna" + x.ToString()))
                        {
                            listBox1.Items.Add((dataGridView1.Rows[f].Cells[x].Value));
                        }
                    }

                int MaxRepe = 0;
                string NameMaxRepe = "";

                for (int i = 0; i < valores.Length; i++)
                {
                    int repetido = 0;

                    for (int x = 0; x < listBox1.Items.Count; x++)
                    {
                        if (listBox1.Items[x].ToString() == valores[i].ToString())
                        {
                            repetido++;
                        }
                    }

                    if (MaxRepe < repetido)
                    {
                        MaxRepe = repetido;
                        NameMaxRepe = valores[i];
                        resultadoAlelo = NameMaxRepe;
                    }
                }

                if (resultadoAlelo[0].ToString() + resultadoAlelo[1].ToString() == "AA")
                {
                    label3.Text = NameMaxRepe + " - Seu filho terá olhos castanhos e \n";
                }
                else if (resultadoAlelo[0].ToString() + resultadoAlelo[1].ToString() == "aa")
                {
                    label3.Text = NameMaxRepe + " - Seu filho terá olhos azuis e \n";
                }
                else
                {
                    label3.Text = NameMaxRepe + " - Seu filho tem 50% de chances de ter olhos azuis ou castanhos e \n";
                }

                if (resultadoAlelo[2].ToString() + resultadoAlelo[3].ToString() == "BB")
                {
                    label3.Text += "terá o lóbulo da orelha livre";
                }
                else if (resultadoAlelo[2].ToString() + resultadoAlelo[3].ToString() == "bb")
                {
                    label3.Text += "terá o lóbulo da orelha colado";
                }
                else
                {
                    label3.Text += "50% de chaces de ter o lóbulo da orelha livre ou colado";
                }

                //Seta o dataGrid como true
                dataGridView1.Visible = true;
                button1.Visible = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;

                button2.Visible = true;
                label3.Visible = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void temaBrancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            comboBox1.BackColor = Color.White;
            comboBox1.ForeColor = Color.Black;
            comboBox2.BackColor = Color.White;
            comboBox2.ForeColor = Color.Black;
            button1.ForeColor = Color.DimGray;
            button2.ForeColor = Color.DimGray;
            toolStrip1.BackColor = Color.White;
        }

        private void temaPretoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TemaEscuro();
        }

        void TemaEscuro()
        {
            this.BackColor = Color.FromArgb(52, 52, 52);
            comboBox1.BackColor = Color.DimGray;
            comboBox1.ForeColor = Color.White;
            comboBox2.BackColor = Color.DimGray;
            comboBox2.ForeColor = Color.White;
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            toolStrip1.BackColor = Color.DimGray;
            dataGridView1.GridColor = Color.DimGray;
            dataGridView1.ForeColor = Color.DimGray;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
