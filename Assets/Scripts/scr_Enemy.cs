using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Enemy : MonoBehaviour
{
    private Transform enemyTransform;
    public float enemySpeed;
    // Start is called before the first frame update
    void Start()
    {
        enemyTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyTransform.position += Vector3.down * enemySpeed * Time.deltaTime;
    }

    
}
