using System;
using System.Xml;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using static ZeldaMaterialGenerator.Data;

namespace ZeldaMaterialGenerator
{
    public partial class MainForm : Form
    {
        #region Variables
        public XmlDocument loadedCollada;
        public List<Material> loadedMaterials;
        public List<string> loadedUnlinkedTextures;
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initialize labels
            loadedModelLabel.Text = "";

            // Initialize inspector components
            Inspector_SelectedObjectLabel.Text = "";
            Inspector_Material_MaterialPreset.Visible = false;
            Inspector_Texture_HasAlpha.Visible = false;

            // Setup material grid
            InitializeGrid();
        }

        #region Methods
        private void InitializeGrid()
        {
            // Initialize material & texture view grid
            MaterialGrid.ColumnCount = 3;
            MaterialGrid.Columns[0].Name = "Materials";
            MaterialGrid.Columns[1].Name = "Textures";
            MaterialGrid.Columns[2].Name = "Unlinked Textures";
            MaterialGrid.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            MaterialGrid.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            MaterialGrid.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void LoadMaterials(string loadPath)
        {
            loadedCollada = new XmlDocument();
            loadedCollada.Load(loadPath);

            // Clear grid
            MaterialGrid.Rows.Clear();

            // Load materials & secondary textures
            loadedMaterials = MaterialLoader.LoadMaterialsFromCollada(loadedCollada);
            loadedUnlinkedTextures = MaterialLoader.LoadTexturesFromCollada(loadedCollada);

            // Fetch textures from the material list
            List<string> materialTextureList = new List<string>();

            for (int i = 0; i < loadedMaterials.Count; i++)
            {
                materialTextureList.Add(loadedMaterials[i].texture.textureName);
            }

            // Compares textures from <library_images> to material entries to find unlinked textures
            loadedUnlinkedTextures = loadedUnlinkedTextures.Except(materialTextureList).ToList();

            // Fill grid with materials & textures
            for (int i = 0; i < loadedMaterials.Count; i++)
            {
                string[] newRow = { loadedMaterials[i].materialName, loadedMaterials[i].texture.textureName, null };
                Console.WriteLine(loadedMaterials[i].texture.textureName);

                if (i < loadedUnlinkedTextures.Count)
                {
                    newRow[2] = loadedUnlinkedTextures[i];
                }

                MaterialGrid.Rows.Add(newRow);
            }

            // Prevent node from being auto-selected
            MaterialGrid.ClearSelection();
        }

        private void SelectedMaterialCell()
        {
            // Material components
            Inspector_Material_MaterialPreset.Visible = true;

            // Texture components
            Inspector_Texture_HasAlpha.Visible = false;
        }

        private void SelectedTextureCell()
        {
            // Material components
            Inspector_Material_MaterialPreset.Visible = false;

            // Texture components
            Inspector_Texture_HasAlpha.Visible = true;
        }
        #endregion

        #region Controls
        private void OpenModelButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Collada files|*.dae",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                loadedModelLabel.Text = ofd.SafeFileName;
                LoadMaterials(ofd.FileName);
            }
        }

        private void MaterialGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the value of the clicked cell
            int row = MaterialGrid.CurrentCell.RowIndex;
            int column = MaterialGrid.CurrentCell.ColumnIndex;
            var val = MaterialGrid.Rows[row].Cells[column].Value;

            // Error if value is null, so check it first
            if (val == null)
            {
                Inspector_SelectedObjectLabel.Text = null;
                return;
            }

            Inspector_SelectedObjectLabel.Text = val.ToString();

            // Check cell type and update inspector
            switch (MaterialGrid.Columns[column].Index)
            {
                case 0: // Materials
                    SelectedMaterialCell();
                    break;

                case 1: // Textures
                case 2: // Unlinked Textures
                    SelectedTextureCell();
                    break;
            }
        }
        #endregion
    }
}
