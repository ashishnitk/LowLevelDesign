using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HelloWorld.LSP
{
    public class Project
    {
        public Collection<ProjectFile> ProjectFiles { get; set; }

        public void LoadAllFiles()
        {
            foreach (ProjectFile file in ProjectFiles)
            {
                file.LoadFileData();
            }
        }

        public void SaveAllFiles()
        {
            foreach (ProjectFile file in ProjectFiles)
            {
                if (file as ReadOnlyFile == null)
                    file.SaveFileData();
            }
        }
    }


    public class ProjectFile
    {
        public string FilePath { get; set; }

        public byte[] FileData { get; set; }

        public void LoadFileData()
        {
            // Retrieve FileData from disk
        }

        public virtual void SaveFileData()
        {
            // Write FileData to disk
        }
    }


    public class ReadOnlyFile : ProjectFile
    {
        public override void SaveFileData()
        {
            throw new InvalidOperationException();
        }
    }
}
