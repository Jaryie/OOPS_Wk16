using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour, IScoreable
{
    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.maxAngularVelocity = float.PositiveInfinity;
    }

    public float OnScore()
    {
        rb.angularVelocity += new Vector3(40f, 40f, 40f);
        return 1f;
    }

}
