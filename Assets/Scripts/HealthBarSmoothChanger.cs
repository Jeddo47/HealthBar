using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarSmoothChanger : GeneralHealthDisplayer
{    
    [SerializeField] private Slider _healthBar;
    [SerializeField] private float _healthBarFillDelay;
    [SerializeField] private float _healthBarFillSpeed;

    protected override void ChangeHealthDisplay()
    {
        StartCoroutine(HealthBarFill());
    }

    private IEnumerator HealthBarFill() 
    {
        WaitForSeconds wait = new WaitForSeconds(_healthBarFillDelay);

        while (_healthBar.value != _playerStats.HitPoints / _playerStats.MaxHitPoints) 
        {
            _healthBar.value = Mathf.MoveTowards(_healthBar.value, _playerStats.HitPoints / _playerStats.MaxHitPoints, _healthBarFillSpeed);

            yield return wait;
        }        
    }
}
