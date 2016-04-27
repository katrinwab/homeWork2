﻿using System.Collections.Generic;
using System.Xml;

namespace HomeWork2.Drink
{
    class DrinkXmlList : SubjectXmlList, IDrinkList
    {
        public DrinkXmlList(string nameXml) : base(nameXml)
        {
            List = new List<Drink>();
            Init();
        }

        public override void ParseNode(XmlNode node)
        {
            var cost = int.Parse(node.Attributes["cost"].Value);
            var count = int.Parse(node.Attributes["count"].Value);
            var name = node.InnerText;
            List.Add(new Drink(cost, count, name));
        }

        public List<Drink> List { get; set; }
    }
}