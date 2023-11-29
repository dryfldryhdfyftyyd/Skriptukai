using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldCoin : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject.Destroy(collision.gameObject);
        }
    }
}
