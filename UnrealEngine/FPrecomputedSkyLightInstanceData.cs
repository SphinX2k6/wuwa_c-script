using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001029 RID: 4137
	[UnrealObjectPath("/Script/Engine.PrecomputedSkyLightInstanceData")]
	[UnrealStructLayout(368, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 368)]
	public class FPrecomputedSkyLightInstanceData : FSceneComponentInstanceData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600E8D2 RID: 59602 RVA: 0x00159DF0 File Offset: 0x00157FF0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPrecomputedSkyLightInstanceData._ScriptStructPtr != 0) ? FPrecomputedSkyLightInstanceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PrecomputedSkyLightInstanceData", ref FPrecomputedSkyLightInstanceData._ScriptStructPtr);
		}

		// Token: 0x17003860 RID: 14432
		// (get) Token: 0x0600E8D3 RID: 59603 RVA: 0x00159E14 File Offset: 0x00158014
		// (set) Token: 0x0600E8D4 RID: 59604 RVA: 0x00159E28 File Offset: 0x00158028
		public unsafe FGuid LightGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPrecomputedSkyLightInstanceData.__PropertyOffset_LightGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPrecomputedSkyLightInstanceData.__PropertyOffset_LightGuid) = value;
			}
		}

		// Token: 0x17003861 RID: 14433
		// (get) Token: 0x0600E8D5 RID: 59605 RVA: 0x00159E3D File Offset: 0x0015803D
		// (set) Token: 0x0600E8D6 RID: 59606 RVA: 0x00159E4D File Offset: 0x0015804D
		public unsafe float AverageBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPrecomputedSkyLightInstanceData.__PropertyOffset_AverageBrightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPrecomputedSkyLightInstanceData.__PropertyOffset_AverageBrightness) = value;
			}
		}

		// Token: 0x0600E8D7 RID: 59607 RVA: 0x00159E5E File Offset: 0x0015805E
		public FPrecomputedSkyLightInstanceData()
		{
		}

		// Token: 0x0600E8D8 RID: 59608 RVA: 0x00159E68 File Offset: 0x00158068
		[NullableContext(1)]
		public FPrecomputedSkyLightInstanceData(FGuid LightGuid, float AverageBrightness, TMap<USceneComponent, FTransform> AttachedInstanceComponents, UObject SourceComponentTemplate, EComponentCreationMethod SourceComponentCreationMethod, int SourceComponentTypeSerializedIndex, TArray<byte> SavedProperties, FActorComponentDuplicatedObjectData UniqueTransientPackage, TArray<FActorComponentDuplicatedObjectData> DuplicatedObjects, TArray<UObject> ReferencedObjects, TArray<FName> ReferencedNames)
		{
			this.LightGuid = LightGuid;
			this.AverageBrightness = AverageBrightness;
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

		// Token: 0x0600E8D9 RID: 59609 RVA: 0x00159ED0 File Offset: 0x001580D0
		protected override IntPtr GetUStructPtr()
		{
			return FPrecomputedSkyLightInstanceData.StaticStruct();
		}

		// Token: 0x0600E8DA RID: 59610 RVA: 0x00159EDC File Offset: 0x001580DC
		[NullableContext(2)]
		public FPrecomputedSkyLightInstanceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600E8DB RID: 59611 RVA: 0x00159EE6 File Offset: 0x001580E6
		public FPrecomputedSkyLightInstanceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600E8DC RID: 59612 RVA: 0x00159EF1 File Offset: 0x001580F1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPrecomputedSkyLightInstanceData(Pointer, false, true);
		}

		// Token: 0x0600E8DD RID: 59613 RVA: 0x00159EFB File Offset: 0x001580FB
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPrecomputedSkyLightInstanceData(Pointer, MemoryOwner);
		}

		// Token: 0x04007E66 RID: 32358
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PrecomputedSkyLightInstanceData";

		// Token: 0x04007E67 RID: 32359
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007E68 RID: 32360
		internal static int __PropertyOffset_LightGuid;

		// Token: 0x04007E69 RID: 32361
		internal static int __PropertyOffset_AverageBrightness;
	}
}
