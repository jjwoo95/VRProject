namespace VRTK
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class PickUpObject : MonoBehaviour
    {
        // player's current size
        public GameObject cameraRig;

        // object which is being grabbed
        private VRTK_InteractableObject interactableObject;

        // size player must ne to grab object
        public float requiredPlayerSize = 1.1f;

        // Use this for initialization
        void Start()
        {
            // get component to grab an object
            interactableObject = GetComponent<VRTK_InteractableObject>();
        }

        // Update is called once per frame
        void Update()
        {
            // check to see if player is large enough to grab object
            if(cameraRig.transform.localScale.y >= requiredPlayerSize)
            {
                // allow player to grab object
                interactableObject.isGrabbable = true;
            }

            // check to see if player is to small to grab object
            else if (cameraRig.transform.localScale.y < requiredPlayerSize)
            {
                // don't allow player to grab object
                interactableObject.isGrabbable = false;
            }
        }
    }
}
