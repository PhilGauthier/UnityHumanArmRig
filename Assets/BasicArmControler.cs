using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicArmControler : MonoBehaviour
{
    public Transform _upperArm;
    public Transform _foreArm;
    public Transform _hand;

    public Vector3 _upperArmOffset;    
    public Vector3 _foreArmOffset;    
    public Vector3 _handOffset;

    protected Vector3 _upperArmOriginal, _foreArmOriginal, _handOriginal;

    private void Start()
    {
        _upperArmOriginal = _upperArm.localEulerAngles;
        _foreArmOriginal = _foreArm.localEulerAngles;
        _handOriginal = _hand.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        _upperArm.localEulerAngles = _upperArmOriginal + _upperArmOffset;
        _foreArm.localEulerAngles = _foreArmOriginal + _foreArmOffset;
        _hand.localEulerAngles = _handOriginal + _handOffset;

    }
}
