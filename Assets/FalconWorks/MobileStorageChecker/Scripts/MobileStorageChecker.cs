using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class MobileStorageChecker : MonoBehaviour {

	[DllImport("__Internal")]
	private static extern ulong _getStorageAvailable ();

	// --------
	#region シングルトン宣言
	private static MobileStorageChecker mInstance;
	// コンストラクタ
	private MobileStorageChecker() {

	}
	// インスタンスを生成する
	public static MobileStorageChecker Instance {
		get {
			if (mInstance == null) {
				GameObject gObj = new GameObject("MobileStorageChecker");
				mInstance = gObj.AddComponent<MobileStorageChecker>();
			}
			return mInstance;
		}
	}
	#endregion

	// --------
	#region メンバフィールド
	/// <summary>
	/// スマートフォン端末(iOS,Android)の空き容量をバイト単位で返すプロパティ
	/// </summary>
	/// <value>空き容量(byte)</value>
	public static ulong StorageAvailable {
		get {

			#if UNITY_IOS && !UNITY_EDITOR
			return _getStorageAvailable();
			#elif UNITY_ANDROID && !UNITY_EDITOR
			var statFs = new AndroidJavaObject ("android.os.StatFs", Application.temporaryCachePath);
			var availableBlocks = statFs.Call<long> ("getAvailableBlocksLong");
			var blockSize = statFs.Call<long> ("getBlockSizeLong");
			var freeBytes = availableBlocks * blockSize;
			return (ulong)freeBytes;
			#else
			return (ulong)0;
			#endif

		}
	}
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
