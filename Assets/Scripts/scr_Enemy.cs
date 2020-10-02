using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Enemy : MonoBehaviour
{
    private Transform enemyTransform;
    public float enemySpeed;
    private int enemyDirection = 1;


    // Start is called before the first frame update
    void Start()
    {
        enemyTransform = GetComponent<Transform>();

        InvokeRepeating("moveEnemy", 1.0f, 0.5f);
    }

    void moveEnemy()
    {
        if (enemyDirection == 1)
        {
            enemyTransform.position += new Vector3(1.0f, 0.0f);
            Debug.Log("I moved right 1");
        }
    }
    // Update is called once per frame
    void Update()
    {
        //enemyTransform.position += Vector3.down * enemySpeed * Time.deltaTime;
    }

    
}
