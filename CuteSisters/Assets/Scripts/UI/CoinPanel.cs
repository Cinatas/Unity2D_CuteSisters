using CuteSister.Manager;
using CuteSister.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CuteSister.UI
{
    public class CoinPanel : MonoBehaviour
    {
        Image coinImage;
        Text coinText;
        private void Awake()
        {
            coinImage = this.GetComponentInChildren<Image>();
            coinText = this.GetComponentInChildren<Text>();
        }

        // Update is called once per frame
        void Update()
        {
            int coinCount = GameManager._Instance._CoinCount;
            coinText.text = "× " + coinCount.ToString();
        }
    }

}
