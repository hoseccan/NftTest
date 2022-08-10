using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using Cinemachine;

public class CameraModSwitcher : MonoBehaviour
{
    private StarterAssetsInputs _input;
    private bool isFP;

    [SerializeField] CinemachineVirtualCamera virtualCamera;

    [Header("ThirdPersonCameraSettings")]
    [SerializeField] private float cameraDistTP;

    [Header("FirstPersonCameraSettings")]
    [SerializeField] private float cameraDistFP;


    void Start()
    {
        _input = GetComponent<StarterAssetsInputs>();
    }
    void Update()
    {
        if (_input.cameraSwitch)
        {
            print("CameraSwitched");

            if (!isFP)
            {
                virtualCamera.GetCinemachineComponent<Cinemachine3rdPersonFollow>().CameraDistance = cameraDistFP;
                isFP = true;
            }
            else
            {
                virtualCamera.GetCinemachineComponent<Cinemachine3rdPersonFollow>().CameraDistance = cameraDistTP;
                isFP = false;
            }

            _input.cameraSwitch = false;
        }
    }
}
