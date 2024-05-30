using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Weapon Slot1;
    public Weapon Slot2;
    public Weapon Slot3;
    public Weapon Slot4;
    public Weapon Slot5;
    public Weapon Slot6;
                //Weapon
                //meleeWeapon
                //Sword

    public void Start()
    {
        Slot1.Attack();
        Slot2.Attack();
        Slot3.Attack();
        Slot4.Attack();
        Slot5.Attack();
        Slot6.Attack();

    }
}
