using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200010C RID: 268
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/CoreUObject.FloatRangeBound")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FFloatRangeBound : IEqualityOperators<FFloatRangeBound, FFloatRangeBound, bool>, IEquatable<FFloatRangeBound>, IUnrealScriptStruct
	{
		// Token: 0x0600112C RID: 4396 RVA: 0x0001B3B4 File Offset: 0x000195B4
		public FFloatRangeBound(TEnumAsByte<ERangeBoundTypes> Type, float Value)
		{
			this.Type = Type;
			this.Value = Value;
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x0001B3C4 File Offset: 0x000195C4
		public static bool operator ==(FFloatRangeBound left, FFloatRangeBound right)
		{
			return left.Type == right.Type && left.Value == right.Value;
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x0001B3E9 File Offset: 0x000195E9
		public static bool operator !=(FFloatRangeBound left, FFloatRangeBound right)
		{
			return !(left == right);
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x0001B3F5 File Offset: 0x000195F5
		public bool Equals(FFloatRangeBound other)
		{
			return this == other;
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x0001B404 File Offset: 0x00019604
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

		// Token: 0x06001131 RID: 4401 RVA: 0x0001B429 File Offset: 0x00019629
		public override int GetHashCode()
		{
			return HashCode.Combine<TEnumAsByte<ERangeBoundTypes>, float>(this.Type, this.Value);
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x0001B43C File Offset: 0x0001963C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFloatRangeBound._ScriptStructPtr != 0) ? FFloatRangeBound._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.FloatRangeBound", ref FFloatRangeBound._ScriptStructPtr);
		}

		// Token: 0x040004E4 RID: 1252
		[FieldOffset(0)]
		public TEnumAsByte<ERangeBoundTypes> Type;

		// Token: 0x040004E5 RID: 1253
		[FieldOffset(4)]
		public float Value;

		// Token: 0x040004E6 RID: 1254
		public const string __ObjectPath = "/Script/CoreUObject.FloatRangeBound";

		// Token: 0x040004E7 RID: 1255
		private static IntPtr _ScriptStructPtr;
	}
}
