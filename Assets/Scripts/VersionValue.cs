using UnityEngine;

public class VersionValue : MonoBehaviour
{
    public string Value;

    private void Awake()
    {
        Value = Application.version;
    }
}
