using System.Collections.Generic;
using Cinder.UI.Infrastructure.Components;
using Cinder.UI.Infrastructure.Dtos;
using Microsoft.AspNetCore.Components;

namespace Cinder.UI.Shared
{
    public class TransactionSummaryModel : EventBusComponent
    {
        [Parameter]
        public IEnumerable<TransactionDto> Transactions { get; set; }
    }
}
