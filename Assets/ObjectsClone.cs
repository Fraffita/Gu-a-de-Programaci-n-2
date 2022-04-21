using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsClone : MonoBehaviour
{

    public int amount;
    public Transform objectToClone;
    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        while (counter < amount)
        {
            Instantiate(objectToClone);
            counter++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
