using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    // the Dust Effect under the snowBoard Mechanism

    [SerializeField] ParticleSystem dust;
    [SerializeField] float dustExitDelay = 0.5f;

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            dust.Play();
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            // a little delay before the seperation make the snow look more realistic.
            Invoke("DustStop", dustExitDelay);
        }
    }

    void DustStop()
    {
        dust.Stop();
    }


}
