using System;
using System.Collections.Generic;
using System.Text;

namespace example
{
    class TDSDataModel
    {
        private string tradeid;
        private int date;
        private double tradevalue;
        private int counterpartyid;

        public string tds_tradeid
        {
            get { return this.tradeid; }
            set { this.tradeid = value; }
        }

        public int tds_date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public double tds_tradevalue
        {
            get { return this.tradevalue; }
            set { this.tradevalue = value; }
        }

        public int tds_counterpid
        {
            get { return this.counterpartyid; }
            set { this.counterpartyid = value; }
        }
    }

    class RDSDataModel
    {
        private int counterpartyid;
        private string name;

        public int rds_cpid
        {
            get { return this.counterpartyid; }
            set { this.counterpartyid = value; }
        }

        public string rds_name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
    class riskcalculator
    {
        //calculator()
    }
    class riskmerge
    {


    }
    class Assignment1
    {
        public static void main(string[] args)
        {
            TDSDataModel t1 = new TDSDataModel();
            RDSDataModel r1 = new RDSDataModel();


            t1.tds_tradeid = "Aiman";
            t1.tds_date = 15;
            t1.tds_tradevalue = 20;
            t1.tds_counterpid = 30;

            r1.rds_cpid = 2403;
            r1.rds_name = "shariff";

            Console.WriteLine(t1.tds_tradeid + " " + t1.tds_date + " " + t1.tds_tradevalue + " " + t1.tds_counterpid);
            Console.WriteLine(r1.rds_name + " " + r1.rds_cpid);

        }
    }
}