using System;
using System.Collections.Generic;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Text.Json;
using System.IO;
namespace EditList
{
	internal class ReadWriteQuestionsFile
	{
		public static List<string> ReadListQuestions()
		{
			List<string> listQ = new List<string>();
			//чтение из файла всей информации по вопросам
			string readText = File.ReadAllText("QLiterature");
			//делим строку на подстроки, разделитель '{'и'}' 
			string[] words = readText.Split(new char[] { '{', '}'});
			foreach (string q in words)
			{
			listQ.Add( q + "}\n{" );			
			}
			return listQ;
		}
		public static  void WriteListQuestions(List<string> listQ)
		{
			FileStream file = new FileStream("QLiterature", FileMode.Truncate);
			file.Close();
			string ListQuestions = "";
			foreach (string question in listQ)
			{
				ListQuestions = ListQuestions + question ;
			}
				using (StreamWriter fw = File.AppendText("QLiterature"))
				{
					fw.WriteLine(ListQuestions);
				}			
		}
	}
}
