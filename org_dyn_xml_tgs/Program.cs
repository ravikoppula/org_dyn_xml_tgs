using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        string appHdrInput = "AppHdr|AppHdr/Fr|AppHdr/Fr/FIId|AppHdr/Fr/FIId/FinInstId|AppHdr/Fr/FIId/FinInstId/Othr|AppHdr/Fr/FIId/FinInstId/Othr/Id|AppHdr/To|AppHdr/To/FIId|AppHdr/To/FIId/FinInstId|AppHdr/To/FIId/FinInstId/Othr|AppHdr/To/FIId/FinInstId/Othr/Id|AppHdr/BizMsgId|AppHdr/MsgDefIdr|AppHdr/BizSvc|AppHdr/CreDt|AppHdr/CpyDplct|AppHdr/PssblDplct|AppHdr/Sgntr|AppHdr/Sgntr/Signature";
        string fitoInput = "FIToFICstmrCdtTrf|FIToFICstmrCdtTrf/GrpHdr|FIToFICstmrCdtTrf/GrpHdr/MsgId|FIToFICstmrCdtTrf/GrpHdr/CreDtTm|FIToFICstmrCdtTrf/GrpHdr/NbOfTxns|FIToFICstmrCdtTrf/GrpHdr/SttlmInf|FIToFICstmrCdtTrf/GrpHdr/SttlmInf/SttlmtMtd|FIToFICstmrCdtTrf/CdtTrfTxnInf|FIToFICstmrCdtTrf/CdtTrfTxnInf/PmtId|FIToFICstmrCdtTrf/CdtTrfTxnInf/PmtId/EndToEndId|FIToFICstmrCdtTrf/CdtTrfTxnInf/PmtId/TxnId|FIToFICstmrCdtTrf/CdtTrfTxnInf/PmtId/ClrSysRef|FIToFICstmrCdtTrf/CdtTrfTxnInf/PmtTpInf|FIToFICstmrCdtTrf/CdtTrfTxnInf/PmtTpInf/CtgyPurp|FIToFICstmrCdtTrf/CdtTrfTxnInf/PmtTpInf/CtgyPurp/Prtry|FIToFICstmrCdtTrf/CdtTrfTxnInf/IntrBkSttlmAmt|FIToFICstmrCdtTrf/CdtTrfTxnInf/IntrBkSttlmDt|FIToFICstmrCdtTrf/CdtTrfTxnInf/ChrgBr|FIToFICstmrCdtTrf/CdtTrfTxnInf/InstgAgt|FIToFICstmrCdtTrf/CdtTrfTxnInf/InstgAgt/FinInstId|FIToFICstmrCdtTrf/CdtTrfTxnInf/InstgAgt/FinInstId/Othr|FIToFICstmrCdtTrf/CdtTrfTxnInf/InstgAgt/FinInstId/Othr/Id|FIToFICstmrCdtTrf/CdtTrfTxnInf/InstgAgt/FinInstId/Nm|FIToFICstmrCdtTrf/CdtTrfTxnInf/InstgAgt/FinInstId/PstlAdr|FIToFICstmrCdtTrf/CdtTrfTxnInf/InstgAgt/FinInstId/PstlAdr/StrtNm|FIToFICstmrCdtTrf/CdtTrfTxnInf/InstgAgt/FinInstId/PstlAdr/TwnNm|FIToFICstmrCdtTrf/CdtTrfTxnInf/InstgAgt/FinInstId/PstlAdr/CtrySubDvsn|FIToFICstmrCdtTrf/CdtTrfTxnInf/InstgAgt/FinInstId/PstlAdr/Ctry|FIToFICstmrCdtTrf/CdtTrfTxnInf/Dbtr|FIToFICstmrCdtTrf/CdtTrfTxnInf/Dbtr/Nm|FIToFICstmrCdtTrf/CdtTrfTxnInf/DbtrAcct|FIToFICstmrCdtTrf/CdtTrfTxnInf/DbtrAcct/Id|FIToFICstmrCdtTrf/CdtTrfTxnInf/DbtrAcct/Id/Othr|FIToFICstmrCdtTrf/CdtTrfTxnInf/DbtrAcct/Id/Othr/Id|FIToFICstmrCdtTrf/CdtTrfTxnInf/DbtrAcct/Tp|FIToFICstmrCdtTrf/CdtTrfTxnInf/DbtrAcct/Tp/Prtry|FIToFICstmrCdtTrf/CdtTrfTxnInf/DbtrAgt|FIToFICstmrCdtTrf/CdtTrfTxnInf/DbtrAgt/FinInstnId|FIToFICstmrCdtTrf/CdtTrfTxnInf/DbtrAgt/FinInstnId/Othr|FIToFICstmrCdtTrf/CdtTrfTxnInf/DbtrAgt/FinInstnId/Othr/Id|FIToFICstmrCdtTrf/CdtTrfTxnInf/CdtrAgt|FIToFICstmrCdtTrf/CdtTrfTxnInf/CdtrAgt/FinInstnId|FIToFICstmrCdtTrf/CdtTrfTxnInf/CdtrAgt/FinInstnId/Othr|FIToFICstmrCdtTrf/CdtTrfTxnInf/CdtrAgt/FinInstnId/Othr/Id|FIToFICstmrCdtTrf/CdtTrfTxnInf/Cdtr|FIToFICstmrCdtTrf/CdtTrfTxnInf/Cdtr/Nm|FIToFICstmrCdtTrf/CdtTrfTxnInf/CdtrAcct|FIToFICstmrCdtTrf/CdtTrfTxnInf/CdtrAcct/Id|FIToFICstmrCdtTrf/CdtTrfTxnInf/CdtrAcct/Id/Othr|FIToFICstmrCdtTrf/CdtTrfTxnInf/CdtrAcct/Id/Othr/Id|FIToFICstmrCdtTrf/CdtTrfTxnInf/CdtrAcct/Tp|FIToFICstmrCdtTrf/CdtTrfTxnInf/CdtrAcct/Tp/Prtry|FIToFICstmrCdtTrf/CdtTrfTxnInf/SplmtryData|FIToFICstmrCdtTrf/CdtTrfTxnInf/SplmtryData/PlcAndNm|FIToFICstmrCdtTrf/CdtTrfTxnInf/SplmtryData/Envlp|FIToFICstmrCdtTrf/CdtTrfTxnInf/SplmtryData/Envlp/InstrForCdtrAgt|FIToFICstmrCdtTrf/CdtTrfTxnInf/SplmtryData/Envlp/InstrForCdtrAgt/RecptRef|FIToFICstmrCdtTrf/CdtTrfTxnInf/SplmtryData/Envlp/InstrForCdtrAgt/PymtDesc|FIToFICstmrCdtTrf/CdtTrfTxnInf/SplmtryData/Envlp/InstrForCdtrAgt/ScndValInd|FIToFICstmrCdtTrf/CdtTrfTxnInf/SplmtryData/Envlp/InstrForCdtrAgt/IdTp|FIToFICstmrCdtTrf/CdtTrfTxnInf/SplmtryData/Envlp/InstrForCdtrAgt/Id|FIToFICstmrCdtTrf/CdtTrfTxnInf/SplmtryData/Envlp/InstrForCdtrAgt/SellerId|FIToFICstmrCdtTrf/CdtTrfTxnInf/SplmtryData/Envlp/InstrForDbtrAcct|FIToFICstmrCdtTrf/CdtTrfTxnInf/SplmtryData/Envlp/InstrForDbtrAcct/RsdnSts|FIToFICstmrCdtTrf/CdtTrfTxnInf/SplmtryData/Envlp/InstrForDbtrAcct/PrdTp|FIToFICstmrCdtTrf/CdtTrfTxnInf/SplmtryData/Envlp/InstrForDbtrAcct/ShariaCmpl|FIToFICstmrCdtTrf/CdtTrfTxnInf/SplmtryData/Envlp/InstrForDbtrAcct/Dtls|FIToFICstmrCdtTrf/CdtTrfTxnInf/SplmtryData/Envlp/Dbtr|FIToFICstmrCdtTrf/CdtTrfTxnInf/SplmtryData/Envlp/Dbtr/IpAddr|FIToFICstmrCdtTrf/CdtTrfTxnInf/SplmtryData/Envlp/Dbtr/Id|FIToFICstmrCdtTrf/CdtTrfTxnInf/SplmtryData/Envlp/CdtTrfTxnInf|FIToFICstmrCdtTrf/CdtTrfTxnInf/SplmtryData/Envlp/CdtTrfTxnInf/URL|FIToFICstmrCdtTrf/CdtTrfTxnInf/SplmtryData/Envlp/PrxyLkUpRef";

        //XElement root = new XElement("root");

        //AddElements(root, appHdrInput);
        //AddElements(root, fitoInput);

        // Example values for some of the nodes
        //SetExampleValues(root);

        //Console.WriteLine(root);

        //int nodeCount = root.Descendants().Count();
        //int childNodeCount = root.Descendants().Sum(e => e.Elements().Count());

        //Console.WriteLine($"Total nodes: {nodeCount}");
        //Console.WriteLine($"Total child nodes: {childNodeCount}");


        XElement appHdrRoot = new XElement("AppHdr");
        XElement fitoRoot = new XElement("FIToFICstmrCdtTrf");

        AddElements(appHdrRoot, appHdrInput);
        AddElements(fitoRoot, fitoInput);

        // Set example values
        SetExampleValues(appHdrRoot);
        SetExampleValues(fitoRoot);

        // Combine the two root elements into a string without a wrapping root element
        string combinedXml = $"{appHdrRoot}{fitoRoot}";

        Console.WriteLine(combinedXml);


        Console.ReadLine();

    }

    static void AddElements(XElement root, string input)
    {
        Dictionary<string, XElement> elements = new Dictionary<string, XElement>();
        string[] paths = input.Split('|');

        foreach (var path in paths)
        {
            string[] nodes = path.Split('/');
            XElement current = root;

            for (int i = 0; i < nodes.Length; i++)
            {
                string node = nodes[i];

                string uniqueKey = string.Join("/", nodes.Take(i + 1));
                if (!elements.ContainsKey(uniqueKey))
                {
                    XElement newElement = new XElement(node);

                    if(String.IsNullOrEmpty(newElement.Value))
                        newElement.Value = "";

                    current.Add(newElement);
                    elements[uniqueKey] = newElement;
                }
                current = elements[uniqueKey];
            }
        }
    }

    static void SetExampleValues(XElement root)
    {
        var idElements = root.Descendants("Id").ToList();
        if (idElements.Count > 0) idElements[0].Value = "001";
        if (idElements.Count > 1) idElements[1].Value = "245";
        if (idElements.Count > 2) idElements[2].Value = "123123123123123123123123";
        if (idElements.Count > 3) idElements[3].Value = "4353432424153453452";

        var valueElements = new Dictionary<string, string>
        {
            { "BizMsgId", "123" },
            { "MsgDefIdr", "123" },
            { "BizSvc", "123" },
            { "CreDt", "2024-06-14T12:00:00" },
            { "CpyDplct", "123" },
            { "PssblDplct", "123" },
            { "Signature", "asdasda" },
            { "MsgId", "ExampleMsgId" },
            { "CreDtTm", "2024-06-14T12:00:00" },
            { "NbOfTxns", "10" },
            { "SttlmtMtd", "CLRG" },
            { "EndToEndId", "E2E12345" },
            { "TxnId", "Txn12345" },
            { "ClrSysRef", "CLR12345" },
            { "Prtry", "PURCHASE" },
            { "IntrBkSttlmAmt", "1000.00" },
            { "IntrBkSttlmDt", "2024-06-14" },
            { "ChrgBr", "SLEV" },
            { "Nm", "ExampleName" },
            { "StrtNm", "ExampleStreet" },
            { "TwnNm", "ExampleTown" },
            { "CtrySubDvsn", "ExampleSubdivision" },
            { "Ctry", "ExampleCountry" },
            { "PstlAdr", "ExamplePostalAddress" },
            { "URL", "http://example.com" },
            { "PrxyLkUpRef", "ProxyLookupReference" }
        };

        foreach (var kvp in valueElements)
        {
            var elements = root.Descendants(kvp.Key).ToList();
            if (elements.Count > 0) elements[0].Value = kvp.Value;
        }
    }
}
