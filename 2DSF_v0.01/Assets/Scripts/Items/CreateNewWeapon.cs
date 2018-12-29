using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewWeapon : MonoBehaviour{

    private BaseWeapon newWeapon;

    void Start(){
      CreateWeapon();
      Debug.Log(newWeapon.ItemName);
      Debug.Log(newWeapon.ItemDescription);
      Debug.Log(newWeapon.WeaponType.ToString());
      Debug.Log(newWeapon.StrengthReq.ToString());
      Debug.Log(newWeapon.DexterityReq.ToString());
      Debug.Log(newWeapon.MajikReq.ToString());
    }

    public void CreateWeapon(){

      //choose type of weapon
      ChooseWeaponType();

      int num = Random.Range(1,101);

      //assign name to the weapon
      newWeapon.ItemName = "W" + num;

      //create a weapon description
      newWeapon.ItemDescription = "This is a new Weapon.";

      //weapon id
      newWeapon.ItemID = num;

      //stats
      newWeapon.StrengthReq = Random.Range(0,16);//Make higher later in game
      newWeapon.DexterityReq = Random.Range(0,16);//Make higher later in game
      newWeapon.MajikReq = Random.Range(0,16);//Make higher later in game


      //Effect ID
      //-------------Do Later---------------

    }

    private void ChooseWeaponType(){
      int randWeaponType = Random.Range(1,4);
      int randWeapon = Random.Range(1,4);

      if(randWeaponType == 1){
        newWeapon = new WeaponInstrument();
        newWeapon.WeaponType = BaseWeapon.WeaponTypes.INSTRUMENT;

        if(randWeapon == 1){
          newWeapon.InstrumentType = WeaponInstrument.InstrumentTypes.KEYTAR;
        }
        else if(randWeapon == 2){
          newWeapon.InstrumentType = WeaponInstrument.InstrumentTypes.EPAN;
        }
        else if(randWeapon == 3){
          newWeapon.InstrumentType = WeaponInstrument.InstrumentTypes.EWIND;
        }

      }
      else if(randWeaponType == 2){
        newWeapon = new WeaponRanged();
        newWeapon.WeaponType = BaseWeapon.WeaponTypes.RANGED;

        if(randWeapon == 1){
          newWeapon.RangedType = WeaponRanged.RangedTypes.IMPROVISED;
        }
        else if(randWeapon == 2){
          newWeapon.RangedType = WeaponRanged.RangedTypes.BOW;
        }
        else if(randWeapon == 3){
          newWeapon.RangedType = WeaponRanged.RangedTypes.GUN;
        }

      }
      else if(randWeaponType == 3){
        newWeapon = new WeaponMelee();
        newWeapon.WeaponType = BaseWeapon.WeaponTypes.MELEE;

        if(randWeapon == 1){
          newWeapon.MeleeType = WeaponMelee.MeleeTypes.IMPROVISED;
        }
        else if(randWeapon == 2){
          newWeapon.MeleeType = WeaponMelee.MeleeTypes.BLADE;
        }
        else if(randWeapon == 3){
          newWeapon.MeleeType = WeaponMelee.MeleeTypes.BLUNT;
        }

      }
    }


}
