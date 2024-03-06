using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankPotion : Item {
    [SerializeField] float HealthIncreasePercentage;
    public override void OnPickUp(Collision2D collision) {
        var damageable = collision.gameObject.GetComponent<IDamageable>();
        if (damageable != null && damageable is PlayerHealth) {
            ((PlayerHealth)damageable).IncreaseMaxHealth(damageable.MaxHealth * (HealthIncreasePercentage / 100));
        }

        base.OnPickUp(collision);
    }
}