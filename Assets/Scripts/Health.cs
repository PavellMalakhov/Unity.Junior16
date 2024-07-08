using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    [SerializeField] private float _healthCurrent = 100f;
    [SerializeField] private float _healthMax = 100f;
    [SerializeField] private float _healthMin = 0f;

    public event Action<float, float> HealthChanged;

    private void Start()
    {
        HealthChanged?.Invoke(_healthCurrent, _healthMax);
    }

    public void AddHealth(float amountHealth)
    {
        if (amountHealth > _healthMin)
        {
            _healthCurrent = Mathf.Clamp(_healthCurrent += amountHealth, _healthMin, _healthMax);

            HealthChanged?.Invoke(_healthCurrent, _healthMax);
        }
    }

    public void TakeDamage(float damage)
    {
        _healthCurrent = Mathf.Clamp(_healthCurrent -= damage, _healthMin, _healthMax);

        HealthChanged?.Invoke(_healthCurrent, _healthMax);
    }
}