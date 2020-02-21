using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace MicrosoftWikiScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlWeb web = new HtmlWeb();
            var full_html = web.Load("https://en.wikipedia.org/wiki/Microsoft");

            string full_text = full_html.DocumentNode.SelectSingleNode("//body").InnerText;
            full_text = Regex.Replace(full_text, @"\s+", " ").Trim();

            string[] split_text = full_text.Split(new string[]
            {
                "1972–1985: The founding of Microsoft", "The company is run by a board of directors"
            }, StringSplitOptions.None);

            string history_text_with_punctuation = split_text[2].ToLower();
            string history_text = Regex.Replace(history_text_with_punctuation, @"[^a-z ]", "");
            history_text = Regex.Replace(history_text, @"[\d-]", string.Empty);

            string[] words = history_text.Split(new string[] { " " }, StringSplitOptions.None);

            var word_dictionary = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (word_dictionary.ContainsKey(words[i]))
                {
                    int value = word_dictionary[words[i]];
                    word_dictionary[words[i]] = value + 1;
                }
                else { word_dictionary.Add(words[i], 1); }
            }
            var word_list = word_dictionary.ToList();
            word_list.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));

            for (int i=1; i<=10; i++)
            {
                Console.WriteLine("{0}. {1}", i, word_list[i]);               
            }

            Console.Write("Type a word to see the number of times it occurs: ");
            string user_input = Console.ReadLine().ToLower();
            if (word_dictionary.ContainsKey(user_input))
            {
                Console.WriteLine(word_dictionary[user_input]);
            }
            else Console.WriteLine("{0} was not found in the dictionary.");
        }
    }
}