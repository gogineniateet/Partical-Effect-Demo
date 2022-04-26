using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalEffectController : MonoBehaviour
{
    ParticleSystem particle;
    // Start is called before the first frame update
    void Start()
    {
        particle = GetComponent<ParticleSystem>();
        //particleSystem.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            particle.Play();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            particle.Stop();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            particle.Pause();
        }
    }
}
