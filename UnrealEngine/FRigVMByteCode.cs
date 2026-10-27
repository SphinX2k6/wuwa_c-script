using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026BB RID: 9915
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/RigVM.RigVMByteCode")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigVMByteCode : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024D3B RID: 150843 RVA: 0x00367D31 File Offset: 0x00365F31
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigVMByteCode._ScriptStructPtr != 0) ? FRigVMByteCode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RigVM.RigVMByteCode", ref FRigVMByteCode._ScriptStructPtr);
		}

		// Token: 0x17008E48 RID: 36424
		// (get) Token: 0x06024D3C RID: 150844 RVA: 0x00367D58 File Offset: 0x00365F58
		// (set) Token: 0x06024D3D RID: 150845 RVA: 0x00367D9B File Offset: 0x00365F9B
		public TArray<byte> ByteCode
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._ByteCode) == null)
				{
					result = (this._ByteCode = new TArray<byte>(base.NativePtr + (IntPtr)FRigVMByteCode.__PropertyOffset_ByteCode, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ByteCode.CopyAssign(value);
			}
		}

		// Token: 0x17008E49 RID: 36425
		// (get) Token: 0x06024D3E RID: 150846 RVA: 0x00367DA9 File Offset: 0x00365FA9
		// (set) Token: 0x06024D3F RID: 150847 RVA: 0x00367DB9 File Offset: 0x00365FB9
		public unsafe int NumInstructions
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigVMByteCode.__PropertyOffset_NumInstructions);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMByteCode.__PropertyOffset_NumInstructions) = value;
			}
		}

		// Token: 0x17008E4A RID: 36426
		// (get) Token: 0x06024D40 RID: 150848 RVA: 0x00367DCC File Offset: 0x00365FCC
		// (set) Token: 0x06024D41 RID: 150849 RVA: 0x00367E0F File Offset: 0x0036600F
		public TArray<FRigVMByteCodeEntry> Entries
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigVMByteCodeEntry> result;
				if ((result = this._Entries) == null)
				{
					result = (this._Entries = new TArray<FRigVMByteCodeEntry>(base.NativePtr + (IntPtr)FRigVMByteCode.__PropertyOffset_Entries, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Entries.CopyAssign(value);
			}
		}

		// Token: 0x06024D42 RID: 150850 RVA: 0x00367E1D File Offset: 0x0036601D
		public FRigVMByteCode()
		{
		}

		// Token: 0x06024D43 RID: 150851 RVA: 0x00367E25 File Offset: 0x00366025
		public FRigVMByteCode(TArray<byte> ByteCode, int NumInstructions, TArray<FRigVMByteCodeEntry> Entries)
		{
			this.ByteCode = ByteCode;
			this.NumInstructions = NumInstructions;
			this.Entries = Entries;
		}

		// Token: 0x06024D44 RID: 150852 RVA: 0x00367E42 File Offset: 0x00366042
		protected override IntPtr GetUStructPtr()
		{
			return FRigVMByteCode.StaticStruct();
		}

		// Token: 0x06024D45 RID: 150853 RVA: 0x00367E4E File Offset: 0x0036604E
		[NullableContext(2)]
		public FRigVMByteCode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024D46 RID: 150854 RVA: 0x00367E58 File Offset: 0x00366058
		public FRigVMByteCode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024D47 RID: 150855 RVA: 0x00367E63 File Offset: 0x00366063
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigVMByteCode(Pointer, false, true);
		}

		// Token: 0x06024D48 RID: 150856 RVA: 0x00367E6D File Offset: 0x0036606D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigVMByteCode(Pointer, MemoryOwner);
		}

		// Token: 0x04013D85 RID: 81285
		public const string __ObjectPath = "/Script/RigVM.RigVMByteCode";

		// Token: 0x04013D86 RID: 81286
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013D87 RID: 81287
		internal static int __PropertyOffset_ByteCode;

		// Token: 0x04013D88 RID: 81288
		[Nullable(2)]
		private TArray<byte> _ByteCode;

		// Token: 0x04013D89 RID: 81289
		internal static int __PropertyOffset_NumInstructions;

		// Token: 0x04013D8A RID: 81290
		internal static int __PropertyOffset_Entries;

		// Token: 0x04013D8B RID: 81291
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigVMByteCodeEntry> _Entries;
	}
}
