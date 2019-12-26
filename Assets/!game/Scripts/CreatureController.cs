using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CreatureController : MonoBehaviour {
    

    private BreadcrumbAi.Ai _ai;
    private AudioSource _audio;
    private Animator _anim;

    //Wrist Colliders
    public Collider rWrist;
    public Collider lWrist;

    //Audio clips
    private AudioClip _walkClip;
    private AudioClip _attackClip;

    private int _state = 0;
    private int _savedState = 0;


    private void Start() {
        _ai = GetComponentInParent<BreadcrumbAi.Ai>();
        _audio = GetComponent<AudioSource>();
        _anim = GetComponent<Animator>();

        _walkClip = (AudioClip)Resources.Load("Sounds/walk");
        _attackClip = (AudioClip)Resources.Load("Sounds/attack");
    }

    private void Update() {
        if (_ai.attackState == BreadcrumbAi.Ai.ATTACK_STATE.CanAttackPlayer && _state != 0) {
           
            //_audio.Stop();
            _state = 0;
            _anim.SetBool("IsAttacking", true);
            _anim.SetBool("IsWalking", false);
            _anim.SetBool("IsIdle", false);
            if (!_audio.isPlaying || _audio.clip != _attackClip)
                StartCoroutine(PlayerWithDelay(0.8f, _attackClip));

        }
        else if (_ai.attackState == BreadcrumbAi.Ai.ATTACK_STATE.CanNotAttack && _state != 1) {
            
            //_audio.Stop();
            _state = 1;
            _anim.SetBool("IsAttacking", false);
            _anim.SetBool("IsWalking", true);
            _anim.SetBool("IsIdle", false);

            if (!_audio.isPlaying || _audio.clip != _walkClip)
                StartCoroutine(PlayerWithDelay(0f, _walkClip));

        }
        if (_ai.moveState == BreadcrumbAi.Ai.MOVEMENT_STATE.IsIdle && _ai.attackState == BreadcrumbAi.Ai.ATTACK_STATE.CanNotAttack && _state != 2) {
            _state = 2;
            _anim.SetBool("IsAttacking", false);
            _anim.SetBool("IsWalking", false);
            _anim.SetBool("IsIdle", true);
            if (_audio.isPlaying) {
                _audio.Stop();
            }
        }
    }

    IEnumerator PlayerWithDelay(float time, AudioClip clip) {
        if(_state == 0) {
            _audio.clip = clip;
            _audio.loop = false;
            _audio.Play();
            while (_state == 0) {
                yield return new WaitForSeconds(time);
                if(!_audio.isPlaying)
                    _audio.Play();
            }
        }
        else {
            _audio.clip = clip;
            _audio.loop = true;
            _audio.Play();
        }
       
    }

    //Animation Events
    public void ActivateWrist() {
        rWrist.enabled = true;
        lWrist.enabled = true;
    }
    //Animation Events
    public void DeactivateWrist() {
        rWrist.enabled = false;
        lWrist.enabled = false;
    }
}
