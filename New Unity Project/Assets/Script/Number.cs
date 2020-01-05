using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number : MonoBehaviour {
    public Sprite[] num;

    void Awake() {
        ChangeNum(0);
    }
    public void ChangeNum(int v) {
        GetComponent<Image>().sprite = num[v];
    }
}
