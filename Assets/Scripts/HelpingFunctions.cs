using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HelpingFunctions : MonoBehaviour
{
    public void ExitPlayMode()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    public void ResetSocketObject(Transform SocketObject, Transform resetPosition)
    {
        XRGrabInteractable _grab = SocketObject.GetComponent<XRGrabInteractable>();

        if (_grab != null)
        {
            // If the object is currently being held, release it
            _grab.interactionManager.CancelInteractorSelection(_grab.firstInteractorSelecting);

            // Reset the object's position and rotation
            SocketObject.position = resetPosition.position;
            SocketObject.rotation = resetPosition.rotation;
        }
    }

}
