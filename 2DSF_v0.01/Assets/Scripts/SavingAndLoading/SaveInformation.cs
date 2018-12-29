using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInformation : MonoBehaviour{


    public static void SaveAllInformation(){
      PlayerPrefs.SetInt("PLAYERLEVEL",GameInformation.PlayerLevel);
      PlayerPrefs.SetString("PLAYERNAME", GameInformation.PlayerName);
      PlayerPrefs.SetInt("HITPOINTS",GameInformation.Hitpoints);
      PlayerPrefs.SetInt("STRENGTH",GameInformation.Strength);
      PlayerPrefs.SetInt("DEXTERITY",GameInformation.Dexterity);
      PlayerPrefs.SetInt("DIPLOMACY",GameInformation.Diplomacy);
      PlayerPrefs.SetInt("MAJIK",GameInformation.Majik);

      if(GameInformation.ClothingOne != null){
        PPSerialization.Save("ClothingOne", GameInformation.ClothingOne);
      }



      Debug.Log("Saved All Information that is programmed to save,  There are probably more things I could have saved tho.  ");
    }
}
