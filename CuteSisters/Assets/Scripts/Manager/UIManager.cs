using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CuteSister.Manager
{
    public class UIManager : MonoBehaviour
    {
        private static UIManager instance;
        public static UIManager _Instance
        {
            get
            {
                return instance;
            }
        }

        GameObject Canvas;
        GameObject CoinPanel;
        GameObject PlayerPanel;
        private void Awake()
        {
            instance = this;
            Canvas = GameObject.Find("Canvas");
            CoinPanel = Canvas.transform.Find("CoinImage").gameObject;
            PlayerPanel = Canvas.transform.Find("PlayerPanel").gameObject;
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}
