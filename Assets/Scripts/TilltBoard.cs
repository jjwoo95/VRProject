namespace VRTK
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class TilltBoard : MonoBehaviour
    {
        // board which is being tilted
        public GameObject board;

        // for moving ball left and right
        public float roll = 1f;

        // for moving ball up and down
        public float pitch = 1f;

        // Axes of rotation for player
        private Quaternion previousRotation;
        private float previousRotationX;
        private float previousRotationY;
        private float previousRotationZ;

        // threshold for tilting player's head
        public float tiltHeadThreshold = 1f;

        // Use this for initialization
        void Start()
        {
            previousRotation = transform.rotation;
        }

        // Update is called once per frame
        void Update()
        {
            if (transform.rotation.x > previousRotation.x + tiltHeadThreshold)
            {
                //previousRotation = transform.rotation;
                previousRotationX = transform.rotation.x;
                previousRotation.x = previousRotationX;
                board.transform.Rotate(pitch, 0, 0);
            }

            if (transform.rotation.x < previousRotation.x - tiltHeadThreshold)
            {
                //previousRotation = transform.rotation;
                previousRotationX = transform.rotation.x;
                previousRotation.x = previousRotationX;
                board.transform.Rotate(-pitch, 0, 0);
            }

            if (transform.rotation.z > previousRotation.z + tiltHeadThreshold)
            {
                //previousRotation = transform.rotation;
                previousRotationZ = transform.rotation.z;
                previousRotation.z = previousRotationZ;
                board.transform.Rotate(0, 0, roll);
            }

            if (transform.rotation.z < previousRotation.z - tiltHeadThreshold)
            {
                //previousRotation = transform.rotation;
                previousRotationZ = transform.rotation.z;
                previousRotation.z = previousRotationZ;
                board.transform.Rotate(0, 0, -roll);
            }
        }
    }
}
