using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaServer.Data
{
    public class MediaServerService
    {

        public string songName { get; set; }

        public IEnumerable<System.IO.FileInfo> GetSongFiles(string songFileLocation)
        {
            var songs = new System.IO.DirectoryInfo(songFileLocation);


            foreach (var song in songs.EnumerateFiles())
            {
                yield return song;

            }
        }

        public int PlaySong(string songfile, string shortSongName,string processName, string executableFile, string pythonScriptFile, string workingLocation)
        {

            if (System.Diagnostics.Process.GetProcessesByName(processName).Length == 0 && System.Diagnostics.Process.GetProcessesByName(processName).Length < 2)
            {
                System.Diagnostics.Process pr = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo prinfo = new System.Diagnostics.ProcessStartInfo(executableFile);
                prinfo.Arguments = $"{pythonScriptFile} {songfile}";
                prinfo.WorkingDirectory = $"{workingLocation}";
                prinfo.UseShellExecute = false;
                prinfo.RedirectStandardOutput = true;
                pr.StartInfo = prinfo;
                pr.Start();
                songName = shortSongName;

                Console.WriteLine(pr.Id);
                return pr.Id;

            }
            return 4194304;





        }


    

        public void StopSongLoad(string processName)
        {
            var runningSongs=System.Diagnostics.Process.GetProcessesByName(processName);
          
                foreach (System.Diagnostics.Process pr in runningSongs)
                {
                    pr.Kill();

                }
         
        }
      
        public int CheckSongRunningLoadingPage(string processName)
        {
            var runningSongs = System.Diagnostics.Process.GetProcessesByName(processName);
            if (runningSongs.Length > 0)
            {
                foreach (System.Diagnostics.Process pr in runningSongs)
                {
                   

                }
                return 1;
            }
            return 0;
        }

    }
}
