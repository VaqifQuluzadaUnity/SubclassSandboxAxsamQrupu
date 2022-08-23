using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicController : MonoBehaviour
{
  [SerializeField] private GameObject[] obtainedSpells;

  [SerializeField] private Button[] spellActivateButtons;

  [SerializeField] private AudioSource spellSource;

  [SerializeField] private Animator characterAnimator;

  [SerializeField] private Transform characterTransform;

  [SerializeField] private Transform enemyTransform;

	private void Start()
	{
		for(int i = 0; i < obtainedSpells.Length; i++)
		{
			Transform targetReference;

			if (obtainedSpells[i].GetComponent<MagicSpell>().isTarget)
			{
				targetReference = enemyTransform;
			}
			else
			{
				targetReference = characterTransform;
			}

			GameObject spellInstance = Instantiate(obtainedSpells[i], transform);

			spellInstance.GetComponent<MagicSpell>().SetupEffect(characterAnimator, spellSource, targetReference);

			spellActivateButtons[i].onClick.AddListener(delegate { OnSpellButtonPressed(spellInstance.GetComponent<MagicSpell>());});
		}
	}

	private void OnSpellButtonPressed(MagicSpell spell)
	{
		spell.Activate();
	}
} 
