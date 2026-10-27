using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200220F RID: 8719
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkMeshStaticData")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FLiveLinkMeshStaticData : FLiveLinkBaseStaticData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021363 RID: 136035 RVA: 0x0030F6F2 File Offset: 0x0030D8F2
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkMeshStaticData._ScriptStructPtr != 0) ? FLiveLinkMeshStaticData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkMeshStaticData", ref FLiveLinkMeshStaticData._ScriptStructPtr);
		}

		// Token: 0x170081A2 RID: 33186
		// (get) Token: 0x06021364 RID: 136036 RVA: 0x0030F716 File Offset: 0x0030D916
		// (set) Token: 0x06021365 RID: 136037 RVA: 0x0030F726 File Offset: 0x0030D926
		public unsafe int LODIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkMeshStaticData.__PropertyOffset_LODIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkMeshStaticData.__PropertyOffset_LODIndex) = value;
			}
		}

		// Token: 0x170081A3 RID: 33187
		// (get) Token: 0x06021366 RID: 136038 RVA: 0x0030F737 File Offset: 0x0030D937
		// (set) Token: 0x06021367 RID: 136039 RVA: 0x0030F747 File Offset: 0x0030D947
		public unsafe int SectionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkMeshStaticData.__PropertyOffset_SectionIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkMeshStaticData.__PropertyOffset_SectionIndex) = value;
			}
		}

		// Token: 0x170081A4 RID: 33188
		// (get) Token: 0x06021368 RID: 136040 RVA: 0x0030F758 File Offset: 0x0030D958
		// (set) Token: 0x06021369 RID: 136041 RVA: 0x0030F76C File Offset: 0x0030D96C
		public unsafe string SectionName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLiveLinkMeshStaticData.__PropertyOffset_SectionName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLiveLinkMeshStaticData.__PropertyOffset_SectionName)), value);
			}
		}

		// Token: 0x170081A5 RID: 33189
		// (get) Token: 0x0602136A RID: 136042 RVA: 0x0030F781 File Offset: 0x0030D981
		// (set) Token: 0x0602136B RID: 136043 RVA: 0x0030F791 File Offset: 0x0030D991
		public unsafe int NumVertices
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkMeshStaticData.__PropertyOffset_NumVertices);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkMeshStaticData.__PropertyOffset_NumVertices) = value;
			}
		}

		// Token: 0x170081A6 RID: 33190
		// (get) Token: 0x0602136C RID: 136044 RVA: 0x0030F7A2 File Offset: 0x0030D9A2
		// (set) Token: 0x0602136D RID: 136045 RVA: 0x0030F7B2 File Offset: 0x0030D9B2
		public unsafe int NumEdges
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkMeshStaticData.__PropertyOffset_NumEdges);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkMeshStaticData.__PropertyOffset_NumEdges) = value;
			}
		}

		// Token: 0x170081A7 RID: 33191
		// (get) Token: 0x0602136E RID: 136046 RVA: 0x0030F7C3 File Offset: 0x0030D9C3
		// (set) Token: 0x0602136F RID: 136047 RVA: 0x0030F7D3 File Offset: 0x0030D9D3
		public unsafe int NumPolygons
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkMeshStaticData.__PropertyOffset_NumPolygons);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkMeshStaticData.__PropertyOffset_NumPolygons) = value;
			}
		}

		// Token: 0x170081A8 RID: 33192
		// (get) Token: 0x06021370 RID: 136048 RVA: 0x0030F7E4 File Offset: 0x0030D9E4
		// (set) Token: 0x06021371 RID: 136049 RVA: 0x0030F7F4 File Offset: 0x0030D9F4
		public unsafe int NumUVs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkMeshStaticData.__PropertyOffset_NumUVs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkMeshStaticData.__PropertyOffset_NumUVs) = value;
			}
		}

		// Token: 0x170081A9 RID: 33193
		// (get) Token: 0x06021372 RID: 136050 RVA: 0x0030F805 File Offset: 0x0030DA05
		// (set) Token: 0x06021373 RID: 136051 RVA: 0x0030F815 File Offset: 0x0030DA15
		public unsafe int NumNormals
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkMeshStaticData.__PropertyOffset_NumNormals);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkMeshStaticData.__PropertyOffset_NumNormals) = value;
			}
		}

		// Token: 0x06021374 RID: 136052 RVA: 0x0030F826 File Offset: 0x0030DA26
		public FLiveLinkMeshStaticData()
		{
		}

		// Token: 0x06021375 RID: 136053 RVA: 0x0030F830 File Offset: 0x0030DA30
		public FLiveLinkMeshStaticData(int LODIndex, int SectionIndex, string SectionName, int NumVertices, int NumEdges, int NumPolygons, int NumUVs, int NumNormals, TArray<FName> PropertyNames)
		{
			this.LODIndex = LODIndex;
			this.SectionIndex = SectionIndex;
			this.SectionName = SectionName;
			this.NumVertices = NumVertices;
			this.NumEdges = NumEdges;
			this.NumPolygons = NumPolygons;
			this.NumUVs = NumUVs;
			this.NumNormals = NumNormals;
			base.PropertyNames = PropertyNames;
		}

		// Token: 0x06021376 RID: 136054 RVA: 0x0030F888 File Offset: 0x0030DA88
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkMeshStaticData.StaticStruct();
		}

		// Token: 0x06021377 RID: 136055 RVA: 0x0030F894 File Offset: 0x0030DA94
		[NullableContext(2)]
		public FLiveLinkMeshStaticData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021378 RID: 136056 RVA: 0x0030F89E File Offset: 0x0030DA9E
		public FLiveLinkMeshStaticData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021379 RID: 136057 RVA: 0x0030F8A9 File Offset: 0x0030DAA9
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkMeshStaticData(Pointer, false, true);
		}

		// Token: 0x0602137A RID: 136058 RVA: 0x0030F8B3 File Offset: 0x0030DAB3
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkMeshStaticData(Pointer, MemoryOwner);
		}

		// Token: 0x04011B7B RID: 72571
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkMeshStaticData";

		// Token: 0x04011B7C RID: 72572
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011B7D RID: 72573
		internal static int __PropertyOffset_LODIndex;

		// Token: 0x04011B7E RID: 72574
		internal static int __PropertyOffset_SectionIndex;

		// Token: 0x04011B7F RID: 72575
		internal static int __PropertyOffset_SectionName;

		// Token: 0x04011B80 RID: 72576
		internal static int __PropertyOffset_NumVertices;

		// Token: 0x04011B81 RID: 72577
		internal static int __PropertyOffset_NumEdges;

		// Token: 0x04011B82 RID: 72578
		internal static int __PropertyOffset_NumPolygons;

		// Token: 0x04011B83 RID: 72579
		internal static int __PropertyOffset_NumUVs;

		// Token: 0x04011B84 RID: 72580
		internal static int __PropertyOffset_NumNormals;
	}
}
