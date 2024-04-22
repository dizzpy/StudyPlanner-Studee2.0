using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalStudyPlanner_Studee.Models
{
    public class Quotes
    {
        private List<string> quotes = new List<string>()
        {
        "Success is not the key to happiness. Happiness is the key to success. If you love what you are doing, you will be successful. - Albert Schweitzer",
        "The only way to do great work is to love what you do. If you haven't found it yet, keep looking. Don't settle. As with all matters of the heart, you'll know when you find it. - Steve Jobs",
        "Success is not the result of spontaneous combustion. You must set yourself on fire. - Arnold H. Glasow",
        "The future belongs to those who believe in the beauty of their dreams. Dare to dream big, for only then can you achieve greatness. - Eleanor Roosevelt",
        "Don't watch the clock; do what it does. Keep going. Persistence and determination are key ingredients in the recipe of success. - Sam Levenson",
        "You don't have to be great to start, but you have to start to be great. Every journey begins with a single step. Take that step fearlessly, for it leads you closer to your dreams. - Zig Ziglar",
        "Believe you can and you're halfway there. Confidence in yourself is the first step towards achieving your goals. - Theodore Roosevelt",
        "The only limit to our realization of tomorrow will be our doubts of today. Banish doubt and embrace possibility, for it is the fuel that propels us towards our dreams. - Franklin D. Roosevelt",
        };

        public List<string> GetAllQuotes()
        {
            return quotes;
        }
    }
}
