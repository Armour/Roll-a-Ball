using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(PlayerController))]
public class PlayerEditor : Editor {

	public override void OnInspectorGUI() {
		base.OnInspectorGUI();

		PlayerController myTarget = (PlayerController)target;
		EditorGUILayout.LabelField("Test Custom Editor", myTarget.speed.ToString());
		if (GUILayout.Button("Custom Button!")) {
			Debug.Log("This is the test custom button");
		}
	}
}
