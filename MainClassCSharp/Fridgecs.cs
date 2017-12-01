using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassCSharp
{
    public partial class Fridgecs
    {
        private string _model;
        private string _production;
        private int _price;
        private int _weight;
        private int _overallVolume;
        

        public Fridgecs(string model, string production, int price, int weight, int overallVolume)
        {
            _model = model;
            _production = production;
            _price = price;
            _weight = weight;
            _overallVolume = overallVolume;
        }

        public Fridgecs(Fridgecs temp)
        {
            _model = temp._model;
            _production = temp._production;
            _price = temp._price;
            _weight = temp._weight;
            _overallVolume = temp._overallVolume;
        }

        public void SetModel(string model)
        {
            _model = model;
        }

        public string GetModel()
        {
            return (_model);
        }

        public void SetProduction(string production)
        {
            _production = production;
        }

        public string GetProduction()
        {
            return (_production);
        }

        public void SetPrice(int price)
        {
            _price = price;
        }

        public int GetPrice()
        {
            return (_price);
        }

        public void SetWeight(int weight)
        {
            _weight = weight;
        }

        public int GetWeight()
        {
            return (_weight);
        }

        public void SetOverallVolume(int overallVolume)
        {
            _overallVolume = overallVolume;
        }

        public int GetOverallVolume()
        {
            return (_overallVolume);
        }
    }
}
