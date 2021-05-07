using Microsoft.Extensions.Logging;
using Resume_application.DndAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static Resume_application.Infrastructure.Constants;
using Resume_application.Models;
using Newtonsoft.Json;
using System.IO;

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

        public async Task<string> GetSpellByName(DndSpellModel spellModel)
        {
            var spellClient = _clientFactory.CreateClient(DND_API);

            var serializer = new JsonSerializer()
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            var stringWriter = new StringWriter();
            using (var writer = new JsonTextWriter(stringWriter))
            {
                writer.QuoteName = false;
                serializer.Serialize(writer, spellModel);
            }

            var query = "query{  spells(filter:" + stringWriter.ToString() + "){name}}";
            var request = new HttpRequestMessage(HttpMethod.Get, "/graphql");

            request.Content = new StringContent(query, Encoding.UTF8, "application/json");
            var DnDAPI = await spellClient.GetAsync("/graphql/?query=" + query);

            return await DnDAPI.Content.ReadAsStringAsync();
        }
    }
}
