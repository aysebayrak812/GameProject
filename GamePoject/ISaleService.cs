using System;
using System.Collections.Generic;
using System.Text;

namespace GamePoject
{
    interface ISaleService
    {
        void Sell(ICampaignService campaignService, IGamerService gamerService);
    }
}
