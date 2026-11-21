using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200021D RID: 541
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InputActionKeyMapping")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FInputActionKeyMapping : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060024AB RID: 9387 RVA: 0x00034CC9 File Offset: 0x00032EC9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInputActionKeyMapping._ScriptStructPtr != 0) ? FInputActionKeyMapping._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InputActionKeyMapping", ref FInputActionKeyMapping._ScriptStructPtr);
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x060024AC RID: 9388 RVA: 0x00034CED File Offset: 0x00032EED
		// (set) Token: 0x060024AD RID: 9389 RVA: 0x00034D01 File Offset: 0x00032F01
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

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x060024AE RID: 9390 RVA: 0x00034D16 File Offset: 0x00032F16
		// (set) Token: 0x060024AF RID: 9391 RVA: 0x00034D2F File Offset: 0x00032F2F
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

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x060024B0 RID: 9392 RVA: 0x00034D5F File Offset: 0x00032F5F
		// (set) Token: 0x060024B1 RID: 9393 RVA: 0x00034D78 File Offset: 0x00032F78
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

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x060024B2 RID: 9394 RVA: 0x00034DA8 File Offset: 0x00032FA8
		// (set) Token: 0x060024B3 RID: 9395 RVA: 0x00034DC1 File Offset: 0x00032FC1
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

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x060024B4 RID: 9396 RVA: 0x00034DF1 File Offset: 0x00032FF1
		// (set) Token: 0x060024B5 RID: 9397 RVA: 0x00034E0A File Offset: 0x0003300A
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

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x060024B6 RID: 9398 RVA: 0x00034E3C File Offset: 0x0003303C
		// (set) Token: 0x060024B7 RID: 9399 RVA: 0x00034E7F File Offset: 0x0003307F
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

		// Token: 0x060024B8 RID: 9400 RVA: 0x00034EA0 File Offset: 0x000330A0
		public FInputActionKeyMapping()
		{
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x00034EA8 File Offset: 0x000330A8
		protected override IntPtr GetUStructPtr()
		{
			return FInputActionKeyMapping.StaticStruct();
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x00034EB4 File Offset: 0x000330B4
		[NullableContext(2)]
		public FInputActionKeyMapping(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x00034EBE File Offset: 0x000330BE
		public FInputActionKeyMapping(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060024BC RID: 9404 RVA: 0x00034EC9 File Offset: 0x000330C9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInputActionKeyMapping(Pointer, false, true);
		}

		// Token: 0x060024BD RID: 9405 RVA: 0x00034ED3 File Offset: 0x000330D3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInputActionKeyMapping(Pointer, MemoryOwner);
		}

		// Token: 0x04000DC7 RID: 3527
		public const string __ObjectPath = "/Script/Engine.InputActionKeyMapping";

		// Token: 0x04000DC8 RID: 3528
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000DC9 RID: 3529
		internal static int __PropertyOffset_ActionName;

		// Token: 0x04000DCA RID: 3530
		internal static int __PropertyOffset_bShift;

		// Token: 0x04000DCB RID: 3531
		internal static byte __PropertyMask_bShift;

		// Token: 0x04000DCC RID: 3532
		internal static int __PropertyOffset_bCtrl;

		// Token: 0x04000DCD RID: 3533
		internal static byte __PropertyMask_bCtrl;

		// Token: 0x04000DCE RID: 3534
		internal static int __PropertyOffset_bAlt;

		// Token: 0x04000DCF RID: 3535
		internal static byte __PropertyMask_bAlt;

		// Token: 0x04000DD0 RID: 3536
		internal static int __PropertyOffset_bCmd;

		// Token: 0x04000DD1 RID: 3537
		internal static byte __PropertyMask_bCmd;

		// Token: 0x04000DD2 RID: 3538
		internal static int __PropertyOffset_Key;

		// Token: 0x04000DD3 RID: 3539
		[Nullable(2)]
		private FKey _Key;
	}
}
