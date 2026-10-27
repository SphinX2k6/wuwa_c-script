using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200229A RID: 8858
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/MediaAssets.MediaSoundComponentSpectralData")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FMediaSoundComponentSpectralData : IEqualityOperators<FMediaSoundComponentSpectralData, FMediaSoundComponentSpectralData, bool>, IEquatable<FMediaSoundComponentSpectralData>, IUnrealScriptStruct
	{
		// Token: 0x06021B32 RID: 138034 RVA: 0x0031D3D6 File Offset: 0x0031B5D6
		public FMediaSoundComponentSpectralData(float FrequencyHz, float Magnitude)
		{
			this.FrequencyHz = FrequencyHz;
			this.Magnitude = Magnitude;
		}

		// Token: 0x06021B33 RID: 138035 RVA: 0x0031D3E6 File Offset: 0x0031B5E6
		public static bool operator ==(FMediaSoundComponentSpectralData left, FMediaSoundComponentSpectralData right)
		{
			return left.FrequencyHz == right.FrequencyHz && left.Magnitude == right.Magnitude;
		}

		// Token: 0x06021B34 RID: 138036 RVA: 0x0031D406 File Offset: 0x0031B606
		public static bool operator !=(FMediaSoundComponentSpectralData left, FMediaSoundComponentSpectralData right)
		{
			return !(left == right);
		}

		// Token: 0x06021B35 RID: 138037 RVA: 0x0031D412 File Offset: 0x0031B612
		public bool Equals(FMediaSoundComponentSpectralData other)
		{
			return this == other;
		}

		// Token: 0x06021B36 RID: 138038 RVA: 0x0031D420 File Offset: 0x0031B620
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FMediaSoundComponentSpectralData)
			{
				FMediaSoundComponentSpectralData other = (FMediaSoundComponentSpectralData)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06021B37 RID: 138039 RVA: 0x0031D445 File Offset: 0x0031B645
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float>(this.FrequencyHz, this.Magnitude);
		}

		// Token: 0x06021B38 RID: 138040 RVA: 0x0031D458 File Offset: 0x0031B658
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMediaSoundComponentSpectralData._ScriptStructPtr != 0) ? FMediaSoundComponentSpectralData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MediaAssets.MediaSoundComponentSpectralData", ref FMediaSoundComponentSpectralData._ScriptStructPtr);
		}

		// Token: 0x04011FA9 RID: 73641
		[FieldOffset(0)]
		public float FrequencyHz;

		// Token: 0x04011FAA RID: 73642
		[FieldOffset(4)]
		public float Magnitude;

		// Token: 0x04011FAB RID: 73643
		public const string __ObjectPath = "/Script/MediaAssets.MediaSoundComponentSpectralData";

		// Token: 0x04011FAC RID: 73644
		private static IntPtr _ScriptStructPtr;
	}
}
