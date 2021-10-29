using FriendOrganizer.Model;
using System.Collections.Generic;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            // TODO: Load Data later
            yield return new Friend { FirstName = "Bray", LastName = "Calvin" };
            yield return new Friend { FirstName = "Neenah", LastName = "Stone" };
            yield return new Friend { FirstName = "Maya", LastName = "Gene" };
            yield return new Friend { FirstName = "Max", LastName = "Catty" };

        }
    }
}
