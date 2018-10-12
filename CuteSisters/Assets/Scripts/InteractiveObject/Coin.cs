using CuteSister.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CuteSister.InteractiveObject
{
    public class Coin : MonoBehaviour
    {

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                GetByPlayer();
            }
        }

        void GetByPlayer()
        {
            GameManager._Instance.GainCoin(1);
            Destroy(this.gameObject);
        }
    }

}
