using System;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace VueJsAspNetMVC
{
    public static class VueExtensions
    {
        public static MvcHtmlString VueTextBoxFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> Expression)
        {
            return new MvcHtmlString(string.Format("<input id='{0}' v-model.trim='input.{0}' />", (Expression.Body as MemberExpression).Member.Name));
        }
    }
}