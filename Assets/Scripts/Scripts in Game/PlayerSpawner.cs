using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour {

    public PlayerController Prefab;
    public Transform PlayerStart;
    void Start () {
        // PlayerController newPlayerController = Instantiate<PlayerController>(Prefab);
        // newPlayerController.transform.position = PlayerStart.position;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
