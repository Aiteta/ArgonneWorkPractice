﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
	public Vector3 spinSpeed = new Vector3(0,0,0);
	Vector3 spinAxis = new Vector3(0,1,0);
	public float rotateSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        spinSpeed = new Vector3(Random.value,Random.value,Random.value);
        spinAxis = Vector3.up;
        spinAxis.x = (Random.value-Random.value)*.05f;
    }

    public void setSize(float size) {
    	this.transform.localScale = new Vector3(size,size,size);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(spinSpeed);
        this.transform.RotateAround(Vector3.zero,spinAxis,rotateSpeed);
    }
}
