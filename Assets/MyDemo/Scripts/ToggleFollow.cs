using UnityEngine;
using UnityEngine.UIElements;

public class ToggleFollow : MonoBehaviour
{
    [SerializeField] private Transform targetCamera;
    [SerializeField] private float distance = 2f;
    [SerializeField] private float heightOffset = 0f;
    [SerializeField] private float smoothSpeed = 8f;
    [SerializeField] private UIDocument targetDocument;

    private Toggle toggleFollow;
    private bool followEnabled = false;

    void Start()
    {
        if(!targetCamera)
            targetCamera = Camera.main.transform;

        var root = targetDocument.rootVisualElement;
        toggleFollow = root.Q<Toggle>("ToggleLock");

        toggleFollow.value = followEnabled;

        Debug.Log("FollowEnabled: " +followEnabled);
        toggleFollow.RegisterValueChangedCallback(OnToggleChanged);
    }

    private void LateUpdate()
    {
        if (!followEnabled || !targetCamera)
            return;
        
        Vector3 targetPosition =
            targetCamera.position +
            targetCamera.forward * distance;

        targetPosition.y += heightOffset;

        transform.position = Vector3.Lerp(
            transform.position,
            targetPosition,
            Time.deltaTime * smoothSpeed
        );

        // Face the camera
        transform.rotation = Quaternion.Lerp(
            transform.rotation,
            Quaternion.LookRotation(
                transform.position - targetCamera.position
            ),
            Time.deltaTime * smoothSpeed
        );
    }

    void OnToggleChanged (ChangeEvent<bool> toggle)
    {
        Debug.Log(toggle.ToString());
        
        followEnabled = toggle.newValue;

        Debug.Log("FollowEnabled: " + followEnabled);
    }
}
