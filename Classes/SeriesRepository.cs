using System;
using System.Collections.Generic;
using SeriesRegisterApp.Interfaces;

namespace SeriesRegisterApp
{

    public class Seriesrepository : IRepository<Series>
    {
        private List<Series> listOfSeries = new List<Series>();
        public List<Series> List(){
            
        }
        public void Update(int id, Series entity){
            listOfSeries[id] = entity;
        }
        public void Delete(int id){
           listOfSeries[id].Exclude();
        }
        public void Insert(Series entity){
          listOfSeries.Add(entity);
        }
        public int NextId(){
           return listOfSeries.Count;
        }
        public Series GetById(int id){
            return listOfSeries[id];
        }
    }

}
