using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;
using Vuforia;

public class UIController : MonoBehaviour
{
	public VideoPlayer video;
	private Animator animator;

	private void Start()
	{
		animator = gameObject.GetComponent<Animator>();

		if (video != null)
		{
			video.Prepare();
		}
	}
	public void PlayBackgroundVideo()
	{
		video.Play();
	}

	public void SetTrigger(string trigger)
	{
		animator.SetTrigger(trigger);
	}

	public void LoadScene(int index)
	{
		AppController.Current.LoadScene(index, animator);
	}

	public void LoadNow()
	{
		AppController.Current.LoadNow = true;
	}

	public void AppExit()
	{
		AppController.AppQuit();
	}
}