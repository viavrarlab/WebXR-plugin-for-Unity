﻿using UnityEngine;
using WebXR;
using UnityEngine.Events;
using NaughtyAttributes;

namespace DaviisLV.WebXR
{
    [RequireComponent(typeof(WebXRController))]
    public class WebXRInteractionManagerBasic : MonoBehaviour
    {
        private WebXRController controller;
        private bool joystickY_InUse = false;
        private bool joystickX_InUse = false;
        private float joystickThreshold = 0.6f;
        private char leftController = 'L';
        private char rightController = 'R';
        private char controllerSide;
        private bool UseWrongInput = false;

        #region UnityEvents
        [Foldout("Trigger")]
        public UnityEvent OnTriggerDown = new UnityEvent();
        [Foldout("Trigger")]
        public UnityEvent OnTriggerUp = new UnityEvent();

        [Foldout("Primary button")]
        public UnityEvent OnBtn1Down = new UnityEvent();
        [Foldout("Primary button")]
        public UnityEvent OnBtn1Up = new UnityEvent();

        [Foldout("Secondary button")]
        public UnityEvent OnBtn2Down = new UnityEvent();
        [Foldout("Secondary button")]
        public UnityEvent OnBtn2Up = new UnityEvent();

        [Foldout("Grip")]
        public UnityEvent OnGripDown = new UnityEvent();
        [Foldout("Grip")]
        public UnityEvent OnGripUp = new UnityEvent();

        [Foldout("Touchpad/Joystick")]
        public UnityEvent OnTouchpadDown = new UnityEvent();
        [Foldout("Touchpad/Joystick")]
        public UnityEvent OnTouchpadUp = new UnityEvent();

        [Foldout("Joystick X")]
        public UnityEvent OnJoystickXPositive = new UnityEvent();
        [Foldout("Joystick X")]
        public UnityEvent OnJoystickXNegative = new UnityEvent();
        [Foldout("Joystick X")]
        public UnityEvent OnJoystickXRelease = new UnityEvent();

        [Foldout("Joystick Y")]
        public UnityEvent OnJoystickYPositive = new UnityEvent();
        [Foldout("Joystick Y")]
        public UnityEvent OnJoystickYNegative = new UnityEvent();
        [Foldout("Joystick Y")]
        public UnityEvent OnJoystickYRelease = new UnityEvent();

        [Foldout("Menu")]
        public UnityEvent OnMenuDown = new UnityEvent();
        #endregion

        void Awake()
        {
            controller = GetComponent<WebXRController>();
            if (controller.hand == WebXRControllerHand.RIGHT)
            {
#if UNITY_EDITOR
                UseWrongInput = false;
#elif UNITY_WEBGL
                UseWrongInput = true;
#endif
                controllerSide = rightController;
            }
            else
                controllerSide = leftController;
        }

        void Update()
        {
            #region Trigger btn
            if (controller.GetButtonUp("Trigger_btn_" + controllerSide))
                OnTriggerUp.Invoke();

            if (controller.GetButtonDown("Trigger_btn_" + controllerSide))
                OnTriggerDown.Invoke();
                
            #endregion
            #region Grip btn
            if (controller.GetButtonDown("Grip_btn_" + controllerSide))
                OnGripDown.Invoke();

            if (controller.GetButtonUp("Grip_btn_" + controllerSide))
                OnGripUp.Invoke();

            #endregion
            #region Touchpad/Joystick btn
            if (controller.GetButtonDown("Joystic_btn_" + controllerSide))
                if (UseWrongInput)
                    OnBtn1Down.Invoke();
                else
                    OnTouchpadDown.Invoke();

            if (controller.GetButtonUp("Joystic_btn_" + controllerSide))
                if (UseWrongInput)
                    OnBtn1Up.Invoke();
                else
                    OnTouchpadUp.Invoke();

            #endregion
            #region Joystick x axes
            float valueX = controller.GetAxis("Joystic_horizontal_" + controllerSide);
            if (valueX > joystickThreshold && joystickX_InUse == false)
            {
                joystickX_InUse = true;
                OnJoystickXPositive.Invoke();
            }
            else if (valueX < -joystickThreshold && joystickX_InUse == false)
            {
                joystickX_InUse = true;
                OnJoystickXNegative.Invoke();
            }
            if ((IsBetween(valueX, -joystickThreshold, joystickThreshold)) && joystickX_InUse == true)
            {
                joystickX_InUse = false;
                OnJoystickXRelease.Invoke();
            }

            #endregion
            #region Joystick y axes
            float valueY = controller.GetAxis("Joystic_vertical_" + controllerSide);
            if (valueY > joystickThreshold && joystickY_InUse == false)
            {
                joystickY_InUse = true;
                OnJoystickYPositive.Invoke();
            }
            else if (valueY < -joystickThreshold && joystickY_InUse == false)
            {
                joystickY_InUse = true;
                OnJoystickYNegative.Invoke();
            }
            if ((IsBetween(valueY, -joystickThreshold, joystickThreshold)) && joystickY_InUse == true)
            {
                joystickY_InUse = false;
                OnJoystickYRelease.Invoke();
            }

            #endregion
            #region Primary btn
            if (controller.GetButtonDown("1_btn_" + controllerSide))
                if (UseWrongInput)
                    OnTouchpadDown.Invoke();
                else
                    OnBtn1Down.Invoke();

            if (controller.GetButtonUp("1_btn_" + controllerSide))
                if (UseWrongInput)
                    OnTouchpadUp.Invoke();
                else
                    OnBtn1Up.Invoke();

            #endregion
            #region Secondary btn
            if (controller.GetButtonDown("2_btn_" + controllerSide))
                if (UseWrongInput)
                    OnBtn1Down.Invoke();
                else
                    OnBtn2Down.Invoke();

            if (controller.GetButtonUp("2_btn_" + controllerSide))
                if (UseWrongInput)
                    OnBtn1Up.Invoke();
                else
                    OnBtn2Up.Invoke();

            #endregion
            #region Menu 
            if (controller.GetButtonDown("Menu_btn_" + controllerSide))
                OnMenuDown.Invoke();

            #endregion
        }
        private bool IsBetween(double testValue, double bound1, double bound2)
        {
            if (bound1 > bound2)
                return testValue >= bound2 && testValue <= bound1;
            return testValue >= bound1 && testValue <= bound2;
        }
    }
}
