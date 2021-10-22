namespace OpenCCConvert
{
    public static class OpenCCHelper
    {
        /// <summary>
        /// 簡體到香港繁體
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Chs2ChtHK(string input) => OpenCC.Convert(input, ".\\opencc\\s2hk.json");

        /// <summary>
        /// 簡體到繁體
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Chs2Cht(string input) => OpenCC.Convert(input, ".\\opencc\\s2t.json");

        /// <summary>
        /// 簡體到臺灣正體
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Chs2ChtTW(string input) => OpenCC.Convert(input, ".\\opencc\\s2tw.json");

        /// <summary>
        /// 簡體到臺灣正體（包括詞彙）
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Chs2ChtTWp(string input) => OpenCC.Convert(input, ".\\opencc\\s2twp.json");

        /// <summary>
        /// 繁體到香港繁體
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Cht2ChtHK(string input) => OpenCC.Convert(input, ".\\opencc\\t2hk.json");

        /// <summary>
        /// 繁體到簡體
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Cht2Chs(string input) => OpenCC.Convert(input, ".\\opencc\\t2s.json");

        /// <summary>
        /// 繁體到臺灣正體
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Cht2ChtTW(string input) => OpenCC.Convert(input, ".\\opencc\\t2tw.json");

        /// <summary>
        /// 臺灣正體到簡體
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Cht2ToChs(string input) => OpenCC.Convert(input, ".\\opencc\\tw2s.json");

        /// <summary>
        /// 臺灣正體到簡體（包括詞彙）
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Cht2ToChsp(string input) => OpenCC.Convert(input, ".\\opencc\\tw2sp.json");
    }
}
