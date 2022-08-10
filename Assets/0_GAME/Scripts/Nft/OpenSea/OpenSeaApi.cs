using System.Net;
using System.IO;
using Newtonsoft.Json;

public class OpenSeaApi : ChainType
{
    public override void GetNftImageUrl(string tokenAddress, string tokenID)
    {
        string url = "https://api.opensea.io/api/v1/asset" + "/" + tokenAddress + "/" + tokenID;

        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        request.Headers.Add("X-API-KEY", "  ");

        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();
        OpenSea info = JsonConvert.DeserializeObject<OpenSea>(json, new KeysJsonConverter(typeof(OpenSea)));

        //File.WriteAllText("D:" + " / InAppList.json", json);

        imageUrl = info.image_url;
    }
}
