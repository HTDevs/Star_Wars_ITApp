using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Vuforia;

public class AppController : MonoBehaviour
{
	public bool LoadNow { get; set; }
	public bool isTrackingScene;

	public static AppController Current
	{ 
		get 
		{ 
			return GameObject.Find("AppController").GetComponent<AppController>();
		} 
	}

	public static float MasterVolume
	{
		set { PlayerPrefs.SetFloat("masterVolume", value); }
		get { return PlayerPrefs.GetFloat("masterVolume"); }
	}

	private void Awake()
	{
		if (PlayerPrefs.GetInt("isFirstLoad") == 0)
		{
			AppController.MasterVolume = 100.0f;
			PlayerPrefs.SetInt("isFirstLoad", 1);
		}
	}

	private void Start()
	{
		this.LoadNow = false;

		if (!isTrackingScene)
		{
			Vuforia.VuforiaBehaviour.Instance.enabled = false;
		}
	}

	private void Update()
	{
		if (isTrackingScene)
		{
			CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
		}
	}

	public void LoadScene(int index, Animator animator)
    {
        // Inicia el estado de carga de partida.
        StartCoroutine(this.LoadSceneAsync(index, animator));
    }

    private IEnumerator LoadSceneAsync(int index, Animator animator)
    {
        // Carga la escena especificada en segundo plano.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(index);
		asyncLoad.allowSceneActivation = false;
		bool done = false;

        while (!asyncLoad.isDone)
        {
			if (asyncLoad.progress >= 0.9f && !done)
			{
				done = true;
				animator.SetTrigger("Loaded");
			}

			if (this.LoadNow)
			{
				asyncLoad.allowSceneActivation = true;
			}

            yield return null;
        }
    }

	public static void AppQuit()
	{
		Application.Quit();
	}
}