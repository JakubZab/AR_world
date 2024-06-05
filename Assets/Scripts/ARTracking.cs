using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.XR;

public class ARTracking : MonoBehaviour
{
    public ARTrackedImageManager trackedImageManager;
    public GameObject wolfPrefab;
    public GameObject griffPrefab;
    public GameObject snakePrefab;
    public GameObject catPrefab;
    public GameObject bearPrefab;

    private Dictionary<string, GameObject> characterPrefabs;

    private void Awake()
    {
        characterPrefabs = new Dictionary<string, GameObject>
        {
            { "wolf", wolfPrefab },
            { "griff", griffPrefab },
            { "snake", snakePrefab },
            { "cat", catPrefab },
            { "bear", bearPrefab }
        };
    }

    public void OnEnable()
    {
        trackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }

    public void OnDisable()
    {
        trackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
    }

    private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        string selectedCharacter = PlayerPrefs.GetString("SelectedCharacter");

        foreach (var trackedImage in eventArgs.added)
        {
            if (characterPrefabs.ContainsKey(trackedImage.referenceImage.name))
            {
                Instantiate(characterPrefabs[trackedImage.referenceImage.name], trackedImage.transform.position, trackedImage.transform.rotation);
            }
        }

        foreach (var trackedImage in eventArgs.updated)
        {
            if (trackedImage.trackingState == TrackingState.Tracking)
            {
                // Update the position and rotation of the instantiated prefabs if necessary
            }
        }

        foreach (var trackedImage in eventArgs.removed)
        {
            // Handle removal of tracked images if necessary
        }
    }
}