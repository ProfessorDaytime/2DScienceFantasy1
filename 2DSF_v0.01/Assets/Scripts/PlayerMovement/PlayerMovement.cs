using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 position = new Vector3(0,0,0);


    // Start is called before the first frame update
    void Start(){
      transform.position = position;
    }

    // Update is called once per frame
    void Update(){

        if(Input.GetKey("w")){
          position = position + new Vector3(0,0.01f,0);
          transform.position = position;
          Debug.Log("Pressing W Key");
        }
        if(Input.GetKey("a")){
          position = position + new Vector3(-0.01f,0,0);
          transform.position = position;
          Debug.Log("Pressing A Key");
        }
        if(Input.GetKey("s")){
          position = position + new Vector3(0,-0.01f,0);
          transform.position = position;
          Debug.Log("Pressing S Key");
        }
        if(Input.GetKey("d")){
          position = position + new Vector3(0.01f,0,0);
          transform.position = position;
          Debug.Log("Pressing D Key");
        }

        if(Input.GetButtonDown("Fire1")){
          Debug.Log("Pressing Fire1 Key");
        }

        if(Input.GetMouseButton(0)){//Left Mouse Button = 0 Right = 1
          Debug.Log("Pressing Mouse Key");
        }
    }
}
