using Selenium.Infrastructure;
using Shared.PageObjects.Elements;
using Shared.PageObjects.Elements.Common;

namespace Shared.PageObjects.Pages.Common
{
    //�������� �����. ������� �� ������ ��������, �������� ������.
    public abstract class SitePage<TPage> : PageBase<TPage> where TPage : PageBase<TPage>, new()
    {
        public HeaderElement Header { get; } = new HeaderElement();
        public SearchModuleElement SearchModuleElement { get; } = new SearchModuleElement();
    }
}