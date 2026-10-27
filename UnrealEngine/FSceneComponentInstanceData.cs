using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010DA RID: 4314
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SceneComponentInstanceData")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 184)]
	public class FSceneComponentInstanceData : FActorComponentInstanceData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F768 RID: 63336 RVA: 0x0016E2A7 File Offset: 0x0016C4A7
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSceneComponentInstanceData._ScriptStructPtr != 0) ? FSceneComponentInstanceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SceneComponentInstanceData", ref FSceneComponentInstanceData._ScriptStructPtr);
		}

		// Token: 0x17003C32 RID: 15410
		// (get) Token: 0x0600F769 RID: 63337 RVA: 0x0016E2CC File Offset: 0x0016C4CC
		// (set) Token: 0x0600F76A RID: 63338 RVA: 0x0016E30F File Offset: 0x0016C50F
		public TMap<USceneComponent, FTransform> AttachedInstanceComponents
		{
			get
			{
				base.FastCheckIsValid();
				TMap<USceneComponent, FTransform> result;
				if ((result = this._AttachedInstanceComponents) == null)
				{
					result = (this._AttachedInstanceComponents = new TMap<USceneComponent, FTransform>(base.NativePtr + (IntPtr)FSceneComponentInstanceData.__PropertyOffset_AttachedInstanceComponents, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AttachedInstanceComponents.CopyAssign(value);
			}
		}

		// Token: 0x0600F76B RID: 63339 RVA: 0x0016E31D File Offset: 0x0016C51D
		public FSceneComponentInstanceData()
		{
		}

		// Token: 0x0600F76C RID: 63340 RVA: 0x0016E328 File Offset: 0x0016C528
		public FSceneComponentInstanceData(TMap<USceneComponent, FTransform> AttachedInstanceComponents, UObject SourceComponentTemplate, EComponentCreationMethod SourceComponentCreationMethod, int SourceComponentTypeSerializedIndex, TArray<byte> SavedProperties, FActorComponentDuplicatedObjectData UniqueTransientPackage, TArray<FActorComponentDuplicatedObjectData> DuplicatedObjects, TArray<UObject> ReferencedObjects, TArray<FName> ReferencedNames)
		{
			this.AttachedInstanceComponents = AttachedInstanceComponents;
			base.SourceComponentTemplate = SourceComponentTemplate;
			base.SourceComponentCreationMethod = SourceComponentCreationMethod;
			base.SourceComponentTypeSerializedIndex = SourceComponentTypeSerializedIndex;
			base.SavedProperties = SavedProperties;
			base.UniqueTransientPackage = UniqueTransientPackage;
			base.DuplicatedObjects = DuplicatedObjects;
			base.ReferencedObjects = ReferencedObjects;
			base.ReferencedNames = ReferencedNames;
		}

		// Token: 0x0600F76D RID: 63341 RVA: 0x0016E380 File Offset: 0x0016C580
		protected override IntPtr GetUStructPtr()
		{
			return FSceneComponentInstanceData.StaticStruct();
		}

		// Token: 0x0600F76E RID: 63342 RVA: 0x0016E38C File Offset: 0x0016C58C
		[NullableContext(2)]
		public FSceneComponentInstanceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F76F RID: 63343 RVA: 0x0016E396 File Offset: 0x0016C596
		public FSceneComponentInstanceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F770 RID: 63344 RVA: 0x0016E3A1 File Offset: 0x0016C5A1
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSceneComponentInstanceData(Pointer, false, true);
		}

		// Token: 0x0600F771 RID: 63345 RVA: 0x0016E3AB File Offset: 0x0016C5AB
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSceneComponentInstanceData(Pointer, MemoryOwner);
		}

		// Token: 0x040085B5 RID: 34229
		public new const string __ObjectPath = "/Script/Engine.SceneComponentInstanceData";

		// Token: 0x040085B6 RID: 34230
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040085B7 RID: 34231
		internal static int __PropertyOffset_AttachedInstanceComponents;

		// Token: 0x040085B8 RID: 34232
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<USceneComponent, FTransform> _AttachedInstanceComponents;
	}
}
