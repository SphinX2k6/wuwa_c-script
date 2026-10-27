using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002604 RID: 9732
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraVariableLayoutInfo")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FNiagaraVariableLayoutInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024314 RID: 148244 RVA: 0x003592EC File Offset: 0x003574EC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraVariableLayoutInfo._ScriptStructPtr != 0) ? FNiagaraVariableLayoutInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraVariableLayoutInfo", ref FNiagaraVariableLayoutInfo._ScriptStructPtr);
		}

		// Token: 0x17008B5D RID: 35677
		// (get) Token: 0x06024315 RID: 148245 RVA: 0x00359310 File Offset: 0x00357510
		// (set) Token: 0x06024316 RID: 148246 RVA: 0x00359320 File Offset: 0x00357520
		public unsafe uint FloatComponentStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraVariableLayoutInfo.__PropertyOffset_FloatComponentStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVariableLayoutInfo.__PropertyOffset_FloatComponentStart) = (int)value;
			}
		}

		// Token: 0x17008B5E RID: 35678
		// (get) Token: 0x06024317 RID: 148247 RVA: 0x00359331 File Offset: 0x00357531
		// (set) Token: 0x06024318 RID: 148248 RVA: 0x00359341 File Offset: 0x00357541
		public unsafe uint Int32ComponentStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraVariableLayoutInfo.__PropertyOffset_Int32ComponentStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVariableLayoutInfo.__PropertyOffset_Int32ComponentStart) = (int)value;
			}
		}

		// Token: 0x17008B5F RID: 35679
		// (get) Token: 0x06024319 RID: 148249 RVA: 0x00359352 File Offset: 0x00357552
		// (set) Token: 0x0602431A RID: 148250 RVA: 0x00359362 File Offset: 0x00357562
		public unsafe uint HalfComponentStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraVariableLayoutInfo.__PropertyOffset_HalfComponentStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVariableLayoutInfo.__PropertyOffset_HalfComponentStart) = (int)value;
			}
		}

		// Token: 0x17008B60 RID: 35680
		// (get) Token: 0x0602431B RID: 148251 RVA: 0x00359374 File Offset: 0x00357574
		// (set) Token: 0x0602431C RID: 148252 RVA: 0x003593B7 File Offset: 0x003575B7
		public FNiagaraTypeLayoutInfo LayoutInfo
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraTypeLayoutInfo result;
				if ((result = this._LayoutInfo) == null)
				{
					result = (this._LayoutInfo = new FNiagaraTypeLayoutInfo(base.NativePtr + (IntPtr)FNiagaraVariableLayoutInfo.__PropertyOffset_LayoutInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraTypeLayoutInfo.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraVariableLayoutInfo.__PropertyOffset_LayoutInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602431D RID: 148253 RVA: 0x003593D8 File Offset: 0x003575D8
		public FNiagaraVariableLayoutInfo()
		{
		}

		// Token: 0x0602431E RID: 148254 RVA: 0x003593E0 File Offset: 0x003575E0
		public FNiagaraVariableLayoutInfo(uint FloatComponentStart, uint Int32ComponentStart, uint HalfComponentStart, FNiagaraTypeLayoutInfo LayoutInfo)
		{
			this.FloatComponentStart = FloatComponentStart;
			this.Int32ComponentStart = Int32ComponentStart;
			this.HalfComponentStart = HalfComponentStart;
			this.LayoutInfo = LayoutInfo;
		}

		// Token: 0x0602431F RID: 148255 RVA: 0x00359405 File Offset: 0x00357605
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraVariableLayoutInfo.StaticStruct();
		}

		// Token: 0x06024320 RID: 148256 RVA: 0x00359411 File Offset: 0x00357611
		[NullableContext(2)]
		public FNiagaraVariableLayoutInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024321 RID: 148257 RVA: 0x0035941B File Offset: 0x0035761B
		public FNiagaraVariableLayoutInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024322 RID: 148258 RVA: 0x00359426 File Offset: 0x00357626
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraVariableLayoutInfo(Pointer, false, true);
		}

		// Token: 0x06024323 RID: 148259 RVA: 0x00359430 File Offset: 0x00357630
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraVariableLayoutInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040136B2 RID: 79538
		public const string __ObjectPath = "/Script/Niagara.NiagaraVariableLayoutInfo";

		// Token: 0x040136B3 RID: 79539
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040136B4 RID: 79540
		internal static int __PropertyOffset_FloatComponentStart;

		// Token: 0x040136B5 RID: 79541
		internal static int __PropertyOffset_Int32ComponentStart;

		// Token: 0x040136B6 RID: 79542
		internal static int __PropertyOffset_HalfComponentStart;

		// Token: 0x040136B7 RID: 79543
		internal static int __PropertyOffset_LayoutInfo;

		// Token: 0x040136B8 RID: 79544
		[Nullable(2)]
		private FNiagaraTypeLayoutInfo _LayoutInfo;
	}
}
