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
        InvokeRepeating("moveEnemy", 1.0f, 0.1f);
    }

    void moveEnemy()
    {
        if (enemyTransform.position.x > 9.0f)
        {
            enemyDirection = 0;
            enemyTransform.position -= new Vector3(0, 0.5f);
        }

        if (enemyTransform.position.x < -9.0f)
        {
            enemyDirection = 1;
            enemyTransform.position -= new Vector3(0, 0.5f);
        }

        if (enemyDirection == 1)
        {
            enemyTransform.position += new Vector3(1.0f, 0.0f);
            //Debug.Log(enemyTransform.position.x);
        }

        if (enemyDirection == 0)
        {
            enemyTransform.position -= new Vector3(1.0f, 0.0f);
            //Debug.Log("I moved left 1");
        }


        
    }
    // Update is called once per frame
    void Update()
    {
        //enemyTransform.position += Vector3.down * enemySpeed * Time.deltaTime;
    }

    
}
