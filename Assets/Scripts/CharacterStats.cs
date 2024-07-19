using System;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    [SerializeField] private float _hitPoints;

    public event Action HealthChanged;

    public float MaxHitPoints { get; private set; }
    public float HitPoints { get { return _hitPoints; } }    

    private void Awake()
    {
        MaxHitPoints = _hitPoints;
    }

    public void ChangeHitPoints(float changeAmount)
    {
        _hitPoints += changeAmount;

        HealthChanged?.Invoke();
    }
}