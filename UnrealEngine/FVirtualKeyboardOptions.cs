using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002861 RID: 10337
	[UnrealObjectPath("/Script/Slate.VirtualKeyboardOptions")]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1)]
	public class FVirtualKeyboardOptions : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026541 RID: 156993 RVA: 0x003A398D File Offset: 0x003A1B8D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVirtualKeyboardOptions._ScriptStructPtr != 0) ? FVirtualKeyboardOptions._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Slate.VirtualKeyboardOptions", ref FVirtualKeyboardOptions._ScriptStructPtr);
		}

		// Token: 0x170093F5 RID: 37877
		// (get) Token: 0x06026542 RID: 156994 RVA: 0x003A39B1 File Offset: 0x003A1BB1
		// (set) Token: 0x06026543 RID: 156995 RVA: 0x003A39C1 File Offset: 0x003A1BC1
		public unsafe bool bEnableAutocorrect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVirtualKeyboardOptions.__PropertyOffset_bEnableAutocorrect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVirtualKeyboardOptions.__PropertyOffset_bEnableAutocorrect) = (value ? 1 : 0);
			}
		}

		// Token: 0x06026544 RID: 156996 RVA: 0x003A39D2 File Offset: 0x003A1BD2
		public FVirtualKeyboardOptions()
		{
		}

		// Token: 0x06026545 RID: 156997 RVA: 0x003A39DA File Offset: 0x003A1BDA
		public FVirtualKeyboardOptions(bool bEnableAutocorrect)
		{
			this.bEnableAutocorrect = bEnableAutocorrect;
		}

		// Token: 0x06026546 RID: 156998 RVA: 0x003A39E9 File Offset: 0x003A1BE9
		protected override IntPtr GetUStructPtr()
		{
			return FVirtualKeyboardOptions.StaticStruct();
		}

		// Token: 0x06026547 RID: 156999 RVA: 0x003A39F5 File Offset: 0x003A1BF5
		[NullableContext(2)]
		public FVirtualKeyboardOptions(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026548 RID: 157000 RVA: 0x003A39FF File Offset: 0x003A1BFF
		public FVirtualKeyboardOptions(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026549 RID: 157001 RVA: 0x003A3A0A File Offset: 0x003A1C0A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVirtualKeyboardOptions(Pointer, false, true);
		}

		// Token: 0x0602654A RID: 157002 RVA: 0x003A3A14 File Offset: 0x003A1C14
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVirtualKeyboardOptions(Pointer, MemoryOwner);
		}

		// Token: 0x0401503D RID: 86077
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Slate.VirtualKeyboardOptions";

		// Token: 0x0401503E RID: 86078
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401503F RID: 86079
		internal static int __PropertyOffset_bEnableAutocorrect;
	}
}
