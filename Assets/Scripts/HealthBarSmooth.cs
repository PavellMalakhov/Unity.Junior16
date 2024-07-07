using UnityEngine;
using UnityEngine.UI;

public class HealthBarSmooth : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Slider _slider;

    private float _targetHealth;

    private void OnEnable()
    {
        _health.HealthChanged += SetTargetHealh;
    }

    private void OnDisable()
    {
        _health.HealthChanged -= SetTargetHealh;
    }

    private void Update()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _targetHealth, Time.deltaTime);
    }

    private void SetTargetHealh(float health, float healthMax)
    {
        _targetHealth = health / healthMax;
    }
}
