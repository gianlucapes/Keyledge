namespace Password
{
    partial class Keyledge
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Keyledge));
            this.label1 = new System.Windows.Forms.Label();
            this.psswordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ch1 = new System.Windows.Forms.NumericUpDown();
            this.chSpecial = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioCostumized = new System.Windows.Forms.RadioButton();
            this.radioRandom = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.charsGroup = new System.Windows.Forms.NumericUpDown();
            this.groups = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.counterBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ch2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.digitsChars = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioPssword = new System.Windows.Forms.RadioButton();
            this.radioProdKey = new System.Windows.Forms.RadioButton();
            this.radioPin = new System.Windows.Forms.RadioButton();
            this.Password = new System.Windows.Forms.GroupBox();
            this.pinBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.prodKeyBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.generate = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chSpecial)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charsGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groups)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ch2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitsChars)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.Password.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password:";
            // 
            // psswordBox
            // 
            this.psswordBox.Location = new System.Drawing.Point(174, 32);
            this.psswordBox.Name = "psswordBox";
            this.psswordBox.Size = new System.Drawing.Size(576, 26);
            this.psswordBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lowercase characters:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(272, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Special characters:";
            // 
            // ch1
            // 
            this.ch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ch1.Location = new System.Drawing.Point(202, 19);
            this.ch1.Name = "ch1";
            this.ch1.Size = new System.Drawing.Size(64, 26);
            this.ch1.TabIndex = 4;
            this.ch1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ch1.ValueChanged += new System.EventHandler(this.ch1_ValueChanged);
            // 
            // chSpecial
            // 
            this.chSpecial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chSpecial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chSpecial.Location = new System.Drawing.Point(441, 58);
            this.chSpecial.Name = "chSpecial";
            this.chSpecial.Size = new System.Drawing.Size(64, 26);
            this.chSpecial.TabIndex = 5;
            this.chSpecial.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.chSpecial.ValueChanged += new System.EventHandler(this.chSpecial_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 252);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioCostumized);
            this.groupBox5.Controls.Add(this.radioRandom);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(534, 133);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(233, 106);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mode";
            // 
            // radioCostumized
            // 
            this.radioCostumized.AutoSize = true;
            this.radioCostumized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioCostumized.Location = new System.Drawing.Point(15, 57);
            this.radioCostumized.Name = "radioCostumized";
            this.radioCostumized.Size = new System.Drawing.Size(121, 24);
            this.radioCostumized.TabIndex = 1;
            this.radioCostumized.Text = "Customized";
            this.radioCostumized.UseVisualStyleBackColor = true;
            this.radioCostumized.CheckedChanged += new System.EventHandler(this.radioCustomized_CheckedChanged);
            // 
            // radioRandom
            // 
            this.radioRandom.AutoSize = true;
            this.radioRandom.Checked = true;
            this.radioRandom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioRandom.Location = new System.Drawing.Point(15, 27);
            this.radioRandom.Name = "radioRandom";
            this.radioRandom.Size = new System.Drawing.Size(94, 24);
            this.radioRandom.TabIndex = 0;
            this.radioRandom.TabStop = true;
            this.radioRandom.Text = "Random";
            this.radioRandom.UseVisualStyleBackColor = true;
            this.radioRandom.CheckedChanged += new System.EventHandler(this.radioRandom_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.charsGroup);
            this.groupBox4.Controls.Add(this.groups);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(15, 135);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(251, 104);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Settings for productKey";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(68, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Characters:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(97, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Groups:";
            // 
            // charsGroup
            // 
            this.charsGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.charsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charsGroup.Location = new System.Drawing.Point(176, 20);
            this.charsGroup.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.charsGroup.Name = "charsGroup";
            this.charsGroup.Size = new System.Drawing.Size(64, 26);
            this.charsGroup.TabIndex = 14;
            this.charsGroup.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.charsGroup.ValueChanged += new System.EventHandler(this.charsGroup_ValueChanged);
            // 
            // groups
            // 
            this.groups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groups.Location = new System.Drawing.Point(176, 52);
            this.groups.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.groups.Name = "groups";
            this.groups.Size = new System.Drawing.Size(64, 26);
            this.groups.TabIndex = 16;
            this.groups.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.groups.ValueChanged += new System.EventHandler(this.groups_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.counterBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.ch1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.ch2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.digitsChars);
            this.groupBox3.Controls.Add(this.chSpecial);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(15, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(753, 94);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Password e Pin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(545, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Enter a value between 1-100";
            // 
            // counterBox
            // 
            this.counterBox.Location = new System.Drawing.Point(671, 37);
            this.counterBox.Name = "counterBox";
            this.counterBox.Size = new System.Drawing.Size(64, 26);
            this.counterBox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(2, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Uppercase characters:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(521, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Total characters:";
            // 
            // ch2
            // 
            this.ch2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch2.Location = new System.Drawing.Point(202, 55);
            this.ch2.Name = "ch2";
            this.ch2.Size = new System.Drawing.Size(64, 26);
            this.ch2.TabIndex = 7;
            this.ch2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ch2.ValueChanged += new System.EventHandler(this.ch2_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(310, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "numeric digits:";
            // 
            // digitsChars
            // 
            this.digitsChars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.digitsChars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitsChars.Location = new System.Drawing.Point(441, 19);
            this.digitsChars.Name = "digitsChars";
            this.digitsChars.Size = new System.Drawing.Size(64, 26);
            this.digitsChars.TabIndex = 9;
            this.digitsChars.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.digitsChars.ValueChanged += new System.EventHandler(this.digitsChars_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.radioPssword);
            this.groupBox2.Controls.Add(this.radioProdKey);
            this.groupBox2.Controls.Add(this.radioPin);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(284, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 106);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generate";
            // 
            // radioPssword
            // 
            this.radioPssword.AutoSize = true;
            this.radioPssword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioPssword.Location = new System.Drawing.Point(92, 22);
            this.radioPssword.Name = "radioPssword";
            this.radioPssword.Size = new System.Drawing.Size(104, 24);
            this.radioPssword.TabIndex = 11;
            this.radioPssword.TabStop = true;
            this.radioPssword.Text = "Password";
            this.radioPssword.UseVisualStyleBackColor = true;
            this.radioPssword.CheckedChanged += new System.EventHandler(this.radioPssword_CheckedChanged);
            // 
            // radioProdKey
            // 
            this.radioProdKey.AutoSize = true;
            this.radioProdKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioProdKey.Location = new System.Drawing.Point(92, 46);
            this.radioProdKey.Name = "radioProdKey";
            this.radioProdKey.Size = new System.Drawing.Size(118, 24);
            this.radioProdKey.TabIndex = 12;
            this.radioProdKey.TabStop = true;
            this.radioProdKey.Text = "ProductKey";
            this.radioProdKey.UseVisualStyleBackColor = true;
            this.radioProdKey.CheckedChanged += new System.EventHandler(this.radioProdKey_CheckedChanged);
            // 
            // radioPin
            // 
            this.radioPin.AutoSize = true;
            this.radioPin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioPin.Location = new System.Drawing.Point(92, 68);
            this.radioPin.Name = "radioPin";
            this.radioPin.Size = new System.Drawing.Size(52, 24);
            this.radioPin.TabIndex = 17;
            this.radioPin.TabStop = true;
            this.radioPin.Text = "Pin";
            this.radioPin.UseVisualStyleBackColor = true;
            this.radioPin.CheckedChanged += new System.EventHandler(this.radioPin_CheckedChanged);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.DarkGreen;
            this.Password.Controls.Add(this.pinBox);
            this.Password.Controls.Add(this.label10);
            this.Password.Controls.Add(this.prodKeyBox);
            this.Password.Controls.Add(this.label7);
            this.Password.Controls.Add(this.label1);
            this.Password.Controls.Add(this.psswordBox);
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.Black;
            this.Password.Location = new System.Drawing.Point(12, 262);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(784, 157);
            this.Password.TabIndex = 7;
            this.Password.TabStop = false;
            // 
            // pinBox
            // 
            this.pinBox.Location = new System.Drawing.Point(174, 109);
            this.pinBox.Name = "pinBox";
            this.pinBox.Size = new System.Drawing.Size(576, 26);
            this.pinBox.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(135, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Pin:";
            // 
            // prodKeyBox
            // 
            this.prodKeyBox.Location = new System.Drawing.Point(174, 72);
            this.prodKeyBox.Name = "prodKeyBox";
            this.prodKeyBox.Size = new System.Drawing.Size(576, 26);
            this.prodKeyBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(69, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "ProductKey:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.copy);
            this.panel1.Controls.Add(this.generate);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(11, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 57);
            this.panel1.TabIndex = 8;
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.generate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.generate.Location = new System.Drawing.Point(35, 9);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(139, 38);
            this.generate.TabIndex = 0;
            this.generate.Text = "Start";
            this.generate.UseVisualStyleBackColor = false;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel.Location = new System.Drawing.Point(370, 9);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(139, 38);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // copy
            // 
            this.copy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.copy.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.copy.Location = new System.Drawing.Point(205, 9);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(139, 38);
            this.copy.TabIndex = 1;
            this.copy.Text = "Copy";
            this.copy.UseVisualStyleBackColor = false;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 69);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Keyledge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(807, 494);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(823, 533);
            this.MinimumSize = new System.Drawing.Size(823, 533);
            this.Name = "Keyledge";
            this.Text = "Keyledge";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chSpecial)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charsGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groups)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ch2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitsChars)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Password.ResumeLayout(false);
            this.Password.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox psswordBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ch1;
        private System.Windows.Forms.NumericUpDown chSpecial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown digitsChars;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ch2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.RadioButton radioPssword;
        private System.Windows.Forms.NumericUpDown groups;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown charsGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox prodKeyBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioPin;
        private System.Windows.Forms.RadioButton radioProdKey;
        private System.Windows.Forms.TextBox pinBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioRandom;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioCostumized;
        private System.Windows.Forms.TextBox counterBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

