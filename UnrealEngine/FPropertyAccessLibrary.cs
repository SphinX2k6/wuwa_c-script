using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002668 RID: 9832
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/PropertyAccess.PropertyAccessLibrary")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 200)]
	public class FPropertyAccessLibrary : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602488B RID: 149643 RVA: 0x003615B9 File Offset: 0x0035F7B9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPropertyAccessLibrary._ScriptStructPtr != 0) ? FPropertyAccessLibrary._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/PropertyAccess.PropertyAccessLibrary", ref FPropertyAccessLibrary._ScriptStructPtr);
		}

		// Token: 0x17008CD0 RID: 36048
		// (get) Token: 0x0602488C RID: 149644 RVA: 0x003615E0 File Offset: 0x0035F7E0
		// (set) Token: 0x0602488D RID: 149645 RVA: 0x00361623 File Offset: 0x0035F823
		public TArray<FPropertyAccessSegment> PathSegments
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPropertyAccessSegment> result;
				if ((result = this._PathSegments) == null)
				{
					result = (this._PathSegments = new TArray<FPropertyAccessSegment>(base.NativePtr + (IntPtr)FPropertyAccessLibrary.__PropertyOffset_PathSegments, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PathSegments.CopyAssign(value);
			}
		}

		// Token: 0x17008CD1 RID: 36049
		// (get) Token: 0x0602488E RID: 149646 RVA: 0x00361634 File Offset: 0x0035F834
		// (set) Token: 0x0602488F RID: 149647 RVA: 0x00361677 File Offset: 0x0035F877
		public TArray<FPropertyAccessPath> SrcPaths
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPropertyAccessPath> result;
				if ((result = this._SrcPaths) == null)
				{
					result = (this._SrcPaths = new TArray<FPropertyAccessPath>(base.NativePtr + (IntPtr)FPropertyAccessLibrary.__PropertyOffset_SrcPaths, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SrcPaths.CopyAssign(value);
			}
		}

		// Token: 0x17008CD2 RID: 36050
		// (get) Token: 0x06024890 RID: 149648 RVA: 0x00361688 File Offset: 0x0035F888
		// (set) Token: 0x06024891 RID: 149649 RVA: 0x003616CB File Offset: 0x0035F8CB
		public TArray<FPropertyAccessPath> DestPaths
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPropertyAccessPath> result;
				if ((result = this._DestPaths) == null)
				{
					result = (this._DestPaths = new TArray<FPropertyAccessPath>(base.NativePtr + (IntPtr)FPropertyAccessLibrary.__PropertyOffset_DestPaths, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DestPaths.CopyAssign(value);
			}
		}

		// Token: 0x17008CD3 RID: 36051
		// (get) Token: 0x06024892 RID: 149650 RVA: 0x003616DC File Offset: 0x0035F8DC
		// (set) Token: 0x06024893 RID: 149651 RVA: 0x00361720 File Offset: 0x0035F920
		public TFixedArray<FPropertyAccessCopyBatch> CopyBatches
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FPropertyAccessCopyBatch> result;
				if ((result = this._CopyBatches) == null)
				{
					result = (this._CopyBatches = new TFixedArray<FPropertyAccessCopyBatch>(base.NativePtr + (IntPtr)FPropertyAccessLibrary.__PropertyOffset_CopyBatches, 4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CopyBatches.CopyAssign(value);
			}
		}

		// Token: 0x17008CD4 RID: 36052
		// (get) Token: 0x06024894 RID: 149652 RVA: 0x00361730 File Offset: 0x0035F930
		// (set) Token: 0x06024895 RID: 149653 RVA: 0x00361773 File Offset: 0x0035F973
		public TArray<FPropertyAccessIndirectionChain> SrcAccesses
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPropertyAccessIndirectionChain> result;
				if ((result = this._SrcAccesses) == null)
				{
					result = (this._SrcAccesses = new TArray<FPropertyAccessIndirectionChain>(base.NativePtr + (IntPtr)FPropertyAccessLibrary.__PropertyOffset_SrcAccesses, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SrcAccesses.CopyAssign(value);
			}
		}

		// Token: 0x17008CD5 RID: 36053
		// (get) Token: 0x06024896 RID: 149654 RVA: 0x00361784 File Offset: 0x0035F984
		// (set) Token: 0x06024897 RID: 149655 RVA: 0x003617C7 File Offset: 0x0035F9C7
		public TArray<FPropertyAccessIndirectionChain> DestAccesses
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPropertyAccessIndirectionChain> result;
				if ((result = this._DestAccesses) == null)
				{
					result = (this._DestAccesses = new TArray<FPropertyAccessIndirectionChain>(base.NativePtr + (IntPtr)FPropertyAccessLibrary.__PropertyOffset_DestAccesses, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DestAccesses.CopyAssign(value);
			}
		}

		// Token: 0x17008CD6 RID: 36054
		// (get) Token: 0x06024898 RID: 149656 RVA: 0x003617D8 File Offset: 0x0035F9D8
		// (set) Token: 0x06024899 RID: 149657 RVA: 0x0036181B File Offset: 0x0035FA1B
		public TArray<FPropertyAccessIndirection> Indirections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPropertyAccessIndirection> result;
				if ((result = this._Indirections) == null)
				{
					result = (this._Indirections = new TArray<FPropertyAccessIndirection>(base.NativePtr + (IntPtr)FPropertyAccessLibrary.__PropertyOffset_Indirections, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Indirections.CopyAssign(value);
			}
		}

		// Token: 0x17008CD7 RID: 36055
		// (get) Token: 0x0602489A RID: 149658 RVA: 0x0036182C File Offset: 0x0035FA2C
		// (set) Token: 0x0602489B RID: 149659 RVA: 0x0036186F File Offset: 0x0035FA6F
		public TArray<int> EventAccessIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._EventAccessIndices) == null)
				{
					result = (this._EventAccessIndices = new TArray<int>(base.NativePtr + (IntPtr)FPropertyAccessLibrary.__PropertyOffset_EventAccessIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EventAccessIndices.CopyAssign(value);
			}
		}

		// Token: 0x0602489C RID: 149660 RVA: 0x0036187D File Offset: 0x0035FA7D
		public FPropertyAccessLibrary()
		{
		}

		// Token: 0x0602489D RID: 149661 RVA: 0x00361888 File Offset: 0x0035FA88
		public FPropertyAccessLibrary(TArray<FPropertyAccessSegment> PathSegments, TArray<FPropertyAccessPath> SrcPaths, TArray<FPropertyAccessPath> DestPaths, TFixedArray<FPropertyAccessCopyBatch> CopyBatches, TArray<FPropertyAccessIndirectionChain> SrcAccesses, TArray<FPropertyAccessIndirectionChain> DestAccesses, TArray<FPropertyAccessIndirection> Indirections, TArray<int> EventAccessIndices)
		{
			this.PathSegments = PathSegments;
			this.SrcPaths = SrcPaths;
			this.DestPaths = DestPaths;
			this.CopyBatches = CopyBatches;
			this.SrcAccesses = SrcAccesses;
			this.DestAccesses = DestAccesses;
			this.Indirections = Indirections;
			this.EventAccessIndices = EventAccessIndices;
		}

		// Token: 0x0602489E RID: 149662 RVA: 0x003618D8 File Offset: 0x0035FAD8
		protected override IntPtr GetUStructPtr()
		{
			return FPropertyAccessLibrary.StaticStruct();
		}

		// Token: 0x0602489F RID: 149663 RVA: 0x003618E4 File Offset: 0x0035FAE4
		[NullableContext(2)]
		public FPropertyAccessLibrary(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060248A0 RID: 149664 RVA: 0x003618EE File Offset: 0x0035FAEE
		public FPropertyAccessLibrary(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060248A1 RID: 149665 RVA: 0x003618F9 File Offset: 0x0035FAF9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPropertyAccessLibrary(Pointer, false, true);
		}

		// Token: 0x060248A2 RID: 149666 RVA: 0x00361903 File Offset: 0x0035FB03
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPropertyAccessLibrary(Pointer, MemoryOwner);
		}

		// Token: 0x04013A10 RID: 80400
		public const string __ObjectPath = "/Script/PropertyAccess.PropertyAccessLibrary";

		// Token: 0x04013A11 RID: 80401
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013A12 RID: 80402
		internal static int __PropertyOffset_PathSegments;

		// Token: 0x04013A13 RID: 80403
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPropertyAccessSegment> _PathSegments;

		// Token: 0x04013A14 RID: 80404
		internal static int __PropertyOffset_SrcPaths;

		// Token: 0x04013A15 RID: 80405
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPropertyAccessPath> _SrcPaths;

		// Token: 0x04013A16 RID: 80406
		internal static int __PropertyOffset_DestPaths;

		// Token: 0x04013A17 RID: 80407
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPropertyAccessPath> _DestPaths;

		// Token: 0x04013A18 RID: 80408
		internal static int __PropertyOffset_CopyBatches;

		// Token: 0x04013A19 RID: 80409
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FPropertyAccessCopyBatch> _CopyBatches;

		// Token: 0x04013A1A RID: 80410
		internal static int __PropertyOffset_SrcAccesses;

		// Token: 0x04013A1B RID: 80411
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPropertyAccessIndirectionChain> _SrcAccesses;

		// Token: 0x04013A1C RID: 80412
		internal static int __PropertyOffset_DestAccesses;

		// Token: 0x04013A1D RID: 80413
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPropertyAccessIndirectionChain> _DestAccesses;

		// Token: 0x04013A1E RID: 80414
		internal static int __PropertyOffset_Indirections;

		// Token: 0x04013A1F RID: 80415
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPropertyAccessIndirection> _Indirections;

		// Token: 0x04013A20 RID: 80416
		internal static int __PropertyOffset_EventAccessIndices;

		// Token: 0x04013A21 RID: 80417
		[Nullable(2)]
		private TArray<int> _EventAccessIndices;
	}
}
