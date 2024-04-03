﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace CK.Ais.Net.Specs.AisMessageTypes
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("LongRangeBroadcastMessageParserSpecsSteps")]
    public partial class LongRangeBroadcastMessageParserSpecsStepsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "LongRangeBroadcastMessageParserSpecs.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AisMessageTypes", "LongRangeBroadcastMessageParserSpecsSteps", "    In order process AIS messages from an nm4 file\r\n    As a developer\r\n    I wan" +
                    "t the NmeaAisLongRangeBroadcastMessageParser to be able to parse the payload sec" +
                    "tion of message type 27: Long-range Automatic Identifcation System Broadcast Mes" +
                    "sage", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Message Type")]
        public void MessageType()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Message Type", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 8
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 9
    testRunner.When("I parse \'KC5E2b@U19PFdLbMuc5=ROv62<7m\' with padding 0 as a Long-range Automatic I" +
                        "dentifcation System Broadcast Message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 10
    testRunner.Then("NmeaAisLongRangeBroadcastMessageParser.Type is 27", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Full message")]
        [NUnit.Framework.TestCaseAttribute("KC5E2b@U19PFdLbMuc5=ROv62<7m", "0", "27", "1", "206914217", "false", "false", "2", "82214", "2904", "57", "167", "false", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Kp15Li@1D=MeT5T@", "0", "27", "3", "538008773", "false", "false", "0", "21557", "-18744", "11", "68", "false", "false", null)]
        [NUnit.Framework.TestCaseAttribute("Kk=>UB03fbh:R`7d", "0", "27", "3", "215197000", "false", "false", "0", "61099", "1349", "16", "123", "false", "false", null)]
        public void FullMessage(string payload, string padding, string type, string repeatindicator, string mmsi, string accuracy, string raimflag, string navigationstatus, string longitude, string latitude, string sog, string cog, string latency, string spare94, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("payload", payload);
            argumentsOfScenario.Add("padding", padding);
            argumentsOfScenario.Add("type", type);
            argumentsOfScenario.Add("repeatindicator", repeatindicator);
            argumentsOfScenario.Add("mmsi", mmsi);
            argumentsOfScenario.Add("accuracy", accuracy);
            argumentsOfScenario.Add("raimflag", raimflag);
            argumentsOfScenario.Add("navigationstatus", navigationstatus);
            argumentsOfScenario.Add("longitude", longitude);
            argumentsOfScenario.Add("latitude", latitude);
            argumentsOfScenario.Add("sog", sog);
            argumentsOfScenario.Add("cog", cog);
            argumentsOfScenario.Add("latency", latency);
            argumentsOfScenario.Add("spare94", spare94);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Full message", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 12
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 13
    testRunner.When(string.Format("I parse \'{0}\' with padding {1} as a Long-range Automatic Identifcation System Bro" +
                            "adcast Message", payload, padding), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 14
    testRunner.Then(string.Format("NmeaAisLongRangeBroadcastMessageParser.Type is {0}", type), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 15
    testRunner.And(string.Format("NmeaAisLongRangeBroadcastMessageParser.RepeatIndicator is {0}", repeatindicator), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
    testRunner.And(string.Format("NmeaAisLongRangeBroadcastMessageParser.Mmsi is {0}", mmsi), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
    testRunner.And(string.Format("NmeaAisLongRangeBroadcastMessageParser.PositionAccuracy is {0}", accuracy), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
    testRunner.And(string.Format("NmeaAisLongRangeBroadcastMessageParser.RaimFlag is {0}", raimflag), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
    testRunner.And(string.Format("NmeaAisLongRangeBroadcastMessageParser.NavigationStatus is {0}", navigationstatus), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
    testRunner.And(string.Format("NmeaAisLongRangeBroadcastMessageParser.Longitude10thMins is {0}", longitude), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
    testRunner.And(string.Format("NmeaAisLongRangeBroadcastMessageParser.Latitude10thMins is {0}", latitude), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
    testRunner.And(string.Format("NmeaAisLongRangeBroadcastMessageParser.SpeedOverGround is {0}", sog), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
    testRunner.And(string.Format("NmeaAisLongRangeBroadcastMessageParser.CourseOverGround is {0}", cog), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
    testRunner.And(string.Format("NmeaAisLongRangeBroadcastMessageParser.PositionLatency is {0}", latency), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
    testRunner.And(string.Format("NmeaAisLongRangeBroadcastMessageParser.SpareBit94 is {0}", spare94), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion