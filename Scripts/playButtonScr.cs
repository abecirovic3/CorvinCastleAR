using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playButtonScr : MonoBehaviour
{
	public GameObject videoPlane;
	
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
				if (hit.collider.tag == "playBtn")
				{
					if (videoPlane.activeSelf) videoPlane.SetActive(false);
					else videoPlane.SetActive(true);
				}
			}
		}
    }
}
