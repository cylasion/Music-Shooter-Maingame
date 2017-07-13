using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//gap code vao ms chinh dc thang diem nay
public static class Score  {
	private static long _Score=0;
	private static int _Combo = 0;
	public static void Add(int k,float time){
		if (time >= 750 && time < 1050) {
			_Score = _Score + k + (int)(_Combo / 5);
			_Combo++;
		} else {
			FailCombo ();
		}

	}

	public static long getScore(){
		return _Score;
	}
	public static void FailCombo(){
		_Combo=0;
	}

	public static int getCombo(){
		return _Combo;
	}


}
