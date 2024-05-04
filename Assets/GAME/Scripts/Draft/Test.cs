using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private bool isSliding = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Debug.Log("Đang chạm");
            isSliding = true;
        }    
        else if(Input.touchCount == 0 && isSliding == true)
        {
            Debug.Log("Đang thả");
            isSliding = false;
        }    
    }
}
