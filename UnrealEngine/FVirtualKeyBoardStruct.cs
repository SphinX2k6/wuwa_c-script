using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001742 RID: 5954
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroCloudGame.VirtualKeyBoardStruct")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FVirtualKeyBoardStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060156C4 RID: 87748 RVA: 0x001F7BB4 File Offset: 0x001F5DB4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVirtualKeyBoardStruct._ScriptStructPtr != 0) ? FVirtualKeyBoardStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroCloudGame.VirtualKeyBoardStruct", ref FVirtualKeyBoardStruct._ScriptStructPtr);
		}

		// Token: 0x17005499 RID: 21657
		// (get) Token: 0x060156C5 RID: 87749 RVA: 0x001F7BD8 File Offset: 0x001F5DD8
		// (set) Token: 0x060156C6 RID: 87750 RVA: 0x001F7BEC File Offset: 0x001F5DEC
		public unsafe string Context
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FVirtualKeyBoardStruct.__PropertyOffset_Context)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FVirtualKeyBoardStruct.__PropertyOffset_Context)), value);
			}
		}

		// Token: 0x060156C7 RID: 87751 RVA: 0x001F7C01 File Offset: 0x001F5E01
		public FVirtualKeyBoardStruct()
		{
		}

		// Token: 0x060156C8 RID: 87752 RVA: 0x001F7C09 File Offset: 0x001F5E09
		public FVirtualKeyBoardStruct(string Context)
		{
			this.Context = Context;
		}

		// Token: 0x060156C9 RID: 87753 RVA: 0x001F7C18 File Offset: 0x001F5E18
		protected override IntPtr GetUStructPtr()
		{
			return FVirtualKeyBoardStruct.StaticStruct();
		}

		// Token: 0x060156CA RID: 87754 RVA: 0x001F7C24 File Offset: 0x001F5E24
		[NullableContext(2)]
		public FVirtualKeyBoardStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060156CB RID: 87755 RVA: 0x001F7C2E File Offset: 0x001F5E2E
		public FVirtualKeyBoardStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060156CC RID: 87756 RVA: 0x001F7C39 File Offset: 0x001F5E39
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVirtualKeyBoardStruct(Pointer, false, true);
		}

		// Token: 0x060156CD RID: 87757 RVA: 0x001F7C43 File Offset: 0x001F5E43
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVirtualKeyBoardStruct(Pointer, MemoryOwner);
		}

		// Token: 0x0400BAE1 RID: 47841
		public const string __ObjectPath = "/Script/KuroCloudGame.VirtualKeyBoardStruct";

		// Token: 0x0400BAE2 RID: 47842
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BAE3 RID: 47843
		internal static int __PropertyOffset_Context;
	}
}
