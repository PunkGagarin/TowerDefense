﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {
    public static int Money;
    public int startingMoney = 500;

    public static int Lives;
    public int startingLives = 20;

    public static int Rounds;
    void Start() {
        Money = startingMoney;
        Lives = startingLives;

        Rounds = 0;
    }
}
