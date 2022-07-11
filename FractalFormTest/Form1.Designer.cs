
namespace FractalFormTest
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label2 = new System.Windows.Forms.Label();
			this.refreshBtn = new System.Windows.Forms.Button();
			this.fracOptions = new System.Windows.Forms.GroupBox();
			this.saveBtn = new System.Windows.Forms.Button();
			this.backBLabel = new System.Windows.Forms.Label();
			this.backGLabel = new System.Windows.Forms.Label();
			this.backRLabel = new System.Windows.Forms.Label();
			this.fracBLabel = new System.Windows.Forms.Label();
			this.fracGLabel = new System.Windows.Forms.Label();
			this.fracRLabel = new System.Windows.Forms.Label();
			this.iterSleep = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.backB = new System.Windows.Forms.TrackBar();
			this.backG = new System.Windows.Forms.TrackBar();
			this.backR = new System.Windows.Forms.TrackBar();
			this.label10 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.fracB = new System.Windows.Forms.TrackBar();
			this.fracG = new System.Windows.Forms.TrackBar();
			this.fracR = new System.Windows.Forms.TrackBar();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.iterAmount = new System.Windows.Forms.TextBox();
			this.drawBtn = new System.Windows.Forms.Button();
			this.fracChoice = new System.Windows.Forms.ComboBox();
			this.fracOptions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.backB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.backG)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.backR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fracB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fracG)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fracR)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label2.Location = new System.Drawing.Point(3, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Выбор фрактала:";
			// 
			// refreshBtn
			// 
			this.refreshBtn.BackColor = System.Drawing.SystemColors.Control;
			this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.refreshBtn.Location = new System.Drawing.Point(6, 759);
			this.refreshBtn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
			this.refreshBtn.Name = "refreshBtn";
			this.refreshBtn.Size = new System.Drawing.Size(305, 55);
			this.refreshBtn.TabIndex = 5;
			this.refreshBtn.Text = "Обновить полотно";
			this.refreshBtn.UseVisualStyleBackColor = false;
			this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
			// 
			// fracOptions
			// 
			this.fracOptions.Controls.Add(this.saveBtn);
			this.fracOptions.Controls.Add(this.backBLabel);
			this.fracOptions.Controls.Add(this.backGLabel);
			this.fracOptions.Controls.Add(this.backRLabel);
			this.fracOptions.Controls.Add(this.fracBLabel);
			this.fracOptions.Controls.Add(this.fracGLabel);
			this.fracOptions.Controls.Add(this.fracRLabel);
			this.fracOptions.Controls.Add(this.iterSleep);
			this.fracOptions.Controls.Add(this.label11);
			this.fracOptions.Controls.Add(this.label7);
			this.fracOptions.Controls.Add(this.label8);
			this.fracOptions.Controls.Add(this.label9);
			this.fracOptions.Controls.Add(this.backB);
			this.fracOptions.Controls.Add(this.backG);
			this.fracOptions.Controls.Add(this.backR);
			this.fracOptions.Controls.Add(this.label10);
			this.fracOptions.Controls.Add(this.label6);
			this.fracOptions.Controls.Add(this.label5);
			this.fracOptions.Controls.Add(this.label4);
			this.fracOptions.Controls.Add(this.fracB);
			this.fracOptions.Controls.Add(this.fracG);
			this.fracOptions.Controls.Add(this.fracR);
			this.fracOptions.Controls.Add(this.label3);
			this.fracOptions.Controls.Add(this.label1);
			this.fracOptions.Controls.Add(this.iterAmount);
			this.fracOptions.Controls.Add(this.drawBtn);
			this.fracOptions.Controls.Add(this.fracChoice);
			this.fracOptions.Controls.Add(this.refreshBtn);
			this.fracOptions.Controls.Add(this.label2);
			this.fracOptions.Dock = System.Windows.Forms.DockStyle.Left;
			this.fracOptions.Location = new System.Drawing.Point(3, 3);
			this.fracOptions.Name = "fracOptions";
			this.fracOptions.Size = new System.Drawing.Size(317, 1035);
			this.fracOptions.TabIndex = 6;
			this.fracOptions.TabStop = false;
			this.fracOptions.Text = "Опции";
			// 
			// saveBtn
			// 
			this.saveBtn.BackColor = System.Drawing.SystemColors.Control;
			this.saveBtn.Enabled = false;
			this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.saveBtn.Location = new System.Drawing.Point(6, 618);
			this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(305, 54);
			this.saveBtn.TabIndex = 32;
			this.saveBtn.Text = "Сохранить фрактал";
			this.saveBtn.UseVisualStyleBackColor = false;
			this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// backBLabel
			// 
			this.backBLabel.AutoSize = true;
			this.backBLabel.Location = new System.Drawing.Point(16, 582);
			this.backBLabel.Name = "backBLabel";
			this.backBLabel.Size = new System.Drawing.Size(13, 15);
			this.backBLabel.TabIndex = 31;
			this.backBLabel.Text = "0";
			// 
			// backGLabel
			// 
			this.backGLabel.AutoSize = true;
			this.backGLabel.Location = new System.Drawing.Point(16, 531);
			this.backGLabel.Name = "backGLabel";
			this.backGLabel.Size = new System.Drawing.Size(13, 15);
			this.backGLabel.TabIndex = 30;
			this.backGLabel.Text = "0";
			// 
			// backRLabel
			// 
			this.backRLabel.AutoSize = true;
			this.backRLabel.Location = new System.Drawing.Point(16, 480);
			this.backRLabel.Name = "backRLabel";
			this.backRLabel.Size = new System.Drawing.Size(13, 15);
			this.backRLabel.TabIndex = 29;
			this.backRLabel.Text = "0";
			// 
			// fracBLabel
			// 
			this.fracBLabel.AutoSize = true;
			this.fracBLabel.Location = new System.Drawing.Point(16, 367);
			this.fracBLabel.Name = "fracBLabel";
			this.fracBLabel.Size = new System.Drawing.Size(13, 15);
			this.fracBLabel.TabIndex = 28;
			this.fracBLabel.Text = "0";
			// 
			// fracGLabel
			// 
			this.fracGLabel.AutoSize = true;
			this.fracGLabel.Location = new System.Drawing.Point(16, 316);
			this.fracGLabel.Name = "fracGLabel";
			this.fracGLabel.Size = new System.Drawing.Size(13, 15);
			this.fracGLabel.TabIndex = 27;
			this.fracGLabel.Text = "0";
			// 
			// fracRLabel
			// 
			this.fracRLabel.AutoSize = true;
			this.fracRLabel.Location = new System.Drawing.Point(16, 265);
			this.fracRLabel.Name = "fracRLabel";
			this.fracRLabel.Size = new System.Drawing.Size(13, 15);
			this.fracRLabel.TabIndex = 26;
			this.fracRLabel.Text = "0";
			// 
			// iterSleep
			// 
			this.iterSleep.Location = new System.Drawing.Point(164, 136);
			this.iterSleep.Name = "iterSleep";
			this.iterSleep.PlaceholderText = "500";
			this.iterSleep.Size = new System.Drawing.Size(142, 23);
			this.iterSleep.TabIndex = 25;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(164, 118);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(145, 15);
			this.label11.TabIndex = 24;
			this.label11.Text = "Время на итерацию (мс):";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(10, 567);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(17, 15);
			this.label7.TabIndex = 23;
			this.label7.Text = "B:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(10, 516);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(18, 15);
			this.label8.TabIndex = 22;
			this.label8.Text = "G:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(10, 465);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(17, 15);
			this.label9.TabIndex = 21;
			this.label9.Text = "R:";
			// 
			// backB
			// 
			this.backB.Location = new System.Drawing.Point(49, 567);
			this.backB.Maximum = 255;
			this.backB.Name = "backB";
			this.backB.Size = new System.Drawing.Size(262, 45);
			this.backB.TabIndex = 20;
			this.backB.ValueChanged += new System.EventHandler(this.backRGB_ValueChanged);
			// 
			// backG
			// 
			this.backG.Location = new System.Drawing.Point(49, 516);
			this.backG.Maximum = 255;
			this.backG.Name = "backG";
			this.backG.Size = new System.Drawing.Size(262, 45);
			this.backG.TabIndex = 19;
			this.backG.ValueChanged += new System.EventHandler(this.backRGB_ValueChanged);
			// 
			// backR
			// 
			this.backR.Location = new System.Drawing.Point(49, 465);
			this.backR.Maximum = 255;
			this.backR.Name = "backR";
			this.backR.Size = new System.Drawing.Size(262, 45);
			this.backR.TabIndex = 18;
			this.backR.ValueChanged += new System.EventHandler(this.backRGB_ValueChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 437);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(68, 15);
			this.label10.TabIndex = 17;
			this.label10.Text = "Цвет фона:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(10, 352);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(17, 15);
			this.label6.TabIndex = 16;
			this.label6.Text = "B:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 301);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(18, 15);
			this.label5.TabIndex = 15;
			this.label5.Text = "G:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 250);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(17, 15);
			this.label4.TabIndex = 14;
			this.label4.Text = "R:";
			// 
			// fracB
			// 
			this.fracB.Location = new System.Drawing.Point(49, 352);
			this.fracB.Maximum = 255;
			this.fracB.Name = "fracB";
			this.fracB.Size = new System.Drawing.Size(257, 45);
			this.fracB.TabIndex = 13;
			this.fracB.ValueChanged += new System.EventHandler(this.fracRGB_ValueChanged);
			// 
			// fracG
			// 
			this.fracG.Location = new System.Drawing.Point(49, 301);
			this.fracG.Maximum = 255;
			this.fracG.Name = "fracG";
			this.fracG.Size = new System.Drawing.Size(257, 45);
			this.fracG.TabIndex = 12;
			this.fracG.ValueChanged += new System.EventHandler(this.fracRGB_ValueChanged);
			// 
			// fracR
			// 
			this.fracR.Location = new System.Drawing.Point(49, 250);
			this.fracR.Maximum = 255;
			this.fracR.Name = "fracR";
			this.fracR.Size = new System.Drawing.Size(257, 45);
			this.fracR.TabIndex = 11;
			this.fracR.ValueChanged += new System.EventHandler(this.fracRGB_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 222);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 15);
			this.label3.TabIndex = 10;
			this.label3.Text = "Цвет фрактала:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 118);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 15);
			this.label1.TabIndex = 9;
			this.label1.Text = "Количество итераций:";
			// 
			// iterAmount
			// 
			this.iterAmount.Location = new System.Drawing.Point(10, 136);
			this.iterAmount.Name = "iterAmount";
			this.iterAmount.PlaceholderText = "30";
			this.iterAmount.Size = new System.Drawing.Size(127, 23);
			this.iterAmount.TabIndex = 8;
			// 
			// drawBtn
			// 
			this.drawBtn.BackColor = System.Drawing.SystemColors.Control;
			this.drawBtn.Enabled = false;
			this.drawBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.drawBtn.Location = new System.Drawing.Point(6, 685);
			this.drawBtn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.drawBtn.Name = "drawBtn";
			this.drawBtn.Size = new System.Drawing.Size(305, 54);
			this.drawBtn.TabIndex = 7;
			this.drawBtn.Text = "Нарисовать выбранный фрактал";
			this.drawBtn.UseVisualStyleBackColor = false;
			this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
			// 
			// fracChoice
			// 
			this.fracChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.fracChoice.FormattingEnabled = true;
			this.fracChoice.Items.AddRange(new object[] {
            "Дракон Хартера-Хейтуэя",
            "Кривая Минковского",
            "Заполняющая пространство кривая Гильберта"});
			this.fracChoice.Location = new System.Drawing.Point(6, 37);
			this.fracChoice.Name = "fracChoice";
			this.fracChoice.Size = new System.Drawing.Size(305, 23);
			this.fracChoice.TabIndex = 6;
			this.fracChoice.SelectedIndexChanged += new System.EventHandler(this.fracChoice_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1904, 1041);
			this.Controls.Add(this.fracOptions);
			this.ForeColor = System.Drawing.SystemColors.Desktop;
			this.Name = "Form1";
			this.Padding = new System.Windows.Forms.Padding(3);
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.fracOptions.ResumeLayout(false);
			this.fracOptions.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.backB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.backG)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.backR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fracB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fracG)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fracR)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.GroupBox fracOptions;
        private System.Windows.Forms.ComboBox fracChoice;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.TrackBar fracR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iterAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar backB;
        private System.Windows.Forms.TrackBar backG;
        private System.Windows.Forms.TrackBar backR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar fracB;
        private System.Windows.Forms.TextBox iterSleep;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label backBLabel;
        private System.Windows.Forms.Label backGLabel;
        private System.Windows.Forms.Label backRLabel;
        private System.Windows.Forms.Label fracBLabel;
        private System.Windows.Forms.Label fracGLabel;
        private System.Windows.Forms.Label fracRLabel;
		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.TrackBar fracG;
	}
}

