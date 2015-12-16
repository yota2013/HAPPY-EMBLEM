using UnityEngine;
using System.Collections;

/*	<summary>
 *	CSVの読み込みと書き込み
 * 	抽象クラスとして作成
 * 	継承先の子クラスで中身は実装する
 * 	</summary>
 */

public abstract class CSV {
	
	// CSVを読み込むところ
	// 継承先の子クラスで実装する
	public abstract void CSVRead (string readFileName);

	// CSVを書き出すメソッド
	// 今は実装予定がない
	// （一応書いといたけど）
	public void CSVWrite (string writeFileName){
		// return null;
	}
}
