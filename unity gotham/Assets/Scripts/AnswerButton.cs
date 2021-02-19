using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class AnswerButton : MonoBehaviour {
	#region SerializeFields

	//serialisedField expose a private variable to the inspector window in unity.
	[SerializeField]
	private Text m_AnswerText;


	[SerializeField]
	private Sprite m_CheckMarkSprite;

	[SerializeField]
	private Sprite m_ExMarkSprite;

	#endregion


	#region Private/Internal Fields

	private Image m_Image;
	private AnswerData _mAnswerData;

	#endregion


	#region Public Methods/Functions

	public void Initialized(AnswerData answerData) {
		_mAnswerData = answerData;
		m_AnswerText.text = answerData.Answer;
	}

	#endregion


	#region MonoBehaviour Methods

	private void Awake() {
		m_Image = GetComponent<Image>();
	}

	#endregion


	#region public methods

	public void AnswerClicked() {
		if (_mAnswerData.IsCorrect) {
			Debug.Log("Correct");
			ApplingCheckMark();
		} else {
			Debug.Log("Wrong");
			ApplingExMark();
		}
	}

	#endregion


	#region Internal Methods/Functions

	private void ApplingCheckMark() {
		m_Image.sprite = m_CheckMarkSprite;
		m_AnswerText.text = string.Empty;
	}

	private void ApplingExMark() {
		m_Image.sprite = m_ExMarkSprite;
		m_AnswerText.text = "";
	}

	#endregion
}