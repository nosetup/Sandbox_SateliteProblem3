#region Credits
/* 
 * Solving a Satelite Problem
 * by N Diep
*/
#endregion
#region Namespace Inclusions
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

using System.IO;
using System.Data.Odbc;
using System.Drawing;


// User Added Namespace


#endregion
namespace LogTerminal
{
    #region Public Enumerations
    public enum LogMsgType { Incoming, Outgoing, MsgFromApp, Normal, Warning, Error };
    #endregion

    public partial class FrmTerminal : Form
    {

        #region Local Variables
        public static string TraceClass;
        public const string SystemAppName = "SateliteProblem";
        #endregion

        #region Constructor
        private AboutBox _aboutBoxForm;

        #endregion

        #region Local Properties
        public FrmTerminal()
        {
            TraceClass = GetType().Name; // Assign the class name to the static variable


            // Build the form
            InitializeComponent();
            InitializeScriptDataGridView();

            MenuStripTerminal.Visible = false;
            ToolStripButtons.Visible = false;
        }

        private void InitializeScriptDataGridView()
        {
            // Set up columns
            Dgv_SolutionLog.ColumnCount = 3;

            // Set column names
            Dgv_SolutionLog.Columns[0].Name = "Info";
            Dgv_SolutionLog.Columns[1].Name = "Results";
            Dgv_SolutionLog.Columns[2].Name = "Score";

            // Set column widths
            Dgv_SolutionLog.Columns[0].Width = 400; // Set the width of the first column
            Dgv_SolutionLog.Columns[0].Frozen = true; // Make the second column a fixed size
            Dgv_SolutionLog.Columns[0].Resizable = DataGridViewTriState.False;
            Dgv_SolutionLog.Columns[1].Width = 300; // Set the width of the first column
            Dgv_SolutionLog.Columns[1].Frozen = true; // Make the second column a fixed size
            Dgv_SolutionLog.Columns[1].Resizable = DataGridViewTriState.False;
            Dgv_SolutionLog.Columns[2].Width = 100; // Set the width of the first column
            Dgv_SolutionLog.Columns[2].Frozen = true; // Make the second column a fixed size
                                                      // Add a new row and set values in each column
            Dgv_SolutionLog.Rows.Add("WELCOME", "WELCOME", "");
        }
        #endregion

        #region Local Methods

        static TimeSpan TIMEOUT = TimeSpan.FromSeconds(600);
        public void TestFactor(string TestPath)
        {

            string[] args = { "1", TestPath };

            TestUtil.Check(args.Length == 2, $"USAGE: {AppDomain.CurrentDomain.FriendlyName} OUT_PATH TEST_CASE");

            string outPath = args[0];
            string testCase = args[1];

            var scenario = new Scenario(testCase);

            Console.WriteLine($"Scenario: {scenario.MinCoverage:P2} coverage ({scenario.Users.Count} users, {scenario.Sats.Count} sats)");

            var start = DateTime.Now;
            var solution = SLinkSolution.Solve(scenario.Users, scenario.Sats);
            var duration = DateTime.Now - start;
            var covered = (double)solution.Count / scenario.Users.Count;

            Console.WriteLine(
                $"Solution: {(covered * 100):F2}% " +
                $"coverage ({solution.Count} users) " +
                //$"in {(duration > TIMEOUT ? TestUtil.RED : duration > TIMEOUT / 2 ? TestUtil.YELLOW : TestUtil.GREEN)}" +
                $"{duration.TotalSeconds:F2}s"
            );

            Dgv_SolutionLog.Rows.Add($"Scenario: {scenario.MinCoverage:P2} coverage ({scenario.Users.Count} users, {scenario.Sats.Count} sats)   " +
                $"({scenario.MinCoverage * scenario.Users.Count} min , {scenario.Sats.Count * 32} max users)"
                , $"Solution: {(covered * 100):F2}% " +
                $"coverage ({solution.Count} users) " +
                //$"in {(duration > TIMEOUT ? TestUtil.RED : duration > TIMEOUT / 2 ? TestUtil.YELLOW : TestUtil.GREEN)}" +
                $"{duration.TotalSeconds:F2}s", $"{(covered) / scenario.MinCoverage:P2}");

            //using (var writer = new StreamWriter(outPath, true))
            //{
            //    writer.WriteLine($"{testCase,-44} {(covered * 100),6:F2}% {duration.TotalSeconds,6:F2}s");
            //}

            TestUtil.Check(duration < TIMEOUT, $"Took too long to produce a solution.. duration={duration}");

            scenario.Check(solution);
        }

        /// <summary>
        /// Open Window About Box</summary>
        private void OpenWindowAboutBox()
        {
            // Check if the form is null or has been closed
            if (_aboutBoxForm == null || _aboutBoxForm.IsDisposed)
            {
                _aboutBoxForm = new AboutBox
                {
                    TopMost = true // Set the form to always be on top
                };
                _aboutBoxForm.Show();
            }
            else
            {
                // If the form is already open, bring it to the front
                _aboutBoxForm.BringToFront();
            }
        }

        public static void LogMessage (DataGridView dgv, string info, string results, string score)
        {
            dgv.Rows.Add(info, results, score);
        }

    #endregion // Local Methods

        #region Event Handlers
        #region Event Handlers > Main Form
        private void FrmTerminal_Load(object sender, EventArgs e)
        {

        }
        private void FrmTerminal_Shown(object sender, EventArgs e)
        {
        }
        private void FrmTerminal_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        #endregion
        #region Events Handlers > Tool Strip Menu Item 
        private void TsmLogsOpen_Click(object sender, EventArgs e)
        {
        }
        private void TsmLogsSaveAs_Click(object sender, EventArgs e)
        {
        }
        private void TsmTVControls_Click(object sender, EventArgs e)
        {
        }
        private void TsmScriptOpen_Click(object sender, EventArgs e)
        {
        }
        private void TsmScriptSaveAs_Click(object sender, EventArgs e)
        {
        }
        private void TsmAutoReplyOpen_Click(object sender, EventArgs e)
        {
        }
        private void TsmAutoReplySaveAs_Click(object sender, EventArgs e)
        {
        }
        private void TsmiFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void TsmiFileLogs_Click(object sender, EventArgs e)
        {

        }
        private void TsmiAbout_Click(object sender, EventArgs e)
        {
            OpenWindowAboutBox();
        }
        #endregion
        #region Event Handlers > Tool Strip Button Click
        private void TsbtnTVControls_Click(object sender, EventArgs e)
        {

        }
        private void TsbtnConnect_Click(object sender, EventArgs e)
        {

        }
        private void TsbtnDisconnect_Click(object sender, EventArgs e)
        {

        }
        private void TsbtnLogOpen_Click(object sender, EventArgs e)
        {
        }
        private void TsbtnLogSaveAs_Click(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// Add space for Console / Trace Writeline</summary>
        private void TsbtnClearConsole_Click(object sender, EventArgs e)
        {
            Trace.WriteLine($"\n\n");
        }
        #endregion // Event Handler Tool Strip Button Click
        #region Event Handlers > Form Change
         private void TimerScript_Tick(object sender, EventArgs e)
        {
        }
#endregion
        #region Events Handlers > Form Button Click
        private void BtnServerConnect_Click(object sender, EventArgs e)
        {
            TestFactor("../../test/01_two_users.txt");
        }

        private void BtnTest2_Click(object sender, EventArgs e)
        {
            TestFactor("../../test/02_five_users.txt");
        }

        private void BtnTest3_Click(object sender, EventArgs e)
        {
            TestFactor("../../test/03_equatorial_band.txt");
        }

        private void BtnTest4_Click(object sender, EventArgs e)
        {
            TestFactor("../../test/04_five_thousand.txt");
        }

        private void BtnTest5_Click(object sender, EventArgs e)
        {
            TestFactor("../../test/05_fifty_thousand_low_coverage.txt");
        }

        private void BtnTest6_Click(object sender, EventArgs e)
        {
            TestFactor("../../test/06_ten_thousand.txt");
        }
        #endregion // Events Handler Form Button Click

        #endregion // Event Handlers

        private void BtnClientDisconnect_Click(object sender, EventArgs e)
        {
                    
            TestFactor("../../test/alt01_two_users.txt");
        
        }
    }

    public class SLinkSolution
    {
        public static Dictionary<User, (Sat, Color)> Solve(Dictionary<User, Vector3> users, Dictionary<Sat, Vector3> sats)
        {
            Console.WriteLine($"Starting Solution Generator");
            // TODO: Implement.
            // Given entire dictionary
            // 
            // Color = A, B, C, D

            var UsersOnline = users.Count;
            var SatOnline = sats.Count;
            var Vectorutilities = new Vector3(0, 0, 0);

            var solution = new Dictionary<User, (Sat, Color)>();


            //Console.WriteLine($"Using AngleBetweenSatUser1User2=  '" +
            //    AngleBetweenSatUser1User2(new Vector3(1583.8425f, -6737.3351f, 0.0000f),
            //                              new Vector3(1598.2020f, -6166.9997f, -59.2118f),
            //                              new Vector3(1689.2813f, -6142.6886f, -57.8504f)) + " ' \n");

            //Console.WriteLine($"Using AngleBetweenSatUser1User2=  '" +
            //    AngleBetweenSatUser1User2(new Vector3(6906.9929f, -440.1023f, 0.0000f),
            //                              new Vector3(6368.2940f, -178.9925f, -49.3330f),
            //                              new Vector3(6369.9657f, -70.5618f, -90.5491f)) + " ' \n");

            //solution = ProcessSateliteAndUsers(solution, users, sats);
            solution = ProcessSateliteAndUsers2(solution, users, sats);

            Console.WriteLine($"Solution has been generated");
            return solution;
        }

        public static Dictionary<User, (Sat, Color)> ProcessSateliteAndUsers(Dictionary<User, (Sat, Color)> currentSolution, Dictionary<User, Vector3> orphanUsers, Dictionary<Sat, Vector3> orphanSats)
        {
            var updatedSolution = new Dictionary<User, (Sat, Color)>();
            var MaxUsersLimit = 32;
            var SatAngleLimit = 45;
            var BeamCollisionLimit = 10;


            Dictionary<Sat, int> counterSateliteSlotsAvailable = new Dictionary<Sat, int>(); // Tracks number of users online for satelite
            Dictionary<Sat, int> counterSatelitesPerUser = new Dictionary<Sat, int>(); // Counts total Satelite within User Range
            Dictionary<User, int> counterUsersPerSatelite = new Dictionary<User, int>(); //Counts total User within specific Satelite Range


            // Create to counterSatelitesPerUser.Add(user, counter); Number of Satelites per user
            foreach (var satEntry in orphanSats)
            {
                var sat = satEntry.Key;
                var satPosition = satEntry.Value;
                counterSateliteSlotsAvailable[sat] = MaxUsersLimit;
                var counter = 0;

                foreach (var userEntry in orphanUsers)
                {
                    var user = userEntry.Key;
                    var userPosition = userEntry.Value;
                    var angleBetweenUserAndSat = AngleBetweenSatUser(satPosition, userPosition);

                    if (angleBetweenUserAndSat <= SatAngleLimit)
                    {
                        counter++;
                        counterSatelitesPerUser[sat] = counter;
                    }
                }
            }

            Console.WriteLine($" Counts total Satelites that can provide service ='{counterSatelitesPerUser.Count}'"); // uncomment to see counter status

            // Create to counterUsersPerSatelite.Add(sat, counter); Number of Users per Satelite
            // Note: Any user that is not in this list is Out of range for service.
            foreach (var userEntry in orphanUsers)
            {
                var user = userEntry.Key;
                var userPosition = userEntry.Value;
                var counter = 0;

                foreach (var satEntry in orphanSats)
                {
                    var sat = satEntry.Key;
                    var satPosition = satEntry.Value;
                    // var angleBetweenUserAndSat = Vectorutilities.AngleBetween(satPosition, userPosition);
                    var angleBetweenUserAndSat = AngleBetweenSatUser(satPosition, userPosition);
                    //Console.WriteLine($"testing  user='{user}' satelite='{sat}' angle='{angleBetweenUserAndSat}'"); // uncomment to see the calculated angle

                    if (angleBetweenUserAndSat <= SatAngleLimit)
                    {
                        counter++;
                        // Console.WriteLine($"user='{user}' counter'{counter}'"); // uncomment to see counter status
                        counterUsersPerSatelite[user] = counter;
                    }
                }
            }

            Console.WriteLine($" Counts total Users that is in range of service ='{counterUsersPerSatelite.Count}'"); // uncomment to see counter status

            // Start reducing the size of Satelites and Users
            // The idea is we would like to work on Satelites / Users with least number of option for connectivity first

            // TODO: NOTE: FROM TESTING, THIS SORTING MADE RESULTS A LITTLE WORST
            // We first want to sort the Satelites counter from least to most.
            var sortedSatDict = counterSatelitesPerUser.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            counterSatelitesPerUser = sortedSatDict;

            // TODO: NOTE: FROM TESTING, THIS SORTING MADE RESULTS A LITTLE WORST
            // Similarly we can sort the User counter from least to most.
            var sortedUserDict = counterUsersPerSatelite.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            counterUsersPerSatelite = sortedUserDict;

            //Next we can try to start Assigning User to a Satelites

            // A. For each Satelite will pick out the top 32 nearest to its center beam (lowest angle)
            // B. To do this the Satelite will make a list of all Users and get the angle relative to the Satelite.
            // C. Next it will sort from cloest to furthest
            // D. Go thru this list and attempt to assign a beam.
            // E. Finally when Successful, the User will be removed from counterSatelitesPerUser.
            foreach (var satEntry in counterSatelitesPerUser) // This is main Satelite loop that assigns user to satelite
            {
                Dictionary<User, float> UserSateliteAngle = new Dictionary<User, float>();
                var satEntryKeyVar = satEntry.Key;
                var satPosition = orphanSats[satEntryKeyVar]; // Get the Satelite Position from Main list

                // Create dictionary with this Satelite that contains "User" and "Angle", named "UserSateliteAngle" for this session
                // We will only save the User Key if angle is less than 45. This means for this Satelite, these users are within its service area.
                foreach (var userEntry in counterUsersPerSatelite)
                {
                    var userPosition = orphanUsers[userEntry.Key];
                    var angleBetweenUserAndSat = AngleBetweenSatUser(satPosition, userPosition);

                    if (angleBetweenUserAndSat <= SatAngleLimit) // For this specific satelite, if users is in range Store the User Name and Angle
                    {
                        UserSateliteAngle[userEntry.Key] = angleBetweenUserAndSat;
                    }
                }

                // TODO: NOTE: This sorting made it a little worst
                // Rearrange with Angles Closest to Furthest
                var sortedUserAngles = UserSateliteAngle.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
                UserSateliteAngle = sortedUserAngles; // For this Satelite, Sort all of the angles

                Dictionary<User, Vector3> SateliteBeamAAngle = new Dictionary<User, Vector3>();
                Dictionary<User, Vector3> SateliteBeamBAngle = new Dictionary<User, Vector3>();
                Dictionary<User, Vector3> SateliteBeamCAngle = new Dictionary<User, Vector3>();
                Dictionary<User, Vector3> SateliteBeamDAngle = new Dictionary<User, Vector3>();

                // TODO: Improvement: This could be improved to be more intelligent
                // Perhaps a smarter loop + discard. Currently this is done in order.

                // Iterate on dictionary containing User Name + Angle from Satelite
                // This will assign a temporary beam from Satelite to User
                if (UserSateliteAngle.Count != 0) // Be safe before starting; ensure we are not null
                {
                    int currentColor = 1; // Initialize the color

                    // Iterate over the sorted user-satellite angle dictionary
                    foreach (var currentUserEntry in UserSateliteAngle)
                    {
                        var currentUserKey = currentUserEntry.Key;

                        if (currentColor == 1 ||
                            AngleBetweenSatUser1User2(satPosition, orphanUsers[currentUserKey], orphanUsers[UserSateliteAngle.ElementAt(currentColor - 2).Key]) < BeamCollisionLimit)
                        {
                            try
                            {
                                switch (currentColor)
                                {
                                    case 1:
                                        SateliteBeamAAngle.Add(currentUserKey, orphanUsers[currentUserKey]);
                                        break;
                                    case 2:
                                        SateliteBeamBAngle.Add(currentUserKey, orphanUsers[currentUserKey]);
                                        break;
                                    case 3:
                                        SateliteBeamCAngle.Add(currentUserKey, orphanUsers[currentUserKey]);
                                        break;
                                    case 4:
                                        SateliteBeamDAngle.Add(currentUserKey, orphanUsers[currentUserKey]);
                                        break;
                                    default:
                                        break;
                                }
                            }
                            catch (Exception ex)
                            {
                                Trace.WriteLine($"ERROR AT {currentColor} '{currentUserKey}': : {ex.Message}");
                            }
                        }
                        else // Maintain the same color if the angle is >= 10
                        {
                            switch (currentColor)
                            {
                                case 1:
                                    SateliteBeamAAngle.Add(currentUserKey, orphanUsers[currentUserKey]);
                                    break;
                                case 2:
                                    SateliteBeamBAngle.Add(currentUserKey, orphanUsers[currentUserKey]);
                                    break;
                                case 3:
                                    SateliteBeamCAngle.Add(currentUserKey, orphanUsers[currentUserKey]);
                                    break;
                                case 4:
                                    SateliteBeamDAngle.Add(currentUserKey, orphanUsers[currentUserKey]);
                                    break;
                                default:
                                    break;
                            }
                        }

                        currentColor = (currentColor % 4) + 1; // Increment color in a cyclic manner (1->2->3->4->1->...)
                    }
                }

                // Check for beam interference check
                // By going to each beam and doing a cross compare.
                // There need to be at least 2 Beams present for interference.

                // Call the method for each satellite beam dictionary, passing UserSateliteAngle, satPosition, and satEntry as parameters
                RemoveInterferingKeys(SateliteBeamAAngle, UserSateliteAngle, satPosition);
                RemoveInterferingKeys(SateliteBeamBAngle, UserSateliteAngle, satPosition);
                RemoveInterferingKeys(SateliteBeamCAngle, UserSateliteAngle, satPosition);
                RemoveInterferingKeys(SateliteBeamDAngle, UserSateliteAngle, satPosition);


                // At this point, a satelite has assigned beams for several clients.
                // We also checked if there are interference
                // first lets see what is our current count
                // TODO: We need an intelligent want to remove clients because just trimming all equally doesn't make sense.
                // ideally you would want to trim the Beam with most connection this way would improve probablity for a connection.

                var usercounter = 0;
                usercounter = SateliteBeamAAngle.Count + SateliteBeamBAngle.Count + SateliteBeamCAngle.Count + SateliteBeamDAngle.Count;
                if (usercounter > MaxUsersLimit && UserSateliteAngle.Count != 0) // we have too many clients
                {
                    var i = 0;
#if DEBUG
                    Trace.WriteLine($"EXCEEDED CAPACITY REACHED FOR THIS SATELITE='{satEntry}' clients='{usercounter}' of 32 max");
#endif
                    // Proceed to shead weight
                    while (usercounter > MaxUsersLimit)
                    {
#if DEBUG
    Trace.WriteLine($"WEIGHT LOSS PROGRESS SATELITE='{satEntry}' clients='{usercounter}' of 32 max");
#endif
                        try
                        {
                            var beamAngleCollections = new List<Dictionary<User, Vector3>>
                            {
                                SateliteBeamAAngle,
                                SateliteBeamBAngle,
                                SateliteBeamCAngle,
                                SateliteBeamDAngle
                            };
                            foreach (var beamAngleCollection in beamAngleCollections)
                            {
                                if (beamAngleCollection.Count != 0)
                                {
                                    // Remove the first element from the collection
                                    var firstKey = beamAngleCollection.First().Key;
                                    beamAngleCollection.Remove(firstKey);

                                    // Update user counter
                                    usercounter = SateliteBeamAAngle.Count + SateliteBeamBAngle.Count + SateliteBeamCAngle.Count + SateliteBeamDAngle.Count;

                                    // Break the loop if usercounter is less than or equal to 32
                                    if (usercounter <= MaxUsersLimit)
                                        break;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Trace.WriteLine($"ERROR TRYING TO LOSE WEIGHT: SATELITE='{satEntry}' i='{i}': {ex.Message}");
                            // Handle exceptions
                        }
                    }
                }
                // Update the slots available
                counterSateliteSlotsAvailable[satEntry.Key] = usercounter;

                // Start Assembling the submitted solution
                // At this point, we should not have any more interference
                // We will now merge the 4 Beams from this specific Satelite into 1 Solution. 
                // As this loops, this will repeat this for all Satelites until the solution is built.

                Dictionary<Dictionary<User, Vector3>, int> beamColorMap = new Dictionary<Dictionary<User, Vector3>, int>
                {
                    { SateliteBeamAAngle, 1 },
                    { SateliteBeamBAngle, 2 },
                    { SateliteBeamCAngle, 3 },
                    { SateliteBeamDAngle, 4 }
                };

                // Iterate over each beam angle collection and start building the solution
                foreach (var kvp in beamColorMap)
                {
                    Dictionary<User, Vector3> beamAngleCollection = kvp.Key;
                    int color = kvp.Value;

                    foreach (var userVectorPair in beamAngleCollection)
                    {
                        var user = userVectorPair.Key;
                        var vector = userVectorPair.Value;

                        try
                        {
                            updatedSolution.Add(user, (satEntryKeyVar, IntToColor(color)));
                            counterUsersPerSatelite.Remove(user);
                        }
                        catch (Exception ex)
                        {
                            // Handle exceptions
                            Trace.WriteLine($"ERROR ADDING {user} for beam angle collection: {ex.Message}");
                        }
                    }
                }
            }

            Trace.WriteLine($"ORPHAN COUNT {counterUsersPerSatelite.Count}");
            // We now have a Preliminary Solution dictionary "solution"
            // We have a count 
            #region Focus Method D)

            #endregion

            //foreach (var remainingUser in counterUsersPerSatelite)
            //{
            //    var remainingUserPos = orphanUsers[remainingUser.Key];
            //    foreach (var entry in updatedSolution)
            //    {
            //        var user = entry.Key;
            //        var (sat, color) = entry.Value;

            //        var updatedSolutionSatPos = orphanSats[sat];
            //        var updatedSolutionUserPos = orphanUsers[user];

            //        if (AngleBetweenSatUser1User2(updatedSolutionSatPos, updatedSolutionUserPos, remainingUserPos) >= 10 && AngleBetweenSatUser(updatedSolutionSatPos, remainingUserPos) <= 45)
            //        {
            //            Trace.WriteLine($"ORPHAN HAS HOPE ='{remainingUser.Key}'");
            //        }
            //    }
            //}



            return updatedSolution;
        }

        public static Dictionary<User, (Sat, Color)> ProcessSateliteAndUsers2(Dictionary<User, (Sat, Color)> currentSolution, Dictionary<User, Vector3> orphanUsers, Dictionary<Sat, Vector3> orphanSats)
        {
            var updatedSolution = new Dictionary<User, (Sat, Color)>();
            var maxUsers = 32;

            // TODO: FUTURE: if we want to reprocess existing list.
            // updatedSolution = currentSolution;

            Dictionary<Sat, int> counterSateliteSlotsAvailable = new Dictionary<Sat, int>(); // Tracks number of users online for satelite
            Dictionary<Sat, int> counterSatelitesPerUser = new Dictionary<Sat, int>(); // Counts total Satelite within User Range
            Dictionary<User, int> counterUsersPerSatelite = new Dictionary<User, int>(); //Counts total User within specific Satelite Range

            // Create counterSatelitesPerUser.Add(user, counter); Number of Satelites per user
            foreach (var satEntry in orphanSats)
            {
                var sat = satEntry.Key;
                var satPosition = satEntry.Value;
                counterSateliteSlotsAvailable[sat] = maxUsers;
                var counter = 0;

                foreach (var userEntry in orphanUsers)
                {
                    var user = userEntry.Key;
                    var userPosition = userEntry.Value;
                    //var angleBetweenUserAndSat = Vectorutilities.AngleBetween(satPosition, userPosition); // Fixes error since satelite and user is 180
                    var angleBetweenUserAndSat = AngleBetweenSatUser(satPosition, userPosition);

                    if (angleBetweenUserAndSat <= 45)
                    {
                        counter++;
                        //Console.WriteLine($"satelite='{sat}' counter'{counter}'"); // uncomment to see counter status
                        counterSatelitesPerUser[sat] = counter;
                    }
                }
            }
#if DEBUG
            Console.WriteLine($" Counts total Satelites that can provide service ='{counterSatelitesPerUser.Count}'"); // uncomment to see counter status
#endif
            // Create counterUsersPerSatelite.Add(sat, counter); Number of Users per Satelite
            // Note: Any user that is not in this list is Out of range for service.
            foreach (var userEntry in orphanUsers)
            {
                var user = userEntry.Key;
                var userPosition = userEntry.Value;
                var counter = 0;

                foreach (var satEntry in orphanSats)
                {
                    var sat = satEntry.Key;
                    var satPosition = satEntry.Value;
                    // var angleBetweenUserAndSat = Vectorutilities.AngleBetween(satPosition, userPosition);
                    var angleBetweenUserAndSat = AngleBetweenSatUser(satPosition, userPosition);
                    //Console.WriteLine($"testing  user='{user}' satelite='{sat}' angle='{angleBetweenUserAndSat}'"); // uncomment to see the calculated angle

                    if (angleBetweenUserAndSat <= 45)
                    {
                        counter++;
                        // Console.WriteLine($"user='{user}' counter'{counter}'"); // uncomment to see counter status
                        counterUsersPerSatelite[user] = counter;
                    }
                }
            }
#if DEBUG
            Console.WriteLine($" Counts total Users that is in range of service ='{counterUsersPerSatelite.Count}'"); // uncomment to see counter status
#endif

            // Start reducing the size of Satelites and Users
            // The idea is we would like to work on Satelites / Users with least number of option for connectivity first

            // TODO: NOTE: FROM TESTING, THIS IS NOT REQUIRED.. BUT DID IMPROVED RESULTS
            // We first want to sort the Satelites counter from least to most.
            var sortedSatDict = counterSatelitesPerUser.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            counterSatelitesPerUser = sortedSatDict;

            // TODO: NOTE: FROM TESTING, THIS IS NOT REQUIRED.. BUT DID IMPROVED RESULTS
            // Similarly we can sort the User counter from least to most.
            var sortedUserDict = counterUsersPerSatelite.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            counterUsersPerSatelite = sortedUserDict;

            // This is main Satelite loop that assigns user to satelite.
            // Next we can try to start Assigning User to all possible Satelites
            foreach (var satEntry in counterSatelitesPerUser) 
            {
                // Create dictionary with this Satelite that contains "User" and "Angle", named "UserSateliteAngle" for this session
                // We will only save the User Key if angle is less than 45. This means for this Satelite, these users are within its service area.
                Dictionary<User, Vector3> listOfUsersInRangeForThisSat = new Dictionary<User, Vector3>();
                var satEntryKeyVar = satEntry.Key;
                var satPosition = orphanSats[satEntryKeyVar]; // Get the Satelite Position from Main list
                foreach (var userEntry in counterUsersPerSatelite)
                {
                    var userPosition = orphanUsers[userEntry.Key];
                    var angleBetweenUserAndSat = AngleBetweenSatUser(satPosition, userPosition);

                    if (angleBetweenUserAndSat <= 45) // For this specific satelite, if users is in range Store the User Name and Angle
                    {
                        listOfUsersInRangeForThisSat[userEntry.Key] = userPosition;
                    }
                }

                // Iterate on dictionary containing User Name + Angle from Satelite
                // This will assign a temporary color from Satelite to User (ex: 1, 2, 3, 4.. etc)
                // We will go over list in updatedsolution to see if any problem with temporary color.
                // If problem exist then add to error counter / color cannot be used.
                // If no more color then the Satelite cannot connect to User due to exisiting interference.
                // If no error present, then color can be used.
                HashSet<User> keysToRemove = new HashSet<User>();
                if (listOfUsersInRangeForThisSat.Count != 0) // Be safe before starting; ensure we are not null
                {
                    var newSatUserCounter = 0;

                    foreach (var currentUserEntry in listOfUsersInRangeForThisSat)
                    {
                        var currentUserKey = currentUserEntry.Key;
                        var tempcolor = 1;
                        var colorErrorCounter = 0; // Do we see any problems with using this color
                        for (tempcolor = 1; tempcolor <= 4; tempcolor++) // Try 1st Color
                        {
                            // We only want to look at records of updateSolution with same color
                            foreach (var solutionEntry in updatedSolution)
                            {
                                var solutionUser = solutionEntry.Key;
                                var (solutionSat, solutionColor) = solutionEntry.Value;

                                // Check CurrentSatPosition against CurrentUser and MainUserList(Solution)
                                // Confirm color is the same
                                // Confirm if Satelite is Same because different Satelites can have same color.
                                if (AngleBetweenSatUser1User2(satPosition, currentUserEntry.Value, orphanUsers[solutionUser]) < 10
                                    && IntToColor(tempcolor) == solutionColor && satEntryKeyVar == solutionSat)
                                {
                                    // Interference present, cannot use this color
                                    colorErrorCounter++;
                                    break;
                                }
                                // Else our angle is > 10, proceed to check other records of same color
                            }

                            // we finished checking records, if no errors then okay to use this color
                            if (colorErrorCounter == 0)
                            {
                                updatedSolution.Add(currentUserKey, (satEntryKeyVar, IntToColor(tempcolor)));
                                newSatUserCounter++;
                                keysToRemove.Add(currentUserKey);
                                break;
                            }
                            else
                            {
                                // if error then we want to try the next color, lets reset our errorCounter.
                                colorErrorCounter = 0; 
                            }
                        }
                        if (newSatUserCounter >= maxUsers) break;
                    }

                    // Remove Users assigned to this Satelite so it won't need to be evaluated for next Satelite.
                    foreach (var key in keysToRemove)
                    {
                        counterUsersPerSatelite.Remove(key);
                    }

                }
            }
#if DEBUG
            Trace.WriteLine($"ORPHAN COUNT {counterUsersPerSatelite.Count}");
#endif
            return updatedSolution;
        }
        
        public static void RemoveInterferingKeys(Dictionary<User, Vector3> beamAngle, Dictionary<User, float> userSateliteAngle,Vector3 satPosition)
        {
            if (beamAngle.Count <= 1 || userSateliteAngle.Count == 0)
                return;

            HashSet<User> keysToRemove = new HashSet<User>();

            for (int i = 0; i < beamAngle.Count; i++)
            {
                for (int j = i + 1; j < beamAngle.Count; j++)
                {
                    try
                    {
                        var currentRecord = beamAngle.ElementAt(i);
                        var previousRecord = beamAngle.ElementAt(j);
                        var angleBetweenUser1AndUser2 = AngleBetweenSatUser1User2(satPosition, currentRecord.Value, previousRecord.Value);

                        if (angleBetweenUser1AndUser2 < 10)
                        {
#if DEBUG
                    Trace.WriteLine($"NOTICE: INTERFERENCE FOUND, REMOVING KEY {previousRecord.Key}, ANGLE ={angleBetweenUser1AndUser2}'");
#endif
                            keysToRemove.Add(previousRecord.Key);
                        }
                    }
                    catch (Exception ex)
                    {
                        Trace.WriteLine($"ERROR WITH Satellite Beam: {ex.Message}");
                    }
                }
            }

            foreach (var key in keysToRemove)
            {
                beamAngle.Remove(key);
            }
        }

        public static Color IntToColor (int value )
        {
            switch (value)
            {
                case 1:
                    return Color.A;
                case 2:
                    return Color.B;
                case 3:
                    return Color.C;
                case 4:
                    return Color.D;
                default:
                    return Color.A;
            }
        }

        public static float AngleBetweenSatUser (Vector3 satelite, Vector3 user)
        {
            float angleBetweenUserSat;

            angleBetweenUserSat = (float)Math.Acos(user.Unit().Dot((satelite - user).Unit()));
            angleBetweenUserSat = angleBetweenUserSat * 180 / (float)Math.PI;

            return angleBetweenUserSat;
        }

        public static float AngleBetweenSatUser1User2(Vector3 satelite, Vector3 user1, Vector3 user2)
        {
            var angle = satelite.AngleBetween(user1, user2);
            return angle;
        }

    }

    class Scenario
        {
        public Dictionary<Sat, Vector3> Sats { get; }
        public Dictionary<User, Vector3> Users { get; }
        public double MinCoverage { get; }

        public Scenario(string path)
        {
            Sats = new Dictionary<Sat, Vector3>();
            Users = new Dictionary<User, Vector3>();
            MinCoverage = 1.0;

            foreach (var line in File.ReadLines(path))
            {
                var parts = line.Split('#')[0].Trim().Split();
                if (parts.Length == 0)
                {
                    continue;
                }

                switch (parts[0])
                {
                    case "min_coverage":
                        MinCoverage = double.Parse(parts[1]);
                        break;
                    case "sat":
                        Sats[new Sat(int.Parse(parts[1]))] = new Vector3(float.Parse(parts[2]), float.Parse(parts[3]), float.Parse(parts[4]));
                        break;
                    case "user":
                        Users[new User(int.Parse(parts[1]))] = new Vector3(float.Parse(parts[2]), float.Parse(parts[3]), float.Parse(parts[4]));
                        break;
                    default:
                        TestUtil.Fail($"Invalid token: {parts[0]}");
                        break;
                }
            }
        }

        public void Check(Dictionary<User, (Sat, Color)> solution)
        {
            var beams = new Dictionary<Sat, List<(Color, User)>>();
            //foreach (var (user, (sat, color)) in solution) // not allowed to write like this in VS2022.
            foreach (var entry in solution)
            {
                var user = entry.Key;
                var (sat, color) = entry.Value;

                var userPos = Users[user];
                var satPos = Sats[sat];

                TestUtil.Check(Enum.IsDefined(typeof(Color), color), $"Invalid color: {color}");

                var angle = Math.Acos(userPos.Unit().Dot((satPos - userPos).Unit()));
#if DEBUG
                //Console.WriteLine($"User= {user} satellite {sat} angle={angle}, displayed as='{angle * 180 / Math.PI:F2}'");
#endif
                TestUtil.Check(angle <= Math.PI / 4, $"User {user} cannot see satellite {sat} ({angle * 180 / Math.PI:F2} degrees from vertical)");

                if (!beams.ContainsKey(sat))
                {
                    beams[sat] = new List<(Color, User)>();
                }

                beams[sat].Add((color, user));
            }

            foreach (var beamEntry in beams)
            {
                var sat = beamEntry.Key;
                var satBeams = beamEntry.Value;
                var satPos = Sats[sat];

                TestUtil.Check(satBeams.Count <= 32, $"Satellite {sat} cannot serve more than 32 users ({satBeams.Count} assigned)");

                foreach (var ((color1, user1), (color2, user2)) in satBeams.SelectMany((x, i) => satBeams.Skip(i + 1).Select(y => (x, y))))
                {
                    if (color1 == color2 && user1 != user2)
                    {
                        var user1Pos = Users[user1];
                        var user2Pos = Users[user2];
                        var angle = satPos.AngleBetween(user1Pos, user2Pos);

                        TestUtil.Check(angle >= 10.0, $"Users {user1} and {user2} on satellite {sat} {color1} are too close ({angle:F2} degrees)");
                    }
                }
            }

            var coverage = (double)solution.Count / Users.Count;
            TestUtil.Check(coverage >= MinCoverage, "Too few users served");
        }
    }


}

