using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInformation{


    public static void LoadAllInformation(){
      GameInformation.PlayerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");
      GameInformation.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
      GameInformation.Hitpoints = PlayerPrefs.GetInt("HITPOINTS");
      GameInformation.Strength = PlayerPrefs.GetInt("STRENGTH");
      GameInformation.Dexterity = PlayerPrefs.GetInt("DEXTERITY");
      GameInformation.Diplomacy = PlayerPrefs.GetInt("DIPLOMACY");
      GameInformation.Majik = PlayerPrefs.GetInt("MAJIK");

      if(PlayerPrefs.GetString("ClothingOne") != null){
        GameInformation.ClothingOne = (BaseClothing)PPSerialization.Load("ClothingOne");
      }
    }
}
