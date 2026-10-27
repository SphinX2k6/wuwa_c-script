using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200253A RID: 9530
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Niagara.NDIDataChannelFunctionInfo")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FNDIDataChannelFunctionInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023604 RID: 144900 RVA: 0x003450CE File Offset: 0x003432CE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNDIDataChannelFunctionInfo._ScriptStructPtr != 0) ? FNDIDataChannelFunctionInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NDIDataChannelFunctionInfo", ref FNDIDataChannelFunctionInfo._ScriptStructPtr);
		}

		// Token: 0x170087FC RID: 34812
		// (get) Token: 0x06023605 RID: 144901 RVA: 0x003450F2 File Offset: 0x003432F2
		// (set) Token: 0x06023606 RID: 144902 RVA: 0x00345106 File Offset: 0x00343306
		public unsafe FName FunctionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNDIDataChannelFunctionInfo.__PropertyOffset_FunctionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNDIDataChannelFunctionInfo.__PropertyOffset_FunctionName) = value;
			}
		}

		// Token: 0x170087FD RID: 34813
		// (get) Token: 0x06023607 RID: 144903 RVA: 0x0034511C File Offset: 0x0034331C
		// (set) Token: 0x06023608 RID: 144904 RVA: 0x0034515F File Offset: 0x0034335F
		public TArray<FNiagaraVariableBase> Inputs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraVariableBase> result;
				if ((result = this._Inputs) == null)
				{
					result = (this._Inputs = new TArray<FNiagaraVariableBase>(base.NativePtr + (IntPtr)FNDIDataChannelFunctionInfo.__PropertyOffset_Inputs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Inputs.CopyAssign(value);
			}
		}

		// Token: 0x170087FE RID: 34814
		// (get) Token: 0x06023609 RID: 144905 RVA: 0x00345170 File Offset: 0x00343370
		// (set) Token: 0x0602360A RID: 144906 RVA: 0x003451B3 File Offset: 0x003433B3
		public TArray<FNiagaraVariableBase> Outputs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraVariableBase> result;
				if ((result = this._Outputs) == null)
				{
					result = (this._Outputs = new TArray<FNiagaraVariableBase>(base.NativePtr + (IntPtr)FNDIDataChannelFunctionInfo.__PropertyOffset_Outputs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Outputs.CopyAssign(value);
			}
		}

		// Token: 0x0602360B RID: 144907 RVA: 0x003451C1 File Offset: 0x003433C1
		public FNDIDataChannelFunctionInfo()
		{
		}

		// Token: 0x0602360C RID: 144908 RVA: 0x003451C9 File Offset: 0x003433C9
		public FNDIDataChannelFunctionInfo(FName FunctionName, TArray<FNiagaraVariableBase> Inputs, TArray<FNiagaraVariableBase> Outputs)
		{
			this.FunctionName = FunctionName;
			this.Inputs = Inputs;
			this.Outputs = Outputs;
		}

		// Token: 0x0602360D RID: 144909 RVA: 0x003451E6 File Offset: 0x003433E6
		protected override IntPtr GetUStructPtr()
		{
			return FNDIDataChannelFunctionInfo.StaticStruct();
		}

		// Token: 0x0602360E RID: 144910 RVA: 0x003451F2 File Offset: 0x003433F2
		[NullableContext(2)]
		public FNDIDataChannelFunctionInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602360F RID: 144911 RVA: 0x003451FC File Offset: 0x003433FC
		public FNDIDataChannelFunctionInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023610 RID: 144912 RVA: 0x00345207 File Offset: 0x00343407
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNDIDataChannelFunctionInfo(Pointer, false, true);
		}

		// Token: 0x06023611 RID: 144913 RVA: 0x00345211 File Offset: 0x00343411
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNDIDataChannelFunctionInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04012FCD RID: 77773
		public const string __ObjectPath = "/Script/Niagara.NDIDataChannelFunctionInfo";

		// Token: 0x04012FCE RID: 77774
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012FCF RID: 77775
		internal static int __PropertyOffset_FunctionName;

		// Token: 0x04012FD0 RID: 77776
		internal static int __PropertyOffset_Inputs;

		// Token: 0x04012FD1 RID: 77777
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraVariableBase> _Inputs;

		// Token: 0x04012FD2 RID: 77778
		internal static int __PropertyOffset_Outputs;

		// Token: 0x04012FD3 RID: 77779
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraVariableBase> _Outputs;
	}
}
