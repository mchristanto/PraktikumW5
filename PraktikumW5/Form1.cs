namespace PraktikumW5
{
    public partial class FormMateri : Form
    {
        public FormMateri()
        {
            InitializeComponent();
        }
       
        private void FormMateri_Load(object sender, EventArgs e)
        {
            
            rButtonRed.Checked = true;
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
         
            if (listBoxKoleksi.Items.Contains(tBoxData.Text))
            {
                MessageBox.Show("Input Kembar");
            }
            else
            {
                listBoxKoleksi.Items.Add(tBoxData.Text);
            }

        }
       
        private void listBoxKoleksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblOutput.Text = listBoxKoleksi.SelectedItem.ToString();
            

        }

        private void checkBoxAktif_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.CheckState == CheckState.Checked)
            {
                if (rButtonBlue.Checked == true)
                {
                    lblOutput.ForeColor = Color.Blue;
                }
                else if (rButtonRed.Checked == true)
                {
                    lblOutput.ForeColor = Color.Red;
                }
            }
            else if (checkBoxAktif.CheckState == CheckState.Unchecked)
            {
                lblOutput.ForeColor = Color.Black;
            }
        }

        private void rButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.CheckState == CheckState.Checked)
            {
                if (rButtonBlue.Checked == true)
                {
                    lblOutput.ForeColor = Color.Blue;
                }
                else if (rButtonRed.Checked == true)
                {
                    lblOutput.ForeColor = Color.Red;
                }
            }
            else if (checkBoxAktif.CheckState == CheckState.Unchecked)
            {
                lblOutput.ForeColor = Color.Black;
            }
        }

        private void rButtonBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.CheckState == CheckState.Checked)
            {
                if (rButtonBlue.Checked == true)
                {
                    lblOutput.ForeColor = Color.Blue;
                }
                else if (rButtonRed.Checked == true)
                {
                    lblOutput.ForeColor = Color.Red;
                }
            }
            else if (checkBoxAktif.CheckState == CheckState.Unchecked)
            {
                lblOutput.ForeColor = Color.Black;
            }
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBoxKoleksi.Items.Clear();
            tBoxData.Clear();
            

        }

        private void tBoxData_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}