using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ShipsController : MonoBehaviour
{
	public GameObject explode;
	private ParticleSystem[] particles;
	private AudioSource audioSource;

	private void Start()
	{
		particles = explode.GetComponentsInChildren<ParticleSystem>();
		audioSource = gameObject.GetComponent<AudioSource>();
	}

	public void ParticlesPlay()
	{
		// Ejecuta los sistemas de particulas del objeto.
		foreach (ParticleSystem item in particles)
		{
			item.Play();
		}
		
		audioSource.Play();
	}
}