using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MagicSpell
{
	public override void Activate()
	{
		base.Activate();

		PlayAnimation();
	}
}
