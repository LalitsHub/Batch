using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.NWF
{
    class TC12_NWF_clearFileForClosing
    {
        /// <summary>
        /// Test Case : Clear File for Closing
        /// Test Steps :
        //        Select Admin tab.Then select "Cases"
        //Search with the case number and click on Search button
        //Select "Clear File for Closing" and then click on Reassign button
        //Enter user name to search and click on search button
        //Select the search user displayed and click on Reassign button.
        //Then click on Finish button then close the case window displayed
        //Search with the case number and click on Search button
        //Select "Clear File for Closing" task
        //Select Loan Action Tab
        //Select CD Processing LO
        //Select CD Rec./Serv./L/O
        //Select CD MLO/S.A.F.E.
        //Click on "Submit" button
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC12NWF");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<NWF_TC_12>>", "<<Clear File for Closing>>", "<<Clear File for Closing>>", "PASS");

                string idcase = pages.NWFCreditRequestcs.fetchCaseID();
                pages.mainMenu.selectAdminCases();
                pages.NWFCreditRequestcs.searchCase(idcase);
                pages.NWFCreditRequestcs.clickClearFileforClosing();
                pages.NWFCreditRequestcs.reassignUser(dtResult[0]["TestData1"].ToString());
                pages.NWFCreditRequestcs.seacrWithCaseId(idcase);
                pages.NWFCreditRequestcs.selectCaseFromInboxHavingText_ClearFileforClosing();
                
                pages.NWFCreditRequestcs.selectCDSubmit(dtResult[0]["TestData2"].ToString(), dtResult[0]["TestData3"].ToString(), dtResult[0]["TestData4"].ToString());
            }
        }
    }
}
