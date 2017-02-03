using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> dictionary=new Dictionary<string, string>();
        string[] keys;
        FileStream fs ;
        StreamWriter familiarWordWriter ;
        int timeInterval = 3000;
        public Form1()
        {
            loadGRE3000();
            loadAndSortTheFamiliarWordList();
            this.Opacity = 0.7;

            InitializeComponent();

            Thread displayWordThread = new Thread(startDisplayWords);
            displayWordThread.IsBackground = true;
            displayWordThread.Start();


        }

        private void loadAndSortTheFamiliarWordList()
        {
            fs = new FileStream("familiarWordList", FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(fs);
            string wordsToDelete = reader.ReadToEnd().ToString();
            fs.Close();
            string[] words = wordsToDelete.Split('\n');
            HashSet<string> familiarWordList = new HashSet<string>();
            foreach (string word in words)
            {
                familiarWordList.Add(word);
                if (dictionary.ContainsKey(word))
                {
                    dictionary.Remove(word);
                }
            }
            keys = dictionary.Keys.ToArray<string>();
            if (familiarWordList.Count != words.Length)
            {
                fs = new FileStream("familiarWordList", FileMode.Create);
                familiarWordWriter = new StreamWriter(fs);
                foreach (string word in familiarWordList)
                {
                    familiarWordWriter.Write(word);
                    familiarWordWriter.Write('\n');
                }
                familiarWordWriter.Flush();
                familiarWordWriter.Close();
            }
            

            fs = new FileStream("familiarWordList", FileMode.Append);
            familiarWordWriter = new StreamWriter(fs);
        }

        private void updateWordLabels(string word)
        {
            WordLabel.Text = word;
            TransLabel.Text = dictionary[word];
        }
       
        private void startDisplayWords()
        {
            Thread.Sleep(10);
            while (true)
            {
                
                BeginInvoke((MethodInvoker) delegate {
                    updateWordLabels(getNextWord());
                });
                Thread.Sleep(timeInterval);

            }
        }
        private string getNextWord()
        {
            Random random = new Random();

            int index = random.Next(dictionary.Count);
            return keys[index];
        }

        private void loadGRE3000()
        {
            string wordListString = Resource1.WordList1;
            string[] lines = wordListString.Split('\n');
            Console.WriteLine(lines.Length);
            for (int i = 0; i < lines.Length; ++i)
            {
                if (lines[i].StartsWith("Q: "))
                {
                    string word = lines[i].Split(' ')[1];
                    word=word.Remove(word.Length - 1);
                    while (i < lines.Length && !lines[i].StartsWith("A: \r"))
                    {
                        ++i;
                    }
                    ++i;
                    StringBuilder transOfWord = new StringBuilder(string.Empty);
                    while (i < lines.Length && lines[i].Length > 1)
                    {
                        transOfWord.Append(lines[i]).Append('\n');
                        ++i;
                    }
                    if (dictionary.Keys.Contains(word))
                    {
                        transOfWord.Append(dictionary[word]);
                        dictionary[word] = transOfWord.ToString();
                    }
                    else
                    {
                        string transResult = transOfWord.ToString();
                        dictionary.Add(word, transResult);
                    }
                }
            }
            keys = dictionary.Keys.ToArray<string>();
            Console.WriteLine(dictionary.Count);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            string wordToDelete = WordLabel.Text;
            if (dictionary.Keys.Contains(wordToDelete)) { 
                dictionary.Remove(wordToDelete);
                familiarWordWriter.Write(wordToDelete);
                familiarWordWriter.Write("\n");
                familiarWordWriter.Flush();
                updateWordLabels(getNextWord());
                keys = dictionary.Keys.ToArray<string>();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool leftFlag = false;
        Point mouseOff;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }

        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            if (this.WordLabel.ForeColor.Equals(System.Drawing.SystemColors.Control))
            {
                this.WordLabel.ForeColor = System.Drawing.SystemColors.ControlText;
                this.TransLabel.ForeColor = System.Drawing.SystemColors.ControlText;
                this.BackColor = System.Drawing.SystemColors.Control;
            }
            else
            {
                this.WordLabel.ForeColor = System.Drawing.SystemColors.Control;
                this.TransLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            }
               
        }
    }
}
