﻿using System.Diagnostics;
using System.Text;
using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;

namespace WaFFL.Evaluation
{
    /// <summary />
    [DebuggerDisplay("{PlayerData}")]
    public abstract class Item : ViewModelBase
    {
        /// <summary />
        public Item(NFLPlayer p)
        {
            this.PlayerData = p;

            Messenger.Default.Register<MarkedPlayerChanged>(this,
                (m) =>
                {
                    if (m.Name == this.PlayerData.Name)
                    {
                        this.RaisePropertyChanged("IsHighlighted");
                    }
                });
        }

        /// <summary />
        public NFLPlayer PlayerData { get; private set; }

        /// <summary />
        public bool IsAvailable
        {
            get { return WaFFLRoster.IsActive(this.PlayerData.Name); }
        }

        /// <summary />
        public bool IsHighlighted
        {
            get { return MarkedPlayers.IsMarked(this.PlayerData.Name); }
        }

        /// <summary />
        public string Name
        {
            get { return this.PlayerData.Name; }
        }

        public string Position
        {
            get
            {
                FanastyPosition position = this.PlayerData.Position;
                if (position != FanastyPosition.UNKNOWN)
                {
                    return position.ToString();
                }

                return "n/a";
            }
        }

        /// <summary />
        public string Team
        {
            get
            {
                NFLTeam team = this.PlayerData.Team;
                if (team != null)
                {
                    return team.TeamCode;
                }

                return "n/a";
            }
        }

        private string GetScoreForWeek(int week)
        {
            foreach (Game g in this.PlayerData.GameLog)
            {
                if (g.Week == week)
                {
                    return g.GetFanastyPoints().ToString();
                }
            }

            return string.Empty;
        }

        private int GetScoreForWeekSortable(int week)
        {
            foreach (Game g in this.PlayerData.GameLog)
            {
                if (g.Week == week)
                {
                    return g.GetFanastyPoints();
                }
            }

            return 0;
        }

        public string Week1Score
        {
            get { return GetScoreForWeek(1); }
        }

        public int Week1ScoreSortable
        {
            get { return GetScoreForWeekSortable(1); }
        }

        public string Week2Score
        {
            get { return GetScoreForWeek(2); }
        }

        public int Week2ScoreSortable
        {
            get { return GetScoreForWeekSortable(2); }
        }

        public string Week3Score
        {
            get { return GetScoreForWeek(3); }
        }

        public int Week3ScoreSortable
        {
            get { return GetScoreForWeekSortable(3); }
        }

        public string Week4Score
        {
            get { return GetScoreForWeek(4); }
        }

        public int Week4ScoreSortable
        {
            get { return GetScoreForWeekSortable(4); }
        }

        public string Week5Score
        {
            get { return GetScoreForWeek(5); }
        }

        public int Week5ScoreSortable
        {
            get { return GetScoreForWeekSortable(5); }
        }

        public string Week6Score
        {
            get { return GetScoreForWeek(6); }
        }

        public int Week6ScoreSortable
        {
            get { return GetScoreForWeekSortable(6); }
        }

        public string Week7Score
        {
            get { return GetScoreForWeek(7); }
        }

        public int Week7ScoreSortable
        {
            get { return GetScoreForWeekSortable(7); }
        }

        public string Week8Score
        {
            get { return GetScoreForWeek(8); }
        }

        public int Week8ScoreSortable
        {
            get { return GetScoreForWeekSortable(8); }
        }

        public string Week9Score
        {
            get { return GetScoreForWeek(9); }
        }

        public int Week9ScoreSortable
        {
            get { return GetScoreForWeekSortable(9); }
        }

        public string Week10Score
        {
            get { return GetScoreForWeek(10); }
        }

        public int Week10ScoreSortable
        {
            get { return GetScoreForWeekSortable(10); }
        }

        public string Week11Score
        {
            get { return GetScoreForWeek(11); }
        }

        public int Week11ScoreSortable
        {
            get { return GetScoreForWeekSortable(11); }
        }

        public string Week12Score
        {
            get { return GetScoreForWeek(12); }
        }

        public int Week12ScoreSortable
        {
            get { return GetScoreForWeekSortable(12); }
        }

        public string Week13Score
        {
            get { return GetScoreForWeek(13); }
        }

        public int Week13ScoreSortable
        {
            get { return GetScoreForWeekSortable(13); }
        }

        public string Week14Score
        {
            get { return GetScoreForWeek(14); }
        }

        public int Week14ScoreSortable
        {
            get { return GetScoreForWeekSortable(14); }
        }

        public string Week15Score
        {
            get { return GetScoreForWeek(15); }
        }

        public int Week15ScoreSortable
        {
            get { return GetScoreForWeekSortable(15); }
        }

        public string Week16Score
        {
            get { return GetScoreForWeek(16); }
        }

        public int Week16ScoreSortable
        {
            get { return GetScoreForWeekSortable(16); }
        }

        public string Week17Score
        {
            get { return GetScoreForWeek(17); }
        }

        public int Week17ScoreSortable
        {
            get { return GetScoreForWeekSortable(17); }
        }
    }
}
