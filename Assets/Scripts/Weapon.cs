using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float damage = 20f;



    public virtual void Attack ()
    {
        Debug.Log("Doing " + damage + "DAMAGE");

    }


}
