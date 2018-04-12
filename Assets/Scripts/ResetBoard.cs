namespace VRTK
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class ResetBoard : MonoBehaviour
    {
        // left and right motion controllers
        private VRTK_ControllerEvents[] controllers;

        // board which is being tilted
        public GameObject board;

        // Use this for initialization
        void Start()
        {
            // VRTK controller events for each controller
            controllers = GetComponentsInChildren<VRTK_ControllerEvents>();
        }

        // Update is called once per frame
        void Update()
        {
            // reset board orientation when trigger is FULLY pressed
            if (controllers[0].triggerClicked || controllers[1].triggerClicked)
            {
                board.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
            }
        }
    }
}