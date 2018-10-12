using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CuteSister.Utility
{
    public class OnAnimation : MonoBehaviour
    {
        void OnAnimationOver()
        {
            Destroy(this.gameObject);
        }
    }
}
