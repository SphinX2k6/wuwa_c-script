using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026C9 RID: 9929
	[UnrealObjectPath("/Script/RigVM.RigVMOperand")]
	[UnrealStructLayout(6, 2, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 6)]
	public class FRigVMOperand : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024DC4 RID: 150980 RVA: 0x00368796 File Offset: 0x00366996
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigVMOperand._ScriptStructPtr != 0) ? FRigVMOperand._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RigVM.RigVMOperand", ref FRigVMOperand._ScriptStructPtr);
		}

		// Token: 0x17008E59 RID: 36441
		// (get) Token: 0x06024DC5 RID: 150981 RVA: 0x003687BA File Offset: 0x003669BA
		// (set) Token: 0x06024DC6 RID: 150982 RVA: 0x003687CA File Offset: 0x003669CA
		public unsafe ERigVMMemoryType MemoryType
		{
			get
			{
				return (ERigVMMemoryType)(*(base.NativePtr + (IntPtr)FRigVMOperand.__PropertyOffset_MemoryType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMOperand.__PropertyOffset_MemoryType) = (byte)value;
			}
		}

		// Token: 0x17008E5A RID: 36442
		// (get) Token: 0x06024DC7 RID: 150983 RVA: 0x003687DB File Offset: 0x003669DB
		// (set) Token: 0x06024DC8 RID: 150984 RVA: 0x003687EB File Offset: 0x003669EB
		public unsafe ushort RegisterIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigVMOperand.__PropertyOffset_RegisterIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMOperand.__PropertyOffset_RegisterIndex) = (short)value;
			}
		}

		// Token: 0x17008E5B RID: 36443
		// (get) Token: 0x06024DC9 RID: 150985 RVA: 0x003687FC File Offset: 0x003669FC
		// (set) Token: 0x06024DCA RID: 150986 RVA: 0x0036880C File Offset: 0x00366A0C
		public unsafe ushort RegisterOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigVMOperand.__PropertyOffset_RegisterOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMOperand.__PropertyOffset_RegisterOffset) = (short)value;
			}
		}

		// Token: 0x06024DCB RID: 150987 RVA: 0x0036881D File Offset: 0x00366A1D
		public FRigVMOperand()
		{
		}

		// Token: 0x06024DCC RID: 150988 RVA: 0x00368825 File Offset: 0x00366A25
		public FRigVMOperand(ERigVMMemoryType MemoryType, ushort RegisterIndex, ushort RegisterOffset)
		{
			this.MemoryType = MemoryType;
			this.RegisterIndex = RegisterIndex;
			this.RegisterOffset = RegisterOffset;
		}

		// Token: 0x06024DCD RID: 150989 RVA: 0x00368842 File Offset: 0x00366A42
		protected override IntPtr GetUStructPtr()
		{
			return FRigVMOperand.StaticStruct();
		}

		// Token: 0x06024DCE RID: 150990 RVA: 0x0036884E File Offset: 0x00366A4E
		[NullableContext(2)]
		public FRigVMOperand(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024DCF RID: 150991 RVA: 0x00368858 File Offset: 0x00366A58
		public FRigVMOperand(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024DD0 RID: 150992 RVA: 0x00368863 File Offset: 0x00366A63
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigVMOperand(Pointer, false, true);
		}

		// Token: 0x06024DD1 RID: 150993 RVA: 0x0036886D File Offset: 0x00366A6D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigVMOperand(Pointer, MemoryOwner);
		}

		// Token: 0x04013DBF RID: 81343
		[Nullable(1)]
		public const string __ObjectPath = "/Script/RigVM.RigVMOperand";

		// Token: 0x04013DC0 RID: 81344
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013DC1 RID: 81345
		internal static int __PropertyOffset_MemoryType;

		// Token: 0x04013DC2 RID: 81346
		internal static int __PropertyOffset_RegisterIndex;

		// Token: 0x04013DC3 RID: 81347
		internal static int __PropertyOffset_RegisterOffset;
	}
}
