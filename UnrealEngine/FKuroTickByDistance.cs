using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200251B RID: 9499
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/Niagara.KuroTickByDistance")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FKuroTickByDistance : IEqualityOperators<FKuroTickByDistance, FKuroTickByDistance, bool>, IEquatable<FKuroTickByDistance>, IUnrealScriptStruct
	{
		// Token: 0x060234B8 RID: 144568 RVA: 0x00343396 File Offset: 0x00341596
		public FKuroTickByDistance(float Distance, float TickInterval)
		{
			this.Distance = Distance;
			this.TickInterval = TickInterval;
		}

		// Token: 0x060234B9 RID: 144569 RVA: 0x003433A6 File Offset: 0x003415A6
		public static bool operator ==(FKuroTickByDistance left, FKuroTickByDistance right)
		{
			return left.Distance == right.Distance && left.TickInterval == right.TickInterval;
		}

		// Token: 0x060234BA RID: 144570 RVA: 0x003433C6 File Offset: 0x003415C6
		public static bool operator !=(FKuroTickByDistance left, FKuroTickByDistance right)
		{
			return !(left == right);
		}

		// Token: 0x060234BB RID: 144571 RVA: 0x003433D2 File Offset: 0x003415D2
		public bool Equals(FKuroTickByDistance other)
		{
			return this == other;
		}

		// Token: 0x060234BC RID: 144572 RVA: 0x003433E0 File Offset: 0x003415E0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FKuroTickByDistance)
			{
				FKuroTickByDistance other = (FKuroTickByDistance)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060234BD RID: 144573 RVA: 0x00343405 File Offset: 0x00341605
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float>(this.Distance, this.TickInterval);
		}

		// Token: 0x060234BE RID: 144574 RVA: 0x00343418 File Offset: 0x00341618
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroTickByDistance._ScriptStructPtr != 0) ? FKuroTickByDistance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.KuroTickByDistance", ref FKuroTickByDistance._ScriptStructPtr);
		}

		// Token: 0x04012F2A RID: 77610
		[FieldOffset(0)]
		public float Distance;

		// Token: 0x04012F2B RID: 77611
		[FieldOffset(4)]
		public float TickInterval;

		// Token: 0x04012F2C RID: 77612
		public const string __ObjectPath = "/Script/Niagara.KuroTickByDistance";

		// Token: 0x04012F2D RID: 77613
		private static IntPtr _ScriptStructPtr;
	}
}
