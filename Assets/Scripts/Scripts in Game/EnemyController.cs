using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public GameObject Cat;
    public float step;
    float speed;
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        speed = step * Time.deltaTime;
        this.transform.position = Vector2.MoveTowards(this.transform.position, Cat.transform.position, speed);

        print("Moving " + name + " from " + this.transform.position + " " + Cat.transform.position + " by " + speed);
	}
}
