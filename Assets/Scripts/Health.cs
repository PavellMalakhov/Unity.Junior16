using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    [SerializeField] private float _health = 100f;
    [SerializeField] private float _healthMax = 100f;
    [SerializeField] private float _healthMin = 0f;

    public event Action<float, float> HealthChanged;

    private void Start()
    {
        HealthChanged?.Invoke(_health, _healthMax);
    }

    public void AddHealth(float amountHealth)
    {
        if (amountHealth > _healthMin)
        {
            _health = Mathf.Clamp(_health += amountHealth, _healthMin, _healthMax);

            HealthChanged?.Invoke(_health, _healthMax);
        }
    }

    public void TakeDamage(float damage)
    {
        _health = Mathf.Clamp(_health -= damage, _healthMin, _healthMax);

        HealthChanged?.Invoke(_health, _healthMax);
    }
}
