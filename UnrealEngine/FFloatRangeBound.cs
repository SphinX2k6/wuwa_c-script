using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000726 RID: 1830
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/CoreUObject.FloatRangeBound")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FFloatRangeBound : IEqualityOperators<FFloatRangeBound, FFloatRangeBound, bool>, IEquatable<FFloatRangeBound>, IUnrealScriptStruct
	{
		// Token: 0x060061C5 RID: 25029 RVA: 0x0008C318 File Offset: 0x0008A518
		public FFloatRangeBound(TEnumAsByte<ERangeBoundTypes> Type, float Value)
		{
			this.Type = Type;
			this.Value = Value;
		}

		// Token: 0x060061C6 RID: 25030 RVA: 0x0008C328 File Offset: 0x0008A528
		public static bool operator ==(FFloatRangeBound left, FFloatRangeBound right)
		{
			return left.Type == right.Type && left.Value == right.Value;
		}

		// Token: 0x060061C7 RID: 25031 RVA: 0x0008C34D File Offset: 0x0008A54D
		public static bool operator !=(FFloatRangeBound left, FFloatRangeBound right)
		{
			return !(left == right);
		}

		// Token: 0x060061C8 RID: 25032 RVA: 0x0008C359 File Offset: 0x0008A559
		public bool Equals(FFloatRangeBound other)
		{
			return this == other;
		}

		// Token: 0x060061C9 RID: 25033 RVA: 0x0008C368 File Offset: 0x0008A568
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FFloatRangeBound)
			{
				FFloatRangeBound other = (FFloatRangeBound)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060061CA RID: 25034 RVA: 0x0008C38D File Offset: 0x0008A58D
		public override int GetHashCode()
		{
			return HashCode.Combine<TEnumAsByte<ERangeBoundTypes>, float>(this.Type, this.Value);
		}

		// Token: 0x060061CB RID: 25035 RVA: 0x0008C3A0 File Offset: 0x0008A5A0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFloatRangeBound._ScriptStructPtr != 0) ? FFloatRangeBound._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.FloatRangeBound", ref FFloatRangeBound._ScriptStructPtr);
		}

		// Token: 0x04002EAE RID: 11950
		[FieldOffset(0)]
		public TEnumAsByte<ERangeBoundTypes> Type;

		// Token: 0x04002EAF RID: 11951
		[FieldOffset(4)]
		public float Value;

		// Token: 0x04002EB0 RID: 11952
		public const string __ObjectPath = "/Script/CoreUObject.FloatRangeBound";

		// Token: 0x04002EB1 RID: 11953
		private static IntPtr _ScriptStructPtr;
	}
}
