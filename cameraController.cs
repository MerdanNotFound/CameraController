using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCon : MonoBehaviour
{
    public GameObject Player;
    public GameObject child;
    public float speed;
    
    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        child = Player.transform.Find("CameraManager").gameObject;
    }

    private void FixedUpdate()
    {
        follow();
    }

    private void follow()   
    {
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, child.transform.position, Time.deltaTime * speed);
        gameObject.transform.LookAt(Player.gameObject.transform.position);
    }
}
