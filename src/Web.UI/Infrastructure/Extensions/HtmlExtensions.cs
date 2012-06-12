using System;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace Web.UI.Infrastructure.Extensions
{
    public static class HtmlExtensions
    {
        public static MvcHtmlString label_for<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
        {
            return format_label(html, ModelMetadata.FromLambdaExpression(expression, html.ViewData), ExpressionHelper.GetExpressionText(expression));
        }

        static MvcHtmlString format_label(HtmlHelper html, ModelMetadata metadata, string html_field_name)
        {
            var builder = new TagBuilder("label");
            builder.Attributes.Add("for", html.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldId(html_field_name));
            builder.SetInnerText(metadata.PropertyName.to_display());
            return MvcHtmlString.Create(builder.ToString(TagRenderMode.Normal));
        }
    }
}