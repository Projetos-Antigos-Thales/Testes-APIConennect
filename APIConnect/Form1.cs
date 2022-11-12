using Newtonsoft.Json;
using APIConnect.Model;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;
using System.Collections.Generic;
using System.Drawing;

namespace APIConnect
{
    public partial class APIConnect : Form
    {
        List<List<string>> requests = new List<List<string>>();

        public APIConnect()
        {
            InitializeComponent();
        }

        private void APIConnect_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void nET60ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void nET31ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void nET22ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void btnSearchFile1_Click(object sender, EventArgs e)
        {
            try
            {
                #region Open FileDialog to find the JSON
                string filePath = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog1.FileName;
                }
                #endregion Open FileDialog to find the JSON

                #region Find the JSON file
                if (!filePath.Equals(""))
                {
                    string extension = filePath.Split(".").Last();
                    if (extension.Equals("json"))
                    {
                        PostmanCollection pCollection;
                        using (StreamReader r = new StreamReader(filePath))
                        {
                            string json = r.ReadToEnd();
                            pCollection = JsonConvert.DeserializeObject<PostmanCollection>(json);
                        }
                        if (pCollection != null)
                        {
                            // MessageBox.Show(pCollection.Item.FirstOrDefault()?.Name);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Extensão \".{extension}\" não permitida!");
                    }
                }
                #endregion Find the JSON file
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Arquivo não encontrado!");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Diretório não existe!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }

        private void btnSearchFile2_Click(object sender, EventArgs e)
        {
            try
            {
                #region Open FileDialog to find the JSON
                string filePath = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog1.FileName;
                }
                #endregion Open FileDialog to find the JSON

                #region Find the JSON file
                if (!filePath.Equals(""))
                {
                    string extension = filePath.Split(".").Last();
                    if (extension.Equals("json"))
                    {
                        PostmanCollection pCollection;
                        using (StreamReader r = new StreamReader(filePath))
                        {
                            string json = r.ReadToEnd();
                            pCollection = JsonConvert.DeserializeObject<PostmanCollection>(json);
                        }
                        if (pCollection != null)
                        {
                            foreach (Item item in pCollection.Item)
                            {
                                List<string> headers = new List<string>();
                                for (int i = 0; i < item.Request.Header.Count; i++)
                                {
                                    headers.Add(item.Request.Header.ElementAt(i).Key + ": " + item.Request.Header.ElementAt(i).Value);
                                }

                                string[] row = { item.Name, item.Request.Method, item.Request.Url.Raw,
                                        headers.Count > 0? headers.ElementAt(0): null, headers.Count > 1? headers.ElementAt(1): null,
                                        headers.Count > 2? headers.ElementAt(2): null, headers.Count > 4? headers.ElementAt(3): null ,
                                        headers.Count > 4? headers.ElementAt(4): null};
                                dataGridView1.Rows.Add(row);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Extensão \".{extension}\" não permitida!");
                    }
                }
                #endregion Find the JSON file
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Arquivo não encontrado!");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Diretório não existe!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }

        }

        private void btnCreateClass_Click(object sender, EventArgs e)
        {
            #region Verify the file name, and start the process of Class Generation
            if (!txtClassName.Text.Equals("") && Regex.IsMatch(txtClassName.Text, @"^[a-zA-Z]+$"))
            {
                CreateConnectionClass();
            }
            else
            {
                MessageBox.Show("Informe um nome válido para a nova classe!");
            }
            #endregion Verify the file name, and start the process of Class Generation
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            #region Deletes everything in DataGridView
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            #endregion Deletes everything in DataGridView
        }


        private void CreateConnectionClass()
        {
            try
            {
                #region Select folder to new class
                string selectedFolder = "";
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        selectedFolder = fbd.SelectedPath;
                    }
                }
                #endregion Select folder to new class

                #region Creates the file
                string newClass = GenerateClasses();

                if (!selectedFolder.Equals(""))
                {
                    using (FileStream fs = File.Create((selectedFolder + "\\") + (txtClassName.Text) + (".cs")))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(newClass);
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }
                }
                #endregion Creates the file
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Arquivo não encontrado!");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Diretório não existe!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }

        private string GenerateClasses()
        {
            string newClass = "";

            #region Get DataGridView values
            int qColums = 8, qRows = dataGridView1.Rows.Count - 1;

            List<string> row = new List<string>();

            int x = 0, y = 0;
            for (x = x; x < qRows;)
            {
                string cell = dataGridView1[y, x].Value != null ? dataGridView1[y, x].Value.ToString() : "";
                row.Add(cell);

                if (y == (qColums - 1))
                {
                    x++; y = 0;
                    requests.Add(row);
                    row = new List<string>();
                }
                else
                {
                    y++;
                }
            }
            #endregion Get DataGridView values

            #region Generates the new class
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string methodName = requests.ElementAt(i).ElementAt(0);
                if (Regex.IsMatch(txtClassName.Text, @"^[a-zA-Z]+$"))
                {
                    methodName = RemoveSpecialCharacters(methodName);
                }
                newClass += "\n\n\n" + GenerateClass(methodName, GenerateClassContent(requests.ElementAt(i)));
            }
            #endregion  Generates the new class

            return newClass;
        }

        private string GenerateClassContent(List<string> request)
        {
            return null;
        }

        private string GenerateClass(string className, string content)
        {
            #region Get the class info together
            string open = "{", close = "}";
            return $"private void {className}(){open}{content}{close}";
            #endregion Get the class info together
        }


        private string RemoveSpecialCharacters(string str)
        {
            #region Cleans the string
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
            #endregion Cleans the string
        }

    }
}