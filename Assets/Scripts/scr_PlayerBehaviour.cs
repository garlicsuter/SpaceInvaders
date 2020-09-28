using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_PlayerBehaviour : MonoBehaviour
{
    private Transform playerTransform;
    public float speed;
    public GameObject bulletFired;
    private float fireElapsedTime = 0.0f;
    public float fireDelay = 0.2f;


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

        //continually increase how much time has elapsed since last fire. Once it is greater than the "fireDelay"
        // you can shoot again. Reset fireElapsed time to 0;
        fireElapsedTime += Time.deltaTime;

        if(Input.GetButton("Jump") && fireElapsedTime >= fireDelay)
        {
            Instantiate(bulletFired, playerTransform.position, playerTransform.rotation);
            fireElapsedTime = 0;
        }
    }
}
