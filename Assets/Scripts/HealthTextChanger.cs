using TMPro;
using UnityEngine;

public class HealthTextChanger : GeneralHealthDisplayer
{
    [SerializeField] private TMP_Text _currentHealth;
    [SerializeField] private TMP_Text _maxHealth;
    [SerializeField] private float _healthColorChangeBreakPoint;
    [SerializeField] private Color _lowHealthColor;
    [SerializeField] private Color _defaultColor;

    private void Awake()
    {
        _maxHealth.text = _playerStats.MaxHitPoints.ToString();
    }

    protected override void ChangeHealthDisplay()
    {
        _currentHealth.text = _playerStats.HitPoints.ToString();

        if (_playerStats.HitPoints / _playerStats.MaxHitPoints <= _healthColorChangeBreakPoint)
        {
            _currentHealth.color = _lowHealthColor;
        }
        else
        {
            _currentHealth.color = _defaultColor;
        }
    }
}
