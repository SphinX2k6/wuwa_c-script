using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002447 RID: 9287
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 20)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneTangentData")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 20)]
	public struct FMovieSceneTangentData : IEqualityOperators<FMovieSceneTangentData, FMovieSceneTangentData, bool>, IEquatable<FMovieSceneTangentData>, IUnrealScriptStruct
	{
		// Token: 0x06022D1C RID: 142620 RVA: 0x00337D06 File Offset: 0x00335F06
		public FMovieSceneTangentData(float ArriveTangent, float LeaveTangent, float ArriveTangentWeight, float LeaveTangentWeight, TEnumAsByte<ERichCurveTangentWeightMode> TangentWeightMode)
		{
			this.ArriveTangent = ArriveTangent;
			this.LeaveTangent = LeaveTangent;
			this.ArriveTangentWeight = ArriveTangentWeight;
			this.LeaveTangentWeight = LeaveTangentWeight;
			this.TangentWeightMode = TangentWeightMode;
		}

		// Token: 0x06022D1D RID: 142621 RVA: 0x00337D30 File Offset: 0x00335F30
		public static bool operator ==(FMovieSceneTangentData left, FMovieSceneTangentData right)
		{
			return left.ArriveTangent == right.ArriveTangent && left.LeaveTangent == right.LeaveTangent && left.ArriveTangentWeight == right.ArriveTangentWeight && left.LeaveTangentWeight == right.LeaveTangentWeight && left.TangentWeightMode == right.TangentWeightMode;
		}

		// Token: 0x06022D1E RID: 142622 RVA: 0x00337D88 File Offset: 0x00335F88
		public static bool operator !=(FMovieSceneTangentData left, FMovieSceneTangentData right)
		{
			return !(left == right);
		}

		// Token: 0x06022D1F RID: 142623 RVA: 0x00337D94 File Offset: 0x00335F94
		public bool Equals(FMovieSceneTangentData other)
		{
			return this == other;
		}

		// Token: 0x06022D20 RID: 142624 RVA: 0x00337DA4 File Offset: 0x00335FA4
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FMovieSceneTangentData)
			{
				FMovieSceneTangentData other = (FMovieSceneTangentData)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06022D21 RID: 142625 RVA: 0x00337DC9 File Offset: 0x00335FC9
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float, TEnumAsByte<ERichCurveTangentWeightMode>>(this.ArriveTangent, this.LeaveTangent, this.ArriveTangentWeight, this.LeaveTangentWeight, this.TangentWeightMode);
		}

		// Token: 0x06022D22 RID: 142626 RVA: 0x00337DEE File Offset: 0x00335FEE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneTangentData._ScriptStructPtr != 0) ? FMovieSceneTangentData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneTangentData", ref FMovieSceneTangentData._ScriptStructPtr);
		}

		// Token: 0x04012977 RID: 76151
		[FieldOffset(0)]
		public float ArriveTangent;

		// Token: 0x04012978 RID: 76152
		[FieldOffset(4)]
		public float LeaveTangent;

		// Token: 0x04012979 RID: 76153
		[FieldOffset(8)]
		public float ArriveTangentWeight;

		// Token: 0x0401297A RID: 76154
		[FieldOffset(12)]
		public float LeaveTangentWeight;

		// Token: 0x0401297B RID: 76155
		[FieldOffset(16)]
		public TEnumAsByte<ERichCurveTangentWeightMode> TangentWeightMode;

		// Token: 0x0401297C RID: 76156
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneTangentData";

		// Token: 0x0401297D RID: 76157
		private static IntPtr _ScriptStructPtr;
	}
}
