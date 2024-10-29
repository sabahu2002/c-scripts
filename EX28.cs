using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX28 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         string [] random = {"cat","dog","car","pizza","hat","fish","tree","monkey","ball","bird"};
        int counter=0;
        while (counter <= 10 )
        {
            
            Debug.Log(random[Random.Range(0,random.Length)] + " " + random[Random.Range(0,random.Length)] + " " + random[Random.Range(0,random.Length)] +" " + random[Random.Range(0,random.Length)] + " "+ random[Random.Range(0,random.Length)] +" "+ random[Random.Range(0,random.Length)] +" "+ random[Random.Range(0,random.Length)]);

            counter++;
        }
        
    }

    
}
