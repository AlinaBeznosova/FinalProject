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


namespace FinalProject
{
  public partial class Form1 : Form
  {
    const string connectionString = "Data Source=\"C:\\Users\\Алина\\source\\repos\\FinalProject\\DataBase.db\"";
    SQLiteConnection connection = new SQLiteConnection(connectionString);
    DataBase db = new DataBase();
    public Form1()
    {
      InitializeComponent();
    }

    private void nameField_TextChanged(object sender, EventArgs e)
    {
      PersonalInfo persona = new PersonalInfo();
      persona.Name = nameField.Text;
    }

    private void dateOfBirth_ValueChanged(object sender, EventArgs e)
    {
      PersonalInfo persona = new PersonalInfo();
      persona.DateOfBirth = dateOfBirth.Value;
    }

    private void genderField_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (genderField.Text != "Выберите пол")
      {
        genderField.ForeColor = Color.Black;
        PersonalInfo persona = new PersonalInfo();
        persona.Gender = genderField.Items.ToString();
      }
    }

    private void nameField_Enter(object sender, EventArgs e)
    {
      if (nameField.Text == "Введите имя")
      {
        nameField.Text = "";
        nameField.ForeColor = Color.Black;
      }
    }

    private void nameField_Leave(object sender, EventArgs e)
    {
      if (nameField.Text == "")
      {
        nameField.Text = "Введите имя";
        nameField.ForeColor = Color.Gray;
      }
    }

    private void buttonSaveInfo_Click(object sender, EventArgs e)
    {
     
      

      string name = nameField.Text;
      string date = dateOfBirth.Text;
      string gender = genderField.Text;

      connection.Open();
      SQLiteCommand command = connection.CreateCommand();
      command.CommandText = @"
               INSERT INTO PersonalInfo (
                 Name, 
                 DateOfBirth, 
                 Gender ) 
               VALUES (
                 @name, 
                 @date, 
                 @gender)";

      command.Parameters.AddWithValue("@name", name);
      command.Parameters.AddWithValue("@date", date);
      command.Parameters.AddWithValue("@gender", gender);

      if (command.ExecuteNonQuery() != 0)
        MessageBox.Show("Данные сохранены");
      connection.Close();

    }

    private void buttonCreatePDF_Click(object sender, EventArgs e)
    {
      string query = "SELECT Name, DateOfBirth, Gender FROM PersonalInfo WHERE Name = @name";

      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();
        using (SQLiteCommand command = new SQLiteCommand(query, connection))
        {
          command.Parameters.AddWithValue("@name", nameField.Text);

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

      MessageBox.Show("PDF файл создан успешно.");
    }
  }
}
