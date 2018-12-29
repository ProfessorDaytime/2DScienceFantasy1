using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseJunk : BaseItem{
    public enum JunkTypes{
      FUNNY,
      BORING,
      VALUABLE
    }

    private JunkTypes junkType;

    public JunkTypes JunkType{
      get{return junkType;}
      set{junkType = value;}
    }

}
