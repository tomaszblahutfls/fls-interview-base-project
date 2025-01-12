using fls_interview_base_project.Models.Pages;
using fls_interview_base_project.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace fls_interview_base_project.Controllers;

public class SearchPageController : PageControllerBase<SearchPage>
{
    public ViewResult Index(SearchPage currentPage, string q)
    {
        var model = new SearchContentModel(currentPage)
        {
            Hits = Enumerable.Empty<SearchContentModel.SearchHit>(),
            NumberOfHits = 0,
            SearchServiceDisabled = true,
            SearchedQuery = q
        };

        return View(model);
    }
}
