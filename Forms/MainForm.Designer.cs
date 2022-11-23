namespace ZeldaMaterialGenerator
{
    partial class MainForm
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
            this.MaterialGrid = new System.Windows.Forms.DataGridView();
            this.OpenModelButton = new System.Windows.Forms.Button();
            this.loadedModelLabel = new System.Windows.Forms.Label();
            this.Inspector = new System.Windows.Forms.Panel();
            this.Inspector_Material_MaterialPreset = new System.Windows.Forms.ComboBox();
            this.Inspector_Texture_HasAlpha = new System.Windows.Forms.CheckBox();
            this.Inspector_SelectedObjectLabel = new System.Windows.Forms.Label();
            this.MaterialInspectorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialGrid)).BeginInit();
            this.Inspector.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaterialGrid
            // 
            this.MaterialGrid.AllowUserToAddRows = false;
            this.MaterialGrid.AllowUserToDeleteRows = false;
            this.MaterialGrid.AllowUserToResizeColumns = false;
            this.MaterialGrid.AllowUserToResizeRows = false;
            this.MaterialGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MaterialGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaterialGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaterialGrid.Location = new System.Drawing.Point(12, 12);
            this.MaterialGrid.MultiSelect = false;
            this.MaterialGrid.Name = "MaterialGrid";
            this.MaterialGrid.ReadOnly = true;
            this.MaterialGrid.RowHeadersVisible = false;
            this.MaterialGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MaterialGrid.ShowCellErrors = false;
            this.MaterialGrid.ShowCellToolTips = false;
            this.MaterialGrid.ShowEditingIcon = false;
            this.MaterialGrid.ShowRowErrors = false;
            this.MaterialGrid.Size = new System.Drawing.Size(402, 657);
            this.MaterialGrid.TabIndex = 2;
            this.MaterialGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MaterialGrid_CellClick);
            // 
            // OpenModelButton
            // 
            this.OpenModelButton.Location = new System.Drawing.Point(581, 12);
            this.OpenModelButton.Name = "OpenModelButton";
            this.OpenModelButton.Size = new System.Drawing.Size(91, 32);
            this.OpenModelButton.TabIndex = 3;
            this.OpenModelButton.Text = "Open Model";
            this.OpenModelButton.UseVisualStyleBackColor = true;
            this.OpenModelButton.Click += new System.EventHandler(this.OpenModelButton_Click);
            // 
            // loadedModelLabel
            // 
            this.loadedModelLabel.AutoSize = true;
            this.loadedModelLabel.Location = new System.Drawing.Point(578, 47);
            this.loadedModelLabel.Name = "loadedModelLabel";
            this.loadedModelLabel.Size = new System.Drawing.Size(98, 13);
            this.loadedModelLabel.TabIndex = 4;
            this.loadedModelLabel.Text = "LoadedModelLabel";
            this.loadedModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Inspector
            // 
            this.Inspector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Inspector.Controls.Add(this.Inspector_Material_MaterialPreset);
            this.Inspector.Controls.Add(this.Inspector_Texture_HasAlpha);
            this.Inspector.Controls.Add(this.Inspector_SelectedObjectLabel);
            this.Inspector.Location = new System.Drawing.Point(420, 63);
            this.Inspector.Name = "Inspector";
            this.Inspector.Size = new System.Drawing.Size(252, 606);
            this.Inspector.TabIndex = 5;
            // 
            // Inspector_Material_MaterialPreset
            // 
            this.Inspector_Material_MaterialPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Inspector_Material_MaterialPreset.FormattingEnabled = true;
            this.Inspector_Material_MaterialPreset.Items.AddRange(new object[] {
            "Default",
            "Test"});
            this.Inspector_Material_MaterialPreset.Location = new System.Drawing.Point(3, 19);
            this.Inspector_Material_MaterialPreset.Name = "Inspector_Material_MaterialPreset";
            this.Inspector_Material_MaterialPreset.Size = new System.Drawing.Size(121, 21);
            this.Inspector_Material_MaterialPreset.TabIndex = 3;
            // 
            // Inspector_Texture_HasAlpha
            // 
            this.Inspector_Texture_HasAlpha.AutoSize = true;
            this.Inspector_Texture_HasAlpha.Location = new System.Drawing.Point(160, 19);
            this.Inspector_Texture_HasAlpha.Name = "Inspector_Texture_HasAlpha";
            this.Inspector_Texture_HasAlpha.Size = new System.Drawing.Size(75, 17);
            this.Inspector_Texture_HasAlpha.TabIndex = 2;
            this.Inspector_Texture_HasAlpha.Text = "Has Alpha";
            this.Inspector_Texture_HasAlpha.UseVisualStyleBackColor = true;
            // 
            // Inspector_SelectedObjectLabel
            // 
            this.Inspector_SelectedObjectLabel.AutoSize = true;
            this.Inspector_SelectedObjectLabel.Location = new System.Drawing.Point(3, 3);
            this.Inspector_SelectedObjectLabel.Name = "Inspector_SelectedObjectLabel";
            this.Inspector_SelectedObjectLabel.Size = new System.Drawing.Size(83, 13);
            this.Inspector_SelectedObjectLabel.TabIndex = 0;
            this.Inspector_SelectedObjectLabel.Text = "Selected Object";
            // 
            // MaterialInspectorLabel
            // 
            this.MaterialInspectorLabel.AutoSize = true;
            this.MaterialInspectorLabel.Location = new System.Drawing.Point(417, 47);
            this.MaterialInspectorLabel.Name = "MaterialInspectorLabel";
            this.MaterialInspectorLabel.Size = new System.Drawing.Size(51, 13);
            this.MaterialInspectorLabel.TabIndex = 6;
            this.MaterialInspectorLabel.Text = "Inspector";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 681);
            this.Controls.Add(this.MaterialInspectorLabel);
            this.Controls.Add(this.Inspector);
            this.Controls.Add(this.loadedModelLabel);
            this.Controls.Add(this.OpenModelButton);
            this.Controls.Add(this.MaterialGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Zelda Material Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaterialGrid)).EndInit();
            this.Inspector.ResumeLayout(false);
            this.Inspector.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView MaterialGrid;
        private System.Windows.Forms.Button OpenModelButton;
        private System.Windows.Forms.Label loadedModelLabel;
        private System.Windows.Forms.Panel Inspector;
        private System.Windows.Forms.Label Inspector_SelectedObjectLabel;
        private System.Windows.Forms.Label MaterialInspectorLabel;
        private System.Windows.Forms.CheckBox Inspector_Texture_HasAlpha;
        private System.Windows.Forms.ComboBox Inspector_Material_MaterialPreset;
    }
}

