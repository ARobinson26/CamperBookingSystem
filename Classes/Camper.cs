using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CamperBookingSystem.Classes
{
    class Camper
    {
        public string registration = "";
        public string name = "";
        public int berths = 0;
        public bool blocked = false;

        /// <summary>
        /// Creates an object of Camper Class with data found from DB.
        /// </summary>
        /// <param name="queriedRegistration">Registration to query DB with.</param>
        /// <returns></returns>
        public static Camper Find(string queriedRegistration)
        {
            //Creates new object 'oCamper' as Camper Class.
            Camper oCamper = new Camper();

            //Creates new object 'dataRow' as a DataRow class containing results from DB query.
            DataRow dataRow = DB.FindCamper(queriedRegistration);

            //If the datarow returned isn't black, set oVehicle = to data found in query.
            if (dataRow != null)
            {
                oCamper.registration = dataRow["registration"].ToString();
                oCamper.name = dataRow["name"].ToString();
                oCamper.berths = int.Parse(dataRow["berths"].ToString());
                oCamper.blocked = bool.Parse(dataRow["blocked"].ToString());

                return oCamper;
            }
            else
            {
                return null;
            }
        }













    }
}
