using System.Collections.ObjectModel;
using XamarinGuy.Models;

namespace XamarinGuy.ViewModels
{
    public class HumanViewModels
    {
        private ObservableCollection<Human> humans;

        public ObservableCollection<Human> Humans
        {
            get { return humans; }
            set
            {
                humans = value;
            }
        }

        public HumanViewModels()
        {
            Humans = new ObservableCollection<Human>
            {
                new Human
                {
                    HumanID = 1,
                    Name = "Australopithecus",
                    Origin = "5 million"
                },
                new Human
                {
                    HumanID = 2,
                    Origin = "3 million",
                    Name = "Sehelanthropus"
                },
                new Human
                {
                    HumanID = 3,
                    Origin = "2 million",
                    Name = "Homohabits"
                },
                new Human
                {
                    HumanID=4,
                    Origin = "1 million",
                    Name="Homo erectus"
                },
                new Human
                {
                    HumanID=5,
                    Origin="100k Years",
                    Name="Human"
                },
                new Human
                {
                    HumanID = 6,
                    Origin="80k Years",
                    Name = "Human"
                },
                new Human
                {
                    HumanID=7,
                    Origin="Present",
                    Name="HumanCivilization"
                },
                new Human
                {
                    HumanID=8,
                    Origin="5 million",
                    Name="Camel"
                },
                new Human
                {
                    HumanID=9,
                    Origin="4 million",
                    Name="Egret"
                }
            };
        }


    }
}
