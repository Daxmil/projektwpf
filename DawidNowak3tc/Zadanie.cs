namespace DawidNowak3tc
{
    public class Zadanie
    {
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public bool CzyWykonane { get; set; }
        public string EmojiWykonania => CzyWykonane ? "✅" : "❌";
    }
}
