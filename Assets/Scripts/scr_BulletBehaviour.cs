using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_BulletBehaviour : MonoBehaviour
{
    private Transform bulletTransform;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        bulletTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bulletTransform.position += Vector3.up * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
    }
}
