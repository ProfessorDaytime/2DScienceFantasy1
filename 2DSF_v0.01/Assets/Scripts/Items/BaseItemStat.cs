using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseItemStat : BaseItem{

  private int hitpoints;
  private int strength;
  private int dexterity;
  private int diplomacy;
  private int majik;


  public int Hitpoints{
    get{return hitpoints;}
    set{hitpoints = value;}
  }

  public int Strength{
    get{return strength;}
    set{strength = value;}
  }

  public int Dexterity{
    get{return dexterity;}
    set{dexterity = value;}
  }

  public int Diplomacy{
    get{return diplomacy;}
    set{diplomacy = value;}
  }

  public int Majik{
    get{return majik;}
    set{majik = value;}
  }
}
