using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    int speed = 0;
    string nama = "Player";
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] string message = " hdhd";
    void Start()
    {
        speed = 5;
        print(message);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
