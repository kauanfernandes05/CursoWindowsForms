namespace CursoWindowsForms
{
    public partial class Frm_HelloWord : Form
    {
        public Frm_HelloWord()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ModificaLabel_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = Txt_ConteudoLabel.Text;
        }
    }
}
