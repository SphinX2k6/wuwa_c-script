using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004C2 RID: 1218
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.ControlRigDrawContainer")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FControlRigDrawContainer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004175 RID: 16757 RVA: 0x00062111 File Offset: 0x00060311
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FControlRigDrawContainer._ScriptStructPtr != 0) ? FControlRigDrawContainer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.ControlRigDrawContainer", ref FControlRigDrawContainer._ScriptStructPtr);
		}

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x06004176 RID: 16758 RVA: 0x00062138 File Offset: 0x00060338
		// (set) Token: 0x06004177 RID: 16759 RVA: 0x0006217B File Offset: 0x0006037B
		public TArray<FControlRigDrawInstruction> Instructions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FControlRigDrawInstruction> result;
				if ((result = this._Instructions) == null)
				{
					result = (this._Instructions = new TArray<FControlRigDrawInstruction>(base.NativePtr + (IntPtr)FControlRigDrawContainer.__PropertyOffset_Instructions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Instructions.CopyAssign(value);
			}
		}

		// Token: 0x06004178 RID: 16760 RVA: 0x00062189 File Offset: 0x00060389
		public FControlRigDrawContainer()
		{
		}

		// Token: 0x06004179 RID: 16761 RVA: 0x00062191 File Offset: 0x00060391
		public FControlRigDrawContainer(TArray<FControlRigDrawInstruction> Instructions)
		{
			this.Instructions = Instructions;
		}

		// Token: 0x0600417A RID: 16762 RVA: 0x000621A0 File Offset: 0x000603A0
		protected override IntPtr GetUStructPtr()
		{
			return FControlRigDrawContainer.StaticStruct();
		}

		// Token: 0x0600417B RID: 16763 RVA: 0x000621AC File Offset: 0x000603AC
		[NullableContext(2)]
		public FControlRigDrawContainer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600417C RID: 16764 RVA: 0x000621B6 File Offset: 0x000603B6
		public FControlRigDrawContainer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600417D RID: 16765 RVA: 0x000621C1 File Offset: 0x000603C1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FControlRigDrawContainer(Pointer, false, true);
		}

		// Token: 0x0600417E RID: 16766 RVA: 0x000621CB File Offset: 0x000603CB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FControlRigDrawContainer(Pointer, MemoryOwner);
		}

		// Token: 0x04001F27 RID: 7975
		public const string __ObjectPath = "/Script/ControlRig.ControlRigDrawContainer";

		// Token: 0x04001F28 RID: 7976
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001F29 RID: 7977
		internal static int __PropertyOffset_Instructions;

		// Token: 0x04001F2A RID: 7978
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FControlRigDrawInstruction> _Instructions;
	}
}
