using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While01 : MonoBehaviour
{

    public int counter;

    // Start is called before the first frame update
    void Start()
    {
        while (counter <= 100)
        {
            Debug.Log(counter);
            counter++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //counter++
        //
        //Debug.Log("Pasó el frame número"+ counter);

    }
}
