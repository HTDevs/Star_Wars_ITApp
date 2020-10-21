using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class ImaTarAnimSupport : MonoBehaviour
{
	private AudioSource[] audios;

	private void Start()
	{
		audios = gameObject.GetComponentsInChildren<AudioSource>();
	}

	public void Play()
	{
		foreach (AudioSource item in audios)
		{
			item.Play();
		}
	}

	public void Pause()
	{
		foreach (AudioSource item in audios)
		{
			item.Pause();
		}
	}
}