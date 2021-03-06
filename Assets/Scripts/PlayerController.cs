﻿using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    private void Awake()
    {
        if (instance != null)
            return;

        instance = this;
    }

    public int money;
    [SerializeField] private int startMoney = 400;
    [SerializeField] private Text amountOfMoney;

    public void ReduceMoney(int valueToTakeAway)
    {
        money -= valueToTakeAway;
        amountOfMoney.text = money.ToString();
    }

    public void increaseMoney(int valueToAdd)
    {
        money += valueToAdd;
        amountOfMoney.text = money.ToString();
    }

    private void Start()
    {
        money = startMoney;
        amountOfMoney.text = startMoney.ToString();
    }
}