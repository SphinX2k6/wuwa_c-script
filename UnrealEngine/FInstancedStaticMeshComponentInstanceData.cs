using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C63 RID: 3171
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InstancedStaticMeshComponentInstanceData")]
	[UnrealStructLayout(336, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 336)]
	public class FInstancedStaticMeshComponentInstanceData : FSceneComponentInstanceData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A150 RID: 41296 RVA: 0x000E52C8 File Offset: 0x000E34C8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInstancedStaticMeshComponentInstanceData._ScriptStructPtr != 0) ? FInstancedStaticMeshComponentInstanceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InstancedStaticMeshComponentInstanceData", ref FInstancedStaticMeshComponentInstanceData._ScriptStructPtr);
		}

		// Token: 0x1700266A RID: 9834
		// (get) Token: 0x0600A151 RID: 41297 RVA: 0x000E52EC File Offset: 0x000E34EC
		// (set) Token: 0x0600A152 RID: 41298 RVA: 0x000E5300 File Offset: 0x000E3500
		[Nullable(2)]
		public unsafe UStaticMesh StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FInstancedStaticMeshComponentInstanceData.__PropertyOffset_StaticMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FInstancedStaticMeshComponentInstanceData.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x1700266B RID: 9835
		// (get) Token: 0x0600A153 RID: 41299 RVA: 0x000E5318 File Offset: 0x000E3518
		// (set) Token: 0x0600A154 RID: 41300 RVA: 0x000E535B File Offset: 0x000E355B
		public FInstancedStaticMeshLightMapInstanceData CachedStaticLighting
		{
			get
			{
				base.FastCheckIsValid();
				FInstancedStaticMeshLightMapInstanceData result;
				if ((result = this._CachedStaticLighting) == null)
				{
					result = (this._CachedStaticLighting = new FInstancedStaticMeshLightMapInstanceData(base.NativePtr + (IntPtr)FInstancedStaticMeshComponentInstanceData.__PropertyOffset_CachedStaticLighting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInstancedStaticMeshLightMapInstanceData.StaticStruct(), base.NativePtr + (IntPtr)FInstancedStaticMeshComponentInstanceData.__PropertyOffset_CachedStaticLighting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700266C RID: 9836
		// (get) Token: 0x0600A155 RID: 41301 RVA: 0x000E537C File Offset: 0x000E357C
		// (set) Token: 0x0600A156 RID: 41302 RVA: 0x000E53BF File Offset: 0x000E35BF
		public TArray<FInstancedStaticMeshInstanceData> PerInstanceSMData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FInstancedStaticMeshInstanceData> result;
				if ((result = this._PerInstanceSMData) == null)
				{
					result = (this._PerInstanceSMData = new TArray<FInstancedStaticMeshInstanceData>(base.NativePtr + (IntPtr)FInstancedStaticMeshComponentInstanceData.__PropertyOffset_PerInstanceSMData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PerInstanceSMData.CopyAssign(value);
			}
		}

		// Token: 0x1700266D RID: 9837
		// (get) Token: 0x0600A157 RID: 41303 RVA: 0x000E53D0 File Offset: 0x000E35D0
		// (set) Token: 0x0600A158 RID: 41304 RVA: 0x000E5413 File Offset: 0x000E3613
		public TArray<float> PerInstanceSMCustomData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._PerInstanceSMCustomData) == null)
				{
					result = (this._PerInstanceSMCustomData = new TArray<float>(base.NativePtr + (IntPtr)FInstancedStaticMeshComponentInstanceData.__PropertyOffset_PerInstanceSMCustomData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PerInstanceSMCustomData.CopyAssign(value);
			}
		}

		// Token: 0x1700266E RID: 9838
		// (get) Token: 0x0600A159 RID: 41305 RVA: 0x000E5421 File Offset: 0x000E3621
		// (set) Token: 0x0600A15A RID: 41306 RVA: 0x000E5431 File Offset: 0x000E3631
		public unsafe int InstancingRandomSeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInstancedStaticMeshComponentInstanceData.__PropertyOffset_InstancingRandomSeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInstancedStaticMeshComponentInstanceData.__PropertyOffset_InstancingRandomSeed) = value;
			}
		}

		// Token: 0x0600A15B RID: 41307 RVA: 0x000E5442 File Offset: 0x000E3642
		public FInstancedStaticMeshComponentInstanceData()
		{
		}

		// Token: 0x0600A15C RID: 41308 RVA: 0x000E544C File Offset: 0x000E364C
		public FInstancedStaticMeshComponentInstanceData(UStaticMesh StaticMesh, FInstancedStaticMeshLightMapInstanceData CachedStaticLighting, TArray<FInstancedStaticMeshInstanceData> PerInstanceSMData, TArray<float> PerInstanceSMCustomData, int InstancingRandomSeed, TMap<USceneComponent, FTransform> AttachedInstanceComponents, UObject SourceComponentTemplate, EComponentCreationMethod SourceComponentCreationMethod, int SourceComponentTypeSerializedIndex, TArray<byte> SavedProperties, FActorComponentDuplicatedObjectData UniqueTransientPackage, TArray<FActorComponentDuplicatedObjectData> DuplicatedObjects, TArray<UObject> ReferencedObjects, TArray<FName> ReferencedNames)
		{
			this.StaticMesh = StaticMesh;
			this.CachedStaticLighting = CachedStaticLighting;
			this.PerInstanceSMData = PerInstanceSMData;
			this.PerInstanceSMCustomData = PerInstanceSMCustomData;
			this.InstancingRandomSeed = InstancingRandomSeed;
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

		// Token: 0x0600A15D RID: 41309 RVA: 0x000E54CC File Offset: 0x000E36CC
		protected override IntPtr GetUStructPtr()
		{
			return FInstancedStaticMeshComponentInstanceData.StaticStruct();
		}

		// Token: 0x0600A15E RID: 41310 RVA: 0x000E54D8 File Offset: 0x000E36D8
		[NullableContext(2)]
		public FInstancedStaticMeshComponentInstanceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A15F RID: 41311 RVA: 0x000E54E2 File Offset: 0x000E36E2
		public FInstancedStaticMeshComponentInstanceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A160 RID: 41312 RVA: 0x000E54ED File Offset: 0x000E36ED
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInstancedStaticMeshComponentInstanceData(Pointer, false, true);
		}

		// Token: 0x0600A161 RID: 41313 RVA: 0x000E54F7 File Offset: 0x000E36F7
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInstancedStaticMeshComponentInstanceData(Pointer, MemoryOwner);
		}

		// Token: 0x0400589F RID: 22687
		public new const string __ObjectPath = "/Script/Engine.InstancedStaticMeshComponentInstanceData";

		// Token: 0x040058A0 RID: 22688
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040058A1 RID: 22689
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x040058A2 RID: 22690
		internal static int __PropertyOffset_CachedStaticLighting;

		// Token: 0x040058A3 RID: 22691
		[Nullable(2)]
		private FInstancedStaticMeshLightMapInstanceData _CachedStaticLighting;

		// Token: 0x040058A4 RID: 22692
		internal static int __PropertyOffset_PerInstanceSMData;

		// Token: 0x040058A5 RID: 22693
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FInstancedStaticMeshInstanceData> _PerInstanceSMData;

		// Token: 0x040058A6 RID: 22694
		internal static int __PropertyOffset_PerInstanceSMCustomData;

		// Token: 0x040058A7 RID: 22695
		[Nullable(2)]
		private TArray<float> _PerInstanceSMCustomData;

		// Token: 0x040058A8 RID: 22696
		internal static int __PropertyOffset_InstancingRandomSeed;
	}
}
