using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Answer")]
public class AnswerData : ScriptableObject {
	#region SerializeField

	[SerializeField]
	private string m_Answer;

	[SerializeField]
	bool m_IsCorrect;

	#endregion


	// Properties expose fields
	// getters & setters


	#region Public Properties

	public string Answer {
		get {
			if (string.IsNullOrEmpty(m_Answer)) {
				return "Invalid Data";
			}

			return m_Answer;
		}
	}

	public bool IsCorrect {
		get { return m_IsCorrect; }
	}

	#endregion
}