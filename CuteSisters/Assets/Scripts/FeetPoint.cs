using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CuteSister.Player
{
    public class FeetPoint : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Ground"))
                Player_Controller._Instance.OnGround();
        }
    }
}
