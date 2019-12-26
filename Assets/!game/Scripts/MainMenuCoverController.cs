using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCoverController : MonoBehaviour {
    public List<GameObject> objects = new List<GameObject>();

    private void Start() {
        int randomNumber = Random.Range(0, objects.Count + 1);
        for (int i = 0; i < objects.Count; i++) {
            if(i == randomNumber) {
                objects[i].SetActive(true);
            }
            else {
                objects[i].SetActive(false);
            }
        }
    }
}
