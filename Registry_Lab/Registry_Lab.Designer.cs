namespace Registry_Lab
{
    partial class Registry_Lab
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
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.buttonCreateSubKey = new System.Windows.Forms.Button();
            this.buttonCreateValue = new System.Windows.Forms.Button();
            this.comboBoxValueType = new System.Windows.Forms.ComboBox();
            this.textBoxNewSubKey = new System.Windows.Forms.TextBox();
            this.textBoxValueName = new System.Windows.Forms.TextBox();
            this.textBoxValueData = new System.Windows.Forms.TextBox();
            this.listBoxRegistry = new System.Windows.Forms.ListBox();
            this.treeViewRegistry = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCurrentPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonSaveToFile.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveToFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSaveToFile.Location = new System.Drawing.Point(734, 168);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(160, 55);
            this.buttonSaveToFile.TabIndex = 3;
            this.buttonSaveToFile.Text = "Сохранение данных";
            this.buttonSaveToFile.UseVisualStyleBackColor = false;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // buttonCreateSubKey
            // 
            this.buttonCreateSubKey.BackColor = System.Drawing.Color.Tomato;
            this.buttonCreateSubKey.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateSubKey.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCreateSubKey.Location = new System.Drawing.Point(493, 474);
            this.buttonCreateSubKey.Name = "buttonCreateSubKey";
            this.buttonCreateSubKey.Size = new System.Drawing.Size(254, 32);
            this.buttonCreateSubKey.TabIndex = 4;
            this.buttonCreateSubKey.Text = "Создание подключа";
            this.buttonCreateSubKey.UseVisualStyleBackColor = false;
            this.buttonCreateSubKey.Click += new System.EventHandler(this.buttonCreateSubKey_Click);
            // 
            // buttonCreateValue
            // 
            this.buttonCreateValue.BackColor = System.Drawing.Color.Tomato;
            this.buttonCreateValue.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateValue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCreateValue.Location = new System.Drawing.Point(493, 576);
            this.buttonCreateValue.Name = "buttonCreateValue";
            this.buttonCreateValue.Size = new System.Drawing.Size(254, 35);
            this.buttonCreateValue.TabIndex = 5;
            this.buttonCreateValue.Text = "Создание параметра.";
            this.buttonCreateValue.UseVisualStyleBackColor = false;
            this.buttonCreateValue.Click += new System.EventHandler(this.buttonCreateValue_Click);
            // 
            // comboBoxValueType
            // 
            this.comboBoxValueType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxValueType.FormattingEnabled = true;
            this.comboBoxValueType.Items.AddRange(new object[] {
            "Строковый",
            "Числовой",
            "Двоичный"});
            this.comboBoxValueType.Location = new System.Drawing.Point(78, 607);
            this.comboBoxValueType.Name = "comboBoxValueType";
            this.comboBoxValueType.Size = new System.Drawing.Size(165, 24);
            this.comboBoxValueType.TabIndex = 6;
            // 
            // textBoxNewSubKey
            // 
            this.textBoxNewSubKey.Location = new System.Drawing.Point(79, 474);
            this.textBoxNewSubKey.Name = "textBoxNewSubKey";
            this.textBoxNewSubKey.Size = new System.Drawing.Size(330, 22);
            this.textBoxNewSubKey.TabIndex = 9;
            // 
            // textBoxValueName
            // 
            this.textBoxValueName.Location = new System.Drawing.Point(78, 547);
            this.textBoxValueName.Name = "textBoxValueName";
            this.textBoxValueName.Size = new System.Drawing.Size(330, 22);
            this.textBoxValueName.TabIndex = 10;
            // 
            // textBoxValueData
            // 
            this.textBoxValueData.Location = new System.Drawing.Point(78, 683);
            this.textBoxValueData.Name = "textBoxValueData";
            this.textBoxValueData.Size = new System.Drawing.Size(330, 22);
            this.textBoxValueData.TabIndex = 11;
            // 
            // listBoxRegistry
            // 
            this.listBoxRegistry.FormattingEnabled = true;
            this.listBoxRegistry.ItemHeight = 16;
            this.listBoxRegistry.Location = new System.Drawing.Point(78, 277);
            this.listBoxRegistry.Name = "listBoxRegistry";
            this.listBoxRegistry.Size = new System.Drawing.Size(891, 116);
            this.listBoxRegistry.TabIndex = 0;
            // 
            // treeViewRegistry
            // 
            this.treeViewRegistry.Location = new System.Drawing.Point(79, 43);
            this.treeViewRegistry.Name = "treeViewRegistry";
            this.treeViewRegistry.Size = new System.Drawing.Size(291, 180);
            this.treeViewRegistry.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Параметры:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Логическая структура реестра:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Запись";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Font = new System.Drawing.Font("Rockwell", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Новый подключ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Font = new System.Drawing.Font("Rockwell", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 514);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Имя";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Font = new System.Drawing.Font("Rockwell", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(75, 652);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "Значение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Rockwell", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 586);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Тип";
            // 
            // labelCurrentPath
            // 
            this.labelCurrentPath.AutoSize = true;
            this.labelCurrentPath.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labelCurrentPath.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPath.Location = new System.Drawing.Point(429, 66);
            this.labelCurrentPath.Name = "labelCurrentPath";
            this.labelCurrentPath.Size = new System.Drawing.Size(112, 18);
            this.labelCurrentPath.TabIndex = 25;
            this.labelCurrentPath.Text = "Текущий путь";
            // 
            // Registry_Lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(981, 764);
            this.Controls.Add(this.labelCurrentPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeViewRegistry);
            this.Controls.Add(this.textBoxValueData);
            this.Controls.Add(this.textBoxValueName);
            this.Controls.Add(this.textBoxNewSubKey);
            this.Controls.Add(this.comboBoxValueType);
            this.Controls.Add(this.buttonCreateValue);
            this.Controls.Add(this.buttonCreateSubKey);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.listBoxRegistry);
            this.Name = "Registry_Lab";
            this.Text = "Registry_Lab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.Button buttonCreateSubKey;
        private System.Windows.Forms.Button buttonCreateValue;
        private System.Windows.Forms.ComboBox comboBoxValueType;
        private System.Windows.Forms.TextBox textBoxNewSubKey;
        private System.Windows.Forms.TextBox textBoxValueName;
        private System.Windows.Forms.TextBox textBoxValueData;
        private System.Windows.Forms.ListBox listBoxRegistry;
        private System.Windows.Forms.TreeView treeViewRegistry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCurrentPath;
    }
}

