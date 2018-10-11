using CuteSister.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CuteSister.Test
{
    public class testInput : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Player_Controller._Instance.Jump(15f);
            }
        }
    }

}
