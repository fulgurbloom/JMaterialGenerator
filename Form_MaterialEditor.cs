namespace ZeldaMaterialGenerator
{
    using static ZMGData;
    using static TextureData;

    public partial class Form_MaterialEditor : Form
    {
        public string[] loadedMaterialPresets = Array.Empty<string>();
        public Material[] loadedMaterials = Array.Empty<Material>();

        public Form_MaterialEditor()
        {
            InitializeComponent();

            loadedMaterialPresets = MaterialLoader.LoadMaterialPresets();

            // Setup game dropdown
            ZMGSetting_Game.Items.Clear();

            List<Game> games = Enum.GetValues(typeof(Game)).Cast<Game>().ToList();

            foreach (Game game in games)
            {
                ZMGSetting_Game.Items.Add(game);
            }

            ZMGSetting_Game.SelectedItem = games[0];

            // Setup presets dropdown
            MaterialSetting_Dropdown_Preset.Items.Clear();

            foreach (string preset in loadedMaterialPresets)
            {
                MaterialSetting_Dropdown_Preset.Items.Add(preset);
            }

            MaterialSetting_Dropdown_Preset.Enabled = false;

            // Setup texture settings
            #region Dropdowns
            // Format
            TextureSetting_Dropdown_Format.Items.Clear();

            List<Format> formats = Enum.GetValues(typeof(Format)).Cast<Format>().ToList();

            foreach (Format format in formats)
            {
                TextureSetting_Dropdown_Format.Items.Add(format);
            }

            TextureSetting_Dropdown_Format.Enabled = false;

            // Wrap S & Wrap T
            TextureSetting_Dropdown_WrapS.Items.Clear();
            TextureSetting_Dropdown_WrapT.Items.Clear();

            List<WrapMode> wrapModes = Enum.GetValues(typeof(WrapMode)).Cast<WrapMode>().ToList();

            foreach (WrapMode wrapMode in wrapModes)
            {
                TextureSetting_Dropdown_WrapS.Items.Add(wrapMode);
                TextureSetting_Dropdown_WrapT.Items.Add(wrapMode);
            }

            TextureSetting_Dropdown_WrapS.Enabled = false;
            TextureSetting_Dropdown_WrapT.Enabled = false;

            // Palette Format
            List<PaletteFormat> paletteFormats = Enum.GetValues(typeof(PaletteFormat)).Cast<PaletteFormat>().ToList();

            foreach (PaletteFormat paletteFormat in paletteFormats)
            {
                TextureSetting_Dropdown_PaletteFormat.Items.Add(paletteFormat);
            }

            TextureSetting_Dropdown_PaletteFormat.Enabled = false;

            // Min Filter & Mag Filter
            List<FilterMode> filterModes = Enum.GetValues(typeof(FilterMode)).Cast<FilterMode>().ToList();

            foreach (FilterMode filterMode in filterModes)
            {
                TextureSetting_Dropdown_MinFilter.Items.Add(filterMode);
                TextureSetting_Dropdown_MagFilter.Items.Add(filterMode);
            }

            TextureSetting_Dropdown_MinFilter.Enabled = false;
            TextureSetting_Dropdown_MagFilter.Enabled = false;
            #endregion

            #region Numeric UpDowns (int)
            // Alpha Setting
            TextureSetting_NumericUpDown_AlphaSetting.DecimalPlaces = 2;
            TextureSetting_NumericUpDown_AlphaSetting.Enabled = false;

            // MipMap
            TextureSetting_NumericUpDown_MipMap.Enabled = false;

            // Max Aniso
            TextureSetting_NumericUpDown_MaxAniso.DecimalPlaces = 2;
            TextureSetting_NumericUpDown_MaxAniso.Enabled = false;

            // TWW - Unknowns
            TextureSetting_TWW_NumericUpDown_unknown2.Enabled = false;
            TextureSetting_TWW_NumericUpDown_unknown3.Enabled = false;
            #endregion

            #region Numeric UpDowns (float)
            // Min LOD
            TextureSetting_NumericUpDown_MinLOD.DecimalPlaces = 2;
            TextureSetting_NumericUpDown_MinLOD.Enabled = false;

            // Max LOD
            TextureSetting_NumericUpDown_MaxLOD.DecimalPlaces = 2;
            TextureSetting_NumericUpDown_MaxLOD.Enabled = false;

            // LOD Bias
            TextureSetting_NumericUpDown_LodBias.DecimalPlaces = 2;
            TextureSetting_NumericUpDown_LodBias.Enabled = false;
            #endregion

            #region Toggles
            // Edge LOD
            TextureSetting_Toggle_EdgeLOD.Enabled = false;

            // Bias Clamp
            TextureSetting_Toggle_BiasClamp.Enabled = false;
            #endregion
        }

        private void Button_LoadModel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new();
            ofd.Filter = "dae files (*.dae)|*.dae";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (MaterialListBox.Items.Count > 0)
                {
                    DialogResult result = MessageBox.Show(
                        "Material list is not empty. A model is already loaded. " +
                        "Loading a new model will overwrite the current material list, " +
                        "are you sure you want to do this?",
                        "WARNING", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        LoadMaterials(ofd.FileName);
                    }
                }
                else
                {
                    LoadMaterials(ofd.FileName);
                }
            }
        }

        private void Button_CreateHeaders_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new();
            sfd.Filter = "txt files (*.txt)|*.txt";
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void LoadMaterials(string filename)
        {
            MaterialListBox.Items.Clear();
            loadedMaterials = MaterialLoader.LoadMaterialsFromCollada(filename);

            if (loadedMaterials.Length > 0)
            {
                for (int i = 0; i < loadedMaterials.Length; i++)
                {
                    MaterialListBox.Items.Add(loadedMaterials[i].materialName);
                }

                // Setup UI
                string modelName = Path.GetFileName(filename);
                LoadedModelLabel.Text = modelName;

                MaterialSetting_Dropdown_Preset.Enabled = true;

                TextureSetting_Dropdown_Format.Enabled = true;
                TextureSetting_NumericUpDown_AlphaSetting.Enabled = true;
                TextureSetting_Dropdown_WrapS.Enabled = true;
                TextureSetting_Dropdown_WrapT.Enabled = true;
                TextureSetting_Dropdown_PaletteFormat.Enabled = true;
                TextureSetting_NumericUpDown_MipMap.Enabled = true;
                TextureSetting_Toggle_EdgeLOD.Enabled = true;
                TextureSetting_Toggle_BiasClamp.Enabled = true;
                TextureSetting_NumericUpDown_MaxAniso.Enabled = true;
                TextureSetting_Dropdown_MinFilter.Enabled = true;
                TextureSetting_Dropdown_MagFilter.Enabled = true;
                TextureSetting_NumericUpDown_MinLOD.Enabled = true;
                TextureSetting_NumericUpDown_MaxLOD.Enabled = true;
                TextureSetting_NumericUpDown_LodBias.Enabled = true;

                if (ZMGSetting_Game.SelectedIndex == (int)Game.TWW)
                {
                    TextureSetting_TWW_NumericUpDown_unknown2.Enabled = true;
                    TextureSetting_TWW_NumericUpDown_unknown3.Enabled = true;
                }

                MaterialListBox.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Loaded model has no materials.");
            }
        }

        private void MaterialListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MaterialListBox.SelectedIndex != -1)
            {
                SelectedTextureLabel.Text = loadedMaterials[MaterialListBox.SelectedIndex].texture.Name;

                // Update material settings
                MaterialSetting_Dropdown_Preset.SelectedIndex = loadedMaterials[MaterialListBox.SelectedIndex].materialPreset;

                // Update texture settings
                TextureSetting_Dropdown_Format.SelectedIndex = (int)loadedMaterials[MaterialListBox.SelectedIndex].texture.Format;
                TextureSetting_NumericUpDown_AlphaSetting.Value = loadedMaterials[MaterialListBox.SelectedIndex].texture.AlphaSetting;
                TextureSetting_Dropdown_WrapS.SelectedIndex = (int)loadedMaterials[MaterialListBox.SelectedIndex].texture.WrapS;
                TextureSetting_Dropdown_WrapT.SelectedIndex = (int)loadedMaterials[MaterialListBox.SelectedIndex].texture.WrapT;
                TextureSetting_Dropdown_PaletteFormat.SelectedIndex = (int)loadedMaterials[MaterialListBox.SelectedIndex].texture.PaletteFormat;
                TextureSetting_NumericUpDown_MipMap.Value = loadedMaterials[MaterialListBox.SelectedIndex].texture.MipMap;
                TextureSetting_Toggle_EdgeLOD.Checked = loadedMaterials[MaterialListBox.SelectedIndex].texture.EdgeLOD;
                TextureSetting_Toggle_BiasClamp.Checked = loadedMaterials[MaterialListBox.SelectedIndex].texture.BiasClamp;
                TextureSetting_NumericUpDown_MaxAniso.Value = loadedMaterials[MaterialListBox.SelectedIndex].texture.MaxAniso;
                TextureSetting_Dropdown_MinFilter.SelectedIndex = (int)loadedMaterials[MaterialListBox.SelectedIndex].texture.MinFilter;
                TextureSetting_Dropdown_MagFilter.SelectedIndex = (int)loadedMaterials[MaterialListBox.SelectedIndex].texture.MagFilter;
                TextureSetting_NumericUpDown_MinLOD.Value = (int)loadedMaterials[MaterialListBox.SelectedIndex].texture.MinLOD; // TODO: figure out how to force-assign float
                TextureSetting_NumericUpDown_MaxLOD.Value = (int)loadedMaterials[MaterialListBox.SelectedIndex].texture.MaxLOD; // TODO: figure out how to force-assign float
                TextureSetting_NumericUpDown_LodBias.Value = (int)loadedMaterials[MaterialListBox.SelectedIndex].texture.LodBias; // TODO: figure out how to force-assign float
            }
        }

        #region Texture settings
        private void TextureSetting_Dropdown_Format_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadedMaterials[MaterialListBox.SelectedIndex].texture.Format = (Format)TextureSetting_Dropdown_Format.SelectedIndex;
        }

        private void TextureSetting_NumericUpDown_AlphaSetting_ValueChanged(object sender, EventArgs e)
        {
            loadedMaterials[MaterialListBox.SelectedIndex].texture.AlphaSetting = (int)TextureSetting_NumericUpDown_AlphaSetting.Value;
        }

        private void TextureSetting_Dropdown_WrapS_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadedMaterials[MaterialListBox.SelectedIndex].texture.WrapS = (WrapMode)TextureSetting_Dropdown_WrapS.SelectedIndex;
        }

        private void TextureSetting_Dropdown_WrapT_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadedMaterials[MaterialListBox.SelectedIndex].texture.WrapT = (WrapMode)TextureSetting_Dropdown_WrapT.SelectedIndex;
        }

        private void TextureSetting_Dropdown_PaletteFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadedMaterials[MaterialListBox.SelectedIndex].texture.PaletteFormat = (PaletteFormat)TextureSetting_Dropdown_PaletteFormat.SelectedIndex;
        }

        private void TextureSetting_NumericUpDown_MipMap_ValueChanged(object sender, EventArgs e)
        {
            loadedMaterials[MaterialListBox.SelectedIndex].texture.MipMap = (int)TextureSetting_NumericUpDown_MipMap.Value;
        }

        private void TextureSetting_Toggle_EdgeLOD_CheckedChanged(object sender, EventArgs e)
        {
            loadedMaterials[MaterialListBox.SelectedIndex].texture.EdgeLOD = TextureSetting_Toggle_EdgeLOD.Checked;
        }

        private void TextureSetting_Toggle_BiasClamp_CheckedChanged(object sender, EventArgs e)
        {
            loadedMaterials[MaterialListBox.SelectedIndex].texture.BiasClamp = TextureSetting_Toggle_BiasClamp.Checked;
        }

        private void TextureSetting_NumericUpDown_MaxAniso_ValueChanged(object sender, EventArgs e)
        {
            loadedMaterials[MaterialListBox.SelectedIndex].texture.MaxAniso = (int)TextureSetting_NumericUpDown_MaxAniso.Value;
        }

        private void TextureSetting_Dropdown_MinFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadedMaterials[MaterialListBox.SelectedIndex].texture.MinFilter = (FilterMode)TextureSetting_Dropdown_MinFilter.SelectedIndex;
        }

        private void TextureSetting_Dropdown_MagFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadedMaterials[MaterialListBox.SelectedIndex].texture.MagFilter = (FilterMode)TextureSetting_Dropdown_MagFilter.SelectedIndex;
        }

        private void TextureSetting_NumericUpDown_MinLOD_ValueChanged(object sender, EventArgs e)
        {
            // TODO: figure out how to force-assign float
            loadedMaterials[MaterialListBox.SelectedIndex].texture.MinLOD = (int)TextureSetting_NumericUpDown_MinLOD.Value;
        }

        private void TextureSetting_NumericUpDown_MaxLOD_ValueChanged(object sender, EventArgs e)
        {
            // TODO: figure out how to force-assign float
            loadedMaterials[MaterialListBox.SelectedIndex].texture.MaxLOD = (int)TextureSetting_NumericUpDown_MaxLOD.Value;
        }

        private void TextureSetting_NumericUpDown_LodBias_ValueChanged(object sender, EventArgs e)
        {
            // TODO: figure out how to force-assign float
            loadedMaterials[MaterialListBox.SelectedIndex].texture.LodBias = (int)TextureSetting_NumericUpDown_LodBias.Value;
        }
        #endregion

        private void ZMGSetting_Game_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loadedMaterials.Length > 0)
            {
                switch (ZMGSetting_Game.SelectedIndex)
                {
                    case 0:
                        TextureSetting_TWW_NumericUpDown_unknown2.Enabled = true;
                        TextureSetting_TWW_NumericUpDown_unknown3.Enabled = true;
                        break;

                    case 1:
                        TextureSetting_TWW_NumericUpDown_unknown2.Enabled = false;
                        TextureSetting_TWW_NumericUpDown_unknown3.Enabled = false;
                        break;
                }
            }
        }

        private void MaterialSetting_Dropdown_Preset_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update material settings
            loadedMaterials[MaterialListBox.SelectedIndex].materialPreset = MaterialSetting_Dropdown_Preset.SelectedIndex;
        }
    }
}
