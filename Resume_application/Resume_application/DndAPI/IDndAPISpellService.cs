using Resume_application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume_application.DndAPI
{
    public interface IDndAPISpellService
    {
        Task<string> GetSpellByName(DndSpellModel spellName);
    }
}
