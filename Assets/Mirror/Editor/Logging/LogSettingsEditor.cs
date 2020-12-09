using Mirror.Logging;
using UnityEditor;
using UnityEngine;

namespace Mirror.Editor.Logging
{
    [CustomEditor(typeof(LogSettings))]
    public class LogSettingsEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            CurrentScriptField();

            LogLevelsGUI.DrawLogFactoryDictionary(target as LogSettings);
        }

        public void CurrentScriptField()
        {
            GUI.enabled = false;
            EditorGUILayout.PropertyField(serializedObject.FindProperty("m_Script"));
            GUI.enabled = true;
        }
    }
}
