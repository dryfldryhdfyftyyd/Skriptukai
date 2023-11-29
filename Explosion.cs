using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject particleSystemPrefab; // Drag and drop the Particle System prefab in the Inspector
    public float particleDuration = 2.0f; // Adjust the duration in the Inspector

    private bool particleActive = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && !particleActive)
        {
            particleActive = true;
            StartCoroutine(ShowParticleSystem());


        }
    }

    IEnumerator ShowParticleSystem()
    {
        GameObject particleObject = Instantiate(particleSystemPrefab, transform.position, Quaternion.identity);
        particleObject.transform.parent = transform;

        yield return new WaitForSeconds(particleDuration);

        Destroy(particleObject);
        particleActive = false;
    }
}
