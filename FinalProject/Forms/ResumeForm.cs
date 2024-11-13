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
  
    readonly string filePath = "resume.docx";
    readonly string connectionString = "Data Source=\"C:\\Users\\Алина\\source\\repos\\FinalProject\\DataBase.db\"";
    
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
      Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });

    }

    private void CreateResume()
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();

        Resume resume = new Resume
        {
          Experiences = new List<Experience>(),
          Educations = new List<Education>(),
          Skills = new List<Skill>(),
          Achievements = new List<Achievement>()
        };

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

        if (Template1RadioButton.Checked)
        {
          CreateDocumentFirstTemplate(resume);
        }
        else if (Template2RadioButton.Checked)
        {
          CreateDocumentSecondTemplate(resume);
        }
        else if (Template3RadioButton.Checked)
        {
          CreateDocumentThirdTemplate(resume);
        }
      }
    }

    public void CreateDocumentFirstTemplate(Resume resume)
    {
      try
      {
        var doc = new Aspose.Words.Document();
        var builder = new DocumentBuilder(doc);

        builder.Font.Size = 20;
        builder.Font.Bold = false;
        builder.Write("Личные данные");
        builder.Writeln();

        builder.Font.Size = 12;
        builder.Font.Bold = true;
        builder.Write("ФИО: ");
        builder.Font.Bold = false;
        builder.Write(resume.PersonalInfo.FullName);
        builder.Writeln();

        builder.Font.Bold = true;
        builder.Write("Дата рождения: ");
        builder.Font.Bold = false;
        builder.Write(resume.PersonalInfo.DateOfBirth);
        builder.Writeln();

        builder.Font.Bold = true;
        builder.Write("Пол: ");
        builder.Font.Bold = false;
        builder.Write(resume.PersonalInfo.Gender);
        builder.Writeln();

        builder.Font.Bold = true;
        builder.Write("Семейное положение: ");
        builder.Font.Bold = false;
        builder.Write(resume.PersonalInfo.MaritalStatus);
        builder.Writeln();

        builder.Font.Bold = true;
        builder.Write("Город проживания: ");
        builder.Font.Bold = false;
        builder.Write(resume.PersonalInfo.City);
        builder.Writeln();

        builder.Font.Bold = true;
        builder.Write("Электронная почта: ");
        builder.Font.Bold = false;
        builder.Write(resume.PersonalInfo.Email);
        builder.Writeln();

        builder.Font.Bold = true;
        builder.Write("Номер телефона: ");
        builder.Font.Bold = false;
        builder.Write(resume.PersonalInfo.PhoneNumber);
        builder.Writeln();
        builder.Writeln();

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

        foreach (var achievement  in resume.Achievements)
        {
          builder.Font.Size = 12;
          builder.Font.Bold = true;
          builder.Write("Профессиональные достижения: ");
          builder.Font.Bold = false;
          builder.Write(achievement.AchievementName);
          builder.Writeln();

        }

        doc.Save(filePath);
      }
      catch (Aspose.Words.FileCorruptedException e)
      {
        MessageBox.Show("Файл коррумпирован: " + e.Message);
      }
      catch (System.IO.IOException e)
      {
        MessageBox.Show("Ошибка ввода/вывода: " + e.Message);
      }
      catch (System.InvalidOperationException e)
      {
        MessageBox.Show("Недопустимая операция: " + e.Message);
      }
      catch (Exception e)
      {
        MessageBox.Show("Общая ошибка: " + e.Message);
      }

    }

    public void ConvertDocxToPdf(string inputFilePath)
    {
      try
      {
        SaveFileDialog saveFileDialog = new SaveFileDialog()
        {
          Filter = "PDF files (*.pdf)|*.pdf",
          Title = "Save as PDF",
          DefaultExt = "pdf",
          AddExtension = true
        };

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
          string outputFilePath = saveFileDialog.FileName;

          var doc = new Document(inputFilePath);

          doc.Save(outputFilePath, SaveFormat.Pdf);

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

    public void CreateDocumentSecondTemplate(Resume resume)
    {
      {
        try
        {
          var doc = new Aspose.Words.Document();
          var builder = new Aspose.Words.DocumentBuilder(doc);

          builder.ParagraphFormat.Alignment = ParagraphAlignment.Left;

          builder.PageSetup.TextColumns.SetCount(2);
          builder.PageSetup.TextColumns.EvenlySpaced = true; 
          builder.PageSetup.TextColumns.LineBetween = true;

          builder.Font.Size = 20;
          builder.Font.Bold = false;
          builder.Write("Личные данные");
          builder.Writeln();

          builder.Font.Size = 12;
          builder.Font.Bold = true;
          builder.Write("ФИО: ");
          builder.Font.Bold = false;
          builder.Write(resume.PersonalInfo.FullName);
          builder.Writeln();

          builder.Font.Bold = true;
          builder.Write("Дата рождения: ");
          builder.Font.Bold = false;
          builder.Write(resume.PersonalInfo.DateOfBirth);
          builder.Writeln();

          builder.Font.Bold = true;
          builder.Write("Пол: ");
          builder.Font.Bold = false;
          builder.Write(resume.PersonalInfo.Gender);
          builder.Writeln();

          builder.Font.Bold = true;
          builder.Write("Семейное положение: ");
          builder.Font.Bold = false;
          builder.Write(resume.PersonalInfo.MaritalStatus);
          builder.Writeln();

          builder.Font.Bold = true;
          builder.Write("Город проживания: ");
          builder.Font.Bold = false;
          builder.Write(resume.PersonalInfo.City);
          builder.Writeln();

          builder.Font.Bold = true;
          builder.Write("Электронная почта: ");
          builder.Font.Bold = false;
          builder.Write(resume.PersonalInfo.Email);
          builder.Writeln();

          builder.Font.Bold = true;
          builder.Write("Номер телефона: ");
          builder.Font.Bold = false;
          builder.Write(resume.PersonalInfo.PhoneNumber);
          builder.Writeln();
          builder.Writeln();

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


          builder.InsertBreak(Aspose.Words.BreakType.ColumnBreak);

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
          builder.Write("Навыки и достижения");
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

          foreach (var achievement in resume.Achievements)
          {
            builder.Font.Size = 12;
            builder.Font.Bold = true;
            builder.Write("Профессиональные достижения: ");
            builder.Font.Bold = false;
            builder.Write(achievement.AchievementName);
            builder.Writeln();
          }

          doc.Save(filePath);
        }
        catch (Aspose.Words.FileCorruptedException e)
        {
          MessageBox.Show("Файл коррумпирован: " + e.Message);
        }
        catch (System.IO.IOException e)
        {
          MessageBox.Show("Ошибка ввода/вывода: " + e.Message);
        }
        catch (System.InvalidOperationException e)
        {
          MessageBox.Show("Недопустимая операция: " + e.Message);
        }
        catch (Exception e)
        {
          MessageBox.Show("Общая ошибка: " + e.Message);
        }
      }
    }

    public void CreateDocumentThirdTemplate(Resume resume)
    {
      {
        try
        {
          var doc = new Aspose.Words.Document();
          var builder = new Aspose.Words.DocumentBuilder(doc);

          builder.ParagraphFormat.Alignment = ParagraphAlignment.Left;

          
          builder.PageSetup.TextColumns.SetCount(3);
          builder.PageSetup.TextColumns.EvenlySpaced = true;
          builder.PageSetup.TextColumns.LineBetween = true;

          builder.Font.Size = 20;
          builder.Font.Bold = false;
          builder.Write("Личные данные");
          builder.Writeln();

          builder.Font.Size = 12;
          builder.Font.Bold = true;
          builder.Write("ФИО: ");
          builder.Font.Bold = false;
          builder.Write(resume.PersonalInfo.FullName);
          builder.Writeln();

          builder.Font.Bold = true;
          builder.Write("Дата рождения: ");
          builder.Font.Bold = false;
          builder.Write(resume.PersonalInfo.DateOfBirth);
          builder.Writeln();

          builder.Font.Bold = true;
          builder.Write("Пол: ");
          builder.Font.Bold = false;
          builder.Write(resume.PersonalInfo.Gender);
          builder.Writeln();

          builder.Font.Bold = true;
          builder.Write("Семейное положение: ");
          builder.Font.Bold = false;
          builder.Write(resume.PersonalInfo.MaritalStatus);
          builder.Writeln();

          builder.Font.Bold = true;
          builder.Write("Город проживания: ");
          builder.Font.Bold = false;
          builder.Write(resume.PersonalInfo.City);
          builder.Writeln();

          builder.Font.Bold = true;
          builder.Write("Электронная почта: ");
          builder.Font.Bold = false;
          builder.Write(resume.PersonalInfo.Email);
          builder.Writeln();

          builder.Font.Bold = true;
          builder.Write("Номер телефона: ");
          builder.Font.Bold = false;
          builder.Write(resume.PersonalInfo.PhoneNumber);
          builder.Writeln();
          builder.Writeln();

          builder.InsertBreak(Aspose.Words.BreakType.ColumnBreak);
          
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

          builder.InsertBreak(Aspose.Words.BreakType.ColumnBreak);

          builder.Font.Size = 20;
          builder.Font.Bold = false;
          builder.Write("Навыки и достижения");
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

          foreach (var achievement in resume.Achievements)
          {
            builder.Font.Size = 12;
            builder.Font.Bold = true;
            builder.Write("Профессиональные достижения: ");
            builder.Font.Bold = false;
            builder.Write(achievement.AchievementName);
            builder.Writeln();
          }

          doc.Save(filePath);
        }
        catch (Aspose.Words.FileCorruptedException e)
        {
          MessageBox.Show("Файл коррумпирован: " + e.Message);
        }
        catch (System.IO.IOException e)
        {
          MessageBox.Show("Ошибка ввода/вывода: " + e.Message);
        }
        catch (System.InvalidOperationException e)
        {
          MessageBox.Show("Недопустимая операция: " + e.Message);
        }
        catch (Exception e)
        {
          MessageBox.Show("Общая ошибка: " + e.Message);
        }
      }
    }
    public ResumeForm()
    {
      InitializeComponent();
    }

  }
}

