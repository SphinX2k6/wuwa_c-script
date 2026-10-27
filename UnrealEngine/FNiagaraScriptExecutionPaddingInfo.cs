using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025E0 RID: 9696
	[UnrealObjectPath("/Script/Niagara.NiagaraScriptExecutionPaddingInfo")]
	[UnrealStructLayout(8, 2, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FNiagaraScriptExecutionPaddingInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060240B3 RID: 147635 RVA: 0x00355457 File Offset: 0x00353657
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraScriptExecutionPaddingInfo._ScriptStructPtr != 0) ? FNiagaraScriptExecutionPaddingInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraScriptExecutionPaddingInfo", ref FNiagaraScriptExecutionPaddingInfo._ScriptStructPtr);
		}

		// Token: 0x17008AAE RID: 35502
		// (get) Token: 0x060240B4 RID: 147636 RVA: 0x0035547B File Offset: 0x0035367B
		// (set) Token: 0x060240B5 RID: 147637 RVA: 0x0035548B File Offset: 0x0035368B
		public unsafe ushort SrcOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraScriptExecutionPaddingInfo.__PropertyOffset_SrcOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraScriptExecutionPaddingInfo.__PropertyOffset_SrcOffset) = (short)value;
			}
		}

		// Token: 0x17008AAF RID: 35503
		// (get) Token: 0x060240B6 RID: 147638 RVA: 0x0035549C File Offset: 0x0035369C
		// (set) Token: 0x060240B7 RID: 147639 RVA: 0x003554AC File Offset: 0x003536AC
		public unsafe ushort DestOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraScriptExecutionPaddingInfo.__PropertyOffset_DestOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraScriptExecutionPaddingInfo.__PropertyOffset_DestOffset) = (short)value;
			}
		}

		// Token: 0x17008AB0 RID: 35504
		// (get) Token: 0x060240B8 RID: 147640 RVA: 0x003554BD File Offset: 0x003536BD
		// (set) Token: 0x060240B9 RID: 147641 RVA: 0x003554CD File Offset: 0x003536CD
		public unsafe ushort SrcSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraScriptExecutionPaddingInfo.__PropertyOffset_SrcSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraScriptExecutionPaddingInfo.__PropertyOffset_SrcSize) = (short)value;
			}
		}

		// Token: 0x17008AB1 RID: 35505
		// (get) Token: 0x060240BA RID: 147642 RVA: 0x003554DE File Offset: 0x003536DE
		// (set) Token: 0x060240BB RID: 147643 RVA: 0x003554EE File Offset: 0x003536EE
		public unsafe ushort DestSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraScriptExecutionPaddingInfo.__PropertyOffset_DestSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraScriptExecutionPaddingInfo.__PropertyOffset_DestSize) = (short)value;
			}
		}

		// Token: 0x060240BC RID: 147644 RVA: 0x003554FF File Offset: 0x003536FF
		public FNiagaraScriptExecutionPaddingInfo()
		{
		}

		// Token: 0x060240BD RID: 147645 RVA: 0x00355507 File Offset: 0x00353707
		public FNiagaraScriptExecutionPaddingInfo(ushort SrcOffset, ushort DestOffset, ushort SrcSize, ushort DestSize)
		{
			this.SrcOffset = SrcOffset;
			this.DestOffset = DestOffset;
			this.SrcSize = SrcSize;
			this.DestSize = DestSize;
		}

		// Token: 0x060240BE RID: 147646 RVA: 0x0035552C File Offset: 0x0035372C
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraScriptExecutionPaddingInfo.StaticStruct();
		}

		// Token: 0x060240BF RID: 147647 RVA: 0x00355538 File Offset: 0x00353738
		[NullableContext(2)]
		public FNiagaraScriptExecutionPaddingInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060240C0 RID: 147648 RVA: 0x00355542 File Offset: 0x00353742
		public FNiagaraScriptExecutionPaddingInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060240C1 RID: 147649 RVA: 0x0035554D File Offset: 0x0035374D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraScriptExecutionPaddingInfo(Pointer, false, true);
		}

		// Token: 0x060240C2 RID: 147650 RVA: 0x00355557 File Offset: 0x00353757
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraScriptExecutionPaddingInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0401354A RID: 79178
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraScriptExecutionPaddingInfo";

		// Token: 0x0401354B RID: 79179
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401354C RID: 79180
		internal static int __PropertyOffset_SrcOffset;

		// Token: 0x0401354D RID: 79181
		internal static int __PropertyOffset_DestOffset;

		// Token: 0x0401354E RID: 79182
		internal static int __PropertyOffset_SrcSize;

		// Token: 0x0401354F RID: 79183
		internal static int __PropertyOffset_DestSize;
	}
}
