﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourPlanner.Models {
    public class TourManager {
        private readonly Dictionary<Guid, Tour> _allTours;

        public TourManager() {
            _allTours = new Dictionary<Guid, Tour>();
        }

        public Tour GetTour(Guid id) { 
            return _allTours[id];
        }

        public void AddTour(Tour tour) {
            _allTours.Add(tour.Id, tour);
        }

        public void RemoveTour(Guid id) {  _allTours.Remove(id); }

        public void UpdateTour(Guid id,  Tour tour) {
            _allTours[id] = tour;
        }
        public IEnumerable<Tour> GetAllTours() {  
            return _allTours.Values; 
        }

        public bool TourExists(Guid id) {
            return _allTours.ContainsKey(id);
        }
    }
}