using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseItem{

    private string itemName;
    private string itemDescription;
    private int itemID;
    private int strengthReq;
    private int dexterityReq;
    private int majikReq;

    public enum ItemTypes{
      CLOTHING,
      WEAPON,
      INGREDIENT,
      POTION,
      QUEST,
      JUNK
    }
    private ItemTypes itemType;

    public string ItemName{
      get{return itemName;}
      set{itemName = value;}
    }

    public string ItemDescription{
      get{return itemDescription;}
      set{itemDescription = value;}
    }

    public int ItemID{
      get{return itemID;}
      set{itemID = value;}
    }

    public ItemTypes ItemType{
      get{return itemType;}
      set{itemType = value;}
    }

    public int StrengthReq{
      get{return strengthReq;}
      set{strengthReq = value;}
    }

    public int DexterityReq{
      get{return dexterityReq;}
      set{dexterityReq = value;}
    }

    public int MajikReq{
      get{return majikReq;}
      set{majikReq = value;}
    }
}
