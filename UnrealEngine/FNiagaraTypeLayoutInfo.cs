using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025FC RID: 9724
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraTypeLayoutInfo")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FNiagaraTypeLayoutInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060242AA RID: 148138 RVA: 0x00358812 File Offset: 0x00356A12
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraTypeLayoutInfo._ScriptStructPtr != 0) ? FNiagaraTypeLayoutInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraTypeLayoutInfo", ref FNiagaraTypeLayoutInfo._ScriptStructPtr);
		}

		// Token: 0x17008B48 RID: 35656
		// (get) Token: 0x060242AB RID: 148139 RVA: 0x00358838 File Offset: 0x00356A38
		// (set) Token: 0x060242AC RID: 148140 RVA: 0x0035887B File Offset: 0x00356A7B
		public TArray<uint> FloatComponentByteOffsets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<uint> result;
				if ((result = this._FloatComponentByteOffsets) == null)
				{
					result = (this._FloatComponentByteOffsets = new TArray<uint>(base.NativePtr + (IntPtr)FNiagaraTypeLayoutInfo.__PropertyOffset_FloatComponentByteOffsets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatComponentByteOffsets.CopyAssign(value);
			}
		}

		// Token: 0x17008B49 RID: 35657
		// (get) Token: 0x060242AD RID: 148141 RVA: 0x0035888C File Offset: 0x00356A8C
		// (set) Token: 0x060242AE RID: 148142 RVA: 0x003588CF File Offset: 0x00356ACF
		public TArray<uint> FloatComponentRegisterOffsets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<uint> result;
				if ((result = this._FloatComponentRegisterOffsets) == null)
				{
					result = (this._FloatComponentRegisterOffsets = new TArray<uint>(base.NativePtr + (IntPtr)FNiagaraTypeLayoutInfo.__PropertyOffset_FloatComponentRegisterOffsets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatComponentRegisterOffsets.CopyAssign(value);
			}
		}

		// Token: 0x17008B4A RID: 35658
		// (get) Token: 0x060242AF RID: 148143 RVA: 0x003588E0 File Offset: 0x00356AE0
		// (set) Token: 0x060242B0 RID: 148144 RVA: 0x00358923 File Offset: 0x00356B23
		public TArray<uint> Int32ComponentByteOffsets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<uint> result;
				if ((result = this._Int32ComponentByteOffsets) == null)
				{
					result = (this._Int32ComponentByteOffsets = new TArray<uint>(base.NativePtr + (IntPtr)FNiagaraTypeLayoutInfo.__PropertyOffset_Int32ComponentByteOffsets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Int32ComponentByteOffsets.CopyAssign(value);
			}
		}

		// Token: 0x17008B4B RID: 35659
		// (get) Token: 0x060242B1 RID: 148145 RVA: 0x00358934 File Offset: 0x00356B34
		// (set) Token: 0x060242B2 RID: 148146 RVA: 0x00358977 File Offset: 0x00356B77
		public TArray<uint> Int32ComponentRegisterOffsets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<uint> result;
				if ((result = this._Int32ComponentRegisterOffsets) == null)
				{
					result = (this._Int32ComponentRegisterOffsets = new TArray<uint>(base.NativePtr + (IntPtr)FNiagaraTypeLayoutInfo.__PropertyOffset_Int32ComponentRegisterOffsets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Int32ComponentRegisterOffsets.CopyAssign(value);
			}
		}

		// Token: 0x17008B4C RID: 35660
		// (get) Token: 0x060242B3 RID: 148147 RVA: 0x00358988 File Offset: 0x00356B88
		// (set) Token: 0x060242B4 RID: 148148 RVA: 0x003589CB File Offset: 0x00356BCB
		public TArray<uint> HalfComponentByteOffsets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<uint> result;
				if ((result = this._HalfComponentByteOffsets) == null)
				{
					result = (this._HalfComponentByteOffsets = new TArray<uint>(base.NativePtr + (IntPtr)FNiagaraTypeLayoutInfo.__PropertyOffset_HalfComponentByteOffsets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HalfComponentByteOffsets.CopyAssign(value);
			}
		}

		// Token: 0x17008B4D RID: 35661
		// (get) Token: 0x060242B5 RID: 148149 RVA: 0x003589DC File Offset: 0x00356BDC
		// (set) Token: 0x060242B6 RID: 148150 RVA: 0x00358A1F File Offset: 0x00356C1F
		public TArray<uint> HalfComponentRegisterOffsets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<uint> result;
				if ((result = this._HalfComponentRegisterOffsets) == null)
				{
					result = (this._HalfComponentRegisterOffsets = new TArray<uint>(base.NativePtr + (IntPtr)FNiagaraTypeLayoutInfo.__PropertyOffset_HalfComponentRegisterOffsets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HalfComponentRegisterOffsets.CopyAssign(value);
			}
		}

		// Token: 0x060242B7 RID: 148151 RVA: 0x00358A2D File Offset: 0x00356C2D
		public FNiagaraTypeLayoutInfo()
		{
		}

		// Token: 0x060242B8 RID: 148152 RVA: 0x00358A35 File Offset: 0x00356C35
		public FNiagaraTypeLayoutInfo(TArray<uint> FloatComponentByteOffsets, TArray<uint> FloatComponentRegisterOffsets, TArray<uint> Int32ComponentByteOffsets, TArray<uint> Int32ComponentRegisterOffsets, TArray<uint> HalfComponentByteOffsets, TArray<uint> HalfComponentRegisterOffsets)
		{
			this.FloatComponentByteOffsets = FloatComponentByteOffsets;
			this.FloatComponentRegisterOffsets = FloatComponentRegisterOffsets;
			this.Int32ComponentByteOffsets = Int32ComponentByteOffsets;
			this.Int32ComponentRegisterOffsets = Int32ComponentRegisterOffsets;
			this.HalfComponentByteOffsets = HalfComponentByteOffsets;
			this.HalfComponentRegisterOffsets = HalfComponentRegisterOffsets;
		}

		// Token: 0x060242B9 RID: 148153 RVA: 0x00358A6A File Offset: 0x00356C6A
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraTypeLayoutInfo.StaticStruct();
		}

		// Token: 0x060242BA RID: 148154 RVA: 0x00358A76 File Offset: 0x00356C76
		[NullableContext(2)]
		public FNiagaraTypeLayoutInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060242BB RID: 148155 RVA: 0x00358A80 File Offset: 0x00356C80
		public FNiagaraTypeLayoutInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060242BC RID: 148156 RVA: 0x00358A8B File Offset: 0x00356C8B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraTypeLayoutInfo(Pointer, false, true);
		}

		// Token: 0x060242BD RID: 148157 RVA: 0x00358A95 File Offset: 0x00356C95
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraTypeLayoutInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0401367B RID: 79483
		public const string __ObjectPath = "/Script/Niagara.NiagaraTypeLayoutInfo";

		// Token: 0x0401367C RID: 79484
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401367D RID: 79485
		internal static int __PropertyOffset_FloatComponentByteOffsets;

		// Token: 0x0401367E RID: 79486
		[Nullable(2)]
		private TArray<uint> _FloatComponentByteOffsets;

		// Token: 0x0401367F RID: 79487
		internal static int __PropertyOffset_FloatComponentRegisterOffsets;

		// Token: 0x04013680 RID: 79488
		[Nullable(2)]
		private TArray<uint> _FloatComponentRegisterOffsets;

		// Token: 0x04013681 RID: 79489
		internal static int __PropertyOffset_Int32ComponentByteOffsets;

		// Token: 0x04013682 RID: 79490
		[Nullable(2)]
		private TArray<uint> _Int32ComponentByteOffsets;

		// Token: 0x04013683 RID: 79491
		internal static int __PropertyOffset_Int32ComponentRegisterOffsets;

		// Token: 0x04013684 RID: 79492
		[Nullable(2)]
		private TArray<uint> _Int32ComponentRegisterOffsets;

		// Token: 0x04013685 RID: 79493
		internal static int __PropertyOffset_HalfComponentByteOffsets;

		// Token: 0x04013686 RID: 79494
		[Nullable(2)]
		private TArray<uint> _HalfComponentByteOffsets;

		// Token: 0x04013687 RID: 79495
		internal static int __PropertyOffset_HalfComponentRegisterOffsets;

		// Token: 0x04013688 RID: 79496
		[Nullable(2)]
		private TArray<uint> _HalfComponentRegisterOffsets;
	}
}
