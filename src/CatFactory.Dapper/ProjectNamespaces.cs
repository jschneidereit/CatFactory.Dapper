﻿namespace CatFactory.Dapper
{
    public class ProjectNamespaces
    {
        public ProjectNamespaces()
        {
            EntityLayer = "EntityLayer";
            DataLayer = "DataLayer";
            Contracts = "Contracts";
            DataContracts = "DataContracts";
            Repositories = "Repositories";
        }

        public string EntityLayer { get; set; }

        public string DataLayer { get; set; }

        public string Contracts { get; set; }

        public string DataContracts { get; set; }

        public string Repositories { get; set; }
    }
}
