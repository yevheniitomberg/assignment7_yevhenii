namespace assignment7_yevhenii
{
    partial class Form1
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
            this.label_question = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radio_4 = new System.Windows.Forms.RadioButton();
            this.radio_3 = new System.Windows.Forms.RadioButton();
            this.radio_2 = new System.Windows.Forms.RadioButton();
            this.radio_1 = new System.Windows.Forms.RadioButton();
            this.button_start = new System.Windows.Forms.Button();
            this.button_finish = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_question
            // 
            this.label_question.AutoSize = true;
            this.label_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_question.Location = new System.Drawing.Point(220, 39);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(72, 20);
            this.label_question.TabIndex = 0;
            this.label_question.Text = "question";
            this.label_question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radio_4);
            this.panel1.Controls.Add(this.radio_3);
            this.panel1.Controls.Add(this.radio_2);
            this.panel1.Controls.Add(this.radio_1);
            this.panel1.Location = new System.Drawing.Point(37, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 204);
            this.panel1.TabIndex = 1;
            // 
            // radio_4
            // 
            this.radio_4.AutoSize = true;
            this.radio_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radio_4.Location = new System.Drawing.Point(3, 177);
            this.radio_4.Name = "radio_4";
            this.radio_4.Size = new System.Drawing.Size(125, 24);
            this.radio_4.TabIndex = 3;
            this.radio_4.TabStop = true;
            this.radio_4.Text = "radioButton4";
            this.radio_4.UseVisualStyleBackColor = true;
            // 
            // radio_3
            // 
            this.radio_3.AutoSize = true;
            this.radio_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radio_3.Location = new System.Drawing.Point(3, 116);
            this.radio_3.Name = "radio_3";
            this.radio_3.Size = new System.Drawing.Size(125, 24);
            this.radio_3.TabIndex = 2;
            this.radio_3.TabStop = true;
            this.radio_3.Text = "radioButton3";
            this.radio_3.UseVisualStyleBackColor = true;
            // 
            // radio_2
            // 
            this.radio_2.AutoSize = true;
            this.radio_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radio_2.Location = new System.Drawing.Point(3, 60);
            this.radio_2.Name = "radio_2";
            this.radio_2.Size = new System.Drawing.Size(125, 24);
            this.radio_2.TabIndex = 1;
            this.radio_2.TabStop = true;
            this.radio_2.Text = "radioButton2";
            this.radio_2.UseVisualStyleBackColor = true;
            // 
            // radio_1
            // 
            this.radio_1.AutoSize = true;
            this.radio_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radio_1.Location = new System.Drawing.Point(3, 3);
            this.radio_1.Name = "radio_1";
            this.radio_1.Size = new System.Drawing.Size(125, 24);
            this.radio_1.TabIndex = 0;
            this.radio_1.TabStop = true;
            this.radio_1.Text = "radioButton1";
            this.radio_1.UseVisualStyleBackColor = true;
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_start.Location = new System.Drawing.Point(68, 335);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(100, 30);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_finish
            // 
            this.button_finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_finish.Location = new System.Drawing.Point(348, 335);
            this.button_finish.Name = "button_finish";
            this.button_finish.Size = new System.Drawing.Size(100, 30);
            this.button_finish.TabIndex = 3;
            this.button_finish.Text = "Finish";
            this.button_finish.UseVisualStyleBackColor = true;
            this.button_finish.Click += new System.EventHandler(this.button_finish_Click);
            // 
            // button_next
            // 
            this.button_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_next.Location = new System.Drawing.Point(204, 335);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(100, 30);
            this.button_next.TabIndex = 4;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 377);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_finish);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_question);
            this.Name = "Form1";
            this.Text = "Driving License Test";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_question;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_finish;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.RadioButton radio_4;
        private System.Windows.Forms.RadioButton radio_3;
        private System.Windows.Forms.RadioButton radio_2;
        private System.Windows.Forms.RadioButton radio_1;
    }
}

