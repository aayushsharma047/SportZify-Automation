using SportZify.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportZify.Services
{
    public class GymService
    {
        public List<GymPlace> GetGymPlaces()
        {
            return new List<GymPlace>()
            {
                new GymPlace()
                {
                    GymId=1,
                    GymName="Gold's Gym",
                    GymCity="Bhilai",
                    GymLocation="Risali",
                    GymCharge=800,
                    GymImageURL="https://sm.askmen.com/askmen_in/photo/default/nitrrogym_hq78.jpg",
                    GymVideoURL="https://www.youtube.com/embed/gey73xiS8F4",
                    GymContact=6666655555,
                    GameName="Gym"
                },
                new GymPlace()
                {
                    GymId=2,
                    GymName="Fitness 24x7",
                    GymCity="Bhilai",
                    GymLocation="Civic Centre",
                    GymCharge=2000,
                    GymImageURL="https://sm.askmen.com/askmen_in/photo/default/nitrrogym_hq78.jpg",
                    GymVideoURL="https://www.youtube.com/embed/gey73xiS8F4" ,
                    GymContact=6666655555,
                    GameName="Gym"
                },
                new GymPlace()
                {
                    GymId=3,
                    GymName="Steel Club",
                    GymCity="Bhilai",
                    GymLocation="Sector-8",
                    GymCharge=1000,
                    GymImageURL="https://sm.askmen.com/askmen_in/photo/default/nitrrogym_hq78.jpg",
                    GymVideoURL="https://www.youtube.com/embed/gey73xiS8F4" ,
                    GymContact=6666655555,
                    GameName="Gym"
                },
                new GymPlace()
                {
                    GymId=4,
                    GymName="Workout Paradise",
                    GymCity="Durg",
                    GymLocation="Indira Nagar",
                    GymCharge=1200,
                    GymImageURL="https://sm.askmen.com/askmen_in/photo/default/nitrrogym_hq78.jpg",
                    GymVideoURL="https://www.youtube.com/embed/gey73xiS8F4" ,
                    GymContact=6666655555,
                    GameName="Gym"
                },
                new GymPlace()
                {
                    GymId=5,
                    GymName="World Gym-1",
                    GymCity="Bhilai",
                    GymLocation="Ispat Nagar",
                    GymCharge=600,
                    GymImageURL="https://sm.askmen.com/askmen_in/photo/default/nitrrogym_hq78.jpg",
                    GymVideoURL="https://www.youtube.com/embed/gey73xiS8F4" ,
                    GymContact=6666655555,
                    GameName="Gym"
                },
                new GymPlace()
                {
                    GymId=6,
                    GymName="World Gym-2",
                    GymCity="Bhilai",
                    GymLocation="Nehru Nagar",
                    GymCharge=900,
                    GymImageURL="https://sm.askmen.com/askmen_in/photo/default/nitrrogym_hq78.jpg",
                    GymVideoURL="https://www.youtube.com/embed/gey73xiS8F4" ,
                    GymContact=6666655555,
                    GameName="Gym"
                },
                new GymPlace()
                {
                    GymId=7,
                    GymName="Fitness 24x7",
                    GymCity="Raipur",
                    GymLocation="Samta Colony",
                    GymCharge=1000,
                    GymImageURL="https://sm.askmen.com/askmen_in/photo/default/nitrrogym_hq78.jpg",
                    GymVideoURL="https://www.youtube.com/embed/gey73xiS8F4" ,
                    GymContact=6666655555,
                    GameName="Gym"
                },
            };
        }
    }
}
