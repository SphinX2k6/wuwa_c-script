using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007E0 RID: 2016
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.QteSpineInfo")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FQteSpineInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AD49 RID: 44361 RVA: 0x001003D7 File Offset: 0x000FE5D7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FQteSpineInfo._ScriptStructPtr != 0) ? FQteSpineInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.QteSpineInfo", ref FQteSpineInfo._ScriptStructPtr);
		}

		// Token: 0x17002046 RID: 8262
		// (get) Token: 0x0600AD4A RID: 44362 RVA: 0x001003FC File Offset: 0x000FE5FC
		// (set) Token: 0x0600AD4B RID: 44363 RVA: 0x0010043F File Offset: 0x000FE63F
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

		// Token: 0x17002047 RID: 8263
		// (get) Token: 0x0600AD4C RID: 44364 RVA: 0x00100450 File Offset: 0x000FE650
		// (set) Token: 0x0600AD4D RID: 44365 RVA: 0x00100493 File Offset: 0x000FE693
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

		// Token: 0x17002048 RID: 8264
		// (get) Token: 0x0600AD4E RID: 44366 RVA: 0x001004A4 File Offset: 0x000FE6A4
		// (set) Token: 0x0600AD4F RID: 44367 RVA: 0x001004E7 File Offset: 0x000FE6E7
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

		// Token: 0x17002049 RID: 8265
		// (get) Token: 0x0600AD50 RID: 44368 RVA: 0x001004F8 File Offset: 0x000FE6F8
		// (set) Token: 0x0600AD51 RID: 44369 RVA: 0x0010053B File Offset: 0x000FE73B
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

		// Token: 0x1700204A RID: 8266
		// (get) Token: 0x0600AD52 RID: 44370 RVA: 0x0010054C File Offset: 0x000FE74C
		// (set) Token: 0x0600AD53 RID: 44371 RVA: 0x0010058F File Offset: 0x000FE78F
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

		// Token: 0x1700204B RID: 8267
		// (get) Token: 0x0600AD54 RID: 44372 RVA: 0x001005A0 File Offset: 0x000FE7A0
		// (set) Token: 0x0600AD55 RID: 44373 RVA: 0x001005E3 File Offset: 0x000FE7E3
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

		// Token: 0x1700204C RID: 8268
		// (get) Token: 0x0600AD56 RID: 44374 RVA: 0x001005F1 File Offset: 0x000FE7F1
		// (set) Token: 0x0600AD57 RID: 44375 RVA: 0x00100601 File Offset: 0x000FE801
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

		// Token: 0x1700204D RID: 8269
		// (get) Token: 0x0600AD58 RID: 44376 RVA: 0x00100614 File Offset: 0x000FE814
		// (set) Token: 0x0600AD59 RID: 44377 RVA: 0x00100657 File Offset: 0x000FE857
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

		// Token: 0x0600AD5A RID: 44378 RVA: 0x00100665 File Offset: 0x000FE865
		public FQteSpineInfo()
		{
		}

		// Token: 0x0600AD5B RID: 44379 RVA: 0x0010066D File Offset: 0x000FE86D
		protected override IntPtr GetUStructPtr()
		{
			return FQteSpineInfo.StaticStruct();
		}

		// Token: 0x0600AD5C RID: 44380 RVA: 0x00100679 File Offset: 0x000FE879
		[NullableContext(2)]
		public FQteSpineInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AD5D RID: 44381 RVA: 0x00100683 File Offset: 0x000FE883
		public FQteSpineInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AD5E RID: 44382 RVA: 0x0010068E File Offset: 0x000FE88E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FQteSpineInfo(Pointer, false, true);
		}

		// Token: 0x0600AD5F RID: 44383 RVA: 0x00100698 File Offset: 0x000FE898
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FQteSpineInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04004AB0 RID: 19120
		public const string __ObjectPath = "/Script/SequenceDialogue.QteSpineInfo";

		// Token: 0x04004AB1 RID: 19121
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004AB2 RID: 19122
		internal static int __PropertyOffset_StartLoopSpines;

		// Token: 0x04004AB3 RID: 19123
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSpineData> _StartLoopSpines;

		// Token: 0x04004AB4 RID: 19124
		internal static int __PropertyOffset_ProgressSpine;

		// Token: 0x04004AB5 RID: 19125
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSpineData> _ProgressSpine;

		// Token: 0x04004AB6 RID: 19126
		internal static int __PropertyOffset_ProgressSpineSegments;

		// Token: 0x04004AB7 RID: 19127
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FQteProgressSpineSegment> _ProgressSpineSegments;

		// Token: 0x04004AB8 RID: 19128
		internal static int __PropertyOffset_EndSpine;

		// Token: 0x04004AB9 RID: 19129
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSpineData> _EndSpine;

		// Token: 0x04004ABA RID: 19130
		internal static int __PropertyOffset_SuccessSpine;

		// Token: 0x04004ABB RID: 19131
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSpineData> _SuccessSpine;

		// Token: 0x04004ABC RID: 19132
		internal static int __PropertyOffset_FailSpine;

		// Token: 0x04004ABD RID: 19133
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSpineData> _FailSpine;

		// Token: 0x04004ABE RID: 19134
		internal static int __PropertyOffset_WaitEndSpineFinish;

		// Token: 0x04004ABF RID: 19135
		internal static int __PropertyOffset_NiagaraParamNames;

		// Token: 0x04004AC0 RID: 19136
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _NiagaraParamNames;
	}
}
