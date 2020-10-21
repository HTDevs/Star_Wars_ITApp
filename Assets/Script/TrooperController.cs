using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class TrooperController : MonoBehaviour
{
	public AudioClip[] others;
	private AudioSource audioSource;

	private void Start ()
	{
		audioSource = gameObject.GetComponent<AudioSource>();
	}

	public void PlayAnyClip()
	{
		// Reproduce cualquier audio del arreglo.
		int random = Random.Range(0, others.Length - 1);
		audioSource.clip = others[random];
		audioSource.Play();
	}
}