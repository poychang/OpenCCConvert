using OpenCCConvert;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var cht = OpenCCHelper.Chs2Cht("预设记忆体大小与硬碟容量");
Console.WriteLine(cht);

var chs = OpenCCHelper.Cht2Chs("預設記憶體大小與硬碟容量");
Console.WriteLine(chs);
