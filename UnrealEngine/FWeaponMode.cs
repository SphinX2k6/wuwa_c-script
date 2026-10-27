using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002932 RID: 10546
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(3, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 3)]
	[UnrealObjectPath("/Script/TriggerEffect.WeaponMode")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 3)]
	public struct FWeaponMode : IEqualityOperators<FWeaponMode, FWeaponMode, bool>, IEquatable<FWeaponMode>, IUnrealScriptStruct
	{
		// Token: 0x06027039 RID: 159801 RVA: 0x003B82AA File Offset: 0x003B64AA
		public FWeaponMode(byte StartPosition, byte EndPosition, byte Strength)
		{
			this.StartPosition = StartPosition;
			this.EndPosition = EndPosition;
			this.Strength = Strength;
		}

		// Token: 0x0602703A RID: 159802 RVA: 0x003B82C1 File Offset: 0x003B64C1
		public static bool operator ==(FWeaponMode left, FWeaponMode right)
		{
			return left.StartPosition == right.StartPosition && left.EndPosition == right.EndPosition && left.Strength == right.Strength;
		}

		// Token: 0x0602703B RID: 159803 RVA: 0x003B82EF File Offset: 0x003B64EF
		public static bool operator !=(FWeaponMode left, FWeaponMode right)
		{
			return !(left == right);
		}

		// Token: 0x0602703C RID: 159804 RVA: 0x003B82FB File Offset: 0x003B64FB
		public bool Equals(FWeaponMode other)
		{
			return this == other;
		}

		// Token: 0x0602703D RID: 159805 RVA: 0x003B830C File Offset: 0x003B650C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FWeaponMode)
			{
				FWeaponMode other = (FWeaponMode)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602703E RID: 159806 RVA: 0x003B8331 File Offset: 0x003B6531
		public override int GetHashCode()
		{
			return HashCode.Combine<byte, byte, byte>(this.StartPosition, this.EndPosition, this.Strength);
		}

		// Token: 0x0602703F RID: 159807 RVA: 0x003B834A File Offset: 0x003B654A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWeaponMode._ScriptStructPtr != 0) ? FWeaponMode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TriggerEffect.WeaponMode", ref FWeaponMode._ScriptStructPtr);
		}

		// Token: 0x04015704 RID: 87812
		[FieldOffset(0)]
		public byte StartPosition;

		// Token: 0x04015705 RID: 87813
		[FieldOffset(1)]
		public byte EndPosition;

		// Token: 0x04015706 RID: 87814
		[FieldOffset(2)]
		public byte Strength;

		// Token: 0x04015707 RID: 87815
		public const string __ObjectPath = "/Script/TriggerEffect.WeaponMode";

		// Token: 0x04015708 RID: 87816
		private static IntPtr _ScriptStructPtr;
	}
}
