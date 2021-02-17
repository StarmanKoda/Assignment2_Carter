using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public Transform objectToSpawn;
    private float timeCounter = 0;
    public float spawnObjectEverySeconds;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter = timeCounter + Time.deltaTime;

        if (timeCounter > spawnObjectEverySeconds)
        {
            Instantiate(objectToSpawn, new Vector2(this.transform.position.x, this.transform.position.y - distance), Quaternion.identity);
            timeCounter = 0;
        }
    }
}
