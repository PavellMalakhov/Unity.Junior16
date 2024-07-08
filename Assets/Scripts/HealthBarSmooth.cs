using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthBarSmooth : EventHandler
{
    [SerializeField] private Slider _slider;

    private float _targetHealth;

    protected override void RenderHealh(float health, float healthMax)
    {
        _targetHealth = health / healthMax;

        StartCoroutine(SmoothRenderHealh(_targetHealth));
    }

    private IEnumerator SmoothRenderHealh(float targetHealth)
    {
        var wait = new WaitForEndOfFrame();

        while (_slider.value != targetHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, targetHealth, Time.deltaTime);

            yield return wait;
        }
    }
}