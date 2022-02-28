using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    private Animator _animator;
    private bool _isWalking;

    private bool IsWalking
    {
        get => _isWalking;
        set
        {
            if (_isWalking == value)
                return;

            _isWalking = value;
            _animator.SetBool("IsWalking", _isWalking);
        }
    }

    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        var moveInput = Input.GetAxis("Move");
        IsWalking = moveInput != 0;
        

    }
}
