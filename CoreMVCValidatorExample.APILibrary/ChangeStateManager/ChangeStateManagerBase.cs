﻿using CoreValidatorExample.BusinessLayer.ChangeStateManager;
using CoreValidatorExample.BusinessLayer.ChangeStateManager.Factory;
using CoreValidatorExample.BusinessLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreValidatorExample.BusinessLayer
{
    public abstract class ChangeStateManagerBase : IChangeStateManager
    {

        protected ChangeStateManagerBase(int userId, int userCorporateUnitId)
        {
            UserId = userId;
            UserCorporateUnitId = userCorporateUnitId;
            ValidationMsgList = new List<SvcValidationMsg>();
            ValidatorExecuterFactory = new ValidatorExecuterFactory();
        }

        protected ValidatorExecuterFactory ValidatorExecuterFactory;
        public int EventId { get; set; }
        public int UserId { get; set; }
        public int UserCorporateUnitId { get; set; }

        protected List<SvcValidationMsg> ValidationMsgList { get; set; }

        public abstract List<SvcValidationMsg> ValidateAndExecute(int eventId);

        public abstract void ExecuteChangeState();

        public void NoValidationsExecuteStateChange()
        {
            ExecuteChangeState();
        }
    }
}
