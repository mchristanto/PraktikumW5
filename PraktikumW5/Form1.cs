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
            ListBox listBoxKoleksi = new ListBox();
            this.Controls.Add(listBoxKoleksi);
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            tBoxData.Text = listBoxKoleksi.Text;
            lblOutput.Text = listBoxKoleksi.SelectedIndex.ToString();

        }
       
        private void listBoxKoleksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
            else if (checkBoxAktif.CheckState == CheckState.Indeterminate)
            {
                lblOutput.ForeColor = Color.Black;
            }
        }

        private void rButtonRed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rButtonBlue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBoxKoleksi.Controls.Clear();
        }

        private void tBoxData_TextChanged(object sender, EventArgs e)
        {

        }
    }
}