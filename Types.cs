namespace ZMGLite
{
    internal class Types
    {
        public struct Material
        {
            public string materialName;
            public string textureName;

            // Constructor
            public Material(string materialName, string textureName)
            {
                this.materialName = materialName;
                this.textureName = textureName;
            }
        }
    }
}
