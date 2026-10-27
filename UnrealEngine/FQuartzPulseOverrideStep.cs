using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200105B RID: 4187
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/Engine.QuartzPulseOverrideStep")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FQuartzPulseOverrideStep : IEqualityOperators<FQuartzPulseOverrideStep, FQuartzPulseOverrideStep, bool>, IEquatable<FQuartzPulseOverrideStep>, IUnrealScriptStruct
	{
		// Token: 0x0600EE2E RID: 60974 RVA: 0x001616D7 File Offset: 0x0015F8D7
		public FQuartzPulseOverrideStep(int NumberOfPulses, EQuartzCommandQuantization PulseDuration)
		{
			this.NumberOfPulses = NumberOfPulses;
			this.PulseDuration = PulseDuration;
		}

		// Token: 0x0600EE2F RID: 60975 RVA: 0x001616E7 File Offset: 0x0015F8E7
		public static bool operator ==(FQuartzPulseOverrideStep left, FQuartzPulseOverrideStep right)
		{
			return left.NumberOfPulses == right.NumberOfPulses && left.PulseDuration == right.PulseDuration;
		}

		// Token: 0x0600EE30 RID: 60976 RVA: 0x00161707 File Offset: 0x0015F907
		public static bool operator !=(FQuartzPulseOverrideStep left, FQuartzPulseOverrideStep right)
		{
			return !(left == right);
		}

		// Token: 0x0600EE31 RID: 60977 RVA: 0x00161713 File Offset: 0x0015F913
		public bool Equals(FQuartzPulseOverrideStep other)
		{
			return this == other;
		}

		// Token: 0x0600EE32 RID: 60978 RVA: 0x00161724 File Offset: 0x0015F924
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FQuartzPulseOverrideStep)
			{
				FQuartzPulseOverrideStep other = (FQuartzPulseOverrideStep)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0600EE33 RID: 60979 RVA: 0x00161749 File Offset: 0x0015F949
		public override int GetHashCode()
		{
			return HashCode.Combine<int, EQuartzCommandQuantization>(this.NumberOfPulses, this.PulseDuration);
		}

		// Token: 0x0600EE34 RID: 60980 RVA: 0x0016175C File Offset: 0x0015F95C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FQuartzPulseOverrideStep._ScriptStructPtr != 0) ? FQuartzPulseOverrideStep._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.QuartzPulseOverrideStep", ref FQuartzPulseOverrideStep._ScriptStructPtr);
		}

		// Token: 0x040080F5 RID: 33013
		[FieldOffset(0)]
		public int NumberOfPulses;

		// Token: 0x040080F6 RID: 33014
		[FieldOffset(4)]
		public EQuartzCommandQuantization PulseDuration;

		// Token: 0x040080F7 RID: 33015
		public const string __ObjectPath = "/Script/Engine.QuartzPulseOverrideStep";

		// Token: 0x040080F8 RID: 33016
		private static IntPtr _ScriptStructPtr;
	}
}
