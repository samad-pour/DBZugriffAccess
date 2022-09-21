namespace DBZugriffAccess
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
            this.BtnAlleSehen = new System.Windows.Forms.Button();
            this.BtnErhoehen = new System.Windows.Forms.Button();
            this.BtnSenken = new System.Windows.Forms.Button();
            this.LstDisplay = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // BtnAlleSehen
            // 
            this.BtnAlleSehen.Location = new System.Drawing.Point(12, 12);
            this.BtnAlleSehen.Name = "BtnAlleSehen";
            this.BtnAlleSehen.Size = new System.Drawing.Size(150, 23);
            this.BtnAlleSehen.TabIndex = 0;
            this.BtnAlleSehen.Text = "Alle Datensätze sehen";
            this.BtnAlleSehen.UseVisualStyleBackColor = true;
            this.BtnAlleSehen.Click += new System.EventHandler(this.BtnAlleSehen_Click);
            // 
            // BtnErhoehen
            // 
            this.BtnErhoehen.Location = new System.Drawing.Point(12, 41);
            this.BtnErhoehen.Name = "BtnErhoehen";
            this.BtnErhoehen.Size = new System.Drawing.Size(150, 23);
            this.BtnErhoehen.TabIndex = 0;
            this.BtnErhoehen.Text = "Gehälter erhöhen";
            this.BtnErhoehen.UseVisualStyleBackColor = true;
            this.BtnErhoehen.Click += new System.EventHandler(this.BtnAendern_Click);
            // 
            // BtnSenken
            // 
            this.BtnSenken.Location = new System.Drawing.Point(12, 70);
            this.BtnSenken.Name = "BtnSenken";
            this.BtnSenken.Size = new System.Drawing.Size(150, 23);
            this.BtnSenken.TabIndex = 0;
            this.BtnSenken.Text = "Gehälter senken";
            this.BtnSenken.UseVisualStyleBackColor = true;
            this.BtnSenken.Click += new System.EventHandler(this.BtnAendern_Click);
            // 
            // LstDisplay
            // 
            this.LstDisplay.Location = new System.Drawing.Point(12, 109);
            this.LstDisplay.Name = "LstDisplay";
            this.LstDisplay.Size = new System.Drawing.Size(342, 96);
            this.LstDisplay.TabIndex = 1;
            this.LstDisplay.UseCompatibleStateImageBehavior = false;
            this.LstDisplay.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 209);
            this.Controls.Add(this.LstDisplay);
            this.Controls.Add(this.BtnSenken);
            this.Controls.Add(this.BtnErhoehen);
            this.Controls.Add(this.BtnAlleSehen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnAlleSehen;
        private Button BtnErhoehen;
        private Button BtnSenken;
        private ListView LstDisplay;
    }
}