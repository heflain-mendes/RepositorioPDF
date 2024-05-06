using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace relatorioPDF.ReportHandlerFactories;

public interface IReportHandlerFactory
{
    public IReportHandler Create();
}
