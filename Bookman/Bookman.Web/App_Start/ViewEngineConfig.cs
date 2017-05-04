namespace Bookman.Web.App_Start
{
    using System.Web.Mvc;

    /// <summary>
    /// Registers view engines
    /// </summary>
    public class ViewEngineConfig
    {
        /// <summary>
        /// Removes every view engine except Razor in order to increase performance
        /// </summary>
        public static void RegisterViewEngines()
        {
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());
        }
    }
}
