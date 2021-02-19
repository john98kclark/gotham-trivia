using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	[SerializeField]
	Question m_Questions;

	[SerializeField]
	private QuestionData[] m_QuestionsData;


	#region MonoBehaviour Methods

	private void Start() {
		m_Questions.Initialize(m_QuestionsData[0]);
	}

	#endregion
}