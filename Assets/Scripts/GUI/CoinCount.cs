
using UnityEngine;
using UnityEngine.UI;

public class CoinCount : MonoBehaviour
{
        public Text moedasCount;
        public GameObject mainManager;

        void Update()
        {
            moedasCount.text = mainManager.GetComponent<CurrencyManager>().totalCurrencys.ToString();
        }
}
