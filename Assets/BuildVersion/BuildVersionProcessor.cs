#if UNITY_EDITOR
using System.IO;

using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class BuildVersionProcessor : IPreprocessBuildWithReport
{
    public int callbackOrder => 0;

    public void OnPreprocessBuild(BuildReport report)
    {
        PlayerSettings.bundleVersion = Git.BuildVersionWithHash;
    }
}
#endif
