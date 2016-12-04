/* http://www.zkea.net/ Copyright 2016 ZKEASOFT http://www.zkea.net/licenses */
using ZKEACMS.SectionWidget.Models;
using Easy.RepositoryPattern;

namespace ZKEACMS.SectionWidget.Service
{
    public interface ISectionContentProviderService : IService<SectionContent>
    {
        SectionContent FillContent(SectionContent content);
    }
}