using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        DataTable dt;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        SqlConnection con;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
             this.lessonsTableAdapter1.Fill(this.bdiplomDataSet1.Lessons);
             dGV.ReadOnly = true;
        } 

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addButtonClick(object sender, EventArgs e)
        {
            if (alertAdd.Visible)
                alertAdd.Visible = false;

            if (string.IsNullOrEmpty(nameBoxAdd.Text) || string.IsNullOrWhiteSpace(nameBoxAdd.Text)
                || string.IsNullOrEmpty(discBoxAdd.Text) || string.IsNullOrWhiteSpace(discBoxAdd.Text)
                || string.IsNullOrEmpty(lessonBoxAdd.Text) || string.IsNullOrWhiteSpace(lessonBoxAdd.Text)
                || string.IsNullOrEmpty(auditBoxAdd.Text) || string.IsNullOrWhiteSpace(auditBoxAdd.Text))
            {
                alertAdd.Visible = true;
                alertAdd.Text = "Все поля должны быть заполнены!";
            }

            if (!Int32.TryParse(lessonBoxAdd.Text, out var n))
            {
                alertAdd.Visible = true;
                alertAdd.Text = "Поле 'Пара' должно быть цифровым!";
                return;
            }

            /*string lesson = lessonBoxAdd.Text;
            string name = nameBoxAdd.Text;
            string disc = discBoxAdd.Text;
            string audit = auditBoxAdd.Text;
            string date = dateTimeAdd.Text;
            //dt.DataSet[bdiplomDataSet];
            var row = dt.NewRow();
            row[1] = lessonBoxAdd.Text;
            row[2] = nameBoxAdd.Text;
            row[3] = discBoxAdd.Text;
            row[4] = auditBoxAdd.Text;
            row[5] = dateTimeAdd.Text;
            dt.Rows.Add(row);
            alertAdd.Visible = true;
            alertAdd.Text = "Сохранено!";*/

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (alertChange.Visible)
                alertChange.Visible = false;

            if (string.IsNullOrEmpty(nameBoxChange.Text) || string.IsNullOrWhiteSpace(nameBoxChange.Text)
                || string.IsNullOrEmpty(discBoxChange.Text) || string.IsNullOrWhiteSpace(discBoxChange.Text)
                || string.IsNullOrEmpty(lessonBoxChange.Text) || string.IsNullOrWhiteSpace(lessonBoxChange.Text)
                || string.IsNullOrEmpty(auditBoxChange.Text) || string.IsNullOrWhiteSpace(auditBoxChange.Text))
            {
                alertChange.Visible = true;
                alertChange.Text = "Все поля должны быть заполнены!";
                return;
            }

            if (!Int32.TryParse(lessonBoxChange.Text, out var n))
            {
                alertChange.Visible = true;
                alertChange.Text = "Поле 'Пара' должно быть цифровым!";
                return;
            }

            if (Int32.TryParse(idBoxChange.Text, out var m))
            {
                var result = from DataRow myRow in dt.Rows
                             where (int)myRow[0] == m
                             select myRow;


                var rowToChange = result.FirstOrDefault();

                if (rowToChange != null)
                {
                    rowToChange.BeginEdit();
                    rowToChange[1] = lessonBoxChange.Text;
                    rowToChange[2] = nameBoxChange.Text;
                    rowToChange[3] = discBoxChange.Text;
                    rowToChange[4] = auditBoxChange.Text;
                    rowToChange[5] = dateTimeChange.Text;

                    alertChange.Visible = true;
                    alertChange.Text = "Готово!";
                    try
                    {
                        dt.Rows[0].EndEdit();
                        dt.Rows[1].EndEdit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Произошло исключение {0} при комплияции!",
                            ex.GetType());
                    }
                }
                else
                {
                    alertChange.Visible = true;
                    alertChange.Text = "Такой ID не найден!";
                }
            }

            else
            {
                alertChange.Visible = true;
                alertChange.Text = "Неверный формат, введите число!";
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (alertDelete.Visible)
                alertDelete.Visible = false;

            if (!string.IsNullOrEmpty(idBoxDelete.Text) && !string.IsNullOrWhiteSpace(idBoxDelete.Text))
            {
                if (Int32.TryParse(idBoxDelete.Text, out var n))
                {
                    var result = from DataRow myRow in dt.Rows
                                 where (int)myRow[0] == n
                                 select myRow;


                    var rowToDelete = result.FirstOrDefault();

                    if (rowToDelete != null)
                    {
                        dt.Rows.Remove(rowToDelete);

                        alertDelete.Visible = true;
                        alertDelete.Text = "Готово!";
                    }
                    else
                    {
                        alertDelete.Visible = true;
                        alertDelete.Text = "Такой ID не найден!";
                    }
                }
                else
                {
                    alertDelete.Visible = true;
                    alertDelete.Text = "Неверный формат, введите число!";
                }
            }
            else
            {
                alertDelete.Visible = true;
                alertDelete.Text = "Введите значение ID!";
            }
        }

        private void RebootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dGV.Refresh();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ПО для контроля и учета заявок вычислительного центра. " +
                "\r\n\r\nv.1.0 " +
                "\r\n\r\nБулаш Андрей Олегович П-403");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream mystr = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((mystr = openFileDialog1.OpenFile()) != null)
                {
                    StreamReader myread = new StreamReader(mystr);
                    string[] str;
                    int num = 0;
                    try
                    {
                        string[] str1 = myread.ReadToEnd().Split('\n');
                        num = str1.Count();
                        dGV.RowCount = num;
                        for (int i = 0; i < num; i++)
                        {
                            str = str1[i].Split('^');
                            for (int j = 0; j < dGV.ColumnCount; j++)
                            {
                                try
                                {
                                    dGV.Rows[i].Cells[j].Value = str[j];
                                }
                                catch { }
                            }
                        }
                            
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myread.Close();
                    }
                }
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter myWriter = new StreamWriter(myStream);
                    try
                    {
                        for (int i = 0; i < dGV.RowCount; i++)
                        {                            
                            for (int j = 0; j < dGV.ColumnCount; j++)
                            {
                                try
                                {
                                    myWriter.Write(dGV.Rows[i].Cells[j].Value.ToString() + " ");
                                }
                                catch { }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                       myWriter.Close();
                    }
                }
            }
        }

    }
}