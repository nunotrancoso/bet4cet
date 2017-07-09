﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Security.Cryptography;

/// <summary>
/// Summary description for security_b4c
/// </summary>
namespace security_b4c
{ 
	public static class security_b4c_md5
	{
		public static string StringToMD5(string input)
		{
			MD5 md5 = MD5.Create();
			byte[] inputBytes = Encoding.ASCII.GetBytes(input);
			byte[] hash = md5.ComputeHash(inputBytes);
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < hash.Length; i++)
			{ sb.Append(hash[i].ToString("X2")); }
			return sb.ToString();
		}
	}
}