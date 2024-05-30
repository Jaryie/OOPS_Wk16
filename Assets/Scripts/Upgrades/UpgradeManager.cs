using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
    //Field
    [SerializeField] private int money = 0;
    [SerializeField] private Button buttonPrefab;
    [SerializeField] private Transform buttonParent;
    private PlaneController planeController;
    private List<BaseUpgrade> upgrades;

    //property
    //public int Money2  {  get; private set; }
    public int Money
    {
        get
        {
            return money;
        }
        private set 
        { 
            money = value; 
            foreach (var upgrade in upgrades)
            {
                upgrade.CheckButtonCost(value);
            }
        }  
    }


   private void Start()
    {
        planeController = FindObjectOfType<PlaneController>();

        upgrades = new List<BaseUpgrade>();

        upgrades.Add(new SpeedUpgrade(planeController, 5, 500f));
        upgrades.Add(new SpeedUpgrade(planeController, 8, 1000f));
        upgrades.Add(new SpeedUpgrade(planeController, 11, 1500f));
        upgrades.Add(new GravityUpgrade(planeController, 5, 1f));
        upgrades.Add(new GravityUpgrade(planeController, 8, 2f));
        upgrades.Add(new GravityUpgrade(planeController, 11, 3f));

       /* int x = 0;
        foreach (var upgrade in upgrades)
        {
            Button go = Instantiate(buttonPrefab, buttonParent);
            TMP_Text text = go.GetComponentInChildren<TMP_TExt>);
            text.text = upgrade.UpgradeName();
            upgrade.SetButton(go);
            upgrade.CheckButtoneCost(Money);

            int y = x;
            go.onClick.AddListener(() => PurchaseUpgrade(y));
            x++;
        }*/

        for (int i = 0; i < upgrades.Count; i++)
        {
            var upgrade = upgrades[i];

            Button go = Instantiate(buttonPrefab, buttonParent);
            upgrade.SetButton(go);
            upgrade.CheckButtonCost(Money);
            TMP_Text text = go.GetComponentInChildren<TMP_Text>();
            text.text = upgrade.UpgradeName();

            int x = i;
            go.onClick.AddListener(() => PurchaseUpgrade(x));
        }
    }

    public void PurchaseUpgrade(int index)
    {
    int tempMoney = Money;
    if (upgrades[index].PayForUpgrade(ref tempMoney))
    {
        upgrades[index].ApplyUpgrade();
    }

    Money = tempMoney;        
    }
    public void EarnMoney(int amount)
    {
        Money += amount;
    }

}
