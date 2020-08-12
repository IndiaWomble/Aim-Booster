using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontrollerscore : MonoBehaviour {

    public int count = 0;
    public TextEditor score;
    void OnMouseDown()
    {
        gameObject.transform.position = new Vector3(Random.Range(-0.5f, 0.5f) * 10, Random.Range(-0.5f, 0.5f) * 10, 0.0f);
        count++;
    }
    // Use this for initialization
    void Start () {
        score = GetComponent<TextEditor>();
}

	
	// Update is called once per frame
	void Update () {
    score.text = "Score : " + count;
	}
}
