using UnityEngine;
using System.Collections;

public class LaserSound : MonoBehaviour
{

    public AudioClip Laser;
    private LaserSound source;

  
    void Awake()
    {
        source = GetComponent<LaserSound>();
    }


    void OnTriggerEnter(Collider other)
    {
        LaserSound LaserSound = other.gameObject.GetComponent<LaserSound>();
    }

}