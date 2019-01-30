using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveStringSpawnbox : MonoBehaviour {

    Vector3 centerPos;
    public float count;
    public Text countText;
    float distanceFromCamera = 10f;
    public float ThingCounter;
    public StringController StringPrefab;
    public StringController GoldenPrefab;
    public Transform StringStart;
    public EnemyController DogPrefab;
    public Transform DogStart;
    float Selector;
    public float ScoreIncrease;
    float NumDog;
    public PlayerController cat;

    void Start () {
        Vector3 centerPos = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, distanceFromCamera));
        NumDog = 0;
        ThingCounter = -1;
    }
	
	// Update is called once per frame
	void Update () {
		if(ThingCounter > 0.9 + NumDog)
        {
            EnemyController newDog = Instantiate<EnemyController>(DogPrefab);
            newDog.Cat = this.cat.gameObject;
            newDog.transform.position = DogStart.position;
            NumDog += 1;
            ThingCounter = 0;
        }
	}
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Cat"))
        {
            Relocate();
            ThingCounter += 1;
            Spawn();
        }
    }
    void Relocate()
    {
        count += ScoreIncrease;
        SetCountText();
        gameObject.transform.position = centerPos;
        gameObject.transform.Translate(Random.Range(-8.4f, 8.4f), Random.Range(-4.6f, 4.6f), 0f);
        Selector = Random.value;
    }
    void Spawn()
    {
        if (Selector < 0.1)
        {
            StringController newGoldenString = Instantiate<StringController>(GoldenPrefab);
            newGoldenString.transform.position = StringStart.position;
            newGoldenString.owner = this;
            ScoreIncrease = 25f;
        }
        else
        {
            StringController newString = Instantiate<StringController>(StringPrefab);
            newString.transform.position = StringStart.position;
            newString.owner = this;
            ScoreIncrease = 10f;
        }
    }
    void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
    }
}
