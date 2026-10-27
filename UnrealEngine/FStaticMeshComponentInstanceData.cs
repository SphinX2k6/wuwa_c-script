using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001194 RID: 4500
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.StaticMeshComponentInstanceData")]
	[UnrealStructLayout(336, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 336)]
	public class FStaticMeshComponentInstanceData : FPrimitiveComponentInstanceData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601093D RID: 67901 RVA: 0x00185819 File Offset: 0x00183A19
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStaticMeshComponentInstanceData._ScriptStructPtr != 0) ? FStaticMeshComponentInstanceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StaticMeshComponentInstanceData", ref FStaticMeshComponentInstanceData._ScriptStructPtr);
		}

		// Token: 0x170040B5 RID: 16565
		// (get) Token: 0x0601093E RID: 67902 RVA: 0x0018583D File Offset: 0x00183A3D
		// (set) Token: 0x0601093F RID: 67903 RVA: 0x00185851 File Offset: 0x00183A51
		[Nullable(2)]
		public unsafe UStaticMesh StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FStaticMeshComponentInstanceData.__PropertyOffset_StaticMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FStaticMeshComponentInstanceData.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x170040B6 RID: 16566
		// (get) Token: 0x06010940 RID: 67904 RVA: 0x00185868 File Offset: 0x00183A68
		// (set) Token: 0x06010941 RID: 67905 RVA: 0x001858AB File Offset: 0x00183AAB
		public TArray<FStaticMeshVertexColorLODData> VertexColorLODs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FStaticMeshVertexColorLODData> result;
				if ((result = this._VertexColorLODs) == null)
				{
					result = (this._VertexColorLODs = new TArray<FStaticMeshVertexColorLODData>(base.NativePtr + (IntPtr)FStaticMeshComponentInstanceData.__PropertyOffset_VertexColorLODs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VertexColorLODs.CopyAssign(value);
			}
		}

		// Token: 0x170040B7 RID: 16567
		// (get) Token: 0x06010942 RID: 67906 RVA: 0x001858BC File Offset: 0x00183ABC
		// (set) Token: 0x06010943 RID: 67907 RVA: 0x001858FF File Offset: 0x00183AFF
		public TArray<FGuid> CachedStaticLighting
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGuid> result;
				if ((result = this._CachedStaticLighting) == null)
				{
					result = (this._CachedStaticLighting = new TArray<FGuid>(base.NativePtr + (IntPtr)FStaticMeshComponentInstanceData.__PropertyOffset_CachedStaticLighting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CachedStaticLighting.CopyAssign(value);
			}
		}

		// Token: 0x170040B8 RID: 16568
		// (get) Token: 0x06010944 RID: 67908 RVA: 0x00185910 File Offset: 0x00183B10
		// (set) Token: 0x06010945 RID: 67909 RVA: 0x00185953 File Offset: 0x00183B53
		public TArray<FStreamingTextureBuildInfo> StreamingTextureData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FStreamingTextureBuildInfo> result;
				if ((result = this._StreamingTextureData) == null)
				{
					result = (this._StreamingTextureData = new TArray<FStreamingTextureBuildInfo>(base.NativePtr + (IntPtr)FStaticMeshComponentInstanceData.__PropertyOffset_StreamingTextureData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StreamingTextureData.CopyAssign(value);
			}
		}

		// Token: 0x06010946 RID: 67910 RVA: 0x00185961 File Offset: 0x00183B61
		public FStaticMeshComponentInstanceData()
		{
		}

		// Token: 0x06010947 RID: 67911 RVA: 0x0018596C File Offset: 0x00183B6C
		public FStaticMeshComponentInstanceData(UStaticMesh StaticMesh, TArray<FStaticMeshVertexColorLODData> VertexColorLODs, TArray<FGuid> CachedStaticLighting, TArray<FStreamingTextureBuildInfo> StreamingTextureData, TArray<uint> MaterialStreamingRelativeBoxes, FTransform ComponentTransform, int VisibilityId, UPrimitiveComponent LODParent, TMap<USceneComponent, FTransform> AttachedInstanceComponents, UObject SourceComponentTemplate, EComponentCreationMethod SourceComponentCreationMethod, int SourceComponentTypeSerializedIndex, TArray<byte> SavedProperties, FActorComponentDuplicatedObjectData UniqueTransientPackage, TArray<FActorComponentDuplicatedObjectData> DuplicatedObjects, TArray<UObject> ReferencedObjects, TArray<FName> ReferencedNames)
		{
			this.StaticMesh = StaticMesh;
			this.VertexColorLODs = VertexColorLODs;
			this.CachedStaticLighting = CachedStaticLighting;
			this.StreamingTextureData = StreamingTextureData;
			base.ComponentTransform = ComponentTransform;
			base.VisibilityId = VisibilityId;
			base.LODParent = LODParent;
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

		// Token: 0x06010948 RID: 67912 RVA: 0x001859FC File Offset: 0x00183BFC
		protected override IntPtr GetUStructPtr()
		{
			return FStaticMeshComponentInstanceData.StaticStruct();
		}

		// Token: 0x06010949 RID: 67913 RVA: 0x00185A08 File Offset: 0x00183C08
		[NullableContext(2)]
		public FStaticMeshComponentInstanceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601094A RID: 67914 RVA: 0x00185A12 File Offset: 0x00183C12
		public FStaticMeshComponentInstanceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601094B RID: 67915 RVA: 0x00185A1D File Offset: 0x00183C1D
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStaticMeshComponentInstanceData(Pointer, false, true);
		}

		// Token: 0x0601094C RID: 67916 RVA: 0x00185A27 File Offset: 0x00183C27
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStaticMeshComponentInstanceData(Pointer, MemoryOwner);
		}

		// Token: 0x04008DE5 RID: 36325
		public new const string __ObjectPath = "/Script/Engine.StaticMeshComponentInstanceData";

		// Token: 0x04008DE6 RID: 36326
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008DE7 RID: 36327
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x04008DE8 RID: 36328
		internal static int __PropertyOffset_VertexColorLODs;

		// Token: 0x04008DE9 RID: 36329
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FStaticMeshVertexColorLODData> _VertexColorLODs;

		// Token: 0x04008DEA RID: 36330
		internal static int __PropertyOffset_CachedStaticLighting;

		// Token: 0x04008DEB RID: 36331
		[Nullable(2)]
		private TArray<FGuid> _CachedStaticLighting;

		// Token: 0x04008DEC RID: 36332
		internal static int __PropertyOffset_StreamingTextureData;

		// Token: 0x04008DED RID: 36333
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FStreamingTextureBuildInfo> _StreamingTextureData;
	}
}
