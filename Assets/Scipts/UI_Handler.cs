using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Handler : MonoBehaviour
{
	public GameObject img;
	
	public void buttonEvent(){
		if(img.active)
			img.SetActive(false);
		else
			img.SetActive(true);
		
	}
}
