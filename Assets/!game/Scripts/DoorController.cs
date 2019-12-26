using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {
    [SerializeField] private bool _startDoor;
    private Animator _animator;

    private void Start() {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            _animator.SetTrigger("OpenDoor");
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag == "Player") {
            _animator.SetTrigger("CloseDoor");
        }
    }
}
