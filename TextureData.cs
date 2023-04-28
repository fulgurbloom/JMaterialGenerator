namespace ZeldaMaterialGenerator
{
    /// <summary>
    /// Thank you SuperBMD
    /// </summary>
    public class TextureData
    {
        public enum Format
        {
                     //Bits per Pixel | Block Width | Block Height | Block Size | Type / Description
            I4,      //  4 | 8 | 8 | 32 | grey
            I8,      //  8 | 8 | 8 | 32 | grey
            IA4,     //  8 | 8 | 4 | 32 | grey + alpha
            IA8,     // 16 | 4 | 4 | 32 | grey + alpha
            RGB565,  // 16 | 4 | 4 | 32 | color
            RGB5A3,  // 16 | 4 | 4 | 32 | color + alpha
            RGBA32,  // 32 | 4 | 4 | 64 | color + alpha
            C4,      //  4 | 8 | 8 | 32 | palette choices (IA8, RGB565, RGB5A3)
            C8,      //  8 | 8 | 4 | 32 | palette choices (IA8, RGB565, RGB5A3)
            C14X2,   // 16 | 4 | 4 | 32 | palette (IA8, RGB565, RGB5A3) NOTE: only 14 bits are used per pixel
            CMPR,    //  4 | 8 | 8 | 32 | mini palettes in each block, RGB565 or transparent.
        }

        public enum WrapMode
        {
            ClampToEdge,
            Repeat,
            MirroredRepeat,
        }

        public enum PaletteFormat
        {
            IA8,
            RGB565,
            RGB5A3,
        }

        public enum FilterMode
        {
            /* Valid in both Min and Mag Filter */
            Nearest,                  // Point Sampling, No Mipmap
            Linear,                   // Bilinear Filtering, No Mipmap

            /* Valid in only Min Filter */
            NearestMipmapNearest,     // Point Sampling, Discrete Mipmap
            NearestMipmapLinear,      // Bilinear Filtering, Discrete Mipmap
            LinearMipmapNearest,      // Point Sampling, Linear MipMap
            LinearMipmapLinear,       // Trilinear Filtering
        }
    }
}
