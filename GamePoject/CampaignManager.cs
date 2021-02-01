using System;
using System.Collections.Generic;
using System.Text;

namespace GamePoject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("KAMPANYA EKLENDİ");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("KAMPANYA SİLİNDİ");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("KAMPANYA GÜNCELLENDİ");
        }
    }
}
