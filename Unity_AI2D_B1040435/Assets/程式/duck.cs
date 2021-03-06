﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;           // 引用 事件 API
using UnityEngine.UI;

public class duck : MonoBehaviour {
    public int speed = 50;          //
    public float jump = 2.5f;
    public string duckname = "鴨子";
    public bool pass = false;
    private Rigidbody2D r2d;
    private Transform tra;
    public bool isGround,isDie;

    public UnityEvent onEat;

    [Header("血量"), Range(0, 200)]
    public float hp = 100;


    public Image hpBar;
    private float hpMax;
    public GameObject final,HP;
    // Use this for initialization
    void Start () {
        r2d = GetComponent<Rigidbody2D>();
        tra = GetComponent<Transform>();
        hpMax = hp;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.D)) Turn(0);
        if (Input.GetKeyDown(KeyCode.A)) Turn(180);




        if (Score_Time.Time_Num <= 0) StartCoroutine("Show_UI");
        
    }

    /// <summary>
    /// 走路
    /// </summary>
    private void Walk()
    {
        r2d.AddForce(new Vector2(speed * Input.GetAxis("Horizontal"), 0));
    }
    private void FixedUpdate()
    {
        Jump();
        Walk();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "地板")
        {
            isGround = true;
        }
        if (other.gameObject.name == "死亡區域")
        {
            isDie = true;
            if (isDie == true)
            {
                final.SetActive(true);
                HP.SetActive(false);
            }
        }
        //isGround = true;
        //Debug.Log("碰到" + collision.gameObject);


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "金幣")
        {
            Destroy(collision.gameObject);  // 刪除
            onEat.Invoke();                 // 呼叫事件
        }
    }

    /// <summary>
    /// 轉彎
    /// </summary>
    /// <param name="Direction">方向 左轉為180 右轉為0</param>
    private void Turn(int Direction)
    {

        tra.eulerAngles = new Vector3(0, Direction, 0);
    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
        {
            isGround = false;
            r2d.AddForce(new Vector2(0, jump));
        }
    }
    public void Damge(float damge)
    {
        hp -= damge;
        hpBar.fillAmount = hp / hpMax;
        if (hp <= 0)
        {
            final.SetActive(true);
        }


       
    }
    /// <summary>
    /// 時間到
    /// </summary>
    /// <returns></returns>
    IEnumerator  Show_UI()
    {
        final.SetActive(true);
        HP.SetActive(false);
        yield return new WaitForSeconds(0.2f);

    }
}
