﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bunarScript : MonoBehaviour
{
	public GameObject textPlane;
	
	Ray ray;
	RaycastHit hit;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetMouseButtonDown(0))
		{
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			
			if (Physics.Raycast(ray, out hit))
			{
				if (hit.collider.tag == "bunar")
				{
					if (textPlane.activeSelf) textPlane.SetActive(false);
					else textPlane.SetActive(true);
				}
			}
		}
    }
}
