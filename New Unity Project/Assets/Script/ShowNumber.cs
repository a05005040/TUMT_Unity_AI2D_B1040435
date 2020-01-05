using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShowNumber : MonoBehaviour {
    public Number[] num;
    public int score;

    void Update() {
        ChangeNumbers();
    }

    void ChangeNumbers() {
        string str  = score.ToString("000000000");

        for (int i = 0; i < str.Length; i++) {
            int j =int.Parse( str[i].ToString());
            num[i].ChangeNum(j);
        }
    }

}
