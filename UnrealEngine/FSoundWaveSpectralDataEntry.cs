using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200115F RID: 4447
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/Engine.SoundWaveSpectralDataEntry")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FSoundWaveSpectralDataEntry : IEqualityOperators<FSoundWaveSpectralDataEntry, FSoundWaveSpectralDataEntry, bool>, IEquatable<FSoundWaveSpectralDataEntry>, IUnrealScriptStruct
	{
		// Token: 0x06010411 RID: 66577 RVA: 0x0017F22E File Offset: 0x0017D42E
		public FSoundWaveSpectralDataEntry(float Magnitude, float NormalizedMagnitude)
		{
			this.Magnitude = Magnitude;
			this.NormalizedMagnitude = NormalizedMagnitude;
		}

		// Token: 0x06010412 RID: 66578 RVA: 0x0017F23E File Offset: 0x0017D43E
		public static bool operator ==(FSoundWaveSpectralDataEntry left, FSoundWaveSpectralDataEntry right)
		{
			return left.Magnitude == right.Magnitude && left.NormalizedMagnitude == right.NormalizedMagnitude;
		}

		// Token: 0x06010413 RID: 66579 RVA: 0x0017F25E File Offset: 0x0017D45E
		public static bool operator !=(FSoundWaveSpectralDataEntry left, FSoundWaveSpectralDataEntry right)
		{
			return !(left == right);
		}

		// Token: 0x06010414 RID: 66580 RVA: 0x0017F26A File Offset: 0x0017D46A
		public bool Equals(FSoundWaveSpectralDataEntry other)
		{
			return this == other;
		}

		// Token: 0x06010415 RID: 66581 RVA: 0x0017F278 File Offset: 0x0017D478
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FSoundWaveSpectralDataEntry)
			{
				FSoundWaveSpectralDataEntry other = (FSoundWaveSpectralDataEntry)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06010416 RID: 66582 RVA: 0x0017F29D File Offset: 0x0017D49D
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float>(this.Magnitude, this.NormalizedMagnitude);
		}

		// Token: 0x06010417 RID: 66583 RVA: 0x0017F2B0 File Offset: 0x0017D4B0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSoundWaveSpectralDataEntry._ScriptStructPtr != 0) ? FSoundWaveSpectralDataEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SoundWaveSpectralDataEntry", ref FSoundWaveSpectralDataEntry._ScriptStructPtr);
		}

		// Token: 0x04008BEA RID: 35818
		[FieldOffset(0)]
		public float Magnitude;

		// Token: 0x04008BEB RID: 35819
		[FieldOffset(4)]
		public float NormalizedMagnitude;

		// Token: 0x04008BEC RID: 35820
		public const string __ObjectPath = "/Script/Engine.SoundWaveSpectralDataEntry";

		// Token: 0x04008BED RID: 35821
		private static IntPtr _ScriptStructPtr;
	}
}
