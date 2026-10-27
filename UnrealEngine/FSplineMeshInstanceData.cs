using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200117C RID: 4476
	[UnrealObjectPath("/Script/Engine.SplineMeshInstanceData")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 232)]
	public class FSplineMeshInstanceData : FSceneComponentInstanceData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601071E RID: 67358 RVA: 0x0018268D File Offset: 0x0018088D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSplineMeshInstanceData._ScriptStructPtr != 0) ? FSplineMeshInstanceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SplineMeshInstanceData", ref FSplineMeshInstanceData._ScriptStructPtr);
		}

		// Token: 0x17004019 RID: 16409
		// (get) Token: 0x0601071F RID: 67359 RVA: 0x001826B1 File Offset: 0x001808B1
		// (set) Token: 0x06010720 RID: 67360 RVA: 0x001826C5 File Offset: 0x001808C5
		public unsafe FVector StartPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSplineMeshInstanceData.__PropertyOffset_StartPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSplineMeshInstanceData.__PropertyOffset_StartPos) = value;
			}
		}

		// Token: 0x1700401A RID: 16410
		// (get) Token: 0x06010721 RID: 67361 RVA: 0x001826DA File Offset: 0x001808DA
		// (set) Token: 0x06010722 RID: 67362 RVA: 0x001826EE File Offset: 0x001808EE
		public unsafe FVector EndPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSplineMeshInstanceData.__PropertyOffset_EndPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSplineMeshInstanceData.__PropertyOffset_EndPos) = value;
			}
		}

		// Token: 0x1700401B RID: 16411
		// (get) Token: 0x06010723 RID: 67363 RVA: 0x00182703 File Offset: 0x00180903
		// (set) Token: 0x06010724 RID: 67364 RVA: 0x00182717 File Offset: 0x00180917
		public unsafe FVector StartTangent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSplineMeshInstanceData.__PropertyOffset_StartTangent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSplineMeshInstanceData.__PropertyOffset_StartTangent) = value;
			}
		}

		// Token: 0x1700401C RID: 16412
		// (get) Token: 0x06010725 RID: 67365 RVA: 0x0018272C File Offset: 0x0018092C
		// (set) Token: 0x06010726 RID: 67366 RVA: 0x00182740 File Offset: 0x00180940
		public unsafe FVector EndTangent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSplineMeshInstanceData.__PropertyOffset_EndTangent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSplineMeshInstanceData.__PropertyOffset_EndTangent) = value;
			}
		}

		// Token: 0x06010727 RID: 67367 RVA: 0x00182755 File Offset: 0x00180955
		public FSplineMeshInstanceData()
		{
		}

		// Token: 0x06010728 RID: 67368 RVA: 0x00182760 File Offset: 0x00180960
		[NullableContext(1)]
		public FSplineMeshInstanceData(FVector StartPos, FVector EndPos, FVector StartTangent, FVector EndTangent, TMap<USceneComponent, FTransform> AttachedInstanceComponents, UObject SourceComponentTemplate, EComponentCreationMethod SourceComponentCreationMethod, int SourceComponentTypeSerializedIndex, TArray<byte> SavedProperties, FActorComponentDuplicatedObjectData UniqueTransientPackage, TArray<FActorComponentDuplicatedObjectData> DuplicatedObjects, TArray<UObject> ReferencedObjects, TArray<FName> ReferencedNames)
		{
			this.StartPos = StartPos;
			this.EndPos = EndPos;
			this.StartTangent = StartTangent;
			this.EndTangent = EndTangent;
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

		// Token: 0x06010729 RID: 67369 RVA: 0x001827D8 File Offset: 0x001809D8
		protected override IntPtr GetUStructPtr()
		{
			return FSplineMeshInstanceData.StaticStruct();
		}

		// Token: 0x0601072A RID: 67370 RVA: 0x001827E4 File Offset: 0x001809E4
		[NullableContext(2)]
		public FSplineMeshInstanceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601072B RID: 67371 RVA: 0x001827EE File Offset: 0x001809EE
		public FSplineMeshInstanceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601072C RID: 67372 RVA: 0x001827F9 File Offset: 0x001809F9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSplineMeshInstanceData(Pointer, false, true);
		}

		// Token: 0x0601072D RID: 67373 RVA: 0x00182803 File Offset: 0x00180A03
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSplineMeshInstanceData(Pointer, MemoryOwner);
		}

		// Token: 0x04008CC1 RID: 36033
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SplineMeshInstanceData";

		// Token: 0x04008CC2 RID: 36034
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008CC3 RID: 36035
		internal static int __PropertyOffset_StartPos;

		// Token: 0x04008CC4 RID: 36036
		internal static int __PropertyOffset_EndPos;

		// Token: 0x04008CC5 RID: 36037
		internal static int __PropertyOffset_StartTangent;

		// Token: 0x04008CC6 RID: 36038
		internal static int __PropertyOffset_EndTangent;
	}
}
