using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FordProgBeadando
{
    public partial class Form1 : Form
    {
        string inputFile;
        string outputFile = "";
        string inputFileName = "input.txt";
        string outputFileName = "export.txt";
        string[] inputSplit;
        string[] inputSplitRow;    

        string input;
        string state;
        string numbers = "";       

        public Form1()
        {
            InitializeComponent();
            Read(inputFileName);
            ReadTxt();   
        }

        private void ClearTable()
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
        }

        private void WriteTxt()
        {
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        outputFile += dataGridView.Columns[j].HeaderText;
                        if (j < dataGridView.ColumnCount - 1)
                            outputFile += ';';
                    }
                    outputFile += "\n";
                }
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    if (j == 0)
                    {
                        outputFile += dataGridView.Rows[i].HeaderCell.Value + ";";
                    }
                    outputFile += dataGridView[j, i].Value;
                    if (j < dataGridView.ColumnCount - 1)
                        outputFile += ";";
                    else
                        outputFile += "\n";
                }
            }
        }

        private void ReadTxt()
        {
            inputSplit = inputFile.Split('\n');
            for (int i = 0; i < inputSplit.Length; i++)
            {
                inputSplitRow = inputSplit[i].Split(';');
                if (i == 0)
                {
                    for (int j = 0; j < inputSplitRow.Length; j++)
                    {
                        dataGridView.Columns.Add(inputSplitRow[j], inputSplitRow[j]);
                    }
                }
                dataGridView.Rows.Add();
                for (int j = 0; j < inputSplitRow.Length; j++)
                {
                    if (j == 0)
                    {
                        if (i > 0)
                        {
                            dataGridView.Rows[i].HeaderCell.Value = inputSplitRow[j];
                        }
                    }
                    else
                    {
                        dataGridView[j - 1, i].Value = inputSplitRow[j];
                    }
                }

            }
            dataGridView.Rows.RemoveAt(0);
        }

        public void Read(string fname)
        {
            StreamReader sr = new StreamReader(File.OpenRead(@fname));
            inputFile = sr.ReadToEnd();
            sr.Close();
        }

        public void Write()
        {
            StreamWriter sw = new StreamWriter(File.OpenWrite(@outputFileName));
            sw.Write(outputFile);
            sw.Flush();
            sw.Close();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            numbers = "";
            rTB.Text = "";
            int rowindex = -1;
            int columnindex = -1;          

            state = dataGridView.Rows[0].HeaderCell.Value.ToString() + "#";
            input = tBInput.Text;
            input = Regex.Replace(input, "[0-9]", "i");
            input = Regex.Replace(input, " ", "");

            if (input[input.Length - 1] != '#')
            {
                input = input + "#";
                tBInput.Text = input;
            }
                
            string actState = state[0].ToString();
            
            rTB.AppendText(input + "," + state + "," + numbers);
            while (true)
            {
                columnindex = -1;
                rowindex = -1;
                if (state[1].ToString() == "'") { actState = state[0].ToString() + state[1].ToString(); }
                else { actState = state[0].ToString(); }
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    if (actState == dataGridView.Rows[i].HeaderCell.Value.ToString())
                    {
                        rowindex = i;
                    }
                }

                if (rowindex == -1)
                {
                    rTB.Text += string.Format("\nHiba a bemeneti állapot `{0}´ karakternél", actState);

                    break;
                }

                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    if (input[0].ToString() == dataGridView.Columns[i].Name.ToString())
                    {
                        columnindex = 0;

                    }
                }
                if (columnindex == -1)
                {
                    rTB.Text += string.Format("\nHiba a bemenetben a `{0}´ karakternél", input[0]);

                    break;
                }

                string command = dataGridView[input[0].ToString(), rowindex].Value.ToString();
                switch (command)
                {
                    case "pop":
                        {
                            input = input.Substring(1);
                            state = state.Substring(1);
                            rTB.AppendText("\n" + input + "," + state + "," + numbers);

                            break;
                        }

                    case "error":
                        {
                            rTB.AppendText("\n" + input + "," + state + "," + numbers);
                            rTB.AppendText(String.Format(" Hiba a bemenetben a `{0}´ karakternél", input[0]));

                            break;
                        }
                    default:
                        {
                            try
                            {
                                numbers += command.Split(',')[1].Substring(0, 1);
                                if ((command.Split(',')[0])[1] == '$')
                                {
                                    if (state[1].ToString() == "'") { state = state.Substring(2); }
                                    else { state = state.Substring(1); }
                                    rTB.AppendText("\n" + input + "," + state + "," + numbers);
                                }
                                else
                                {
                                    if (state[1].ToString() == "'") { state = command.Split(',')[0].Substring(1) + state.Substring(2); }
                                    else { state = command.Split(',')[0].Substring(1) + state.Substring(1); }
                                    rTB.AppendText("\n" + input + "," + state + "," + numbers);
                                }
                            }
                            catch
                            {
                                rTB.AppendText(String.Format("A {0} oszlop, {1}. sorának utasítása hibás", input[0].ToString(), rowindex));
                            }
                            break;
                        }
                }
                if (input == state && state == "#")
                {
                    rTB.AppendText("\n" + input + "," + state + "," + numbers + " elfogadva");
                    break;
                }
                if (command == "error")
                    break;

                if (sw.Elapsed > TimeSpan.FromMilliseconds(500))
                    break;
            }        
        }

        private void BtnTablazatBetolt_Click(object sender, EventArgs e)
        {
            ofp.Filter = "Text|*.txt*.*";
            ofp.ShowDialog();
            StreamReader sr = new StreamReader(File.OpenRead(ofp.FileName));
            inputFile = sr.ReadToEnd();
            ClearTable();
            ReadTxt();
        }

        private void BTNTablaTorol_Click(object sender, EventArgs e)
        {
            ClearTable();
        }

        private void btnSaveOutput_Click(object sender, EventArgs e)
        {

            StreamWriter writer = File.AppendText(outputFileName);
            writer.Write(rTB.Text);
            writer.Close();
        }

        private void btnSaveTable_Click(object sender, EventArgs e)
        {
            sfd.Filter = "Text|*.txt*.*";
            sfd.ShowDialog();
            StreamWriter sw = new StreamWriter(File.OpenWrite(@sfd.FileName));
            WriteTxt();
            sw.Write(outputFile);
            sw.Flush();
            sw.Close();
        }
    }
}