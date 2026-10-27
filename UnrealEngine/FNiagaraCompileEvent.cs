using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020024CF RID: 9423
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/NiagaraShader.NiagaraCompileEvent")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FNiagaraCompileEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060233B6 RID: 144310 RVA: 0x00341CE2 File Offset: 0x0033FEE2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraCompileEvent._ScriptStructPtr != 0) ? FNiagaraCompileEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/NiagaraShader.NiagaraCompileEvent", ref FNiagaraCompileEvent._ScriptStructPtr);
		}

		// Token: 0x17008774 RID: 34676
		// (get) Token: 0x060233B7 RID: 144311 RVA: 0x00341D06 File Offset: 0x0033FF06
		// (set) Token: 0x060233B8 RID: 144312 RVA: 0x00341D16 File Offset: 0x0033FF16
		public unsafe FNiagaraCompileEventSeverity Severity
		{
			get
			{
				return (FNiagaraCompileEventSeverity)(*(base.NativePtr + (IntPtr)FNiagaraCompileEvent.__PropertyOffset_Severity));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraCompileEvent.__PropertyOffset_Severity) = (byte)value;
			}
		}

		// Token: 0x17008775 RID: 34677
		// (get) Token: 0x060233B9 RID: 144313 RVA: 0x00341D27 File Offset: 0x0033FF27
		// (set) Token: 0x060233BA RID: 144314 RVA: 0x00341D3B File Offset: 0x0033FF3B
		public unsafe string Message
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FNiagaraCompileEvent.__PropertyOffset_Message)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FNiagaraCompileEvent.__PropertyOffset_Message)), value);
			}
		}

		// Token: 0x17008776 RID: 34678
		// (get) Token: 0x060233BB RID: 144315 RVA: 0x00341D50 File Offset: 0x0033FF50
		// (set) Token: 0x060233BC RID: 144316 RVA: 0x00341D64 File Offset: 0x0033FF64
		public unsafe FGuid NodeGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraCompileEvent.__PropertyOffset_NodeGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraCompileEvent.__PropertyOffset_NodeGuid) = value;
			}
		}

		// Token: 0x17008777 RID: 34679
		// (get) Token: 0x060233BD RID: 144317 RVA: 0x00341D79 File Offset: 0x0033FF79
		// (set) Token: 0x060233BE RID: 144318 RVA: 0x00341D8D File Offset: 0x0033FF8D
		public unsafe FGuid PinGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraCompileEvent.__PropertyOffset_PinGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraCompileEvent.__PropertyOffset_PinGuid) = value;
			}
		}

		// Token: 0x17008778 RID: 34680
		// (get) Token: 0x060233BF RID: 144319 RVA: 0x00341DA4 File Offset: 0x0033FFA4
		// (set) Token: 0x060233C0 RID: 144320 RVA: 0x00341DE7 File Offset: 0x0033FFE7
		public TArray<FGuid> StackGuids
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGuid> result;
				if ((result = this._StackGuids) == null)
				{
					result = (this._StackGuids = new TArray<FGuid>(base.NativePtr + (IntPtr)FNiagaraCompileEvent.__PropertyOffset_StackGuids, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StackGuids.CopyAssign(value);
			}
		}

		// Token: 0x060233C1 RID: 144321 RVA: 0x00341DF5 File Offset: 0x0033FFF5
		public FNiagaraCompileEvent()
		{
		}

		// Token: 0x060233C2 RID: 144322 RVA: 0x00341DFD File Offset: 0x0033FFFD
		public FNiagaraCompileEvent(FNiagaraCompileEventSeverity Severity, string Message, FGuid NodeGuid, FGuid PinGuid, TArray<FGuid> StackGuids)
		{
			this.Severity = Severity;
			this.Message = Message;
			this.NodeGuid = NodeGuid;
			this.PinGuid = PinGuid;
			this.StackGuids = StackGuids;
		}

		// Token: 0x060233C3 RID: 144323 RVA: 0x00341E2A File Offset: 0x0034002A
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraCompileEvent.StaticStruct();
		}

		// Token: 0x060233C4 RID: 144324 RVA: 0x00341E36 File Offset: 0x00340036
		[NullableContext(2)]
		public FNiagaraCompileEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060233C5 RID: 144325 RVA: 0x00341E40 File Offset: 0x00340040
		public FNiagaraCompileEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060233C6 RID: 144326 RVA: 0x00341E4B File Offset: 0x0034004B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraCompileEvent(Pointer, false, true);
		}

		// Token: 0x060233C7 RID: 144327 RVA: 0x00341E55 File Offset: 0x00340055
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraCompileEvent(Pointer, MemoryOwner);
		}

		// Token: 0x04012D3B RID: 77115
		public const string __ObjectPath = "/Script/NiagaraShader.NiagaraCompileEvent";

		// Token: 0x04012D3C RID: 77116
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012D3D RID: 77117
		internal static int __PropertyOffset_Severity;

		// Token: 0x04012D3E RID: 77118
		internal static int __PropertyOffset_Message;

		// Token: 0x04012D3F RID: 77119
		internal static int __PropertyOffset_NodeGuid;

		// Token: 0x04012D40 RID: 77120
		internal static int __PropertyOffset_PinGuid;

		// Token: 0x04012D41 RID: 77121
		internal static int __PropertyOffset_StackGuids;

		// Token: 0x04012D42 RID: 77122
		[Nullable(2)]
		private TArray<FGuid> _StackGuids;
	}
}
