using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelEnd : MonoBehaviour
{
    public string leveltoLoad;
    public int leveltime;
    public float timeCounter;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter = timeCounter + Time.deltaTime;

        if (timeCounter > leveltime)
        {
            SceneManager.LoadScene(leveltoLoad);
        }
    }
}
