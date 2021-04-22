namespace Hakaton
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
            this.buttonCreatePizza = new System.Windows.Forms.Button();
            this.buttonNewPerson = new System.Windows.Forms.Button();
            this.buttonLevelUp = new System.Windows.Forms.Button();
            this.buttonAddAdvert = new System.Windows.Forms.Button();
            this.labelLevelUp = new System.Windows.Forms.Label();
            this.labelNewPerson = new System.Windows.Forms.Label();
            this.labelAddAdvert = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.timerPurchase = new System.Windows.Forms.Timer(this.components);
            this.labelPizza = new System.Windows.Forms.Label();
            this.labelPurchase = new System.Windows.Forms.Label();
            this.timerPizza = new System.Windows.Forms.Timer(this.components);
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonChek = new System.Windows.Forms.Button();
            this.pictureBoxPizza = new System.Windows.Forms.PictureBox();
            this.pictureBoxMoney = new System.Windows.Forms.PictureBox();
            this.pictureBoxPurchase = new System.Windows.Forms.PictureBox();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreatePizza
            // 
            this.buttonCreatePizza.BackgroundImage = global::Hakaton.Properties.Resources.butstart;
            this.buttonCreatePizza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreatePizza.Location = new System.Drawing.Point(120, 210);
            this.buttonCreatePizza.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreatePizza.Name = "buttonCreatePizza";
            this.buttonCreatePizza.Size = new System.Drawing.Size(130, 60);
            this.buttonCreatePizza.TabIndex = 0;
            this.buttonCreatePizza.UseVisualStyleBackColor = true;
            this.buttonCreatePizza.Click += new System.EventHandler(this.buttonCreatePizza_Click);
            // 
            // buttonNewPerson
            // 
            this.buttonNewPerson.BackgroundImage = global::Hakaton.Properties.Resources.but1;
            this.buttonNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNewPerson.Location = new System.Drawing.Point(11, 330);
            this.buttonNewPerson.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNewPerson.Name = "buttonNewPerson";
            this.buttonNewPerson.Size = new System.Drawing.Size(100, 50);
            this.buttonNewPerson.TabIndex = 1;
            this.buttonNewPerson.UseVisualStyleBackColor = true;
            this.buttonNewPerson.Visible = false;
            this.buttonNewPerson.Click += new System.EventHandler(this.buttonNewPerson_Click);
            // 
            // buttonLevelUp
            // 
            this.buttonLevelUp.BackgroundImage = global::Hakaton.Properties.Resources.but2;
            this.buttonLevelUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLevelUp.Location = new System.Drawing.Point(136, 330);
            this.buttonLevelUp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLevelUp.Name = "buttonLevelUp";
            this.buttonLevelUp.Size = new System.Drawing.Size(100, 50);
            this.buttonLevelUp.TabIndex = 1;
            this.buttonLevelUp.UseVisualStyleBackColor = true;
            this.buttonLevelUp.Visible = false;
            this.buttonLevelUp.Click += new System.EventHandler(this.buttonLevelUp_Click);
            // 
            // buttonAddAdvert
            // 
            this.buttonAddAdvert.BackgroundImage = global::Hakaton.Properties.Resources.bu3;
            this.buttonAddAdvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddAdvert.Location = new System.Drawing.Point(263, 330);
            this.buttonAddAdvert.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddAdvert.Name = "buttonAddAdvert";
            this.buttonAddAdvert.Size = new System.Drawing.Size(100, 50);
            this.buttonAddAdvert.TabIndex = 1;
            this.buttonAddAdvert.UseVisualStyleBackColor = true;
            this.buttonAddAdvert.Visible = false;
            this.buttonAddAdvert.Click += new System.EventHandler(this.buttonAddAdvert_Click);
            // 
            // labelLevelUp
            // 
            this.labelLevelUp.AutoSize = true;
            this.labelLevelUp.BackColor = System.Drawing.Color.White;
            this.labelLevelUp.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevelUp.ForeColor = System.Drawing.Color.Chocolate;
            this.labelLevelUp.Location = new System.Drawing.Point(164, 382);
            this.labelLevelUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLevelUp.Name = "labelLevelUp";
            this.labelLevelUp.Size = new System.Drawing.Size(46, 20);
            this.labelLevelUp.TabIndex = 2;
            this.labelLevelUp.Text = "750₽";
            this.labelLevelUp.Visible = false;
            // 
            // labelNewPerson
            // 
            this.labelNewPerson.AutoSize = true;
            this.labelNewPerson.BackColor = System.Drawing.Color.White;
            this.labelNewPerson.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewPerson.ForeColor = System.Drawing.Color.Chocolate;
            this.labelNewPerson.Location = new System.Drawing.Point(33, 382);
            this.labelNewPerson.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNewPerson.Name = "labelNewPerson";
            this.labelNewPerson.Size = new System.Drawing.Size(46, 20);
            this.labelNewPerson.TabIndex = 3;
            this.labelNewPerson.Text = "500₽";
            this.labelNewPerson.Visible = false;
            // 
            // labelAddAdvert
            // 
            this.labelAddAdvert.AutoSize = true;
            this.labelAddAdvert.BackColor = System.Drawing.Color.White;
            this.labelAddAdvert.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddAdvert.ForeColor = System.Drawing.Color.Chocolate;
            this.labelAddAdvert.Location = new System.Drawing.Point(292, 382);
            this.labelAddAdvert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddAdvert.Name = "labelAddAdvert";
            this.labelAddAdvert.Size = new System.Drawing.Size(46, 20);
            this.labelAddAdvert.TabIndex = 4;
            this.labelAddAdvert.Text = "550₽";
            this.labelAddAdvert.Visible = false;
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.BackColor = System.Drawing.Color.White;
            this.labelMoney.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoney.ForeColor = System.Drawing.Color.Chocolate;
            this.labelMoney.Location = new System.Drawing.Point(24, 153);
            this.labelMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(18, 20);
            this.labelMoney.TabIndex = 6;
            this.labelMoney.Text = "0";
            this.labelMoney.Visible = false;
            // 
            // timerPurchase
            // 
            this.timerPurchase.Interval = 1000;
            this.timerPurchase.Tick += new System.EventHandler(this.timerPurchase_Tick);
            // 
            // labelPizza
            // 
            this.labelPizza.AutoSize = true;
            this.labelPizza.BackColor = System.Drawing.Color.White;
            this.labelPizza.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPizza.ForeColor = System.Drawing.Color.Chocolate;
            this.labelPizza.Location = new System.Drawing.Point(24, 107);
            this.labelPizza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPizza.Name = "labelPizza";
            this.labelPizza.Size = new System.Drawing.Size(18, 20);
            this.labelPizza.TabIndex = 7;
            this.labelPizza.Text = "0";
            this.labelPizza.Visible = false;
            // 
            // labelPurchase
            // 
            this.labelPurchase.AutoSize = true;
            this.labelPurchase.BackColor = System.Drawing.Color.White;
            this.labelPurchase.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPurchase.ForeColor = System.Drawing.Color.Chocolate;
            this.labelPurchase.Location = new System.Drawing.Point(24, 130);
            this.labelPurchase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPurchase.Name = "labelPurchase";
            this.labelPurchase.Size = new System.Drawing.Size(18, 20);
            this.labelPurchase.TabIndex = 8;
            this.labelPurchase.Text = "0";
            this.labelPurchase.Visible = false;
            // 
            // timerPizza
            // 
            this.timerPizza.Interval = 1000;
            this.timerPizza.Tick += new System.EventHandler(this.timerPizza_Tick);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.White;
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.Chocolate;
            this.labelInfo.Location = new System.Drawing.Point(111, 287);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 21);
            this.labelInfo.TabIndex = 6;
            // 
            // buttonChek
            // 
            this.buttonChek.BackgroundImage = global::Hakaton.Properties.Resources.butChat;
            this.buttonChek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChek.Location = new System.Drawing.Point(160, 250);
            this.buttonChek.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChek.Name = "buttonChek";
            this.buttonChek.Size = new System.Drawing.Size(50, 20);
            this.buttonChek.TabIndex = 9;
            this.buttonChek.UseVisualStyleBackColor = true;
            this.buttonChek.Visible = false;
            this.buttonChek.Click += new System.EventHandler(this.buttonChek_Click);
            // 
            // pictureBoxPizza
            // 
            this.pictureBoxPizza.BackColor = System.Drawing.Color.White;
            this.pictureBoxPizza.Image = global::Hakaton.Properties.Resources.pizza;
            this.pictureBoxPizza.Location = new System.Drawing.Point(2, 110);
            this.pictureBoxPizza.Name = "pictureBoxPizza";
            this.pictureBoxPizza.Size = new System.Drawing.Size(17, 17);
            this.pictureBoxPizza.TabIndex = 10;
            this.pictureBoxPizza.TabStop = false;
            this.pictureBoxPizza.Visible = false;
            // 
            // pictureBoxMoney
            // 
            this.pictureBoxMoney.BackColor = System.Drawing.Color.White;
            this.pictureBoxMoney.Image = global::Hakaton.Properties.Resources.Без_имени1;
            this.pictureBoxMoney.Location = new System.Drawing.Point(2, 156);
            this.pictureBoxMoney.Name = "pictureBoxMoney";
            this.pictureBoxMoney.Size = new System.Drawing.Size(17, 17);
            this.pictureBoxMoney.TabIndex = 11;
            this.pictureBoxMoney.TabStop = false;
            this.pictureBoxMoney.Visible = false;
            // 
            // pictureBoxPurchase
            // 
            this.pictureBoxPurchase.BackColor = System.Drawing.Color.White;
            this.pictureBoxPurchase.Image = global::Hakaton.Properties.Resources.purchase;
            this.pictureBoxPurchase.Location = new System.Drawing.Point(2, 133);
            this.pictureBoxPurchase.Name = "pictureBoxPurchase";
            this.pictureBoxPurchase.Size = new System.Drawing.Size(17, 17);
            this.pictureBoxPurchase.TabIndex = 12;
            this.pictureBoxPurchase.TabStop = false;
            this.pictureBoxPurchase.Visible = false;
            // 
            // timerTime
            // 
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.White;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(325, 114);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(44, 17);
            this.labelTime.TabIndex = 13;
            this.labelTime.Text = "9 : 00";
            this.labelTime.Visible = false;
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.White;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo.Location = new System.Drawing.Point(342, 12);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(23, 23);
            this.buttonInfo.TabIndex = 14;
            this.buttonInfo.Text = "i";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Visible = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hakaton.Properties.Resources.fonchh;
            this.ClientSize = new System.Drawing.Size(374, 402);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.pictureBoxPurchase);
            this.Controls.Add(this.pictureBoxMoney);
            this.Controls.Add(this.pictureBoxPizza);
            this.Controls.Add(this.buttonChek);
            this.Controls.Add(this.labelPurchase);
            this.Controls.Add(this.labelPizza);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelAddAdvert);
            this.Controls.Add(this.labelNewPerson);
            this.Controls.Add(this.labelLevelUp);
            this.Controls.Add(this.buttonAddAdvert);
            this.Controls.Add(this.buttonLevelUp);
            this.Controls.Add(this.buttonNewPerson);
            this.Controls.Add(this.buttonCreatePizza);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Pizzeria";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPurchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreatePizza;
        private System.Windows.Forms.Button buttonNewPerson;
        private System.Windows.Forms.Button buttonLevelUp;
        private System.Windows.Forms.Button buttonAddAdvert;
        private System.Windows.Forms.Label labelLevelUp;
        private System.Windows.Forms.Label labelNewPerson;
        private System.Windows.Forms.Label labelAddAdvert;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Timer timerPurchase;
        private System.Windows.Forms.Label labelPizza;
        private System.Windows.Forms.Label labelPurchase;
        private System.Windows.Forms.Timer timerPizza;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonChek;
        private System.Windows.Forms.PictureBox pictureBoxPizza;
        private System.Windows.Forms.PictureBox pictureBoxMoney;
        private System.Windows.Forms.PictureBox pictureBoxPurchase;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonInfo;
    }
}

