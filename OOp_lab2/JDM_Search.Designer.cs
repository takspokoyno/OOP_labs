namespace OOp_lab2
{
    partial class JDM_Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JDM_Search));
            this.LINQ = new System.Windows.Forms.RadioButton();
            this.DOM = new System.Windows.Forms.RadioButton();
            this.SAX = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.DriveUnit = new System.Windows.Forms.CheckBox();
            this.Brand = new System.Windows.Forms.CheckBox();
            this.Model = new System.Windows.Forms.CheckBox();
            this.Engine = new System.Windows.Forms.CheckBox();
            this.Year = new System.Windows.Forms.CheckBox();
            this.MaxSpeed = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.Price = new System.Windows.Forms.CheckBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonTransform = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LINQ
            // 
            this.LINQ.AutoSize = true;
            this.LINQ.Location = new System.Drawing.Point(49, 376);
            this.LINQ.Name = "LINQ";
            this.LINQ.Size = new System.Drawing.Size(61, 21);
            this.LINQ.TabIndex = 0;
            this.LINQ.TabStop = true;
            this.LINQ.Text = "LINQ";
            this.LINQ.UseVisualStyleBackColor = true;
            // 
            // DOM
            // 
            this.DOM.AutoSize = true;
            this.DOM.Location = new System.Drawing.Point(151, 376);
            this.DOM.Name = "DOM";
            this.DOM.Size = new System.Drawing.Size(61, 21);
            this.DOM.TabIndex = 1;
            this.DOM.TabStop = true;
            this.DOM.Text = "DOM";
            this.DOM.UseVisualStyleBackColor = true;
            // 
            // SAX
            // 
            this.SAX.AutoSize = true;
            this.SAX.Location = new System.Drawing.Point(255, 376);
            this.SAX.Name = "SAX";
            this.SAX.Size = new System.Drawing.Size(56, 21);
            this.SAX.TabIndex = 2;
            this.SAX.TabStop = true;
            this.SAX.Text = "SAX";
            this.SAX.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(436, 34);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(321, 363);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // DriveUnit
            // 
            this.DriveUnit.AutoSize = true;
            this.DriveUnit.Location = new System.Drawing.Point(49, 58);
            this.DriveUnit.Name = "DriveUnit";
            this.DriveUnit.Size = new System.Drawing.Size(92, 21);
            this.DriveUnit.TabIndex = 4;
            this.DriveUnit.Text = "Drive Unit";
            this.DriveUnit.UseVisualStyleBackColor = true;
            this.DriveUnit.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Location = new System.Drawing.Point(49, 88);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(68, 21);
            this.Brand.TabIndex = 5;
            this.Brand.Text = "Brand";
            this.Brand.UseVisualStyleBackColor = true;
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(49, 119);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(68, 21);
            this.Model.TabIndex = 6;
            this.Model.Text = "Model";
            this.Model.UseVisualStyleBackColor = true;
            // 
            // Engine
            // 
            this.Engine.AutoSize = true;
            this.Engine.Location = new System.Drawing.Point(49, 150);
            this.Engine.Name = "Engine";
            this.Engine.Size = new System.Drawing.Size(74, 21);
            this.Engine.TabIndex = 7;
            this.Engine.Text = "Engine";
            this.Engine.UseVisualStyleBackColor = true;
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(49, 181);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(60, 21);
            this.Year.TabIndex = 8;
            this.Year.Text = "Year";
            this.Year.UseVisualStyleBackColor = true;
            // 
            // MaxSpeed
            // 
            this.MaxSpeed.AutoSize = true;
            this.MaxSpeed.Location = new System.Drawing.Point(49, 212);
            this.MaxSpeed.Name = "MaxSpeed";
            this.MaxSpeed.Size = new System.Drawing.Size(100, 21);
            this.MaxSpeed.TabIndex = 9;
            this.MaxSpeed.Text = "Max Speed";
            this.MaxSpeed.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(192, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(192, 89);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 11;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(192, 119);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 12;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(192, 150);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 13;
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(192, 181);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 24);
            this.comboBox5.TabIndex = 14;
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(192, 212);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 24);
            this.comboBox6.TabIndex = 15;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(49, 243);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(62, 21);
            this.Price.TabIndex = 16;
            this.Price.Text = "Price";
            this.Price.UseVisualStyleBackColor = true;
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(192, 243);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 24);
            this.comboBox7.TabIndex = 17;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(49, 323);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(74, 30);
            this.buttonClear.TabIndex = 21;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonTransform
            // 
            this.buttonTransform.Location = new System.Drawing.Point(220, 323);
            this.buttonTransform.Name = "buttonTransform";
            this.buttonTransform.Size = new System.Drawing.Size(93, 30);
            this.buttonTransform.TabIndex = 22;
            this.buttonTransform.Text = "Transform";
            this.buttonTransform.UseVisualStyleBackColor = true;
            this.buttonTransform.Click += new System.EventHandler(this.buttonTransform_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(129, 323);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(83, 30);
            this.buttonSearch.TabIndex = 23;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // JDM_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonTransform);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.MaxSpeed);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Engine);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.DriveUnit);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SAX);
            this.Controls.Add(this.DOM);
            this.Controls.Add(this.LINQ);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "JDM_Search";
            this.Text = "JDM Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JDM_Search_FormClosing);
            this.Load += new System.EventHandler(this.JDM_Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton LINQ;
        private System.Windows.Forms.RadioButton DOM;
        private System.Windows.Forms.RadioButton SAX;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox DriveUnit;
        private System.Windows.Forms.CheckBox Brand;
        private System.Windows.Forms.CheckBox Model;
        private System.Windows.Forms.CheckBox Engine;
        private System.Windows.Forms.CheckBox Year;
        private System.Windows.Forms.CheckBox MaxSpeed;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.CheckBox Price;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonTransform;
        private System.Windows.Forms.Button buttonSearch;
    }
}

