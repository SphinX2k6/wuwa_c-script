using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000116 RID: 278
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/CoreUObject.Int32RangeBound")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FInt32RangeBound : IEqualityOperators<FInt32RangeBound, FInt32RangeBound, bool>, IEquatable<FInt32RangeBound>, IUnrealScriptStruct
	{
		// Token: 0x0600117A RID: 4474 RVA: 0x0001BAB8 File Offset: 0x00019CB8
		public FInt32RangeBound(TEnumAsByte<ERangeBoundTypes> Type, int Value)
		{
			this.Type = Type;
			this.Value = Value;
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x0001BAC8 File Offset: 0x00019CC8
		public static bool operator ==(FInt32RangeBound left, FInt32RangeBound right)
		{
			return left.Type == right.Type && left.Value == right.Value;
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x0001BAED File Offset: 0x00019CED
		public static bool operator !=(FInt32RangeBound left, FInt32RangeBound right)
		{
			return !(left == right);
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x0001BAF9 File Offset: 0x00019CF9
		public bool Equals(FInt32RangeBound other)
		{
			return this == other;
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x0001BB08 File Offset: 0x00019D08
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FInt32RangeBound)
			{
				FInt32RangeBound other = (FInt32RangeBound)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x0001BB2D File Offset: 0x00019D2D
		public override int GetHashCode()
		{
			return HashCode.Combine<TEnumAsByte<ERangeBoundTypes>, int>(this.Type, this.Value);
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x0001BB40 File Offset: 0x00019D40
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInt32RangeBound._ScriptStructPtr != 0) ? FInt32RangeBound._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Int32RangeBound", ref FInt32RangeBound._ScriptStructPtr);
		}

		// Token: 0x0400050C RID: 1292
		[FieldOffset(0)]
		public TEnumAsByte<ERangeBoundTypes> Type;

		// Token: 0x0400050D RID: 1293
		[FieldOffset(4)]
		public int Value;

		// Token: 0x0400050E RID: 1294
		public const string __ObjectPath = "/Script/CoreUObject.Int32RangeBound";

		// Token: 0x0400050F RID: 1295
		private static IntPtr _ScriptStructPtr;
	}
}
