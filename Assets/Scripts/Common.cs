using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class SyndicateCommon
{

    [Serializable]
    public class BetrayerMaster
    {
        public string kr { get; set; }
        public string en { get; set; }
        public string valuable { get; set; }
        public string T { get; set; }
        public string F { get; set; }
        public string R { get; set; }
        public string I { get; set; }
        public string TReward { get; set; }
        public string FReward { get; set; }
        public string RReward { get; set; }
        public string IReward { get; set; }
        public string TV { get; set; }
        public string FV { get; set; }
        public string RV { get; set; }
        public string IV { get; set; }
    }

    [Serializable]
    public class MasterRoot
    {
        public List<BetrayerMaster> BetrayerMaster { get; set; }
    }
}
