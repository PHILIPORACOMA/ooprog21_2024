using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDNumber2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set form title
            this.Text = "Student Information Form";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Gather all the input values
            string idNumber = idNumberTextBox.Text;
            string course = courseTextBox.Text;
            string yearLevel = yearLevelTextBox.Text;
            string firstName = firstNameTextBox.Text;
            string middleName = middleNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string emailAddress = emailTextBox.Text;
            string homeAddress = homeAddressTextBox.Text;
            string fatherName = fatherNameTextBox.Text;
            string motherName = motherNameTextBox.Text;
            string dateOfBirth = dobTextBox.Text;
            string age = ageTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;
            string parentContact = parentContactTextBox.Text;
            string skillsAndInterest = skillsInterestTextBox.Text;

            // Display all information in a MessageBox or create a summary in a label
            string message = $"ID Number: {idNumber}\n" +
                             $"Course: {course}\n" +
                             $"Year Level: {yearLevel}\n" +
                             $"Name: {firstName} {middleName} {lastName}\n" +
                             $"Email: {emailAddress}\n" +
                             $"Address: {homeAddress}\n" +
                             $"Father's Name: {fatherName}\n" +
                             $"Mother's Name: {motherName}\n" +
                             $"Date of Birth: {dateOfBirth}\n" +
                             $"Age: {age}\n" +
                             $"Phone Number: {phoneNumber}\n" +
                             $"Parent Contact Info: {parentContact}\n" +
                             $"Skills & Interest: {skillsAndInterest}";

            MessageBox.Show(message, "Student Information");
        }
    }
}
