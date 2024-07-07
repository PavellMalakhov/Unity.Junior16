using UnityEngine;
using TMPro;

public class CurrentMaxHealth : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _currentMaxHealth;
    [SerializeField] private Health _health;

    private void OnEnable()
    {
        _health.HealthChanged += RenderHealh;
    }

    private void OnDisable()
    {
        _health.HealthChanged -= RenderHealh;
    }

    private void RenderHealh(float health, float healthMax)
    {
        _currentMaxHealth.text = health + " / " + healthMax;
    }
}
