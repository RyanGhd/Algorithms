using Newtonsoft.Json;

namespace Algorithms.UnitTests;

public class TestDataHelper
{
    public T Deserialize<T>(string input)
    {
        var data = JsonConvert.DeserializeObject<T>(input);

        return data;
    }

    public string Serialize(object data)
    {
        return JsonConvert.SerializeObject(data);
    }
}