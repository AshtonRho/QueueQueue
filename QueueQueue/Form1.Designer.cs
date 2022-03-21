namespace QueueQueue
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
            this.lbx_QA = new System.Windows.Forms.ListBox();
            this.lbx_QB = new System.Windows.Forms.ListBox();
            this.btn_push = new System.Windows.Forms.Button();
            this.btn_pop = new System.Windows.Forms.Button();
            this.btn_peek = new System.Windows.Forms.Button();
            this.rtb_input = new System.Windows.Forms.RichTextBox();
            this.rtb_outputA = new System.Windows.Forms.RichTextBox();
            this.lbl_input = new System.Windows.Forms.Label();
            this.lbl_outputA = new System.Windows.Forms.Label();
            this.lbl_qb = new System.Windows.Forms.Label();
            this.lbl_qa = new System.Windows.Forms.Label();
            this.lbl_outputB = new System.Windows.Forms.Label();
            this.rtb_outputB = new System.Windows.Forms.RichTextBox();
            this.btn_clearOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbx_QA
            // 
            this.lbx_QA.FormattingEnabled = true;
            this.lbx_QA.ItemHeight = 20;
            this.lbx_QA.Location = new System.Drawing.Point(360, 188);
            this.lbx_QA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbx_QA.Name = "lbx_QA";
            this.lbx_QA.Size = new System.Drawing.Size(348, 584);
            this.lbx_QA.TabIndex = 0;
            // 
            // lbx_QB
            // 
            this.lbx_QB.FormattingEnabled = true;
            this.lbx_QB.ItemHeight = 20;
            this.lbx_QB.Location = new System.Drawing.Point(718, 188);
            this.lbx_QB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbx_QB.Name = "lbx_QB";
            this.lbx_QB.Size = new System.Drawing.Size(348, 584);
            this.lbx_QB.TabIndex = 1;
            // 
            // btn_push
            // 
            this.btn_push.Location = new System.Drawing.Point(2, 102);
            this.btn_push.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_push.Name = "btn_push";
            this.btn_push.Size = new System.Drawing.Size(350, 52);
            this.btn_push.TabIndex = 2;
            this.btn_push.Text = "PUSH";
            this.btn_push.UseVisualStyleBackColor = true;
            this.btn_push.Click += new System.EventHandler(this.btn_push_Click);
            // 
            // btn_pop
            // 
            this.btn_pop.Location = new System.Drawing.Point(360, 102);
            this.btn_pop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_pop.Name = "btn_pop";
            this.btn_pop.Size = new System.Drawing.Size(350, 52);
            this.btn_pop.TabIndex = 3;
            this.btn_pop.Text = "POP";
            this.btn_pop.UseVisualStyleBackColor = true;
            this.btn_pop.Click += new System.EventHandler(this.btn_pop_Click);
            // 
            // btn_peek
            // 
            this.btn_peek.Location = new System.Drawing.Point(718, 102);
            this.btn_peek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_peek.Name = "btn_peek";
            this.btn_peek.Size = new System.Drawing.Size(350, 52);
            this.btn_peek.TabIndex = 4;
            this.btn_peek.Text = "PEEK";
            this.btn_peek.UseVisualStyleBackColor = true;
            this.btn_peek.Click += new System.EventHandler(this.btn_peek_Click);
            // 
            // rtb_input
            // 
            this.rtb_input.Location = new System.Drawing.Point(2, 29);
            this.rtb_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtb_input.Name = "rtb_input";
            this.rtb_input.Size = new System.Drawing.Size(348, 50);
            this.rtb_input.TabIndex = 5;
            this.rtb_input.Text = "";
            // 
            // rtb_outputA
            // 
            this.rtb_outputA.Location = new System.Drawing.Point(360, 29);
            this.rtb_outputA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtb_outputA.Name = "rtb_outputA";
            this.rtb_outputA.ReadOnly = true;
            this.rtb_outputA.Size = new System.Drawing.Size(348, 50);
            this.rtb_outputA.TabIndex = 6;
            this.rtb_outputA.Text = "";
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Location = new System.Drawing.Point(2, 12);
            this.lbl_input.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(50, 20);
            this.lbl_input.TabIndex = 7;
            this.lbl_input.Text = "Input:";
            // 
            // lbl_outputA
            // 
            this.lbl_outputA.AutoSize = true;
            this.lbl_outputA.Location = new System.Drawing.Point(360, 12);
            this.lbl_outputA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_outputA.Name = "lbl_outputA";
            this.lbl_outputA.Size = new System.Drawing.Size(73, 20);
            this.lbl_outputA.TabIndex = 8;
            this.lbl_outputA.Text = "OutputA:";
            // 
            // lbl_qb
            // 
            this.lbl_qb.AutoSize = true;
            this.lbl_qb.Location = new System.Drawing.Point(862, 169);
            this.lbl_qb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_qb.Name = "lbl_qb";
            this.lbl_qb.Size = new System.Drawing.Size(72, 20);
            this.lbl_qb.TabIndex = 10;
            this.lbl_qb.Text = "Queue B";
            // 
            // lbl_qa
            // 
            this.lbl_qa.AutoSize = true;
            this.lbl_qa.Location = new System.Drawing.Point(500, 169);
            this.lbl_qa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_qa.Name = "lbl_qa";
            this.lbl_qa.Size = new System.Drawing.Size(72, 20);
            this.lbl_qa.TabIndex = 9;
            this.lbl_qa.Text = "Queue A";
            // 
            // lbl_outputB
            // 
            this.lbl_outputB.AutoSize = true;
            this.lbl_outputB.Location = new System.Drawing.Point(718, 12);
            this.lbl_outputB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_outputB.Name = "lbl_outputB";
            this.lbl_outputB.Size = new System.Drawing.Size(73, 20);
            this.lbl_outputB.TabIndex = 13;
            this.lbl_outputB.Text = "OutputB:";
            // 
            // rtb_outputB
            // 
            this.rtb_outputB.Location = new System.Drawing.Point(718, 29);
            this.rtb_outputB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtb_outputB.Name = "rtb_outputB";
            this.rtb_outputB.ReadOnly = true;
            this.rtb_outputB.Size = new System.Drawing.Size(348, 50);
            this.rtb_outputB.TabIndex = 12;
            this.rtb_outputB.Text = "";
            // 
            // btn_clearOutput
            // 
            this.btn_clearOutput.Location = new System.Drawing.Point(2, 188);
            this.btn_clearOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_clearOutput.Name = "btn_clearOutput";
            this.btn_clearOutput.Size = new System.Drawing.Size(350, 54);
            this.btn_clearOutput.TabIndex = 14;
            this.btn_clearOutput.Text = "CLEAR OUTPUT";
            this.btn_clearOutput.UseVisualStyleBackColor = true;
            this.btn_clearOutput.Click += new System.EventHandler(this.btn_clearOutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 832);
            this.Controls.Add(this.btn_clearOutput);
            this.Controls.Add(this.lbl_outputB);
            this.Controls.Add(this.rtb_outputB);
            this.Controls.Add(this.lbl_qb);
            this.Controls.Add(this.lbl_qa);
            this.Controls.Add(this.lbl_outputA);
            this.Controls.Add(this.lbl_input);
            this.Controls.Add(this.rtb_outputA);
            this.Controls.Add(this.rtb_input);
            this.Controls.Add(this.btn_peek);
            this.Controls.Add(this.btn_pop);
            this.Controls.Add(this.btn_push);
            this.Controls.Add(this.lbx_QB);
            this.Controls.Add(this.lbx_QA);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_QA;
        private System.Windows.Forms.ListBox lbx_QB;
        private System.Windows.Forms.Button btn_push;
        private System.Windows.Forms.Button btn_pop;
        private System.Windows.Forms.Button btn_peek;
        private System.Windows.Forms.RichTextBox rtb_input;
        private System.Windows.Forms.RichTextBox rtb_outputA;
        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.Label lbl_outputA;
        private System.Windows.Forms.Label lbl_qb;
        private System.Windows.Forms.Label lbl_qa;
        private System.Windows.Forms.Label lbl_outputB;
        private System.Windows.Forms.RichTextBox rtb_outputB;
        private System.Windows.Forms.Button btn_clearOutput;
    }
}

