using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewClothing : MonoBehaviour
{

    private BaseClothing newClothing;
    private string[] qualities = new string[4]{"Common", "Great", "Amazing", "Dank"};

    void Start(){
      CreateClothing();
      Debug.Log(newClothing.ItemName);
      Debug.Log(newClothing.Quality);
      Debug.Log(newClothing.ItemDescription);
      Debug.Log(newClothing.ClothingType.ToString());
      Debug.Log("Strength Req " + newClothing.StrengthReq.ToString());
      Debug.Log("Dexterity Req " + newClothing.DexterityReq.ToString());
      Debug.Log("Majik Req " + newClothing.MajikReq.ToString());
      Debug.Log("Strength Buff " + newClothing.Strength.ToString());
      Debug.Log("Dexterity Buff " + newClothing.Dexterity.ToString());
      Debug.Log("Majik Buff " + newClothing.Majik.ToString());
      Debug.Log("Hitpoints Buff " + newClothing.Hitpoints.ToString());
      Debug.Log("Diplomacy Buff " + newClothing.Diplomacy.ToString());
    }

    private void CreateClothing(){
      newClothing = new BaseClothing();
      int num = Random.Range(1,101);

      //assign name to the weapon
      newClothing.ItemName = "C" + num;

      //create a weapon description
      newClothing.ItemDescription = "This is a new Clothing Item.";
      newClothing.Quality = qualities[Random.Range(0,4)];
      newClothing.ItemID = Random.Range(1,101);
      ChooseClothingType();

      //stats
      newClothing.StrengthReq = Random.Range(0,16);//Make higher later in game
      newClothing.DexterityReq = Random.Range(0,16);//Make higher later in game
      newClothing.MajikReq = Random.Range(0,16);//Make higher later in game
      newClothing.Strength = Random.Range(-3,5);//Make higher later in game
      newClothing.Dexterity = Random.Range(-3,5);//Make higher later in game
      newClothing.Majik = Random.Range(-3,5);//Make higher later in game
      newClothing.Hitpoints = Random.Range(0,4);
      newClothing.Diplomacy = Random.Range(-3,5);
    }

    private void ChooseClothingType(){
      int num = Random.Range(0,7);

      if(num == 0){
        newClothing.ClothingType = BaseClothing.ClothingTypes.HAT;
      }
      else if(num == 1){
        newClothing.ClothingType = BaseClothing.ClothingTypes.UNDERSHIRT;
      }
      else if(num == 2){
        newClothing.ClothingType = BaseClothing.ClothingTypes.OVERSHIRT;
      }
      else if(num == 3){
        newClothing.ClothingType = BaseClothing.ClothingTypes.PANTS;
      }
      else if(num == 4){
        newClothing.ClothingType = BaseClothing.ClothingTypes.SOCKS;
      }
      else if(num == 5){
        newClothing.ClothingType = BaseClothing.ClothingTypes.SHOES;
      }
      else if(num == 6){
        newClothing.ClothingType = BaseClothing.ClothingTypes.BAG;
      }
    }


}
