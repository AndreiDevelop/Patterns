using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumperManager : Subject 
{
	private void OnTriggerEnter(Collider col)
	{
		Jumper tempJumper = col.GetComponent<Jumper> ();

		if (tempJumper) 
		{
			base.AddObserver (tempJumper);
		}
	}

	private void OnTriggerExit(Collider col)
	{
		Jumper tempJumper = col.GetComponent<Jumper> ();

		if (tempJumper) 
		{
			base.RemoveObserver (tempJumper);
		}
	}
}
