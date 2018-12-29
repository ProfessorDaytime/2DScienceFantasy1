using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateNewCharacter : MonoBehaviour{

    private BasePlayer newPlayer;
    private bool isBard;
    private bool isStealth;
    private bool isFighter;
    private string playerName = "Enter Name";

    // Start is called before the first frame update
    void Start(){
      newPlayer = new BasePlayer();
    }

    // Update is called once per frame
    void Update(){

    }

    void OnGUI(){
      playerName = GUILayout.TextArea(playerName);
      isBard = GUILayout.Toggle(isBard, "Bard Class");
      isStealth = GUILayout.Toggle(isStealth, "Stealth Class");
      isFighter = GUILayout.Toggle(isFighter, "Fighter Class");

      if(GUILayout.Button("Create")){
        if(isBard){
          newPlayer.PlayerClass = new BaseBardClass();
        } else if(isStealth){
          newPlayer.PlayerClass = new BaseStealthClass();
        } else if(isFighter){
          newPlayer.PlayerClass = new BaseFighterClass();
        }

        newPlayer.PlayerName = playerName;
        newPlayer.PlayerLevel = 1;
        newPlayer.Hitpoints = newPlayer.PlayerClass.Hitpoints;
        newPlayer.Strength = newPlayer.PlayerClass.Strength;
        newPlayer.Dexterity = newPlayer.PlayerClass.Dexterity;
        newPlayer.Diplomacy = newPlayer.PlayerClass.Diplomacy;
        newPlayer.Majik = newPlayer.PlayerClass.Majik;

        StoreNewPlayerInfo();
        SaveInformation.SaveAllInformation();

        Debug.Log("Player Name: " + newPlayer.PlayerName);
        Debug.Log("Player Class: " + newPlayer.PlayerClass.CharacterClassName);
        Debug.Log("Player Level: " + newPlayer.PlayerLevel);
        Debug.Log("Player Hitpoints: " + newPlayer.Hitpoints);
        Debug.Log("Player Strength: " + newPlayer.Strength);
        Debug.Log("Player Dexterity: " + newPlayer.Dexterity);
        Debug.Log("Player Diplomacy: " + newPlayer.Diplomacy);
        Debug.Log("Player Majik: " + newPlayer.Majik);
      }

      if(GUILayout.Button("Load")){
        //Application.LoadLevel("tset");
        SceneManager.LoadScene("tset", LoadSceneMode.Additive);
      }

    }


    private void StoreNewPlayerInfo(){
      GameInformation.PlayerName = newPlayer.PlayerName;
      GameInformation.PlayerLevel = newPlayer.PlayerLevel;
      GameInformation.Hitpoints = newPlayer.Hitpoints;
      GameInformation.Strength = newPlayer.Strength;
      GameInformation.Dexterity = newPlayer.Dexterity;
      GameInformation.Diplomacy = newPlayer.Diplomacy;
      GameInformation.Majik = newPlayer.Majik;
    }


}
