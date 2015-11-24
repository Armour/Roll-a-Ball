using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(PlayerController))]
public class PlayerEditor : Editor {

	public override void OnInspectorGUI() {
		DrawDefaultInspector();

		PlayerController myTarget = (PlayerController)target; 
		EditorGUILayout.LabelField("Test Custom Editor", myTarget.speed.ToString());
		if (GUILayout.Button("Custom Button!")) {
			Debug.Log("This is the test custom button");
		}
	}
}
