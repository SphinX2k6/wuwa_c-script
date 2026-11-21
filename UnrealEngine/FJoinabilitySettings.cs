using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000128 RID: 296
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 24)]
	[UnrealObjectPath("/Script/CoreUObject.JoinabilitySettings")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 24)]
	public struct FJoinabilitySettings : IEqualityOperators<FJoinabilitySettings, FJoinabilitySettings, bool>, IEquatable<FJoinabilitySettings>, IUnrealScriptStruct
	{
		// Token: 0x0600121B RID: 4635 RVA: 0x0001CA06 File Offset: 0x0001AC06
		public FJoinabilitySettings(FName SessionName, bool bPublicSearchable, bool bAllowInvites, bool bJoinViaPresence, bool bJoinViaPresenceFriendsOnly, int MaxPlayers, int MaxPartySize)
		{
			this.SessionName = SessionName;
			this.bPublicSearchable = bPublicSearchable;
			this.bAllowInvites = bAllowInvites;
			this.bJoinViaPresence = bJoinViaPresence;
			this.bJoinViaPresenceFriendsOnly = bJoinViaPresenceFriendsOnly;
			this.MaxPlayers = MaxPlayers;
			this.MaxPartySize = MaxPartySize;
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x0001CA40 File Offset: 0x0001AC40
		public static bool operator ==(FJoinabilitySettings left, FJoinabilitySettings right)
		{
			return left.SessionName == right.SessionName && left.bPublicSearchable == right.bPublicSearchable && left.bAllowInvites == right.bAllowInvites && left.bJoinViaPresence == right.bJoinViaPresence && left.bJoinViaPresenceFriendsOnly == right.bJoinViaPresenceFriendsOnly && left.MaxPlayers == right.MaxPlayers && left.MaxPartySize == right.MaxPartySize;
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x0001CAB6 File Offset: 0x0001ACB6
		public static bool operator !=(FJoinabilitySettings left, FJoinabilitySettings right)
		{
			return !(left == right);
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x0001CAC2 File Offset: 0x0001ACC2
		public bool Equals(FJoinabilitySettings other)
		{
			return this == other;
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x0001CAD0 File Offset: 0x0001ACD0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FJoinabilitySettings)
			{
				FJoinabilitySettings other = (FJoinabilitySettings)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x0001CAF5 File Offset: 0x0001ACF5
		public override int GetHashCode()
		{
			return HashCode.Combine<FName, bool, bool, bool, bool, int, int>(this.SessionName, this.bPublicSearchable, this.bAllowInvites, this.bJoinViaPresence, this.bJoinViaPresenceFriendsOnly, this.MaxPlayers, this.MaxPartySize);
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x0001CB26 File Offset: 0x0001AD26
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FJoinabilitySettings._ScriptStructPtr != 0) ? FJoinabilitySettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.JoinabilitySettings", ref FJoinabilitySettings._ScriptStructPtr);
		}

		// Token: 0x0400056D RID: 1389
		[FieldOffset(0)]
		public FName SessionName;

		// Token: 0x0400056E RID: 1390
		[FieldOffset(12)]
		public bool bPublicSearchable;

		// Token: 0x0400056F RID: 1391
		[FieldOffset(13)]
		public bool bAllowInvites;

		// Token: 0x04000570 RID: 1392
		[FieldOffset(14)]
		public bool bJoinViaPresence;

		// Token: 0x04000571 RID: 1393
		[FieldOffset(15)]
		public bool bJoinViaPresenceFriendsOnly;

		// Token: 0x04000572 RID: 1394
		[FieldOffset(16)]
		public int MaxPlayers;

		// Token: 0x04000573 RID: 1395
		[FieldOffset(20)]
		public int MaxPartySize;

		// Token: 0x04000574 RID: 1396
		public const string __ObjectPath = "/Script/CoreUObject.JoinabilitySettings";

		// Token: 0x04000575 RID: 1397
		private static IntPtr _ScriptStructPtr;
	}
}
