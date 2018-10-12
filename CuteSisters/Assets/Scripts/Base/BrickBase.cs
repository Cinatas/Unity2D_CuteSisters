using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace CuteSister.Base
{
    [RequireComponent(typeof(Collider2D))]
    public class BrickBase : MonoBehaviour
    {
        public UnityAction OnPlayerTopTouched;
    }
}
