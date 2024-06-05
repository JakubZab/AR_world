using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ImageTrackingAndCharacterPlacement : MonoBehaviour
{
    public ARTrackedImageManager trackedImageManager;
    public GameObject wolfPrefab;  // Prefab postaci dla szko³y wilka
    private GameObject spawnedCharacter;

    void OnEnable()
    {
        trackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }

    void OnDisable()
    {
        trackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
    }

    private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (var trackedImage in eventArgs.added)
        {
            if (trackedImage.referenceImage.name == "Wilk")  // Nazwa obrazu w bibliotece obrazów
            {
                if (spawnedCharacter == null)
                {
                    spawnedCharacter = Instantiate(wolfPrefab, trackedImage.transform.position, trackedImage.transform.rotation);
                }
            }
        }

        foreach (var trackedImage in eventArgs.updated)
        {
            if (trackedImage.referenceImage.name == "Wilk" && spawnedCharacter != null)
            {
                spawnedCharacter.transform.position = trackedImage.transform.position;
                spawnedCharacter.transform.rotation = trackedImage.transform.rotation;
            }
        }

        foreach (var trackedImage in eventArgs.removed)
        {
            if (trackedImage.referenceImage.name == "Wilk" && spawnedCharacter != null)
            {
                Destroy(spawnedCharacter);
                spawnedCharacter = null;
            }
        }
    }
}
