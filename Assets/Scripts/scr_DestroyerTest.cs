using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_DestroyerTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            scr_EnemyManager.instance.HP--;  //if user presses space, decrease HP by 1
            Debug.Log("--HP:" + scr_EnemyManager.instance.HP);
        }
        if(scr_EnemyManager.instance.HP == 0)
        {
            Destroy(gameObject); //If HP == 0, destroy object this script is attached to
        }
    }
}
