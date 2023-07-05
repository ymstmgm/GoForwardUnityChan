using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSound : MonoBehaviour
{
    // キューブの効果音
    public AudioSource audioSource;
    // 着地判定
    private bool isGround;


    // Start is called before the first frame update
    void Start()
    {}

     

    private void Update()
    {
        // 着地した時、重なった時に再生
        if (isGround)
        {
            audioSource.Play();
        }
    }
}
