// <copyright file="NmeaAisPositionReportClassAParser.cs" company="Endjin Limited">
// Copyright (c) Endjin Limited. All rights reserved.
// </copyright>

using System;

namespace Ais.Net
{
    /// <summary>
    /// Enables fields to be extracted from an AIS Position Report Class A payload in an NMEA
    /// sentence.
    /// It parses the content of messages 1, 2 and 3.
    /// </summary>
    public readonly ref struct NmeaAisPositionReportClassAParser
    {
        readonly NmeaAisBitVectorParser _bits;

        /// <summary>
        /// Create an <see cref="NmeaAisPositionReportClassAParser"/>.
        /// </summary>
        /// <param name="ascii">The ASCII-encoded message payload.</param>
        /// <param name="padding">The number of bits of padding in this payload.</param>
        public NmeaAisPositionReportClassAParser( ReadOnlySpan<byte> ascii, uint padding )
        {
            _bits = new NmeaAisBitVectorParser( ascii, padding );
        }

        /// <summary>
        /// Gets the message type.
        /// </summary>
        public MessageType MessageType => (MessageType)_bits.GetUnsignedInteger( 6, 0 );

        /// <summary>
        /// Gets the number of times this message had been repeated on this broadcast.
        /// </summary>
        /// <remarks>
        /// When stations retransmit messages with a view to enabling them to get around hills and
        /// other obstacles, this should be incremented. When it reaches 3, no more attempts should
        /// be made to retransmit it.
        /// </remarks>
        public uint RepeatIndicator => _bits.GetUnsignedInteger( 2, 6 );

        /// <summary>
        /// Gets the unique identifier assigned to the transponder that sent this message.
        /// </summary>
        public uint Mmsi => _bits.GetUnsignedInteger( 30, 8 );

        /// <summary>
        /// Gets the vessel's navigation status.
        /// </summary>
        public NavigationStatus NavigationStatus => (NavigationStatus)_bits.GetUnsignedInteger( 4, 38 );

        /// <summary>
        /// Gets the vessel's rate of turn.
        /// </summary>
        public int RateOfTurn => _bits.GetSignedInteger( 8, 42 );

        /// <summary>
        /// Gets the vessel's speed over ground, in tenths of a knot.
        /// </summary>
        public uint SpeedOverGroundTenths => _bits.GetUnsignedInteger( 10, 50 );

        /// <summary>
        /// Gets a value indicating whether the position information is of DGPS quality.
        /// </summary>
        /// <remarks>
        /// If <c>true</c>, location information is DGPS-quality (less than 10m). If false, it is
        /// of unaugmented GNSS accuracy.
        /// </remarks>
        public bool PositionAccuracy => _bits.GetBit( 60 );

        /// <summary>
        /// Gets the reported longitude, in units of 1/10000 arc minutes.
        /// </summary>
        public int Longitude10000thMins => _bits.GetSignedInteger( 28, 61 );

        /// <summary>
        /// Gets the reported latitude, in units of 1/10000 arc minutes.
        /// </summary>
        public int Latitude10000thMins => _bits.GetSignedInteger( 27, 89 );

        /// <summary>
        /// Gets the vessel's course over ground in units of one tenth of a degree.
        /// </summary>
        public uint CourseOverGround10thDegrees => _bits.GetUnsignedInteger( 12, 116 );

        /// <summary>
        /// Gets the vessel's heading in degrees.
        /// </summary>
        public uint TrueHeadingDegrees => _bits.GetUnsignedInteger( 9, 128 );

        /// <summary>
        /// Gets the seconds part of the (UTC) time at which the location was recorded.
        /// </summary>
        public uint TimeStampSecond => _bits.GetUnsignedInteger( 6, 137 );

        /// <summary>
        /// Gets a value indicating which kind of manoeuvre the vessel is engaged in, if any.
        /// </summary>
        public ManoeuvreIndicator ManoeuvreIndicator => (ManoeuvreIndicator)_bits.GetUnsignedInteger( 2, 143 );

        /// <summary>
        /// Gets the value of the bits in this message for which no standard meaning is currently
        /// defined.
        /// </summary>
        public uint SpareBits145 => _bits.GetUnsignedInteger( 3, 145 );

        /// <summary>
        /// Gets a value indicating whether Receiver Autonomous Integrity Monitoring is in use.
        /// </summary>
        public bool RaimFlag => _bits.GetBit( 148 );

        /// <summary>
        /// Gets a value indicating the time synchronization mechanism in use by the radio system.
        /// </summary>
        public RadioSyncState RadioSyncState => (RadioSyncState)_bits.GetUnsignedInteger( 2, 149 );

        /// <summary>
        /// Gets a value indicating how many more frames are to be sent before the radio system
        /// will need to select a new slot.
        /// </summary>
        public uint RadioSlotTimeout => _bits.GetUnsignedInteger( 3, 151 );

        /// <summary>
        /// Gets information from the radio diagnostic system, the interpretation of which is
        /// determined by the value of <see cref="RadioSlotTimeout"/>.
        /// </summary>
        public uint RadioSubMessage => _bits.GetUnsignedInteger( 14, 154 );
    }
}
