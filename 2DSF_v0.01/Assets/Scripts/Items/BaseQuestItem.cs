using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseBaseQuestItem : BaseItem{
    public enum QuestItemTypes{
      ALSOJUSTCOMEBACKTOTHISSHITLATERDUDE
    }

    private QuestItemTypes questItemType;

    public  QuestItemTypes QuestItemType{
      get{return questItemType;}
      set{questItemType = value;}
    }

}
