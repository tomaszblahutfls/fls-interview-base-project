using System.ComponentModel.DataAnnotations;
using fls_interview_base_project.Business.Rendering;
using EPiServer.Web;

namespace fls_interview_base_project.Models.Pages;

/// <summary>
/// Represents contact details for a contact person
/// </summary>
[SiteContentType(
    GUID = "b1a7a8e3-5c4d-4b8e-9f3e-2d5f8e1b6c3a",
    GroupName = Globals.GroupNames.Specialized)]
[SiteImageUrl(Globals.StaticGraphicsFolderPath + "page-type-thumbnail-contact.png")]
public class CompanyOfficePage : StandardPage, IContainerPage
{
    // Write your code here
    public virtual string Address { get; set; }
}
