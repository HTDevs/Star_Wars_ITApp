using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class R2Controller : MonoBehaviour
{
	public AudioClip scream;
	public AudioClip[] others;
	private AudioSource audioSource;

	private void Start ()
	{
		audioSource = gameObject.GetComponent<AudioSource>();
	}
	
	public void PlayScream()
	{
		audioSource.clip = scream;
		audioSource.Play();
	}

	public void PlayAnyClip()
	{
		// Ejecuta cualquier audio del arreglo.
		int random = Random.Range(0, others.Length - 1);
		audioSource.clip = others[random];
		audioSource.Play();
	}
}