using UnityEngine;
using UnityEngine.UI;

public class HealthBarChanger : MonoBehaviour
{
    [SerializeField] private CharacterStats _playerStats;
    [SerializeField] private Slider _healthBar;

    private void OnEnable()
    {
        _playerStats.HealthChanged += ChangeHealthBar;
    }

    private void OnDisable()
    {
        _playerStats.HealthChanged -= ChangeHealthBar;
    }

    public void ChangeHealthBar() 
    {
        _healthBar.value = _playerStats.HitPoints/_playerStats.MaxHitPoints;    
    }
}
