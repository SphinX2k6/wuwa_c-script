using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020024C6 RID: 9414
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/NiagaraCore.NiagaraCompileHash")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FNiagaraCompileHash : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060233A3 RID: 144291 RVA: 0x00341B53 File Offset: 0x0033FD53
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraCompileHash._ScriptStructPtr != 0) ? FNiagaraCompileHash._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/NiagaraCore.NiagaraCompileHash", ref FNiagaraCompileHash._ScriptStructPtr);
		}

		// Token: 0x17008773 RID: 34675
		// (get) Token: 0x060233A4 RID: 144292 RVA: 0x00341B78 File Offset: 0x0033FD78
		// (set) Token: 0x060233A5 RID: 144293 RVA: 0x00341BBB File Offset: 0x0033FDBB
		public TArray<byte> DataHash
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._DataHash) == null)
				{
					result = (this._DataHash = new TArray<byte>(base.NativePtr + (IntPtr)FNiagaraCompileHash.__PropertyOffset_DataHash, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DataHash.CopyAssign(value);
			}
		}

		// Token: 0x060233A6 RID: 144294 RVA: 0x00341BC9 File Offset: 0x0033FDC9
		public FNiagaraCompileHash()
		{
		}

		// Token: 0x060233A7 RID: 144295 RVA: 0x00341BD1 File Offset: 0x0033FDD1
		public FNiagaraCompileHash(TArray<byte> DataHash)
		{
			this.DataHash = DataHash;
		}

		// Token: 0x060233A8 RID: 144296 RVA: 0x00341BE0 File Offset: 0x0033FDE0
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraCompileHash.StaticStruct();
		}

		// Token: 0x060233A9 RID: 144297 RVA: 0x00341BEC File Offset: 0x0033FDEC
		[NullableContext(2)]
		public FNiagaraCompileHash(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060233AA RID: 144298 RVA: 0x00341BF6 File Offset: 0x0033FDF6
		public FNiagaraCompileHash(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060233AB RID: 144299 RVA: 0x00341C01 File Offset: 0x0033FE01
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraCompileHash(Pointer, false, true);
		}

		// Token: 0x060233AC RID: 144300 RVA: 0x00341C0B File Offset: 0x0033FE0B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraCompileHash(Pointer, MemoryOwner);
		}

		// Token: 0x04012D0B RID: 77067
		public const string __ObjectPath = "/Script/NiagaraCore.NiagaraCompileHash";

		// Token: 0x04012D0C RID: 77068
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012D0D RID: 77069
		internal static int __PropertyOffset_DataHash;

		// Token: 0x04012D0E RID: 77070
		[Nullable(2)]
		private TArray<byte> _DataHash;
	}
}
