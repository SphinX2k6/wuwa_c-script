using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200270A RID: 9994
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.QteSpineInfo")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FQteSpineInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060250DB RID: 151771 RVA: 0x0036D770 File Offset: 0x0036B970
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FQteSpineInfo._ScriptStructPtr != 0) ? FQteSpineInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.QteSpineInfo", ref FQteSpineInfo._ScriptStructPtr);
		}

		// Token: 0x17008EF6 RID: 36598
		// (get) Token: 0x060250DC RID: 151772 RVA: 0x0036D794 File Offset: 0x0036B994
		// (set) Token: 0x060250DD RID: 151773 RVA: 0x0036D7D7 File Offset: 0x0036B9D7
		public TArray<FSpineData> StartLoopSpines
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSpineData> result;
				if ((result = this._StartLoopSpines) == null)
				{
					result = (this._StartLoopSpines = new TArray<FSpineData>(base.NativePtr + (IntPtr)FQteSpineInfo.__PropertyOffset_StartLoopSpines, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StartLoopSpines.CopyAssign(value);
			}
		}

		// Token: 0x17008EF7 RID: 36599
		// (get) Token: 0x060250DE RID: 151774 RVA: 0x0036D7E8 File Offset: 0x0036B9E8
		// (set) Token: 0x060250DF RID: 151775 RVA: 0x0036D82B File Offset: 0x0036BA2B
		public TArray<FSpineData> ProgressSpine
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSpineData> result;
				if ((result = this._ProgressSpine) == null)
				{
					result = (this._ProgressSpine = new TArray<FSpineData>(base.NativePtr + (IntPtr)FQteSpineInfo.__PropertyOffset_ProgressSpine, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ProgressSpine.CopyAssign(value);
			}
		}

		// Token: 0x17008EF8 RID: 36600
		// (get) Token: 0x060250E0 RID: 151776 RVA: 0x0036D83C File Offset: 0x0036BA3C
		// (set) Token: 0x060250E1 RID: 151777 RVA: 0x0036D87F File Offset: 0x0036BA7F
		public TArray<FQteProgressSpineSegment> ProgressSpineSegments
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FQteProgressSpineSegment> result;
				if ((result = this._ProgressSpineSegments) == null)
				{
					result = (this._ProgressSpineSegments = new TArray<FQteProgressSpineSegment>(base.NativePtr + (IntPtr)FQteSpineInfo.__PropertyOffset_ProgressSpineSegments, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ProgressSpineSegments.CopyAssign(value);
			}
		}

		// Token: 0x17008EF9 RID: 36601
		// (get) Token: 0x060250E2 RID: 151778 RVA: 0x0036D890 File Offset: 0x0036BA90
		// (set) Token: 0x060250E3 RID: 151779 RVA: 0x0036D8D3 File Offset: 0x0036BAD3
		public TArray<FSpineData> EndSpine
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSpineData> result;
				if ((result = this._EndSpine) == null)
				{
					result = (this._EndSpine = new TArray<FSpineData>(base.NativePtr + (IntPtr)FQteSpineInfo.__PropertyOffset_EndSpine, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EndSpine.CopyAssign(value);
			}
		}

		// Token: 0x17008EFA RID: 36602
		// (get) Token: 0x060250E4 RID: 151780 RVA: 0x0036D8E4 File Offset: 0x0036BAE4
		// (set) Token: 0x060250E5 RID: 151781 RVA: 0x0036D927 File Offset: 0x0036BB27
		public TArray<FSpineData> SuccessSpine
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSpineData> result;
				if ((result = this._SuccessSpine) == null)
				{
					result = (this._SuccessSpine = new TArray<FSpineData>(base.NativePtr + (IntPtr)FQteSpineInfo.__PropertyOffset_SuccessSpine, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SuccessSpine.CopyAssign(value);
			}
		}

		// Token: 0x17008EFB RID: 36603
		// (get) Token: 0x060250E6 RID: 151782 RVA: 0x0036D938 File Offset: 0x0036BB38
		// (set) Token: 0x060250E7 RID: 151783 RVA: 0x0036D97B File Offset: 0x0036BB7B
		public TArray<FSpineData> FailSpine
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSpineData> result;
				if ((result = this._FailSpine) == null)
				{
					result = (this._FailSpine = new TArray<FSpineData>(base.NativePtr + (IntPtr)FQteSpineInfo.__PropertyOffset_FailSpine, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FailSpine.CopyAssign(value);
			}
		}

		// Token: 0x17008EFC RID: 36604
		// (get) Token: 0x060250E8 RID: 151784 RVA: 0x0036D989 File Offset: 0x0036BB89
		// (set) Token: 0x060250E9 RID: 151785 RVA: 0x0036D999 File Offset: 0x0036BB99
		public unsafe bool WaitEndSpineFinish
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQteSpineInfo.__PropertyOffset_WaitEndSpineFinish) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQteSpineInfo.__PropertyOffset_WaitEndSpineFinish) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008EFD RID: 36605
		// (get) Token: 0x060250EA RID: 151786 RVA: 0x0036D9AC File Offset: 0x0036BBAC
		// (set) Token: 0x060250EB RID: 151787 RVA: 0x0036D9EF File Offset: 0x0036BBEF
		public TArray<string> NiagaraParamNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._NiagaraParamNames) == null)
				{
					result = (this._NiagaraParamNames = new TArray<string>(base.NativePtr + (IntPtr)FQteSpineInfo.__PropertyOffset_NiagaraParamNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NiagaraParamNames.CopyAssign(value);
			}
		}

		// Token: 0x060250EC RID: 151788 RVA: 0x0036D9FD File Offset: 0x0036BBFD
		public FQteSpineInfo()
		{
		}

		// Token: 0x060250ED RID: 151789 RVA: 0x0036DA08 File Offset: 0x0036BC08
		public FQteSpineInfo(TArray<FSpineData> StartLoopSpines, TArray<FSpineData> ProgressSpine, TArray<FQteProgressSpineSegment> ProgressSpineSegments, TArray<FSpineData> EndSpine, TArray<FSpineData> SuccessSpine, TArray<FSpineData> FailSpine, bool WaitEndSpineFinish, TArray<string> NiagaraParamNames)
		{
			this.StartLoopSpines = StartLoopSpines;
			this.ProgressSpine = ProgressSpine;
			this.ProgressSpineSegments = ProgressSpineSegments;
			this.EndSpine = EndSpine;
			this.SuccessSpine = SuccessSpine;
			this.FailSpine = FailSpine;
			this.WaitEndSpineFinish = WaitEndSpineFinish;
			this.NiagaraParamNames = NiagaraParamNames;
		}

		// Token: 0x060250EE RID: 151790 RVA: 0x0036DA58 File Offset: 0x0036BC58
		protected override IntPtr GetUStructPtr()
		{
			return FQteSpineInfo.StaticStruct();
		}

		// Token: 0x060250EF RID: 151791 RVA: 0x0036DA64 File Offset: 0x0036BC64
		[NullableContext(2)]
		public FQteSpineInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060250F0 RID: 151792 RVA: 0x0036DA6E File Offset: 0x0036BC6E
		public FQteSpineInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060250F1 RID: 151793 RVA: 0x0036DA79 File Offset: 0x0036BC79
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FQteSpineInfo(Pointer, false, true);
		}

		// Token: 0x060250F2 RID: 151794 RVA: 0x0036DA83 File Offset: 0x0036BC83
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FQteSpineInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04013F5D RID: 81757
		public const string __ObjectPath = "/Script/SequenceDialogue.QteSpineInfo";

		// Token: 0x04013F5E RID: 81758
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013F5F RID: 81759
		internal static int __PropertyOffset_StartLoopSpines;

		// Token: 0x04013F60 RID: 81760
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSpineData> _StartLoopSpines;

		// Token: 0x04013F61 RID: 81761
		internal static int __PropertyOffset_ProgressSpine;

		// Token: 0x04013F62 RID: 81762
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSpineData> _ProgressSpine;

		// Token: 0x04013F63 RID: 81763
		internal static int __PropertyOffset_ProgressSpineSegments;

		// Token: 0x04013F64 RID: 81764
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FQteProgressSpineSegment> _ProgressSpineSegments;

		// Token: 0x04013F65 RID: 81765
		internal static int __PropertyOffset_EndSpine;

		// Token: 0x04013F66 RID: 81766
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSpineData> _EndSpine;

		// Token: 0x04013F67 RID: 81767
		internal static int __PropertyOffset_SuccessSpine;

		// Token: 0x04013F68 RID: 81768
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSpineData> _SuccessSpine;

		// Token: 0x04013F69 RID: 81769
		internal static int __PropertyOffset_FailSpine;

		// Token: 0x04013F6A RID: 81770
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSpineData> _FailSpine;

		// Token: 0x04013F6B RID: 81771
		internal static int __PropertyOffset_WaitEndSpineFinish;

		// Token: 0x04013F6C RID: 81772
		internal static int __PropertyOffset_NiagaraParamNames;

		// Token: 0x04013F6D RID: 81773
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _NiagaraParamNames;
	}
}
