using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001170 RID: 4464
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SpecifiedFolderPathCheck")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FSpecifiedFolderPathCheck : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010501 RID: 66817 RVA: 0x001807E3 File Offset: 0x0017E9E3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSpecifiedFolderPathCheck._ScriptStructPtr != 0) ? FSpecifiedFolderPathCheck._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SpecifiedFolderPathCheck", ref FSpecifiedFolderPathCheck._ScriptStructPtr);
		}

		// Token: 0x17003FEB RID: 16363
		// (get) Token: 0x06010502 RID: 66818 RVA: 0x00180808 File Offset: 0x0017EA08
		// (set) Token: 0x06010503 RID: 66819 RVA: 0x0018084B File Offset: 0x0017EA4B
		public TArray<FSpecifiedFolderPath> SpecifiedFolders
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSpecifiedFolderPath> result;
				if ((result = this._SpecifiedFolders) == null)
				{
					result = (this._SpecifiedFolders = new TArray<FSpecifiedFolderPath>(base.NativePtr + (IntPtr)FSpecifiedFolderPathCheck.__PropertyOffset_SpecifiedFolders, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpecifiedFolders.CopyAssign(value);
			}
		}

		// Token: 0x06010504 RID: 66820 RVA: 0x00180859 File Offset: 0x0017EA59
		public FSpecifiedFolderPathCheck()
		{
		}

		// Token: 0x06010505 RID: 66821 RVA: 0x00180861 File Offset: 0x0017EA61
		public FSpecifiedFolderPathCheck(TArray<FSpecifiedFolderPath> SpecifiedFolders)
		{
			this.SpecifiedFolders = SpecifiedFolders;
		}

		// Token: 0x06010506 RID: 66822 RVA: 0x00180870 File Offset: 0x0017EA70
		protected override IntPtr GetUStructPtr()
		{
			return FSpecifiedFolderPathCheck.StaticStruct();
		}

		// Token: 0x06010507 RID: 66823 RVA: 0x0018087C File Offset: 0x0017EA7C
		[NullableContext(2)]
		public FSpecifiedFolderPathCheck(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010508 RID: 66824 RVA: 0x00180886 File Offset: 0x0017EA86
		public FSpecifiedFolderPathCheck(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010509 RID: 66825 RVA: 0x00180891 File Offset: 0x0017EA91
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSpecifiedFolderPathCheck(Pointer, false, true);
		}

		// Token: 0x0601050A RID: 66826 RVA: 0x0018089B File Offset: 0x0017EA9B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSpecifiedFolderPathCheck(Pointer, MemoryOwner);
		}

		// Token: 0x04008C61 RID: 35937
		public const string __ObjectPath = "/Script/Engine.SpecifiedFolderPathCheck";

		// Token: 0x04008C62 RID: 35938
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008C63 RID: 35939
		internal static int __PropertyOffset_SpecifiedFolders;

		// Token: 0x04008C64 RID: 35940
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSpecifiedFolderPath> _SpecifiedFolders;
	}
}
