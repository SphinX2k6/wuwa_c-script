using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200165D RID: 5725
	[UnrealObjectPath("/Script/KuroAnim.KuroAnimLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroAnimLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014BD7 RID: 84951 RVA: 0x001E804D File Offset: 0x001E624D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnimLibrary._ClassPtr;
		}

		// Token: 0x06014BD8 RID: 84952 RVA: 0x001E805C File Offset: 0x001E625C
		public UKuroAnimLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroAnimLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014BD9 RID: 84953 RVA: 0x001E8084 File Offset: 0x001E6284
		[NullableContext(1)]
		public UKuroAnimLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnimLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06014BDA RID: 84954 RVA: 0x001E80B8 File Offset: 0x001E62B8
		[NullableContext(1)]
		public unsafe static string GetGameplayAbpPath([Nullable(2)] UObject BaseAbp, string GameplayTypeName)
		{
			FString fstring = FString.AllocTemp(GameplayTypeName);
			string result = FString.ToStringAndDeleteNativePtr(UKuroAnimLibrary.__GetGameplayAbpPath_Internal((BaseAbp != null) ? BaseAbp.NativePtr : IntPtr.Zero, fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06014BDB RID: 84955 RVA: 0x001E80F4 File Offset: 0x001E62F4
		[NullableContext(2)]
		public unsafe static FTransform GetDefaultBoneLocalPoseByName(USkeletalMeshComponent SkelMeshComp, in FName BoneName)
		{
			fixed (FName* ptr = &BoneName)
			{
				void* ptr2 = (void*)ptr;
				return UKuroAnimLibrary.__GetDefaultBoneLocalPoseByName_Internal((SkelMeshComp != null) ? SkelMeshComp.NativePtr : IntPtr.Zero, BoneName);
			}
		}

		// Token: 0x06014BDC RID: 84956 RVA: 0x001E811C File Offset: 0x001E631C
		[NullableContext(2)]
		public unsafe static FTransform GetDefaultBoneComponentPoseByName(USkeletalMeshComponent SkelMeshComp, in FName BoneName)
		{
			fixed (FName* ptr = &BoneName)
			{
				void* ptr2 = (void*)ptr;
				return UKuroAnimLibrary.__GetDefaultBoneComponentPoseByName_Internal((SkelMeshComp != null) ? SkelMeshComp.NativePtr : IntPtr.Zero, BoneName);
			}
		}

		// Token: 0x06014BDD RID: 84957 RVA: 0x001E8144 File Offset: 0x001E6344
		[NullableContext(2)]
		public static void EndAnimNotifyStates(UAnimInstance AnimInstance)
		{
			UKuroAnimLibrary.__EndAnimNotifyStates_Internal((AnimInstance != null) ? AnimInstance.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06014BDE RID: 84958
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetGameplayAbpPath_Internal(IntPtr BaseAbp, in FString GameplayTypeName);

		// Token: 0x06014BDF RID: 84959
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetDefaultBoneLocalPoseByName_Internal(IntPtr SkelMeshComp, in FName BoneName);

		// Token: 0x06014BE0 RID: 84960
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetDefaultBoneComponentPoseByName_Internal(IntPtr SkelMeshComp, in FName BoneName);

		// Token: 0x06014BE1 RID: 84961
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EndAnimNotifyStates_Internal(IntPtr AnimInstance);

		// Token: 0x06014BE2 RID: 84962 RVA: 0x001E815B File Offset: 0x001E635B
		static UKuroAnimLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroAnimLibrary");
		}

		// Token: 0x06014BE3 RID: 84963 RVA: 0x001E8169 File Offset: 0x001E6369
		protected UKuroAnimLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B4ED RID: 46317
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroAnimLibrary";

		// Token: 0x0400B4EE RID: 46318
		private static IntPtr _ClassPtr;

		// Token: 0x0400B4EF RID: 46319
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
