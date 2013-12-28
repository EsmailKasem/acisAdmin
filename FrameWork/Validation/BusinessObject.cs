﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrameWork.EnumLst;
using System.Collections;

namespace FrameWork
{
    public abstract class BusinessObject
    {
        public  List<BusinessRule> _businessRules = new List<BusinessRule>();
        private List<ValidationErrorsItem> _validationErrors = new List<ValidationErrorsItem>();
        public List<ValidationErrorsItem> ValidationErrors
        {
            get { return _validationErrors; }
        }

        protected void AddRule(BusinessRule rule)
        {
            _businessRules.Add(rule);
        }


        /// <summary>
        /// Useing Simple
        /// Object.ValidationErrors.ToList().First().Value ==> Will By the Msg
        /// Object.ValidationErrors.ToList().First().Key ==> Will Be the PropName
        /// </summary>
        /// <param name="Lang"></param>
        /// <returns></returns>
        public bool Validate(Languages Lang = Languages.Arabic)
        {
            bool isValid = true;
            _validationErrors.Clear();

            BusinessRule.Equals(Lang, null);

            foreach (BusinessRule rule in _businessRules)
            {
                if (!rule.Validate(this))
                {
                    isValid = false;
                    _validationErrors.Add(new ValidationErrorsItem() { PropName = rule.PropertyName, ErrorMessage = Lang == Languages.Arabic ? rule.ErrorMessage_AR : rule.ErrorMessage_En });
                }
            }
            return isValid;
        }

    }

    public class ValidationErrorsItem
    {
        public string PropName { get; set; }
        public string ErrorMessage { get; set; }
    }
}