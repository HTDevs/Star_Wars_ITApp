using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class FlashToggle : MonoBehaviour
{
	private bool isActive = false;

	public void Toggle()
	{
		isActive = !isActive;
		CameraDevice.Instance.SetFlashTorchMode(isActive);
	}
}