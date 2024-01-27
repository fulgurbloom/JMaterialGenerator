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
            Material[] materials = Array.Empty<Material>();

            foreach (XmlNode node in materialNodes)
            {
                // Setup texture
                Texture texture = CreateBaseTexture();
                // TODO: Find better node method, this is pathetic
                texture.Name = FixTextureNameExtension(node.FirstChild.FirstChild.FirstChild.FirstChild.InnerText);

                // Setup material
                materials.Append(new Material()
                {
                    materialName = RemoveMaterialSuffix(node.Attributes[0].InnerText),
                    materialPreset = 0,
                    texture = texture
                });
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
