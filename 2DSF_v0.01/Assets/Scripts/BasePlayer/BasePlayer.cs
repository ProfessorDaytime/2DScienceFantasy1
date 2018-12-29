using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer{

    private string playerName;
    private int playerLevel;
    private BaseCharacterClass playerClass;
    private int hitpoints;
    private int strength;
    private int dexterity;
    private int diplomacy;
    private int majik;

    // public string PlayerName{
    //   get{return playerName;}
    //   set{playerName = value;}
    // }

    //QUICKER GETTERS AND SETTERS
    public string PlayerName{get;set;}

    public int PlayerLevel{
      get{return playerLevel;}
      set{playerLevel = value;}
    }

    public BaseCharacterClass PlayerClass{
      get{return playerClass;}
      set{playerClass = value;}
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
