using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TsetScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("LLLLOOOOAAADDDIINNG");
        LoadInformation.LoadAllInformation();
        Debug.Log("Player Name: " + GameInformation.PlayerName);
        // Debug.Log("Player Class: " + newPlayer.PlayerClass.CharacterClassName);
        Debug.Log("Player Level: " + GameInformation.PlayerLevel);
        Debug.Log("Player Hitpoints: " + GameInformation.Hitpoints);
        Debug.Log("Player Strength: " + GameInformation.Strength);
        Debug.Log("Player Dexterity: " + GameInformation.Dexterity);
        Debug.Log("Player Diplomacy: " + GameInformation.Diplomacy);
        Debug.Log("Player Majik: " + GameInformation.Majik);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
