using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essai_WebApplicationMVC.Models
{
    public static class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();
        public static IEnumerable<GuestResponse> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(GuestResponse response)//Vert, ajout des participants
        {
            responses.Add(response);
            responses.Count();
        }
    }
}
