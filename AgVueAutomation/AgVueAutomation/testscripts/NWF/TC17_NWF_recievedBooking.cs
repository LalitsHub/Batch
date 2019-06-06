using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.NWF
{
    class TC17_NWF_recievedBooking
    {
        /// <summary>
        /// Test Case : Credit Request Closing - Recieve Signed Docs and Send For Booking
        /// Test Steps :
        //        Select Admin tab.Then select "Cases"
        //Search with the case number and click on Search button
        //Select "Booking Request" and then click on Reassign button
        //Enter user name to search and click on search button
        //Select the search user displayed and click on Reassign button.
        //Then click on Finish button then close the case window displayed
        //Search with the case number and click on Search button
        //Select "Booking Request" task
        //Select the Booking Request checkbox
        //Click on "Submit" button
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC17NWF");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<NWF_TC_17>>", "<<Credit Request Closing - Recieve Signed Docs and Send For Booking>>", "<<Credit Request Closing - Recieve Signed Docs and Send For Booking>>", "PASS");

                string idcase = pages.NWFCreditRequestcs.fetchCaseID();
                pages.mainMenu.selectAdminCases();
                pages.NWFCreditRequestcs.searchCase(idcase);
                pages.NWFCreditRequestcs.clickBookingRequest();
                pages.NWFCreditRequestcs.reassignUser(dtResult[0]["TestData1"].ToString());

                pages.NWFCreditRequestcs.searchCaseIdWithBookingRequest(idcase);
            }
        }
    }
}
