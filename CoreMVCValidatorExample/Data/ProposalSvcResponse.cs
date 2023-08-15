﻿using CoreValidatorExample.WebSite.ValidationHelper;

namespace CoreValidatorExample.WebSite.Data
{
    public class ProposalSvcResponse
    {
        public bool Success { get; set; }
        public List<SvcErrorMsg> SvcErrorMsgs { get; set; }
    }
}
