using System.Xml;
using static ZMGLite.Types;

namespace ZMGLite
{
    internal class ColladaReader
    {
        public static List<Material> LoadMaterialsFromCollada(XmlDocument collada)
        {
            // Create material list
            XmlNodeList materialNodes = collada.GetElementsByTagName("effect");
            List<Material> materials = new();

            int materialIndex = 0;
            foreach (XmlNode node in materialNodes)
            {
                // Get material & texture names from nodes
                string materialName = node.Attributes[0].InnerText; // matname-effect
                string textureName = node["profile_COMMON"].FirstChild.InnerText; //texname_format

                // Remove name suffixes
                materialName = materialName.Substring(0, materialName.Length - 7); // -effect
                textureName = textureName.Substring(0, textureName.Length - 4); // example: _png

                // Setup material
                materials.Add(new Material(materialName, textureName));
                materialIndex++;
            }

            return materials;
        }

        public static List<string> LoadTexturesFromCollada(XmlDocument collada)
        {
            // Create texture list
            XmlNodeList textureNodes = collada.GetElementsByTagName("image");
            List<string> textures = new();

            int textureIndex = 0;
            foreach(XmlNode node in textureNodes)
            {
                // Get texture names from nodes
                string textureName = node.Attributes[0].InnerText;

                // Remove name suffixes
                textureName = textureName.Substring(0, textureName.Length - 4); // example: _png

                // Setup texture
                textures.Add(textureName);
                textureIndex++;
            }

            return textures;
        }
    }
}
