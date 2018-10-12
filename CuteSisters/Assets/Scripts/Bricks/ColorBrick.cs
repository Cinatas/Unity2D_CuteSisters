using CuteSister.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBrick : BrickBase{

    GameObject crackObj;
    [SerializeField]
    GameObject hitFXprefab;
    int hp = 2;
    private void Awake()
    {
        crackObj = this.transform.Find("crack").gameObject;

        this.OnPlayerTopTouched += new UnityEngine.Events.UnityAction(OnPlayerHeadHit);
    }

    private void Start()
    {
        crackObj.SetActive(false);
    }

    void Break()
    {
        Instantiate(hitFXprefab).transform.position = this.transform.position;
        Destroy(this.gameObject);
    }

    void ShowCrack()
    {
        crackObj.SetActive(true);
    }

    void OnPlayerHeadHit()
    {
        hp--;
        if (hp > 0)
        {
            ShowCrack();
        }
        else
        {
            Break();
        }
    }
}
