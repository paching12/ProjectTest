namespace projectTest.Entities
{
    public class TvShow
    {
        public string name { get; set; }

        public int id { get; set; }

        public bool favorite { get; set; }

        public TvShow( int id, string name ) {
            ( this.id, this.name ) = ( id, name );
            favorite = false;
        } 

    }

}