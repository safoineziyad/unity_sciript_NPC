using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour

    public interface level = 1;
    public float speed = 5f;
    private int health;
{
    // Start is called before the first frame update
    void Start()
    {
        health = level;
        Debug.Log("NPC Health:" + health);
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = Transform.position;
        newPosition.z += speed * Time.deltaTime;
        Transform.position = newPosition;
    }-
