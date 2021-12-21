
namespace Тест_на_IQ
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.Nickname_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_CheckResult = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nickname_textBox
            // 
            this.Nickname_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nickname_textBox.Location = new System.Drawing.Point(53, 486);
            this.Nickname_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Nickname_textBox.Name = "Nickname_textBox";
            this.Nickname_textBox.Size = new System.Drawing.Size(271, 34);
            this.Nickname_textBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 442);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите свой ник:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(123)))), ((int)(((byte)(118)))));
            this.label2.Location = new System.Drawing.Point(40, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 54);
            this.label2.TabIndex = 4;
            this.label2.Text = "Тест на IQ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(48, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 274);
            this.label3.TabIndex = 6;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_CheckResult
            // 
            this.btn_CheckResult.BackColor = System.Drawing.Color.Transparent;
            this.btn_CheckResult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CheckResult.BackgroundImage")));
            this.btn_CheckResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_CheckResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CheckResult.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btn_CheckResult.FlatAppearance.BorderSize = 0;
            this.btn_CheckResult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CheckResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CheckResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CheckResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_CheckResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_CheckResult.Location = new System.Drawing.Point(441, 553);
            this.btn_CheckResult.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CheckResult.Name = "btn_CheckResult";
            this.btn_CheckResult.Size = new System.Drawing.Size(341, 130);
            this.btn_CheckResult.TabIndex = 1;
            this.btn_CheckResult.UseVisualStyleBackColor = false;
            this.btn_CheckResult.Click += new System.EventHandler(this.btn_CheckResult_Click);
            this.btn_CheckResult.MouseEnter += new System.EventHandler(this.btn_CheckResult_MouseEnter);
            this.btn_CheckResult.MouseLeave += new System.EventHandler(this.btn_CheckResult_MouseLeave);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.Transparent;
            this.btn_Start.BackgroundImage = global::Тест_на_IQ.Properties.Resources.btnBegin;
            this.btn_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Start.FlatAppearance.BorderSize = 0;
            this.btn_Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Start.ForeColor = System.Drawing.Color.White;
            this.btn_Start.Location = new System.Drawing.Point(33, 553);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(344, 130);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.button1_Click);
            this.btn_Start.MouseEnter += new System.EventHandler(this.btn_Start_MouseEnter);
            this.btn_Start.MouseLeave += new System.EventHandler(this.btn_Start_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "../.../Resources/brain.png";
            this.pictureBox1.InitialImage = global::Тест_на_IQ.Properties.Resources.brain;
            this.pictureBox1.Location = new System.Drawing.Point(403, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 375);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(812, 698);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nickname_textBox);
            this.Controls.Add(this.btn_CheckResult);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(830, 745);
            this.MinimumSize = new System.Drawing.Size(830, 745);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.DoubleClick += new System.EventHandler(this.MainPage_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_CheckResult;
        private System.Windows.Forms.TextBox Nickname_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}