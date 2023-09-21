namespace Member.Domain
{
    //En esta capa se encuentran todos los dominios o entidades necesarias para ejectura el API.
    //ESta capa no referencia a ninguna de las capas externas.
    public class Member
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }

    }
}