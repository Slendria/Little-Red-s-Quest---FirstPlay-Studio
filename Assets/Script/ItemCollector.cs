using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{

    private int coins = 0;
    public GameObject door;
    [SerializeField] private Text coinsText;
    [SerializeField] private AudioSource coinsAudioSource;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Coins"))
        {
            coinsAudioSource.Play();
            Destroy(collision.gameObject);
            coins++;
            coinsText.text = " : " + coins;

        }
    }
    private void Update()
    {
        if(coins == 6)
        {
            Destroy(door);
        }
    }

}
