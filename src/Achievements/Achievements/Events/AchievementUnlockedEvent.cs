﻿using Achievements.Models;

namespace Achievements.Events
{
    public class AchievementUnlockedEvent
    {
        public string UserId { get; set; }
        public int AchievementId { get; set; }
    }
}