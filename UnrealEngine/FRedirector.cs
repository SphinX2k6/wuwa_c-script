using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001076 RID: 4214
	[UnrealObjectPath("/Script/Engine.Redirector")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRedirector : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EFCD RID: 61389 RVA: 0x00163893 File Offset: 0x00161A93
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRedirector._ScriptStructPtr != 0) ? FRedirector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.Redirector", ref FRedirector._ScriptStructPtr);
		}

		// Token: 0x17003A0A RID: 14858
		// (get) Token: 0x0600EFCE RID: 61390 RVA: 0x001638B7 File Offset: 0x00161AB7
		// (set) Token: 0x0600EFCF RID: 61391 RVA: 0x001638CB File Offset: 0x00161ACB
		public unsafe FName OldName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRedirector.__PropertyOffset_OldName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRedirector.__PropertyOffset_OldName) = value;
			}
		}

		// Token: 0x17003A0B RID: 14859
		// (get) Token: 0x0600EFD0 RID: 61392 RVA: 0x001638E0 File Offset: 0x00161AE0
		// (set) Token: 0x0600EFD1 RID: 61393 RVA: 0x001638F4 File Offset: 0x00161AF4
		public unsafe FName NewName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRedirector.__PropertyOffset_NewName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRedirector.__PropertyOffset_NewName) = value;
			}
		}

		// Token: 0x0600EFD2 RID: 61394 RVA: 0x00163909 File Offset: 0x00161B09
		public FRedirector()
		{
		}

		// Token: 0x0600EFD3 RID: 61395 RVA: 0x00163911 File Offset: 0x00161B11
		public FRedirector(FName OldName, FName NewName)
		{
			this.OldName = OldName;
			this.NewName = NewName;
		}

		// Token: 0x0600EFD4 RID: 61396 RVA: 0x00163927 File Offset: 0x00161B27
		protected override IntPtr GetUStructPtr()
		{
			return FRedirector.StaticStruct();
		}

		// Token: 0x0600EFD5 RID: 61397 RVA: 0x00163933 File Offset: 0x00161B33
		[NullableContext(2)]
		public FRedirector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EFD6 RID: 61398 RVA: 0x0016393D File Offset: 0x00161B3D
		public FRedirector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EFD7 RID: 61399 RVA: 0x00163948 File Offset: 0x00161B48
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRedirector(Pointer, false, true);
		}

		// Token: 0x0600EFD8 RID: 61400 RVA: 0x00163952 File Offset: 0x00161B52
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRedirector(Pointer, MemoryOwner);
		}

		// Token: 0x040081B7 RID: 33207
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.Redirector";

		// Token: 0x040081B8 RID: 33208
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040081B9 RID: 33209
		internal static int __PropertyOffset_OldName;

		// Token: 0x040081BA RID: 33210
		internal static int __PropertyOffset_NewName;
	}
}
