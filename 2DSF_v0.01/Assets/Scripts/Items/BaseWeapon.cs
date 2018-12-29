using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseWeapon : BaseItemStat{ //BaseWeapon <- BaseItemStat <-BaseItem

    public enum WeaponTypes{
      INSTRUMENT,
      RANGED,
      MELEE
    }

    public enum DamageTypes{
      POISON,//Lingering Effect
      BLUNT,//One Hit Damage
      PIERCING,//One Hit Damage -- Maybe a little more if removed
      CUT //Hit, then slow drain of blood
    }




    private WeaponTypes weaponType;
    private DamageTypes damageType;
    private float initialDamage {get;set;}



    public WeaponTypes WeaponType{
      get{return weaponType;}
      set{weaponType = value;}
    }

    public DamageTypes DamageType{
      get{return damageType;}
      set{damageType = value;}
    }





}
