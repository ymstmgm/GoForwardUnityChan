using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSound : MonoBehaviour
{
    //キューブの効果音
    private AudioSource AudioSource;

    void Start()
    {
        // キューブの音を取得する
        AudioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // キューブが地面に接触と重なった時に音を再生する
        AudioSource.Play();
       
        // ユニティちゃんを判定
        if (collision.gameObject.name == "UnityChan2D")
       {
        // 音を再生しない
        return;
       }
    }
}
