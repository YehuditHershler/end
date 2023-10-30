namespace Api1.patriot
{
    public class Loction
    {
        public string City { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public Patriotmissile MisleState { get; set; }

        public IEnumerable<Loction> Getdata()
        {
            return DB.data;
        }
        public bool add(Loction l)
        {
            DB.data.Add(l);
            return true;
        }
    }
}
