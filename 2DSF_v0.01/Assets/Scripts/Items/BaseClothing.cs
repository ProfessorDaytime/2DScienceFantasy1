using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseClothing : BaseItemStat{ //BaseClothing <- BaseItemStat <-BaseItem

  public enum ClothingTypes{
    HAT,
    UNDERSHIRT,
    OVERSHIRT,
    PANTS,
    SOCKS,
    SHOES,
    BAG
  }

  private ClothingTypes clothingType;
  private string quality;
  private int effectID;

  public ClothingTypes ClothingType{
    get{return clothingType;}
    set{clothingType = value;}
  }

  public int EffectID{
    get{return effectID;}
    set{effectID = value;}
  }

  public string Quality{
    get{return quality;}
    set{quality = value;}
  }
}
