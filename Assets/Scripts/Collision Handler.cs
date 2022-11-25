using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollustionHandler : MonoBehaviour
{
     void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("My name is Friendly");
                break;
            case "Finish":
                Debug.Log("Congraglulation you reached finish");
                break;
            case "Fuel":
                Debug.Log("You picked fuel");
                break;
            default:
                Debug.Log("Sorry you blew up!");
                    break;
        }
    }
}
