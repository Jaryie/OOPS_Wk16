using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    Rigidbody rb;

    public float speed;
    public float rotationSpeed;
    public float lift;
    public float gravity = 9.81f;
    public float score;


    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //Move forward
        rb.AddForce(transform.forward * speed, ForceMode.Acceleration);
    }
    // -MAFS-
    // Abs          - makes the number positive
    // Clamp01      - Ensures a value is between two other values
    // Clamp02      - Clamps between 0 and 1

    // if N is between 0 - 1
    // 1 - N
    // Invert aa number
    // 0.3 = 0.7
    // 0.1 = 0.9

    // Lerp         - Linear Interpolation
    //                      5       10
    //                          0.5 (indicating we want a number halfway between 5 and 10)
    //                          7.5
    // Sin/Cos      - waves (wavey lines, consistently fluctuating value, think wavy line graph)
    // Dot product  - how much o vectors point in the same direction
    //              - from 1 to -1
    // Cross prouct - 


    void FixedUpdate()
    {
        //Input
        float input = Input.GetAxisRaw("Vertical");
        rb.AddTorque(transform.right * rotationSpeed * input); // * Time.deltaTime);

        //Lift
        //float dot = Vector3.Dot(transform.forward, Vector3.up);
        //dot = 1 - Mathf.Abs(dot);
        //float liftResult = lift *= dot;
        rb.AddForce(transform.up * lift * SpeedMultiplier(), ForceMode.Acceleration);

        //Gravity
        rb.AddForce(Vector3.down * gravity, ForceMode.Acceleration);

        //Drag
        rb.AddForce(-transform.forward * 1f * SpeedMultiplier(), ForceMode.Acceleration);

        //Turn Drag
        float result = 1 - Vector3.Dot(rb.velocity.normalized, transform.forward);
        rb.AddForce(-transform.forward * result, ForceMode.Acceleration);

        //Forward
        //dot = Vector3.Dot(transform.forward, rb.velocity.normalized);
        //dot = Mathf.Abs(dot);
        //rb.velocity = rb.velocity * dot;

        //Velocity direction slowly turn forward
        rb.velocity = Vector3.Lerp(rb.velocity.normalized, transform.forward, Time.deltaTime).normalized * rb.velocity.magnitude;
    }
    float SpeedMultiplier()
    {
        return Mathf.InverseLerp(0, 10, rb.velocity.magnitude);
    }

        //dot = 1 - Mathf.Abs(dot);
        //rb.velocity = transform.forward * rb.velocity.magnitude * dot;   


    private void OnTriggerEnter(Collider other)
    {
        IScoreable scoreable = other.GetComponent<IScoreable>();
        if (scoreable != null)
        {
            score += scoreable.OnScore();
            //Debug.Log(scoreable.OnScore());
        }
    }
    public void OnCollisionEnter(Collision other)
    {
    IScoreable scoreable = other.gameObject.GetComponent<IScoreable>();
        if (scoreable != null)
        {
            score += scoreable.OnScore();
            //Debug.Log(scoreable.OnScore());
        }
    }

}
