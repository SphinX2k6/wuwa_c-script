using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000730 RID: 1840
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/CoreUObject.Int32RangeBound")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FInt32RangeBound : IEqualityOperators<FInt32RangeBound, FInt32RangeBound, bool>, IEquatable<FInt32RangeBound>, IUnrealScriptStruct
	{
		// Token: 0x06006217 RID: 25111 RVA: 0x0008CA64 File Offset: 0x0008AC64
		public FInt32RangeBound(TEnumAsByte<ERangeBoundTypes> Type, int Value)
		{
			this.Type = Type;
			this.Value = Value;
		}

		// Token: 0x06006218 RID: 25112 RVA: 0x0008CA74 File Offset: 0x0008AC74
		public static bool operator ==(FInt32RangeBound left, FInt32RangeBound right)
		{
			return left.Type == right.Type && left.Value == right.Value;
		}

		// Token: 0x06006219 RID: 25113 RVA: 0x0008CA99 File Offset: 0x0008AC99
		public static bool operator !=(FInt32RangeBound left, FInt32RangeBound right)
		{
			return !(left == right);
		}

		// Token: 0x0600621A RID: 25114 RVA: 0x0008CAA5 File Offset: 0x0008ACA5
		public bool Equals(FInt32RangeBound other)
		{
			return this == other;
		}

		// Token: 0x0600621B RID: 25115 RVA: 0x0008CAB4 File Offset: 0x0008ACB4
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

		// Token: 0x0600621C RID: 25116 RVA: 0x0008CAD9 File Offset: 0x0008ACD9
		public override int GetHashCode()
		{
			return HashCode.Combine<TEnumAsByte<ERangeBoundTypes>, int>(this.Type, this.Value);
		}

		// Token: 0x0600621D RID: 25117 RVA: 0x0008CAEC File Offset: 0x0008ACEC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInt32RangeBound._ScriptStructPtr != 0) ? FInt32RangeBound._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Int32RangeBound", ref FInt32RangeBound._ScriptStructPtr);
		}

		// Token: 0x04002ED6 RID: 11990
		[FieldOffset(0)]
		public TEnumAsByte<ERangeBoundTypes> Type;

		// Token: 0x04002ED7 RID: 11991
		[FieldOffset(4)]
		public int Value;

		// Token: 0x04002ED8 RID: 11992
		public const string __ObjectPath = "/Script/CoreUObject.Int32RangeBound";

		// Token: 0x04002ED9 RID: 11993
		private static IntPtr _ScriptStructPtr;
	}
}
