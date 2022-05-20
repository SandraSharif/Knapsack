using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Knapsack
{
    public partial class Form1 : Form
    {
        public class RuckArticle
        {
            public string name { get; set; }
            public int weight { get; set; }
            public int value { get; set; }
            public RuckArticle(string art_name, int art_weight, int art_value)
            {
                name = art_name;
                weight = art_weight;
                value = art_value;
            }
        }
        private List<RuckArticle> articles;
        private List<RuckArticle> decision_art;
        private string text_save = "";
        public Form1()
        {
            InitializeComponent();
            articles = new List<RuckArticle>();
            decision_art = new List<RuckArticle>();
        }
        public int[][] memoiz(List<RuckArticle> full)
        {
            int[][] A;
            A = new int[full.Count + 1][];
            int ruck_weight = Convert.ToInt32(numericUpDown_weightruck.Value);
            progressBar_packing.Maximum = (full.Count + 1)*(ruck_weight+1);
            progressBar_packing.Value = 0;
            for (int i = 0; i < full.Count + 1; i++)
            {
                A[i] = new int[ruck_weight + 1];
            }
            for (int k = 0; k <= full.Count; k++)
            {
                for (int s = 0; s <= ruck_weight; s++)
                {
                    if ((k == 0) || (s == 0))
                    {
                        A[k][s] = 0;
                        progressBar_packing.Value++;
                    }
                    else
                    {
                        if (s >= full[k - 1].weight)
                        {
                            A[k][s] = Math.Max(A[k - 1][s], A[k - 1][s - full[k - 1].weight] + full[k - 1].value);
                        }
                        else
                        {
                            A[k][s] = A[k - 1][s];
                        }
                        progressBar_packing.Value++;
                    }
                }
            }
            progressBar_packing.Value = 0;
            return A;
        }
        private void traceResult(int[][] A, List<RuckArticle> full_l)
        {
            int k = full_l.Count;
            int s = Convert.ToInt32(numericUpDown_weightruck.Value);
            int fin_value = Convert.ToInt32(A[k][s]);
            for (int i = k; i > 0; i--)
            {
                if (fin_value <= 0)
                {
                    progressBar_packing.Value = progressBar_packing.Maximum;
                    return;
                }
                if (A[i - 1][s] == fin_value)
                {
                    continue;
                }
                else
                {    
                decision_art.Add(new RuckArticle(full_l[i - 1].name, full_l[i - 1].weight, full_l[i -1].value));
                    fin_value -= full_l[i - 1].value;
                    s -= full_l[i - 1].weight;
                    progressBar_packing.Value++;
                }
            }
            progressBar_packing.Value = progressBar_packing.Maximum;
        }
        private void ShowList(List<RuckArticle> view_list)
        {
            listView_articles.Items.Clear();
            foreach (RuckArticle i in view_list)
            {
                listView_articles.Items.Add(new ListViewItem(new string[] { i.name, i.weight.ToString(), i.value.ToString() }));
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listView_articles.Columns.Add("Наименование", 100, HorizontalAlignment.Left);
            listView_articles.Columns.Add("Вес", 100, HorizontalAlignment.Left);
            listView_articles.Columns.Add("Ценность", 100, HorizontalAlignment.Left);
            timer1.Enabled = true;
            toolStripStatusLabel1.Text = DateTime.Now.ToString("ddd dd MMMM yyyy HH:mm:ss");
            progressBar_packing.Value = 0;
            progressBar_listcreating.Value = 0;
            numericUpDown_weightruck.Maximum = 10000;
            numericUpDown_countarticle.Maximum = 10000;
            numericUpDown_weightruck.Value = 1;
            numericUpDown_countarticle.Value = 1;
        }
        private void buttonStartKnapsack_Click(object sender, EventArgs e)
        {           
                if (articles.Count != 0)
            {
                ShowList(articles);
                if (decision_art.Count != 0)
                {
                    decision_art.Clear();
                }
                int max_w = Convert.ToInt32(numericUpDown_weightruck.Value);
                int numbers = articles.Count;
                int[][] ar_mem = new int[numbers + 1][];
                for (int i = 0; i < articles.Count + 1; i++)
                {
                    ar_mem[i] = new int[max_w + 1];
                }
                ar_mem = memoiz(articles);
                traceResult(ar_mem, articles);
                if (decision_art.Count != 0)
                {
                    foreach (ListViewItem item in listView_articles.Items)
                    {
                        foreach (RuckArticle m in decision_art)
                        {
                            if (m.name == item.SubItems[0].Text)
                            {
                                item.BackColor = Color.LightGreen;
                            }
                        }
                    }
                    MessageBox.Show("Рюкзак упакован, сложенные в него предметы выделены в таблице зелёным цветом");
                }
                else
                {
                    MessageBox.Show("Ни один предмет из списка не поместился в рюкзак, на экране показан первоначальный список всех предметов без изменений");
                }
            }
            else
            {
                MessageBox.Show("Список предметов, из которых нужно собрать рюкзак, не может быть пустым");
            }
        }
        private void buttonForSelfAdd_Click(object sender, EventArgs e)
        {
            bool fix_repeat = false;
            Adding addpr = new Adding(this);
            addpr.Owner = this;
            addpr.ShowDialog();
            string addart_name = addpr.art_name;
            int addart_weight = addpr.art_weight;
            int addart_value = addpr.art_value;
            int repeat_count = 0;
            foreach (RuckArticle i in articles)
            {
                if (i.name.ToLower() == addart_name.ToLower())
                {
                    fix_repeat = true;
                    Form2 to_add = new Form2(this);
                    to_add.Owner = this;
                    to_add.ShowDialog();
                    string addart_name_rep = to_add.art_name_repeat;
                    int how_many = to_add.art_count;
                    repeat_count++;
                    if (addart_name_rep == "Increase")
                    {
                        foreach (RuckArticle m in articles)
                        {
                            if (m.name.ToLower() == addart_name.ToLower())
                            {
                                m.weight = how_many * m.weight;
                                m.value = how_many * m.value;
                                MessageBox.Show("Количество экземпляров этого предмета увеличено, изменение отображено в списке");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Количество экземпляров этого предмета осталось прежним, список всех предметов не изменился");
                    }
                }
            }
            if (repeat_count == 0)
            {
                foreach (RuckArticle i in articles)
                {
                    if (i.name.ToLower() != addart_name.ToLower())
                    {
                        if ((i.weight == addart_weight) && (i.value == addart_value))
                        {
                            MessageBox.Show("Предмет с такими весом и ценностью уже есть в списке");
                            repeat_count++;
                            break;
                        }
                    }
                }
            }
            if ((repeat_count == 0) && (addart_name != "NOADD") && (fix_repeat == false))
                {
                    articles.Add(new RuckArticle(addart_name, addart_weight, addart_value));
                MessageBox.Show("Предмет успешно добавлен");
                }
            ShowList(articles);
        }
        private void buttonForDecision_Click(object sender, EventArgs e)
        {           
            if (decision_art.Count != 0)
            {
                listView_articles.Items.Clear();
                ShowList(decision_art);
            }
            else
            {
                if (articles.Count != 0)
                {
                    MessageBox.Show("В рюкзак не поместился ни один предмет из списка!");
                }
                else
                {
                    MessageBox.Show("Рюкзак не был упакован, так как список всех предметов пуст!");
                }
            }
        }
        private void buttonForFirstList_Click(object sender, EventArgs e)
        {
            if (articles.Count != 0)
            {
                listView_articles.Items.Clear();
                ShowList(articles);
            }
            else
            {
                MessageBox.Show("Список всех предметов пуст!");
            }
        }
        private void numericUpDown_countarticle_ValueChanged(object sender, EventArgs e)
        {
            articles.Clear();
            decision_art.Clear();
            progressBar_listcreating.Minimum = 0;
            progressBar_listcreating.Maximum = Convert.ToInt32(numericUpDown_countarticle.Value);
            progressBar_listcreating.Value = 0;
            Random r = new Random();
            for (int i = 0; i < numericUpDown_countarticle.Value; i++)
            {
                int w = r.Next(1, 1000);
                int v = r.Next(1, 1000);
                int num = i + 1;
                int repeat_count = 0;
                string name_pr = "Предмет" + num.ToString();
                foreach (RuckArticle k in articles)
                {
                    if ((k.weight == w) && (k.value == v))
                    {
                        repeat_count++;
                    }
                }
                if (repeat_count == 0)
                {
                    articles.Add(new RuckArticle(name_pr, w, v));
                    progressBar_listcreating.Value++;
                }
                else
                {
                    i--;
                }
            }
            ShowList(articles);
        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("dddd dd MMMM yyyy HH:mm:ss");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("dddd dd MMMM yyyy HH:mm:ss");
        }
        private void открытьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            articles.Clear();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) { return; }
            string filename = openFileDialog1.FileName;
            List<string> str = new List<string>();
            str = System.IO.File.ReadAllLines(filename).ToList();
            for (int i = 0; i < str.Count; i++)
            {
                string[] str_art = str[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                articles.Add(new RuckArticle(str_art[0], Convert.ToInt32(str_art[1]), Convert.ToInt32(str_art[2])));
                ShowList(articles);
            }
            MessageBox.Show("Список открыт");
        }
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            articles.Clear(); 
            decision_art.Clear();
            listView_articles.Items.Clear();
            progressBar_packing.Value = 0;
            progressBar_listcreating.Value = 0;
        }
        private void сохранитьСписокВФайлToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (articles.Count != 0)
            {
                saveFileDialog1.Filter = "Text files(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) { return; }
            string filename = saveFileDialog1.FileName;
            List<string> str = new List<string>();
            int i = 0;
            string str_file;
                while (i < articles.Count)
                {
                    str_file = articles[i].name + " " + articles[i].weight.ToString() + " " + articles[i].value.ToString();
                    str.Add(str_file);
                    i++;
                }
                System.IO.File.WriteAllLines(filename, str);
                MessageBox.Show("Первоначальный список успешно сохранён");
            }
            else
            {
                MessageBox.Show("Список всех предметов пуст!");
            }             
        }
        private void сохранитьРешениеВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (decision_art.Count != 0)
            {
                saveFileDialog1.Filter = "Text files(*.txt)|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) { return; }
                string filename = saveFileDialog1.FileName;
                List<string> str_list = new List<string>();
                int i = 0;
                string str_file;
                while (i < decision_art.Count)
                {
                    str_file = decision_art[i].name + " " + decision_art[i].weight.ToString() + " " + decision_art[i].value.ToString();
                    str_list.Add(str_file);
                    i++;
                }
                System.IO.File.WriteAllLines(filename, str_list);
                MessageBox.Show("Содержимое упакованного рюкзака сохранено");
            }
            else
            {
                if (articles.Count != 0)
                {
                    MessageBox.Show("В рюкзак не поместился ни один предмет из списка!");
                }
                else
                {
                    MessageBox.Show("Рюкзак не был упакован, так как список всех предметов пуст!");
                }
            }
        }
        private void очиститьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            listView_articles.Items.Clear();
            articles.Clear(); 
            decision_art.Clear(); 
            progressBar_packing.Value = 0;
            progressBar_listcreating.Value = 0;
        }
        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(text_save, new Font("Times New Roman", 14), Brushes.Black, 0, 0);
        }
        private void печатьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            text_save = null;
            if (articles.Count != 0)
            {
                    text_save += "Предметы выбирались из списка: \n\t";
                    for (int i = 0; i < articles.Count; i++)
                    {
                        text_save = text_save + articles[i].name.ToString() + " " + articles[i].weight.ToString() + " " + articles[i].value.ToString() + "\n\t";
                    }
                    text_save += "В рюкзак были сложены предметы: \n\t";
                    for (int i = 0; i < decision_art.Count; i++)
                    {
                        text_save = text_save + decision_art[i].name.ToString() + " " + decision_art[i].weight.ToString() + " " + decision_art[i].value.ToString() + "\n\t";
                    }
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += PrintPageHandler;
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDialog.Document.Print();
                }
            }
            else
            {
                MessageBox.Show("Печать невозможна, так как список всех предметов пуст, вследствие чего рюкзак не был упакован");
            }
        }
        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

