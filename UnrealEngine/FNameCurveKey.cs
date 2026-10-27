using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EC4 RID: 3780
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/Engine.NameCurveKey")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct FNameCurveKey : IEqualityOperators<FNameCurveKey, FNameCurveKey, bool>, IEquatable<FNameCurveKey>, IUnrealScriptStruct
	{
		// Token: 0x0600CCA9 RID: 52393 RVA: 0x0012A303 File Offset: 0x00128503
		public FNameCurveKey(float Time, FName Value)
		{
			this.Time = Time;
			this.Value = Value;
		}

		// Token: 0x0600CCAA RID: 52394 RVA: 0x0012A313 File Offset: 0x00128513
		public static bool operator ==(FNameCurveKey left, FNameCurveKey right)
		{
			return left.Time == right.Time && left.Value == right.Value;
		}

		// Token: 0x0600CCAB RID: 52395 RVA: 0x0012A336 File Offset: 0x00128536
		public static bool operator !=(FNameCurveKey left, FNameCurveKey right)
		{
			return !(left == right);
		}

		// Token: 0x0600CCAC RID: 52396 RVA: 0x0012A342 File Offset: 0x00128542
		public bool Equals(FNameCurveKey other)
		{
			return this == other;
		}

		// Token: 0x0600CCAD RID: 52397 RVA: 0x0012A350 File Offset: 0x00128550
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FNameCurveKey)
			{
				FNameCurveKey other = (FNameCurveKey)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0600CCAE RID: 52398 RVA: 0x0012A375 File Offset: 0x00128575
		public override int GetHashCode()
		{
			return HashCode.Combine<float, FName>(this.Time, this.Value);
		}

		// Token: 0x0600CCAF RID: 52399 RVA: 0x0012A388 File Offset: 0x00128588
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNameCurveKey._ScriptStructPtr != 0) ? FNameCurveKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NameCurveKey", ref FNameCurveKey._ScriptStructPtr);
		}

		// Token: 0x04006E32 RID: 28210
		[FieldOffset(0)]
		public float Time;

		// Token: 0x04006E33 RID: 28211
		[FieldOffset(4)]
		public FName Value;

		// Token: 0x04006E34 RID: 28212
		public const string __ObjectPath = "/Script/Engine.NameCurveKey";

		// Token: 0x04006E35 RID: 28213
		private static IntPtr _ScriptStructPtr;
	}
}
