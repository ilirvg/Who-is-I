using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour {

    //NavMesh
    private NavMeshAgent _enemyNav;
    [SerializeField] GameObject _player = null;
    [SerializeField] float _distanceToFollow = 10;

    //Animation
    private static Animator _anim;

    private void Start() {
        _anim = GetComponent<Animator>();
        _enemyNav = GetComponent<NavMeshAgent>();
    }

    private void Update() {
        float _distance = Vector3.Distance(transform.position, _player.transform.position);
        if(_distance < _distanceToFollow) {
            Vector3 _direction = transform.position - _player.transform.position;
            Vector3 _newPosition = transform.position - _direction;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(-_direction), 0.1f);
            _enemyNav.SetDestination(_newPosition);

            _anim.SetBool("IsIdle", false);
            
            if (_distance > 3.5) {
                if (_enemyNav.velocity == Vector3.zero) {
                    _anim.SetBool("IsAttacking", false);
                    _anim.SetBool("IsWalking", false);
                    _anim.SetBool("IsIdle", true);
                }
                else {
                    _anim.SetBool("IsWalking", true);
                    _anim.SetBool("IsAttacking", false);
                }
            }
            else {
                _anim.SetBool("IsWalking", false);
                _anim.SetBool("IsAttacking", true);
            }
                
        }
        else {
            _anim.SetBool("IsIdle", true);
            _anim.SetBool("IsWalking", false);
            _anim.SetBool("IsAttacking", false);
        }
        //Debug.Log(_anim.GetBool("IsIdle"));
        
    }
}
