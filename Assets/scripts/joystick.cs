using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody),typeof(BoxCollider))]
public class joystick : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private Animator _animator;
    [SerializeField] private float hiz;


    void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_joystick.Horizontal*hiz, 0, _joystick.Vertical*hiz);
        if(_joystick.Horizontal!=0 || _joystick.Vertical!=0)
        {
          
            
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity); //rigidbody hýzý(velocity) ile dön
            
            _animator.SetBool("isRunning", true);


        }
        else 
            _animator.SetBool("isRunning", false);
    }
}
