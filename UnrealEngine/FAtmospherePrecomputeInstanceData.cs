using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000862 RID: 2146
	[UnrealObjectPath("/Script/Engine.AtmospherePrecomputeInstanceData")]
	[UnrealStructLayout(688, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 688)]
	public class FAtmospherePrecomputeInstanceData : FSceneComponentInstanceData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060073A5 RID: 29605 RVA: 0x000A6068 File Offset: 0x000A4268
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAtmospherePrecomputeInstanceData._ScriptStructPtr != 0) ? FAtmospherePrecomputeInstanceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AtmospherePrecomputeInstanceData", ref FAtmospherePrecomputeInstanceData._ScriptStructPtr);
		}

		// Token: 0x060073A6 RID: 29606 RVA: 0x000A608C File Offset: 0x000A428C
		public FAtmospherePrecomputeInstanceData()
		{
		}

		// Token: 0x060073A7 RID: 29607 RVA: 0x000A6094 File Offset: 0x000A4294
		[NullableContext(1)]
		public FAtmospherePrecomputeInstanceData(TMap<USceneComponent, FTransform> AttachedInstanceComponents, UObject SourceComponentTemplate, EComponentCreationMethod SourceComponentCreationMethod, int SourceComponentTypeSerializedIndex, TArray<byte> SavedProperties, FActorComponentDuplicatedObjectData UniqueTransientPackage, TArray<FActorComponentDuplicatedObjectData> DuplicatedObjects, TArray<UObject> ReferencedObjects, TArray<FName> ReferencedNames)
		{
			base.AttachedInstanceComponents = AttachedInstanceComponents;
			base.SourceComponentTemplate = SourceComponentTemplate;
			base.SourceComponentCreationMethod = SourceComponentCreationMethod;
			base.SourceComponentTypeSerializedIndex = SourceComponentTypeSerializedIndex;
			base.SavedProperties = SavedProperties;
			base.UniqueTransientPackage = UniqueTransientPackage;
			base.DuplicatedObjects = DuplicatedObjects;
			base.ReferencedObjects = ReferencedObjects;
			base.ReferencedNames = ReferencedNames;
		}

		// Token: 0x060073A8 RID: 29608 RVA: 0x000A60EC File Offset: 0x000A42EC
		protected override IntPtr GetUStructPtr()
		{
			return FAtmospherePrecomputeInstanceData.StaticStruct();
		}

		// Token: 0x060073A9 RID: 29609 RVA: 0x000A60F8 File Offset: 0x000A42F8
		[NullableContext(2)]
		public FAtmospherePrecomputeInstanceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060073AA RID: 29610 RVA: 0x000A6102 File Offset: 0x000A4302
		public FAtmospherePrecomputeInstanceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060073AB RID: 29611 RVA: 0x000A610D File Offset: 0x000A430D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAtmospherePrecomputeInstanceData(Pointer, false, true);
		}

		// Token: 0x060073AC RID: 29612 RVA: 0x000A6117 File Offset: 0x000A4317
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAtmospherePrecomputeInstanceData(Pointer, MemoryOwner);
		}

		// Token: 0x040037AC RID: 14252
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AtmospherePrecomputeInstanceData";

		// Token: 0x040037AD RID: 14253
		private static IntPtr _ScriptStructPtr;
	}
}
