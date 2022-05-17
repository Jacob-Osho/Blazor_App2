namespace GameIndustry_V2.Helpers
{
    public struct MultipleSelecterHelperModel
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public MultipleSelecterHelperModel(string key,string value)
        {
            Key = key;
            Value = value;
        }

    }
}
