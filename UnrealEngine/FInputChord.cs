using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002859 RID: 10329
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Slate.InputChord")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FInputChord : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026501 RID: 156929 RVA: 0x003A323D File Offset: 0x003A143D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInputChord._ScriptStructPtr != 0) ? FInputChord._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Slate.InputChord", ref FInputChord._ScriptStructPtr);
		}

		// Token: 0x170093EA RID: 37866
		// (get) Token: 0x06026502 RID: 156930 RVA: 0x003A3264 File Offset: 0x003A1464
		// (set) Token: 0x06026503 RID: 156931 RVA: 0x003A32A7 File Offset: 0x003A14A7
		public FKey Key
		{
			get
			{
				base.FastCheckIsValid();
				FKey result;
				if ((result = this._Key) == null)
				{
					result = (this._Key = new FKey(base.NativePtr + (IntPtr)FInputChord.__PropertyOffset_Key, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), base.NativePtr + (IntPtr)FInputChord.__PropertyOffset_Key, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093EB RID: 37867
		// (get) Token: 0x06026504 RID: 156932 RVA: 0x003A32C8 File Offset: 0x003A14C8
		// (set) Token: 0x06026505 RID: 156933 RVA: 0x003A32E1 File Offset: 0x003A14E1
		public unsafe bool bShift
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FInputChord.__PropertyOffset_bShift) & FInputChord.__PropertyMask_bShift) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FInputChord.__PropertyOffset_bShift) = ((*(base.NativePtr + (IntPtr)FInputChord.__PropertyOffset_bShift) & ~FInputChord.__PropertyMask_bShift) | (value ? FInputChord.__PropertyMask_bShift : 0));
			}
		}

		// Token: 0x170093EC RID: 37868
		// (get) Token: 0x06026506 RID: 156934 RVA: 0x003A3311 File Offset: 0x003A1511
		// (set) Token: 0x06026507 RID: 156935 RVA: 0x003A332A File Offset: 0x003A152A
		public unsafe bool bCtrl
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FInputChord.__PropertyOffset_bCtrl) & FInputChord.__PropertyMask_bCtrl) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FInputChord.__PropertyOffset_bCtrl) = ((*(base.NativePtr + (IntPtr)FInputChord.__PropertyOffset_bCtrl) & ~FInputChord.__PropertyMask_bCtrl) | (value ? FInputChord.__PropertyMask_bCtrl : 0));
			}
		}

		// Token: 0x170093ED RID: 37869
		// (get) Token: 0x06026508 RID: 156936 RVA: 0x003A335A File Offset: 0x003A155A
		// (set) Token: 0x06026509 RID: 156937 RVA: 0x003A3373 File Offset: 0x003A1573
		public unsafe bool bAlt
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FInputChord.__PropertyOffset_bAlt) & FInputChord.__PropertyMask_bAlt) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FInputChord.__PropertyOffset_bAlt) = ((*(base.NativePtr + (IntPtr)FInputChord.__PropertyOffset_bAlt) & ~FInputChord.__PropertyMask_bAlt) | (value ? FInputChord.__PropertyMask_bAlt : 0));
			}
		}

		// Token: 0x170093EE RID: 37870
		// (get) Token: 0x0602650A RID: 156938 RVA: 0x003A33A3 File Offset: 0x003A15A3
		// (set) Token: 0x0602650B RID: 156939 RVA: 0x003A33BC File Offset: 0x003A15BC
		public unsafe bool bCmd
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FInputChord.__PropertyOffset_bCmd) & FInputChord.__PropertyMask_bCmd) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FInputChord.__PropertyOffset_bCmd) = ((*(base.NativePtr + (IntPtr)FInputChord.__PropertyOffset_bCmd) & ~FInputChord.__PropertyMask_bCmd) | (value ? FInputChord.__PropertyMask_bCmd : 0));
			}
		}

		// Token: 0x0602650C RID: 156940 RVA: 0x003A33EC File Offset: 0x003A15EC
		public FInputChord()
		{
		}

		// Token: 0x0602650D RID: 156941 RVA: 0x003A33F4 File Offset: 0x003A15F4
		public FInputChord(FKey Key, bool bShift, bool bCtrl, bool bAlt, bool bCmd)
		{
			this.Key = Key;
			this.bShift = bShift;
			this.bCtrl = bCtrl;
			this.bAlt = bAlt;
			this.bCmd = bCmd;
		}

		// Token: 0x0602650E RID: 156942 RVA: 0x003A3421 File Offset: 0x003A1621
		protected override IntPtr GetUStructPtr()
		{
			return FInputChord.StaticStruct();
		}

		// Token: 0x0602650F RID: 156943 RVA: 0x003A342D File Offset: 0x003A162D
		[NullableContext(2)]
		public FInputChord(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026510 RID: 156944 RVA: 0x003A3437 File Offset: 0x003A1637
		public FInputChord(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026511 RID: 156945 RVA: 0x003A3442 File Offset: 0x003A1642
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInputChord(Pointer, false, true);
		}

		// Token: 0x06026512 RID: 156946 RVA: 0x003A344C File Offset: 0x003A164C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInputChord(Pointer, MemoryOwner);
		}

		// Token: 0x04015011 RID: 86033
		public const string __ObjectPath = "/Script/Slate.InputChord";

		// Token: 0x04015012 RID: 86034
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015013 RID: 86035
		internal static int __PropertyOffset_Key;

		// Token: 0x04015014 RID: 86036
		[Nullable(2)]
		private FKey _Key;

		// Token: 0x04015015 RID: 86037
		internal static int __PropertyOffset_bShift;

		// Token: 0x04015016 RID: 86038
		internal static byte __PropertyMask_bShift;

		// Token: 0x04015017 RID: 86039
		internal static int __PropertyOffset_bCtrl;

		// Token: 0x04015018 RID: 86040
		internal static byte __PropertyMask_bCtrl;

		// Token: 0x04015019 RID: 86041
		internal static int __PropertyOffset_bAlt;

		// Token: 0x0401501A RID: 86042
		internal static byte __PropertyMask_bAlt;

		// Token: 0x0401501B RID: 86043
		internal static int __PropertyOffset_bCmd;

		// Token: 0x0401501C RID: 86044
		internal static byte __PropertyMask_bCmd;
	}
}
