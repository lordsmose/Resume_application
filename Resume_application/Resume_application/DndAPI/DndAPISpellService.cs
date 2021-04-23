using Microsoft.Extensions.Logging;
using Resume_application.DndAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using static Resume_application.Infrastructure.Constants;

namespace Resume_application.DndAPI
{
    public class DndAPISpellService : IDndAPISpellService
    {
        private ILogger<DndAPISpellService> _logger;

        private readonly IHttpClientFactory _clientFactory;
        public DndAPISpellService(ILogger<DndAPISpellService> logger, IHttpClientFactory clientFactory)
        {
            _logger = logger;
            _clientFactory = clientFactory;
        }

        public async Task<string> GetSpellByName(string spellName)
        {
            var spellClient = _clientFactory.CreateClient(DND_API);
            var DnDAPI = await spellClient.GetAsync("/api/spells/" + spellName + "/");
            return await DnDAPI.Content.ReadAsStringAsync();
        }
    }
}
