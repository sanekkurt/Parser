
namespace Parser.Scopus
{
    class ScopusSettings : IParserSettings
    {
        public ScopusSettings(string Id)
        {
            ID = Id;
        }

        //public string BaseUrl { get; set; } = "https://www.scopus.com/results/results.uri?sort=plf-f&src=s&sid=d2e92069ec3f00fa0096a853f2687d47&sot=aut&sdt=a&sl=17&s=";
        //public string BaseUrl { get; set; } = "https://www.scopus.com/results/results.uri?cc=10&sort=plf-f&src=s&nlo=&nlr=&nls=&sid=8be774e8dd3312fa6e05ec914cf029bc&sot=aut&sdt=a&sl=18&s=";
        public string BaseUrl { get; set; } = "https://www.scopus.com/results/results.uri?&src=s&nlo=&nlr=&nls=&sid=8be774e8dd3312fa6e05ec914cf029bc&sot=aut&sdt=a&sl=18&cl=t&origin=resultslist&ss=plf-f&ws=r-f&ps=r-f&cs=r-f&cc=10";
        public string Parametr_Search { get; set; } = "&s=AU-ID({AuthorID})&offset={PageNumber}";

        public string ID { get; set; }
    }
}

/*namespace Parser.Scopus
{
    class ScopusSettings : IParserSettings
    {
        public ScopusSettings(string Id)
        {
            ID = Id;
        }

        public string BaseUrl { get; set; } = "https://www.scopus.com/authid/detail.uri?";

        public string Parametr_Search { get; set; } = "authorId={AuthorID}#documentTab";

        public string ID { get; set; }
    }
}
*/