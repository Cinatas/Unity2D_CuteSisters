using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CuteSister.Utility
{
    public class DestroyDelay : MonoBehaviour
    {
        public float DelayTime;

        private void Start()
        {
            Destroy(this.gameObject, DelayTime);
        }
    }

}
