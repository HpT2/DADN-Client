using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemConfig : ScriptableObject
{
    public enum Type
    {
        Common,
        Rare,
        Mythic,
        Legend,
    }
    public GameObject itemPrefab;
    public Type type;
}
