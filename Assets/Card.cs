using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    float numberOfInstances = 0f;
    public void IncreaseInstance()
    {
        numberOfInstances++;
        // print(numberOfInstances);
    }    

    public bool IsMaxInstance()
    {
        if (numberOfInstances >= 2)
        {
            return true;
        }
        return false;
    }

    public float GetNumberofInstances()
    {
        return numberOfInstances;
    }
}
