using System;
using System.Collections.Generic;
using AngleSharp.Html.Parser;
using Parser.Common;


namespace Parser.Elibrary
{

    class ParserWorkerExtend<T> where T : class
    {
        IParser<T> parser;
        IParserSettingsExtend parserSettings;

        HtmlLoaderExtend loader;

        bool isActive;

        #region Properties

        public IParser<T> Parser
        {
            get
            {
                return parser;
            }
            set
            {
                parser = value;
            }
        }

        public IParserSettingsExtend Settings
        {
            get
            {
                return parserSettings;
            }
            set
            {
                parserSettings = value;
                loader = new HtmlLoaderExtend(value);
            }
        }

        public bool IsActive
        {
            get
            {
                return isActive;
            }
        }

        #endregion

        public event Action<object, T> OnNewData;
        public event Action<object> OnCompleted;

        public ParserWorkerExtend(IParser<T> parser)
        {
            this.parser = parser;
        }

        public ParserWorkerExtend(IParser<T> parser, IParserSettingsExtend parserSettings) : this(parser)
        {
            this.parserSettings = parserSettings;
        }

        public void Start()
        {
            isActive = true;
            Worker();
        }

        public void Abort()
        {
            isActive = false;
        }

        private async void Worker()
        {
           
            int pageNum = 1;
            while (true)
            {
                if (!isActive)
                {
                    OnCompleted?.Invoke(this);
                    return;
                }

                var source = await loader.GetSourceByPage(pageNum.ToString());
               // if (pageNum == 13) break;
                pageNum++;
                var domParser = new HtmlParser();

                var document = domParser.ParseDocument(source);

                var result = parser.Parse(document);

                if (result == null) break;
                else OnNewData?.Invoke(this, result);
            }


            OnCompleted?.Invoke(this);
            isActive = false;
        }


    }
}
