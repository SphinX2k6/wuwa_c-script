using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200267D RID: 9853
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/RawInput.RawInputDeviceButtonProperties")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRawInputDeviceButtonProperties : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024981 RID: 149889 RVA: 0x00362B8C File Offset: 0x00360D8C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRawInputDeviceButtonProperties._ScriptStructPtr != 0) ? FRawInputDeviceButtonProperties._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RawInput.RawInputDeviceButtonProperties", ref FRawInputDeviceButtonProperties._ScriptStructPtr);
		}

		// Token: 0x17008D1C RID: 36124
		// (get) Token: 0x06024982 RID: 149890 RVA: 0x00362BB0 File Offset: 0x00360DB0
		// (set) Token: 0x06024983 RID: 149891 RVA: 0x00362BC9 File Offset: 0x00360DC9
		public unsafe bool bEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRawInputDeviceButtonProperties.__PropertyOffset_bEnabled) & FRawInputDeviceButtonProperties.__PropertyMask_bEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRawInputDeviceButtonProperties.__PropertyOffset_bEnabled) = ((*(base.NativePtr + (IntPtr)FRawInputDeviceButtonProperties.__PropertyOffset_bEnabled) & ~FRawInputDeviceButtonProperties.__PropertyMask_bEnabled) | (value ? FRawInputDeviceButtonProperties.__PropertyMask_bEnabled : 0));
			}
		}

		// Token: 0x17008D1D RID: 36125
		// (get) Token: 0x06024984 RID: 149892 RVA: 0x00362BFC File Offset: 0x00360DFC
		// (set) Token: 0x06024985 RID: 149893 RVA: 0x00362C3F File Offset: 0x00360E3F
		public FKey Key
		{
			get
			{
				base.FastCheckIsValid();
				FKey result;
				if ((result = this._Key) == null)
				{
					result = (this._Key = new FKey(base.NativePtr + (IntPtr)FRawInputDeviceButtonProperties.__PropertyOffset_Key, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), base.NativePtr + (IntPtr)FRawInputDeviceButtonProperties.__PropertyOffset_Key, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06024986 RID: 149894 RVA: 0x00362C60 File Offset: 0x00360E60
		public FRawInputDeviceButtonProperties()
		{
		}

		// Token: 0x06024987 RID: 149895 RVA: 0x00362C68 File Offset: 0x00360E68
		public FRawInputDeviceButtonProperties(bool bEnabled, FKey Key)
		{
			this.bEnabled = bEnabled;
			this.Key = Key;
		}

		// Token: 0x06024988 RID: 149896 RVA: 0x00362C7E File Offset: 0x00360E7E
		protected override IntPtr GetUStructPtr()
		{
			return FRawInputDeviceButtonProperties.StaticStruct();
		}

		// Token: 0x06024989 RID: 149897 RVA: 0x00362C8A File Offset: 0x00360E8A
		[NullableContext(2)]
		public FRawInputDeviceButtonProperties(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602498A RID: 149898 RVA: 0x00362C94 File Offset: 0x00360E94
		public FRawInputDeviceButtonProperties(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602498B RID: 149899 RVA: 0x00362C9F File Offset: 0x00360E9F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRawInputDeviceButtonProperties(Pointer, false, true);
		}

		// Token: 0x0602498C RID: 149900 RVA: 0x00362CA9 File Offset: 0x00360EA9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRawInputDeviceButtonProperties(Pointer, MemoryOwner);
		}

		// Token: 0x04013AB0 RID: 80560
		public const string __ObjectPath = "/Script/RawInput.RawInputDeviceButtonProperties";

		// Token: 0x04013AB1 RID: 80561
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013AB2 RID: 80562
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04013AB3 RID: 80563
		internal static byte __PropertyMask_bEnabled;

		// Token: 0x04013AB4 RID: 80564
		internal static int __PropertyOffset_Key;

		// Token: 0x04013AB5 RID: 80565
		[Nullable(2)]
		private FKey _Key;
	}
}
