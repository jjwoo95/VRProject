namespace VRTK
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class ScalePlayer : MonoBehaviour
    {
        // player's current position
        public GameObject cameraRig;

        // left and right motion controllers
        private VRTK_ControllerEvents[] controllers;

        // change the size of the player
        public float maxSize = 5.0f;
        public float smallestSize = 0.1f;
        public float changeSizeRate = 0.01f;

        // movement speed of player
        private VRTK_MoveInPlace playerMovement;
        public float movementSpeedChangeRate = 0.01f;

        // speed at which player changes sizes
        public float cooldownTime = 0.001F;
        private float currentTimeDuringCooldown = 0.0F;

        // Use this for initialization
        void Start()
        {
            // VRTK controller events for each controller
            controllers = GetComponentsInChildren<VRTK_ControllerEvents>();

            // VRTK component which controls movement speed
            playerMovement = GetComponentInChildren<VRTK_MoveInPlace>();
        }

        // Update is called once per frame
        void Update()
        {
            // shrink player size if they can still become smaller
            if (controllers[0].triggerClicked && cameraRig.transform.localScale.x > smallestSize && Time.time > currentTimeDuringCooldown)
            {
                // make player smaller
                cameraRig.transform.localScale = new Vector3(cameraRig.transform.localScale.x - changeSizeRate, cameraRig.transform.localScale.y - changeSizeRate, cameraRig.transform.localScale.z - changeSizeRate);

                // make player move slower
                playerMovement.speedScale -= movementSpeedChangeRate;

                // start cooldown time for next time player can change size
                currentTimeDuringCooldown = Time.time + cooldownTime;
            }

            // grow player size if they can grow larger
            else if (controllers[1].triggerClicked && cameraRig.transform.localScale.x < maxSize && Time.time > currentTimeDuringCooldown)
            {
                // make player larger
                cameraRig.transform.localScale = new Vector3(cameraRig.transform.localScale.x + changeSizeRate, cameraRig.transform.localScale.y + changeSizeRate, cameraRig.transform.localScale.z + changeSizeRate);

                // make player move faster
                playerMovement.speedScale += movementSpeedChangeRate;

                // start cooldown time for next time player can change size
                currentTimeDuringCooldown = Time.time + cooldownTime;
            }
        }
    }
}
