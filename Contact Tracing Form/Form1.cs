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
            file.WriteLine(lblContactTrace.Text);
            file.WriteLine(lblPersonalInfo.Text);
            file.WriteLine("First Name: " +   txtbxFirstName.Text);
            file.WriteLine("Last Name: " +   txtbxLastName.Text);
            file.WriteLine("Age: " +   txtbxAge.Text);
            file.WriteLine("Gender: " +   txtbxGender.Text);
            file.WriteLine("Contact Number: " +   txtbxContactNumber.Text);
            file.WriteLine("House Number: " +   txtbxHouseNumber.Text);
            file.WriteLine("Street/Barangay: " +   txtbxStreet.Text);
            file.WriteLine("City/Town: " +   txtbxCity.Text);
            file.WriteLine("Zip Code: " +   txtbxZipCode.Text);
            file.WriteLine("Purpose: " +   txtbxPurpose.Text);
            file.WriteLine("Body Temperature: " +   txtbxBodyTemp.Text);
            file.Close();
        }

    }
}