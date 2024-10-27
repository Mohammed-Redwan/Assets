using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       int x = 0;
       while(x <= 5) {
	       if(x != 3) {
		       Debug.Log(x);
	       }
           x++;
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
