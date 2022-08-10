using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attribute
{
    public string value;
    public string trait_type;
}

public class Contract
{
    public string address;
}

public class Id
{
    public string tokenId;
    public TokenMetadata tokenMetadata;
}

public class Medium
{
    public string raw;
    public string gateway;
    public string thumbnail;
    public string format;
    public int bytes;
}

public class Metadata
{
    public string name;
    public string description;
    public string image;
    public List<Attribute> attributes;
}

public class Alchemy
{
    public Contract contract;
    public Id id;
    public string title;
    public string description;
    public TokenUri tokenUri;
    public List<Medium> media;
    public Metadata metadata;
    public DateTime timeLastUpdated;
}

public class TokenMetadata
{
    public string tokenType;
}

public class TokenUri
{
    public string raw;
    public string gateway;
}

