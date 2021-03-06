﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFullNameRegApp
{
    public partial class Form1 : Form
    {
        Student aStudent= new Student();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            aStudent.regNo = regNoTextBox.Text;
            aStudent.firstName = firstNameTextBox.Text;
            aStudent.lastName = lastnameTextBox.Text;

            Clear();

            string fullName = aStudent.GetFullName();
            MessageBox.Show(fullName + ", your registration number is " + aStudent.regNo);
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            regNoTextBox.Text = aStudent.regNo;
            firstNameTextBox.Text = aStudent.firstName;
            lastnameTextBox.Text = aStudent.lastName;
        }

        public void Clear()
        {
            regNoTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastnameTextBox.Text = string.Empty;
        }
    }
}
