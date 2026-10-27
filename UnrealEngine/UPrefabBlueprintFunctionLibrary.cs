using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002657 RID: 9815
	[UnrealObjectPath("/Script/PrefabSystem.PrefabBlueprintFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UPrefabBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060247A7 RID: 149415 RVA: 0x0035FFCA File Offset: 0x0035E1CA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPrefabBlueprintFunctionLibrary._ClassPtr;
		}

		// Token: 0x060247A8 RID: 149416 RVA: 0x0035FFD8 File Offset: 0x0035E1D8
		public UPrefabBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UPrefabBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060247A9 RID: 149417 RVA: 0x00360000 File Offset: 0x0035E200
		[NullableContext(1)]
		public UPrefabBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPrefabBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060247AA RID: 149418 RVA: 0x00360033 File Offset: 0x0035E233
		[NullableContext(2)]
		public static AActor Instantiate(UPrefabAsset PrefabAsset, USceneComponent ParentComponent, ULevel InLevel, bool bTemporaryEditorActor)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UPrefabBlueprintFunctionLibrary.__Instantiate_Internal((PrefabAsset != null) ? PrefabAsset.NativePtr : IntPtr.Zero, (ParentComponent != null) ? ParentComponent.NativePtr : IntPtr.Zero, (InLevel != null) ? InLevel.NativePtr : IntPtr.Zero, bTemporaryEditorActor));
		}

		// Token: 0x060247AB RID: 149419 RVA: 0x00360070 File Offset: 0x0035E270
		[NullableContext(2)]
		public static void ApplyPrefab(AActor Actor)
		{
			UPrefabBlueprintFunctionLibrary.__ApplyPrefab_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060247AC RID: 149420
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Instantiate_Internal(IntPtr PrefabAsset, IntPtr ParentComponent, IntPtr InLevel, bool bTemporaryEditorActor);

		// Token: 0x060247AD RID: 149421
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyPrefab_Internal(IntPtr Actor);

		// Token: 0x060247AE RID: 149422 RVA: 0x00360087 File Offset: 0x0035E287
		static UPrefabBlueprintFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/PrefabSystem.PrefabBlueprintFunctionLibrary");
		}

		// Token: 0x060247AF RID: 149423 RVA: 0x00360095 File Offset: 0x0035E295
		protected UPrefabBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013994 RID: 80276
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/PrefabSystem.PrefabBlueprintFunctionLibrary";

		// Token: 0x04013995 RID: 80277
		private static IntPtr _ClassPtr;

		// Token: 0x04013996 RID: 80278
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
