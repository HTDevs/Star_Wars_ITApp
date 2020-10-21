using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class AudioGroupController : MonoBehaviour
{
	public AudioMixer group;
	public string groupName;

	[Header("ReadOnly")]
	public float volume;
	
	private void Update () 
	{
		group.SetFloat(groupName, 20.0f * Mathf.Log10(volume));
	}
}