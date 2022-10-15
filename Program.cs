using System;
using System.Collections.Generic;
using System.Linq;
using Balta.ContentContext;

namespace Balta{
    class Program{
        static void Main(string[] args) {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo 1", "artigo1"));
            articles.Add(new Article("Artigo 2", "artigo2"));
            articles.Add(new Article("Artigo 3", "artigo3"));

            /*foreach(var article in articles){
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }*/

            var courses = new List<Course>();
            courses.Add(new Course("Curso 1", "curso1", "", null, 5, ContentContext.Enums.EContentLevel.Basic));
            courses.Add(new Course("Curso 2", "curso2", "", null, 5, ContentContext.Enums.EContentLevel.Fundamental));
            courses.Add(new Course("Curso 3", "curso3", "", null, 5, ContentContext.Enums.EContentLevel.Intermediary));

            var careers = new List<Career>();
            careers.Add(new Career("Carreira 1", "carreira1"));
            careers.Add(new Career("Carreira 2", "carreira2"));
            careers.Add(new Career("Carreira 3", "carreira3"));
            var careerItems = new List<CareerItem>();
            careerItems.Add(new CareerItem(1 ,"Item 1", "Descrição", null));
            careerItems.Add(new CareerItem(2, "Item 2", "Descrição", courses[0]));
            careerItems.Add(new CareerItem(3, "Item 3", "Descrição", courses[0]));

            foreach(var item in careerItems){
                careers[0].Items.Add(item);
            }

            foreach(var career in careers){
                Console.WriteLine(career.Title);
                foreach(var item in careerItems.OrderBy(x => x.Order)){
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine($"{item.Course?.Title} - {item.Course?.Level}");

                    foreach(var notification in item.Notifications){
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }

        }
    }
}
