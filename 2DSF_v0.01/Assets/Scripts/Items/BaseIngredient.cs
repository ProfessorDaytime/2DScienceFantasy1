using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseIngredient : BaseItem{

    public enum IngredientTypes{
      A, B, C, D, E, F, G
    }

    private IngredientTypes ingredientType;

    public IngredientTypes IngredientType{
      get{return ingredientType;}
      set{ingredientType = value;}
    }

}
