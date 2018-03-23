using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DemoSceneDirector : MonoBehaviour {

	// --------
	#region インスペクタ設定用フィールド
	[SerializeField] Text m_ByteTextLandscape;
	[SerializeField] Text m_ByteTextPortrait;
	#endregion

	// --------
	#region メンバフィールド
	/// <summary> 
	/// 
	/// </summary>
	private float m_Timeout = 3.0f;
	private float m_TimeElapsed;
	#endregion

	// --------
	#region MonoBehaviourメソッド
	/// <summary> 
	/// 初期化処理
	/// </summary>
	void Awake() {

	}
	/// <summary> 
	/// 開始処理
	/// </summary>
	void Start () {
		ulong num;
		num = MobileStorageChecker.StorageAvailable;

		Debug.Log ("MOB^num:"+num);
		Debug.Log ("MOB^num type:"+num.GetType ());

		m_ByteTextLandscape.text = num.ToString();
		m_ByteTextPortrait.text = num.ToString ();

	}
	/// <summary> 
	/// 更新処理
	/// </summary>
	void Update () {

		m_TimeElapsed += Time.deltaTime;

		if (m_TimeElapsed >= m_Timeout) {


			ulong num;
			num = MobileStorageChecker.StorageAvailable;
			m_ByteTextLandscape.text = num.ToString ();
			m_ByteTextPortrait.text = num.ToString ();

			m_TimeElapsed = 0.0f;
		}

	}

	/// <summary> 
	/// 更新処理
	/// </summary>
	void LateUpdate(){
	}

	#endregion

	// --------
	#region メンバメソッド
	#endregion

}
