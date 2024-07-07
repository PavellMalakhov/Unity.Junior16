using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Slider _slider;

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
        _slider.value = health / healthMax;
    }
}
