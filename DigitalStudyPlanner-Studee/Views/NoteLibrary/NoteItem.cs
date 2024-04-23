using Google.Cloud.Firestore;
using System.Xml.Linq;

namespace DigitalStudyPlanner_Studee.Views.NoteLibrary
{
    public class NoteItem
    {
        [FirestoreProperty]
        public string NoteTitle { get; set; }

        [FirestoreProperty]
        public string NoteContent { get; set; }

        [FirestoreProperty]
        public string NoteID { get; set; }

        public override string ToString()
        {
            return $"Title: {NoteTitle}, Note: {NoteContent}";
        }
    }
}