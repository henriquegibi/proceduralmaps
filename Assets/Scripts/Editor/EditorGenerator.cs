using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Generator))]
public class EditorGenerator : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Generator generator = (Generator)target;

        if (GUILayout.Button("Generate Map"))
        {
            generator.GenerateMap();
        }

        if (GUILayout.Button("Clean Map"))
        {
            generator.CleanMap();
        }
    }
}
