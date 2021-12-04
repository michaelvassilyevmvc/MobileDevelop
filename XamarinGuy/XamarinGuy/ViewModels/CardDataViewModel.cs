using System.Collections.Generic;
using System.Collections.ObjectModel;
using XamarinGuy.Models;

namespace XamarinGuy.ViewModels
{
    public class CardDataViewModel
    {
        public IList<CardDataModel> CardDataCollection { get; set; }

        public object SelectedItem { get; set; }
        public CardDataViewModel()
        {
            CardDataCollection = new List<CardDataModel>();
            GenerateCardModel();
        }

        private void GenerateCardModel()
        {
            CardDataCollection = new ObservableCollection<CardDataModel>
            {
                new CardDataModel
                {
                    HeadTitle = " 1 day ago  - FaceBook",
                    HeadLines="Samsung SM-T3855 with Adroid 7.0 gets WIFI certified - GSM Arena News",
                    ProfileImage = "https://advancelocal-adapter-image-uploads.s3.amazonaws.com/image.lehighvalleylive.com/home/lvlive-media/width2048/img/entertainment_impact/photo/20769691-standard.jpg",
                    HeadLinesDesc = "Facebook is a social networking service launched on February"
                }, 
                new CardDataModel
                {
                    HeadTitle=" 9 hrs ago   - The Indipendent",
                    HeadLines = "Game Of Thrones season 7 : Fans think Catelyn's Stark's Ghost was",
                    HeadLinesDesc = "The Independent is a British online newspaper. small sample based",
                    ProfileImage = "https://www.howfamous.is/celebrity/chris-hemsworth/200/220.jpg?lang=en"
                },
                new CardDataModel
                {
                    HeadTitle = "16 hrs ago -  MacRumors",
                    HeadLinesDesc = "MacRumors.com is a website that aggregates Mac and Apple related news",
                    HeadLines = "Set it and forget it: 5 Things you should always automate on your phone",
                    ProfileImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTGTl5sRHiZTJyOSvhmX3ZHs23BiWlR6t-QyQ&usqp=CAU"
                },
                new CardDataModel
                {
                    HeadTitle = " 19 hrs ago - Android Authority",
                    HeadLinesDesc = "MacRumors.com is a website that aggregates Mac and Apple .... small sample ",
                    HeadLines = "Set it and forget it : 5 Things you should always automate on your phone",
                    ProfileImage = "https://cdn.thetealmango.com/wp-content/uploads/2021/08/Robert.jpg"
                }
            };
        }
    }
}
