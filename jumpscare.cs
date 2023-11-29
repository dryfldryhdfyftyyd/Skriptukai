using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpscare : MonoBehaviour
{
    public float length = 10;
    public static jumpscare inst;
    private void Awaike()
    {
        if (inst == null) inst = this;
        else Destroy(gameObject);
    }

    // Update is called once per frame
    public void Start()
    {
        image.SetActive(true);
        Invoke(nameof(Restart), length);
    }
    public void Restart()
    {
        
    }
}
