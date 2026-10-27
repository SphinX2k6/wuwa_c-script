using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025C4 RID: 9668
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraParameters")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FNiagaraParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023F0C RID: 147212 RVA: 0x003527ED File Offset: 0x003509ED
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraParameters._ScriptStructPtr != 0) ? FNiagaraParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraParameters", ref FNiagaraParameters._ScriptStructPtr);
		}

		// Token: 0x17008A36 RID: 35382
		// (get) Token: 0x06023F0D RID: 147213 RVA: 0x00352814 File Offset: 0x00350A14
		// (set) Token: 0x06023F0E RID: 147214 RVA: 0x00352857 File Offset: 0x00350A57
		public TArray<FNiagaraVariable> Parameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraVariable> result;
				if ((result = this._Parameters) == null)
				{
					result = (this._Parameters = new TArray<FNiagaraVariable>(base.NativePtr + (IntPtr)FNiagaraParameters.__PropertyOffset_Parameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Parameters.CopyAssign(value);
			}
		}

		// Token: 0x06023F0F RID: 147215 RVA: 0x00352865 File Offset: 0x00350A65
		public FNiagaraParameters()
		{
		}

		// Token: 0x06023F10 RID: 147216 RVA: 0x0035286D File Offset: 0x00350A6D
		public FNiagaraParameters(TArray<FNiagaraVariable> Parameters)
		{
			this.Parameters = Parameters;
		}

		// Token: 0x06023F11 RID: 147217 RVA: 0x0035287C File Offset: 0x00350A7C
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraParameters.StaticStruct();
		}

		// Token: 0x06023F12 RID: 147218 RVA: 0x00352888 File Offset: 0x00350A88
		[NullableContext(2)]
		public FNiagaraParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023F13 RID: 147219 RVA: 0x00352892 File Offset: 0x00350A92
		public FNiagaraParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023F14 RID: 147220 RVA: 0x0035289D File Offset: 0x00350A9D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraParameters(Pointer, false, true);
		}

		// Token: 0x06023F15 RID: 147221 RVA: 0x003528A7 File Offset: 0x00350AA7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraParameters(Pointer, MemoryOwner);
		}

		// Token: 0x04013452 RID: 78930
		public const string __ObjectPath = "/Script/Niagara.NiagaraParameters";

		// Token: 0x04013453 RID: 78931
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013454 RID: 78932
		internal static int __PropertyOffset_Parameters;

		// Token: 0x04013455 RID: 78933
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraVariable> _Parameters;
	}
}
