using Unity.FPS.Game;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Unity.FPS.UI
{
    public class MainMenuManager : MonoBehaviour
    {
        // [Tooltip("Root GameObject of the menu used to toggle its activation")]
        // public GameObject MenuRoot;

        // [Tooltip("Master volume when menu is open")]
        // [Range(0.001f, 1f)]
        // public float VolumeWhenMenuOpen = 0.5f;

        [Tooltip("Toggle component for shadows")]
        public Toggle ShadowsToggle;

        // [Tooltip("GameObject for the controls")]
        // public GameObject ControlImage;

        void Awake()
        {
            ShadowsToggle.isOn = QualitySettings.shadows != ShadowQuality.Disable;
            ShadowsToggle.onValueChanged.AddListener(OnShadowsChanged);
        }

        // void Update()
        // {
        //     if (Input.GetButtonDown(GameConstants.k_ButtonNamePauseMenu)
        //         || (MenuRoot.activeSelf && Input.GetButtonDown(GameConstants.k_ButtonNameCancel)))
        //     {
        //         if (ControlImage.activeSelf)
        //         {
        //             ControlImage.SetActive(false);
        //             return;
        //         }

        //         SetPauseMenuActivation(!MenuRoot.activeSelf);

        //     }

        //     if (Input.GetAxisRaw(GameConstants.k_AxisNameVertical) != 0)
        //     {
        //         if (EventSystem.current.currentSelectedGameObject == null)
        //         {
        //             EventSystem.current.SetSelectedGameObject(null);
        //         }
        //     }
        // }

        // public void ClosePauseMenu()
        // {
        //     SetPauseMenuActivation(false);
        // }

        // void SetPauseMenuActivation(bool active)
        // {
        //     MenuRoot.SetActive(active);

        //     if (MenuRoot.activeSelf)
        //     {
        //         Cursor.lockState = CursorLockMode.None;
        //         Time.timeScale = 0f;
        //         AudioUtility.SetMasterVolume(VolumeWhenMenuOpen);

        //         EventSystem.current.SetSelectedGameObject(null);
        //     }
        //     else
        //     {
        //         Cursor.lockState = CursorLockMode.Locked;
        //         Time.timeScale = 1f;
        //         AudioUtility.SetMasterVolume(1);
        //     }

        // }

        void OnShadowsChanged(bool newValue)
        {
            QualitySettings.shadows = newValue ? ShadowQuality.All : ShadowQuality.Disable;
        }

        // public void OnShowControlButtonClicked(bool show)
        // {
        //     ControlImage.SetActive(show);
        // }
    }
}