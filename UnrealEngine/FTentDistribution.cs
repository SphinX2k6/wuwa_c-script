using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011C5 RID: 4549
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/Engine.TentDistribution")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FTentDistribution : IEqualityOperators<FTentDistribution, FTentDistribution, bool>, IEquatable<FTentDistribution>, IUnrealScriptStruct
	{
		// Token: 0x06010C33 RID: 68659 RVA: 0x00189EC2 File Offset: 0x001880C2
		public FTentDistribution(float TipAltitude, float TipValue, float Width)
		{
			this.TipAltitude = TipAltitude;
			this.TipValue = TipValue;
			this.Width = Width;
		}

		// Token: 0x06010C34 RID: 68660 RVA: 0x00189ED9 File Offset: 0x001880D9
		public static bool operator ==(FTentDistribution left, FTentDistribution right)
		{
			return left.TipAltitude == right.TipAltitude && left.TipValue == right.TipValue && left.Width == right.Width;
		}

		// Token: 0x06010C35 RID: 68661 RVA: 0x00189F07 File Offset: 0x00188107
		public static bool operator !=(FTentDistribution left, FTentDistribution right)
		{
			return !(left == right);
		}

		// Token: 0x06010C36 RID: 68662 RVA: 0x00189F13 File Offset: 0x00188113
		public bool Equals(FTentDistribution other)
		{
			return this == other;
		}

		// Token: 0x06010C37 RID: 68663 RVA: 0x00189F24 File Offset: 0x00188124
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FTentDistribution)
			{
				FTentDistribution other = (FTentDistribution)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06010C38 RID: 68664 RVA: 0x00189F49 File Offset: 0x00188149
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float>(this.TipAltitude, this.TipValue, this.Width);
		}

		// Token: 0x06010C39 RID: 68665 RVA: 0x00189F62 File Offset: 0x00188162
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTentDistribution._ScriptStructPtr != 0) ? FTentDistribution._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TentDistribution", ref FTentDistribution._ScriptStructPtr);
		}

		// Token: 0x04008F53 RID: 36691
		[FieldOffset(0)]
		public readonly float TipAltitude;

		// Token: 0x04008F54 RID: 36692
		[FieldOffset(4)]
		public readonly float TipValue;

		// Token: 0x04008F55 RID: 36693
		[FieldOffset(8)]
		public readonly float Width;

		// Token: 0x04008F56 RID: 36694
		public const string __ObjectPath = "/Script/Engine.TentDistribution";

		// Token: 0x04008F57 RID: 36695
		private static IntPtr _ScriptStructPtr;
	}
}
