using System;
using System.Collections.Generic;
using System.Xml;
using static ZeldaMaterialGenerator.Data;

namespace ZeldaMaterialGenerator
{
    internal class MaterialLoader
    {
        public static List<Material> LoadMaterialsFromCollada(XmlDocument collada)
        {
            // Create material list
            XmlNodeList materialNodes = collada.GetElementsByTagName("effect");
            List<Material> materials = new List<Material>();

            int materialIndex = 0;
            foreach (XmlNode node in materialNodes)
            {
                // Get material & texture names from nodes
                string materialName = node.Attributes[0].InnerText; // matname-effect
                string textureName = node["profile_COMMON"].FirstChild.InnerText; //texname_format

                // Remove name suffixes
                materialName = materialName.Substring(0, materialName.Length - 7); // -effect
                textureName = textureName.Substring(0, textureName.Length - 4); // example: _png

                // Create texture
                Texture texture = new Texture(textureName, false);

                materials.Add(new Material(materialName, texture));
                materialIndex++;
            }

            return materials;
        }

        public static List<string> LoadTexturesFromCollada(XmlDocument collada)
        {
            // Create secondary texture list
            XmlNodeList textureNodes = collada.GetElementsByTagName("image");
            //string[] textures = new string[textureNodes.Count];
            List<string> textures = new List<string>();

            int textureIndex = 0;
            foreach (XmlNode node in textureNodes)
            {
                // Get secondary texture name
                string unlinkedTextureName = node.Attributes[0].InnerText;

                // Remove name suffixes
                unlinkedTextureName = unlinkedTextureName.Substring(0, unlinkedTextureName.Length - 4); // example: _png

                //textures[textureIndex] = secondaryTextureName;
                textures.Add(unlinkedTextureName);
                textureIndex++;
            }

            return textures;
        }
    }
}
