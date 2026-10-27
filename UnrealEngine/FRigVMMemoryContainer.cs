using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026C7 RID: 9927
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/RigVM.RigVMMemoryContainer")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FRigVMMemoryContainer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024DA5 RID: 150949 RVA: 0x0036841C File Offset: 0x0036661C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigVMMemoryContainer._ScriptStructPtr != 0) ? FRigVMMemoryContainer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RigVM.RigVMMemoryContainer", ref FRigVMMemoryContainer._ScriptStructPtr);
		}

		// Token: 0x17008E51 RID: 36433
		// (get) Token: 0x06024DA6 RID: 150950 RVA: 0x00368440 File Offset: 0x00366640
		// (set) Token: 0x06024DA7 RID: 150951 RVA: 0x00368450 File Offset: 0x00366650
		public unsafe bool bUseNameMap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigVMMemoryContainer.__PropertyOffset_bUseNameMap) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMMemoryContainer.__PropertyOffset_bUseNameMap) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008E52 RID: 36434
		// (get) Token: 0x06024DA8 RID: 150952 RVA: 0x00368461 File Offset: 0x00366661
		// (set) Token: 0x06024DA9 RID: 150953 RVA: 0x00368471 File Offset: 0x00366671
		public unsafe ERigVMMemoryType MemoryType
		{
			get
			{
				return (ERigVMMemoryType)(*(base.NativePtr + (IntPtr)FRigVMMemoryContainer.__PropertyOffset_MemoryType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMMemoryContainer.__PropertyOffset_MemoryType) = (byte)value;
			}
		}

		// Token: 0x17008E53 RID: 36435
		// (get) Token: 0x06024DAA RID: 150954 RVA: 0x00368484 File Offset: 0x00366684
		// (set) Token: 0x06024DAB RID: 150955 RVA: 0x003684C7 File Offset: 0x003666C7
		public TArray<FRigVMRegister> Registers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigVMRegister> result;
				if ((result = this._Registers) == null)
				{
					result = (this._Registers = new TArray<FRigVMRegister>(base.NativePtr + (IntPtr)FRigVMMemoryContainer.__PropertyOffset_Registers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Registers.CopyAssign(value);
			}
		}

		// Token: 0x17008E54 RID: 36436
		// (get) Token: 0x06024DAC RID: 150956 RVA: 0x003684D8 File Offset: 0x003666D8
		// (set) Token: 0x06024DAD RID: 150957 RVA: 0x0036851B File Offset: 0x0036671B
		public TArray<FRigVMRegisterOffset> RegisterOffsets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigVMRegisterOffset> result;
				if ((result = this._RegisterOffsets) == null)
				{
					result = (this._RegisterOffsets = new TArray<FRigVMRegisterOffset>(base.NativePtr + (IntPtr)FRigVMMemoryContainer.__PropertyOffset_RegisterOffsets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RegisterOffsets.CopyAssign(value);
			}
		}

		// Token: 0x17008E55 RID: 36437
		// (get) Token: 0x06024DAE RID: 150958 RVA: 0x0036852C File Offset: 0x0036672C
		// (set) Token: 0x06024DAF RID: 150959 RVA: 0x0036856F File Offset: 0x0036676F
		public TArray<byte> Data
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._Data) == null)
				{
					result = (this._Data = new TArray<byte>(base.NativePtr + (IntPtr)FRigVMMemoryContainer.__PropertyOffset_Data, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Data.CopyAssign(value);
			}
		}

		// Token: 0x17008E56 RID: 36438
		// (get) Token: 0x06024DB0 RID: 150960 RVA: 0x00368580 File Offset: 0x00366780
		// (set) Token: 0x06024DB1 RID: 150961 RVA: 0x003685C3 File Offset: 0x003667C3
		public TArray<UScriptStruct> ScriptStructs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UScriptStruct> result;
				if ((result = this._ScriptStructs) == null)
				{
					result = (this._ScriptStructs = new TArray<UScriptStruct>(base.NativePtr + (IntPtr)FRigVMMemoryContainer.__PropertyOffset_ScriptStructs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ScriptStructs.CopyAssign(value);
			}
		}

		// Token: 0x17008E57 RID: 36439
		// (get) Token: 0x06024DB2 RID: 150962 RVA: 0x003685D4 File Offset: 0x003667D4
		// (set) Token: 0x06024DB3 RID: 150963 RVA: 0x00368617 File Offset: 0x00366817
		public TMap<FName, int> NameMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, int> result;
				if ((result = this._NameMap) == null)
				{
					result = (this._NameMap = new TMap<FName, int>(base.NativePtr + (IntPtr)FRigVMMemoryContainer.__PropertyOffset_NameMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NameMap.CopyAssign(value);
			}
		}

		// Token: 0x17008E58 RID: 36440
		// (get) Token: 0x06024DB4 RID: 150964 RVA: 0x00368625 File Offset: 0x00366825
		// (set) Token: 0x06024DB5 RID: 150965 RVA: 0x00368635 File Offset: 0x00366835
		public unsafe bool bEncounteredErrorDuringLoad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigVMMemoryContainer.__PropertyOffset_bEncounteredErrorDuringLoad) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMMemoryContainer.__PropertyOffset_bEncounteredErrorDuringLoad) = (value ? 1 : 0);
			}
		}

		// Token: 0x06024DB6 RID: 150966 RVA: 0x00368646 File Offset: 0x00366846
		public FRigVMMemoryContainer()
		{
		}

		// Token: 0x06024DB7 RID: 150967 RVA: 0x00368650 File Offset: 0x00366850
		public FRigVMMemoryContainer(bool bUseNameMap, ERigVMMemoryType MemoryType, TArray<FRigVMRegister> Registers, TArray<FRigVMRegisterOffset> RegisterOffsets, TArray<byte> Data, TArray<UScriptStruct> ScriptStructs, TMap<FName, int> NameMap, bool bEncounteredErrorDuringLoad)
		{
			this.bUseNameMap = bUseNameMap;
			this.MemoryType = MemoryType;
			this.Registers = Registers;
			this.RegisterOffsets = RegisterOffsets;
			this.Data = Data;
			this.ScriptStructs = ScriptStructs;
			this.NameMap = NameMap;
			this.bEncounteredErrorDuringLoad = bEncounteredErrorDuringLoad;
		}

		// Token: 0x06024DB8 RID: 150968 RVA: 0x003686A0 File Offset: 0x003668A0
		protected override IntPtr GetUStructPtr()
		{
			return FRigVMMemoryContainer.StaticStruct();
		}

		// Token: 0x06024DB9 RID: 150969 RVA: 0x003686AC File Offset: 0x003668AC
		[NullableContext(2)]
		public FRigVMMemoryContainer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024DBA RID: 150970 RVA: 0x003686B6 File Offset: 0x003668B6
		public FRigVMMemoryContainer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024DBB RID: 150971 RVA: 0x003686C1 File Offset: 0x003668C1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigVMMemoryContainer(Pointer, false, true);
		}

		// Token: 0x06024DBC RID: 150972 RVA: 0x003686CB File Offset: 0x003668CB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigVMMemoryContainer(Pointer, MemoryOwner);
		}

		// Token: 0x04013DAB RID: 81323
		public const string __ObjectPath = "/Script/RigVM.RigVMMemoryContainer";

		// Token: 0x04013DAC RID: 81324
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013DAD RID: 81325
		internal static int __PropertyOffset_bUseNameMap;

		// Token: 0x04013DAE RID: 81326
		internal static int __PropertyOffset_MemoryType;

		// Token: 0x04013DAF RID: 81327
		internal static int __PropertyOffset_Registers;

		// Token: 0x04013DB0 RID: 81328
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigVMRegister> _Registers;

		// Token: 0x04013DB1 RID: 81329
		internal static int __PropertyOffset_RegisterOffsets;

		// Token: 0x04013DB2 RID: 81330
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigVMRegisterOffset> _RegisterOffsets;

		// Token: 0x04013DB3 RID: 81331
		internal static int __PropertyOffset_Data;

		// Token: 0x04013DB4 RID: 81332
		[Nullable(2)]
		private TArray<byte> _Data;

		// Token: 0x04013DB5 RID: 81333
		internal static int __PropertyOffset_ScriptStructs;

		// Token: 0x04013DB6 RID: 81334
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UScriptStruct> _ScriptStructs;

		// Token: 0x04013DB7 RID: 81335
		internal static int __PropertyOffset_NameMap;

		// Token: 0x04013DB8 RID: 81336
		[Nullable(2)]
		private TMap<FName, int> _NameMap;

		// Token: 0x04013DB9 RID: 81337
		internal static int __PropertyOffset_bEncounteredErrorDuringLoad;
	}
}
