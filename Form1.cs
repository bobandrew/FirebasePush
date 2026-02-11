namespace FirebasePush
{
    using System.Net.Http.Json;

    using FirebaseAdmin.Messaging;

    using Newtonsoft.Json;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                var pushHelper = new PushHelper(txtProjectId.Text);
                var message = JsonConvert.DeserializeObject<Message>(txtPushData.Text.Replace("newid()", Guid.NewGuid().ToString()));
                txtResult.Text = pushHelper.Send(message);
            }
            catch (Exception ex)
            {
                txtResult.Text = ex.Message;
            }

            //txtPushData.Text
        }
    }
}