using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MagicSpell
{

	public override void Activate()
	{
		base.Activate();

		PlaySound();

		PlayAnimation();
	}

	public override void PlaySound()
	{
		//base.PlaySound();

		print("Sound played");
	}

	

}
