using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMelee : BaseWeapon{

  public enum MeleeTypes{
    IMPROVISED,
    BLADE,
    BLUNT
  }

  private MeleeTypes meleeType;

  public MeleeTypes MeleeType{
    get{return meleeType;}
    set{meleeType = value;}
  }
}
