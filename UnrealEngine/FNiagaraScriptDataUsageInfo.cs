using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025DF RID: 9695
	[UnrealObjectPath("/Script/Niagara.NiagaraScriptDataUsageInfo")]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1)]
	public class FNiagaraScriptDataUsageInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060240A9 RID: 147625 RVA: 0x003553C7 File Offset: 0x003535C7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraScriptDataUsageInfo._ScriptStructPtr != 0) ? FNiagaraScriptDataUsageInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraScriptDataUsageInfo", ref FNiagaraScriptDataUsageInfo._ScriptStructPtr);
		}

		// Token: 0x17008AAD RID: 35501
		// (get) Token: 0x060240AA RID: 147626 RVA: 0x003553EB File Offset: 0x003535EB
		// (set) Token: 0x060240AB RID: 147627 RVA: 0x003553FB File Offset: 0x003535FB
		public unsafe bool bReadsAttributeData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraScriptDataUsageInfo.__PropertyOffset_bReadsAttributeData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraScriptDataUsageInfo.__PropertyOffset_bReadsAttributeData) = (value ? 1 : 0);
			}
		}

		// Token: 0x060240AC RID: 147628 RVA: 0x0035540C File Offset: 0x0035360C
		public FNiagaraScriptDataUsageInfo()
		{
		}

		// Token: 0x060240AD RID: 147629 RVA: 0x00355414 File Offset: 0x00353614
		public FNiagaraScriptDataUsageInfo(bool bReadsAttributeData)
		{
			this.bReadsAttributeData = bReadsAttributeData;
		}

		// Token: 0x060240AE RID: 147630 RVA: 0x00355423 File Offset: 0x00353623
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraScriptDataUsageInfo.StaticStruct();
		}

		// Token: 0x060240AF RID: 147631 RVA: 0x0035542F File Offset: 0x0035362F
		[NullableContext(2)]
		public FNiagaraScriptDataUsageInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060240B0 RID: 147632 RVA: 0x00355439 File Offset: 0x00353639
		public FNiagaraScriptDataUsageInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060240B1 RID: 147633 RVA: 0x00355444 File Offset: 0x00353644
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraScriptDataUsageInfo(Pointer, false, true);
		}

		// Token: 0x060240B2 RID: 147634 RVA: 0x0035544E File Offset: 0x0035364E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraScriptDataUsageInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04013547 RID: 79175
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraScriptDataUsageInfo";

		// Token: 0x04013548 RID: 79176
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013549 RID: 79177
		internal static int __PropertyOffset_bReadsAttributeData;
	}
}
