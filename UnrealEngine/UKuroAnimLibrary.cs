using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002F3 RID: 755
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroAnimLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroAnimLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005237 RID: 21047 RVA: 0x00073059 File Offset: 0x00071259
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnimLibrary._ClassPtr;
		}

		// Token: 0x06005238 RID: 21048 RVA: 0x00073068 File Offset: 0x00071268
		public UKuroAnimLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroAnimLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005239 RID: 21049 RVA: 0x00073090 File Offset: 0x00071290
		[NullableContext(1)]
		public UKuroAnimLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnimLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600523A RID: 21050 RVA: 0x000730C4 File Offset: 0x000712C4
		[NullableContext(1)]
		public unsafe static string GetGameplayAbpPath([Nullable(2)] UObject BaseAbp, string GameplayTypeName)
		{
			FString fstring = FString.AllocTemp(GameplayTypeName);
			string result = FString.ToStringAndDeleteNativePtr(UKuroAnimLibrary.__GetGameplayAbpPath_Internal((BaseAbp != null) ? BaseAbp.NativePtr : IntPtr.Zero, fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600523B RID: 21051 RVA: 0x00073100 File Offset: 0x00071300
		public unsafe static FTransform GetDefaultBoneLocalPoseByName(USkeletalMeshComponent SkelMeshComp, in FName BoneName)
		{
			fixed (FName* ptr = &BoneName)
			{
				void* ptr2 = (void*)ptr;
				return UKuroAnimLibrary.__GetDefaultBoneLocalPoseByName_Internal((SkelMeshComp != null) ? SkelMeshComp.NativePtr : IntPtr.Zero, BoneName);
			}
		}

		// Token: 0x0600523C RID: 21052 RVA: 0x00073128 File Offset: 0x00071328
		public unsafe static FTransform GetDefaultBoneComponentPoseByName(USkeletalMeshComponent SkelMeshComp, in FName BoneName)
		{
			fixed (FName* ptr = &BoneName)
			{
				void* ptr2 = (void*)ptr;
				return UKuroAnimLibrary.__GetDefaultBoneComponentPoseByName_Internal((SkelMeshComp != null) ? SkelMeshComp.NativePtr : IntPtr.Zero, BoneName);
			}
		}

		// Token: 0x0600523D RID: 21053 RVA: 0x00073150 File Offset: 0x00071350
		public unsafe static int GetAnimationCurveId(UAnimSequence Animation, in FName CurveName)
		{
			fixed (FName* ptr = &CurveName)
			{
				void* ptr2 = (void*)ptr;
				return UKuroAnimLibrary.__GetAnimationCurveId_Internal((Animation != null) ? Animation.NativePtr : IntPtr.Zero, CurveName);
			}
		}

		// Token: 0x0600523E RID: 21054 RVA: 0x00073178 File Offset: 0x00071378
		public static float EvaluateAnimationCurve(UAnimSequence Animation, int CurveId, float Time)
		{
			return UKuroAnimLibrary.__EvaluateAnimationCurve_Internal((Animation != null) ? Animation.NativePtr : IntPtr.Zero, CurveId, Time);
		}

		// Token: 0x0600523F RID: 21055 RVA: 0x00073191 File Offset: 0x00071391
		public static void EndAnimNotifyStates(UAnimInstance AnimInstance)
		{
			UKuroAnimLibrary.__EndAnimNotifyStates_Internal((AnimInstance != null) ? AnimInstance.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06005240 RID: 21056
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetGameplayAbpPath_Internal(IntPtr BaseAbp, in FString GameplayTypeName);

		// Token: 0x06005241 RID: 21057
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetDefaultBoneLocalPoseByName_Internal(IntPtr SkelMeshComp, in FName BoneName);

		// Token: 0x06005242 RID: 21058
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetDefaultBoneComponentPoseByName_Internal(IntPtr SkelMeshComp, in FName BoneName);

		// Token: 0x06005243 RID: 21059
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetAnimationCurveId_Internal(IntPtr Animation, in FName CurveName);

		// Token: 0x06005244 RID: 21060
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __EvaluateAnimationCurve_Internal(IntPtr Animation, int CurveId, float Time);

		// Token: 0x06005245 RID: 21061
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EndAnimNotifyStates_Internal(IntPtr AnimInstance);

		// Token: 0x06005246 RID: 21062 RVA: 0x000731A8 File Offset: 0x000713A8
		static UKuroAnimLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroAnimLibrary");
		}

		// Token: 0x06005247 RID: 21063 RVA: 0x000731B6 File Offset: 0x000713B6
		protected UKuroAnimLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400217D RID: 8573
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroAnimLibrary";

		// Token: 0x0400217E RID: 8574
		private static IntPtr _ClassPtr;

		// Token: 0x0400217F RID: 8575
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
