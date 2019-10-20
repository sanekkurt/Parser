
namespace Parser.Elibrary
{
    class ElibrarySettings:IParserSettingsExtend
    {

        public ElibrarySettings(string Id)
        {
            ID = Id;
        }

        public string BaseUrl { get; set; } = "https://elibrary.ru/author_items.asp?";

        public string Parametr_Search { get; set; } = "authorid={AuthorID}&pagenum={PageNumber}";

        public string ID { get; set; }

    }
}
