using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollectorTutorial : MonoBehaviour
{
    private int coins = 0;
    public GameObject door;
    [SerializeField] private Text coinsText;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Coins"))
        {
            Destroy(collision.gameObject);
            coins++;
            coinsText.text = "Coins : " + coins;

        }
    }
    private void Update()
    {
        if (coins == 6)
        {
            Destroy(door);
        }
    }
}
