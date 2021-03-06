﻿using DesignCrowd.Models.Enums;
using System;

namespace DesignCrowd.Services.Australia.Factories
{
    public class AustraliaIndividualPublicHolidayFactory : IAustraliaIndividualPublicHolidayFactory
    {
        public IAustraliaIndividualPublicHolidayCreator Create(AustralianState state)
        {
            switch (state)
            {
                case AustralianState.NSW:
                    return new NswPublicHolidayCreator();
                case AustralianState.QLD:
                    return new QldPublicHolidayCreator();
                default:
                    throw new ArgumentOutOfRangeException(nameof(state), state, null);
            }
        }
    }
}
