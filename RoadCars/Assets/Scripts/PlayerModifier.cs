using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModifier : MonoBehaviour
{
    [SerializeField] int _weight;

    float _widthMultiplay = 0.0005f;

    [SerializeField] Renderer _renderer;

    [SerializeField] Transform _colliderTranform;

    [SerializeField] AudioSource _increaseSourse;

    private void Start()
    {
        SetWeight(Progress.Instance.Width);
    }

    private void Update()
    {

         if(Input.GetKeyDown(KeyCode.W))
        {
            AddWidth(20);
        }
    }

    public void AddWidth(int value)
    {
        _weight += value;
        UpdateWeight();
        if(value > 0)
        {
            _increaseSourse.Play();
        }
    }

    public void SetWeight(int value)
    {
        _weight += value;
        UpdateWeight();
    }

    public void HitBarrier()
    {
        
       if (_weight > 0)
        {
            _weight -= 50;
            UpdateWeight();
        }
        else
        {
            Die();
        }
    }

    void UpdateWeight()
    {
        _renderer.material.SetFloat("_PushValue", _weight * _widthMultiplay);
    }

    void Die()
    {
        FindObjectOfType<GameManager>().ShowFinishWindow();
        Destroy(gameObject);
    }
}
