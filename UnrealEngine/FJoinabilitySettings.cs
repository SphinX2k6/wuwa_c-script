using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000742 RID: 1858
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 24)]
	[UnrealObjectPath("/Script/CoreUObject.JoinabilitySettings")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 24)]
	public struct FJoinabilitySettings : IEqualityOperators<FJoinabilitySettings, FJoinabilitySettings, bool>, IEquatable<FJoinabilitySettings>, IUnrealScriptStruct
	{
		// Token: 0x060062BF RID: 25279 RVA: 0x0008DA86 File Offset: 0x0008BC86
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

		// Token: 0x060062C0 RID: 25280 RVA: 0x0008DAC0 File Offset: 0x0008BCC0
		public static bool operator ==(FJoinabilitySettings left, FJoinabilitySettings right)
		{
			return left.SessionName == right.SessionName && left.bPublicSearchable == right.bPublicSearchable && left.bAllowInvites == right.bAllowInvites && left.bJoinViaPresence == right.bJoinViaPresence && left.bJoinViaPresenceFriendsOnly == right.bJoinViaPresenceFriendsOnly && left.MaxPlayers == right.MaxPlayers && left.MaxPartySize == right.MaxPartySize;
		}

		// Token: 0x060062C1 RID: 25281 RVA: 0x0008DB36 File Offset: 0x0008BD36
		public static bool operator !=(FJoinabilitySettings left, FJoinabilitySettings right)
		{
			return !(left == right);
		}

		// Token: 0x060062C2 RID: 25282 RVA: 0x0008DB42 File Offset: 0x0008BD42
		public bool Equals(FJoinabilitySettings other)
		{
			return this == other;
		}

		// Token: 0x060062C3 RID: 25283 RVA: 0x0008DB50 File Offset: 0x0008BD50
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

		// Token: 0x060062C4 RID: 25284 RVA: 0x0008DB75 File Offset: 0x0008BD75
		public override int GetHashCode()
		{
			return HashCode.Combine<FName, bool, bool, bool, bool, int, int>(this.SessionName, this.bPublicSearchable, this.bAllowInvites, this.bJoinViaPresence, this.bJoinViaPresenceFriendsOnly, this.MaxPlayers, this.MaxPartySize);
		}

		// Token: 0x060062C5 RID: 25285 RVA: 0x0008DBA6 File Offset: 0x0008BDA6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FJoinabilitySettings._ScriptStructPtr != 0) ? FJoinabilitySettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.JoinabilitySettings", ref FJoinabilitySettings._ScriptStructPtr);
		}

		// Token: 0x04002F37 RID: 12087
		[FieldOffset(0)]
		public FName SessionName;

		// Token: 0x04002F38 RID: 12088
		[FieldOffset(12)]
		public bool bPublicSearchable;

		// Token: 0x04002F39 RID: 12089
		[FieldOffset(13)]
		public bool bAllowInvites;

		// Token: 0x04002F3A RID: 12090
		[FieldOffset(14)]
		public bool bJoinViaPresence;

		// Token: 0x04002F3B RID: 12091
		[FieldOffset(15)]
		public bool bJoinViaPresenceFriendsOnly;

		// Token: 0x04002F3C RID: 12092
		[FieldOffset(16)]
		public int MaxPlayers;

		// Token: 0x04002F3D RID: 12093
		[FieldOffset(20)]
		public int MaxPartySize;

		// Token: 0x04002F3E RID: 12094
		public const string __ObjectPath = "/Script/CoreUObject.JoinabilitySettings";

		// Token: 0x04002F3F RID: 12095
		private static IntPtr _ScriptStructPtr;
	}
}
