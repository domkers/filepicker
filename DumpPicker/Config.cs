using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DumpPicker
{
    class Config
    {
        public string inifile = System.Environment.CurrentDirectory + "/config.ini";
        public const string inisection = "names";
        public const string filterSection = "filter";

        /// <summary>
        /// 显示的名字
        /// </summary>
        public static string[] names = { "万里鹏", "张文旭", "王世元", "余天照", "吕斌", "刘俊斌", "李鑫" };
        /// <summary>
        /// 对应文件夹名称
        /// </summary>
        public static string[] folder = { "wanlipeng", "zhangwenxu", "wangshiyuan", "yutianzhao", "lvbin", "liujunbin", "lixin" };
        /// <summary>
        /// 初始化，判断是否存在配置文件
        /// </summary>
        public Config()
        {
            if (!File.Exists(inifile))
            {
                for (int i = 0; i < names.Length; i++)
                {
                    IniTool.INIWriteValue(inifile, inisection, folder[i], names[i]);
                }
                // 过滤词
                IniTool.INIWriteValue(inifile, filterSection, "keyword", "");
            }
        }

        /// <summary>
        /// 返回名字的value的集合
        /// </summary>
        /// <returns></returns>
        public string[] getNames()
        {
            return IniTool.INIGetAllItemKeys(inifile, inisection);
        }

        /// <summary>
        /// 得到某一个分类里的项目value
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string getName(string key)
        {
            return IniTool.INIGetStringValue(inifile, inisection, key, "unknow");
        }

        /// <summary>
        /// 配置存储的关键词，过滤不包含关键词的文件
        /// </summary>
        /// <returns></returns>
        public string getKeyword()
        {
            return IniTool.INIGetStringValue(inifile, filterSection, "keyword", "");
        }
    }
}
