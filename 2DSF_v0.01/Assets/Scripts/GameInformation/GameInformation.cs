using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInformation : MonoBehaviour{

    void Awake(){
      DontDestroyOnLoad(transform.gameObject);
    }

    public static BaseClothing ClothingOne{get;set;}
    public static string PlayerName{get;set;}
    public static int PlayerLevel{get;set;}
    public static BaseCharacterClass PlayerClass{get;set;}
    public static int Hitpoints{get;set;}
    public static int Strength{get;set;}
    public static int Dexterity{get;set;}
    public static int Diplomacy{get;set;}
    public static int Majik{get;set;}
}
