using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(Collider))]
public class Jumper : MonoBehaviour, IObserver 
{
	private const float LIMIT_HEIGHT = 0.55f;

	[SerializeField]
	private float _jumpForce = 30f;

	private Transform _transform = null;
	private Rigidbody _rigitbody = null;

	void Awake () 
	{
		_transform = transform;
		_rigitbody = GetComponent<Rigidbody> ();
	}
	
	public void Notify()
	{
		Jump ();
	}

	private void Jump()
	{
		if (_transform.position.y < LIMIT_HEIGHT) 
		{
			_rigitbody.AddForce (Vector3.up * _jumpForce);
		}
	}
}
