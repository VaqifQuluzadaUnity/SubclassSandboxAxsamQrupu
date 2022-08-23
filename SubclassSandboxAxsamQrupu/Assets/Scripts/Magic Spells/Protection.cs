using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protection : MagicSpell
{
	[SerializeField] private GameObject shieldPrefab;
	public override void Activate()
	{
		base.Activate();
		SpawnShield();

	}

	private void SpawnShield()
	{
		print("Shield Spawned");
		//Shield
	}
}
