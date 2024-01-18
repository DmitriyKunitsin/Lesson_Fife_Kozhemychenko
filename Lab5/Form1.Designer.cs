namespace Programming
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
            this.components = new System.ComponentModel.Container();
            this.formPictureBox = new System.Windows.Forms.PictureBox();
            this.formTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.decreaseMovementValue = new System.Windows.Forms.ToolStripDropDownButton();
            this.movementPerSecondStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.increaseMovementValue = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelPosX = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelPosY = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.formPictureBox)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formPictureBox
            // 
            this.formPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formPictureBox.BackColor = System.Drawing.Color.White;
            this.formPictureBox.Location = new System.Drawing.Point(0, 0);
            this.formPictureBox.Name = "formPictureBox";
            this.formPictureBox.Size = new System.Drawing.Size(800, 800);
            this.formPictureBox.TabIndex = 0;
            this.formPictureBox.TabStop = false;
            // 
            // formTimer
            // 
            this.formTimer.Tick += new System.EventHandler(this.formTimer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.decreaseMovementValue,
            this.movementPerSecondStatusLabel,
            this.increaseMovementValue,
            this.toolStripStatusLabel2,
            this.labelPosX,
            this.toolStripStatusLabel4,
            this.labelPosY});
            this.statusStrip1.Location = new System.Drawing.Point(0, 803);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(209, 17);
            this.toolStripStatusLabel1.Text = "Количство перемещений в секунду: ";
            // 
            // decreaseMovementValue
            // 
            this.decreaseMovementValue.AutoToolTip = false;
            this.decreaseMovementValue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.decreaseMovementValue.Image = global::Programming.Properties.Resources.down;
            this.decreaseMovementValue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.decreaseMovementValue.Name = "decreaseMovementValue";
            this.decreaseMovementValue.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.decreaseMovementValue.ShowDropDownArrow = false;
            this.decreaseMovementValue.Size = new System.Drawing.Size(20, 20);
            this.decreaseMovementValue.Text = "toolStripSplitButton1";
            this.decreaseMovementValue.Click += new System.EventHandler(this.decreaseMovementValue_Click);
            // 
            // movementPerSecondStatusLabel
            // 
            this.movementPerSecondStatusLabel.Name = "movementPerSecondStatusLabel";
            this.movementPerSecondStatusLabel.Size = new System.Drawing.Size(19, 17);
            this.movementPerSecondStatusLabel.Text = "10";
            // 
            // increaseMovementValue
            // 
            this.increaseMovementValue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.increaseMovementValue.Image = global::Programming.Properties.Resources.up_arrow;
            this.increaseMovementValue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.increaseMovementValue.Name = "increaseMovementValue";
            this.increaseMovementValue.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.increaseMovementValue.ShowDropDownArrow = false;
            this.increaseMovementValue.Size = new System.Drawing.Size(20, 20);
            this.increaseMovementValue.Text = "toolStripSplitButton2";
            this.increaseMovementValue.Click += new System.EventHandler(this.increaseMovementValue_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel2.Text = "; x = ";
            // 
            // labelPosX
            // 
            this.labelPosX.Name = "labelPosX";
            this.labelPosX.Size = new System.Drawing.Size(118, 17);
            this.labelPosX.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel4.Text = "; posY = ";
            // 
            // labelPosY
            // 
            this.labelPosY.Name = "labelPosY";
            this.labelPosY.Size = new System.Drawing.Size(118, 17);
            this.labelPosY.Text = "toolStripStatusLabel5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 825);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.formPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.Text = "Куницин Д.С. - задание 5 - вариант 12";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formPictureBox)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox formPictureBox;
        private System.Windows.Forms.Timer formTimer;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel movementPerSecondStatusLabel;
        private ToolStripDropDownButton decreaseMovementValue;
        private ToolStripDropDownButton increaseMovementValue;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel labelPosX;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel labelPosY;
    }
}