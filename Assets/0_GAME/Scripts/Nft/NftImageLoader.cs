using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using Newtonsoft.Json;

public class NftImageLoader : MonoBehaviour
{
    private enum ApiType { OpenSea, Alchemy }
    [SerializeField] private ApiType apiType;

    private ChainType chainApi;
    [SerializeField] private RawImage img;

    [SerializeField] private string tokenAddress;
    [SerializeField] private string tokenID;

    void Start()
    {
        switch (apiType)
        {
            case ApiType.OpenSea:
                chainApi = new OpenSeaApi();
                break;

            case ApiType.Alchemy:
                chainApi = new AlchemyApi();
                break;
        }

        chainApi.GetNftImageUrl(tokenAddress, tokenID);
        StartCoroutine(DownloadImage(chainApi.imageUrl));
    }
    IEnumerator DownloadImage(string url)
    {
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);

        yield return www.SendWebRequest();

        Texture texture = DownloadHandlerTexture.GetContent(www);
        img.texture = texture;
    }
}
