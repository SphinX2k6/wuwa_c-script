using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026CB RID: 9931
	[UnrealObjectPath("/Script/RigVM.RigVMRegister")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRigVMRegister : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024DE6 RID: 151014 RVA: 0x003689F1 File Offset: 0x00366BF1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigVMRegister._ScriptStructPtr != 0) ? FRigVMRegister._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RigVM.RigVMRegister", ref FRigVMRegister._ScriptStructPtr);
		}

		// Token: 0x17008E62 RID: 36450
		// (get) Token: 0x06024DE7 RID: 151015 RVA: 0x00368A15 File Offset: 0x00366C15
		// (set) Token: 0x06024DE8 RID: 151016 RVA: 0x00368A25 File Offset: 0x00366C25
		public unsafe ERigVMRegisterType Type
		{
			get
			{
				return (ERigVMRegisterType)(*(base.NativePtr + (IntPtr)FRigVMRegister.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMRegister.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x17008E63 RID: 36451
		// (get) Token: 0x06024DE9 RID: 151017 RVA: 0x00368A36 File Offset: 0x00366C36
		// (set) Token: 0x06024DEA RID: 151018 RVA: 0x00368A46 File Offset: 0x00366C46
		public unsafe uint ByteIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigVMRegister.__PropertyOffset_ByteIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMRegister.__PropertyOffset_ByteIndex) = (int)value;
			}
		}

		// Token: 0x17008E64 RID: 36452
		// (get) Token: 0x06024DEB RID: 151019 RVA: 0x00368A57 File Offset: 0x00366C57
		// (set) Token: 0x06024DEC RID: 151020 RVA: 0x00368A67 File Offset: 0x00366C67
		public unsafe ushort ElementSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigVMRegister.__PropertyOffset_ElementSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMRegister.__PropertyOffset_ElementSize) = (short)value;
			}
		}

		// Token: 0x17008E65 RID: 36453
		// (get) Token: 0x06024DED RID: 151021 RVA: 0x00368A78 File Offset: 0x00366C78
		// (set) Token: 0x06024DEE RID: 151022 RVA: 0x00368A88 File Offset: 0x00366C88
		public unsafe ushort ElementCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigVMRegister.__PropertyOffset_ElementCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMRegister.__PropertyOffset_ElementCount) = (short)value;
			}
		}

		// Token: 0x17008E66 RID: 36454
		// (get) Token: 0x06024DEF RID: 151023 RVA: 0x00368A99 File Offset: 0x00366C99
		// (set) Token: 0x06024DF0 RID: 151024 RVA: 0x00368AA9 File Offset: 0x00366CA9
		public unsafe ushort SliceCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigVMRegister.__PropertyOffset_SliceCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMRegister.__PropertyOffset_SliceCount) = (short)value;
			}
		}

		// Token: 0x17008E67 RID: 36455
		// (get) Token: 0x06024DF1 RID: 151025 RVA: 0x00368ABA File Offset: 0x00366CBA
		// (set) Token: 0x06024DF2 RID: 151026 RVA: 0x00368ACA File Offset: 0x00366CCA
		public unsafe byte AlignmentBytes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigVMRegister.__PropertyOffset_AlignmentBytes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMRegister.__PropertyOffset_AlignmentBytes) = value;
			}
		}

		// Token: 0x17008E68 RID: 36456
		// (get) Token: 0x06024DF3 RID: 151027 RVA: 0x00368ADB File Offset: 0x00366CDB
		// (set) Token: 0x06024DF4 RID: 151028 RVA: 0x00368AEB File Offset: 0x00366CEB
		public unsafe ushort TrailingBytes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigVMRegister.__PropertyOffset_TrailingBytes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMRegister.__PropertyOffset_TrailingBytes) = (short)value;
			}
		}

		// Token: 0x17008E69 RID: 36457
		// (get) Token: 0x06024DF5 RID: 151029 RVA: 0x00368AFC File Offset: 0x00366CFC
		// (set) Token: 0x06024DF6 RID: 151030 RVA: 0x00368B10 File Offset: 0x00366D10
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigVMRegister.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMRegister.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17008E6A RID: 36458
		// (get) Token: 0x06024DF7 RID: 151031 RVA: 0x00368B25 File Offset: 0x00366D25
		// (set) Token: 0x06024DF8 RID: 151032 RVA: 0x00368B35 File Offset: 0x00366D35
		public unsafe int ScriptStructIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigVMRegister.__PropertyOffset_ScriptStructIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMRegister.__PropertyOffset_ScriptStructIndex) = value;
			}
		}

		// Token: 0x17008E6B RID: 36459
		// (get) Token: 0x06024DF9 RID: 151033 RVA: 0x00368B46 File Offset: 0x00366D46
		// (set) Token: 0x06024DFA RID: 151034 RVA: 0x00368B56 File Offset: 0x00366D56
		public unsafe bool bIsArray
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigVMRegister.__PropertyOffset_bIsArray) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMRegister.__PropertyOffset_bIsArray) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008E6C RID: 36460
		// (get) Token: 0x06024DFB RID: 151035 RVA: 0x00368B67 File Offset: 0x00366D67
		// (set) Token: 0x06024DFC RID: 151036 RVA: 0x00368B77 File Offset: 0x00366D77
		public unsafe bool bIsDynamic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigVMRegister.__PropertyOffset_bIsDynamic) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMRegister.__PropertyOffset_bIsDynamic) = (value ? 1 : 0);
			}
		}

		// Token: 0x06024DFD RID: 151037 RVA: 0x00368B88 File Offset: 0x00366D88
		public FRigVMRegister()
		{
		}

		// Token: 0x06024DFE RID: 151038 RVA: 0x00368B90 File Offset: 0x00366D90
		public FRigVMRegister(ERigVMRegisterType Type, uint ByteIndex, ushort ElementSize, ushort ElementCount, ushort SliceCount, byte AlignmentBytes, ushort TrailingBytes, FName Name, int ScriptStructIndex, bool bIsArray, bool bIsDynamic)
		{
			this.Type = Type;
			this.ByteIndex = ByteIndex;
			this.ElementSize = ElementSize;
			this.ElementCount = ElementCount;
			this.SliceCount = SliceCount;
			this.AlignmentBytes = AlignmentBytes;
			this.TrailingBytes = TrailingBytes;
			this.Name = Name;
			this.ScriptStructIndex = ScriptStructIndex;
			this.bIsArray = bIsArray;
			this.bIsDynamic = bIsDynamic;
		}

		// Token: 0x06024DFF RID: 151039 RVA: 0x00368BF8 File Offset: 0x00366DF8
		protected override IntPtr GetUStructPtr()
		{
			return FRigVMRegister.StaticStruct();
		}

		// Token: 0x06024E00 RID: 151040 RVA: 0x00368C04 File Offset: 0x00366E04
		[NullableContext(2)]
		public FRigVMRegister(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024E01 RID: 151041 RVA: 0x00368C0E File Offset: 0x00366E0E
		public FRigVMRegister(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024E02 RID: 151042 RVA: 0x00368C19 File Offset: 0x00366E19
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigVMRegister(Pointer, false, true);
		}

		// Token: 0x06024E03 RID: 151043 RVA: 0x00368C23 File Offset: 0x00366E23
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigVMRegister(Pointer, MemoryOwner);
		}

		// Token: 0x04013DCC RID: 81356
		[Nullable(1)]
		public const string __ObjectPath = "/Script/RigVM.RigVMRegister";

		// Token: 0x04013DCD RID: 81357
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013DCE RID: 81358
		internal static int __PropertyOffset_Type;

		// Token: 0x04013DCF RID: 81359
		internal static int __PropertyOffset_ByteIndex;

		// Token: 0x04013DD0 RID: 81360
		internal static int __PropertyOffset_ElementSize;

		// Token: 0x04013DD1 RID: 81361
		internal static int __PropertyOffset_ElementCount;

		// Token: 0x04013DD2 RID: 81362
		internal static int __PropertyOffset_SliceCount;

		// Token: 0x04013DD3 RID: 81363
		internal static int __PropertyOffset_AlignmentBytes;

		// Token: 0x04013DD4 RID: 81364
		internal static int __PropertyOffset_TrailingBytes;

		// Token: 0x04013DD5 RID: 81365
		internal static int __PropertyOffset_Name;

		// Token: 0x04013DD6 RID: 81366
		internal static int __PropertyOffset_ScriptStructIndex;

		// Token: 0x04013DD7 RID: 81367
		internal static int __PropertyOffset_bIsArray;

		// Token: 0x04013DD8 RID: 81368
		internal static int __PropertyOffset_bIsDynamic;
	}
}
