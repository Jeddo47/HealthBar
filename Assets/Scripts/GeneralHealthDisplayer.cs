using UnityEngine;

public class GeneralHealthDisplayer : MonoBehaviour
{
    [SerializeField] protected CharacterStats _playerStats;

    private void OnEnable()
    {
        _playerStats.HealthChanged += ChangeHealthDisplay;
    }

    private void OnDisable()
    {
        _playerStats.HealthChanged -= ChangeHealthDisplay;
    }

    protected virtual void ChangeHealthDisplay() { }
}
