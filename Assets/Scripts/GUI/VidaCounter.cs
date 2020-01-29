using UnityEngine;
using UnityEngine.UI;

public class VidaCounter : MonoBehaviour
{
    public GameObject playerRef;
    public Text lifeCount;

    void Update()
    {
        lifeCount.text = playerRef.GetComponent<ShipController>().allStatus[playerRef.GetComponent<ShipController>().healthLevel - 1].health.ToString();
    }
}
