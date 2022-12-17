using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCharge : MonoBehaviour
{
    //Slider healthbar tells sets which Slider to modify
    [SerializeField] Slider healthbar;
    //Sets Starting health value to 100
    float health_value = 100;
    //Stores changed health value
    public float current_health;

    //On start sets health value
    void Start()
    {
        current_health = health_value;
    }

    //On Collision subtracts health every time player Collides
    void OnCollisionEnter2D(Collision2D col)
    {
        current_health -= 32;
        healthbar.value = current_health;
    }
}
