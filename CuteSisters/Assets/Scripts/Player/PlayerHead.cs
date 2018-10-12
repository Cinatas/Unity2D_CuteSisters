using CuteSister.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CuteSister.Player
{
    public class PlayerHead : MonoBehaviour
    {
        GameObject headColliderFX;
        // Use this for initialization
        void Start()
        {
            headColliderFX = Resources.Load<GameObject>("FX/HeadColliderFX");
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            BrickBase brick = collision.GetComponent<BrickBase>();
            if (brick!= null)
            {
                brick.OnPlayerTopTouched();
                Player_Controller._Instance.SetPlayerVerticalSpeed(0);
            }
            else
            {
                Instantiate(headColliderFX).transform.position = this.transform.position + new Vector3(0, -0.5f, 0);
            }
        }
    }

}
