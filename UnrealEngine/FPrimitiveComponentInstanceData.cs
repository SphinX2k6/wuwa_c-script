using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200103E RID: 4158
	[UnrealObjectPath("/Script/Engine.PrimitiveComponentInstanceData")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class FPrimitiveComponentInstanceData : FSceneComponentInstanceData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EC60 RID: 60512 RVA: 0x0015EAA9 File Offset: 0x0015CCA9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPrimitiveComponentInstanceData._ScriptStructPtr != 0) ? FPrimitiveComponentInstanceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PrimitiveComponentInstanceData", ref FPrimitiveComponentInstanceData._ScriptStructPtr);
		}

		// Token: 0x17003935 RID: 14645
		// (get) Token: 0x0600EC61 RID: 60513 RVA: 0x0015EACD File Offset: 0x0015CCCD
		// (set) Token: 0x0600EC62 RID: 60514 RVA: 0x0015EAE1 File Offset: 0x0015CCE1
		public unsafe FTransform ComponentTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPrimitiveComponentInstanceData.__PropertyOffset_ComponentTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPrimitiveComponentInstanceData.__PropertyOffset_ComponentTransform) = value;
			}
		}

		// Token: 0x17003936 RID: 14646
		// (get) Token: 0x0600EC63 RID: 60515 RVA: 0x0015EAF6 File Offset: 0x0015CCF6
		// (set) Token: 0x0600EC64 RID: 60516 RVA: 0x0015EB06 File Offset: 0x0015CD06
		public unsafe int VisibilityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPrimitiveComponentInstanceData.__PropertyOffset_VisibilityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPrimitiveComponentInstanceData.__PropertyOffset_VisibilityId) = value;
			}
		}

		// Token: 0x17003937 RID: 14647
		// (get) Token: 0x0600EC65 RID: 60517 RVA: 0x0015EB17 File Offset: 0x0015CD17
		// (set) Token: 0x0600EC66 RID: 60518 RVA: 0x0015EB2B File Offset: 0x0015CD2B
		[Nullable(2)]
		public unsafe UPrimitiveComponent LODParent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FPrimitiveComponentInstanceData.__PropertyOffset_LODParent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPrimitiveComponentInstanceData.__PropertyOffset_LODParent, value);
			}
		}

		// Token: 0x0600EC67 RID: 60519 RVA: 0x0015EB40 File Offset: 0x0015CD40
		public FPrimitiveComponentInstanceData()
		{
		}

		// Token: 0x0600EC68 RID: 60520 RVA: 0x0015EB48 File Offset: 0x0015CD48
		[NullableContext(1)]
		public FPrimitiveComponentInstanceData(FTransform ComponentTransform, int VisibilityId, UPrimitiveComponent LODParent, TMap<USceneComponent, FTransform> AttachedInstanceComponents, UObject SourceComponentTemplate, EComponentCreationMethod SourceComponentCreationMethod, int SourceComponentTypeSerializedIndex, TArray<byte> SavedProperties, FActorComponentDuplicatedObjectData UniqueTransientPackage, TArray<FActorComponentDuplicatedObjectData> DuplicatedObjects, TArray<UObject> ReferencedObjects, TArray<FName> ReferencedNames)
		{
			this.ComponentTransform = ComponentTransform;
			this.VisibilityId = VisibilityId;
			this.LODParent = LODParent;
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

		// Token: 0x0600EC69 RID: 60521 RVA: 0x0015EBB8 File Offset: 0x0015CDB8
		protected override IntPtr GetUStructPtr()
		{
			return FPrimitiveComponentInstanceData.StaticStruct();
		}

		// Token: 0x0600EC6A RID: 60522 RVA: 0x0015EBC4 File Offset: 0x0015CDC4
		[NullableContext(2)]
		public FPrimitiveComponentInstanceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EC6B RID: 60523 RVA: 0x0015EBCE File Offset: 0x0015CDCE
		public FPrimitiveComponentInstanceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EC6C RID: 60524 RVA: 0x0015EBD9 File Offset: 0x0015CDD9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPrimitiveComponentInstanceData(Pointer, false, true);
		}

		// Token: 0x0600EC6D RID: 60525 RVA: 0x0015EBE3 File Offset: 0x0015CDE3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPrimitiveComponentInstanceData(Pointer, MemoryOwner);
		}

		// Token: 0x04007FFB RID: 32763
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PrimitiveComponentInstanceData";

		// Token: 0x04007FFC RID: 32764
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007FFD RID: 32765
		internal static int __PropertyOffset_ComponentTransform;

		// Token: 0x04007FFE RID: 32766
		internal static int __PropertyOffset_VisibilityId;

		// Token: 0x04007FFF RID: 32767
		internal static int __PropertyOffset_LODParent;
	}
}
