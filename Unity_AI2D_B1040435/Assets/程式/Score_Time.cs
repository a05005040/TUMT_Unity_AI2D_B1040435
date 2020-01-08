using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Time : MonoBehaviour {
    public static float Time_Num =120;
    public static int Score_Num = 0;
    public Sprite[] Texture;
    public GameObject[] Score_UI;
    public GameObject[] Time_UI;
    private int Score_Num_0, Score_Num_1, Score_Num_2;
    private int Time_Num_0, Time_Num_1, Time_Num_2;
    // Use this for initialization
    void Start ()
    {

        Time_Num = 15;
        Score_Num = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Time_Num -= Time.deltaTime;
        if (Time_Num <= 0)
        {
            Time_UI[0].SetActive(true);
            Time_UI[1].SetActive(false);
            Time_UI[2].SetActive(false);
            Time_UI[0].GetComponent<SpriteRenderer>().sprite = Texture[0];
        }
        if (Time_Num > 0 && Time_Num < 10)
        {
            Time_UI[0].SetActive(true);
            Time_UI[1].SetActive(false);
            Time_UI[2].SetActive(false);
            Time_UI[0].GetComponent<SpriteRenderer>().sprite = Texture[(int)Time_Num];
        }
        if (Time_Num >= 10 && Time_Num < 100)
        {
            Time_Num_0 = (int)(Time_Num / 10);
            Time_Num_1 = (int)(Time_Num % 10);

            Time_UI[0].SetActive(true);
            Time_UI[1].SetActive(true);
            Time_UI[2].SetActive(false);
            Time_UI[0].GetComponent<SpriteRenderer>().sprite = Texture[Time_Num_0];
            Time_UI[1].GetComponent<SpriteRenderer>().sprite = Texture[Time_Num_1];


        }
        if (Time_Num >= 100 && Time_Num < 1000)
        {
            Time_Num_0 =(int)(Time_Num / 100);
            Time_Num_1 = (int)((Time_Num % 100)/10);
            Time_Num_2 = (int)((Time_Num % 100) % 10);

            Time_UI[0].SetActive(true);
            Time_UI[1].SetActive(true);
            Time_UI[2].SetActive(true);
            Time_UI[0].GetComponent<SpriteRenderer>().sprite = Texture[Time_Num_0];
            Time_UI[1].GetComponent<SpriteRenderer>().sprite = Texture[Time_Num_1];
            Time_UI[2].GetComponent<SpriteRenderer>().sprite = Texture[Time_Num_2];


        }




        

        if (Score_Num <= 0)
        {
            Score_UI[0].SetActive(true);
            Score_UI[1].SetActive(false);
            Score_UI[2].SetActive(false);
            Score_UI[0].GetComponent<SpriteRenderer>().sprite = Texture[0];
        }
        if (Score_Num > 0 && Score_Num < 10)
        {
            Score_UI[0].SetActive(true);
            Score_UI[1].SetActive(false);
            Score_UI[2].SetActive(false);
            Score_UI[0].GetComponent<SpriteRenderer>().sprite = Texture[(int)Score_Num];
        }
        if (Score_Num >= 10 && Score_Num < 100)
        {
            Score_Num_0 = (int)(Score_Num / 10);
            Score_Num_1 = (int)(Score_Num % 10);

            Score_UI[0].SetActive(true);
            Score_UI[1].SetActive(true);
            Score_UI[2].SetActive(false);
            Score_UI[0].GetComponent<SpriteRenderer>().sprite = Texture[Score_Num_0];
            Score_UI[1].GetComponent<SpriteRenderer>().sprite = Texture[Score_Num_1];


        }
        if (Score_Num >= 100 && Score_Num < 1000)
        {
            Score_Num_0 = (int)(Score_Num / 100);
            Score_Num_1 = (int)((Score_Num % 100) / 10);
            Score_Num_2 = (int)((Score_Num % 100) % 10);

            Score_UI[0].SetActive(true);
            Score_UI[1].SetActive(true);
            Score_UI[2].SetActive(true);
            Score_UI[0].GetComponent<SpriteRenderer>().sprite = Texture[Score_Num_0];
            Score_UI[1].GetComponent<SpriteRenderer>().sprite = Texture[Score_Num_1];
            Score_UI[2].GetComponent<SpriteRenderer>().sprite = Texture[Score_Num_2];


        }




    }
}
