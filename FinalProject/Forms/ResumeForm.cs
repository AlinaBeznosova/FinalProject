using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using FinalProject.DataBase;
using FinalProject.Core;
using Aspose.Words;
using EasyDox;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.CompilerServices;


namespace FinalProject.Forms
{
  public partial class ResumeForm : Form
  {
    
    Resume resume = new Resume();
    readonly string filePath = "resume.docx";
    private readonly AchievementForm achievementForm;
    readonly DataBaseManager baseManager = new DataBaseManager();
    readonly string connectionString = "Data Source=\"C:\\Users\\Алина\\source\\repos\\FinalProject\\DataBase.db\"";
    PersonalInfo person = new PersonalInfo();
    Experience experience = new Experience();
    

    public ResumeForm() 
    {
      InitializeComponent();
    }
    public ResumeForm(AchievementForm achievementForm)
    {
      InitializeComponent();
      this.achievementForm = achievementForm;
    }

    private void ResumeForm_FormClosed(object sender, FormClosedEventArgs e)
    {
     System.Windows.Forms.Application.Exit();
    }

    private void ShowTemplateButton_Click(object sender, EventArgs e)
    {
      try
      {
        if (Template1RadioButton.Checked)
        {
          Process.Start("Template1.pdf");
        }
        else if (Template2RadioButton.Checked)
        {
          Process.Start("Template2.pdf");
        }
        else if (Template3RadioButton.Checked)
        {
          Process.Start("Template3.pdf");
        }
        else
        {
          MessageBox.Show("Выберите шаблон");
        }
      }
      catch (System.ComponentModel.Win32Exception ex)
      {
        MessageBox.Show($"Не удалось открыть файл: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Возникла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void ShowTemplateDOCButton_Click(object sender, EventArgs e)
    {
      try
      {
        if (Template1RadioButton.Checked)
        {
          Process.Start("Template1.docx");
        }
        else if (Template2RadioButton.Checked)
        {
          Process.Start("Template2.docx");
        }
        else if (Template3RadioButton.Checked)
        {
          Process.Start("Template3.docx");
        }
        else
        {
          MessageBox.Show("Выберите шаблон");
        }
      }
      catch (System.ComponentModel.Win32Exception ex)
      {
        MessageBox.Show($"Не удалось открыть файл: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Возникла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    
  }

    private void CreateResumePDFButton_Click(object sender, EventArgs e)
    {
     
      CreateResume();

      ConvertDocxToPdf(filePath);
      
    }
    private void CreateResumeDOCButton_Click(object sender, EventArgs e)
    {
      CreateResume();
    }


    private void CreateResume()
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();

        var resume = new Resume();
        resume.Experiences = new List<Experience>();
        resume.Educations = new List<Education>();
        resume.Skills = new List<Skill>();
        resume.Achievements = new List<Achievement>();

        // Чтение личных данных
        var command = connection.CreateCommand();
        command.CommandText = @"
            SELECT *
            FROM PersonalInfo pi
            WHERE pi.PersonalInfoId = @personalId AND pi.UserId = @userId";

        command.Parameters.AddWithValue("@personalId", PersonalInfo.PersonalInfoId);
        command.Parameters.AddWithValue("@userId", User.UserId);

        using (var reader = command.ExecuteReader())
        {
          if (reader.Read())
          {
            string fullName = reader["FullName"].ToString();
            string dateOfBirth = reader["DateOfBirth"].ToString();
            string gender = reader["Gender"].ToString();
            string maritalStatus = reader["MaritalStatus"].ToString();
            string city = reader["City"].ToString();
            string email = reader["Email"].ToString();
            string phoneNumber = reader["PhoneNumber"].ToString();

            var person = new PersonalInfo(fullName, dateOfBirth, gender, maritalStatus, city, email, phoneNumber);
            resume.PersonalInfo = person;
          }
          else
          {
            MessageBox.Show("Данные не найдены.");
            return;
          }
        }

        // Чтение опыта работы
        command.CommandText = @"
            SELECT *
            FROM Experience e
            WHERE e.PersonalInfoId = @personalId";

        command.Parameters.Clear();
        command.Parameters.AddWithValue("@personalId", PersonalInfo.PersonalInfoId);

        using (var reader = command.ExecuteReader())
        {
          while (reader.Read())
          {
            string position = reader["Position"].ToString();
            string company = reader["Company"].ToString();
            string startDate = reader["StartDate"].ToString();
            string endDate = reader["EndDate"].ToString();
            string responsibilities = reader["Responsibilities"].ToString();

            var experience = new Experience(position, company, startDate, endDate, responsibilities);
            resume.Experiences.Add(experience);
          }
        }

        // Чтение образования
        command.CommandText = @"
            SELECT *
            FROM Education ed
            WHERE ed.PersonalInfoId = @personalId";

        command.Parameters.Clear();
        command.Parameters.AddWithValue("@personalId", PersonalInfo.PersonalInfoId);

        using (var reader = command.ExecuteReader())
        {
          while (reader.Read())
          {
            string institution = reader["Institution"].ToString();
            string specialty = reader["Specialty"].ToString();
            string yearOfGraduation = reader["YearOfGraduation"].ToString();

            var education = new Education(institution, specialty, yearOfGraduation);
            resume.Educations.Add(education);
          }
        }

        command.CommandText = @"
            SELECT *
            FROM Skills s
            WHERE s.PersonalInfoId = @personalId";

        command.Parameters.Clear();
        command.Parameters.AddWithValue("@personalId", PersonalInfo.PersonalInfoId);

        using (var reader = command.ExecuteReader())
        {
          while (reader.Read())
          {
            string hardSkill = reader["HardSkill"].ToString();
            string softSkill = reader["SoftSkill"].ToString();


            Skill skills = new Skill(hardSkill, softSkill);
            resume.Skills.Add(skills);
          }
        }

        command.CommandText = @"
            SELECT *
            FROM Achievements a
            WHERE a.PersonalInfoId = @personalId";

        command.Parameters.Clear();
        command.Parameters.AddWithValue("@personalId", PersonalInfo.PersonalInfoId);

        using (var reader = command.ExecuteReader())
        {
          while (reader.Read())
          {
            string achievementName = reader["AchievementName"].ToString();

            Achievement achievement = new Achievement(achievementName);
            resume.Achievements.Add(achievement);
          }
        }
        
          CreateDocument(resume);
        
      }
    }

    public void CreateDocument(Resume resume)
    {
      try
      {
        var doc = new Aspose.Words.Document();
        var builder = new DocumentBuilder(doc);

        // Заголовок
        builder.Font.Size = 20;
        builder.Font.Bold = false;
        builder.Write("Личные данные");
        builder.Writeln();

        // ФИО
        builder.Font.Size = 12;
        builder.Font.Bold = true;
        builder.Write("ФИО: ");
        builder.Font.Bold = false;
        builder.Write(resume.PersonalInfo.FullName);
        builder.Writeln();

        // Дата рождения
        builder.Font.Bold = true;
        builder.Write("Дата рождения: ");
        builder.Font.Bold = false;
        builder.Write(resume.PersonalInfo.DateOfBirth);
        builder.Writeln();

        // Пол
        builder.Font.Bold = true;
        builder.Write("Пол: ");
        builder.Font.Bold = false;
        builder.Write(resume.PersonalInfo.Gender);
        builder.Writeln();

        // Семейное положение
        builder.Font.Bold = true;
        builder.Write("Семейное положение: ");
        builder.Font.Bold = false;
        builder.Write(resume.PersonalInfo.MaritalStatus);
        builder.Writeln();

        // Город проживания
        builder.Font.Bold = true;
        builder.Write("Город проживания: ");
        builder.Font.Bold = false;
        builder.Write(resume.PersonalInfo.City);
        builder.Writeln();

        // Электронная почта
        builder.Font.Bold = true;
        builder.Write("Электронная почта: ");
        builder.Font.Bold = false;
        builder.Write(resume.PersonalInfo.Email);
        builder.Writeln();

        // Номер телефона
        builder.Font.Bold = true;
        builder.Write("Номер телефона: ");
        builder.Font.Bold = false;
        builder.Write(resume.PersonalInfo.PhoneNumber);
        builder.Writeln();
        builder.Writeln();

        // Опыт работы
        builder.Font.Size = 20;
        builder.Font.Bold = false;
        builder.Write("Опыт работы");
        builder.Writeln();

        foreach (var experience in resume.Experiences)
        {
          builder.Font.Size = 12;
          builder.Font.Bold = true;
          builder.Write("Должность: ");
          builder.Font.Bold = false;
          builder.Write(experience.Position);
          builder.Writeln();

          builder.Font.Bold = true;
          builder.Write("Компания: ");
          builder.Font.Bold = false;
          builder.Write(experience.Company);
          builder.Writeln();

          builder.Font.Bold = true;
          builder.Write("Дата начала: ");
          builder.Font.Bold = false;
          builder.Write(experience.StartDate);
          builder.Writeln();

          builder.Font.Bold = true;
          builder.Write("Дата окончания: ");
          builder.Font.Bold = false;
          builder.Write(experience.EndDate);
          builder.Writeln();

          builder.Font.Bold = true;
          builder.Write("Обязанности: ");
          builder.Font.Bold = false;
          builder.Write(experience.Responsibilities);
          builder.Writeln();
          builder.Writeln();
        }

       
        builder.Font.Size = 20;
        builder.Font.Bold = false;
        builder.Write("Образование");
        builder.Writeln();

        foreach (var education in resume.Educations)
        {
          builder.Font.Size = 12;
          builder.Font.Bold = true;
          builder.Write("Учебное заведение: ");
          builder.Font.Bold = false;
          builder.Write(education.Institution);
          builder.Writeln();

          builder.Font.Size = 12;
          builder.Font.Bold = true;
          builder.Write("Специальность: ");
          builder.Font.Bold = false;
          builder.Write(education.Specialty);
          builder.Writeln();

          builder.Font.Size = 12;
          builder.Font.Bold = true;
          builder.Write("Год окончания: ");
          builder.Font.Bold = false;
          builder.Write(education.YearOfGraduation);
          builder.Writeln();
          builder.Writeln();
        }
        builder.Font.Size = 20;
        builder.Font.Bold = false;
        builder.Write("Навыки");
        builder.Writeln();

        foreach (var skill in resume.Skills)
        {
          builder.Font.Size = 12;
          builder.Font.Bold = true;
          builder.Write("Технические навыки: ");
          builder.Font.Bold = false;
          builder.Write(skill.Hardskill);
          builder.Writeln();

          builder.Font.Size = 12;
          builder.Font.Bold = true;
          builder.Write("Универсальные навыки: ");
          builder.Font.Bold = false;
          builder.Write(skill.Softskill);
          builder.Writeln();
          builder.Writeln();
        }

        builder.Font.Size = 20;
        builder.Font.Bold = false;
        builder.Write("Достижения");
        builder.Writeln();

        foreach (var skill in resume.Skills)
        {
          builder.Font.Size = 12;
          builder.Font.Bold = true;
          builder.Write("Профессиональные достижения: ");
          builder.Font.Bold = false;
          builder.Write(skill.Hardskill);
          builder.Writeln();

        }

        doc.Save(filePath);
      }
      catch (Aspose.Words.FileCorruptedException e)
      {
        Console.WriteLine("Файл коррумпирован: " + e.Message);
      }
      catch (System.IO.IOException e)
      {
        Console.WriteLine("Ошибка ввода/вывода: " + e.Message);
      }
      catch (System.InvalidOperationException e)
      {
        Console.WriteLine("Недопустимая операция: " + e.Message);
      }
      catch (Exception e)
      {
        Console.WriteLine("Общая ошибка: " + e.Message);
      }

    }

    public void ConvertDocxToPdf(string inputFilePath)
    {
      try
      {
        // Создание диалогового окна для сохранения файла
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
        saveFileDialog.Title = "Save as PDF";
        saveFileDialog.DefaultExt = "pdf";
        saveFileDialog.AddExtension = true;

        // Отображение диалогового окна
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
          string outputFilePath = saveFileDialog.FileName;

          // Загрузка документа DOCX
          var doc = new Document(inputFilePath);

          // Сохранение документа в формате PDF
          doc.Save(outputFilePath, SaveFormat.Pdf);

          // Открытие полученного PDF файла
          Process.Start(new ProcessStartInfo(outputFilePath) { UseShellExecute = true });
        }
      }
      catch (Aspose.Words.FileCorruptedException e)
      {
        MessageBox.Show("Файл коррумпирован: " + e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      catch (System.IO.IOException e)
      {
        MessageBox.Show("Ошибка ввода/вывода: " + e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      catch (System.InvalidOperationException e)
      {
        MessageBox.Show("Недопустимая операция: " + e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      catch (Exception e)
      {
        MessageBox.Show("Общая ошибка: " + e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

   

   
  }
}

