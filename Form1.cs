namespace WinFormsApp1
{
    public partial class Trabalho : Form
    {
        string nomeUsu�rio;

        public Trabalho()
        {
            InitializeComponent();
        }

        private void Trabalho_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btcadastro_Click(object sender, EventArgs e)
        {
            nomeUsu�rio = textBox2.Text;
            if (cltermos.Checked == true)
            {
                if (rbmulher.Checked == true)
                {
                    MessageBox.Show($"Ol� senhora " + nomeUsu�rio + " seu cadastro foi realizado com sucesso");
                }
                else if (rbhomem.Checked == true)
                {
                    MessageBox.Show($"Ol� senhor " + nomeUsu�rio + " seu cadastro foi realizado com sucesso");
                }
                else
                {
                    MessageBox.Show($"Ol� " + nomeUsu�rio + " seu cadastro foi realizado com sucesso");
                }
            }
            else
            {
                MessageBox.Show("Voc� precisa aceitar os termos de uso para continuar");
            }


        }

        private void cltermos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btproxima_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
            form2.FormClosed += (s, args) => this.Close();
        }
    }
}
