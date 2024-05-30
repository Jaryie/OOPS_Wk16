using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseUpgrade
{
    public Button upgradeButton;

    protected int cost = 1;

    public abstract void ApplyUpgrade();

    public abstract string UpgradeName();







    public void CheckButtonCost(int money)
    {
        if (upgradeButton == null)
        {
            return
        }

        if (money < cost)
        {
            upgradeButtone.interactable = false;
        }
        else
        {
            upgradeButton.interactable = true;
        }
    }
}
