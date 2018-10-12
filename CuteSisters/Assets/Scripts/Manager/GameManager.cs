using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CuteSister.Manager
{
    public class GameManager : MonoBehaviour
    {

        private static GameManager instance;
        public static GameManager _Instance
        {
            get
            {
                return instance;
            }
        }

        private int coinCount;
        public int _CoinCount
        {
            get
            {
                return coinCount;
            }
        }

        

        private void Awake()
        {
            instance = this;
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void GainCoin(int count)
        {
            coinCount += count;
        }
    }

}
