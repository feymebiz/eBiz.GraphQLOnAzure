using System;
using System.Collections.Generic;
using System.Text;

namespace eBiz.GraphQLOnAzure.Types
{
  public class SearchResult
  {
    public List<Movie> Search { get; set; }
    public string Response { get; set; }
    public string totalResults { get; set; }
  }
}
