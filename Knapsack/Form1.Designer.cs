
namespace Knapsack
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar_packing = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_weightruck = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_articles = new System.Windows.Forms.ListView();
            this.buttonStartKnapsack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonForSelfAdd = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_countarticle = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar_listcreating = new System.Windows.Forms.ProgressBar();
            this.buttonForDecision = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьСписокВФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьРешениеВФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonForFirstList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_weightruck)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_countarticle)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar_packing
            // 
            this.progressBar_packing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar_packing.Location = new System.Drawing.Point(136, 354);
            this.progressBar_packing.Name = "progressBar_packing";
            this.progressBar_packing.Size = new System.Drawing.Size(677, 23);
            this.progressBar_packing.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-1, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Упаковка рюкзака...";
            // 
            // numericUpDown_weightruck
            // 
            this.numericUpDown_weightruck.Location = new System.Drawing.Point(606, 40);
            this.numericUpDown_weightruck.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_weightruck.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_weightruck.Name = "numericUpDown_weightruck";
            this.numericUpDown_weightruck.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_weightruck.TabIndex = 3;
            this.numericUpDown_weightruck.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(444, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вместимость рюкзака";
            // 
            // listView_articles
            // 
            this.listView_articles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView_articles.HideSelection = false;
            this.listView_articles.Location = new System.Drawing.Point(16, 56);
            this.listView_articles.Name = "listView_articles";
            this.listView_articles.Size = new System.Drawing.Size(421, 248);
            this.listView_articles.TabIndex = 5;
            this.listView_articles.UseCompatibleStateImageBehavior = false;
            this.listView_articles.View = System.Windows.Forms.View.Details;
            // 
            // buttonStartKnapsack
            // 
            this.buttonStartKnapsack.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartKnapsack.Location = new System.Drawing.Point(530, 148);
            this.buttonStartKnapsack.Name = "buttonStartKnapsack";
            this.buttonStartKnapsack.Size = new System.Drawing.Size(158, 54);
            this.buttonStartKnapsack.TabIndex = 6;
            this.buttonStartKnapsack.Text = "Начать упаковку рюкзака";
            this.buttonStartKnapsack.UseVisualStyleBackColor = true;
            this.buttonStartKnapsack.Click += new System.EventHandler(this.buttonStartKnapsack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Список предметов:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonForSelfAdd
            // 
            this.buttonForSelfAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonForSelfAdd.Location = new System.Drawing.Point(530, 109);
            this.buttonForSelfAdd.Name = "buttonForSelfAdd";
            this.buttonForSelfAdd.Size = new System.Drawing.Size(158, 33);
            this.buttonForSelfAdd.TabIndex = 8;
            this.buttonForSelfAdd.Text = "Добавить предмет";
            this.buttonForSelfAdd.UseVisualStyleBackColor = true;
            this.buttonForSelfAdd.Click += new System.EventHandler(this.buttonForSelfAdd_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(135, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(444, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Сгенерировать список из";
            // 
            // numericUpDown_countarticle
            // 
            this.numericUpDown_countarticle.Location = new System.Drawing.Point(607, 68);
            this.numericUpDown_countarticle.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_countarticle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_countarticle.Name = "numericUpDown_countarticle";
            this.numericUpDown_countarticle.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_countarticle.TabIndex = 12;
            this.numericUpDown_countarticle.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_countarticle.ValueChanged += new System.EventHandler(this.numericUpDown_countarticle_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(733, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "предметов";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(-1, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Генерация списка...";
            // 
            // progressBar_listcreating
            // 
            this.progressBar_listcreating.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar_listcreating.Location = new System.Drawing.Point(136, 323);
            this.progressBar_listcreating.Name = "progressBar_listcreating";
            this.progressBar_listcreating.Size = new System.Drawing.Size(677, 23);
            this.progressBar_listcreating.TabIndex = 15;
            // 
            // buttonForDecision
            // 
            this.buttonForDecision.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonForDecision.Location = new System.Drawing.Point(530, 208);
            this.buttonForDecision.Name = "buttonForDecision";
            this.buttonForDecision.Size = new System.Drawing.Size(158, 53);
            this.buttonForDecision.TabIndex = 17;
            this.buttonForDecision.Text = "Показать содержимое упакованного рюкзака";
            this.buttonForDecision.UseVisualStyleBackColor = true;
            this.buttonForDecision.Click += new System.EventHandler(this.buttonForDecision_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.сохранитьСписокВФайлToolStripMenuItem,
            this.сохранитьРешениеВФайлToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.печатьToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.создатьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click_1);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // сохранитьСписокВФайлToolStripMenuItem
            // 
            this.сохранитьСписокВФайлToolStripMenuItem.Name = "сохранитьСписокВФайлToolStripMenuItem";
            this.сохранитьСписокВФайлToolStripMenuItem.Size = new System.Drawing.Size(160, 20);
            this.сохранитьСписокВФайлToolStripMenuItem.Text = "Сохранить список в файл";
            this.сохранитьСписокВФайлToolStripMenuItem.Click += new System.EventHandler(this.сохранитьСписокВФайлToolStripMenuItem_Click_1);
            // 
            // сохранитьРешениеВФайлToolStripMenuItem
            // 
            this.сохранитьРешениеВФайлToolStripMenuItem.Name = "сохранитьРешениеВФайлToolStripMenuItem";
            this.сохранитьРешениеВФайлToolStripMenuItem.Size = new System.Drawing.Size(171, 20);
            this.сохранитьРешениеВФайлToolStripMenuItem.Text = "Сохранить решение в файл";
            this.сохранитьРешениеВФайлToolStripMenuItem.Click += new System.EventHandler(this.сохранитьРешениеВФайлToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click_1);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.печатьToolStripMenuItem.Text = "Печать";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click_1);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // buttonForFirstList
            // 
            this.buttonForFirstList.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonForFirstList.Location = new System.Drawing.Point(530, 264);
            this.buttonForFirstList.Name = "buttonForFirstList";
            this.buttonForFirstList.Size = new System.Drawing.Size(158, 53);
            this.buttonForFirstList.TabIndex = 18;
            this.buttonForFirstList.Text = "Показать первоначальный список";
            this.buttonForFirstList.UseVisualStyleBackColor = true;
            this.buttonForFirstList.Click += new System.EventHandler(this.buttonForFirstList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.buttonForFirstList);
            this.Controls.Add(this.buttonForDecision);
            this.Controls.Add(this.progressBar_listcreating);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown_countarticle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonForSelfAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonStartKnapsack);
            this.Controls.Add(this.listView_articles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_weightruck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar_packing);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Плотная упаковка рюкзака";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_weightruck)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_countarticle)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar_packing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView_articles;
        private System.Windows.Forms.Button buttonStartKnapsack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonForSelfAdd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.NumericUpDown numericUpDown_weightruck;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown numericUpDown_countarticle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar_listcreating;
        private System.Windows.Forms.Button buttonForDecision;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьСписокВФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьРешениеВФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.Button buttonForFirstList;
    }
}

