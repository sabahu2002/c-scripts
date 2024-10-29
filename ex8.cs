using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class ex8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int random=1;
        while (true)
        {
            random= Random.Range(1,20);
            if(random == 5) 
            {
                continue;
            }
            if(random==15)
            {
                Debug.Log(random);
                break;
            }
        Debug.Log(random);
        }
    }

    
}
