using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : MonoBehaviour
{
	public Animator[] trooperAnimators;

	public void SetTrigger(string trigger)
	{
		foreach (Animator animator in trooperAnimators)
		{
			animator.SetTrigger(trigger);
		}
	}

	public void FireTrooper(int index)
	{
		// Dependiendo de su ídice establece un trigger.
		switch (index)
		{
			case 1:
				trooperAnimators[0].SetTrigger("FiringRifle");
				break;

			case 2:
				trooperAnimators[1].SetTrigger("CruchRapidFire");
				break;

			case 3:
				trooperAnimators[2].SetTrigger("FiringRifle");
				break;

			case 4:
				trooperAnimators[3].SetTrigger("FiringRifle");
				break;
		}
	}

	public void DeathTrooper(int index)
	{
		// Dependiendo de su ídice establece un trigger.
		switch (index)
		{
			case 1:
				trooperAnimators[0].SetTrigger("Death3");
				break;

			case 2:
				trooperAnimators[1].SetTrigger("Death1");
				break;

			case 3:
				trooperAnimators[2].SetTrigger("Death2");
				break;

			case 4:
				trooperAnimators[3].SetTrigger("Death2");
				break;
		}
	}
}