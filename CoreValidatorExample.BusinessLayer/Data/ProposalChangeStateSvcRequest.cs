﻿namespace CoreValidatorExample.BusinessLayer.Data
{
    public class ProposalChangeStateSvcRequest : SvcRequestBase
    {
      
        public int ProposalId { get; set; }
        public int EventId { get; set; }
    }
}
