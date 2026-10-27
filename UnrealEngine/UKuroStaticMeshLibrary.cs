using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001916 RID: 6422
	[UnrealObjectPath("/Script/KuroGameplay.KuroStaticMeshLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroStaticMeshLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017D53 RID: 97619 RVA: 0x0022E751 File Offset: 0x0022C951
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroStaticMeshLibrary._ClassPtr;
		}

		// Token: 0x06017D54 RID: 97620 RVA: 0x0022E760 File Offset: 0x0022C960
		public UKuroStaticMeshLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroStaticMeshLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017D55 RID: 97621 RVA: 0x0022E788 File Offset: 0x0022C988
		[NullableContext(1)]
		public UKuroStaticMeshLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroStaticMeshLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017D56 RID: 97622 RVA: 0x0022E7BB File Offset: 0x0022C9BB
		[NullableContext(2)]
		public static void MergeSimpleCollisions(UStaticMeshComponent TemplateComponent, in TArray<FTransform> LocalTransforms)
		{
			UKuroStaticMeshLibrary.__MergeSimpleCollisions_Internal((TemplateComponent != null) ? TemplateComponent.NativePtr : IntPtr.Zero, (LocalTransforms ?? new TArray<FTransform>()).NativePtr);
		}

		// Token: 0x06017D57 RID: 97623
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MergeSimpleCollisions_Internal(IntPtr TemplateComponent, IntPtr LocalTransforms);

		// Token: 0x06017D58 RID: 97624 RVA: 0x0022E7E2 File Offset: 0x0022C9E2
		static UKuroStaticMeshLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroStaticMeshLibrary");
		}

		// Token: 0x06017D59 RID: 97625 RVA: 0x0022E7F0 File Offset: 0x0022C9F0
		protected UKuroStaticMeshLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CEAC RID: 52908
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroStaticMeshLibrary";

		// Token: 0x0400CEAD RID: 52909
		private static IntPtr _ClassPtr;

		// Token: 0x0400CEAE RID: 52910
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
