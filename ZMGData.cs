namespace ZeldaMaterialGenerator
{
    using static TextureData;

    public class ZMGData
    {
        public enum Game { TWW, TP }

        /// <summary>
        /// 
        /// </summary>
        public struct Material
        {
            public string materialName;
            public int materialPreset;
            public Texture texture;

            // Constructor
            public Material(string materialName, int materialPreset, Texture texture)
            {
                this.materialName = materialName;
                this.materialPreset = materialPreset;
                this.texture = texture;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public struct Texture
        {
            // Texture header settings
            public string Name;
            public Format Format;
            public int AlphaSetting;
            public WrapMode WrapS;
            public WrapMode WrapT;
            public PaletteFormat PaletteFormat;
            public int MipMap;
            public bool EdgeLOD;
            public bool BiasClamp;
            public int MaxAniso;
            public FilterMode MinFilter;
            public FilterMode MagFilter;
            public float MinLOD;
            public float MaxLOD;
            public float LodBias;

            // Constructor
            public Texture(string Name, Format Format, int AlphaSetting, WrapMode WrapS, WrapMode WrapT,
                PaletteFormat PaletteFormat, int MipMap, bool EdgeLOD, bool BiasClamp, int MaxAniso,
                FilterMode MinFilter, FilterMode MagFilter, float MinLOD, float MaxLOD, float LodBias)
            {
                this.Name = Name;
                this.Format = Format;
                this.AlphaSetting = AlphaSetting;
                this.WrapS = WrapS;
                this.WrapT = WrapT;
                this.PaletteFormat = PaletteFormat;
                this.MipMap = MipMap;
                this.EdgeLOD = EdgeLOD;
                this.BiasClamp = BiasClamp;
                this.MaxAniso = MaxAniso;
                this.MinFilter = MinFilter;
                this.MagFilter = MagFilter;
                this.MinLOD = MinLOD;
                this.MaxLOD = MaxLOD;
                this.LodBias = LodBias;
            }
        }
    }

    /*public class Utils
    {
        public static string RemoveExtensionFromString(string str)
        {
            return str.Substring(0, str.Length - 4);
        }
    }*/
}
