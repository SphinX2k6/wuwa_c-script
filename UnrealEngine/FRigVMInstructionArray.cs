using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026C4 RID: 9924
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/RigVM.RigVMInstructionArray")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigVMInstructionArray : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024D8D RID: 150925 RVA: 0x0036829C File Offset: 0x0036649C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigVMInstructionArray._ScriptStructPtr != 0) ? FRigVMInstructionArray._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RigVM.RigVMInstructionArray", ref FRigVMInstructionArray._ScriptStructPtr);
		}

		// Token: 0x17008E50 RID: 36432
		// (get) Token: 0x06024D8E RID: 150926 RVA: 0x003682C0 File Offset: 0x003664C0
		// (set) Token: 0x06024D8F RID: 150927 RVA: 0x00368303 File Offset: 0x00366503
		public TArray<FRigVMInstruction> Instructions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigVMInstruction> result;
				if ((result = this._Instructions) == null)
				{
					result = (this._Instructions = new TArray<FRigVMInstruction>(base.NativePtr + (IntPtr)FRigVMInstructionArray.__PropertyOffset_Instructions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Instructions.CopyAssign(value);
			}
		}

		// Token: 0x06024D90 RID: 150928 RVA: 0x00368311 File Offset: 0x00366511
		public FRigVMInstructionArray()
		{
		}

		// Token: 0x06024D91 RID: 150929 RVA: 0x00368319 File Offset: 0x00366519
		public FRigVMInstructionArray(TArray<FRigVMInstruction> Instructions)
		{
			this.Instructions = Instructions;
		}

		// Token: 0x06024D92 RID: 150930 RVA: 0x00368328 File Offset: 0x00366528
		protected override IntPtr GetUStructPtr()
		{
			return FRigVMInstructionArray.StaticStruct();
		}

		// Token: 0x06024D93 RID: 150931 RVA: 0x00368334 File Offset: 0x00366534
		[NullableContext(2)]
		public FRigVMInstructionArray(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024D94 RID: 150932 RVA: 0x0036833E File Offset: 0x0036653E
		public FRigVMInstructionArray(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024D95 RID: 150933 RVA: 0x00368349 File Offset: 0x00366549
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigVMInstructionArray(Pointer, false, true);
		}

		// Token: 0x06024D96 RID: 150934 RVA: 0x00368353 File Offset: 0x00366553
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigVMInstructionArray(Pointer, MemoryOwner);
		}

		// Token: 0x04013DA3 RID: 81315
		public const string __ObjectPath = "/Script/RigVM.RigVMInstructionArray";

		// Token: 0x04013DA4 RID: 81316
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013DA5 RID: 81317
		internal static int __PropertyOffset_Instructions;

		// Token: 0x04013DA6 RID: 81318
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigVMInstruction> _Instructions;
	}
}
