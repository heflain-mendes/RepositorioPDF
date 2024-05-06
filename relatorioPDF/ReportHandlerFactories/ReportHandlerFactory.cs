using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace relatorioPDF.ReportHandlerFactories;

public class ReportHandlerFactory : IReportHandlerFactory
{
    public IReportHandler Create()
    {
        var header = new HeaderHandler();
        var sicar = new SICARHandler();
        var cnuc = new CNUCHandler();
        var funai = new FUNAIHandler();
        var inpe = new INPEHandler();
        var ibma = new IBAMAHandler();
        
        header.SetNext(sicar);
        sicar.SetNext(cnuc);
        cnuc.SetNext(funai);
        funai.SetNext(inpe);
        inpe.SetNext(ibma);

        return header;
    }
}