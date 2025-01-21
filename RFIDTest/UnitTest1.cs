﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RFIDTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPalletCount()
        {
            var soapClient = new IntegrationtoNAV.IntegrationtoNAVSoapClient();
            var apiKey = "Eax^ME_bg@C8Wy9YMB+P";
            var projectName = "OYAK";
            var result = soapClient.GetPalletInfo(apiKey, projectName, "A000000000003164");
            // result.JSONResult = [{"OrderNo":"106056","PalletCount":240}] 
        }

        [TestMethod]
        public void TestInBound()
        {
            var soapClient = new IntegrationtoNAV.IntegrationtoNAVSoapClient();
            var apiKey = "Eax^ME_bg@C8Wy9YMB+P";
            var projectName = "OYAK";
            string operationName = "RFIDInbound";
            string values = "A000000000003162,A000000000003163,A000000000003164,A000000000003165,A000000000003166,A000000000003167,A000000000003168,A000000000003169,A000000000003170,A000000000003171,A000000000003172,A000000000003173,A000000000003174,A000000000003175,A000000000003176,A000000000003177,A000000000003178,A000000000003179,A000000000003180,A000000000003181,A000000000003182,A000000000003183,A000000000003184,A000000000003185,A000000000003186,A000000000003187,A000000000003188,A000000000003189,A000000000003190,A000000000003191,A000000000003192,A000000000003193,A000000000003194,A000000000003195,A000000000003196,A000000000003197,A000000000003198,A000000000003199,A000000000003200,A000000000003201,A000000000003202,A000000000003203,A000000000003204,A000000000003205,A000000000003206,A000000000003207,A000000000003208,A000000000003209,A000000000003210,A000000000003211,A000000000003212,A000000000003213,A000000000003214,A000000000003215,A000000000003216,A000000000003217,A000000000003218,A000000000003219,A000000000003220,A000000000003221,A000000000003222,A000000000003223,A000000000003224,A000000000003225,A000000000003226,A000000000003227,A000000000003228,A000000000003229,A000000000003230,A000000000003231,A000000000003232,A000000000003233,A000000000003234,A000000000003235,A000000000003236,A000000000003237,A000000000003238,A000000000003239,A000000000003240,A000000000003241,A000000000003242,A000000000003243,A000000000003244,A000000000003245,A000000000003246,A000000000003247,A000000000003248,A000000000003249,A000000000003250,A000000000003251,A000000000003252,A000000000003253,A000000000003254,A000000000003255,A000000000003256,A000000000003257,A000000000003258,A000000000003259,A000000000003260,A000000000003261,A000000000003262,A000000000003263,A000000000003264,A000000000003265,A000000000003266,A000000000003267,A000000000003268,A000000000003269,A000000000003270,A000000000003271,A000000000003272,A000000000003273,A000000000003274,A000000000003275,A000000000003276,A000000000003277,A000000000003278,A000000000003279,A000000000003280,A000000000003281,A000000000003282,A000000000003283,A000000000003284,A000000000003285,A000000000003286,A000000000003287,A000000000003288,A000000000003289,A000000000003290,A000000000003291,A000000000003292,A000000000003293,A000000000003294,A000000000003295,A000000000003296,A000000000003297,A000000000003298,A000000000003299,A000000000003300,A000000000003301,A000000000003302,A000000000003303,A000000000003304,A000000000003305,A000000000003306,A000000000003307,A000000000003308,A000000000003309,A000000000003310,A000000000003311,A000000000003312,A000000000003313,A000000000003314,A000000000003315,A000000000003316,A000000000003317,A000000000003318,A000000000003319,A000000000003320,A000000000003321,A000000000003322,A000000000003323,A000000000003324,A000000000003325,A000000000003326,A000000000003327,A000000000003328,A000000000003329,A000000000003330,A000000000003331,A000000000003332,A000000000003333,A000000000003334,A000000000003335,A000000000003336,A000000000003337,A000000000003338,A000000000003339,A000000000003340,A000000000003341,A000000000003342,A000000000003343,A000000000003344,A000000000003345,A000000000003346,A000000000003347,A000000000003348,A000000000003349,A000000000003350,A000000000003351,A000000000003352,A000000000003353,A000000000003354,A000000000003355,A000000000003356,A000000000003357,A000000000003358,A000000000003359,A000000000003360,A000000000003361,A000000000003362,A000000000003363,A000000000003364,A000000000003365,A000000000003366,A000000000003367,A000000000003368,A000000000003369,A000000000003370,A000000000003371,A000000000003372,A000000000003373,A000000000003374,A000000000003375,A000000000003376,A000000000003377,A000000000003378,A000000000003379,A000000000003380,A000000000003381,A000000000003382,A000000000003383,A000000000003384,A000000000003385,A000000000003386,A000000000003387,A000000000003388,A000000000003389,A000000000003390,A000000000003391,A000000000003392,A000000000003393,A000000000003394,A000000000003395,A000000000003396,A000000000003397,A000000000003398,A000000000003399,A000000000003400,A000000000003401";
            soapClient.SendRFID(apiKey, projectName, operationName, values);
            // Herhangi bir exception alınmadıysa başarılı
        }

        [TestMethod]
        public void TestOutBound()
        {
            var soapClient = new IntegrationtoNAV.IntegrationtoNAVSoapClient();
            var apiKey = "Eax^ME_bg@C8Wy9YMB+P";
            var projectName = "OYAK";
            string operationName = "RFIDOutbound";
            string values = "A000000000003162,A000000000003163,A000000000003164,A000000000003165,A000000000003166,A000000000003167,A000000000003168,A000000000003169,A000000000003170,A000000000003171,A000000000003172,A000000000003173,A000000000003174,A000000000003175,A000000000003176,A000000000003177,A000000000003178,A000000000003179,A000000000003180,A000000000003181,A000000000003182,A000000000003183,A000000000003184,A000000000003185,A000000000003186,A000000000003187,A000000000003188,A000000000003189,A000000000003190,A000000000003191,A000000000003192,A000000000003193,A000000000003194,A000000000003195,A000000000003196,A000000000003197,A000000000003198,A000000000003199,A000000000003200,A000000000003201,A000000000003202,A000000000003203,A000000000003204,A000000000003205,A000000000003206,A000000000003207,A000000000003208,A000000000003209,A000000000003210,A000000000003211,A000000000003212,A000000000003213,A000000000003214,A000000000003215,A000000000003216,A000000000003217,A000000000003218,A000000000003219,A000000000003220,A000000000003221,A000000000003222,A000000000003223,A000000000003224,A000000000003225,A000000000003226,A000000000003227,A000000000003228,A000000000003229,A000000000003230,A000000000003231,A000000000003232,A000000000003233,A000000000003234,A000000000003235,A000000000003236,A000000000003237,A000000000003238,A000000000003239,A000000000003240,A000000000003241,A000000000003242,A000000000003243,A000000000003244,A000000000003245,A000000000003246,A000000000003247,A000000000003248,A000000000003249,A000000000003250,A000000000003251,A000000000003252,A000000000003253,A000000000003254,A000000000003255,A000000000003256,A000000000003257,A000000000003258,A000000000003259,A000000000003260,A000000000003261,A000000000003262,A000000000003263,A000000000003264,A000000000003265,A000000000003266,A000000000003267,A000000000003268,A000000000003269,A000000000003270,A000000000003271,A000000000003272,A000000000003273,A000000000003274,A000000000003275,A000000000003276,A000000000003277,A000000000003278,A000000000003279,A000000000003280,A000000000003281,A000000000003282,A000000000003283,A000000000003284,A000000000003285,A000000000003286,A000000000003287,A000000000003288,A000000000003289,A000000000003290,A000000000003291,A000000000003292,A000000000003293,A000000000003294,A000000000003295,A000000000003296,A000000000003297,A000000000003298,A000000000003299,A000000000003300,A000000000003301,A000000000003302,A000000000003303,A000000000003304,A000000000003305,A000000000003306,A000000000003307,A000000000003308,A000000000003309,A000000000003310,A000000000003311,A000000000003312,A000000000003313,A000000000003314,A000000000003315,A000000000003316,A000000000003317,A000000000003318,A000000000003319,A000000000003320,A000000000003321,A000000000003322,A000000000003323,A000000000003324,A000000000003325,A000000000003326,A000000000003327,A000000000003328,A000000000003329,A000000000003330,A000000000003331,A000000000003332,A000000000003333,A000000000003334,A000000000003335,A000000000003336,A000000000003337,A000000000003338,A000000000003339,A000000000003340,A000000000003341,A000000000003342,A000000000003343,A000000000003344,A000000000003345,A000000000003346,A000000000003347,A000000000003348,A000000000003349,A000000000003350,A000000000003351,A000000000003352,A000000000003353,A000000000003354,A000000000003355,A000000000003356,A000000000003357,A000000000003358,A000000000003359,A000000000003360,A000000000003361,A000000000003362,A000000000003363,A000000000003364,A000000000003365,A000000000003366,A000000000003367,A000000000003368,A000000000003369,A000000000003370,A000000000003371,A000000000003372,A000000000003373,A000000000003374,A000000000003375,A000000000003376,A000000000003377,A000000000003378,A000000000003379,A000000000003380,A000000000003381,A000000000003382,A000000000003383,A000000000003384,A000000000003385,A000000000003386,A000000000003387,A000000000003388,A000000000003389,A000000000003390,A000000000003391,A000000000003392,A000000000003393,A000000000003394,A000000000003395,A000000000003396,A000000000003397,A000000000003398,A000000000003399,A000000000003400,A000000000003401";
            soapClient.SendRFID(apiKey, projectName, operationName, values);
            // Herhangi bir exception alınmadıysa başarılı
        }
    }
}
