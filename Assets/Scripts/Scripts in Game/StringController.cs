using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringController : MonoBehaviour {


    public MoveStringSpawnbox owner;
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Cat"))
        {
            Destroy(this.gameObject);
        }
    }
}
