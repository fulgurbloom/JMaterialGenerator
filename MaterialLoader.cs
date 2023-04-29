using System.Xml;

namespace JMaterialGenerator
{
    using static JMGData;
    using static TextureData;

    internal class MaterialLoader
    {
        /// <summary>
        /// Loads material preset (.mat) files from Presets folder
        /// </summary>
        /// <returns></returns>
        public static string[] LoadMaterialPresets()
        {
            return Directory.GetFiles("Presets", "*.mat");
        }

        public static Material[] LoadMaterialsFromCollada(string colladaPath)
        {
            // Setup collada XML
            XmlDocument collada = new();
            collada.Load(colladaPath);

            XmlNodeList materialNodes = collada.GetElementsByTagName("effect");
            Material[] materials = new Material[materialNodes.Count];

            for (int i = 0; i < materialNodes.Count; i++)
            {
                // Setup material
                Material material = new();
                material.materialName = RemoveMaterialSuffix(materialNodes[i].Attributes[0].InnerText);
                material.materialPreset = 0;

                // Setup texture
                Texture texture = CreateBaseTexture();
                // TODO: Find better node method, this is pathetic
                texture.Name = FixTextureNameExtension(materialNodes[i].FirstChild.FirstChild.FirstChild.FirstChild.InnerText);

                // Finish material setup
                material.materialPreset = 0;
                material.texture = texture;
                materials[i] = material;
            }

            return materials;
        }

        /// <summary>
        /// Generates texture header entry with base settings
        /// </summary>
        /// <returns></returns>
        private static Texture CreateBaseTexture()
        {
            Texture texture = new();

            texture.Name = "";
            texture.Format = Format.CMPR;
            texture.AlphaSetting = 204;
            texture.WrapS = WrapMode.Repeat;
            texture.WrapT = WrapMode.Repeat;
            texture.PaletteFormat = PaletteFormat.IA8;
            texture.MipMap = 0;
            texture.EdgeLOD = false;
            texture.BiasClamp = false;
            texture.MaxAniso = 0;
            texture.MinFilter = FilterMode.Linear;
            texture.MagFilter = FilterMode.Linear;
            texture.MinLOD = 0;
            texture.MaxLOD = 0;
            texture.LodBias = 0;

            return texture;
        }

        private static string RemoveMaterialSuffix(string materialName)
        {
            return materialName[0..^7];
        }

        private static string FixTextureNameExtension(string textureName)
        {
            int pos = textureName.LastIndexOf("_");
            return textureName.Remove(pos, 1).Insert(pos, ".");
        }
    }
}
