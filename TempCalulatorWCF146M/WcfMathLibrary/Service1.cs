﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfMathLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        OutputForTemp IService1.CalculateTemp(InputForTemp input)
        {
            //Комментарий
            OutputForTemp result = new OutputForTemp();
            result.OutputMessage = "Вы написали: "+ input.InputMessage;
            //Ещё один комментарий
            return result;
        }
    }
}