﻿using UnityEngine;
using System.Collections;
using System.IO; //System.IO.FileInfo, System.IO.StreamReader, System.IO.StreamWriter
using System; //Exception
using System.Text; //Encoding
using System.Collections.Generic;

//UserManager : SingletonMonoBehaviour<UserManager>

public class FileReadList{

	public List<string> _guitxt = new List<string> ();

	public List<string> Guitxt
	{
		get
		{
			return _guitxt;
		}
	}

	//Read text
	public void ReadFile(string Filename){
		// FileReadTest.txtファイルを読み込む
		//ResourcesからのLoad
		TextAsset fi = Resources.Load("CSV/" + Filename) as TextAsset;
		Debug.Log (fi);
		string[] linesFromfile = fi.text.Split('\n');


		foreach (string textfile in linesFromfile)
		{
			Debug.Log(textfile);
			if (textfile != null) {
				_guitxt.Add (textfile);
			} 
			else 
			{
				Debug.Log (_guitxt);
				_guitxt.Add(SetDefaultText ());
			}
		}

	}
	// 改行コード処理
	string SetDefaultText(){
		return "C#あ\n";
	}



}

