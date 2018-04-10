using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangerManager : Subject
{
	private void OnTriggerEnter(Collider col)
	{
		ColorChanger tempColorChanger = col.GetComponent<ColorChanger> ();

		if (tempColorChanger) 
		{
			base.AddObserver (tempColorChanger);
		}
	}

	private void OnTriggerExit(Collider col)
	{
		ColorChanger tempColorChanger = col.GetComponent<ColorChanger> ();

		if (tempColorChanger) 
		{
			base.RemoveObserver (tempColorChanger);
		}
	}
}
