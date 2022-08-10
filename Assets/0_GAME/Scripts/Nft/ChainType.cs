using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class ChainType
{
    public string imageUrl;

    public virtual void GetNftImageUrl(string tokenAddress, string tokenID)
    {

    }
}
