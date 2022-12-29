namespace LED_Room_Controller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.allOnButton = new System.Windows.Forms.Button();
            this.allOffButton = new System.Windows.Forms.Button();
            this.colorPickerButton = new System.Windows.Forms.Button();
            this.toggleStrip = new System.Windows.Forms.CheckBox();
            this.toggleNeopixelStrip = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // allOnButton
            // 
            this.allOnButton.Location = new System.Drawing.Point(12, 12);
            this.allOnButton.Name = "allOnButton";
            this.allOnButton.Size = new System.Drawing.Size(75, 23);
            this.allOnButton.TabIndex = 4;
            this.allOnButton.Text = "All On";
            this.allOnButton.UseVisualStyleBackColor = true;
            this.allOnButton.Click += new System.EventHandler(this.allOnButton_Click);
            // 
            // allOffButton
            // 
            this.allOffButton.Location = new System.Drawing.Point(93, 12);
            this.allOffButton.Name = "allOffButton";
            this.allOffButton.Size = new System.Drawing.Size(75, 23);
            this.allOffButton.TabIndex = 5;
            this.allOffButton.Text = "All Off";
            this.allOffButton.UseVisualStyleBackColor = true;
            this.allOffButton.Click += new System.EventHandler(this.allOffButton_Click);
            // 
            // colorPickerButton
            // 
            this.colorPickerButton.Location = new System.Drawing.Point(12, 75);
            this.colorPickerButton.Name = "colorPickerButton";
            this.colorPickerButton.Size = new System.Drawing.Size(156, 23);
            this.colorPickerButton.TabIndex = 6;
            this.colorPickerButton.Text = "Select Colour";
            this.colorPickerButton.UseVisualStyleBackColor = true;
            this.colorPickerButton.Click += new System.EventHandler(this.colorPickerButton_Click);
            // 
            // toggleStrip
            // 
            this.toggleStrip.AutoSize = true;
            this.toggleStrip.Location = new System.Drawing.Point(12, 41);
            this.toggleStrip.Name = "toggleStrip";
            this.toggleStrip.Size = new System.Drawing.Size(47, 17);
            this.toggleStrip.TabIndex = 7;
            this.toggleStrip.Text = "Strip";
            this.toggleStrip.UseVisualStyleBackColor = true;
            this.toggleStrip.CheckedChanged += new System.EventHandler(this.toggleStrip_CheckedChanged);
            // 
            // toggleNeopixelStrip
            // 
            this.toggleNeopixelStrip.AutoSize = true;
            this.toggleNeopixelStrip.Location = new System.Drawing.Point(93, 41);
            this.toggleNeopixelStrip.Name = "toggleNeopixelStrip";
            this.toggleNeopixelStrip.Size = new System.Drawing.Size(91, 17);
            this.toggleNeopixelStrip.TabIndex = 8;
            this.toggleNeopixelStrip.Text = "Neopixel Strip";
            this.toggleNeopixelStrip.UseVisualStyleBackColor = true;
            this.toggleNeopixelStrip.CheckedChanged += new System.EventHandler(this.toggleNeopixelStrip_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 113);
            this.Controls.Add(this.toggleNeopixelStrip);
            this.Controls.Add(this.toggleStrip);
            this.Controls.Add(this.colorPickerButton);
            this.Controls.Add(this.allOffButton);
            this.Controls.Add(this.allOnButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button allOnButton;
        private System.Windows.Forms.Button allOffButton;
        private System.Windows.Forms.Button colorPickerButton;
        private System.Windows.Forms.CheckBox toggleStrip;
        private System.Windows.Forms.CheckBox toggleNeopixelStrip;
    }
}

