using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class MultiImageTrackingManager : MonoBehaviour
{
    [SerializeField] private GameObject[] arPrefabs; // Arraste seus 8 prefabs aqui no Inspetor
    private readonly Dictionary<string, GameObject> _instantiatedPrefabs = new Dictionary<string, GameObject>();
    private ARTrackedImageManager _imageManager;

    void Awake()
    {
        _imageManager = GetComponent<ARTrackedImageManager>();
    }

    void OnEnable()
    {
        _imageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }

    void OnDisable()
    {
        _imageManager.trackedImagesChanged -= OnTrackedImagesChanged;
    }

    void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        // Quando uma imagem nova é detectada
        foreach (var trackedImage in eventArgs.added)
        {
            var imageName = trackedImage.referenceImage.name;
            foreach (var prefab in arPrefabs)
            {
                if (string.Compare(prefab.name, imageName, System.StringComparison.OrdinalIgnoreCase) == 0 && !_instantiatedPrefabs.ContainsKey(imageName))
                {
                    var newPrefab = Instantiate(prefab, trackedImage.transform);
                    _instantiatedPrefabs.Add(imageName, newPrefab);
                }
            }
        }

        // Atualiza a posição e visibilidade enquanto a câmera se move
        foreach (var trackedImage in eventArgs.updated)
        {
            if (_instantiatedPrefabs.ContainsKey(trackedImage.referenceImage.name))
            {
                _instantiatedPrefabs[trackedImage.referenceImage.name].SetActive(trackedImage.trackingState == UnityEngine.XR.ARSubsystems.TrackingState.Tracking);
            }
        }
    }
}