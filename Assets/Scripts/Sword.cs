using UnityEngine;
public enum Materials
{
    Wood,
    Bronze,
    Iron,
    Steel,
    Diamond,
    Gems,
}

public class Sword : MeleeWeapon
{
    public Materials blade;
    public Materials hilt;
    public Materials pommel;
}
