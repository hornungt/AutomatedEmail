using System;
using System.Windows.Forms;

namespace Automated_Email
{
    /// <summary>
    /// A prompt that asks the user to input an email address.
    /// This is used for both adding a new email and editing an existing one.
    /// </summary>
    public partial class AddressPrompt : Form
    {
        public string Result { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public AddressPrompt(string oldEmail)
        {
            InitializeComponent();
            this.AddressTextInput.Text = Result = oldEmail ?? "";
        }

        /// <summary>
        /// Sets this.Result to the inputed email.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitAddressButton_Click(object sender, EventArgs e)
        {
            this.Result = this.AddressTextInput.Text;
        }
    }
}
