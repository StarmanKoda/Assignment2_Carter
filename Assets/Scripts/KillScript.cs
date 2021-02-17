using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript : MonoBehaviour
{
    public GameObject Me;
    public Transform explosionPrefab;


    private void OnTriggerEnter2D(Collider2D Coll)
    {
        Debug.Log("Killed");
        Destroy(Me);
        Instantiate(explosionPrefab, this.transform.position, Quaternion.identity);
    }
}
