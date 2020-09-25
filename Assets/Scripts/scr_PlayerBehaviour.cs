using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_PlayerBehaviour : MonoBehaviour
{
    private Transform playerTransform;
    public float speed;
    public GameObject bulletFired;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GetComponent<Transform>();   
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveHorizontal, 0);
        playerTransform.position += movement * speed;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletFired, playerTransform.position, playerTransform.rotation);
        }
    }
}
