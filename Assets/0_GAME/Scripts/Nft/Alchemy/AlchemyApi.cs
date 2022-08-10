using System.Net;
using System.IO;
using Newtonsoft.Json;

public class AlchemyApi : ChainType
{
    public override void GetNftImageUrl(string tokenAddress, string tokenID)
    {
        string url = "https://eth-mainnet.g.alchemy.com/nft/v2/demo/getNFTMetadata" + "?contractAddress=" + tokenAddress + "&tokenId=" + tokenID;

        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        request.Accept = "application/json";

        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();
        Alchemy info = JsonConvert.DeserializeObject<Alchemy>(json, new KeysJsonConverter(typeof(Alchemy)));

        //File.WriteAllText("D:" + " / InAppList.json", json);

        imageUrl = info.metadata.image;
    }
}
