using TMPro;
using UnityEngine;

public class HealthTextChanger : MonoBehaviour
{
    [SerializeField] private TMP_Text _currentHealth;
    [SerializeField] private TMP_Text _maxHealth;
    [SerializeField] private CharacterStats _playerStats;
    [SerializeField] private float _healthColorChangeBreakPoint;
    [SerializeField] private Color _lowHealthColor;

    private void Awake()
    {
        _maxHealth.text = _playerStats.MaxHitPoints.ToString();
    }

    private void OnEnable()
    {
        _playerStats.HealthChanged += ChangeHealth;
    }

    private void OnDisable()
    {
        _playerStats.HealthChanged -= ChangeHealth;
    }

    private void ChangeHealth() 
    {
        _currentHealth.text = _playerStats.HitPoints.ToString();
        
        if (_playerStats.HitPoints/_playerStats.MaxHitPoints <= _healthColorChangeBreakPoint) 
        {
            _currentHealth.color = _lowHealthColor;        
        }
    }
}
