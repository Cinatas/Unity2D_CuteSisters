using CuteSister.Base;
using CuteSister.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testBrick : BrickBase {

    Rigidbody2D _rigid2D;
    float verticalSpeed;
    protected void Awake()
    {
        _rigid2D = this.GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start () {
        
	}
    private void FixedUpdate()
    {
        this.transform.Translate(Vector2.up * verticalSpeed * Time.deltaTime);
    }

    private void OnEnable()
    {
        this.OnPlayerTopTouched += OnTouch;
    }

    private void OnDisable()
    {
        this.OnPlayerTopTouched -= OnTouch;
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTouch()
    {
        Destroy(this.gameObject);
    }
}
