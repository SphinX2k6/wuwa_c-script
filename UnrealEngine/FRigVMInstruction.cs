using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026C3 RID: 9923
	[UnrealObjectPath("/Script/RigVM.RigVMInstruction")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigVMInstruction : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024D7F RID: 150911 RVA: 0x003681BC File Offset: 0x003663BC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigVMInstruction._ScriptStructPtr != 0) ? FRigVMInstruction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RigVM.RigVMInstruction", ref FRigVMInstruction._ScriptStructPtr);
		}

		// Token: 0x17008E4D RID: 36429
		// (get) Token: 0x06024D80 RID: 150912 RVA: 0x003681E0 File Offset: 0x003663E0
		// (set) Token: 0x06024D81 RID: 150913 RVA: 0x003681F0 File Offset: 0x003663F0
		public unsafe ulong ByteCodeIndex
		{
			get
			{
				return (ulong)(*(base.NativePtr + (IntPtr)FRigVMInstruction.__PropertyOffset_ByteCodeIndex));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMInstruction.__PropertyOffset_ByteCodeIndex) = (long)value;
			}
		}

		// Token: 0x17008E4E RID: 36430
		// (get) Token: 0x06024D82 RID: 150914 RVA: 0x00368201 File Offset: 0x00366401
		// (set) Token: 0x06024D83 RID: 150915 RVA: 0x00368211 File Offset: 0x00366411
		public unsafe ERigVMOpCode OpCode
		{
			get
			{
				return (ERigVMOpCode)(*(base.NativePtr + (IntPtr)FRigVMInstruction.__PropertyOffset_OpCode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMInstruction.__PropertyOffset_OpCode) = (byte)value;
			}
		}

		// Token: 0x17008E4F RID: 36431
		// (get) Token: 0x06024D84 RID: 150916 RVA: 0x00368222 File Offset: 0x00366422
		// (set) Token: 0x06024D85 RID: 150917 RVA: 0x00368232 File Offset: 0x00366432
		public unsafe byte OperandAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigVMInstruction.__PropertyOffset_OperandAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMInstruction.__PropertyOffset_OperandAlignment) = value;
			}
		}

		// Token: 0x06024D86 RID: 150918 RVA: 0x00368243 File Offset: 0x00366443
		public FRigVMInstruction()
		{
		}

		// Token: 0x06024D87 RID: 150919 RVA: 0x0036824B File Offset: 0x0036644B
		public FRigVMInstruction(ulong ByteCodeIndex, ERigVMOpCode OpCode, byte OperandAlignment)
		{
			this.ByteCodeIndex = ByteCodeIndex;
			this.OpCode = OpCode;
			this.OperandAlignment = OperandAlignment;
		}

		// Token: 0x06024D88 RID: 150920 RVA: 0x00368268 File Offset: 0x00366468
		protected override IntPtr GetUStructPtr()
		{
			return FRigVMInstruction.StaticStruct();
		}

		// Token: 0x06024D89 RID: 150921 RVA: 0x00368274 File Offset: 0x00366474
		[NullableContext(2)]
		public FRigVMInstruction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024D8A RID: 150922 RVA: 0x0036827E File Offset: 0x0036647E
		public FRigVMInstruction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024D8B RID: 150923 RVA: 0x00368289 File Offset: 0x00366489
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigVMInstruction(Pointer, false, true);
		}

		// Token: 0x06024D8C RID: 150924 RVA: 0x00368293 File Offset: 0x00366493
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigVMInstruction(Pointer, MemoryOwner);
		}

		// Token: 0x04013D9E RID: 81310
		[Nullable(1)]
		public const string __ObjectPath = "/Script/RigVM.RigVMInstruction";

		// Token: 0x04013D9F RID: 81311
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013DA0 RID: 81312
		internal static int __PropertyOffset_ByteCodeIndex;

		// Token: 0x04013DA1 RID: 81313
		internal static int __PropertyOffset_OpCode;

		// Token: 0x04013DA2 RID: 81314
		internal static int __PropertyOffset_OperandAlignment;
	}
}
