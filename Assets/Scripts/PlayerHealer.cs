using UnityEngine;
using UnityEngine.UI;

public class PlayerHealer : MonoBehaviour
{
    [SerializeField] private CharacterStats _characterStats;
    [SerializeField] private float _healthHealAmount;
    [SerializeField] private Button _healerButton;

    private void OnEnable()
    {
        _healerButton.onClick.AddListener(HealPlayer);        
    }

    private void OnDisable()
    {
        _healerButton.onClick.RemoveListener(HealPlayer);        
    }

    private void HealPlayer() 
    {
        _characterStats.ChangeHitPoints(_healthHealAmount);    
    }
}
