namespace Praktikum_Week_5
{
    public partial class FormWeek5 : Form
    {
        public FormWeek5()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            labelHalo.Text = textBoxData.Text;
        }

        private void radioButtonMerah_CheckedChanged(object sender, EventArgs e)
        {
            labelHalo.ForeColor = Color.Red;
        }
        private void radioButtonBiru_CheckedChanged(object sender, EventArgs e)
        {
            labelHalo.ForeColor = Color.Blue;
        }
        private void listBoxKoleksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxKoleksi.Text = textBoxData.Text;
        }

        private void checkBoxAktif_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxAktif.Checked = radioButtonMerah.Checked;
            labelHalo.ForeColor = Color.Red;
            checkBoxAktif.Checked = radioButtonBiru.Checked;
            labelHalo.ForeColor = Color.Blue;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}