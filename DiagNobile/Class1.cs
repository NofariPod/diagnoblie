using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DiagNobile
{
    class MyDiagNobileFunctions
    {
        //public String dataSource = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cohen\Documents\Diagnobile_Database.mdf;Integrated Security=True;"
        //public String dataSource = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nofar\Desktop\מערכות מידע\שנה ג\סמסטר ב\פרוייקט גמר\DiagNobileMaayan28.8\Diagnobile_Database.mdf;Integrated Security=True;Connect Timeout=30";



        public String dataSource = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nofar\Desktop\DiagNobile1.9\DiagNobile1.9\DiagNobile31.8\DiagNobile\DiagNobile\Diagnobile_Database.mdf;Integrated Security=True;Connect Timeout=30";

        public MyDiagNobileFunctions()
        {
        }

        /**The functions are arranged by database tables**/
        //Diagnosis

        //function to get all the diagnosis
        public DataTable GetAllDiagnosis()
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT distinct name FROM Diagnosis", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }

        //function to insert new diagnosis
        public void InsertDiagnosis(String name, String explanation)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Diagnosis VALUES (N'" + name + "',N'" 
                + explanation + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //function that check if the diagnosis exists
        public Boolean CheckDiagnosisExists(String diagnosis)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Diagnosis" +
                "where name=N'" + diagnosis + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() != "0")
            {
                return true;
            }
            return false;
        }

        //function that get the number of diagnosis
        public String GetNumDiagnosis(String name)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select IdDiagnosis from Diagnosis " +
                "where name=N'" + name + "'", con);
            DataSet dt = new DataSet();
            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["IdDiagnosis"].ToString());
            }
            Console.ReadLine();

            String idDiagnosis = Convert.ToString(tblAuthors.Rows[0]["IdDiagnosis"]);

            return idDiagnosis;
        }

        //function that get the name of diagnosis
        public String GetNameDiagnosis(String idDiagnosis)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select name from Diagnosis " +
                "where IdDiagnosis='" + idDiagnosis + "'", con);
            DataSet dt = new DataSet();
            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["name"].ToString());
            }
            Console.ReadLine();

            String diagnosis = Convert.ToString(tblAuthors.Rows[0]["name"]);

            return diagnosis;
        }

        //DiagnosisOrgans

        //function that get the parts of body after inserted diagnosis to check the patient
        public DataTable GetPartBodyForCheckPatient(String idDiagnosis)
        {

            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select distinct PartBody " +
                "from DiagnosisOrgans join Organs on DiagnosisOrgans.IdOrgan = Organs.OrganNum " +
                "where IdDiagnosis='" + GetNumDiagnosis(idDiagnosis) + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            return tblAuthors;
        }

        //function that get the organs to check after inserted diagnosis and parts of body
        public DataTable GetOrgansForCheckPatient(String nameDiagnosis, String partBody)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select distinct IdOrgan " +
                "from DiagnosisOrgans join Organs on DiagnosisOrgans.IdOrgan=Organs.OrganNum " +
                "where IdDiagnosis='" + GetNumDiagnosis(nameDiagnosis) + "'and PartBody=N'" 
                + partBody + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            return tblAuthors;
        }

        //function that get the views of patient after inserted diagnosis, parts of body and organs
        public DataTable GetViewsForCheckPatient(String idDiagnosis, String partBody, String organ)
        {

            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select distinct viewOrgan " +
                "from DiagnosisOrgans join Organs on DiagnosisOrgans.IdOrgan=Organs.OrganNum " +
                "where IdDiagnosis='" + GetNumDiagnosis(idDiagnosis) + "'and PartBody=N'" 
                + partBody + "'and IdOrgan='" + GetOrganNum(organ) + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            return tblAuthors;
        }

        //function that get the sides of patient after inserted diagnosis, parts of body, organs and views
        public DataTable GetSidesForCheckPatient(String idDiagnosis, String partBody, 
            String organ, String view)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select distinct side " +
                "from DiagnosisOrgans join Organs on DiagnosisOrgans.IdOrgan=Organs.OrganNum " +
                "where IdDiagnosis='" + GetNumDiagnosis(idDiagnosis) + "'and PartBody=N'" 
                + partBody + "'and IdOrgan='" + GetOrganNum(organ) + "'and viewOrgan=N'" 
                + view + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            return tblAuthors;
        }

        //function to insert diagnosis organs 
        public void InsertDiagnosisOrgans(String diagnosis, String organ, String view, String side)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO DiagnosisOrgans VALUES ('" 
                + GetNumDiagnosis(diagnosis) + "',N'" + GetOrganNum(organ) + "',N'" 
                + view + "',N'" + side + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //function that get the number of test of patient
        public String GetTestNum(String diagnosis, String organ, String view, String side)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT numTest FROM DiagnosisOrgans " +
                "where IdDiagnosis='" + GetNumDiagnosis(diagnosis) + "'and IdOrgan='" 
                + GetOrganNum(organ) + "' and viewOrgan=N'" + view + "' and side=N'" + side + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["numTest"].ToString());
            }
            Console.ReadLine();

            String numTest = Convert.ToString(tblAuthors.Rows[0]["numTest"]);

            return numTest;
        }

        //function that get the number of test to general principle
        public String GetTestNumForPrincipleGeneral(String diagnosis, String organ, String view)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT numTest FROM DiagnosisOrgans " +
                "where IdDiagnosis='" + GetNumDiagnosis(diagnosis) + "'and IdOrgan='" 
                + GetOrganNum(organ) + "' and viewOrgan=N'" + view + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["numTest"].ToString());
            }
            Console.ReadLine();

            String numTest = Convert.ToString(tblAuthors.Rows[0]["numTest"]);


            return numTest;
        }

        //function to check if number of test already exists
        public Boolean CheckTestNumExists(String diagnosis, String organ, String view, String side)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT count(*) FROM DiagnosisOrgans " +
                "where IdDiagnosis='" + GetNumDiagnosis(diagnosis) + "'and IdOrgan='" 
                + GetOrganNum(organ) + "' and viewOrgan=N'" + view + "' and side=N'" + side + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            return false;
        }

        //DiagnosisSymptoms
        //DiagnosisTests
        //Findings

        //function that insert the finding of patient with name, principle and area
        public void InsertFinding(String name, String principle, String area, String diagnosisName)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Findings (name, principle,Area,diagnosis)" +
                "VALUES (N'" + name + "',N'" + principle + "',N'" + area + "','" 
                + GetNumDiagnosis(diagnosisName) + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //function that insert touching finding of patient with name, principle, sub name and area
        public void InsertFindingTouching(String name, String principle, 
            String subName, String area, String diagnosisName)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Findings VALUES (N'" + name 
                + "',N'" + principle + "',N'" + subName + "',N'" + area + "','" 
                + GetNumDiagnosis(diagnosisName) + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //function that get the number of finding
        public String GetFindingNum(String finding, String principle, String area, String diagnosisName)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Id FROM Findings " +
                "where name=N'" + finding + "'and principle=N'" + principle + "'and Area=N'" 
                + area + "'and diagnosis='" + GetNumDiagnosis(diagnosisName) + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["Id"].ToString());
            }
            Console.ReadLine();

            String findingNum = Convert.ToString(tblAuthors.Rows[0]["Id"]);

            return findingNum;
        }

        //function that get the name of finding
        public String GetFindingName(String finding)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT name FROM Findings " +
                "where Id=N'" + finding + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["name"].ToString());
            }
            Console.ReadLine();

            String findingName = Convert.ToString(tblAuthors.Rows[0]["name"]);

            return findingName;
        }

        //function that get the name of touching finding
        /**public String GetFindingTouchingName(String IdfFnding)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Findings where Id=N'" + IdfFnding + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["Id"].ToString());
            }
            Console.ReadLine();

            String findingNum = Convert.ToString(tblAuthors.Rows[0]["Id"]);

            return findingNum;
        }**/

        //function that get the number of touching finding
        public String GetFindingTouchingNum(String findingName, String principle, 
            String subFindings, String area,String diagnosisName)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Id FROM Findings " +
                "where name=N'" + findingName + "'and principle=N'" + principle + "'and subFindings=N'" 
                + subFindings + "'and Area=N'" + area + "'and diagnosis='" 
                + GetNumDiagnosis(diagnosisName) + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["Id"].ToString());
            }
            Console.ReadLine();

            String findingNum = Convert.ToString(tblAuthors.Rows[0]["Id"]);

            return findingNum;
        }

        //function that get the table of all finding by principles
        public DataTable GetFindingByPrinciple(String principle, String diagnosisName)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Findings " +
                "where principle=N'" + principle + "'and diagnosis='" 
                + GetNumDiagnosis(diagnosisName) + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            return tblAuthors;
        }

        //function that check if the finding already exists
        public Boolean CheckFindingExists(String fiding, String principle, 
            String area,String diagnosisName)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Findings " +
                "where name='" + fiding + "'and principle=N'" + principle + "'and Area=N'" 
                + area + "'and diagnosis='" + GetNumDiagnosis(diagnosisName) + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() != "0")
            {
                return true;
            }
            return false;
        }

        //function that check if touching finding already exists
        public Boolean CheckFindingTouchingExists(String fiding, String principle, 
            String subName, String area,String diagnosisName)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Findings " +
                "where name=N'" + fiding + "'and principle=N'" + principle + "' and subFindings=N'" 
                + subName + "'and Area=N'" + area + "'and diagnosis='" + GetNumDiagnosis(diagnosisName) 
                + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() != "0")
            {
                return true;
            }
            return false;
        }

        //FindingsTouching
        
        //function that insert touching findings of the treatment  
        public void InsertFindingsTouchingTreatments(String tNum, String numRes, 
            String repetitive, String exists, String location, String power, String manipulation)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO FindingsTouching VALUES ('" 
                + tNum + "','" + numRes + "',N'" + repetitive + "',N'" + exists + "',N'" 
                + location + "',N'" + power + "',N'" + manipulation + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public Boolean CheckFindingsTouchingTreatmentsExists(String tNum, String numRes)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from FindingsTouching " +
                "where TreatmentNum='" + tNum + "' and NumResponse='" + numRes + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            return false;
        }

        //FindingsTouchingBlock

        //???
        public void InsertFindingsTouchingBlockTreatments(String tNum, String numRes, 
            String repetitive, String exists, String surfaceArea, String rigidity)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO FindingsTouching VALUES ('" 
                + tNum + "','" + numRes + "',N'" + repetitive + "',N'" + exists + "',N'" 
                + surfaceArea + "',N'" + rigidity + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            
        }
        public Boolean CheckFindingsTouchingBlockTreatmentsExists(String tNum, String numRes)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from FindingsTouchingBlock " +
                "where TreatmentNum='" + tNum + "'and NumResponse='" + numRes + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            return false;
        }

        //FindingsTreatments

        //function that insert findings of the treatment
        public void InsertFindingsTreatments(String tNum, String numRes, String response)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO FindingsTreatments VALUES ('" 
                + tNum + "','" + numRes + "',N'" + response + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public Boolean CheckFindingsTreatmentsExists(String tNum, String numRes)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from FindingsTreatments " +
                "where TreatmentNum='" + tNum + "'and NumResponse='" + numRes + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            return false;
        }

        //function that display data table of checked organs in treatment
        public DataTable GetOrganCheckedByTreatment(String numT)
        {

            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select distinct OrganNum " +
                "from FindingsTreatments where TreatmentNum='" + numT + "'", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }

        //function that display data table of general findings in treatment 
        public DataTable GetGeneralData(String treatNum, String organNum)
        {

            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select * from FindingsTreatments " +
                "where TreatmentNum='" + treatNum + "' and OrganNum= '" + organNum + "'", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }

        //function that check if the table of findings display any findings 
        public Boolean CheckDisplayRowsFindings(String treatNum, String organNum, String principle)
        {

            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from FindingsTreatments " +
                "where TreatmentNum='" + treatNum + "' and OrganNum= '" 
                + organNum + "' and PrincipleType= N'" + principle + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            return false;
        }

        //function that display findings description in table
        public String GetDisplayRowsFindings(String treatNum, String organNum, String principle)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select FindingDescription " +
                "from FindingsTreatments where TreatmentNum='" + treatNum + "' and OrganNum= '" 
                + organNum + "' and PrincipleType= N'" + principle + "'", con);
            DataSet dt = new DataSet();
            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0} {1}",
                drCurrent["FindingDescription"].ToString());
            }
            Console.ReadLine();

            String findingDescription = Convert.ToString(tblAuthors.Rows[0]["FindingDescription"]);

            return findingDescription;
        }

        //function that display data table of findings
        public DataTable GetDisplayRowsFindings(String treatNum, String organNum, 
            String principle, String side)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select FindingDescription " +
                "from FindingsTreatments where TreatmentNum='" + treatNum + "' and OrganNum= '" 
                + organNum + "' and PrincipleType= N'" + principle + "' and Side= N'" + side + "'", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }

        //InterestedTests
        //OptionsFindings

        //function that display drop down list of findings options
        public DataTable GetOptionsFinding(String idFinding)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT distinct OptionFinding " +
                "FROM OptionsFindings where IdFinding=N'" + idFinding + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            return tblAuthors;
        }

        //function that insert new findings options
        public void InsertOptionFinding(String idFinding, String option)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO OptionsFindings VALUES ('" 
                + idFinding + "',N'" + option + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //function that check if specific finding option already exists
        public Boolean CheckFindingOptionExists(String idfiding, String option)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from OptionsFindings " +
                "where IdFinding='" + idfiding + "'and OptionFinding=N'" + option + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() != "0")
            {
                return true;
            }
            return false;
        }

        //OrganFindings

        //function that get the number of response 
        public String GetResponseNum(String test, String principle, String idFinding)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Id FROM OrganFindings " +
                "where NumTest='" + test + "'and PrincipleType=N'" + principle + "' and IdFinding=N'" 
                + idFinding + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["Id"].ToString());
            }
            Console.ReadLine();

            String numTest = Convert.ToString(tblAuthors.Rows[0]["Id"]);


            return numTest;
        }

        //function that insert the organ findings
        public void InsertOrganFindings(String NumTest, String PrincipleType, String IdFinding)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO OrganFindings VALUES ('" 
                + NumTest + "',N'" + PrincipleType + "',N'" + IdFinding + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //Organs

        //function that display data table of all parts of body to check
        public DataTable GetAllPartBody()
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT distinct PartBody FROM Organs", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }

        //function to get the name of organ
        public String GetOrganName(String organNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT OrganDescription " +
                "FROM Organs where OrganNum='" + organNum + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["OrganDescription"].ToString());
            }
            Console.ReadLine();

            String OrganDescription = Convert.ToString(tblAuthors.Rows[0]["OrganDescription"]);

            return OrganDescription;
        }

        //function to check if the organ already exists
        public Boolean CheckOrganExists(String organ)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Organs " +
                "where OrganDescription=N'" + organ + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() != "0")
            {
                return true;
            }
            return false;
        }

        //function that get the number of organ
        public String GetOrganNum(String organName)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT OrganNum FROM Organs " +
                "where OrganDescription=N'" + organName + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["OrganNum"].ToString());
            }
            Console.ReadLine();

            String OrganNum = Convert.ToString(tblAuthors.Rows[0]["OrganNum"]);


            return OrganNum;
        }

        //function to insert new organ
        public void InsertOrgan(String name, String partBody)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Organs " +
                "VALUES (N'" + name + "',N'" + partBody + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //function that dispay data table of organs by body parts
        public DataTable GetOrganByPartBody(String PartBody)
        {

            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select distinct OrganDescription " +
                "from Organs where PartBody=N'" + PartBody + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            return tblAuthors;
        }

        //OrgansTesting

        //function that insert the test of the organ
        public void InsertOrgansTesting(String symptom, String organ)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO OrgansTesting " +
                "VALUES ('" + GetSymptomNum(symptom) + "','" + GetOrganNum(organ) + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //Patients

        //function that display data table of first patient details
        public DataTable GetFirstPatientDetails(String id)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select * from Patients " +
                "where PatientId='" + id + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;
        }

        //function that get the age of the patient
        public String GetAge(String idP)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT PatientId,DATEDIFF(yy, CONVERT(DATETIME, DateBirth), GETDATE()) as age FROM Patients where PatientId='" + idP + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0} {1}",
                drCurrent["PatientId"].ToString(),
                drCurrent["age"].ToString());
            }
            Console.ReadLine();

            String age = Convert.ToString(tblAuthors.Rows[0]["age"]);

            return age;

        }

        //function that update sensitivity
        public void UpdateSensitivity(String sensitivity, String idPatient)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Update Patients set Sensitivity=N'" 
                + sensitivity + "' where PatientId='" + idPatient + "'", con);
            cmd1.ExecuteNonQuery();
            con.Close();
        }

        //function that update chronic diseases
        public void UpdateChronicDiseases(String chronicDieseas, String idPatient)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Patients set ChronicDiseases=N'" 
                + chronicDieseas + "' where PatientId='" + idPatient + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //function that check if patient is already exists
        public Boolean CheckPatientExists(String idP)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from patients " +
                "where PatientId='" + idP + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            return false;
        }
        public void InsertNewPatient(String id, String fName, String lName, String dateB)
        {

            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO " +
                "patients(PatientId,FirstName,LastName,DateBirth) VALUES ('" + id + "' ,N'" 
                + fName + "',N'" + lName + "','" + dateB + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //Symptoms

        //function that display data table of all symptoms
        public DataTable GetAllSymptoms()
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT distinct SymptomDescription " +
                "FROM Symptoms", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }

        //function that get the symptom num
        public String GetSymptomNum(String symptom)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Symptoms " +
                "where SymptomDescription=N'" + symptom + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0} {1}",
                drCurrent["SymptomNum"].ToString(),
                drCurrent["SymptomDescription"].ToString());
            }
            Console.ReadLine();

            String SymptomNum = Convert.ToString(tblAuthors.Rows[0]["SymptomNum"]);

            return SymptomNum;
        }

        //function that get the symptom name
        public String GetSymptomName(String symptom)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Symptoms " +
                "where SymptomNum='" + symptom + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0} {1}",
                drCurrent["SymptomNum"].ToString(),
                drCurrent["SymptomDescription"].ToString());
            }
            Console.ReadLine();

            String SymptomName = Convert.ToString(tblAuthors.Rows[0]["SymptomDescription"]);

            return SymptomName;
        }

        //function that check if symptom already exists
        public Boolean CheckSymptomExists(String symptom)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Symptoms " +
                "where SymptomDescription=N'" + symptom + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() != "0")
            {
                return true;
            }
            return false;
        }

        //function that insert new symptom
        public void InsertSymptom(String name)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Symptoms VALUES (N'" + name + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //SymptomsTreatments

        //function that insert new symptom by treatment
        public void InsertNewSymptomByTreatment(String treatmentNum, String symptom, 
            String side, String type)
        {
            //check if symptom of treatment doesnt inserted
            if (!CheckSymptomsTretmentInsert(treatmentNum, symptom, side, type))
            {
                String symptomNum = GetSymptomNum(symptom);
                SqlConnection con = new SqlConnection(dataSource);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO SymptomsTreatments VALUES ('" 
                    + treatmentNum + "','" + symptomNum + "',N'" + side + "',N'" + type + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }

        //function to delete symptom bt treatment
        public void DeleteSymptomByTreatment(String treatmentNum, String symptom, 
            String side, String type)
        {
            //check if symptom of treatment inserted
            if (CheckSymptomsTretmentInsert(treatmentNum, symptom, side, type))
            {
                String symptomNum = GetSymptomNum(symptom);
                SqlConnection con = new SqlConnection(dataSource);
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from SymptomsTreatments " +
                    "where TreatmentNum='" + treatmentNum + "' and SymptomNum='" 
                    + symptomNum + "' and side=N'" + side + "' and type=N'" + type + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }

        //function to check if they are symptoms treatment inserted in data
        public Boolean CheckSymptomsTretmentInsert(String TreatmentNum, String Symptom, 
            String side, String type)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from SymptomsTreatments " +
                "where TreatmentNum='" + TreatmentNum + "' and SymptomNum='" 
                + GetSymptomNum(Symptom) + "' and side=N'" + side + "' and type=N'" + type + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            return false;

        }

        //function to check if the symptoms treatment exists
        public Boolean CheckExsistSymptomsTretmentInsert(String TreatmentNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from SymptomsTreatments " +
                "where TreatmentNum='" + TreatmentNum + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            return false;

        }

        //function that get all symptoms by treatment number
        public DataTable GetAllSymptomsByTreatment(String treatmentNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM SymptomsTreatments " +
                "where TreatmentNum='" + treatmentNum + "'", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }

        //Tests
        public DataTable GetAllTests()
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Tests ", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;

        }
        public DataTable GetTestsByType(String type)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT name from Tests where typeTest=N'" 
                + type + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;

        }
        public String GetIdTest(String name)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Id from Tests where name=N'" 
                + name + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["Id"].ToString());
            }
            Console.ReadLine();
            String id = Convert.ToString(tblAuthors.Rows[0]["Id"]);

            return id;          

        }
        public String GetNameTest(String id)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT name from Tests where Id='" + id + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["name"].ToString());
            }
            Console.ReadLine();

            String name = Convert.ToString(tblAuthors.Rows[0]["name"]);

            return name;

        }
        public void InsertTest(String name, String type)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Tests VALUES (N'" + name + "',N'" 
                + type + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public Boolean CheckTestExists(String name, String type)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Tests " +
                "where name=N'" + name + "'and typeTest=N'" + type + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() != "0")
            {
                return true;
            }
            return false;
        }

        //TestsTreatments
        public Boolean CheckTestsTreatmentsExists(String treatmentNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from TestsTreatments " +
                "where TreatmentNum=N'" + treatmentNum +  "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() != "0")
            {
                return true;
            }
            return false;
        }
        public Boolean CheckTestsTreatmentsExists(String treatmentNum, String patientId, 
            String testName, String idRequires)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from TestsTreatments " +
                "where TreatmentNum=N'" + treatmentNum + "'and PatientId=N'" + patientId 
                + "'and TestNum=N'" + GetIdTest(testName) + "'and UserRequires=N'" 
                + idRequires + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() != "0")
            {
                return true;
            }
            return false;
        }
        public void InsertTestsTreatments(String treatmentNum, String patientId, 
            String testName, String idRequires)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO " +
                "TestsTreatments (TreatmentNum,PatientId,TestNum,UserRequires) VALUES ('" 
                + treatmentNum + "','" + patientId + "','" + GetIdTest(testName) + "',N'" 
                + idRequires + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        
        public DataTable GetTestsTreatments(String treatmentNum, String idDiag1)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT TestNum,type " +
                "FROM DiagnosisTests join TestsTreatments on IdTest=TestNum where IdDiagnosis='" 
                + idDiag1 + "' and TreatmentNum = '" + treatmentNum + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;
        }
        public void ConfrimTest(String testTreatNum,String idConfrim)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update TestsTreatments set Confrim=1 , idConfrim = '" 
                + idConfrim + "' where TestTreatNum='" + testTreatNum + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //function that get list of tests
        public DataTable GetTestsList(String idP)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TestsTreatments  " +
                "where PatientId='" + idP + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;
        }
        public DataTable GetAllTestsTretmentsForNurse()
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TestsTreatments " +
                "where (TestValue IS NULL)", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;
        }
        public DataTable GetAllTestsTretments()
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TestsTreatments", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;
        }
        public DataTable GetAllTestsTretmentsByDoctor(String userId)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TestsTreatments " +
                "where UserRequires='" + userId + "' and Coalesce(Confrim, 0) = 0 ", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;
        }
        public Boolean CheckTreatmentsTestTrackingExists(String treatmentNum, 
            String patientId, String testName, String frequency)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from TreatmentsTestTracking " +
                "where TreatmentNum=N'" + treatmentNum + "'and PatientId=N'" + patientId + "'and TestNum=N'" + GetIdTest(testName) + "'and Frequency=N'" + frequency + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() != "0")
            {
                return true;
            }
            return false;
        }
        public Boolean CheckTreatmentsTestTrackingExists(String treatmentNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from TreatmentsTestTracking " +
                "where TreatmentNum=N'" + treatmentNum +"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() != "0")
            {
                return true;
            }
            return false;
        }
        public DataTable GetTreatmentsTestTracking(String treatmentNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from TreatmentsTestTracking " +
                "where TreatmentNum='" + treatmentNum + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            return tblAuthors;
        }
        public void InsertTreatmentsTestTracking(String treatmentNum, String patientId, 
            String testName, String frequency)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO " +
                "TreatmentsTestTracking (TreatmentNum,PatientId,TestNum,Frequency) VALUES ('" 
                + treatmentNum + "','" + patientId + "','" + GetIdTest(testName) + "',N'" 
                + frequency + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //Treatments
        
        public void UpdateTreatmentStatus(String treatmentNum, String value)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Treatments set TreatmentStatus=N'" 
                + value + "' where TreatmentNum='" + treatmentNum + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public Boolean CheckedTreatmentDoctorExists(String treatmentNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select DoctorId from Treatments " +
                "where TreatmentNum='" + treatmentNum + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["DoctorId"].ToString());
            }
            Console.ReadLine();

            String doctorId = Convert.ToString(tblAuthors.Rows[0]["DoctorId"]);
            if (doctorId.Length == 0)
            {
                return false;
            }
            return true;
        }
        public void UpdateTreatmentDoctor(String treatmentNum, String idDoctor)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Treatments set DoctorId='" 
                + idDoctor + "' where TreatmentNum='" + treatmentNum + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public Boolean CheckIfThisRecheckDoctor(String treatmentNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Treatments " +
                "where TreatmentNum='" + treatmentNum + "' and TreatmentStatus=N'רופא חוזר'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "0")
            {
                return false;
            }
            return true;
        }

        //function that check if specific patient have opened treatment
        public Boolean CheckTretmentOpen(String id)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Treatments " +
                "where PatientId='" + id + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "0")
            {
                return false;
            }
            return true;
        }
        public String GetReleaseTime(String idTreatment, String type)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Release FROM TreatmentsStatus " +
                "where TreatmentNum='" + idTreatment + "' and TreatmentStatus=N'" + type + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["Release"].ToString());
            }
            Console.ReadLine();

            String Release = Convert.ToString(tblAuthors.Rows[0]["Release"]);

            return Release;
        }
        public String GetPatientIdByTretment(String idTreatment)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT PatientId FROM Treatments " +
                "where TreatmentNum='" + idTreatment + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["PatientId"].ToString());
            }
            Console.ReadLine();

            String PatientId = Convert.ToString(tblAuthors.Rows[0]["PatientId"]);

            return PatientId;
        }
        public String GetReceptionTime(String idTreatment, String type)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Reception FROM TreatmentsStatus " +
                "where TreatmentNum='" + idTreatment + "' and typeTreatment=N'" + type + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["Reception"].ToString());
            }
            Console.ReadLine();

            String Reception = Convert.ToString(tblAuthors.Rows[0]["Reception"]);

            return Reception;
        }
        //function that display data table of treatment details
        public DataTable GetTreatmentDetails(String idTreatment)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select * from Treatments where TreatmentNum='" 
                + idTreatment + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            return tblAuthors;
        }

        //function that open new treatment process in the system
        public void OpenNewTretmentOnSystem(String idPatient, String idNurse)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Treatments (PatientId,NurseId) " +
                "VALUES ('" + idPatient + "','" + idNurse + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public String GetTreatmentStatus(String idTreatment)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT TreatmentStatus FROM Treatments " +
                "where TreatmentNum='" + idTreatment + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["TreatmentStatus"].ToString());
            }
            Console.ReadLine();

            String TreatmentStatus = Convert.ToString(tblAuthors.Rows[0]["TreatmentStatus"]);

            return TreatmentStatus;
        }
        //function to get the number of treatment
        public String GetTreatmentNum(String idP)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT PatientId,TreatmentNum FROM Treatments " +
                "where PatientId='" + idP + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0} {1}",
                drCurrent["PatientId"].ToString(),
                drCurrent["TreatmentNum"].ToString());
            }
            Console.ReadLine();

            String TreatmentNum = Convert.ToString(tblAuthors.Rows[0]["TreatmentNum"]);

            return TreatmentNum;
        }

        //function to update treatment data
        public void UpdateTreatmentData(String temperature, String sysbloodPressure, String diasbloodPressure, String pulse, String complaint, String idTreatment)
        {
            UpdateInitialFindings(temperature, sysbloodPressure, diasbloodPressure, pulse, idTreatment);
        }

        //function to update initial details of patient 
        public void UpdateInitialFindings(String temperature, String sysbloodPressure, String diasbloodPressure, String pulse, String idTreatment)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Treatments set BodyTemperature='" 
                + temperature + "',systolicBloodPressuree='" 
                + sysbloodPressure + "',diastolicBloodPressuree='" 
                + diasbloodPressure + "' ,Pulse='" + pulse + "' where TreatmentNum='" 
                + idTreatment + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //function that display data table of organs that need to check in patient by body parts
        public DataTable GetOrganForCheckPatientByPartBody(String numT, String partB)
        {

            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select distinct PartBody " +
                "from Treatments join SymptomsTreatments on " +
                "Treatments.TreatmentNum=SymptomsTreatments.TreatmentNum join OrgansTesting " +
                "on SymptomsTreatments.SymptomNum=OrgansTesting.SymptomNum join " +
                "Organs on Organs.OrganNum=OrgansTesting.OrganNum where Treatments.TreatmentNum='" 
                + numT + "'and PartBody=N'" + partB + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            return tblAuthors;
        }

        //function that get the count of how many people received treatment 
        public String GetSumPatientsStatusReception()
        {

            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Treatments ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt.Rows[0][0].ToString();
        }

        //function that get the count of how many people now in treatment
        public String GetSumPatientsStatusInTherapy()
        {

            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter(" select count(*) from Treatments " +
                "where TreatmentStatus not Like N'שוחרר' and TreatmentStatus not Like N'בהמתנה לאחות'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt.Rows[0][0].ToString();
        }

        //function that get the count of how many people close treatment and release
        public String GetSumPatientsStatusRelease()
        {

            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Treatments " +
                "where TreatmentStatus= N'שוחרר' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt.Rows[0][0].ToString();
        }

        //function to save primary diagnosis
        public void SaveDiagnosisPrimary(String idTretment, String nameDiagnosis)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Treatments SET PrimaryDiagnosisId='" 
                + GetNumDiagnosis(nameDiagnosis) + "' where TreatmentNum='" + idTretment + "';", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //function to save secondary diagnosis
        public void SaveDiagnosisSecondary(String idTretment, String nameDiagnosis)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Treatments SET SecondaryDiagnosisId='" 
                + GetNumDiagnosis(nameDiagnosis) + "' where TreatmentNum='" + idTretment + "';", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //function to save diagnosis
        public void SaveDiagnosis(String idTretment, String typeDiagnosis, String nameDiagnosis)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Treatments SET '" + typeDiagnosis + "'='" 
                + GetNumDiagnosis(nameDiagnosis) + "' where TreatmentNum='" + idTretment + "';", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //function that get the id of secondary diagnosis
        public String GetSecondaryDiagnosisId(String treatmentNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select SecondaryDiagnosisId from Treatments " +
                "where TreatmentNum='" + treatmentNum + "'", con);
            DataSet dt = new DataSet();
            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["SecondaryDiagnosisId"].ToString());
            }
            Console.ReadLine();

            String secondaryDiagnosisId = Convert.ToString(tblAuthors.Rows[0]["SecondaryDiagnosisId"]);

            return secondaryDiagnosisId;
        }

        //function that get the id of primary diagnosis
        public String GetPrimaryDiagnosisId(String treatmentNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select PrimaryDiagnosisId from Treatments " +
                "where TreatmentNum='" + treatmentNum + "'", con);
            DataSet dt = new DataSet();
            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["PrimaryDiagnosisId"].ToString());
            }
            Console.ReadLine();

            String primaryDiagnosisId = Convert.ToString(tblAuthors.Rows[0]["PrimaryDiagnosisId"]);

            return primaryDiagnosisId;
        }
        public String GetDoctorIdByTretment(String treatmentNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select DoctorId from Treatments " +
                "where TreatmentNum='" + treatmentNum + "'", con);
            DataSet dt = new DataSet();
            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["DoctorId"].ToString());
            }
            Console.ReadLine();

            String DoctorId = Convert.ToString(tblAuthors.Rows[0]["DoctorId"]);

            return DoctorId;
        }
        //
        public String GetDoctorId(String treatmentNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select DoctorId from Treatments " +
                "where TreatmentNum='" + treatmentNum + "'", con);
            DataSet dt = new DataSet();
            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["DoctorId"].ToString());
            }
            Console.ReadLine();

            String doctorId = Convert.ToString(tblAuthors.Rows[0]["DoctorId"]);

            return doctorId;
        }

        //function that check if patient diagnosis already exists
        public Boolean CheckDiagnosisExistsForPatients(String idTretment, String typeDiagnosis)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select '" + typeDiagnosis + "' from Treatments " +
                "where TreatmentNum='" + idTretment + "'", con);
            DataSet dt = new DataSet();
            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent[typeDiagnosis].ToString());
            }
            Console.ReadLine();

            String Diagnosis = Convert.ToString(tblAuthors.Rows[0][typeDiagnosis]);

            if (Diagnosis.Length!=0)
            {
                return true;
            }
            return false;
        }
        public Boolean CheckDiagnosisPrimaryExistsForPatients(String idTretment)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select PrimaryDiagnosisId from Treatments " +
                "where TreatmentNum='" + idTretment + "'", con);
            DataSet dt = new DataSet();
            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["PrimaryDiagnosisId"].ToString());
            }
            Console.ReadLine();

            String Diagnosis = Convert.ToString(tblAuthors.Rows[0]["PrimaryDiagnosisId"]);

            if (Diagnosis.Length != 0)
            {
                return true;
            }
            return false;
        }
        public Boolean CheckDiagnosisSecondaryExistsForPatients(String idTretment)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select SecondaryDiagnosisId from Treatments " +
                "where TreatmentNum='" + idTretment + "'", con);
            DataSet dt = new DataSet();
            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["SecondaryDiagnosisId"].ToString());
            }
            Console.ReadLine();

            String Diagnosis = Convert.ToString(tblAuthors.Rows[0]["SecondaryDiagnosisId"]);

            if (Diagnosis.Length != 0)
            {
                return true;
            }
            return false;
        }

        //TreatmentsHistory

        //function that get all treatments of the patient
        public DataTable GetTreatmentList(String idPatient)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select TreatmentNum from TreatmentsHistory " +
                "where PatientId='" + idPatient + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            return tblAuthors;
        }

        //TreatmentsStatus
        public DataTable GetStatusPatientByDay()
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select CONVERT(date, Reception) as myDate, " +
                "count(*) as sumPatientsForDay from TreatmentsStatus group by CONVERT(date, Reception)", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            return tblAuthors;
        }
        //function to insert estimated duration of the treatment
        public void InsertTimeValue(String treatmentNum, String type)
        {
            int estimatedDuratio = GetEstimatedDuration(type);
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO " +
                "TreatmentsStatus (TreatmentNum,Reception,typeTreatment,estimatedDuration) VALUES ('" 
                + treatmentNum + "',SYSDATETIME(),N'" + type + "'," + estimatedDuratio + ")", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable GetTreatmentStatusData(String idTreatment, String type)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select * from TreatmentsStatus " +
                "where TreatmentNum='" + idTreatment + "' and typeTreatment=N'" + type + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            return tblAuthors;
        }
        //function to update estimated duration of the treatment to release 
        public void UpdateTimeValue(String treatmentNum, String type)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update TreatmentsStatus set Release=SYSDATETIME() " +
                "where TreatmentNum='" + treatmentNum + "' and typeTreatment=N'" + type + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            UpdateActualDurationValue(treatmentNum, type);
        }

        public void UpdateActualDurationValue(String treatmentNum, String type)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update TreatmentsStatus set " +
                "actualDuration=DATEDIFF(MINUTE,Reception,Release)  where TreatmentNum='" 
                + treatmentNum + "' and typeTreatment=N'" + type + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UpdateTestTreatment(String testNum, String time, String value)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update TestsTreatments set TestValue=N'" 
                + value + "',TestTime=SYSDATETIME() where TestTreatNum='" + testNum + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //function that get the estimated duration of treatment
        public int GetEstimatedDuration(String type)
        {

            if (type.Equals("אחות"))
            {
                return 7;
            }
            else if (type.Equals("רופא"))
            {
                return 15;
            }
            else if (type.Equals("כללי"))
            {
                return 30;
            }
            return 5;
        }

        //function that check if time value already exists
        public Boolean CheckTimeValueExists(String treatmentNum, String type)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from TreatmentsStatus " +
                "where TreatmentNum='" + treatmentNum + "' and typeTreatment=N'" + type + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            return false;
        }


        //function that get the time of reception to the treatment
        public String GetTimeTreatment(String treatmentNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select Reception from TreatmentsStatus " +
                "where TreatmentNum='" + treatmentNum + "' and typeTreatment=N'כללי'", con);
            DataSet dt = new DataSet();
            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["Reception"].ToString());
            }
            Console.ReadLine();

            String time = Convert.ToString(tblAuthors.Rows[0]["Reception"]);

            return time;
        }
        public String GetTimeAvgt(String type)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select convert(numeric(10,2), AVG(actualDuration)) as sumTimeTretment from TreatmentsStatus where typeTreatment=N'" + type + "'", con);
            DataSet dt = new DataSet();
            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["sumTimeTretment"].ToString());
            }
            Console.ReadLine();

            String sum = Convert.ToString(tblAuthors.Rows[0]["sumTimeTretment"]);

            return sum;
        }
        public int GetTimeTreatmentSummery(String treatmentNum, String type)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select actualDuration-estimatedDuration as sum " +
                "from TreatmentsStatus where TreatmentNum='" + treatmentNum + "' " +
                "and typeTreatment=N'" + type + "'", con);
            DataSet dt = new DataSet();
            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["sum"].ToString());
            }
            Console.ReadLine();
            String a = Convert.ToString(tblAuthors.Rows[0]["sum"]);
            int sum;
            if (a.Length == 0)
            {
                sum = 0;
            }
            else
            {
                sum = int.Parse(a);
            }
            return sum;
        }

        //Users

        //function that check if user exists by id
        public Boolean CheckedUser(String id)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from users " +
                "where userid='" + id + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            return false;

        }

        //function that check if user exists by id and password
        public Boolean CheckedUser(String id, String pass)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Users " +
                "where UserId='" + id + "' and password ='" + pass + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            return false;
        }


        //function that get the permission of the user
        public String GetPermission(String id)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select Permission from users where userId='" + id + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["Permission"].ToString());
            }
            Console.ReadLine();

            String permission = Convert.ToString(tblAuthors.Rows[0]["Permission"]);

            return permission;
        }

        //function that get user name
        public String GetNameUser(String id)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Users where UserId='" + id + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0} {1}",
                drCurrent["FirstName"].ToString(),
                drCurrent["LastName"].ToString());
            }
            Console.ReadLine();

            String FirstName = Convert.ToString(tblAuthors.Rows[0]["FirstName"]);
            String LastName = Convert.ToString(tblAuthors.Rows[0]["LastName"]);
            String Name = FirstName +" "+ LastName;

            return Name;
        }
        public String GetIdUserByLastName(String lastName)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT UserId FROM Users " +
                "where LastName=N'" + lastName + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["UserId"].ToString());
            }
            Console.ReadLine();

            String userId = Convert.ToString(tblAuthors.Rows[0]["UserId"]);
            return userId;
        }

        //function to reset the password
        public void ResetPassword(String id, String password)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Users(Password) VALUES ('" 
                + password + "'where UserId='" + id + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable GetAllDcotors() { 

        SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select * from Users where Permission=N'רופא'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            return tblAuthors;
        }

        //join tables

        //function that display data table of patients and all there treatments
        public DataTable GetAllPatientDetails(String id)
        {

            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select * from Patients join Treatments " +
                "on Patients.PatientId=Treatments.PatientId where Treatments.PatientId='" 
                + id + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            return tblAuthors;
        }
        public String GetPatientName(String id)
        {

            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select * from Patients " +
                "where patientId='" + id + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0} {1}",
                drCurrent["FirstName"].ToString(),
                drCurrent["LastName"].ToString());
            }
            Console.ReadLine();

            String FirstName = Convert.ToString(tblAuthors.Rows[0]["FirstName"]);
            String LastName = Convert.ToString(tblAuthors.Rows[0]["LastName"]);
            String Name = FirstName +" "+ LastName;

            return Name;
        }

        //function that display data table of patients and all there history treatments
        public DataTable GetAllPatientDetailsOldTreatment(String id)
        {

            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select * from Patients join " +
                "TreatmentsHistory on Patients.PatientId=TreatmentsHistory.PatientId " +
                "where TreatmentsHistory.PatientId='" + id + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            return tblAuthors;
        }

        //function that get the symptoms of patient
        public DataTable GetSymptomsPatient(String numT)
        {

            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select SymptomDescription " +
                "from SymptomsTreatments join Symptoms on " +
                "SymptomsTreatments.SymptomNum = Symptoms.SymptomNum where TreatmentNum= '" 
                + numT + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            return tblAuthors;
        }

        //function that display data table of findings to check patients
        public DataTable GetFindingsForCheckPatient(String numTest, String principle)
        {

            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select OrganFindings.IdFinding,subFindings " +
                "from OrganFindings join Findings on OrganFindings.IdFinding=Findings.Id " +
                "where NumTest='" + numTest + "'and PrincipleType=N'" + principle + "' order by OrganFindings.IdFinding asc", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            return tblAuthors;
        }

        //function that get the Rigidity of patient that checked
        public String GetFindingRigidityForCheckPatient(String numTest, String principle)
        {

            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select OrganFindings.IdFinding,subFindings " +
                "from OrganFindings join Findings on OrganFindings.IdFinding=Findings.Id " +
                "where NumTest='" + numTest + "'and PrincipleType=N'" 
                + principle + "'and subFindings=N'נוקשות'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0} {1}",
                drCurrent["IdFinding"].ToString());
            }
            Console.ReadLine();

            String IdFinding = Convert.ToString(tblAuthors.Rows[0]["IdFinding"]);

            return IdFinding;
        }

        //function that get treatment number by date
        public String GetNumTreatmentById(String id)
        {

            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select TreatmentNum from Treatments where PatientId='" + id +  "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["TreatmentNum"].ToString());
            }
            Console.ReadLine();

            String treatmentNum = Convert.ToString(tblAuthors.Rows[0]["TreatmentNum"]);

            return treatmentNum;
        }

        //function that display data table of patients list
        public DataTable GetPatientsList()
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT  TreatmentNum,Treatments.PatientId," +
                "FirstName,LastName,TreatmentStatus FROM Treatments join Patients on " +
                "Treatments.PatientId=Patients.PatientId ", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;
        }
        //function that display data table of patients list
        public DataTable GetPatientsListByNurse(String id)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT distinct TreatmentNum,Treatments.PatientId," +
                "FirstName,LastName,TreatmentStatus,NurseId FROM Treatments join Patients " +
                "on Treatments.PatientId=Patients.PatientId  where NurseId='" + id + "'", con);
            DataSet dt = new DataSet();
            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;
        }//function that display data table of patients list
        public DataTable GetPatientsListByDoctor(String id)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT distinct TreatmentNum,Treatments.PatientId," +
                "FirstName,LastName,TreatmentStatus,DoctorId FROM Treatments join Patients on " +
                "Treatments.PatientId=Patients.PatientId  where DoctorId='" + id + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;
        }
        //function that display patient status with all details of patient
        public DataTable GetPatientStatus(String idP)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT distinct TreatmentNum,Treatments.PatientId," +
                "FirstName,LastName,TreatmentStatus FROM Treatments join Patients " +
                "on Treatments.PatientId=Patients.PatientId  where Treatments.PatientId='" 
                + idP + "'", con);

            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;

        }

        //function that get the names of entered findings
        public DataTable GetNameFeedingFindings(String treatmentNum, String principle)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT distinct name from viewFeedingFiding " +
                "where TreatmentNum='" + treatmentNum + "' and principle=N'" + principle + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;

        }

        //function that display data table of findings that entered
        public DataTable GetFeedingFindingsNames(String treatmentNum,String idDiagnosis, String principle)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT distinct name,subFindings from " +
                "viewFeedingFidingSub where TreatmentNum='" + treatmentNum + "' and IdDiagnosis='" + idDiagnosis + "' and principle=N'" + principle + "' order by name desc ,subFindings desc", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;

        }
        public DataTable GetFeedingFindingsResponseBySide(String treatmentNum, String idDiagnosis, String principle, String name)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT side,response from viewFeedingFidingSub " +
                "where TreatmentNum='" + treatmentNum + "' and IdDiagnosis='" + idDiagnosis + "' and principle=N'" + principle + "' and name=N'" 
                + name + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;

        }
        public DataTable GetFeedingFindingsTResponseBySide(String treatmentNum, String idDiagnosis, String principle, String name, String sub)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT side,response from viewFeedingFidingSub " +
                "where TreatmentNum='" + treatmentNum + "' and IdDiagnosis='" + idDiagnosis + "' and principle=N'" + principle + "' and name=N'" + name + "' and subFindings=N'" + sub + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;

        }

        public String GetFeedingFindingGeneral(String treatmentNum, String idDiagnosis, String side)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT response  from  viewFeedingFiding " +
                "where TreatmentNum='" + treatmentNum + "' and IdDiagnosis=N'" + idDiagnosis + "' and side=N'" + side + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0} ",
                drCurrent["response"].ToString());
            }
            Console.ReadLine();

            String resGeneral = Convert.ToString(tblAuthors.Rows[0]["response"]);

            return resGeneral;

        }

        //function that display data table of touching findings that entered
        public DataTable GetFeedingFindingsTouchingRepetitive(String treatmentNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT distinct RepetitiveResponse from " +
                "FindingsTouching where TreatmentNum='" + treatmentNum + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;

        }
        public DataTable GetFeedingFindingsTouchingRepetitiveResponses(String treatmentNum, String repetitive)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from  viewFeedingFindingsTouching " +
                "where TreatmentNum='" + treatmentNum + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;

        }

        //function that display data table of touching findings block that entered
        public DataTable GetFeedingFindingsTouchingBlock(String treatmentNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT* from  FindingsTouchingBlock " +
                "where TreatmentNum='" + treatmentNum + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;
        }      
        //Medicines
        public DataTable GetAllMedicines()
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT name from Medicines", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;

        }
        public String GetIdMedication(String name)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Id from Medicines " +
                "where name=N'" + name + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["Id"].ToString());
            }
            Console.ReadLine();

            String id = Convert.ToString(tblAuthors.Rows[0]["Id"]);

            return id;

        }
        public String GetNameMedication(String id)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT name from Medicines " +
                "where Id='" + id + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["name"].ToString());
            }
            Console.ReadLine();

            String name = Convert.ToString(tblAuthors.Rows[0]["name"]);

            return name;

        }
        public Boolean CheckMedicationExists(String name)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Medicines " +
                "where name=N'" + name + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() != "0")
            {
                return true;
            }
            return false;
        }
        public void InsertMedication(String name)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Medicines VALUES (N'" + name + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public Boolean CheckDiagnosisMedicinesExists(String idDiagnosis, String medicationNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from DiagnosisMedicines " +
                "where IdDiagnosis='" + idDiagnosis + "' and MedicationNum='" + medicationNum + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() != "0")
            {
                return true;
            }
            return false;
        }
        public void InsertDiagnosisMedication(String idDiagnosis, String medicationNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO DiagnosisMedicines VALUES ('" 
                + idDiagnosis + "','" + medicationNum + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable GetAllDiagnosisMedication(String idDiagnosis)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from DiagnosisMedicines " +
                "where IdDiagnosis='" + idDiagnosis + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;
        }
        public void InsertTreatmentsMedication(String idPatient, String name, String dosage)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TreatmentsMedicines VALUES ('" + idPatient + "','" + GetIdMedication(name) + "',N'" + dosage + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable GetPatientMedications(String idPatient)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from TreatmentsMedicines where PatientId='" + idPatient + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;
        }
        public Boolean CheckPatientMedicinesExists(String idPatient)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from TreatmentsMedicines " +
                "where PatientId='" + idPatient + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() != "0")
            {
                return true;
            }
            return false;
        }
        public Boolean CheckPatientMedicinesExists(String idPatient, String name, String dosage)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from TreatmentsMedicines " +
                "where PatientId='" + idPatient + "' and MedicationNum='" 
                + GetIdMedication(name) + "' and Dosage=N'" + dosage + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() != "0")
            {
                return true;
            }
            return false;
        }
        public Boolean CheckDiagnosisTestExists(String idDiagnosis, String idTest, String type)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from DiagnosisTests where " +
                "IdDiagnosis='" + idDiagnosis + "' and IdTest='" + idTest + "' and type=N'" 
                + type + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() != "0")
            {
                return true;
            }
            return false;
        }
        public void InsertDiagnosisTests(String idDiagnosis, String idTest, String type)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO DiagnosisTests VALUES ('" 
                + idDiagnosis + "','" + idTest + "',N'" + type + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable GetAllPatientsReleased()
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT TreatmentNum from Treatments where TreatmentStatus=N'שוחרר'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;

        }
        
        //TreatmentsActions
        public DataTable GetActionsByTreatment(String treatmentNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from TreatmentsActions where TreatmentNum='" 
                + treatmentNum + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;

        }
        public void InsertAction(String treatmentNum, String action, String organ, String target)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TreatmentsActions VALUES ('" 
                + treatmentNum + "','" + action + "',N'" + GetOrganNum(organ) + "',N'" 
                + target + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //TreatmentsImaging
        public DataTable GetImagingByTreatment(String treatmentNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from TreatmentsImaging where TreatmentNum='" 
                + treatmentNum + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;

        }
        public void InsertImaging(String treatmentNum, String organ, String cameraType, String photoType)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TreatmentsImaging VALUES ('" 
                + treatmentNum + "','" + GetOrganNum(organ) + "',N'" + cameraType + "',N'" 
                + photoType + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //TreatmentsSideEffects
        public DataTable GetSideEffectsByTreatment(String treatmentNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from TreatmentsSideEffects where " +
                "TreatmentNum='" + treatmentNum + "'", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;

        }
        public void InsertSideEffect(String treatmentNum, String factorA, String factorB, String restriction)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TreatmentsSideEffects VALUES ('" 
                + treatmentNum + "','" + factorA + "',N'" + factorB + "',N'" + restriction + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public int GetSumPatientsForTretmentNurse()
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT count(*) as sumPatient  from  TreatmentsNurse", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["sumPatient"].ToString());
            }
            Console.ReadLine();

            int sumPatient = Convert.ToInt16(tblAuthors.Rows[0]["sumPatient"]);

            return sumPatient;

        }
        public Boolean CheckIfPatientsExistsInListNurse(String idP)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from TreatmentsNurse where PatientId=N'" + idP + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() != "0")
            {
                return true;
            }
            return false;
        }
        public void InsertPatientsForTretmentNurse(String idPatient)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TreatmentsNurse VALUES ('" 
                + idPatient + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public int GetSumPatientsForTretmentDoctor()
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT count(*) as sumPatient  from  TreatmentsDoctor", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0}",
                drCurrent["sumPatient"].ToString());
            }
            Console.ReadLine();

            int sumPatient = Convert.ToInt16(tblAuthors.Rows[0]["sumPatient"]);

            return sumPatient;

        }
        
        public void InsertPatientsForTretmentDoctor(String idPatient, String queueNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TreatmentsDoctor VALUES ('" 
                + queueNum + "','" + idPatient + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public int getExpectedCompletion(String idTretment)
        {
            String status = GetTreatmentStatus(idTretment);
            int sum;
            if (status.Equals("בהמתנה לאחות"))
            {
                sum = GetSumPatientsForTretmentNurse() * GetEstimatedDuration("אחות")
                    + GetEstimatedDuration("אחות") 
                    + GetSumPatientsForTretmentDoctor()* GetEstimatedDuration("רופא") 
                    + GetEstimatedDuration("רופא");
            }
            else if (status.Equals("בדיקת אחות"))
            {
                sum = GetEstimatedDuration("אחות") 
                    + GetSumPatientsForTretmentDoctor() * GetEstimatedDuration("רופא") 
                    + GetEstimatedDuration("רופא");
            }

            else if (status.Equals("בהמתנה לרופא"))
            {
                sum =  GetSumPatientsForTretmentDoctor() * GetEstimatedDuration("רופא") 
                    + GetEstimatedDuration("רופא");

            }
            else if (status.Equals("בדיקת רופא"))
            {
                sum =GetEstimatedDuration("רופא");

            }
            else if (status.Equals("בהמתנה לבדיקות נוספות"))
            {
                sum=20+ GetEstimatedDuration("רופא");
            }
            else if (status.Equals("בדיקת רופא חוזר"))
            {
                sum = GetEstimatedDuration("רופא");
            }
            else
            {
                sum =5;
            }
            return sum;
        }
        public DataTable GetPatientsNurse()
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Nun,Treatments.PatientId as id,TreatmentStatus " 
                + "from TreatmentsNurse join Treatments on TreatmentsNurse.PatientId = Treatments.PatientId", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");

            try
            {
                sda.Fill(dt, "Authors");
            }
#pragma warning disable CS0168 // The variable 'e' is declared but never used
            catch (Exception e)
#pragma warning restore CS0168 // The variable 'e' is declared but never used
            {
                
            }
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];
            
            return tblAuthors;

        }
        public DataTable GetPatientsDoctor()
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from TreatmentsDoctor ", con);
            DataSet dt = new DataSet();

            sda.FillSchema(dt, SchemaType.Source, "Authors");
            sda.Fill(dt, "Authors");
            DataTable tblAuthors;
            tblAuthors = dt.Tables["Authors"];

            return tblAuthors;

        }
        public Boolean CheckPatientExistsInListDoctor(String idP)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from TreatmentsDoctor where PatientId='" + idP + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            return false;
        }
        public void DeletePatientFromListDoctor(String idP)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from TreatmentsDoctor where PatientId='" + idP + "'", con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeletePatientFromListNurse(String idP)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from TreatmentsNurse where PatientId='" + idP + "'", con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void EmptyLooseTreatments()
        {
            DataTable td = GetAllPatientsReleased();

            foreach (DataRow datarow in td.Rows)
            {
                String num = Convert.ToString(datarow["TreatmentNum"]);
                DeleteAllTretmentTest(num);
                DeleteAllTretmentTimes(num);
                DeleteAllTreatmentTestTracking(num);
                DeleteAllTreatmentSymptoms(num);
                DeleteAllTreatmentFindings(num);
                DeletePatientFromListNurse(GetPatientIdByTretment(num));
                DeleteTretmentt(num);
            }
        }
        public void DeleteAllTretmentTest(String tretmentNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from TestsTreatments where TreatmentNum='" + tretmentNum + "'", con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteAllTretmentTimes(String tretmentNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from TreatmentsStatus where TreatmentNum='" + tretmentNum + "'", con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteAllTreatmentTestTracking(String tretmentNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from TreatmentsTestTracking where TreatmentNum='" + tretmentNum + "'", con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteAllTreatmentSymptoms(String tretmentNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from SymptomsTreatments where TreatmentNum='" + tretmentNum + "'", con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteAllTreatmentFindings(String tretmentNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from FindingsTreatments where TreatmentNum='" + tretmentNum + "'", con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteTretmentt(String tretmentNum)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Treatments where TreatmentNum='" + tretmentNum + "'", con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable GetAllDiagnosisTest(String idDiagnosis)
        {
            SqlConnection con = new SqlConnection(dataSource);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM DiagnosisTests where IdDiagnosis='" + idDiagnosis + "'", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }
    }
}
