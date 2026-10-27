using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A1E RID: 6686
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/KuroPerformance.KuroGameConfig")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FKuroGameConfig : IEqualityOperators<FKuroGameConfig, FKuroGameConfig, bool>, IEquatable<FKuroGameConfig>, IUnrealScriptStruct
	{
		// Token: 0x06018BB9 RID: 101305 RVA: 0x00248138 File Offset: 0x00246338
		public FKuroGameConfig(int FPS, int Resolution, bool bMSAA, TEnumAsByte<EKuroGameConfigLevel> RenderLevel, TEnumAsByte<EKuroGameConfigLevel> ModelLevel, bool bSceneTransition)
		{
			this.FPS = FPS;
			this.Resolution = Resolution;
			this.bMSAA = bMSAA;
			this.RenderLevel = RenderLevel;
			this.ModelLevel = ModelLevel;
			this.bSceneTransition = bSceneTransition;
		}

		// Token: 0x06018BBA RID: 101306 RVA: 0x00248168 File Offset: 0x00246368
		public static bool operator ==(FKuroGameConfig left, FKuroGameConfig right)
		{
			return left.FPS == right.FPS && left.Resolution == right.Resolution && left.bMSAA == right.bMSAA && left.RenderLevel == right.RenderLevel && left.ModelLevel == right.ModelLevel && left.bSceneTransition == right.bSceneTransition;
		}

		// Token: 0x06018BBB RID: 101307 RVA: 0x002481D5 File Offset: 0x002463D5
		public static bool operator !=(FKuroGameConfig left, FKuroGameConfig right)
		{
			return !(left == right);
		}

		// Token: 0x06018BBC RID: 101308 RVA: 0x002481E1 File Offset: 0x002463E1
		public bool Equals(FKuroGameConfig other)
		{
			return this == other;
		}

		// Token: 0x06018BBD RID: 101309 RVA: 0x002481F0 File Offset: 0x002463F0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FKuroGameConfig)
			{
				FKuroGameConfig other = (FKuroGameConfig)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06018BBE RID: 101310 RVA: 0x00248215 File Offset: 0x00246415
		public override int GetHashCode()
		{
			return HashCode.Combine<int, int, bool, TEnumAsByte<EKuroGameConfigLevel>, TEnumAsByte<EKuroGameConfigLevel>, bool>(this.FPS, this.Resolution, this.bMSAA, this.RenderLevel, this.ModelLevel, this.bSceneTransition);
		}

		// Token: 0x06018BBF RID: 101311 RVA: 0x00248240 File Offset: 0x00246440
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroGameConfig._ScriptStructPtr != 0) ? FKuroGameConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroPerformance.KuroGameConfig", ref FKuroGameConfig._ScriptStructPtr);
		}

		// Token: 0x0400D5D2 RID: 54738
		[FieldOffset(0)]
		public readonly int FPS;

		// Token: 0x0400D5D3 RID: 54739
		[FieldOffset(4)]
		public readonly int Resolution;

		// Token: 0x0400D5D4 RID: 54740
		[FieldOffset(8)]
		public readonly bool bMSAA;

		// Token: 0x0400D5D5 RID: 54741
		[FieldOffset(9)]
		public readonly TEnumAsByte<EKuroGameConfigLevel> RenderLevel;

		// Token: 0x0400D5D6 RID: 54742
		[FieldOffset(10)]
		public readonly TEnumAsByte<EKuroGameConfigLevel> ModelLevel;

		// Token: 0x0400D5D7 RID: 54743
		[FieldOffset(11)]
		public readonly bool bSceneTransition;

		// Token: 0x0400D5D8 RID: 54744
		public const string __ObjectPath = "/Script/KuroPerformance.KuroGameConfig";

		// Token: 0x0400D5D9 RID: 54745
		private static IntPtr _ScriptStructPtr;
	}
}
