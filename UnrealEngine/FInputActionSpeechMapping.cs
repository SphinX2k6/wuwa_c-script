using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C4F RID: 3151
	[UnrealObjectPath("/Script/Engine.InputActionSpeechMapping")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FInputActionSpeechMapping : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009FC2 RID: 40898 RVA: 0x000E3111 File Offset: 0x000E1311
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInputActionSpeechMapping._ScriptStructPtr != 0) ? FInputActionSpeechMapping._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InputActionSpeechMapping", ref FInputActionSpeechMapping._ScriptStructPtr);
		}

		// Token: 0x17002613 RID: 9747
		// (get) Token: 0x06009FC3 RID: 40899 RVA: 0x000E3135 File Offset: 0x000E1335
		// (set) Token: 0x06009FC4 RID: 40900 RVA: 0x000E3149 File Offset: 0x000E1349
		public unsafe FName ActionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputActionSpeechMapping.__PropertyOffset_ActionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputActionSpeechMapping.__PropertyOffset_ActionName) = value;
			}
		}

		// Token: 0x17002614 RID: 9748
		// (get) Token: 0x06009FC5 RID: 40901 RVA: 0x000E315E File Offset: 0x000E135E
		// (set) Token: 0x06009FC6 RID: 40902 RVA: 0x000E3172 File Offset: 0x000E1372
		public unsafe FName SpeechKeyword
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputActionSpeechMapping.__PropertyOffset_SpeechKeyword);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputActionSpeechMapping.__PropertyOffset_SpeechKeyword) = value;
			}
		}

		// Token: 0x06009FC7 RID: 40903 RVA: 0x000E3187 File Offset: 0x000E1387
		public FInputActionSpeechMapping()
		{
		}

		// Token: 0x06009FC8 RID: 40904 RVA: 0x000E318F File Offset: 0x000E138F
		public FInputActionSpeechMapping(FName ActionName, FName SpeechKeyword)
		{
			this.ActionName = ActionName;
			this.SpeechKeyword = SpeechKeyword;
		}

		// Token: 0x06009FC9 RID: 40905 RVA: 0x000E31A5 File Offset: 0x000E13A5
		protected override IntPtr GetUStructPtr()
		{
			return FInputActionSpeechMapping.StaticStruct();
		}

		// Token: 0x06009FCA RID: 40906 RVA: 0x000E31B1 File Offset: 0x000E13B1
		[NullableContext(2)]
		public FInputActionSpeechMapping(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009FCB RID: 40907 RVA: 0x000E31BB File Offset: 0x000E13BB
		public FInputActionSpeechMapping(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009FCC RID: 40908 RVA: 0x000E31C6 File Offset: 0x000E13C6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInputActionSpeechMapping(Pointer, false, true);
		}

		// Token: 0x06009FCD RID: 40909 RVA: 0x000E31D0 File Offset: 0x000E13D0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInputActionSpeechMapping(Pointer, MemoryOwner);
		}

		// Token: 0x040057EE RID: 22510
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.InputActionSpeechMapping";

		// Token: 0x040057EF RID: 22511
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040057F0 RID: 22512
		internal static int __PropertyOffset_ActionName;

		// Token: 0x040057F1 RID: 22513
		internal static int __PropertyOffset_SpeechKeyword;
	}
}
