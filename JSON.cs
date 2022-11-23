using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using static ZMGLite.Types;

namespace ZMGLite
{
    internal class JSON
    {
        public static string WriteMaterialsToJSON(string path, List<Material> materials, List<string> unlinkedTextures)
        {
            // Setup JSON
            StringWriter writer = new();


            JsonDocument jsonDoc;

            JsonSerializerOptions jsonOptions = new JsonSerializerOptions { WriteIndented = true };
            string materialString = JsonSerializer.Serialize(materials, jsonOptions);
            string textureString = JsonSerializer.Serialize(unlinkedTextures, jsonOptions);
            //JsonWriter jWriter = new JsonTextWriter(sWriter);

            // Begin writing JSON
            /*jWriter.Formatting = Formatting.Indented;

            jWriter.WriteStartObject();
            jWriter.WritePropertyName("PropertyTest");
            jWriter.WriteValue("ValueTest");
            jWriter.WritePropertyName("PropertyTest2");
            jWriter.WriteStartArray();
            jWriter.WriteValue("ArrayTest1");
            jWriter.WriteComment("comment test");
            jWriter.WriteValue("value1?");
            jWriter.WriteValue("value2?");
            jWriter.WriteEnd();
            jWriter.WriteEndObject();

            sWriter.*/

            

            return "";
        }
    }
}
