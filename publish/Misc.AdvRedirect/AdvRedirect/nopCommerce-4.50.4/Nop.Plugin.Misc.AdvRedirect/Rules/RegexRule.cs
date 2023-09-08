﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Nop.Plugin.Misc.AdvRedirect.Rules
{
    public class RegexRule : IRule
    {
        private Regex _regex;
        private string _redirectUrl;
        private bool _useQryString;

        public RegexRule(string pattern, string redirectUrl, bool useQryString)
        {
            _redirectUrl = redirectUrl;
            _regex = new Regex(pattern);
            _useQryString = useQryString;
        }

        public bool UseQueryString { get; }
        public string RedirectUrl
        {
            get
            {
                return _redirectUrl;
            }
        }

        public bool Match(string url, string qry)
        {
            string key = _useQryString ? url + qry : url;
            return _regex.Match(key).Success;
        }
    }
}
