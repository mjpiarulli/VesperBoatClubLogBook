using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using ModelStateDictionary = System.Web.ModelBinding.ModelStateDictionary;

namespace Common.Extensions
{
    public static class ModelStateDictionaryExtensions
    {
        public static void AddModelError<TModel, TProperty>(this ModelStateDictionary modelState, Expression<Func<TModel, TProperty>> ex, string message)
        {
            var key = ExpressionHelper.GetExpressionText(ex);
            modelState.AddModelError(key, message);
        }
    }
}
