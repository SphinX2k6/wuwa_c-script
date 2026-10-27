using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020020D8 RID: 8408
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIThaiWordRow")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FLGUIThaiWordRow : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FAB2 RID: 129714 RVA: 0x002F195F File Offset: 0x002EFB5F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIThaiWordRow._ScriptStructPtr != 0) ? FLGUIThaiWordRow._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIThaiWordRow", ref FLGUIThaiWordRow._ScriptStructPtr);
		}

		// Token: 0x17007CDA RID: 31962
		// (get) Token: 0x0601FAB3 RID: 129715 RVA: 0x002F1983 File Offset: 0x002EFB83
		// (set) Token: 0x0601FAB4 RID: 129716 RVA: 0x002F1997 File Offset: 0x002EFB97
		public unsafe string Word
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLGUIThaiWordRow.__PropertyOffset_Word)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLGUIThaiWordRow.__PropertyOffset_Word)), value);
			}
		}

		// Token: 0x0601FAB5 RID: 129717 RVA: 0x002F19AC File Offset: 0x002EFBAC
		public FLGUIThaiWordRow()
		{
		}

		// Token: 0x0601FAB6 RID: 129718 RVA: 0x002F19B4 File Offset: 0x002EFBB4
		public FLGUIThaiWordRow(string Word)
		{
			this.Word = Word;
		}

		// Token: 0x0601FAB7 RID: 129719 RVA: 0x002F19C3 File Offset: 0x002EFBC3
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIThaiWordRow.StaticStruct();
		}

		// Token: 0x0601FAB8 RID: 129720 RVA: 0x002F19CF File Offset: 0x002EFBCF
		[NullableContext(2)]
		public FLGUIThaiWordRow(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FAB9 RID: 129721 RVA: 0x002F19D9 File Offset: 0x002EFBD9
		public FLGUIThaiWordRow(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FABA RID: 129722 RVA: 0x002F19E4 File Offset: 0x002EFBE4
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIThaiWordRow(Pointer, false, true);
		}

		// Token: 0x0601FABB RID: 129723 RVA: 0x002F19EE File Offset: 0x002EFBEE
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIThaiWordRow(Pointer, MemoryOwner);
		}

		// Token: 0x04011168 RID: 69992
		public new const string __ObjectPath = "/Script/LGUI.LGUIThaiWordRow";

		// Token: 0x04011169 RID: 69993
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401116A RID: 69994
		internal static int __PropertyOffset_Word;
	}
}
