using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace ToastLibrary
{
    /// <summary>
    /// http://msdn.microsoft.com/ja-jp/library/windows/apps/hh761494.aspx
    /// </summary>
    public class Toast
    {
        #region Common

        private static XmlDocument CreateXmlFromTemplate(ToastTemplateType toastTemplate, string[] texts, string src = null, string alt = null, string duration = "short", bool silent = false, string audioSrc = null, bool loop = false, string launch = "")
        {
            XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(toastTemplate);
            XmlNodeList toastTextElements = toastXml.GetElementsByTagName("text");
            for (int i = 0; i < texts.Length; i++)
            {
                toastTextElements[i].AppendChild(toastXml.CreateTextNode(texts[i]));
            }

            if (src != null)
            {
                XmlNodeList toastImageAttributes = toastXml.GetElementsByTagName("image");
                ((XmlElement)toastImageAttributes[0]).SetAttribute("src", src);
                ((XmlElement)toastImageAttributes[0]).SetAttribute("alt", alt);
            }

            IXmlNode toastNode = toastXml.SelectSingleNode("/toast");

            ((XmlElement)toastNode).SetAttribute("duration", duration);

            XmlElement audio = toastXml.CreateElement("audio");
            if (audioSrc != null)
            {
                audio.SetAttribute("src", audioSrc);
                if (duration == "long")
                {
                    audio.SetAttribute("loop", loop.ToString().ToLower());
                }
            }
            audio.SetAttribute("silent", silent.ToString().ToLower());
            toastNode.AppendChild(audio);

            ((XmlElement)toastNode).SetAttribute("launch", launch);
            return toastXml;
        }

        #endregion

        #region Text

        public static void Text01(string bodyText, string duration = "short", bool silent = false, string audioSrc = null, bool loop = false, string launch = "")
        {
            ToastTemplateType toastTemplate = ToastTemplateType.ToastText01;
            XmlDocument toastXml = CreateXmlFromTemplate(toastTemplate, new string[] { bodyText }, null, null, duration, silent, audioSrc, loop, launch);
            ToastNotification toast = new ToastNotification(toastXml);
            ToastNotificationManager.CreateToastNotifier().Show(toast);
        }

        public static void Text02(string headlineText, string bodyText, string duration = "short", bool silent = false, string audioSrc = null, bool loop = false, string launch = "")
        {
            ToastTemplateType toastTemplate = ToastTemplateType.ToastText02;
            XmlDocument toastXml = CreateXmlFromTemplate(toastTemplate, new string[] { headlineText, bodyText }, null, null, duration, silent, audioSrc, loop, launch);
            ToastNotification toast = new ToastNotification(toastXml);
            ToastNotificationManager.CreateToastNotifier().Show(toast);
        }

        public static void Text03(string headlineText, string bodyText, string duration = "short", bool silent = false, string audioSrc = null, bool loop = false, string launch = "")
        {
            ToastTemplateType toastTemplate = ToastTemplateType.ToastText03;
            XmlDocument toastXml = CreateXmlFromTemplate(toastTemplate, new string[] { headlineText, bodyText }, null, null, duration, silent, audioSrc, loop, launch);
            ToastNotification toast = new ToastNotification(toastXml);
            ToastNotificationManager.CreateToastNotifier().Show(toast);
        }

        public static void Text04(string headlineText, string bodyText1, string bodyText2, string duration = "short", bool silent = false, string audioSrc = null, bool loop = false, string launch = "")
        {
            ToastTemplateType toastTemplate = ToastTemplateType.ToastText04;
            XmlDocument toastXml = CreateXmlFromTemplate(toastTemplate, new string[] { headlineText, bodyText1, bodyText2 }, null, null, duration, silent, audioSrc, loop, launch);
            ToastNotification toast = new ToastNotification(toastXml);
            ToastNotificationManager.CreateToastNotifier().Show(toast);
        }

        #endregion

        #region ImageAndText

        public static void ImageAndText01(string bodyText, string src, string alt = "", string duration = "short", bool silent = false, string audioSrc = null, bool loop = false, string launch = "")
        {
            ToastTemplateType toastTemplate = ToastTemplateType.ToastImageAndText01;
            XmlDocument toastXml = CreateXmlFromTemplate(toastTemplate, new string[] { bodyText }, src, alt, duration, silent, audioSrc, loop, launch);
            ToastNotification toast = new ToastNotification(toastXml);
            ToastNotificationManager.CreateToastNotifier().Show(toast);
        }

        public static void ImageAndText02(string headlineText, string bodyText, string src, string alt = "", string duration = "short", bool silent = false, string audioSrc = null, bool loop = false, string launch = "")
        {
            ToastTemplateType toastTemplate = ToastTemplateType.ToastImageAndText02;
            XmlDocument toastXml = CreateXmlFromTemplate(toastTemplate, new string[] { headlineText, bodyText }, src, alt, duration, silent, audioSrc, loop, launch);
            ToastNotification toast = new ToastNotification(toastXml);
            ToastNotificationManager.CreateToastNotifier().Show(toast);
        }

        public static void ImageAndText03(string headlineText, string bodyText, string src, string alt = "", string duration = "short", bool silent = false, string audioSrc = null, bool loop = false, string launch = "")
        {
            ToastTemplateType toastTemplate = ToastTemplateType.ToastImageAndText03;
            XmlDocument toastXml = CreateXmlFromTemplate(toastTemplate, new string[] { headlineText, bodyText }, src, alt, duration, silent, audioSrc, loop, launch);
            ToastNotification toast = new ToastNotification(toastXml);
            ToastNotificationManager.CreateToastNotifier().Show(toast);
        }

        public static void ImageAndText04(string headlineText, string bodyText1, string bodyText2, string src, string alt = "", string duration = "short", bool silent = false, string audioSrc = null, bool loop = false, string launch = "")
        {
            ToastTemplateType toastTemplate = ToastTemplateType.ToastImageAndText04;
            XmlDocument toastXml = CreateXmlFromTemplate(toastTemplate, new string[] { headlineText, bodyText1, bodyText2 }, src, alt, duration, silent, audioSrc, loop, launch);
            ToastNotification toast = new ToastNotification(toastXml);
            ToastNotificationManager.CreateToastNotifier().Show(toast);
        }

        #endregion
    }
}
