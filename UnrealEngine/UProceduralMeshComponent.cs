using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007B8 RID: 1976
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ProceduralMeshComponent.ProceduralMeshComponent")]
	[UnrealStructLayout(1728, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1728)]
	public class UProceduralMeshComponent : UMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600AB7F RID: 43903 RVA: 0x000FCE9E File Offset: 0x000FB09E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UProceduralMeshComponent._ClassPtr;
		}

		// Token: 0x0600AB80 RID: 43904 RVA: 0x000FCEAC File Offset: 0x000FB0AC
		public UProceduralMeshComponent() : this(BuiltinUtils.AllocNativeUObject(UProceduralMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600AB81 RID: 43905 RVA: 0x000FCED4 File Offset: 0x000FB0D4
		public UProceduralMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UProceduralMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001FF3 RID: 8179
		// (get) Token: 0x0600AB82 RID: 43906 RVA: 0x000FCF07 File Offset: 0x000FB107
		// (set) Token: 0x0600AB83 RID: 43907 RVA: 0x000FCF17 File Offset: 0x000FB117
		public unsafe bool bUseComplexAsSimpleCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProceduralMeshComponent.__PropertyOffset_bUseComplexAsSimpleCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProceduralMeshComponent.__PropertyOffset_bUseComplexAsSimpleCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001FF4 RID: 8180
		// (get) Token: 0x0600AB84 RID: 43908 RVA: 0x000FCF28 File Offset: 0x000FB128
		// (set) Token: 0x0600AB85 RID: 43909 RVA: 0x000FCF38 File Offset: 0x000FB138
		public unsafe bool bUseAsyncCooking
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProceduralMeshComponent.__PropertyOffset_bUseAsyncCooking) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProceduralMeshComponent.__PropertyOffset_bUseAsyncCooking) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001FF5 RID: 8181
		// (get) Token: 0x0600AB86 RID: 43910 RVA: 0x000FCF49 File Offset: 0x000FB149
		// (set) Token: 0x0600AB87 RID: 43911 RVA: 0x000FCF59 File Offset: 0x000FB159
		public unsafe bool bUseFullPrecisionUVs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProceduralMeshComponent.__PropertyOffset_bUseFullPrecisionUVs) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProceduralMeshComponent.__PropertyOffset_bUseFullPrecisionUVs) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001FF6 RID: 8182
		// (get) Token: 0x0600AB88 RID: 43912 RVA: 0x000FCF6A File Offset: 0x000FB16A
		// (set) Token: 0x0600AB89 RID: 43913 RVA: 0x000FCF7E File Offset: 0x000FB17E
		[Nullable(2)]
		public unsafe UBodySetup ProcMeshBodySetup
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBodySetup>(base.NativePtr / (IntPtr)sizeof(void*) + UProceduralMeshComponent.__PropertyOffset_ProcMeshBodySetup);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UProceduralMeshComponent.__PropertyOffset_ProcMeshBodySetup, value);
			}
		}

		// Token: 0x17001FF7 RID: 8183
		// (get) Token: 0x0600AB8A RID: 43914 RVA: 0x000FCF93 File Offset: 0x000FB193
		// (set) Token: 0x0600AB8B RID: 43915 RVA: 0x000FCFA7 File Offset: 0x000FB1A7
		public unsafe FBoxSphereBounds LocalBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProceduralMeshComponent.__PropertyOffset_LocalBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProceduralMeshComponent.__PropertyOffset_LocalBounds) = value;
			}
		}

		// Token: 0x17001FF8 RID: 8184
		// (get) Token: 0x0600AB8C RID: 43916 RVA: 0x000FCFBC File Offset: 0x000FB1BC
		// (set) Token: 0x0600AB8D RID: 43917 RVA: 0x000FCFF5 File Offset: 0x000FB1F5
		public TArray<UBodySetup> AsyncBodySetupQueue
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UBodySetup> result;
				if ((result = this._AsyncBodySetupQueue) == null)
				{
					result = (this._AsyncBodySetupQueue = new TArray<UBodySetup>(base.NativePtr + (IntPtr)UProceduralMeshComponent.__PropertyOffset_AsyncBodySetupQueue, this));
				}
				return result;
			}
			set
			{
				this.AsyncBodySetupQueue.CopyAssign(value);
			}
		}

		// Token: 0x0600AB8E RID: 43918 RVA: 0x000FD003 File Offset: 0x000FB203
		public void SetUseFullPrecisionUVs(bool bNewUseFullPrecisionUVs)
		{
			UProceduralMeshComponent.__SetUseFullPrecisionUVs_Internal(base.NativePtr, bNewUseFullPrecisionUVs);
		}

		// Token: 0x0600AB8F RID: 43919 RVA: 0x000FD011 File Offset: 0x000FB211
		public void SetMeshSectionVisible(int SectionIndex, bool bNewVisibility)
		{
			UProceduralMeshComponent.__SetMeshSectionVisible_Internal(base.NativePtr, SectionIndex, bNewVisibility);
		}

		// Token: 0x0600AB90 RID: 43920 RVA: 0x000FD020 File Offset: 0x000FB220
		public bool IsMeshSectionVisible(int SectionIndex)
		{
			return UProceduralMeshComponent.__IsMeshSectionVisible_Internal(base.NativePtr, SectionIndex);
		}

		// Token: 0x0600AB91 RID: 43921 RVA: 0x000FD02E File Offset: 0x000FB22E
		public int GetNumSections()
		{
			return UProceduralMeshComponent.__GetNumSections_Internal(base.NativePtr);
		}

		// Token: 0x0600AB92 RID: 43922 RVA: 0x000FD03B File Offset: 0x000FB23B
		public void ClearMeshSection(int SectionIndex)
		{
			UProceduralMeshComponent.__ClearMeshSection_Internal(base.NativePtr, SectionIndex);
		}

		// Token: 0x0600AB93 RID: 43923 RVA: 0x000FD049 File Offset: 0x000FB249
		public void ClearCollisionConvexMeshes()
		{
			UProceduralMeshComponent.__ClearCollisionConvexMeshes_Internal(base.NativePtr);
		}

		// Token: 0x0600AB94 RID: 43924 RVA: 0x000FD056 File Offset: 0x000FB256
		public void ClearAllMeshSections()
		{
			UProceduralMeshComponent.__ClearAllMeshSections_Internal(base.NativePtr);
		}

		// Token: 0x0600AB95 RID: 43925 RVA: 0x000FD063 File Offset: 0x000FB263
		[NullableContext(2)]
		public void AddCollisionConvexMesh(TArray<FVector> ConvexVerts)
		{
			UProceduralMeshComponent.__AddCollisionConvexMesh_Internal(base.NativePtr, (ConvexVerts ?? new TArray<FVector>()).NativePtr);
		}

		// Token: 0x0600AB96 RID: 43926
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseFullPrecisionUVs_Internal(IntPtr @this, bool bNewUseFullPrecisionUVs);

		// Token: 0x0600AB97 RID: 43927
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMeshSectionVisible_Internal(IntPtr @this, int SectionIndex, bool bNewVisibility);

		// Token: 0x0600AB98 RID: 43928
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsMeshSectionVisible_Internal(IntPtr @this, int SectionIndex);

		// Token: 0x0600AB99 RID: 43929
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumSections_Internal(IntPtr @this);

		// Token: 0x0600AB9A RID: 43930
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearMeshSection_Internal(IntPtr @this, int SectionIndex);

		// Token: 0x0600AB9B RID: 43931
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearCollisionConvexMeshes_Internal(IntPtr @this);

		// Token: 0x0600AB9C RID: 43932
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAllMeshSections_Internal(IntPtr @this);

		// Token: 0x0600AB9D RID: 43933
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddCollisionConvexMesh_Internal(IntPtr @this, IntPtr ConvexVerts);

		// Token: 0x0600AB9E RID: 43934 RVA: 0x000FD07F File Offset: 0x000FB27F
		static UProceduralMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ProceduralMeshComponent.ProceduralMeshComponent");
		}

		// Token: 0x0600AB9F RID: 43935 RVA: 0x000FD08D File Offset: 0x000FB28D
		protected UProceduralMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040049AC RID: 18860
		public new const string __ObjectPath = "/Script/ProceduralMeshComponent.ProceduralMeshComponent";

		// Token: 0x040049AD RID: 18861
		private static IntPtr _ClassPtr;

		// Token: 0x040049AE RID: 18862
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040049AF RID: 18863
		internal static int __PropertyOffset_bUseComplexAsSimpleCollision;

		// Token: 0x040049B0 RID: 18864
		internal static int __PropertyOffset_bUseAsyncCooking;

		// Token: 0x040049B1 RID: 18865
		internal static int __PropertyOffset_bUseFullPrecisionUVs;

		// Token: 0x040049B2 RID: 18866
		internal static int __PropertyOffset_ProcMeshBodySetup;

		// Token: 0x040049B3 RID: 18867
		internal static int __PropertyOffset_LocalBounds;

		// Token: 0x040049B4 RID: 18868
		internal static int __PropertyOffset_AsyncBodySetupQueue;

		// Token: 0x040049B5 RID: 18869
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBodySetup> _AsyncBodySetupQueue;
	}
}
