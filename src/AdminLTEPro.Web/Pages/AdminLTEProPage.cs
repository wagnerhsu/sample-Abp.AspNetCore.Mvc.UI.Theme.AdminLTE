using Microsoft.AspNetCore.Mvc.Razor.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;
using Volo.Abp.Localization;

namespace AdminLTEPro.Web.Pages
{
    public abstract class AdminLTEProPage: AbpPage
    {
        [RazorInject]
        public ILanguageProvider LanguageProvider { get; set; }
    }
}
