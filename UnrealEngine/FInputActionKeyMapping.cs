using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C4E RID: 3150
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InputActionKeyMapping")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FInputActionKeyMapping : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009FAE RID: 40878 RVA: 0x000E2ECA File Offset: 0x000E10CA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInputActionKeyMapping._ScriptStructPtr != 0) ? FInputActionKeyMapping._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InputActionKeyMapping", ref FInputActionKeyMapping._ScriptStructPtr);
		}

		// Token: 0x1700260D RID: 9741
		// (get) Token: 0x06009FAF RID: 40879 RVA: 0x000E2EEE File Offset: 0x000E10EE
		// (set) Token: 0x06009FB0 RID: 40880 RVA: 0x000E2F02 File Offset: 0x000E1102
		public unsafe FName ActionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputActionKeyMapping.__PropertyOffset_ActionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputActionKeyMapping.__PropertyOffset_ActionName) = value;
			}
		}

		// Token: 0x1700260E RID: 9742
		// (get) Token: 0x06009FB1 RID: 40881 RVA: 0x000E2F17 File Offset: 0x000E1117
		// (set) Token: 0x06009FB2 RID: 40882 RVA: 0x000E2F30 File Offset: 0x000E1130
		public unsafe bool bShift
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FInputActionKeyMapping.__PropertyOffset_bShift) & FInputActionKeyMapping.__PropertyMask_bShift) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FInputActionKeyMapping.__PropertyOffset_bShift) = ((*(base.NativePtr + (IntPtr)FInputActionKeyMapping.__PropertyOffset_bShift) & ~FInputActionKeyMapping.__PropertyMask_bShift) | (value ? FInputActionKeyMapping.__PropertyMask_bShift : 0));
			}
		}

		// Token: 0x1700260F RID: 9743
		// (get) Token: 0x06009FB3 RID: 40883 RVA: 0x000E2F60 File Offset: 0x000E1160
		// (set) Token: 0x06009FB4 RID: 40884 RVA: 0x000E2F79 File Offset: 0x000E1179
		public unsafe bool bCtrl
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FInputActionKeyMapping.__PropertyOffset_bCtrl) & FInputActionKeyMapping.__PropertyMask_bCtrl) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FInputActionKeyMapping.__PropertyOffset_bCtrl) = ((*(base.NativePtr + (IntPtr)FInputActionKeyMapping.__PropertyOffset_bCtrl) & ~FInputActionKeyMapping.__PropertyMask_bCtrl) | (value ? FInputActionKeyMapping.__PropertyMask_bCtrl : 0));
			}
		}

		// Token: 0x17002610 RID: 9744
		// (get) Token: 0x06009FB5 RID: 40885 RVA: 0x000E2FA9 File Offset: 0x000E11A9
		// (set) Token: 0x06009FB6 RID: 40886 RVA: 0x000E2FC2 File Offset: 0x000E11C2
		public unsafe bool bAlt
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FInputActionKeyMapping.__PropertyOffset_bAlt) & FInputActionKeyMapping.__PropertyMask_bAlt) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FInputActionKeyMapping.__PropertyOffset_bAlt) = ((*(base.NativePtr + (IntPtr)FInputActionKeyMapping.__PropertyOffset_bAlt) & ~FInputActionKeyMapping.__PropertyMask_bAlt) | (value ? FInputActionKeyMapping.__PropertyMask_bAlt : 0));
			}
		}

		// Token: 0x17002611 RID: 9745
		// (get) Token: 0x06009FB7 RID: 40887 RVA: 0x000E2FF2 File Offset: 0x000E11F2
		// (set) Token: 0x06009FB8 RID: 40888 RVA: 0x000E300B File Offset: 0x000E120B
		public unsafe bool bCmd
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FInputActionKeyMapping.__PropertyOffset_bCmd) & FInputActionKeyMapping.__PropertyMask_bCmd) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FInputActionKeyMapping.__PropertyOffset_bCmd) = ((*(base.NativePtr + (IntPtr)FInputActionKeyMapping.__PropertyOffset_bCmd) & ~FInputActionKeyMapping.__PropertyMask_bCmd) | (value ? FInputActionKeyMapping.__PropertyMask_bCmd : 0));
			}
		}

		// Token: 0x17002612 RID: 9746
		// (get) Token: 0x06009FB9 RID: 40889 RVA: 0x000E303C File Offset: 0x000E123C
		// (set) Token: 0x06009FBA RID: 40890 RVA: 0x000E307F File Offset: 0x000E127F
		public FKey Key
		{
			get
			{
				base.FastCheckIsValid();
				FKey result;
				if ((result = this._Key) == null)
				{
					result = (this._Key = new FKey(base.NativePtr + (IntPtr)FInputActionKeyMapping.__PropertyOffset_Key, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), base.NativePtr + (IntPtr)FInputActionKeyMapping.__PropertyOffset_Key, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06009FBB RID: 40891 RVA: 0x000E30A0 File Offset: 0x000E12A0
		public FInputActionKeyMapping()
		{
		}

		// Token: 0x06009FBC RID: 40892 RVA: 0x000E30A8 File Offset: 0x000E12A8
		public FInputActionKeyMapping(FName ActionName, bool bShift, bool bCtrl, bool bAlt, bool bCmd, FKey Key)
		{
			this.ActionName = ActionName;
			this.bShift = bShift;
			this.bCtrl = bCtrl;
			this.bAlt = bAlt;
			this.bCmd = bCmd;
			this.Key = Key;
		}

		// Token: 0x06009FBD RID: 40893 RVA: 0x000E30DD File Offset: 0x000E12DD
		protected override IntPtr GetUStructPtr()
		{
			return FInputActionKeyMapping.StaticStruct();
		}

		// Token: 0x06009FBE RID: 40894 RVA: 0x000E30E9 File Offset: 0x000E12E9
		[NullableContext(2)]
		public FInputActionKeyMapping(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009FBF RID: 40895 RVA: 0x000E30F3 File Offset: 0x000E12F3
		public FInputActionKeyMapping(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009FC0 RID: 40896 RVA: 0x000E30FE File Offset: 0x000E12FE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInputActionKeyMapping(Pointer, false, true);
		}

		// Token: 0x06009FC1 RID: 40897 RVA: 0x000E3108 File Offset: 0x000E1308
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInputActionKeyMapping(Pointer, MemoryOwner);
		}

		// Token: 0x040057E1 RID: 22497
		public const string __ObjectPath = "/Script/Engine.InputActionKeyMapping";

		// Token: 0x040057E2 RID: 22498
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040057E3 RID: 22499
		internal static int __PropertyOffset_ActionName;

		// Token: 0x040057E4 RID: 22500
		internal static int __PropertyOffset_bShift;

		// Token: 0x040057E5 RID: 22501
		internal static byte __PropertyMask_bShift;

		// Token: 0x040057E6 RID: 22502
		internal static int __PropertyOffset_bCtrl;

		// Token: 0x040057E7 RID: 22503
		internal static byte __PropertyMask_bCtrl;

		// Token: 0x040057E8 RID: 22504
		internal static int __PropertyOffset_bAlt;

		// Token: 0x040057E9 RID: 22505
		internal static byte __PropertyMask_bAlt;

		// Token: 0x040057EA RID: 22506
		internal static int __PropertyOffset_bCmd;

		// Token: 0x040057EB RID: 22507
		internal static byte __PropertyMask_bCmd;

		// Token: 0x040057EC RID: 22508
		internal static int __PropertyOffset_Key;

		// Token: 0x040057ED RID: 22509
		[Nullable(2)]
		private FKey _Key;
	}
}
