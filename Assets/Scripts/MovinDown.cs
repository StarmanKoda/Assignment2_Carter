using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovinDown : MonoBehaviour
{
    public GameObject Tracker;
    public float Speed;

    // Update is called once per frame
    void Update()
    {
        Tracker.transform.Translate(new Vector2( 0, -Speed * Time.deltaTime));
    }
}
