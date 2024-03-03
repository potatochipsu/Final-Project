using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MulaiButton : MonoBehaviour
{
    public void StartButton(){
        if(this.gameObject.tag == "Start"){
            Debug.Log("Button Pressed");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
