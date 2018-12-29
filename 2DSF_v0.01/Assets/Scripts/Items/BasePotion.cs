using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BasePotion : BaseItem{
    public enum PotionTypes{
      BUFF,
      POISON,
      DRUG
    }//JUSTCOMEBACKTOTHISSHIT

    private PotionTypes potionType;
    private int effectID;


    public PotionTypes PotionType {
      get{return potionType;}
      set{potionType = value;}
    }

    public int EffectID{
      get{return effectID;}
      set{effectID = value;}
    }

}
