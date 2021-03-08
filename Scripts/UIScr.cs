using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScr : MonoBehaviour
{
	public GameObject panel;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void exitBtnEvent() {
		Application.Quit();
	}
	
	public void infoBtnEvent() {
		panel.SetActive(!panel.activeSelf);
	}
	
	public void imgButtonEvent() {
		Application.OpenURL("https://thumbs.dreamstime.com/z/corvin-castle-romania-europe-flat-vector-attraction-landmark-cartoon-style-historic-sight-showplace-web-site-illustration-world-69347884.jpg");
	}
}
