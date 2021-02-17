using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Diagnostics;

public class EEE : MonoBehaviour
{
    public GameObject Bob;
    public float Speed;
    public KeyCode Right;
    public KeyCode Left;
    public KeyCode Up;
    public KeyCode Down;
    public KeyCode Fire;
    public KeyCode Dodge;
    public Transform objectToSpawn;
    private float timeCounter = 0;
    public float timeCounterDodge = 0;
    public float spawnObjectEverySeconds;
    public float dodgeEverySeconds;
    public Text HealthDisplay;
    public int health;
    public string leveltoLoad;
    public AudioSource Whoom;
    public bool dodge;

    

    // Start is called before the first frame update
    void Start()
    {
        dodge = false;
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        
            health = health - 25;
            HealthDisplay.text = health.ToString();
        
    }
    // Update is called once per frame
    void Update()
    {
        timeCounter = timeCounter + Time.deltaTime;

        if (Input.GetKey(Right))
        {
            Bob.transform.Translate(new Vector2(Speed * Time.deltaTime, 0));
        }

        if (Input.GetKey(Left))
        {
            Bob.transform.Translate(new Vector2(-Speed * Time.deltaTime, 0));
        }
        if (Input.GetKey(Up))
        {
            Bob.transform.Translate(new Vector2(0, Speed * Time.deltaTime));
        }
        if (Input.GetKey(Down))
        {
            Bob.transform.Translate(new Vector2(0, -Speed * Time.deltaTime));
        }
        if (Input.GetKey(Fire) && (timeCounter > spawnObjectEverySeconds))
        {
            Instantiate(objectToSpawn,new Vector2(this.transform.position.x , this.transform.position.y + 2), Quaternion.identity);
            timeCounter = 0;
        }
        


        if (health == 0)
        {
            Destroy(Bob);
            SceneManager.LoadScene(leveltoLoad);
        }
    }
}
