using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGUI : MonoBehaviour
{
  private BaseCharacterClass class1 = new BaseBardClass();
  private BaseCharacterClass class2 = new BaseStealthClass();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI(){
      GUILayout.Label(class1.CharacterClassName);
      GUILayout.Label(class1.CharacterClassDescription);

      GUILayout.Label(class2.CharacterClassName);
      GUILayout.Label(class2.CharacterClassDescription);
    }
}
