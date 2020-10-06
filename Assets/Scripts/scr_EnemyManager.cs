using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_EnemyManager : MonoBehaviour
{
    //following tutorial on https://www.studica.com/blog/how-to-create-a-singleton-in-unity-3d

    public static scr_EnemyManager instance = null;
    public int HP = 3;

    private void Awake()
    {
        if(instance == null) //Determine if our instance is null
        {
            instance = this; //assign instance to this instace of the class
        }
        else if(instance != this)  //Determine if our instance is already assigned to something else
        {
            Destroy(gameObject);  //Since we already have a manager assigned somewhere else, we don'e need a duplicate
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
