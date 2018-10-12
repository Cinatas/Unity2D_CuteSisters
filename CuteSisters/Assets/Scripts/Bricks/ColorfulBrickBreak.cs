using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorfulBrickBreak : MonoBehaviour {

    Rigidbody2D _rigid1;
    Rigidbody2D _rigid2;
    Rigidbody2D _rigid3;
    Rigidbody2D _rigid4;

    private void Awake()
    {
        _rigid1 = this.transform.Find("1").GetComponent<Rigidbody2D>();
        _rigid2 = this.transform.Find("2").GetComponent<Rigidbody2D>();
        _rigid3 = this.transform.Find("3").GetComponent<Rigidbody2D>();
        _rigid4 = this.transform.Find("4").GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start () {
        _rigid1.AddForce(new Vector2(-150, 150));
        _rigid2.AddForce(new Vector2(150, 150));
        _rigid3.AddForce(new Vector2(125, 100));
        _rigid4.AddForce(new Vector2(-125, 100));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
