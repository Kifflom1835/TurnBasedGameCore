using System;
using UniversalUnity.Helpers.MonoBehaviourExtenders;

namespace Core
{
    public class Battle : GenericSingleton<Battle>
    {
        public Action AInitiativeEnd;
    }
}