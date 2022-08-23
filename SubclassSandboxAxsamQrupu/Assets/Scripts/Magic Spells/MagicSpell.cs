using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicSpell : MonoBehaviour
{
  [SerializeField] private string spellAnimationString;

  

  [SerializeField] private AudioClip spellSfx;


  [SerializeField] private GameObject spellVFX;

  public bool isTarget;

  private AudioSource spellAudioSource;

  private Animator characterAnimator;

  private Transform vfxTarget;

 

  public virtual void Activate()
	{
    SpawnParticle();
	}

  public virtual void SpawnParticle()
	{
    GameObject spellVFXInstance = Instantiate(spellVFX, vfxTarget);

    spellVFXInstance.GetComponent<ParticleSystem>().Play();
	}

  public virtual void PlaySound()
	{
    spellAudioSource.clip = spellSfx;

    spellAudioSource.Play();
	}

  public virtual void PlayAnimation()
	{
    characterAnimator.Play(spellAnimationString);
	}

  public void SetupEffect(Animator _animator, AudioSource _sfxSource, Transform _target)
	{
    characterAnimator = _animator;

    spellAudioSource = _sfxSource;

    vfxTarget = _target;
	}


}
