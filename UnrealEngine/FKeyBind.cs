using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CC8 RID: 3272
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KeyBind")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FKeyBind : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A559 RID: 42329 RVA: 0x000EB338 File Offset: 0x000E9538
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKeyBind._ScriptStructPtr != 0) ? FKeyBind._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KeyBind", ref FKeyBind._ScriptStructPtr);
		}

		// Token: 0x17002752 RID: 10066
		// (get) Token: 0x0600A55A RID: 42330 RVA: 0x000EB35C File Offset: 0x000E955C
		// (set) Token: 0x0600A55B RID: 42331 RVA: 0x000EB39F File Offset: 0x000E959F
		public FKey Key
		{
			get
			{
				base.FastCheckIsValid();
				FKey result;
				if ((result = this._Key) == null)
				{
					result = (this._Key = new FKey(base.NativePtr + (IntPtr)FKeyBind.__PropertyOffset_Key, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), base.NativePtr + (IntPtr)FKeyBind.__PropertyOffset_Key, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002753 RID: 10067
		// (get) Token: 0x0600A55C RID: 42332 RVA: 0x000EB3C0 File Offset: 0x000E95C0
		// (set) Token: 0x0600A55D RID: 42333 RVA: 0x000EB3D4 File Offset: 0x000E95D4
		public unsafe string Command
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKeyBind.__PropertyOffset_Command)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKeyBind.__PropertyOffset_Command)), value);
			}
		}

		// Token: 0x17002754 RID: 10068
		// (get) Token: 0x0600A55E RID: 42334 RVA: 0x000EB3E9 File Offset: 0x000E95E9
		// (set) Token: 0x0600A55F RID: 42335 RVA: 0x000EB402 File Offset: 0x000E9602
		public unsafe bool Control
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKeyBind.__PropertyOffset_Control) & FKeyBind.__PropertyMask_Control) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKeyBind.__PropertyOffset_Control) = ((*(base.NativePtr + (IntPtr)FKeyBind.__PropertyOffset_Control) & ~FKeyBind.__PropertyMask_Control) | (value ? FKeyBind.__PropertyMask_Control : 0));
			}
		}

		// Token: 0x17002755 RID: 10069
		// (get) Token: 0x0600A560 RID: 42336 RVA: 0x000EB432 File Offset: 0x000E9632
		// (set) Token: 0x0600A561 RID: 42337 RVA: 0x000EB44B File Offset: 0x000E964B
		public unsafe bool Shift
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKeyBind.__PropertyOffset_Shift) & FKeyBind.__PropertyMask_Shift) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKeyBind.__PropertyOffset_Shift) = ((*(base.NativePtr + (IntPtr)FKeyBind.__PropertyOffset_Shift) & ~FKeyBind.__PropertyMask_Shift) | (value ? FKeyBind.__PropertyMask_Shift : 0));
			}
		}

		// Token: 0x17002756 RID: 10070
		// (get) Token: 0x0600A562 RID: 42338 RVA: 0x000EB47B File Offset: 0x000E967B
		// (set) Token: 0x0600A563 RID: 42339 RVA: 0x000EB494 File Offset: 0x000E9694
		public unsafe bool Alt
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKeyBind.__PropertyOffset_Alt) & FKeyBind.__PropertyMask_Alt) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKeyBind.__PropertyOffset_Alt) = ((*(base.NativePtr + (IntPtr)FKeyBind.__PropertyOffset_Alt) & ~FKeyBind.__PropertyMask_Alt) | (value ? FKeyBind.__PropertyMask_Alt : 0));
			}
		}

		// Token: 0x17002757 RID: 10071
		// (get) Token: 0x0600A564 RID: 42340 RVA: 0x000EB4C4 File Offset: 0x000E96C4
		// (set) Token: 0x0600A565 RID: 42341 RVA: 0x000EB4DD File Offset: 0x000E96DD
		public unsafe bool Cmd
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKeyBind.__PropertyOffset_Cmd) & FKeyBind.__PropertyMask_Cmd) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKeyBind.__PropertyOffset_Cmd) = ((*(base.NativePtr + (IntPtr)FKeyBind.__PropertyOffset_Cmd) & ~FKeyBind.__PropertyMask_Cmd) | (value ? FKeyBind.__PropertyMask_Cmd : 0));
			}
		}

		// Token: 0x17002758 RID: 10072
		// (get) Token: 0x0600A566 RID: 42342 RVA: 0x000EB50D File Offset: 0x000E970D
		// (set) Token: 0x0600A567 RID: 42343 RVA: 0x000EB526 File Offset: 0x000E9726
		public unsafe bool bIgnoreCtrl
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKeyBind.__PropertyOffset_bIgnoreCtrl) & FKeyBind.__PropertyMask_bIgnoreCtrl) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKeyBind.__PropertyOffset_bIgnoreCtrl) = ((*(base.NativePtr + (IntPtr)FKeyBind.__PropertyOffset_bIgnoreCtrl) & ~FKeyBind.__PropertyMask_bIgnoreCtrl) | (value ? FKeyBind.__PropertyMask_bIgnoreCtrl : 0));
			}
		}

		// Token: 0x17002759 RID: 10073
		// (get) Token: 0x0600A568 RID: 42344 RVA: 0x000EB556 File Offset: 0x000E9756
		// (set) Token: 0x0600A569 RID: 42345 RVA: 0x000EB56F File Offset: 0x000E976F
		public unsafe bool bIgnoreShift
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKeyBind.__PropertyOffset_bIgnoreShift) & FKeyBind.__PropertyMask_bIgnoreShift) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKeyBind.__PropertyOffset_bIgnoreShift) = ((*(base.NativePtr + (IntPtr)FKeyBind.__PropertyOffset_bIgnoreShift) & ~FKeyBind.__PropertyMask_bIgnoreShift) | (value ? FKeyBind.__PropertyMask_bIgnoreShift : 0));
			}
		}

		// Token: 0x1700275A RID: 10074
		// (get) Token: 0x0600A56A RID: 42346 RVA: 0x000EB59F File Offset: 0x000E979F
		// (set) Token: 0x0600A56B RID: 42347 RVA: 0x000EB5B8 File Offset: 0x000E97B8
		public unsafe bool bIgnoreAlt
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKeyBind.__PropertyOffset_bIgnoreAlt) & FKeyBind.__PropertyMask_bIgnoreAlt) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKeyBind.__PropertyOffset_bIgnoreAlt) = ((*(base.NativePtr + (IntPtr)FKeyBind.__PropertyOffset_bIgnoreAlt) & ~FKeyBind.__PropertyMask_bIgnoreAlt) | (value ? FKeyBind.__PropertyMask_bIgnoreAlt : 0));
			}
		}

		// Token: 0x1700275B RID: 10075
		// (get) Token: 0x0600A56C RID: 42348 RVA: 0x000EB5E8 File Offset: 0x000E97E8
		// (set) Token: 0x0600A56D RID: 42349 RVA: 0x000EB601 File Offset: 0x000E9801
		public unsafe bool bIgnoreCmd
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKeyBind.__PropertyOffset_bIgnoreCmd) & FKeyBind.__PropertyMask_bIgnoreCmd) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKeyBind.__PropertyOffset_bIgnoreCmd) = ((*(base.NativePtr + (IntPtr)FKeyBind.__PropertyOffset_bIgnoreCmd) & ~FKeyBind.__PropertyMask_bIgnoreCmd) | (value ? FKeyBind.__PropertyMask_bIgnoreCmd : 0));
			}
		}

		// Token: 0x1700275C RID: 10076
		// (get) Token: 0x0600A56E RID: 42350 RVA: 0x000EB631 File Offset: 0x000E9831
		// (set) Token: 0x0600A56F RID: 42351 RVA: 0x000EB64A File Offset: 0x000E984A
		public unsafe bool bDisabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKeyBind.__PropertyOffset_bDisabled) & FKeyBind.__PropertyMask_bDisabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKeyBind.__PropertyOffset_bDisabled) = ((*(base.NativePtr + (IntPtr)FKeyBind.__PropertyOffset_bDisabled) & ~FKeyBind.__PropertyMask_bDisabled) | (value ? FKeyBind.__PropertyMask_bDisabled : 0));
			}
		}

		// Token: 0x0600A570 RID: 42352 RVA: 0x000EB67A File Offset: 0x000E987A
		public FKeyBind()
		{
		}

		// Token: 0x0600A571 RID: 42353 RVA: 0x000EB684 File Offset: 0x000E9884
		public FKeyBind(FKey Key, string Command, bool Control, bool Shift, bool Alt, bool Cmd, bool bIgnoreCtrl, bool bIgnoreShift, bool bIgnoreAlt, bool bIgnoreCmd, bool bDisabled)
		{
			this.Key = Key;
			this.Command = Command;
			this.Control = Control;
			this.Shift = Shift;
			this.Alt = Alt;
			this.Cmd = Cmd;
			this.bIgnoreCtrl = bIgnoreCtrl;
			this.bIgnoreShift = bIgnoreShift;
			this.bIgnoreAlt = bIgnoreAlt;
			this.bIgnoreCmd = bIgnoreCmd;
			this.bDisabled = bDisabled;
		}

		// Token: 0x0600A572 RID: 42354 RVA: 0x000EB6EC File Offset: 0x000E98EC
		protected override IntPtr GetUStructPtr()
		{
			return FKeyBind.StaticStruct();
		}

		// Token: 0x0600A573 RID: 42355 RVA: 0x000EB6F8 File Offset: 0x000E98F8
		[NullableContext(2)]
		public FKeyBind(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A574 RID: 42356 RVA: 0x000EB702 File Offset: 0x000E9902
		public FKeyBind(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A575 RID: 42357 RVA: 0x000EB70D File Offset: 0x000E990D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKeyBind(Pointer, false, true);
		}

		// Token: 0x0600A576 RID: 42358 RVA: 0x000EB717 File Offset: 0x000E9917
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKeyBind(Pointer, MemoryOwner);
		}

		// Token: 0x04005AF3 RID: 23283
		public const string __ObjectPath = "/Script/Engine.KeyBind";

		// Token: 0x04005AF4 RID: 23284
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005AF5 RID: 23285
		internal static int __PropertyOffset_Key;

		// Token: 0x04005AF6 RID: 23286
		[Nullable(2)]
		private FKey _Key;

		// Token: 0x04005AF7 RID: 23287
		internal static int __PropertyOffset_Command;

		// Token: 0x04005AF8 RID: 23288
		internal static int __PropertyOffset_Control;

		// Token: 0x04005AF9 RID: 23289
		internal static byte __PropertyMask_Control;

		// Token: 0x04005AFA RID: 23290
		internal static int __PropertyOffset_Shift;

		// Token: 0x04005AFB RID: 23291
		internal static byte __PropertyMask_Shift;

		// Token: 0x04005AFC RID: 23292
		internal static int __PropertyOffset_Alt;

		// Token: 0x04005AFD RID: 23293
		internal static byte __PropertyMask_Alt;

		// Token: 0x04005AFE RID: 23294
		internal static int __PropertyOffset_Cmd;

		// Token: 0x04005AFF RID: 23295
		internal static byte __PropertyMask_Cmd;

		// Token: 0x04005B00 RID: 23296
		internal static int __PropertyOffset_bIgnoreCtrl;

		// Token: 0x04005B01 RID: 23297
		internal static byte __PropertyMask_bIgnoreCtrl;

		// Token: 0x04005B02 RID: 23298
		internal static int __PropertyOffset_bIgnoreShift;

		// Token: 0x04005B03 RID: 23299
		internal static byte __PropertyMask_bIgnoreShift;

		// Token: 0x04005B04 RID: 23300
		internal static int __PropertyOffset_bIgnoreAlt;

		// Token: 0x04005B05 RID: 23301
		internal static byte __PropertyMask_bIgnoreAlt;

		// Token: 0x04005B06 RID: 23302
		internal static int __PropertyOffset_bIgnoreCmd;

		// Token: 0x04005B07 RID: 23303
		internal static byte __PropertyMask_bIgnoreCmd;

		// Token: 0x04005B08 RID: 23304
		internal static int __PropertyOffset_bDisabled;

		// Token: 0x04005B09 RID: 23305
		internal static byte __PropertyMask_bDisabled;
	}
}
