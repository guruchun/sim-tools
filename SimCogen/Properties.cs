namespace FcpUtils
{
    public class Property {
        private Dictionary<String, String> list;
        private String filename;

        public Property(String file)
        {
            list = new Dictionary<String, String>();
            this.filename = file;

            Reload();
        }

        public String Get(String field, String defValue)
        {
            // null이면 defValue 사용
            return Get(field) ?? defValue;
        }
        public String Get(String field)
        {
            return (list.ContainsKey(field)) ? (list[field]) : "";
        }

        public void Set(String field, Object value)
        {
            if (!list.ContainsKey(field))
                list.Add(field, value.ToString() ?? "");
            else
                list[field] = value.ToString() ?? "";
        }

        public void Save()
        {
            Save(this.filename);
        }

        public void Save(String filename)
        {
            this.filename = filename;

            if (!System.IO.File.Exists(filename))
                System.IO.File.Create(filename);

            System.IO.StreamWriter file = new System.IO.StreamWriter(filename);

            foreach (String prop in list.Keys.ToArray())
                if (!String.IsNullOrWhiteSpace(list[prop]))
                    file.WriteLine(prop + "=" + list[prop]);

            file.Close();
        }

        public void Reload()
        {
            Load(this.filename);
        }

        public void Load(String filename)
        {
            //this.filename = filename;
            //if (System.IO.File.Exists(filename))
            //    LoadFromFile(filename);
            //else
            //    System.IO.File.Create(filename);
        }

        private void LoadFromFile(String file)
        {
            foreach (String line in System.IO.File.ReadAllLines(file))
            {
                // check invalid line
                if ((String.IsNullOrEmpty(line)) || (line.StartsWith(";")) || (line.StartsWith("#")) || (!line.Contains('=')))
                    continue;

                // ignore line comment
                string kvLine = line;
                int pos = line.IndexOf(';');
                if (pos > 0)
                    kvLine = line[..pos].Trim();
                pos = line.IndexOf('#');
                if (pos > 0)
                    kvLine = line[..pos].Trim();

                // parse key & value
                int index = kvLine.IndexOf('=');
                String key = kvLine[..index].Trim();
                String value = kvLine[(index + 1)..].Trim();
                try
                {
                    //ignore dublicates
                    list.Add(key, value);
                }
                catch { }
            }
        }
    }
}
