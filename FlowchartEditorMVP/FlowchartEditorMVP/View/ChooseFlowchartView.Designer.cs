﻿namespace FlowchartEditorMVP.View
{
    partial class ChooseFlowchartView
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
            this.flowchartDataGridView = new System.Windows.Forms.DataGridView();
            this.openButton = new System.Windows.Forms.Button();
            this.createNewButton = new System.Windows.Forms.Button();
            this.changeUserButton = new System.Windows.Forms.Button();
            this.excLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flowchartDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // flowchartDataGridView
            // 
            this.flowchartDataGridView.AllowUserToAddRows = false;
            this.flowchartDataGridView.AllowUserToDeleteRows = false;
            this.flowchartDataGridView.AllowUserToResizeRows = false;
            this.flowchartDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.flowchartDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.flowchartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flowchartDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.flowchartDataGridView.Location = new System.Drawing.Point(225, 50);
            this.flowchartDataGridView.Name = "flowchartDataGridView";
            this.flowchartDataGridView.Size = new System.Drawing.Size(472, 600);
            this.flowchartDataGridView.TabIndex = 0;
            this.flowchartDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.flowchartDataGridView_CellClick);
            // 
            // openButton
            // 
            this.openButton.Enabled = false;
            this.openButton.Location = new System.Drawing.Point(715, 50);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(122, 43);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // createNewButton
            // 
            this.createNewButton.Location = new System.Drawing.Point(849, 50);
            this.createNewButton.Name = "createNewButton";
            this.createNewButton.Size = new System.Drawing.Size(122, 43);
            this.createNewButton.TabIndex = 1;
            this.createNewButton.Text = "Create new";
            this.createNewButton.UseVisualStyleBackColor = true;
            this.createNewButton.Click += new System.EventHandler(this.createNewButton_Click);
            // 
            // changeUserButton
            // 
            this.changeUserButton.Location = new System.Drawing.Point(84, 50);
            this.changeUserButton.Name = "changeUserButton";
            this.changeUserButton.Size = new System.Drawing.Size(122, 43);
            this.changeUserButton.TabIndex = 1;
            this.changeUserButton.Text = "Change user";
            this.changeUserButton.UseVisualStyleBackColor = true;
            this.changeUserButton.Click += new System.EventHandler(this.changeUserButton_Click);
            // 
            // excLabel
            // 
            this.excLabel.AutoSize = true;
            this.excLabel.Location = new System.Drawing.Point(712, 96);
            this.excLabel.Name = "excLabel";
            this.excLabel.Size = new System.Drawing.Size(0, 13);
            this.excLabel.TabIndex = 2;
            // 
            // ChooseFlowchartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 335);
            this.Controls.Add(this.excLabel);
            this.Controls.Add(this.createNewButton);
            this.Controls.Add(this.changeUserButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.flowchartDataGridView);
            this.Name = "ChooseFlowchartView";
            this.Text = "Flowchart Editor";
            this.Load += new System.EventHandler(this.ChooseFlowchartView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flowchartDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView flowchartDataGridView;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button createNewButton;
        private System.Windows.Forms.Button changeUserButton;
        private System.Windows.Forms.Label excLabel;
    }
}