using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.NWF
{
    class TC23_NWF_postAuditClose
    {
        /// <summary>
        /// Test Case : Credit Request Closing - Next Day verification
        /// Test Steps :
        //        Select Admin tab.Then select "Cases"
        //Search with the case number and click on Search button
        //Select "PostAuditClose" and then click on Reassign button
        //Enter user name to search and click on search button
        //Select the search user displayed and click on Reassign button.
        //Then click on Finish button then close the case window displayed
        //Search with the case number and click on Search button
        //Select "PostAuditClose" task
        //Select the Independent Verified Checkbox
        //CLick on Post-Close Checklist tab
        //Select the 'Complete' option for Post-Close Status1
        //Select the 'Complete' option for Post-Close Status2
        //Select the 'Complete' option for Post-Close Status3
        //Select the 'Complete' option for Post-Close Status4
        //Select the 'Complete' option for Post-Close Status5
        //Select the 'Complete' option for Post-Close Status6
        //Click on "Submit" button
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC23NWF");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<NWF_TC_23>>", "<<Receive and Scan Documents>>", "<<Receive and Scan Documents>>", "PASS");

                string idcase = pages.NWFCreditRequestcs.fetchCaseID();
                pages.mainMenu.selectAdminCases();
                //System.Threading.Thread.Sleep(3000);
                pages.NWFCreditRequestcs.searchCase(idcase);
                pages.NWFCreditRequestcs.clickPostAuditClose();
                pages.NWFCreditRequestcs.reassignUser(dtResult[0]["TestData1"].ToString());

                pages.NWFCreditRequestcs.searchCaseIdWithPostAuditClose(idcase);
            }
        }
    }
}
