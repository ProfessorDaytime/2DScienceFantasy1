using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseFighterClass : BaseCharacterClass{

  public BaseFighterClass(){
    CharacterClassName = "Fighter";
    CharacterClassDescription = "Brute Strength";
    Hitpoints = 12;
    Strength = 14;
    Dexterity = 11;
    Diplomacy = 8;
    Majik = 6;
  }
}
