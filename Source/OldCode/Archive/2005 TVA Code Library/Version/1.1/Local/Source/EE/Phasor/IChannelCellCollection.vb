'*******************************************************************************************************
'  IChannelCellCollection.vb - Channel cell collection interface
'  Copyright � 2005 - TVA, all rights reserved - Gbtc
'
'  Build Environment: VB.NET, Visual Studio 2003
'  Primary Developer: James R Carroll, System Analyst [TVA]
'      Office: COO - TRNS/PWR ELEC SYS O, CHATTANOOGA, TN - MR 2W-C
'       Phone: 423/751-2827
'       Email: jrcarrol@tva.gov
'
'  Code Modification History:
'  -----------------------------------------------------------------------------------------------------
'  02/18/2005 - James R Carroll
'       Initial version of source generated
'
'*******************************************************************************************************

Namespace EE.Phasor

    ' This interface represents a protocol independent representation of a collection of any kind of data cell.

    Public Interface IChannelCellCollection

        Inherits IChannelCollection

        Shadows Sub Add(ByVal value As IChannelCell)

        Default Shadows ReadOnly Property Item(ByVal index As Integer) As IChannelCell

    End Interface

End Namespace