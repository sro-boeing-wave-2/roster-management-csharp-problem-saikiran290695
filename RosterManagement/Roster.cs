using System;
using System.Linq;
using System.Collections.Generic;

namespace RosterManagement
{
    public class CodeSchool
    {
        Dictionary<int, List<string>> _roster;

        public CodeSchool()
        {
            _roster = new Dictionary<int, List<String>>();
        }        
        /// <summary>
        /// Should be able to Add Student to a Particular Wave
        /// </summary>
        /// <param name="cadet">Refers to the name of the Cadet</param>
        /// <param name="wave">Refers to the Wave number</param>
        public void Add(string cadet, int wave)
        {
            List<string> students = new List<string>();
            students.Add(cadet);
            try
            {
                _roster[wave].AddRange(students);
                _roster[wave].Sort();
            }
            catch
            {
                _roster.Add(wave, students);
            }
        }
        /// <summary>
        /// Returns all the Cadets in a given wave
        /// </summary>
        /// <param name="wave">Refers to the wave number from where cadet list is to be fetched</param>
        /// <returns>List of Cadet's Name</returns>
        public List<string> Grade(int wave)
        {
            var list = new List<string>();
            try
            {
                list = _roster[wave];
                return list.ToList();
            }
            catch
            {
                return list;
            }
        }
        /// <summary>
        /// Return all the cadets in the CodeSchool
        /// </summary>
        /// <returns>List of Cadet's Name</returns>
        public List<string> Roster()
        {
            var cadets = new List<string>();
            foreach(int index in _roster.Keys.OrderBy(element => element))
            {
                cadets.AddRange(_roster[index].ToList());
            }
            return cadets;
        }
    }
}
