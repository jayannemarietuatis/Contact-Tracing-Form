namespace Contact_Tracing_Form
{
    public partial class frmContactTracing : Form
    {
        public frmContactTracing()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\DELL\Desktop\JAY ANNE\PUP\2ND SEM\OBJECT PROG\Contact Tracing Form.txt", true);
        }

    }
}