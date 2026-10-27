using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002285 RID: 8837
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MagtModule.QualityCollectionGraph")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FQualityCollectionGraph : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021998 RID: 137624 RVA: 0x0031B624 File Offset: 0x00319824
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FQualityCollectionGraph._ScriptStructPtr != 0) ? FQualityCollectionGraph._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MagtModule.QualityCollectionGraph", ref FQualityCollectionGraph._ScriptStructPtr);
		}

		// Token: 0x1700828B RID: 33419
		// (get) Token: 0x06021999 RID: 137625 RVA: 0x0031B648 File Offset: 0x00319848
		// (set) Token: 0x0602199A RID: 137626 RVA: 0x0031B65C File Offset: 0x0031985C
		public unsafe string GraphName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FQualityCollectionGraph.__PropertyOffset_GraphName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FQualityCollectionGraph.__PropertyOffset_GraphName)), value);
			}
		}

		// Token: 0x1700828C RID: 33420
		// (get) Token: 0x0602199B RID: 137627 RVA: 0x0031B674 File Offset: 0x00319874
		// (set) Token: 0x0602199C RID: 137628 RVA: 0x0031B6B7 File Offset: 0x003198B7
		public TMap<EPerformJudgement, FQualitySettingCollection> CollectionGraph
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EPerformJudgement, FQualitySettingCollection> result;
				if ((result = this._CollectionGraph) == null)
				{
					result = (this._CollectionGraph = new TMap<EPerformJudgement, FQualitySettingCollection>(base.NativePtr + (IntPtr)FQualityCollectionGraph.__PropertyOffset_CollectionGraph, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CollectionGraph.CopyAssign(value);
			}
		}

		// Token: 0x0602199D RID: 137629 RVA: 0x0031B6C5 File Offset: 0x003198C5
		public FQualityCollectionGraph()
		{
		}

		// Token: 0x0602199E RID: 137630 RVA: 0x0031B6CD File Offset: 0x003198CD
		public FQualityCollectionGraph(string GraphName, TMap<EPerformJudgement, FQualitySettingCollection> CollectionGraph)
		{
			this.GraphName = GraphName;
			this.CollectionGraph = CollectionGraph;
		}

		// Token: 0x0602199F RID: 137631 RVA: 0x0031B6E3 File Offset: 0x003198E3
		protected override IntPtr GetUStructPtr()
		{
			return FQualityCollectionGraph.StaticStruct();
		}

		// Token: 0x060219A0 RID: 137632 RVA: 0x0031B6EF File Offset: 0x003198EF
		[NullableContext(2)]
		public FQualityCollectionGraph(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060219A1 RID: 137633 RVA: 0x0031B6F9 File Offset: 0x003198F9
		public FQualityCollectionGraph(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060219A2 RID: 137634 RVA: 0x0031B704 File Offset: 0x00319904
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FQualityCollectionGraph(Pointer, false, true);
		}

		// Token: 0x060219A3 RID: 137635 RVA: 0x0031B70E File Offset: 0x0031990E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FQualityCollectionGraph(Pointer, MemoryOwner);
		}

		// Token: 0x04011F0B RID: 73483
		public const string __ObjectPath = "/Script/MagtModule.QualityCollectionGraph";

		// Token: 0x04011F0C RID: 73484
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011F0D RID: 73485
		internal static int __PropertyOffset_GraphName;

		// Token: 0x04011F0E RID: 73486
		internal static int __PropertyOffset_CollectionGraph;

		// Token: 0x04011F0F RID: 73487
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EPerformJudgement, FQualitySettingCollection> _CollectionGraph;
	}
}
