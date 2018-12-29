using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRanged : BaseWeapon{

  public enum RangedTypes{
    IMPROVISED,
    BOW,
    GUN
  }

  private RangedTypes rangedType;
  
  public RangedTypes RangedType{
    get{return rangedType;}
    set{rangedType = value;}
  }
}
