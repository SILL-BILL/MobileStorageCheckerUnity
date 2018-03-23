using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 簡易的にPortrait用,Landscape用のカンバスをデバイスの傾きによって切り替えるクラス
/// </summary>
public class UIOrientationChanger : MonoBehaviour {

	// --------
	#region インスペクタ設定用フィールド
	/// <summary> 
	/// ランドスケープ用UIカンバス
	/// </summary>
	[SerializeField] private GameObject m_LandscapeCanvas;
	/// <summary> 
	/// ポートレイト用UIカンバス
	/// </summary>
	[SerializeField] private GameObject m_PortraitCanvas;
	#endregion

	// --------
	#region メンバフィールド
	/// <summary>
	/// The current orientation.
	/// </summary>
	private int m_CurrentScreenWidth;
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

	}
	/// <summary> 
	/// 更新処理
	/// </summary>
	void Update () {
		checkOrientation ();
	}

	/// <summary> 
	/// 更新処理
	/// </summary>
	void LateUpdate(){

	}
	#endregion

	// --------
	#region メンバメソッド
	/// <summary>
	/// Checks the orientation.
	/// </summary>
	private void checkOrientation(){

		if(m_CurrentScreenWidth != Screen.width){
			if (Screen.width < Screen.height) {
				//ポートレイト
				if(!m_PortraitCanvas.activeSelf) m_PortraitCanvas.SetActive (true);
				if(m_LandscapeCanvas.activeSelf) m_LandscapeCanvas.SetActive (false);
			} else {
				//ランドスケープ
				if(m_PortraitCanvas.activeSelf) m_PortraitCanvas.SetActive (false);
				if(!m_LandscapeCanvas.activeSelf) m_LandscapeCanvas.SetActive (true);
			}
		}
	}
	#endregion

}
