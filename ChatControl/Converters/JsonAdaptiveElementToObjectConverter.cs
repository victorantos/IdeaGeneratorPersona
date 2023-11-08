using IdeaGeneratorPersona.ChatControl.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace IdeaGeneratorPersona.ChatControl.Converters;
 
public class JsonAdaptiveElementToObjectConverter : Newtonsoft.Json.JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return objectType == typeof(AdaptiveElement);
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
    {
        JObject jsonObject = JObject.Load(reader);
        string adaptiveElementType = jsonObject["type"].Value<string>();
        if (adaptiveElementType == "TextBlock")
        {
            return jsonObject.ToObject<AdaptiveTextBlock>(serializer);
        }
        else if (adaptiveElementType == "Image")
        {
            return jsonObject.ToObject<AdaptiveImage>(serializer);
        }

        return jsonObject.ToObject<AdaptiveColumnSet>(serializer);
    }
  
    public override void WriteJson(JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }
 
}

