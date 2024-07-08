using UnityEngine;
using UnityEngine.UI;

public class HealthBarSmooth : EventHandler
{
    [SerializeField] private Slider _slider;

    private float _targetHealth;

    private void Update()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _targetHealth, Time.deltaTime);
    }

    protected override void RenderHealh(float health, float healthMax)
    {
        _targetHealth = health / healthMax;
    }
}