using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    public int count;
    [SerializeField] private Text countText;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collectable"))
        {
            count++;
            UpdateCountText();
            Destroy(collision.gameObject);
        }
    }

    void UpdateCountText()
    {
        if (countText != null)
        {
            countText.text = count.ToString();
        }
    }
}