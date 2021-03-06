
/*
*  Warewolf - The Easy Service Bus
*  Copyright 2014 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/


// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18063
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Dev2.Activities.Specs.Toolbox.Resources.Service.PluginService
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.IgnoreAttribute()]
    public partial class PluginServiceExecutionFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PluginServiceExecution.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PluginServiceExecution", "In order to use PluginService \r\nAs a Warewolf user\r\nI want a tool that calls the " +
                    "PluginServices into the workflow", ProgrammingLanguage.CSharp, new string[] {
                        "ignore"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "PluginServiceExecution")))
            {
                Dev2.Activities.Specs.Toolbox.Resources.Service.PluginService.PluginServiceExecutionFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Executing PluginService using input data")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "PluginServiceExecution")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        public virtual void ExecutingPluginServiceUsingInputData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Executing PluginService using input data", new string[] {
                        "mytag"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
      testRunner.Given("I have a PluginService \"emails\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
   testRunner.And("the input host is \"smtp.gmail.com\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
   testRunner.And("the input port is \"25\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
   testRunner.And("the input from is \"warewolfteam@dev2.co.za\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
   testRunner.And("the input to is \"development@dev2.co.za\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
   testRunner.And("the input subject is \"email from dev2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
   testRunner.And("the input body is \"email from warewolf plugin\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
      testRunner.And("the output is mapped as \"[[result]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
      testRunner.When("the Service is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
      testRunner.Then("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Host",
                        "Port",
                        "From Account",
                        "To Account",
                        "Subject",
                        "Body"});
            table1.AddRow(new string[] {
                        "smtp.gmail.com",
                        "25",
                        "warewolfteam@dev2.co.za",
                        "development@dev2.co.za",
                        "email from dev2",
                        "email from warewolf plugin"});
#line 19
   testRunner.And("the debug input as", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "[[result]] = Email sent from warewolfteam@dev2.co.za"});
#line 22
   testRunner.And("the debug output as", ((string)(null)), table2, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Executing PluginService with recordset as input data")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "PluginServiceExecution")]
        public virtual void ExecutingPluginServiceWithRecordsetAsInputData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Executing PluginService with recordset as input data", ((string[])(null)));
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
      testRunner.Given("I have a PluginService \"emails\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
   testRunner.And("the input host is \"[[rec(*).a]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
   testRunner.And("the input port is \"[[res(*).a]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
   testRunner.And("the input from is \"warewolfteam@dev2.co.za\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
   testRunner.And("the input to is \"development@dev2.co.za\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
   testRunner.And("the input subject is \"email from dev2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
   testRunner.And("the input body is \"email from warewolf plugin\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
      testRunner.And("the output is mapped as \"[[result]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
      testRunner.When("the Service is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
      testRunner.Then("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Host",
                        "Port",
                        "From Account",
                        "To Account",
                        "Subject",
                        "Body"});
            table3.AddRow(new string[] {
                        "[[rec(*).a]]",
                        "[[res(*).a]]",
                        "warewolfteam@dev2.co.za",
                        "development@dev2.co.za",
                        "email from dev2",
                        "email from warewolf plugin"});
#line 37
   testRunner.And("the debug input as", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "[[result]] ="});
#line 40
   testRunner.And("the debug output as", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Executing PluginService with scalar as input data")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "PluginServiceExecution")]
        public virtual void ExecutingPluginServiceWithScalarAsInputData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Executing PluginService with scalar as input data", ((string[])(null)));
#line 44
this.ScenarioSetup(scenarioInfo);
#line 45
      testRunner.Given("I have a PluginService \"emails\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 46
   testRunner.And("the input host is \"[[scalar]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
   testRunner.And("the input port is \"25\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
   testRunner.And("the input from is \"warewolfteam@dev2.co.za\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
   testRunner.And("the input to is \"development@dev2.co.za\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
   testRunner.And("the input subject is \"email from dev2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
   testRunner.And("the input body is \"email from warewolf plugin\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
      testRunner.And("the output is mapped as \"[[result]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
      testRunner.When("the Service is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
      testRunner.Then("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Host",
                        "Port",
                        "From Account",
                        "To Account",
                        "Subject",
                        "Body"});
            table5.AddRow(new string[] {
                        "[[rec(*).a]]",
                        "[[res(*).a]]",
                        "warewolfteam@dev2.co.za",
                        "development@dev2.co.za",
                        "email from dev2",
                        "email from warewolf plugin"});
#line 55
   testRunner.And("the debug input as", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "[[result]] ="});
#line 58
   testRunner.And("the debug output as", ((string)(null)), table6, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Executing a puginservice with invalid input data")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "PluginServiceExecution")]
        public virtual void ExecutingAPuginserviceWithInvalidInputData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Executing a puginservice with invalid input data", ((string[])(null)));
#line 61
this.ScenarioSetup(scenarioInfo);
#line 62
         testRunner.Given("I have a PluginService \"IntegrationTestPluginEmptyToNull\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 63
   testRunner.And("the input sender is \"warewolf@dev2.co.za\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
   testRunner.And("the input testtype is \"warewolf@dev2.co.za\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
   testRunner.And("the output is mapped as \"[[result]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
   testRunner.When("the Service is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
   testRunner.Then("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Sender",
                        "TestType"});
            table7.AddRow(new string[] {
                        "warewolf@dev2.co.za",
                        "warewolf@dev2.co.za"});
#line 68
   testRunner.And("the debug input as", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "[[result]] ="});
#line 71
   testRunner.And("the debug output as", ((string)(null)), table8, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
