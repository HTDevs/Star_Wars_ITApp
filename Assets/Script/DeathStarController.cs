using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class DeathStarController : MonoBehaviour
{
	private ParticleSystem[] particles;
	private AudioSource audioSource;

	private void Start()
	{
		particles = gameObject.GetComponentsInChildren<ParticleSystem>();
		audioSource = gameObject.GetComponent<AudioSource>();
	}

	public void ParticlesPlay()
	{
		// Ejecuta las particulas del arreglo.
		foreach (ParticleSystem item in particles)
		{
			item.Play();
		}
		
		audioSource.Play();
	}
}