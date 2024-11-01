using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iTextSharp.xmp.impl;
using FinalProject.DataBase;


namespace FinalProject
{
  public partial class Form1 : Form
  {
    

    readonly PersonalInfo person = new PersonalInfo();
    readonly DataBaseManager baseManager = new DataBaseManager();
    public Form1()
    {
      InitializeComponent();
      
    }

    private void FullNameField_TextChanged(object sender, EventArgs e)
    { 
      person.FullName = FullNameField.Text;
    }

    private void DateOfBirth_ValueChanged(object sender, EventArgs e)
    {
      person.DateOfBirth = DateOfBirthField.Text;
    }


    private void FullNameField_Enter(object sender, EventArgs e)
    {
      if (FullNameField.Text == "Введите имя")
      {
        FullNameField.Text = "";
        FullNameField.ForeColor = Color.Black;
      }
    }

    private void FullNameField_Leave(object sender, EventArgs e)
    {
      if (FullNameField.Text == "")
      {
        FullNameField.Text = "Введите имя";
        FullNameField.ForeColor = Color.Gray;
      }
    }

    private void ButtonSaveInfo_Click(object sender, EventArgs e)
    {
      person.FullName = FullNameField.Text;
      person.DateOfBirth = DateOfBirthField.Text;
      person.Gender = GenderField.Text;
      person.City = CityField.Text;
      person.PhoneNumber = PhoneNumberField.Text;
      person.Email = EmailField.Text;
      person.MaritalStatus = MaritalStatusField.Text;

      baseManager.SavePersonalInfo(person);

    }

    private void ButtonCreatePDF_Click(object sender, EventArgs e)
    {
      /*string query = "SELECT Name, DateOfBirth, Gender FROM PersonalInfo WHERE Name = @name";

      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();
        using (SQLiteCommand command = new SQLiteCommand(query, connection))
        {
          command.Parameters.AddWithValue("@name", FullNameField.Text);

          using (SQLiteDataReader reader = command.ExecuteReader())
          {
            // Создание документа PDF
            using (FileStream fs = new FileStream("PersonalInfo.pdf", FileMode.Create))
            {
              using (Document doc = new Document())
              {
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();

                // Добавление заголовка
                Paragraph header = new Paragraph("Personal Info");
                header.Alignment = Element.ALIGN_CENTER;
                doc.Add(header);

                // Добавление строк с данными
                while (reader.Read())
                {
                  string name = reader["Name"].ToString();
                  string dateOfBirth = reader["DateOfBirth"].ToString();
                  string gender = reader["Gender"].ToString();

                  doc.Add(new Paragraph($"Name: {name}"));
                  doc.Add(new Paragraph($"Date of Birth: {dateOfBirth}"));
                  doc.Add(new Paragraph($"Gender: {gender}"));
                  doc.Add(new Paragraph("")); // Пустая строка для разделения записей
                }
              }
            }
          }
        }
      }

      MessageBox.Show("PDF файл создан успешно.");*/
    }

    
    private void CityField_TextChanged(object sender, EventArgs e)
    {
      person.City = CityField.Text;
    }

    private void CityField_Enter(object sender, EventArgs e)
    {
      if (CityField.Text == "Введите город")
      {
        CityField.Text = "";
        CityField.ForeColor = Color.Black;
      }
    }

    private void CityField_Leave(object sender, EventArgs e)
    {
      if (CityField.Text == "")
      {
        CityField.Text = "Введите город";
        CityField.ForeColor = Color.Gray;
      }
    }

    private void EmailField_TextChanged(object sender, EventArgs e)
    {
      person.Email = EmailField.Text;
    }

    private void EmailField_Enter(object sender, EventArgs e)
    {
      if (EmailField.Text == "Введите почту")
      {
        EmailField.Text = "";
        EmailField.ForeColor = Color.Black;
      }
    }

    private void EmailField_Leave(object sender, EventArgs e)
    {
      if (EmailField.Text == "")
      {
        EmailField.Text = "Введите почту";
        EmailField.ForeColor = Color.Gray;
      }
    }

    private void PhoneNumberField_TextChanged(object sender, EventArgs e)
    {
      person.PhoneNumber = PhoneNumberField.Text;
    }

    private void GenderField_SelectedIndexChanged(object sender, EventArgs e)
    {
      person.Gender = GenderField.Items.ToString();
      GenderField.ForeColor = Color.Black;
    }

    private void MaritalStatusField_SelectedIndexChanged(object sender, EventArgs e)
    {
      person.MaritalStatus = MaritalStatusField.Items.ToString();
      MaritalStatusField.ForeColor = Color.Black;
    }
  }
}
