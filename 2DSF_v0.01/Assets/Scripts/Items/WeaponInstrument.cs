using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponInstrument : BaseWeapon{

  public enum InstrumentTypes{
    KEYTAR,
    EPAN,
    EWIND
  }

  private InstrumentTypes instrumentType;

  public InstrumentTypes InstrumentType{
    get{return instrumentType;}
    set{instrumentType = value;}
  }
}
