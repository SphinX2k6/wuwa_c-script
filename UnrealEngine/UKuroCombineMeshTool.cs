using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AD3 RID: 6867
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCombineMeshTool")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroCombineMeshTool : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601993D RID: 104765 RVA: 0x0025CFF4 File Offset: 0x0025B1F4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCombineMeshTool._ClassPtr;
		}

		// Token: 0x0601993E RID: 104766 RVA: 0x0025D000 File Offset: 0x0025B200
		public UKuroCombineMeshTool() : this(BuiltinUtils.AllocNativeUObject(UKuroCombineMeshTool.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601993F RID: 104767 RVA: 0x0025D028 File Offset: 0x0025B228
		[NullableContext(1)]
		public UKuroCombineMeshTool(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCombineMeshTool.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06019940 RID: 104768 RVA: 0x0025D05C File Offset: 0x0025B25C
		[NullableContext(2)]
		public unsafe static USkeletalMeshComponent SetupPartSkeletalMesh(AActor Actor, in FTransform Transform, USkeletalMeshComponent MainMeshComp, USkeletalMesh PartMesh, FName PartMeshName, bool bIsSocket = false, int Index = 0, bool bManualAttach = false)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(UKuroCombineMeshTool.__SetupPartSkeletalMesh_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, ptr, (MainMeshComp != null) ? MainMeshComp.NativePtr : IntPtr.Zero, (PartMesh != null) ? PartMesh.NativePtr : IntPtr.Zero, PartMeshName, bIsSocket, Index, bManualAttach));
		}

		// Token: 0x06019941 RID: 104769 RVA: 0x0025D0C8 File Offset: 0x0025B2C8
		[NullableContext(2)]
		[return: Nullable(1)]
		public static TArray<USkeletalMeshComponent> SetupDecorations(AActor Actor, USkeletalMeshComponent MainMeshComp, UKuroNpcExtraDecorationConfig Config)
		{
			return new TArray<USkeletalMeshComponent>(UKuroCombineMeshTool.__SetupDecorations_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, (MainMeshComp != null) ? MainMeshComp.NativePtr : IntPtr.Zero, (Config != null) ? Config.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x06019942 RID: 104770 RVA: 0x0025D108 File Offset: 0x0025B308
		[NullableContext(2)]
		public unsafe static USkeletalMeshComponent LoadBodyPart(AActor Actor, in FTransform DefaultTransform, USkeletalMeshComponent MainMeshComp, USkeletalMesh BodyPartMesh, FName PartName, bool bRunPostUpdateTick, bool bDyeColor, bool bHasSkinColor, in FLinearColor SkinColor, bool bHasColor1, in FLinearColor Color1, bool bHasColor2, in FLinearColor Color2, UMaterialInterface Material, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UMaterialInterface> ExtraMaterials)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = DefaultTransform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(UKuroCombineMeshTool.__LoadBodyPart_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, ptr, (MainMeshComp != null) ? MainMeshComp.NativePtr : IntPtr.Zero, (BodyPartMesh != null) ? BodyPartMesh.NativePtr : IntPtr.Zero, PartName, bRunPostUpdateTick, bDyeColor, bHasSkinColor, SkinColor, bHasColor1, Color1, bHasColor2, Color2, (Material != null) ? Material.NativePtr : IntPtr.Zero, (ExtraMaterials ?? new TArray<UMaterialInterface>()).NativePtr));
		}

		// Token: 0x06019943 RID: 104771
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FName GetPartMeshName(FName Prefix, int Index);

		// Token: 0x06019944 RID: 104772
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetupPartSkeletalMesh_Internal(IntPtr Actor, in FTransform Transform, IntPtr MainMeshComp, IntPtr PartMesh, FName PartMeshName, bool bIsSocket, int Index, bool bManualAttach);

		// Token: 0x06019945 RID: 104773
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetupDecorations_Internal(IntPtr Actor, IntPtr MainMeshComp, IntPtr Config);

		// Token: 0x06019946 RID: 104774
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LoadBodyPart_Internal(IntPtr Actor, in FTransform DefaultTransform, IntPtr MainMeshComp, IntPtr BodyPartMesh, FName PartName, bool bRunPostUpdateTick, bool bDyeColor, bool bHasSkinColor, in FLinearColor SkinColor, bool bHasColor1, in FLinearColor Color1, bool bHasColor2, in FLinearColor Color2, IntPtr Material, IntPtr ExtraMaterials);

		// Token: 0x06019947 RID: 104775 RVA: 0x0025D1A1 File Offset: 0x0025B3A1
		static UKuroCombineMeshTool()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroCombineMeshTool");
		}

		// Token: 0x06019948 RID: 104776 RVA: 0x0025D1AF File Offset: 0x0025B3AF
		protected UKuroCombineMeshTool(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DECD RID: 57037
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCombineMeshTool";

		// Token: 0x0400DECE RID: 57038
		private static IntPtr _ClassPtr;

		// Token: 0x0400DECF RID: 57039
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
