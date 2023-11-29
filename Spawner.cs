using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public int count = 8;

    void Start()
    {
        var pos = new Vector3(0, 300, 0);

        for (int i = 0; i < count; i++)
        {
            pos.x = Random.Range(10, 90);
            pos.z = Random.Range(10, 90);

            if(Physics.Raycast(pos, Vector3.down, out var hit))
            {
                Instantiate(prefab, hit.point, Quaternion.EulerAngles(hit.normal)); //Quaternion.identity
            }
        }
    }

    
}
