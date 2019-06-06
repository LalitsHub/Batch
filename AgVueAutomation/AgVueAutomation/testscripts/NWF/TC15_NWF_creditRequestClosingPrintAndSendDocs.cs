using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.NWF
{
    class TC15_NWF_creditRequestClosingPrintAndSendDocs
    {
        /// <summary>
        /// Test Case : Credit Request Closing - Print and Send Documents
        /// Test Steps :
        //        Select Admin tab.Then select "Cases"
        //Search with the case number and click on Search button
        //Select "<Print and Send Documents" and then click on Reassign button
        //Enter user name to search and click on search button
        //Select the search user displayed and click on Reassign button.
        //Then click on Finish button then close the case window displayed
        //Search with the case number and click on Search button
        //Select "Print and Send Documents" task
        //Select the Documents Printed Checkbox
        //Click on "Submit" button
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC15NWF");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<NWF_TC_15>>", "<<Print and Send Documents>>", "<<Print and Send Documents>>", "PASS");

                string idcase = pages.NWFCreditRequestcs.fetchCaseID();
                pages.mainMenu.selectAdminCases();
                pages.NWFCreditRequestcs.searchCase(idcase);
                pages.NWFCreditRequestcs.clickPrintandSentDocuments();
                pages.NWFCreditRequestcs.reassignUser(dtResult[0]["TestData1"].ToString());

                pages.NWFCreditRequestcs.searchCaseIdWithPrintandSendDocs(idcase);

            }
        }
    }
}
