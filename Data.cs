namespace ZeldaMaterialGenerator
{
    public class Data
    {
        public struct Material
        {
            public string materialName;
            public Texture texture;

            // Material settings


            // Constructor
            public Material(string materialName, Texture texture)
            {
                this.materialName = materialName;
                this.texture = texture;
            }
        }

        public struct Texture
        {
            public string textureName;

            // Texture settings
            public bool hasAlpha;

            // Constructor
            public Texture(string textureName, bool hasAlpha)
            {
                this.textureName = textureName;
                this.hasAlpha = hasAlpha;
            }
        }
    }
}
