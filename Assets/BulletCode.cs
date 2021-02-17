using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCode : MonoBehaviour
{
    public GameObject Bullet;
    public float Speed;
    private float timeCounter = 0;
    public float destroyObjectEverySeconds;
    public Collider2D Smash;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter = timeCounter + Time.deltaTime;
        Bullet.transform.Translate(new Vector2(0, Speed * Time.deltaTime));
        

    }
    
    void OnCollisionEnter2D(Collision2D coll)
    {
        Smash.isTrigger = true;
        Debug.Log("Trigger On ");

       Destroy(Bullet);
    }

}
