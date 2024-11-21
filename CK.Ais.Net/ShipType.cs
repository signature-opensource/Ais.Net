// <copyright file="ShipType.cs" company="Endjin Limited">
// Copyright (c) Endjin Limited. All rights reserved.
// </copyright>

namespace Ais.Net;

/// <summary>
/// Ship types.
/// </summary>
public enum ShipType
{
    NotAvailable = 0,
    Reserved1 = 1,
    Reserved2 = 2,
    Reserved3 = 3,
    Reserved4 = 4,
    Reserved5 = 5,
    Reserved6 = 6,
    Reserved7 = 7,
    Reserved8 = 8,
    Reserved9 = 9,
    Reserved10 = 10,
    Reserved11 = 11,
    Reserved12 = 12,
    Reserved13 = 13,
    Reserved14 = 14,
    Reserved15 = 15,
    Reserved16 = 16,
    Reserved17 = 17,
    Reserved18 = 18,
    Reserved19 = 19,

    WingInGroundAll = 20,
    WingInGroundHazardousCategoryA = 21,
    WingInGroundHazardousCategoryB = 22,
    WingInGroundHazardousCategoryC = 23,
    WingInGroundHazardousCategoryD = 24,
    WingInGroundReserved25 = 25,
    WingInGroundReserved26 = 26,
    WingInGroundReserved27 = 27,
    WingInGroundReserved28 = 28,
    WingInGroundReserved29 = 29,

    Fishing = 30,
    Towing = 31,
    TowingLengthOver200OmrBreadthOver25m = 32,
    DredgingOrUnderwaterOps = 33,
    DivingOps = 34,
    MilitaryOps = 35,
    Sailing = 36,
    PleasureCraft = 37,
    Reserved38 = 38,
    Reserved39 = 39,

    HighSpeedCraftAll = 40,
    HighSpeedCraftHazardousCategoryA = 41,
    HighSpeedCraftHazardousCategoryB = 42,
    HighSpeedCraftHazardousCategoryC = 43,
    HighSpeedCraftHazardousCategoryD = 44,
    HighSpeedCraftReserved45 = 45,
    HighSpeedCraftReserved46 = 46,
    HighSpeedCraftReserved47 = 47,
    HighSpeedCraftReserved48 = 48,
    HighSpeedCraftNoAdditionalInformation = 49,

    PilotVessel = 50,
    SearchAndRescueVessel = 51,
    Tug = 52,
    PortTender = 53,
    AntiPollutionEquipment = 54,
    LawEnforcement = 55,
    SpareLocalVessel56 = 56,
    SpareLocalVessel57 = 57,
    MedicalTransport = 58,
    NoncombatantShip = 59,

    PassengerAll = 60,
    PassengerHazardousCategoryA = 61,
    PassengerHazardousCategoryB = 62,
    PassengerHazardousCategoryC = 63,
    PassengerHazardousCategoryD = 64,
    PassengerReserved65 = 65,
    PassengerReserved66 = 66,
    PassengerReserved67 = 67,
    PassengerReserved68 = 68,
    PassengerNoAdditionalInformation = 69,

    CargoAll = 70,
    CargoHazardousCategoryA = 71,
    CargoHazardousCategoryB = 72,
    CargoHazardousCategoryC = 73,
    CargoHazardousCategoryD = 74,
    CargoReserved75 = 75,
    CargoReserved76 = 76,
    CargoReserved77 = 77,
    CargoReserved78 = 78,
    CargoNoAdditionalInformation = 79,

    TankerAll = 80,
    TankerHazardousCategoryA = 81,
    TankerHazardousCategoryB = 82,
    TankerHazardousCategoryC = 83,
    TankerHazardousCategoryD = 84,
    TankerReserved85 = 85,
    TankerReserved86 = 86,
    TankerReserved87 = 87,
    TankerReserved88 = 88,
    TankerNoAdditionalInformation = 89,

    OtherAll = 90,
    OtherHazardousCategoryA = 91,
    OtherHazardousCategoryB = 92,
    OtherHazardousCategoryC = 93,
    OtherHazardousCategoryD = 94,
    OtherReserved95 = 95,
    OtherReserved96 = 96,
    OtherReserved97 = 97,
    OtherReserved98 = 98,
    OtherNoAdditionalInformation = 99,
}
