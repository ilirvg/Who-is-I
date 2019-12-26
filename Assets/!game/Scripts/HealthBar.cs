using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {
    public Image healthBar;

    private int min = 0;
    private int max = 100;

    private int currentValue;
    private float currentPercentage;

    public void SetHealthBar(int health) {
        if(health != currentValue) {
            if(max - min == 0) {
                currentValue = 0;
                currentPercentage = 0;
            }
            else {
                currentValue = health;
                currentPercentage = (float)currentValue / (float)(max - min);
            }
            healthBar.fillAmount = currentPercentage;
        }
    }
}
