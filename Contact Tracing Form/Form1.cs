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
            file.WriteLine (lblContactTrace.Text);
            file.WriteLine (lblPersonalInfo.Text);
            file.WriteLine ("First Name: " + txtbxFirstName.Text);
            file.WriteLine ("Last Name: " + txtbxLastName.Text);
            file.WriteLine ("Age: " + txtbxAge.Text);
            file.WriteLine ("Gender: " + txtbxGender.Text);
            file.WriteLine ("Contact Number: " + txtbxContactNumber.Text);
            file.WriteLine ("House Number: " + txtbxHouseNumber.Text);
            file.WriteLine("Date: " + txtbxDate.Text);
            file.WriteLine ("Street/Barangay: " + txtbxStreet.Text);
            file.WriteLine ("City/Town: " + txtbxCity.Text);
            file.WriteLine ("Zip Code: " + txtbxZipCode.Text);
            file.WriteLine ("Purpose: " + txtbxPurpose.Text);
            file.WriteLine ("Body Temperature: " + txtbxBodyTemp.Text);
           
            file.WriteLine (lblCovid.Text);
            file.WriteLine (lblInstruction.Text);
            file.WriteLine (lblQ1.Text + txtbxQ1.Text);
            file.WriteLine (lblQ2.Text + txtbxQ2.Text);
            file.WriteLine (lblQ3.Text + txtbxQ3.Text);
            file.WriteLine (lblQ4.Text + txtbxQ4.Text);
            file.WriteLine (lblQ5.Text + txtbxQ5.Text);
            file.WriteLine (lblQ6.Text + txtbxQ6.Text);
            file.WriteLine (lblQ7.Text + txtbxQ7.Text);
            file.WriteLine (lblQ8.Text + txtbxQ8.Text);
            file.WriteLine (lblClosing.Text);
            file.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbxQ7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(@"C:\Users\DELL\Desktop\JAY ANNE\PUP\2ND SEM\OBJECT PROG\Contact Tracing Form.txt");
            string all = reader.ReadToEnd();
            MessageBox.Show(all);
        }

        private void frmContactTracing_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(@"C:\Users\DELL\Desktop\JAY ANNE\PUP\2ND SEM\OBJECT PROG\Contact Tracing Form.txt");

            string Line;
            string info = txtbxSearch.Text;
            bool dateExist = false;

            do
            {
                Line = reader.ReadLine();
                if (Line != null)
                {
                    dateExist = Line.Contains(info);
                    MessageBox.Show(Line);
                }

                else
                {
                    MessageBox.Show(txtbxSearch.Text + "does not exist");
                }
            }
            while (Line != null && !dateExist);

            if (dateExist)
            {
                MessageBox.Show(info);
            }
        }
         
        private void btnGenerateQR_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator GetQR = new QRCoder.QRCodeGenerator();
            var text = (txtbxFirstName.Text + txtbxLastName.Text + txtbxAge.Text + txtbxGender.Text +
                txtbxContactNumber.Text + txtbxHouseNumber.Text + txtbxDate.Text + txtbxStreet.Text +
                txtbxCity.Text + txtbxZipCode.Text + txtbxPurpose.Text + txtbxBodyTemp.Text);
            var info = GetQR.CreateQrCode(text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(info);
            picbxQR.Image = code.GetGraphic(50);
        }
    }
}