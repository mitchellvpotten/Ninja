using UnityEngine;
using System.Collections;

public class killplane : MonoBehaviour
{

    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Player")
        {
            c.GetComponent<Entity>().TakeDamage(10);
            Debug.Log("you died");
        }
    }
}