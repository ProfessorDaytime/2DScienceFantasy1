using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass{

    private string characterClassName;
    private string characterClassDescription;

    //Stats
    private int hitpoints;
    private int strength;
    private int dexterity;
    private int diplomacy;
    private int majik;



    public string CharacterClassName{
      get{return characterClassName;}
      set{characterClassName = value;}
    }

    public string CharacterClassDescription{
      get{return characterClassDescription;}
      set{characterClassDescription = value;}
    }

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
