using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A00 RID: 10752
	[UnrealObjectPath("/Script/UMG.WidgetComponentInstanceData")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 200)]
	public class FWidgetComponentInstanceData : FSceneComponentInstanceData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027F4C RID: 163660 RVA: 0x003CD79D File Offset: 0x003CB99D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWidgetComponentInstanceData._ScriptStructPtr != 0) ? FWidgetComponentInstanceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/UMG.WidgetComponentInstanceData", ref FWidgetComponentInstanceData._ScriptStructPtr);
		}

		// Token: 0x06027F4D RID: 163661 RVA: 0x003CD7C1 File Offset: 0x003CB9C1
		public FWidgetComponentInstanceData()
		{
		}

		// Token: 0x06027F4E RID: 163662 RVA: 0x003CD7CC File Offset: 0x003CB9CC
		[NullableContext(1)]
		public FWidgetComponentInstanceData(TMap<USceneComponent, FTransform> AttachedInstanceComponents, UObject SourceComponentTemplate, EComponentCreationMethod SourceComponentCreationMethod, int SourceComponentTypeSerializedIndex, TArray<byte> SavedProperties, FActorComponentDuplicatedObjectData UniqueTransientPackage, TArray<FActorComponentDuplicatedObjectData> DuplicatedObjects, TArray<UObject> ReferencedObjects, TArray<FName> ReferencedNames)
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

		// Token: 0x06027F4F RID: 163663 RVA: 0x003CD824 File Offset: 0x003CBA24
		protected override IntPtr GetUStructPtr()
		{
			return FWidgetComponentInstanceData.StaticStruct();
		}

		// Token: 0x06027F50 RID: 163664 RVA: 0x003CD830 File Offset: 0x003CBA30
		[NullableContext(2)]
		public FWidgetComponentInstanceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027F51 RID: 163665 RVA: 0x003CD83A File Offset: 0x003CBA3A
		public FWidgetComponentInstanceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027F52 RID: 163666 RVA: 0x003CD845 File Offset: 0x003CBA45
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWidgetComponentInstanceData(Pointer, false, true);
		}

		// Token: 0x06027F53 RID: 163667 RVA: 0x003CD84F File Offset: 0x003CBA4F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWidgetComponentInstanceData(Pointer, MemoryOwner);
		}

		// Token: 0x04015D10 RID: 89360
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.WidgetComponentInstanceData";

		// Token: 0x04015D11 RID: 89361
		private static IntPtr _ScriptStructPtr;
	}
}
