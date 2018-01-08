using System;
using System.Collections.Generic;
using System.Linq;

class ForumTopics
{
    static Dictionary<string, HashSet<string>> data = new Dictionary<string, HashSet<string>>();
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        while (input[0] != "filter")
        {
            string topic = input[0];
            string[] tags = input[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (!data.ContainsKey(topic))
            {
                data.Add(topic, new HashSet<string>());
            }
            foreach (var tag in tags)
            {
                data[topic].Add(tag);
            }
            input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        }
        string[] sequenceOfTags = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        PrintTopic(data, sequenceOfTags);
    }
    static bool ContainedTags(HashSet<string> tags, string[] tagzForCheck)
    {
        foreach (var tag in tagzForCheck)
        {
            if (!tags.Contains(tag))
            {
                return false;
            }
        }
        return true;
    }
    static void PrintTopic(Dictionary<string, HashSet<string>> data, string[] tags)
    {
        foreach (var topicData in data)
        {
            string topic = topicData.Key;
            HashSet<string> tagsData = topicData.Value;
            if (ContainedTags(tagsData, tags))
            {
                var hashtaggedTags = tagsData.Select(t => "#" + t);
                Console.WriteLine("{0} | {1}", topic, string.Join(", ", hashtaggedTags));
            }
        }
    }
}
