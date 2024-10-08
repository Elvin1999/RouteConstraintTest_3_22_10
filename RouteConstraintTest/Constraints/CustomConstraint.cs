
namespace RouteConstraintTest.Constraints
{
    public class CustomConstraint : IRouteConstraint
    {
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if(!values.ContainsKey(routeKey)) return false;

            var routeValue = values[routeKey]?.ToString();
            return !string.IsNullOrEmpty(routeValue) && routeValue.StartsWith("FC:");
        }
    }
}
