using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001028 RID: 4136
	[UnrealObjectPath("/Script/Engine.PrecomputedLightInstanceData")]
	[UnrealStructLayout(272, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 272)]
	public class FPrecomputedLightInstanceData : FSceneComponentInstanceData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600E8C4 RID: 59588 RVA: 0x00159CAA File Offset: 0x00157EAA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPrecomputedLightInstanceData._ScriptStructPtr != 0) ? FPrecomputedLightInstanceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PrecomputedLightInstanceData", ref FPrecomputedLightInstanceData._ScriptStructPtr);
		}

		// Token: 0x1700385D RID: 14429
		// (get) Token: 0x0600E8C5 RID: 59589 RVA: 0x00159CCE File Offset: 0x00157ECE
		// (set) Token: 0x0600E8C6 RID: 59590 RVA: 0x00159CE2 File Offset: 0x00157EE2
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPrecomputedLightInstanceData.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPrecomputedLightInstanceData.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x1700385E RID: 14430
		// (get) Token: 0x0600E8C7 RID: 59591 RVA: 0x00159CF7 File Offset: 0x00157EF7
		// (set) Token: 0x0600E8C8 RID: 59592 RVA: 0x00159D0B File Offset: 0x00157F0B
		public unsafe FGuid LightGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPrecomputedLightInstanceData.__PropertyOffset_LightGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPrecomputedLightInstanceData.__PropertyOffset_LightGuid) = value;
			}
		}

		// Token: 0x1700385F RID: 14431
		// (get) Token: 0x0600E8C9 RID: 59593 RVA: 0x00159D20 File Offset: 0x00157F20
		// (set) Token: 0x0600E8CA RID: 59594 RVA: 0x00159D30 File Offset: 0x00157F30
		public unsafe int PreviewShadowMapChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPrecomputedLightInstanceData.__PropertyOffset_PreviewShadowMapChannel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPrecomputedLightInstanceData.__PropertyOffset_PreviewShadowMapChannel) = value;
			}
		}

		// Token: 0x0600E8CB RID: 59595 RVA: 0x00159D41 File Offset: 0x00157F41
		public FPrecomputedLightInstanceData()
		{
		}

		// Token: 0x0600E8CC RID: 59596 RVA: 0x00159D4C File Offset: 0x00157F4C
		[NullableContext(1)]
		public FPrecomputedLightInstanceData(FTransform Transform, FGuid LightGuid, int PreviewShadowMapChannel, TMap<USceneComponent, FTransform> AttachedInstanceComponents, UObject SourceComponentTemplate, EComponentCreationMethod SourceComponentCreationMethod, int SourceComponentTypeSerializedIndex, TArray<byte> SavedProperties, FActorComponentDuplicatedObjectData UniqueTransientPackage, TArray<FActorComponentDuplicatedObjectData> DuplicatedObjects, TArray<UObject> ReferencedObjects, TArray<FName> ReferencedNames)
		{
			this.Transform = Transform;
			this.LightGuid = LightGuid;
			this.PreviewShadowMapChannel = PreviewShadowMapChannel;
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

		// Token: 0x0600E8CD RID: 59597 RVA: 0x00159DBC File Offset: 0x00157FBC
		protected override IntPtr GetUStructPtr()
		{
			return FPrecomputedLightInstanceData.StaticStruct();
		}

		// Token: 0x0600E8CE RID: 59598 RVA: 0x00159DC8 File Offset: 0x00157FC8
		[NullableContext(2)]
		public FPrecomputedLightInstanceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600E8CF RID: 59599 RVA: 0x00159DD2 File Offset: 0x00157FD2
		public FPrecomputedLightInstanceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600E8D0 RID: 59600 RVA: 0x00159DDD File Offset: 0x00157FDD
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPrecomputedLightInstanceData(Pointer, false, true);
		}

		// Token: 0x0600E8D1 RID: 59601 RVA: 0x00159DE7 File Offset: 0x00157FE7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPrecomputedLightInstanceData(Pointer, MemoryOwner);
		}

		// Token: 0x04007E61 RID: 32353
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PrecomputedLightInstanceData";

		// Token: 0x04007E62 RID: 32354
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007E63 RID: 32355
		internal static int __PropertyOffset_Transform;

		// Token: 0x04007E64 RID: 32356
		internal static int __PropertyOffset_LightGuid;

		// Token: 0x04007E65 RID: 32357
		internal static int __PropertyOffset_PreviewShadowMapChannel;
	}
}
