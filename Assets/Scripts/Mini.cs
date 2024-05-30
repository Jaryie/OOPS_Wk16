using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mini : MonoBehaviour, IScoreable
{
    private Rigidbody rb;
    private void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }

    public float OnScore()
        {
            rb.AddTorque (0f, 100f,0f, ForceMode.VelocityChange);
            return 1f;
        }

    }


//https://www.youtube.com/watch?v=2T5_0AGdFic