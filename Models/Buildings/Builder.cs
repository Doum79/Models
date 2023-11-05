namespace Models.Buildings
{
    public class Builder
    {
        public BuildingBase Build(BuildingType type)
        {
            switch (type)
            {
                case BuildingType.Armory:
                    return new Armory();
                case BuildingType.Barracks:
                    return new Barracks();
                case BuildingType.CommandCenter:
                    return new CommandCenter();
                default:
                    return null;
            }
        }
    }
}
