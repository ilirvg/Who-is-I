using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public HealthBar healthBar;
    private int _health = 100;

    public void DmgTaken(int dmg) {
        _health -= dmg;
        healthBar.SetHealthBar(_health);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.transform.tag == "Enemy") {
            DmgTaken(1);
        }
    }

}
