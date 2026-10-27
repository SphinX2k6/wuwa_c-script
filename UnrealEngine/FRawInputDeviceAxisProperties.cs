using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200267C RID: 9852
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/RawInput.RawInputDeviceAxisProperties")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRawInputDeviceAxisProperties : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602496F RID: 149871 RVA: 0x0036299D File Offset: 0x00360B9D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRawInputDeviceAxisProperties._ScriptStructPtr != 0) ? FRawInputDeviceAxisProperties._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RawInput.RawInputDeviceAxisProperties", ref FRawInputDeviceAxisProperties._ScriptStructPtr);
		}

		// Token: 0x17008D17 RID: 36119
		// (get) Token: 0x06024970 RID: 149872 RVA: 0x003629C1 File Offset: 0x00360BC1
		// (set) Token: 0x06024971 RID: 149873 RVA: 0x003629DA File Offset: 0x00360BDA
		public unsafe bool bEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRawInputDeviceAxisProperties.__PropertyOffset_bEnabled) & FRawInputDeviceAxisProperties.__PropertyMask_bEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRawInputDeviceAxisProperties.__PropertyOffset_bEnabled) = ((*(base.NativePtr + (IntPtr)FRawInputDeviceAxisProperties.__PropertyOffset_bEnabled) & ~FRawInputDeviceAxisProperties.__PropertyMask_bEnabled) | (value ? FRawInputDeviceAxisProperties.__PropertyMask_bEnabled : 0));
			}
		}

		// Token: 0x17008D18 RID: 36120
		// (get) Token: 0x06024972 RID: 149874 RVA: 0x00362A0C File Offset: 0x00360C0C
		// (set) Token: 0x06024973 RID: 149875 RVA: 0x00362A4F File Offset: 0x00360C4F
		public FKey Key
		{
			get
			{
				base.FastCheckIsValid();
				FKey result;
				if ((result = this._Key) == null)
				{
					result = (this._Key = new FKey(base.NativePtr + (IntPtr)FRawInputDeviceAxisProperties.__PropertyOffset_Key, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), base.NativePtr + (IntPtr)FRawInputDeviceAxisProperties.__PropertyOffset_Key, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008D19 RID: 36121
		// (get) Token: 0x06024974 RID: 149876 RVA: 0x00362A70 File Offset: 0x00360C70
		// (set) Token: 0x06024975 RID: 149877 RVA: 0x00362A89 File Offset: 0x00360C89
		public unsafe bool bInverted
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRawInputDeviceAxisProperties.__PropertyOffset_bInverted) & FRawInputDeviceAxisProperties.__PropertyMask_bInverted) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRawInputDeviceAxisProperties.__PropertyOffset_bInverted) = ((*(base.NativePtr + (IntPtr)FRawInputDeviceAxisProperties.__PropertyOffset_bInverted) & ~FRawInputDeviceAxisProperties.__PropertyMask_bInverted) | (value ? FRawInputDeviceAxisProperties.__PropertyMask_bInverted : 0));
			}
		}

		// Token: 0x17008D1A RID: 36122
		// (get) Token: 0x06024976 RID: 149878 RVA: 0x00362AB9 File Offset: 0x00360CB9
		// (set) Token: 0x06024977 RID: 149879 RVA: 0x00362AD2 File Offset: 0x00360CD2
		public unsafe bool bGamepadStick
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRawInputDeviceAxisProperties.__PropertyOffset_bGamepadStick) & FRawInputDeviceAxisProperties.__PropertyMask_bGamepadStick) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRawInputDeviceAxisProperties.__PropertyOffset_bGamepadStick) = ((*(base.NativePtr + (IntPtr)FRawInputDeviceAxisProperties.__PropertyOffset_bGamepadStick) & ~FRawInputDeviceAxisProperties.__PropertyMask_bGamepadStick) | (value ? FRawInputDeviceAxisProperties.__PropertyMask_bGamepadStick : 0));
			}
		}

		// Token: 0x17008D1B RID: 36123
		// (get) Token: 0x06024978 RID: 149880 RVA: 0x00362B02 File Offset: 0x00360D02
		// (set) Token: 0x06024979 RID: 149881 RVA: 0x00362B12 File Offset: 0x00360D12
		public unsafe float Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRawInputDeviceAxisProperties.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRawInputDeviceAxisProperties.__PropertyOffset_Offset) = value;
			}
		}

		// Token: 0x0602497A RID: 149882 RVA: 0x00362B23 File Offset: 0x00360D23
		public FRawInputDeviceAxisProperties()
		{
		}

		// Token: 0x0602497B RID: 149883 RVA: 0x00362B2B File Offset: 0x00360D2B
		public FRawInputDeviceAxisProperties(bool bEnabled, FKey Key, bool bInverted, bool bGamepadStick, float Offset)
		{
			this.bEnabled = bEnabled;
			this.Key = Key;
			this.bInverted = bInverted;
			this.bGamepadStick = bGamepadStick;
			this.Offset = Offset;
		}

		// Token: 0x0602497C RID: 149884 RVA: 0x00362B58 File Offset: 0x00360D58
		protected override IntPtr GetUStructPtr()
		{
			return FRawInputDeviceAxisProperties.StaticStruct();
		}

		// Token: 0x0602497D RID: 149885 RVA: 0x00362B64 File Offset: 0x00360D64
		[NullableContext(2)]
		public FRawInputDeviceAxisProperties(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602497E RID: 149886 RVA: 0x00362B6E File Offset: 0x00360D6E
		public FRawInputDeviceAxisProperties(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602497F RID: 149887 RVA: 0x00362B79 File Offset: 0x00360D79
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRawInputDeviceAxisProperties(Pointer, false, true);
		}

		// Token: 0x06024980 RID: 149888 RVA: 0x00362B83 File Offset: 0x00360D83
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRawInputDeviceAxisProperties(Pointer, MemoryOwner);
		}

		// Token: 0x04013AA5 RID: 80549
		public const string __ObjectPath = "/Script/RawInput.RawInputDeviceAxisProperties";

		// Token: 0x04013AA6 RID: 80550
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013AA7 RID: 80551
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04013AA8 RID: 80552
		internal static byte __PropertyMask_bEnabled;

		// Token: 0x04013AA9 RID: 80553
		internal static int __PropertyOffset_Key;

		// Token: 0x04013AAA RID: 80554
		[Nullable(2)]
		private FKey _Key;

		// Token: 0x04013AAB RID: 80555
		internal static int __PropertyOffset_bInverted;

		// Token: 0x04013AAC RID: 80556
		internal static byte __PropertyMask_bInverted;

		// Token: 0x04013AAD RID: 80557
		internal static int __PropertyOffset_bGamepadStick;

		// Token: 0x04013AAE RID: 80558
		internal static byte __PropertyMask_bGamepadStick;

		// Token: 0x04013AAF RID: 80559
		internal static int __PropertyOffset_Offset;
	}
}
