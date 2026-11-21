using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000405 RID: 1029
	[UnrealObjectPath("/Script/KuroGameplay.KuroStaticMeshLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroStaticMeshLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060064D5 RID: 25813 RVA: 0x0008FE91 File Offset: 0x0008E091
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroStaticMeshLibrary._ClassPtr;
		}

		// Token: 0x060064D6 RID: 25814 RVA: 0x0008FEA0 File Offset: 0x0008E0A0
		public UKuroStaticMeshLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroStaticMeshLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060064D7 RID: 25815 RVA: 0x0008FEC8 File Offset: 0x0008E0C8
		[NullableContext(1)]
		public UKuroStaticMeshLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroStaticMeshLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060064D8 RID: 25816 RVA: 0x0008FEFB File Offset: 0x0008E0FB
		[NullableContext(2)]
		public static void MergeSimpleCollisions(UStaticMeshComponent TemplateComponent, in TArray<FTransform> LocalTransforms)
		{
			UKuroStaticMeshLibrary.__MergeSimpleCollisions_Internal((TemplateComponent != null) ? TemplateComponent.NativePtr : IntPtr.Zero, (LocalTransforms ?? new TArray<FTransform>()).NativePtr);
		}

		// Token: 0x060064D9 RID: 25817
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MergeSimpleCollisions_Internal(IntPtr TemplateComponent, IntPtr LocalTransforms);

		// Token: 0x060064DA RID: 25818 RVA: 0x0008FF22 File Offset: 0x0008E122
		static UKuroStaticMeshLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroStaticMeshLibrary");
		}

		// Token: 0x060064DB RID: 25819 RVA: 0x0008FF30 File Offset: 0x0008E130
		protected UKuroStaticMeshLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002A7A RID: 10874
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroStaticMeshLibrary";

		// Token: 0x04002A7B RID: 10875
		private static IntPtr _ClassPtr;

		// Token: 0x04002A7C RID: 10876
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
