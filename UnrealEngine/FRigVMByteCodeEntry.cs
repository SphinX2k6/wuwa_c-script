using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026BC RID: 9916
	[UnrealObjectPath("/Script/RigVM.RigVMByteCodeEntry")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigVMByteCodeEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024D49 RID: 150857 RVA: 0x00367E76 File Offset: 0x00366076
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigVMByteCodeEntry._ScriptStructPtr != 0) ? FRigVMByteCodeEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RigVM.RigVMByteCodeEntry", ref FRigVMByteCodeEntry._ScriptStructPtr);
		}

		// Token: 0x17008E4B RID: 36427
		// (get) Token: 0x06024D4A RID: 150858 RVA: 0x00367E9A File Offset: 0x0036609A
		// (set) Token: 0x06024D4B RID: 150859 RVA: 0x00367EAE File Offset: 0x003660AE
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigVMByteCodeEntry.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMByteCodeEntry.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17008E4C RID: 36428
		// (get) Token: 0x06024D4C RID: 150860 RVA: 0x00367EC3 File Offset: 0x003660C3
		// (set) Token: 0x06024D4D RID: 150861 RVA: 0x00367ED3 File Offset: 0x003660D3
		public unsafe int InstructionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigVMByteCodeEntry.__PropertyOffset_InstructionIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMByteCodeEntry.__PropertyOffset_InstructionIndex) = value;
			}
		}

		// Token: 0x06024D4E RID: 150862 RVA: 0x00367EE4 File Offset: 0x003660E4
		public FRigVMByteCodeEntry()
		{
		}

		// Token: 0x06024D4F RID: 150863 RVA: 0x00367EEC File Offset: 0x003660EC
		public FRigVMByteCodeEntry(FName Name, int InstructionIndex)
		{
			this.Name = Name;
			this.InstructionIndex = InstructionIndex;
		}

		// Token: 0x06024D50 RID: 150864 RVA: 0x00367F02 File Offset: 0x00366102
		protected override IntPtr GetUStructPtr()
		{
			return FRigVMByteCodeEntry.StaticStruct();
		}

		// Token: 0x06024D51 RID: 150865 RVA: 0x00367F0E File Offset: 0x0036610E
		[NullableContext(2)]
		public FRigVMByteCodeEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024D52 RID: 150866 RVA: 0x00367F18 File Offset: 0x00366118
		public FRigVMByteCodeEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024D53 RID: 150867 RVA: 0x00367F23 File Offset: 0x00366123
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigVMByteCodeEntry(Pointer, false, true);
		}

		// Token: 0x06024D54 RID: 150868 RVA: 0x00367F2D File Offset: 0x0036612D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigVMByteCodeEntry(Pointer, MemoryOwner);
		}

		// Token: 0x04013D8C RID: 81292
		[Nullable(1)]
		public const string __ObjectPath = "/Script/RigVM.RigVMByteCodeEntry";

		// Token: 0x04013D8D RID: 81293
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013D8E RID: 81294
		internal static int __PropertyOffset_Name;

		// Token: 0x04013D8F RID: 81295
		internal static int __PropertyOffset_InstructionIndex;
	}
}
