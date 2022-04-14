using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision c)
    {
        if (Equals(c.gameObject.tag, "wall"))
        {
            Debug.Log("Human you hit a wall...what to do?");

            // Player lose Hp.
            // Level is restarted.
            // Spawn more enemies.
        }
    }
}
