namespace Concrete_Cost_Calculator
{
    partial class concreteCostForm
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
            this.title = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lengthInputBox = new System.Windows.Forms.TextBox();
            this.widthinputBox = new System.Windows.Forms.TextBox();
            this.calculateCostButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.bagsRequiredLabel = new System.Windows.Forms.Label();
            this.cementKgsLabel = new System.Windows.Forms.Label();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.cementRequiredTotalTextbox = new System.Windows.Forms.TextBox();
            this.bagsRequiredTextbox = new System.Windows.Forms.TextBox();
            this.totalVolumeOfConcreteTextbox = new System.Windows.Forms.TextBox();
            this.TotalCostTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(65, 30);
            this.title.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(321, 31);
            this.title.TabIndex = 0;
            this.title.Text = "Driveway Measurements:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(111, 100);
            this.lengthLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(97, 31);
            this.lengthLabel.TabIndex = 1;
            this.lengthLabel.Text = "Length";
            this.lengthLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(125, 143);
            this.widthLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(83, 31);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Depth 0.5m";
            // 
            // lengthInputBox
            // 
            this.lengthInputBox.Location = new System.Drawing.Point(219, 100);
            this.lengthInputBox.Name = "lengthInputBox";
            this.lengthInputBox.Size = new System.Drawing.Size(100, 38);
            this.lengthInputBox.TabIndex = 0;
            // 
            // widthinputBox
            // 
            this.widthinputBox.Location = new System.Drawing.Point(219, 144);
            this.widthinputBox.Name = "widthinputBox";
            this.widthinputBox.Size = new System.Drawing.Size(100, 38);
            this.widthinputBox.TabIndex = 1;
            // 
            // calculateCostButton
            // 
            this.calculateCostButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.calculateCostButton.Location = new System.Drawing.Point(36, 219);
            this.calculateCostButton.Name = "calculateCostButton";
            this.calculateCostButton.Size = new System.Drawing.Size(228, 72);
            this.calculateCostButton.TabIndex = 2;
            this.calculateCostButton.Text = "Calculate Concrete Cost";
            this.calculateCostButton.UseVisualStyleBackColor = true;
            this.calculateCostButton.Click += new System.EventHandler(this.calculateCostButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(270, 219);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(94, 48);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(370, 219);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(91, 48);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(46, 298);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(279, 31);
            this.totalCostLabel.TabIndex = 9;
            this.totalCostLabel.Text = "Total Cost of Cement:";
            this.totalCostLabel.Click += new System.EventHandler(this.totalCostLabel_Click);
            // 
            // bagsRequiredLabel
            // 
            this.bagsRequiredLabel.AutoSize = true;
            this.bagsRequiredLabel.Location = new System.Drawing.Point(124, 339);
            this.bagsRequiredLabel.Name = "bagsRequiredLabel";
            this.bagsRequiredLabel.Size = new System.Drawing.Size(201, 31);
            this.bagsRequiredLabel.TabIndex = 10;
            this.bagsRequiredLabel.Text = "Bags Required:";
            // 
            // cementKgsLabel
            // 
            this.cementKgsLabel.AutoSize = true;
            this.cementKgsLabel.Location = new System.Drawing.Point(2, 387);
            this.cementKgsLabel.Name = "cementKgsLabel";
            this.cementKgsLabel.Size = new System.Drawing.Size(323, 31);
            this.cementKgsLabel.TabIndex = 11;
            this.cementKgsLabel.Text = "Kg\'s of Cement Required:";
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(-4, 427);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(329, 31);
            this.volumeLabel.TabIndex = 12;
            this.volumeLabel.Text = "Total Volume of Concrete:";
            this.volumeLabel.Click += new System.EventHandler(this.volumeLabel_Click);
            // 
            // cementRequiredTotalTextbox
            // 
            this.cementRequiredTotalTextbox.Location = new System.Drawing.Point(331, 380);
            this.cementRequiredTotalTextbox.Name = "cementRequiredTotalTextbox";
            this.cementRequiredTotalTextbox.ReadOnly = true;
            this.cementRequiredTotalTextbox.Size = new System.Drawing.Size(130, 38);
            this.cementRequiredTotalTextbox.TabIndex = 7;
            this.cementRequiredTotalTextbox.TextChanged += new System.EventHandler(this.cementRequiredTotalTextbox_TextChanged);
            // 
            // bagsRequiredTextbox
            // 
            this.bagsRequiredTextbox.Location = new System.Drawing.Point(331, 336);
            this.bagsRequiredTextbox.Name = "bagsRequiredTextbox";
            this.bagsRequiredTextbox.ReadOnly = true;
            this.bagsRequiredTextbox.Size = new System.Drawing.Size(130, 38);
            this.bagsRequiredTextbox.TabIndex = 6;
            // 
            // totalVolumeOfConcreteTextbox
            // 
            this.totalVolumeOfConcreteTextbox.Location = new System.Drawing.Point(331, 424);
            this.totalVolumeOfConcreteTextbox.Name = "totalVolumeOfConcreteTextbox";
            this.totalVolumeOfConcreteTextbox.ReadOnly = true;
            this.totalVolumeOfConcreteTextbox.Size = new System.Drawing.Size(130, 38);
            this.totalVolumeOfConcreteTextbox.TabIndex = 8;
            // 
            // TotalCostTextBox
            // 
            this.TotalCostTextBox.Location = new System.Drawing.Point(331, 295);
            this.TotalCostTextBox.Name = "TotalCostTextBox";
            this.TotalCostTextBox.ReadOnly = true;
            this.TotalCostTextBox.Size = new System.Drawing.Size(130, 38);
            this.TotalCostTextBox.TabIndex = 5;
            // 
            // concreteCostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 480);
            this.Controls.Add(this.TotalCostTextBox);
            this.Controls.Add(this.totalVolumeOfConcreteTextbox);
            this.Controls.Add(this.bagsRequiredTextbox);
            this.Controls.Add(this.cementRequiredTotalTextbox);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.cementKgsLabel);
            this.Controls.Add(this.bagsRequiredLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateCostButton);
            this.Controls.Add(this.widthinputBox);
            this.Controls.Add(this.lengthInputBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximumSize = new System.Drawing.Size(493, 519);
            this.MinimumSize = new System.Drawing.Size(493, 519);
            this.Name = "concreteCostForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concrete Cost Calculator";
            this.Load += new System.EventHandler(this.concreteCostForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lengthInputBox;
        private System.Windows.Forms.TextBox widthinputBox;
        private System.Windows.Forms.Button calculateCostButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label bagsRequiredLabel;
        private System.Windows.Forms.Label cementKgsLabel;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.TextBox cementRequiredTotalTextbox;
        private System.Windows.Forms.TextBox bagsRequiredTextbox;
        private System.Windows.Forms.TextBox totalVolumeOfConcreteTextbox;
        private System.Windows.Forms.TextBox TotalCostTextBox;
    }
}

