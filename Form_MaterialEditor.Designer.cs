namespace JMaterialGenerator
{
    partial class Form_MaterialEditor
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
            this.MaterialListBox = new System.Windows.Forms.ListBox();
            this.Button_LoadModel = new System.Windows.Forms.Button();
            this.LoadedModelLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextureSetting_Dropdown_Format = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TextureSetting_Dropdown_SelectedTexture = new System.Windows.Forms.ComboBox();
            this.TextureSetting_NumericUpDown_LodBias = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.TextureSetting_NumericUpDown_AlphaSetting = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.TextureSetting_NumericUpDown_MaxAniso = new System.Windows.Forms.NumericUpDown();
            this.TextureSetting_Dropdown_MinFilter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextureSetting_NumericUpDown_MipMap = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.TextureSetting_NumericUpDown_MaxLOD = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.TextureSetting_Toggle_EdgeLOD = new System.Windows.Forms.CheckBox();
            this.TextureSetting_Dropdown_WrapS = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TextureSetting_Dropdown_MagFilter = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextureSetting_Dropdown_PaletteFormat = new System.Windows.Forms.ComboBox();
            this.TextureSetting_Toggle_BiasClamp = new System.Windows.Forms.CheckBox();
            this.TextureSetting_NumericUpDown_MinLOD = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextureSetting_Dropdown_WrapT = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Button_CreateHeaders = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.ZMGSetting_Game = new System.Windows.Forms.ComboBox();
            this.TextureSetting_TWW_NumericUpDown_unknown3 = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.TextureSetting_TWW_NumericUpDown_unknown2 = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.MaterialSetting_Dropdown_Preset = new System.Windows.Forms.ComboBox();
            this.SelectedTextureLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TextureSetting_Button_AddTextureToMaterial = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextureSetting_NumericUpDown_LodBias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextureSetting_NumericUpDown_AlphaSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextureSetting_NumericUpDown_MaxAniso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextureSetting_NumericUpDown_MipMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextureSetting_NumericUpDown_MaxLOD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextureSetting_NumericUpDown_MinLOD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextureSetting_TWW_NumericUpDown_unknown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextureSetting_TWW_NumericUpDown_unknown2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaterialListBox
            // 
            this.MaterialListBox.FormattingEnabled = true;
            this.MaterialListBox.ItemHeight = 15;
            this.MaterialListBox.Location = new System.Drawing.Point(12, 27);
            this.MaterialListBox.Name = "MaterialListBox";
            this.MaterialListBox.Size = new System.Drawing.Size(200, 499);
            this.MaterialListBox.TabIndex = 0;
            this.MaterialListBox.SelectedIndexChanged += new System.EventHandler(this.MaterialListBox_SelectedIndexChanged);
            // 
            // Button_LoadModel
            // 
            this.Button_LoadModel.Location = new System.Drawing.Point(456, 565);
            this.Button_LoadModel.Name = "Button_LoadModel";
            this.Button_LoadModel.Size = new System.Drawing.Size(213, 23);
            this.Button_LoadModel.TabIndex = 1;
            this.Button_LoadModel.Text = "Load Model";
            this.Button_LoadModel.UseVisualStyleBackColor = true;
            this.Button_LoadModel.Click += new System.EventHandler(this.Button_LoadModel_Click);
            // 
            // LoadedModelLabel
            // 
            this.LoadedModelLabel.AutoSize = true;
            this.LoadedModelLabel.Location = new System.Drawing.Point(12, 9);
            this.LoadedModelLabel.Name = "LoadedModelLabel";
            this.LoadedModelLabel.Size = new System.Drawing.Size(83, 15);
            this.LoadedModelLabel.TabIndex = 2;
            this.LoadedModelLabel.Text = "Loaded Model";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.TextureSetting_Button_AddTextureToMaterial);
            this.panel1.Controls.Add(this.TextureSetting_Dropdown_Format);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.TextureSetting_Dropdown_SelectedTexture);
            this.panel1.Controls.Add(this.TextureSetting_NumericUpDown_LodBias);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.TextureSetting_NumericUpDown_AlphaSetting);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TextureSetting_NumericUpDown_MaxAniso);
            this.panel1.Controls.Add(this.TextureSetting_Dropdown_MinFilter);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextureSetting_NumericUpDown_MipMap);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TextureSetting_NumericUpDown_MaxLOD);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.TextureSetting_Toggle_EdgeLOD);
            this.panel1.Controls.Add(this.TextureSetting_Dropdown_WrapS);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.TextureSetting_Dropdown_MagFilter);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TextureSetting_Dropdown_PaletteFormat);
            this.panel1.Controls.Add(this.TextureSetting_Toggle_BiasClamp);
            this.panel1.Controls.Add(this.TextureSetting_NumericUpDown_MinLOD);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TextureSetting_Dropdown_WrapT);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(218, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 499);
            this.panel1.TabIndex = 4;
            // 
            // TextureSetting_Dropdown_Format
            // 
            this.TextureSetting_Dropdown_Format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextureSetting_Dropdown_Format.FormattingEnabled = true;
            this.TextureSetting_Dropdown_Format.Location = new System.Drawing.Point(3, 72);
            this.TextureSetting_Dropdown_Format.Name = "TextureSetting_Dropdown_Format";
            this.TextureSetting_Dropdown_Format.Size = new System.Drawing.Size(121, 23);
            this.TextureSetting_Dropdown_Format.TabIndex = 0;
            this.TextureSetting_Dropdown_Format.SelectedIndexChanged += new System.EventHandler(this.TextureSetting_Dropdown_Format_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(130, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 15);
            this.label16.TabIndex = 43;
            this.label16.Text = "Selected Texture";
            // 
            // TextureSetting_Dropdown_SelectedTexture
            // 
            this.TextureSetting_Dropdown_SelectedTexture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextureSetting_Dropdown_SelectedTexture.FormattingEnabled = true;
            this.TextureSetting_Dropdown_SelectedTexture.Location = new System.Drawing.Point(3, 44);
            this.TextureSetting_Dropdown_SelectedTexture.Name = "TextureSetting_Dropdown_SelectedTexture";
            this.TextureSetting_Dropdown_SelectedTexture.Size = new System.Drawing.Size(121, 23);
            this.TextureSetting_Dropdown_SelectedTexture.TabIndex = 42;
            // 
            // TextureSetting_NumericUpDown_LodBias
            // 
            this.TextureSetting_NumericUpDown_LodBias.Location = new System.Drawing.Point(4, 452);
            this.TextureSetting_NumericUpDown_LodBias.Name = "TextureSetting_NumericUpDown_LodBias";
            this.TextureSetting_NumericUpDown_LodBias.Size = new System.Drawing.Size(121, 23);
            this.TextureSetting_NumericUpDown_LodBias.TabIndex = 30;
            this.TextureSetting_NumericUpDown_LodBias.ValueChanged += new System.EventHandler(this.TextureSetting_NumericUpDown_LodBias_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(131, 452);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 15);
            this.label14.TabIndex = 29;
            this.label14.Text = "LOD Bias";
            // 
            // TextureSetting_NumericUpDown_AlphaSetting
            // 
            this.TextureSetting_NumericUpDown_AlphaSetting.Location = new System.Drawing.Point(3, 101);
            this.TextureSetting_NumericUpDown_AlphaSetting.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.TextureSetting_NumericUpDown_AlphaSetting.Name = "TextureSetting_NumericUpDown_AlphaSetting";
            this.TextureSetting_NumericUpDown_AlphaSetting.Size = new System.Drawing.Size(121, 23);
            this.TextureSetting_NumericUpDown_AlphaSetting.TabIndex = 11;
            this.TextureSetting_NumericUpDown_AlphaSetting.ValueChanged += new System.EventHandler(this.TextureSetting_NumericUpDown_AlphaSetting_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Format";
            // 
            // TextureSetting_NumericUpDown_MaxAniso
            // 
            this.TextureSetting_NumericUpDown_MaxAniso.Location = new System.Drawing.Point(4, 304);
            this.TextureSetting_NumericUpDown_MaxAniso.Name = "TextureSetting_NumericUpDown_MaxAniso";
            this.TextureSetting_NumericUpDown_MaxAniso.Size = new System.Drawing.Size(121, 23);
            this.TextureSetting_NumericUpDown_MaxAniso.TabIndex = 20;
            this.TextureSetting_NumericUpDown_MaxAniso.ValueChanged += new System.EventHandler(this.TextureSetting_NumericUpDown_MaxAniso_ValueChanged);
            // 
            // TextureSetting_Dropdown_MinFilter
            // 
            this.TextureSetting_Dropdown_MinFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextureSetting_Dropdown_MinFilter.FormattingEnabled = true;
            this.TextureSetting_Dropdown_MinFilter.Location = new System.Drawing.Point(4, 333);
            this.TextureSetting_Dropdown_MinFilter.Name = "TextureSetting_Dropdown_MinFilter";
            this.TextureSetting_Dropdown_MinFilter.Size = new System.Drawing.Size(121, 23);
            this.TextureSetting_Dropdown_MinFilter.TabIndex = 21;
            this.TextureSetting_Dropdown_MinFilter.SelectedIndexChanged += new System.EventHandler(this.TextureSetting_Dropdown_MinFilter_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "MipMap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alpha Setting";
            // 
            // TextureSetting_NumericUpDown_MipMap
            // 
            this.TextureSetting_NumericUpDown_MipMap.Location = new System.Drawing.Point(4, 217);
            this.TextureSetting_NumericUpDown_MipMap.Name = "TextureSetting_NumericUpDown_MipMap";
            this.TextureSetting_NumericUpDown_MipMap.Size = new System.Drawing.Size(120, 23);
            this.TextureSetting_NumericUpDown_MipMap.TabIndex = 10;
            this.TextureSetting_NumericUpDown_MipMap.ValueChanged += new System.EventHandler(this.TextureSetting_NumericUpDown_MipMap_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(131, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Max Aniso";
            // 
            // TextureSetting_NumericUpDown_MaxLOD
            // 
            this.TextureSetting_NumericUpDown_MaxLOD.Location = new System.Drawing.Point(4, 423);
            this.TextureSetting_NumericUpDown_MaxLOD.Name = "TextureSetting_NumericUpDown_MaxLOD";
            this.TextureSetting_NumericUpDown_MaxLOD.Size = new System.Drawing.Size(121, 23);
            this.TextureSetting_NumericUpDown_MaxLOD.TabIndex = 28;
            this.TextureSetting_NumericUpDown_MaxLOD.ValueChanged += new System.EventHandler(this.TextureSetting_NumericUpDown_MaxLOD_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Min Filter";
            // 
            // TextureSetting_Toggle_EdgeLOD
            // 
            this.TextureSetting_Toggle_EdgeLOD.AutoSize = true;
            this.TextureSetting_Toggle_EdgeLOD.Location = new System.Drawing.Point(4, 247);
            this.TextureSetting_Toggle_EdgeLOD.Name = "TextureSetting_Toggle_EdgeLOD";
            this.TextureSetting_Toggle_EdgeLOD.Size = new System.Drawing.Size(15, 14);
            this.TextureSetting_Toggle_EdgeLOD.TabIndex = 13;
            this.TextureSetting_Toggle_EdgeLOD.UseVisualStyleBackColor = true;
            this.TextureSetting_Toggle_EdgeLOD.CheckedChanged += new System.EventHandler(this.TextureSetting_Toggle_EdgeLOD_CheckedChanged);
            // 
            // TextureSetting_Dropdown_WrapS
            // 
            this.TextureSetting_Dropdown_WrapS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextureSetting_Dropdown_WrapS.FormattingEnabled = true;
            this.TextureSetting_Dropdown_WrapS.Location = new System.Drawing.Point(3, 130);
            this.TextureSetting_Dropdown_WrapS.Name = "TextureSetting_Dropdown_WrapS";
            this.TextureSetting_Dropdown_WrapS.Size = new System.Drawing.Size(121, 23);
            this.TextureSetting_Dropdown_WrapS.TabIndex = 4;
            this.TextureSetting_Dropdown_WrapS.SelectedIndexChanged += new System.EventHandler(this.TextureSetting_Dropdown_WrapS_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Palette Format";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Bias Clamp";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(131, 423);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "Max LOD";
            // 
            // TextureSetting_Dropdown_MagFilter
            // 
            this.TextureSetting_Dropdown_MagFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextureSetting_Dropdown_MagFilter.FormattingEnabled = true;
            this.TextureSetting_Dropdown_MagFilter.Location = new System.Drawing.Point(4, 362);
            this.TextureSetting_Dropdown_MagFilter.Name = "TextureSetting_Dropdown_MagFilter";
            this.TextureSetting_Dropdown_MagFilter.Size = new System.Drawing.Size(121, 23);
            this.TextureSetting_Dropdown_MagFilter.TabIndex = 23;
            this.TextureSetting_Dropdown_MagFilter.SelectedIndexChanged += new System.EventHandler(this.TextureSetting_Dropdown_MagFilter_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Edge LOD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "WrapS";
            // 
            // TextureSetting_Dropdown_PaletteFormat
            // 
            this.TextureSetting_Dropdown_PaletteFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextureSetting_Dropdown_PaletteFormat.FormattingEnabled = true;
            this.TextureSetting_Dropdown_PaletteFormat.Location = new System.Drawing.Point(3, 188);
            this.TextureSetting_Dropdown_PaletteFormat.Name = "TextureSetting_Dropdown_PaletteFormat";
            this.TextureSetting_Dropdown_PaletteFormat.Size = new System.Drawing.Size(121, 23);
            this.TextureSetting_Dropdown_PaletteFormat.TabIndex = 8;
            this.TextureSetting_Dropdown_PaletteFormat.SelectedIndexChanged += new System.EventHandler(this.TextureSetting_Dropdown_PaletteFormat_SelectedIndexChanged);
            // 
            // TextureSetting_Toggle_BiasClamp
            // 
            this.TextureSetting_Toggle_BiasClamp.AutoSize = true;
            this.TextureSetting_Toggle_BiasClamp.Location = new System.Drawing.Point(4, 276);
            this.TextureSetting_Toggle_BiasClamp.Name = "TextureSetting_Toggle_BiasClamp";
            this.TextureSetting_Toggle_BiasClamp.Size = new System.Drawing.Size(15, 14);
            this.TextureSetting_Toggle_BiasClamp.TabIndex = 15;
            this.TextureSetting_Toggle_BiasClamp.UseVisualStyleBackColor = true;
            this.TextureSetting_Toggle_BiasClamp.CheckedChanged += new System.EventHandler(this.TextureSetting_Toggle_BiasClamp_CheckedChanged);
            // 
            // TextureSetting_NumericUpDown_MinLOD
            // 
            this.TextureSetting_NumericUpDown_MinLOD.Location = new System.Drawing.Point(3, 394);
            this.TextureSetting_NumericUpDown_MinLOD.Name = "TextureSetting_NumericUpDown_MinLOD";
            this.TextureSetting_NumericUpDown_MinLOD.Size = new System.Drawing.Size(121, 23);
            this.TextureSetting_NumericUpDown_MinLOD.TabIndex = 26;
            this.TextureSetting_NumericUpDown_MinLOD.ValueChanged += new System.EventHandler(this.TextureSetting_NumericUpDown_MinLOD_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(131, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Mag Filter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "WrapT";
            // 
            // TextureSetting_Dropdown_WrapT
            // 
            this.TextureSetting_Dropdown_WrapT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextureSetting_Dropdown_WrapT.FormattingEnabled = true;
            this.TextureSetting_Dropdown_WrapT.Location = new System.Drawing.Point(3, 159);
            this.TextureSetting_Dropdown_WrapT.Name = "TextureSetting_Dropdown_WrapT";
            this.TextureSetting_Dropdown_WrapT.Size = new System.Drawing.Size(121, 23);
            this.TextureSetting_Dropdown_WrapT.TabIndex = 6;
            this.TextureSetting_Dropdown_WrapT.SelectedIndexChanged += new System.EventHandler(this.TextureSetting_Dropdown_WrapT_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(130, 394);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "Min LOD";
            // 
            // Button_CreateHeaders
            // 
            this.Button_CreateHeaders.Location = new System.Drawing.Point(456, 594);
            this.Button_CreateHeaders.Name = "Button_CreateHeaders";
            this.Button_CreateHeaders.Size = new System.Drawing.Size(213, 23);
            this.Button_CreateHeaders.TabIndex = 5;
            this.Button_CreateHeaders.Text = "Create Headers";
            this.Button_CreateHeaders.UseVisualStyleBackColor = true;
            this.Button_CreateHeaders.Click += new System.EventHandler(this.Button_CreateHeaders_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(764, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 15);
            this.label17.TabIndex = 36;
            this.label17.Text = "Game";
            // 
            // ZMGSetting_Game
            // 
            this.ZMGSetting_Game.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ZMGSetting_Game.FormattingEnabled = true;
            this.ZMGSetting_Game.Location = new System.Drawing.Point(641, 27);
            this.ZMGSetting_Game.Name = "ZMGSetting_Game";
            this.ZMGSetting_Game.Size = new System.Drawing.Size(117, 23);
            this.ZMGSetting_Game.TabIndex = 35;
            this.ZMGSetting_Game.SelectedIndexChanged += new System.EventHandler(this.ZMGSetting_Game_SelectedIndexChanged);
            // 
            // TextureSetting_TWW_NumericUpDown_unknown3
            // 
            this.TextureSetting_TWW_NumericUpDown_unknown3.Location = new System.Drawing.Point(6, 37);
            this.TextureSetting_TWW_NumericUpDown_unknown3.Name = "TextureSetting_TWW_NumericUpDown_unknown3";
            this.TextureSetting_TWW_NumericUpDown_unknown3.Size = new System.Drawing.Size(95, 23);
            this.TextureSetting_TWW_NumericUpDown_unknown3.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(107, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 15);
            this.label18.TabIndex = 39;
            this.label18.Text = "unknown3";
            // 
            // TextureSetting_TWW_NumericUpDown_unknown2
            // 
            this.TextureSetting_TWW_NumericUpDown_unknown2.Location = new System.Drawing.Point(6, 8);
            this.TextureSetting_TWW_NumericUpDown_unknown2.Name = "TextureSetting_TWW_NumericUpDown_unknown2";
            this.TextureSetting_TWW_NumericUpDown_unknown2.Size = new System.Drawing.Size(95, 23);
            this.TextureSetting_TWW_NumericUpDown_unknown2.TabIndex = 38;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(107, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 15);
            this.label19.TabIndex = 37;
            this.label19.Text = "unknown2";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(764, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 15);
            this.label20.TabIndex = 40;
            this.label20.Text = "Material Preset";
            // 
            // MaterialSetting_Dropdown_Preset
            // 
            this.MaterialSetting_Dropdown_Preset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialSetting_Dropdown_Preset.FormattingEnabled = true;
            this.MaterialSetting_Dropdown_Preset.Location = new System.Drawing.Point(641, 56);
            this.MaterialSetting_Dropdown_Preset.Name = "MaterialSetting_Dropdown_Preset";
            this.MaterialSetting_Dropdown_Preset.Size = new System.Drawing.Size(117, 23);
            this.MaterialSetting_Dropdown_Preset.TabIndex = 39;
            this.MaterialSetting_Dropdown_Preset.SelectedIndexChanged += new System.EventHandler(this.MaterialSetting_Dropdown_Preset_SelectedIndexChanged);
            // 
            // SelectedTextureLabel
            // 
            this.SelectedTextureLabel.AutoSize = true;
            this.SelectedTextureLabel.Location = new System.Drawing.Point(244, 9);
            this.SelectedTextureLabel.Name = "SelectedTextureLabel";
            this.SelectedTextureLabel.Size = new System.Drawing.Size(92, 15);
            this.SelectedTextureLabel.TabIndex = 39;
            this.SelectedTextureLabel.Text = "Selected Texture";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(456, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 15);
            this.label15.TabIndex = 40;
            this.label15.Text = "Per-Game Settings";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.TextureSetting_TWW_NumericUpDown_unknown2);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.TextureSetting_TWW_NumericUpDown_unknown3);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Location = new System.Drawing.Point(456, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 499);
            this.panel4.TabIndex = 41;
            // 
            // TextureSetting_Button_AddTextureToMaterial
            // 
            this.TextureSetting_Button_AddTextureToMaterial.Location = new System.Drawing.Point(3, 3);
            this.TextureSetting_Button_AddTextureToMaterial.Name = "TextureSetting_Button_AddTextureToMaterial";
            this.TextureSetting_Button_AddTextureToMaterial.Size = new System.Drawing.Size(77, 35);
            this.TextureSetting_Button_AddTextureToMaterial.TabIndex = 42;
            this.TextureSetting_Button_AddTextureToMaterial.Text = "Add texture";
            this.TextureSetting_Button_AddTextureToMaterial.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 35);
            this.button1.TabIndex = 44;
            this.button1.Text = "Remove texture";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form_MaterialEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 654);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.MaterialSetting_Dropdown_Preset);
            this.Controls.Add(this.SelectedTextureLabel);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.ZMGSetting_Game);
            this.Controls.Add(this.Button_CreateHeaders);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoadedModelLabel);
            this.Controls.Add(this.Button_LoadModel);
            this.Controls.Add(this.MaterialListBox);
            this.Name = "Form_MaterialEditor";
            this.Text = "JMaterialGenerator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextureSetting_NumericUpDown_LodBias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextureSetting_NumericUpDown_AlphaSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextureSetting_NumericUpDown_MaxAniso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextureSetting_NumericUpDown_MipMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextureSetting_NumericUpDown_MaxLOD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextureSetting_NumericUpDown_MinLOD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextureSetting_TWW_NumericUpDown_unknown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextureSetting_TWW_NumericUpDown_unknown2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox MaterialListBox;
        private Button Button_LoadModel;
        private Label LoadedModelLabel;
        private Panel panel1;
        private Button Button_CreateHeaders;
        private Label label17;
        private ComboBox ZMGSetting_Game;
        private NumericUpDown TextureSetting_TWW_NumericUpDown_unknown3;
        private Label label18;
        private NumericUpDown TextureSetting_TWW_NumericUpDown_unknown2;
        private Label label19;
        private Label label20;
        private ComboBox MaterialSetting_Dropdown_Preset;
        private Label SelectedTextureLabel;
        private Label label15;
        private Panel panel4;
        private Label label16;
        private ComboBox TextureSetting_Dropdown_SelectedTexture;
        private ComboBox TextureSetting_Dropdown_Format;
        private NumericUpDown TextureSetting_NumericUpDown_LodBias;
        private Label label14;
        private NumericUpDown TextureSetting_NumericUpDown_AlphaSetting;
        private Label label1;
        private NumericUpDown TextureSetting_NumericUpDown_MaxAniso;
        private ComboBox TextureSetting_Dropdown_MinFilter;
        private Label label6;
        private Label label2;
        private NumericUpDown TextureSetting_NumericUpDown_MipMap;
        private Label label10;
        private NumericUpDown TextureSetting_NumericUpDown_MaxLOD;
        private Label label9;
        private CheckBox TextureSetting_Toggle_EdgeLOD;
        private ComboBox TextureSetting_Dropdown_WrapS;
        private Label label5;
        private Label label8;
        private Label label13;
        private ComboBox TextureSetting_Dropdown_MagFilter;
        private Label label7;
        private Label label3;
        private ComboBox TextureSetting_Dropdown_PaletteFormat;
        private CheckBox TextureSetting_Toggle_BiasClamp;
        private NumericUpDown TextureSetting_NumericUpDown_MinLOD;
        private Label label11;
        private Label label4;
        private ComboBox TextureSetting_Dropdown_WrapT;
        private Label label12;
        private Button TextureSetting_Button_AddTextureToMaterial;
        private Button button1;
    }
}