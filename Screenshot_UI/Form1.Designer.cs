namespace Screenshot_UI
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
            this.txt_InputPath = new System.Windows.Forms.TextBox();
            this.txt_outputPath = new System.Windows.Forms.TextBox();
            this.btn_listofapps = new System.Windows.Forms.Button();
            this.btn_moveimg = new System.Windows.Forms.Button();
            this.lbl_inputPath = new System.Windows.Forms.Label();
            this.lbl_outputPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_InputPath
            // 
            this.txt_InputPath.Location = new System.Drawing.Point(37, 76);
            this.txt_InputPath.Name = "txt_InputPath";
            this.txt_InputPath.Size = new System.Drawing.Size(300, 20);
            this.txt_InputPath.TabIndex = 0;
            // 
            // txt_outputPath
            // 
            this.txt_outputPath.Location = new System.Drawing.Point(37, 151);
            this.txt_outputPath.Name = "txt_outputPath";
            this.txt_outputPath.Size = new System.Drawing.Size(300, 20);
            this.txt_outputPath.TabIndex = 1;
            // 
            // btn_listofapps
            // 
            this.btn_listofapps.Location = new System.Drawing.Point(37, 219);
            this.btn_listofapps.Name = "btn_listofapps";
            this.btn_listofapps.Size = new System.Drawing.Size(100, 28);
            this.btn_listofapps.TabIndex = 2;
            this.btn_listofapps.Text = "List of apps";
            this.btn_listofapps.UseVisualStyleBackColor = true;
            this.btn_listofapps.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_moveimg
            // 
            this.btn_moveimg.Location = new System.Drawing.Point(319, 219);
            this.btn_moveimg.Name = "btn_moveimg";
            this.btn_moveimg.Size = new System.Drawing.Size(100, 28);
            this.btn_moveimg.TabIndex = 3;
            this.btn_moveimg.Text = "Move Images";
            this.btn_moveimg.UseVisualStyleBackColor = true;
            this.btn_moveimg.Click += new System.EventHandler(this.btn_moveimg_Click);
            // 
            // lbl_inputPath
            // 
            this.lbl_inputPath.AutoSize = true;
            this.lbl_inputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inputPath.Location = new System.Drawing.Point(37, 34);
            this.lbl_inputPath.Name = "lbl_inputPath";
            this.lbl_inputPath.Size = new System.Drawing.Size(143, 20);
            this.lbl_inputPath.TabIndex = 5;
            this.lbl_inputPath.Text = "Input folder path";
            // 
            // lbl_outputPath
            // 
            this.lbl_outputPath.AutoSize = true;
            this.lbl_outputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outputPath.Location = new System.Drawing.Point(37, 119);
            this.lbl_outputPath.Name = "lbl_outputPath";
            this.lbl_outputPath.Size = new System.Drawing.Size(156, 20);
            this.lbl_outputPath.TabIndex = 6;
            this.lbl_outputPath.Text = "Output folder path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 306);
            this.Controls.Add(this.lbl_outputPath);
            this.Controls.Add(this.lbl_inputPath);
            this.Controls.Add(this.btn_moveimg);
            this.Controls.Add(this.btn_listofapps);
            this.Controls.Add(this.txt_outputPath);
            this.Controls.Add(this.txt_InputPath);
            this.Name = "Form1";
            this.Text = "Screenshot Classifier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_InputPath;
        private System.Windows.Forms.TextBox txt_outputPath;
        private System.Windows.Forms.Button btn_listofapps;
        private System.Windows.Forms.Button btn_moveimg;
    
        private System.Windows.Forms.Label lbl_inputPath;
        private System.Windows.Forms.Label lbl_outputPath;
    }
}

