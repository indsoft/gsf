//*******************************************************************************************************
//  IHeaderCell.cs
//  Copyright © 2009 - TVA, all rights reserved - Gbtc
//
//  Build Environment: C#, Visual Studio 2008
//  Primary Developer: James R Carroll
//      Office: PSO TRAN & REL, CHATTANOOGA - MR BK-C
//       Phone: 423/751-4165
//       Email: jrcarrol@tva.gov
//
//  Code Modification History:
//  -----------------------------------------------------------------------------------------------------
//  04/16/2005 - James R Carroll
//       Generated original version of source code.
//
//*******************************************************************************************************

namespace PCS.PhasorProtocols
{
    /// <summary>
    /// Represents a protocol independent interface representation of any kind of <see cref="IHeaderFrame"/> cell.
    /// </summary>
    public interface IHeaderCell : IChannelCell
    {
        /// <summary>
        /// Gets a reference to the parent <see cref="IHeaderFrame"/> for this <see cref="IHeaderCell"/>.
        /// </summary>
        new IHeaderFrame Parent { get; }

        /// <summary>
        /// Gets or sets ASCII character as a <see cref="Byte"/> of this <see cref="IHeaderCell"/>.
        /// </summary>
        byte Character { get; set; }
    }
}
