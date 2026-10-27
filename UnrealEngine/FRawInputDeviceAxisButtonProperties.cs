using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200267B RID: 9851
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/RawInput.RawInputDeviceAxisButtonProperties")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRawInputDeviceAxisButtonProperties : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602495F RID: 149855 RVA: 0x00362850 File Offset: 0x00360A50
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRawInputDeviceAxisButtonProperties._ScriptStructPtr != 0) ? FRawInputDeviceAxisButtonProperties._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RawInput.RawInputDeviceAxisButtonProperties", ref FRawInputDeviceAxisButtonProperties._ScriptStructPtr);
		}

		// Token: 0x17008D13 RID: 36115
		// (get) Token: 0x06024960 RID: 149856 RVA: 0x00362874 File Offset: 0x00360A74
		// (set) Token: 0x06024961 RID: 149857 RVA: 0x00362884 File Offset: 0x00360A84
		public unsafe int AnalogIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRawInputDeviceAxisButtonProperties.__PropertyOffset_AnalogIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRawInputDeviceAxisButtonProperties.__PropertyOffset_AnalogIndex) = value;
			}
		}

		// Token: 0x17008D14 RID: 36116
		// (get) Token: 0x06024962 RID: 149858 RVA: 0x00362895 File Offset: 0x00360A95
		// (set) Token: 0x06024963 RID: 149859 RVA: 0x003628A5 File Offset: 0x00360AA5
		public unsafe float AnalogValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRawInputDeviceAxisButtonProperties.__PropertyOffset_AnalogValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRawInputDeviceAxisButtonProperties.__PropertyOffset_AnalogValue) = value;
			}
		}

		// Token: 0x17008D15 RID: 36117
		// (get) Token: 0x06024964 RID: 149860 RVA: 0x003628B6 File Offset: 0x00360AB6
		// (set) Token: 0x06024965 RID: 149861 RVA: 0x003628C6 File Offset: 0x00360AC6
		public unsafe float MaxAnalogValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRawInputDeviceAxisButtonProperties.__PropertyOffset_MaxAnalogValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRawInputDeviceAxisButtonProperties.__PropertyOffset_MaxAnalogValue) = value;
			}
		}

		// Token: 0x17008D16 RID: 36118
		// (get) Token: 0x06024966 RID: 149862 RVA: 0x003628D8 File Offset: 0x00360AD8
		// (set) Token: 0x06024967 RID: 149863 RVA: 0x0036291B File Offset: 0x00360B1B
		public FKey Key
		{
			get
			{
				base.FastCheckIsValid();
				FKey result;
				if ((result = this._Key) == null)
				{
					result = (this._Key = new FKey(base.NativePtr + (IntPtr)FRawInputDeviceAxisButtonProperties.__PropertyOffset_Key, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), base.NativePtr + (IntPtr)FRawInputDeviceAxisButtonProperties.__PropertyOffset_Key, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06024968 RID: 149864 RVA: 0x0036293C File Offset: 0x00360B3C
		public FRawInputDeviceAxisButtonProperties()
		{
		}

		// Token: 0x06024969 RID: 149865 RVA: 0x00362944 File Offset: 0x00360B44
		public FRawInputDeviceAxisButtonProperties(int AnalogIndex, float AnalogValue, float MaxAnalogValue, FKey Key)
		{
			this.AnalogIndex = AnalogIndex;
			this.AnalogValue = AnalogValue;
			this.MaxAnalogValue = MaxAnalogValue;
			this.Key = Key;
		}

		// Token: 0x0602496A RID: 149866 RVA: 0x00362969 File Offset: 0x00360B69
		protected override IntPtr GetUStructPtr()
		{
			return FRawInputDeviceAxisButtonProperties.StaticStruct();
		}

		// Token: 0x0602496B RID: 149867 RVA: 0x00362975 File Offset: 0x00360B75
		[NullableContext(2)]
		public FRawInputDeviceAxisButtonProperties(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602496C RID: 149868 RVA: 0x0036297F File Offset: 0x00360B7F
		public FRawInputDeviceAxisButtonProperties(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602496D RID: 149869 RVA: 0x0036298A File Offset: 0x00360B8A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRawInputDeviceAxisButtonProperties(Pointer, false, true);
		}

		// Token: 0x0602496E RID: 149870 RVA: 0x00362994 File Offset: 0x00360B94
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRawInputDeviceAxisButtonProperties(Pointer, MemoryOwner);
		}

		// Token: 0x04013A9E RID: 80542
		public const string __ObjectPath = "/Script/RawInput.RawInputDeviceAxisButtonProperties";

		// Token: 0x04013A9F RID: 80543
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013AA0 RID: 80544
		internal static int __PropertyOffset_AnalogIndex;

		// Token: 0x04013AA1 RID: 80545
		internal static int __PropertyOffset_AnalogValue;

		// Token: 0x04013AA2 RID: 80546
		internal static int __PropertyOffset_MaxAnalogValue;

		// Token: 0x04013AA3 RID: 80547
		internal static int __PropertyOffset_Key;

		// Token: 0x04013AA4 RID: 80548
		[Nullable(2)]
		private FKey _Key;
	}
}
