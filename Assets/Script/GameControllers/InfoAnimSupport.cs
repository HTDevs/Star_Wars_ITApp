using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoAnimSupport : MonoBehaviour
{
	public Animator infoAnimator;

	public void ResetAnim()
	{
		infoAnimator.SetTrigger("Reset");
	}
}
