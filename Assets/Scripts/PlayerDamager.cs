using UnityEngine;
using UnityEngine.UI;

public class PlayerDamager : MonoBehaviour
{
    [SerializeField] private CharacterStats _playerStats;
    [SerializeField] private float _damage;
    [SerializeField] private Button _dealDamageButton;

    private void OnEnable()
    {
        _dealDamageButton.onClick.AddListener(DealDamage);        
    }

    private void OnDisable()
    {
        _dealDamageButton.onClick.RemoveListener(DealDamage);
    }

    public void DealDamage() 
    {
        _playerStats.ChangeHitPoints(-_damage);
    }
}
