using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour, IObserver 
{
	private MeshRenderer _meshRenderer;

	void Awake () 
	{
		_meshRenderer = GetComponent<MeshRenderer> ();
	}

	public void Notify()
	{
		ColorChange ();
	}

	public void ColorChange()
	{
		_meshRenderer.material.color = Random.ColorHSV ();
	}
}
