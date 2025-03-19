using System;
using System.Drawing;
using System.Windows.Forms;
namespace IDNumber2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox idNumberTextBox;
        private TextBox courseTextBox;
        private TextBox yearLevelTextBox;
        private TextBox firstNameTextBox;
        private TextBox middleNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox emailTextBox;
        private TextBox homeAddressTextBox;
        private TextBox fatherNameTextBox;
        private TextBox motherNameTextBox;
        private TextBox dobTextBox;
        private TextBox ageTextBox;
        private TextBox phoneNumberTextBox;
        private TextBox parentContactTextBox;
        private TextBox skillsInterestTextBox;
        private Button submitButton;
        private Label idNumberLabel;
        private Label courseLabel;
        private Label yearLevelLabel;
        private Label firstNameLabel;
        private Label middleNameLabel;
        private Label lastNameLabel;
        private Label emailLabel;
        private Label homeAddressLabel;
        private Label fatherNameLabel;
        private Label motherNameLabel;
        private Label dobLabel;
        private Label ageLabel;
        private Label phoneNumberLabel;
        private Label parentContactLabel;
        private Label skillsInterestLabel;

        private void InitializeComponent()
        {
            this.idNumberLabel = new Label();
            this.courseLabel = new Label();
            this.yearLevelLabel = new Label();
            this.firstNameLabel = new Label();
            this.middleNameLabel = new Label();
            this.lastNameLabel = new Label();
            this.emailLabel = new Label();
            this.homeAddressLabel = new Label();
            this.fatherNameLabel = new Label();
            this.motherNameLabel = new Label();
            this.dobLabel = new Label();
            this.ageLabel = new Label();
            this.phoneNumberLabel = new Label();
            this.parentContactLabel = new Label();
            this.skillsInterestLabel = new Label();

            this.idNumberTextBox = new TextBox();
            this.courseTextBox = new TextBox();
            this.yearLevelTextBox = new TextBox();
            this.firstNameTextBox = new TextBox();
            this.middleNameTextBox = new TextBox();
            this.lastNameTextBox = new TextBox();
            this.emailTextBox = new TextBox();
            this.homeAddressTextBox = new TextBox();
            this.fatherNameTextBox = new TextBox();
            this.motherNameTextBox = new TextBox();
            this.dobTextBox = new TextBox();
            this.ageTextBox = new TextBox();
            this.phoneNumberTextBox = new TextBox();
            this.parentContactTextBox = new TextBox();
            this.skillsInterestTextBox = new TextBox();

            this.submitButton = new Button();

            // Set Text for Labels
            this.idNumberLabel.Text = "Your ID number:";
            this.courseLabel.Text = "Your Course:";
            this.yearLevelLabel.Text = "Your Year Level:";
            this.firstNameLabel.Text = "Your First Name:";
            this.middleNameLabel.Text = "Your Middle Name (Optional):";
            this.lastNameLabel.Text = "Your Last Name:";
            this.emailLabel.Text = "Your Email Address:";
            this.homeAddressLabel.Text = "Your Home Address:";
            this.fatherNameLabel.Text = "Your Father's Name:";
            this.motherNameLabel.Text = "Your Mother's Name:";
            this.dobLabel.Text = "Your Date of Birth:";
            this.ageLabel.Text = "Your Age:";
            this.phoneNumberLabel.Text = "Your Phone Number:";
            this.parentContactLabel.Text = "Parent Contact Information:";
            this.skillsInterestLabel.Text = "Skills and Interests:";

            // Set the position of the labels and textboxes
            this.idNumberLabel.Location = new Point(20, 20);
            this.idNumberTextBox.Location = new Point(150, 20);
            this.courseLabel.Location = new Point(20, 50);
            this.courseTextBox.Location = new Point(150, 50);
            this.yearLevelLabel.Location = new Point(20, 80);
            this.yearLevelTextBox.Location = new Point(150, 80);
            this.firstNameLabel.Location = new Point(20, 110);
            this.firstNameTextBox.Location = new Point(150, 110);
            this.middleNameLabel.Location = new Point(20, 140);
            this.middleNameTextBox.Location = new Point(150, 140);
            this.lastNameLabel.Location = new Point(20, 170);
            this.lastNameTextBox.Location = new Point(150, 170);
            this.emailLabel.Location = new Point(20, 200);
            this.emailTextBox.Location = new Point(150, 200);
            this.homeAddressLabel.Location = new Point(20, 230);
            this.homeAddressTextBox.Location = new Point(150, 230);
            this.fatherNameLabel.Location = new Point(20, 260);
            this.fatherNameTextBox.Location = new Point(150, 260);
            this.motherNameLabel.Location = new Point(20, 290);
            this.motherNameTextBox.Location = new Point(150, 290);
            this.dobLabel.Location = new Point(20, 320);
            this.dobTextBox.Location = new Point(150, 320);
            this.ageLabel.Location = new Point(20, 350);
            this.ageTextBox.Location = new Point(150, 350);
            this.phoneNumberLabel.Location = new Point(20, 380);
            this.phoneNumberTextBox.Location = new Point(150, 380);
            this.parentContactLabel.Location = new Point(20, 410);
            this.parentContactTextBox.Location = new Point(150, 410);
            this.skillsInterestLabel.Location = new Point(20, 440);
            this.skillsInterestTextBox.Location = new Point(150, 440);
            this.submitButton.Location = new Point(150, 480);

            // Submit Button
            this.submitButton.Text = "Submit";
            this.submitButton.Click += new EventHandler(submitButton_Click);

            // Add controls to the form
            this.Controls.Add(this.idNumberLabel);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.yearLevelLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.homeAddressLabel);
            this.Controls.Add(this.fatherNameLabel);
            this.Controls.Add(this.motherNameLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.parentContactLabel);
            this.Controls.Add(this.skillsInterestLabel);

            this.Controls.Add(this.idNumberTextBox);
            this.Controls.Add(this.courseTextBox);
            this.Controls.Add(this.yearLevelTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.homeAddressTextBox);
            this.Controls.Add(this.fatherNameTextBox);
            this.Controls.Add(this.motherNameTextBox);
            this.Controls.Add(this.dobTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.parentContactTextBox);
            this.Controls.Add(this.skillsInterestTextBox);
            this.Controls.Add(this.submitButton);

            this.Text = "Student Information Form";
            this.Size = new Size(500, 600); // Adjust the form size
        }

    }
}


