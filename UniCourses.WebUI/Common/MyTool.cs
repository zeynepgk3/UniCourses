using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using UniCourses.Bl.Repositories;
using UniCourses.Dal.Contexts;
using UniCourses.Dal.Entities;
using UniCourses.WebUI.Models;
using UniCourses.WebUI.ViewModels;

namespace UniCourses.WebUI.Common
{
    public static class MyTool
    {
        public static string urlConvert(string _url)
        {
            if (string.IsNullOrEmpty(_url)) return "";
            _url = _url.ToLower();
            _url = _url.Trim();
            if (_url.Length > 300) _url = _url.Substring(0, 300);
            _url = _url.Replace("İ", "I");
            _url = _url.Replace("ı", "i");
            _url = _url.Replace("ğ", "g");
            _url = _url.Replace("Ğ", "G");
            _url = _url.Replace("ç", "c");
            _url = _url.Replace("Ç", "C");
            _url = _url.Replace("ö", "o");
            _url = _url.Replace("Ö", "O");
            _url = _url.Replace("ş", "s");
            _url = _url.Replace("Ş", "S");
            _url = _url.Replace("ü", "u");
            _url = _url.Replace("Ü", "U");
            _url = _url.Replace("'", "");
            _url = _url.Replace("\"", "");
            _url = _url.Replace(",", "-");
            char[] replacerList = @"$%#@!*?;:~`+=()[]{}|\'<>,/^&"".".ToCharArray();
            for (int i = 0; i < replacerList.Length; i++)
            {
                string strChr = replacerList[i].ToString();
                if (_url.Contains(strChr))
                {
                    _url = _url.Replace(strChr, string.Empty);
                }
            }
            Regex r = new Regex("[^a-zA-Z0-9_-]");
            _url = r.Replace(_url, "-");
            while (_url.IndexOf("--") > -1)
                _url = _url.Replace("--", "-");
            return _url;
        }
    }
}
