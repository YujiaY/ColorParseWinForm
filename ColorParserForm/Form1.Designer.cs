namespace ColorParserForm
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
            this.btnJsonDictionary = new System.Windows.Forms.Button();
            this.labelJsonString = new System.Windows.Forms.Label();
            this.flowLayoutPanelColors = new System.Windows.Forms.FlowLayoutPanel();
            this.btnJsonClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJsonDictionary
            // 
            this.btnJsonDictionary.Location = new System.Drawing.Point(157, 12);
            this.btnJsonDictionary.Name = "btnJsonDictionary";
            this.btnJsonDictionary.Size = new System.Drawing.Size(132, 23);
            this.btnJsonDictionary.TabIndex = 0;
            this.btnJsonDictionary.Text = "Read JSON (dictionary)";
            this.btnJsonDictionary.UseVisualStyleBackColor = true;
            this.btnJsonDictionary.Click += new System.EventHandler(this.btnJsonDictionary_Click);
            // 
            // labelJsonString
            // 
            this.labelJsonString.AutoSize = true;
            this.labelJsonString.Location = new System.Drawing.Point(13, 52);
            this.labelJsonString.Name = "labelJsonString";
            this.labelJsonString.Size = new System.Drawing.Size(190, 13);
            this.labelJsonString.TabIndex = 1;
            this.labelJsonString.Text = "JSON formatted string will appear here.";
            // 
            // flowLayoutPanelColors
            // 
            this.flowLayoutPanelColors.Location = new System.Drawing.Point(16, 79);
            this.flowLayoutPanelColors.Name = "flowLayoutPanelColors";
            this.flowLayoutPanelColors.Size = new System.Drawing.Size(641, 494);
            this.flowLayoutPanelColors.TabIndex = 2;
 
            // 
            // btnJsonClass
            // 
            this.btnJsonClass.Location = new System.Drawing.Point(346, 12);
            this.btnJsonClass.Name = "btnJsonClass";
            this.btnJsonClass.Size = new System.Drawing.Size(143, 23);
            this.btnJsonClass.TabIndex = 3;
            this.btnJsonClass.Text = "Read JSON (class)";
            this.btnJsonClass.UseVisualStyleBackColor = true;
            this.btnJsonClass.Click += new System.EventHandler(this.btnJsonClass_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 585);
            this.Controls.Add(this.btnJsonClass);
            this.Controls.Add(this.flowLayoutPanelColors);
            this.Controls.Add(this.labelJsonString);
            this.Controls.Add(this.btnJsonDictionary);
            this.Name = "Form1";
            this.Text = "Colour Parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJsonDictionary;
        private System.Windows.Forms.Label labelJsonString;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelColors;
        private System.Windows.Forms.Button btnJsonClass;
    }
}

