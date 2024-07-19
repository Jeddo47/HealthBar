using UnityEngine;
using UnityEngine.UI;

public class HealthBarChanger : GeneralHealthDisplayer
{
    [SerializeField] private Slider _healthBar;

    protected override void ChangeHealthDisplay()
    {
        _healthBar.value = _playerStats.HitPoints / _playerStats.MaxHitPoints;
    }
}
