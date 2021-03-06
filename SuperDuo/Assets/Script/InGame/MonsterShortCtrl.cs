﻿using UnityEngine;
using System.Collections;

public class MonsterShortCtrl : MonoBehaviour {

    public int builed;
    public MonsterShort m = new MonsterShort();
    public GameObject target;

    //최적화를 위한 캐싱 변수
    Transform tr;
    Rigidbody2D ri;
    Animator ani;
    AudioSource sound;

    //오브젝트 행동이 시작될 때 
    void Start()
    {
        //캐싱 작업
        tr = GetComponent<Transform>();
        ri = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
    }

    //매 프레임 마다 실행
    void Update()
    {

    }

    //체력을 관리합니다.
    public void HpManager(int num) {
        m.hp += num; 
    }


}
