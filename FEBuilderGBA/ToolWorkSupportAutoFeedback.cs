﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FEBuilderGBA
{
    public class ToolWorkSupportAutoFeedback
    {
        bool IsAutoFeedBack = false;
        string USERHASH = "";
        string VERSION = "";

        string AUTOFEEDBACK_POST_USERHASH = "";
        string AUTOFEEDBACK_POST_VERSION = "";
        string AUTOFEEDBACK_POST_CHAPTER = "";
        string AUTOFEEDBACK_POST_DEADUNIT = "";
        string AUTOFEEDBACK_POST_BASE64 = "";
        string AUTOFEEDBACK_URL = "";

        string SavFilename = "";

        const int FEEDBACK_WAIT_MINUTE = 1;
        DateTime LastFeedBackPostTime = DateTime.Now.AddMinutes(-FEEDBACK_WAIT_MINUTE);
        string LastFeedBackType = "";
        bool IsBusy = false;

        public void Init(Dictionary<string, string> lines, bool enableAutoFeedback)
        {
            string url = U.at(lines, "AUTOFEEDBACK_URL");
            AUTOFEEDBACK_URL = url;

            AUTOFEEDBACK_POST_USERHASH = U.at(lines, "AUTOFEEDBACK_POST_USERHASH");
            AUTOFEEDBACK_POST_VERSION = U.at(lines, "AUTOFEEDBACK_POST_VERSION");
            AUTOFEEDBACK_POST_CHAPTER = U.at(lines, "AUTOFEEDBACK_POST_CHAPTER");
            AUTOFEEDBACK_POST_DEADUNIT = U.at(lines, "AUTOFEEDBACK_POST_DEADUNIT");
            AUTOFEEDBACK_POST_BASE64 = U.at(lines, "AUTOFEEDBACK_POST_BASE64");

            this.USERHASH = MakeUserHash();
            this.VERSION = MakeVersion();
            this.SavFilename = MakeSavFilename();
            if (url == "")
            {//URLが無効なのでできません
                IsAutoFeedBack = false;
            }
            else if (enableAutoFeedback == false)
            {//ユーザーが拒否しているのでできません
                IsAutoFeedBack = false;
            }
            else
            {//OK,自動フィードバックできる
                IsAutoFeedBack = true;
            }
        }
        public void SetAutoFeedBackStatus(bool r)
        {
            if (AUTOFEEDBACK_URL == "")
            {
                IsAutoFeedBack = false;
                return;
            }
            IsAutoFeedBack = r;
        }

        string MakeSavFilename()
        {
            return U.ChangeExtFilename(Program.ROM.Filename, ".SAV", ".emulator");
        }
        string MakeUserHash()
        {
            string users = System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            byte[] data = System.Text.Encoding.ASCII.GetBytes(users);
            uint sum = U.CalcCheckSUM(data);
            return sum.ToString();
        }
        string MakeVersion()
        {
            uint size = (uint) (Program.ROM.Data.Length / 1024);
            if (! File.Exists(Program.ROM.Filename))
            {
                return "_" + size;
            }
            string filename = Path.GetFileNameWithoutExtension(Program.ROM.Filename);
            DateTime dt = U.GetFileDateLastWriteTime(Program.ROM.Filename);
            return filename + "\r\n" + dt.ToString("yyyyMMdd") + "\r\n" + size;
        }
        public bool GetIsAutoFeedBack()
        {
            return IsAutoFeedBack;
        }
        public DateTime GetLastFeedBackPostTime()
        {
            return LastFeedBackPostTime;
        }
        public bool GetAutoFeedBackEnable()
        {
            if (AUTOFEEDBACK_URL == "")
            {
                return false;
            }
            return true;
        }
        public void SendFeedBack(uint mapid)
        {
            if (! IsAutoFeedBack)
            {//フィードバックはしない
                return;
            }
            if (IsBusy)
            {//レポートスレッドが動作しているので、何もしない
                return;
            }

            DateTime now = DateTime.Now;
            if (now <= LastFeedBackPostTime)
            {//クールダウン中
                return;
            }

            bool flag0x03 = EmulatorMemoryUtil.IsFlag0x03Enable();
            if (flag0x03)
            {
                if (SendFeedBack_EndEvent(mapid))
                {
                    return;
                }
            }

            uint deadunit = EmulatorMemoryUtil.DeadPlayerUnit();
            if (deadunit != 0)
            {
                if (SendFeedBack_DeadEvent(mapid, deadunit))
                {
                    return;
                }
            }
        }
        bool SendFeedBack_EndEvent(uint mapid)
        {
            string eventType = "EndEvent" + mapid;
            if (LastFeedBackType == eventType)
            {//連続して報告はしない
                return false;
            }
            uint maptaskProcs = EmulatorMemoryUtil.SearchMapTaskProcsAddr();
            if (maptaskProcs == U.NOT_FOUND)
            {//マップに入っていないので、章タイトルを表示している最中だろうから、送ってはいけない
                return false;
            }

            Send(mapid, 0x0);
            LastFeedBackType = eventType;
            LastFeedBackPostTime = DateTime.Now.AddMinutes(FEEDBACK_WAIT_MINUTE);
            return true;
        }
        bool SendFeedBack_DeadEvent(uint mapid, uint deadunit)
        {
            string eventType = "UnitDead" + deadunit;
            if (LastFeedBackType == eventType)
            {//連続して報告はしない
                return false;
            }
            uint maptaskProcs = EmulatorMemoryUtil.SearchMapTaskProcsAddr();
            if (maptaskProcs == U.NOT_FOUND)
            {//マップに入っていないので、章タイトルを表示している最中だろうから、送ってはいけない
                return false;
            }

            Send(mapid, deadunit);
            LastFeedBackType = eventType;
            LastFeedBackPostTime = DateTime.Now.AddMinutes(FEEDBACK_WAIT_MINUTE);
            return true;
        }
        string MakeBase64()
        {
            if (! File.Exists(this.SavFilename))
            {//セーブファイルがない!
                return "";
            }

            try
            {
                string temp7z = Path.GetTempFileName();
                File.Delete(temp7z);
                temp7z = temp7z + ".7z";
                ArchSevenZip.Compress(temp7z, this.SavFilename);
                byte[] bin = File.ReadAllBytes(temp7z);
                File.Delete(temp7z);
                return System.Convert.ToBase64String(bin);
            }
            catch (Exception)
            {
                return "";
            }
        }
        void Send(uint mapid, uint uid)
        {
            string chapter = MapSettingForm.GetMapName(mapid);
            if (chapter == "")
            {
                return;
            }
            chapter = mapid.ToString("X02") + " " + chapter
                + "\r\n" + EmulatorMemoryUtil.MakeChapterExtraInfo();
            string deadunit;
            if (uid == 0)
            {
                deadunit = "";
            }
            else
            {
                deadunit = UnitForm.GetUnitName(uid);
                deadunit = uid.ToString("X02") + " " + deadunit
                    + "\r\n" + EmulatorMemoryUtil.MakeUnitBattleExtraInfo();
            }

            System.Threading.Thread s1 = new System.Threading.Thread(t =>
            {
                IsBusy = true;
                try
                {
                    string base64 = MakeBase64();
                    if (base64 != "")
                    {
                        Send(chapter, deadunit, base64);
                    }
                }
                catch (Exception)
                {
                }
                IsBusy = false;
            });
            s1.Start();
        }

        void Send(string chapter, string deadunit, string base64)
        {
            if (AUTOFEEDBACK_URL == "")
            {
                return;
            }

            try
            {
                Dictionary<string, string> args = new Dictionary<string, string>();
                args["ifq"] = "";
                if (AUTOFEEDBACK_POST_USERHASH != "") args[AUTOFEEDBACK_POST_USERHASH] = this.USERHASH;
                if (AUTOFEEDBACK_POST_VERSION != "") args[AUTOFEEDBACK_POST_VERSION] = this.VERSION;
                if (AUTOFEEDBACK_POST_CHAPTER != "") args[AUTOFEEDBACK_POST_CHAPTER] = chapter;
                if (AUTOFEEDBACK_POST_DEADUNIT != "") args[AUTOFEEDBACK_POST_DEADUNIT] = deadunit;
                if (AUTOFEEDBACK_POST_BASE64 != "") args[AUTOFEEDBACK_POST_BASE64] = base64;
                args["submit"] = "Submit";

                U.HttpPost(AUTOFEEDBACK_URL, args);
                Log.Notify("AutoFeedback", AUTOFEEDBACK_URL, this.USERHASH, this.VERSION, chapter, deadunit, base64);
            }
            catch (Exception)
            {
            }
        }
    }
}
