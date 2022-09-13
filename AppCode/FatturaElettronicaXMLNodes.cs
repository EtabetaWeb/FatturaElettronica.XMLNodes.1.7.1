using System;
using System.Xml.Serialization;
using System.Xml;

[Serializable]
public class FatturaElettronicaXMLNodes
{
    [XmlAttribute("versione")]
    public string versione;
    public FatturaElettronicaHeader FatturaElettronicaHeader;
    public FatturaElettronicaBody FatturaElettronicaBody;
}
