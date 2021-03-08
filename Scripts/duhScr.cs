using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duhScr : MonoBehaviour
{
	
	public GameObject duhPlane;
	
	Ray ray;
	RaycastHit hit;
	
	float movementOffset = 0.0001f;
	int counter = 0;
	
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
				if (hit.collider.tag == "duh")
				{	
					duhPlane.SetActive(!duhPlane.activeSelf);
				}
			}
		}
		
		if (duhPlane.activeSelf) 
		{
			counter++;
			if (counter == 25)
			{
				movementOffset *= -1;
				counter = 0;
			}
			Vector3 pos = transform.position;
			transform.position = new Vector3(pos.x, pos.y + movementOffset, pos.z);
		}
    }
}
