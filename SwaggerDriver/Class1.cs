using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using LINQPad.Extensibility.DataContext;

namespace SwaggerDriver
{
    public class Class1 : DynamicDataContextDriver
    {
        public override string GetConnectionDescription(IConnectionInfo cxInfo)
        {
            throw new NotImplementedException();
        }

        public override bool ShowConnectionDialog(IConnectionInfo cxInfo, bool isNewConnection)
        {
            throw new NotImplementedException();
        }

        public override string Name { get; } = "Swagger Driver"
        public override string Author { get; } = "Pearse Hutson"

        public override List<ExplorerItem> GetSchemaAndBuildAssembly(IConnectionInfo cxInfo, AssemblyName assemblyToBuild, ref string nameSpace,
            ref string typeName)
        {
            throw new NotImplementedException();
        }
    }
}
