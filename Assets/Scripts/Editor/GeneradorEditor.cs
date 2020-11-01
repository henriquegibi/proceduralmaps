using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Runtime;

[CustomEditor(typeof(Generador))]
public class GeneradorEditor : Editor
{
   public override void OnInspectorGUI()
    {
        Generador generador = (Generador)target;

        if(GUILayout.Button("Generar Mapa"))
        {
            generador.GenerarMapa();
        }

        if(GUILayout.Button("Limpiar Mapa"))
        {
            generador.LimpiarMapa();
        }

        base.OnInspectorGUI();
    }
}