using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200267E RID: 9854
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/RawInput.RawInputDeviceConfiguration")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FRawInputDeviceConfiguration : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602498D RID: 149901 RVA: 0x00362CB2 File Offset: 0x00360EB2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRawInputDeviceConfiguration._ScriptStructPtr != 0) ? FRawInputDeviceConfiguration._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RawInput.RawInputDeviceConfiguration", ref FRawInputDeviceConfiguration._ScriptStructPtr);
		}

		// Token: 0x17008D1E RID: 36126
		// (get) Token: 0x0602498E RID: 149902 RVA: 0x00362CD6 File Offset: 0x00360ED6
		// (set) Token: 0x0602498F RID: 149903 RVA: 0x00362CEA File Offset: 0x00360EEA
		public unsafe string VendorID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FRawInputDeviceConfiguration.__PropertyOffset_VendorID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FRawInputDeviceConfiguration.__PropertyOffset_VendorID)), value);
			}
		}

		// Token: 0x17008D1F RID: 36127
		// (get) Token: 0x06024990 RID: 149904 RVA: 0x00362CFF File Offset: 0x00360EFF
		// (set) Token: 0x06024991 RID: 149905 RVA: 0x00362D13 File Offset: 0x00360F13
		public unsafe string ProductID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FRawInputDeviceConfiguration.__PropertyOffset_ProductID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FRawInputDeviceConfiguration.__PropertyOffset_ProductID)), value);
			}
		}

		// Token: 0x17008D20 RID: 36128
		// (get) Token: 0x06024992 RID: 149906 RVA: 0x00362D28 File Offset: 0x00360F28
		// (set) Token: 0x06024993 RID: 149907 RVA: 0x00362D6B File Offset: 0x00360F6B
		public TArray<FRawInputDeviceAxisProperties> AxisProperties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRawInputDeviceAxisProperties> result;
				if ((result = this._AxisProperties) == null)
				{
					result = (this._AxisProperties = new TArray<FRawInputDeviceAxisProperties>(base.NativePtr + (IntPtr)FRawInputDeviceConfiguration.__PropertyOffset_AxisProperties, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AxisProperties.CopyAssign(value);
			}
		}

		// Token: 0x17008D21 RID: 36129
		// (get) Token: 0x06024994 RID: 149908 RVA: 0x00362D7C File Offset: 0x00360F7C
		// (set) Token: 0x06024995 RID: 149909 RVA: 0x00362DBF File Offset: 0x00360FBF
		public TArray<FRawInputDeviceButtonProperties> ButtonProperties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRawInputDeviceButtonProperties> result;
				if ((result = this._ButtonProperties) == null)
				{
					result = (this._ButtonProperties = new TArray<FRawInputDeviceButtonProperties>(base.NativePtr + (IntPtr)FRawInputDeviceConfiguration.__PropertyOffset_ButtonProperties, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ButtonProperties.CopyAssign(value);
			}
		}

		// Token: 0x17008D22 RID: 36130
		// (get) Token: 0x06024996 RID: 149910 RVA: 0x00362DD0 File Offset: 0x00360FD0
		// (set) Token: 0x06024997 RID: 149911 RVA: 0x00362E13 File Offset: 0x00361013
		public TArray<FRawInputDeviceAxisButtonProperties> AxisButtonProperties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRawInputDeviceAxisButtonProperties> result;
				if ((result = this._AxisButtonProperties) == null)
				{
					result = (this._AxisButtonProperties = new TArray<FRawInputDeviceAxisButtonProperties>(base.NativePtr + (IntPtr)FRawInputDeviceConfiguration.__PropertyOffset_AxisButtonProperties, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AxisButtonProperties.CopyAssign(value);
			}
		}

		// Token: 0x17008D23 RID: 36131
		// (get) Token: 0x06024998 RID: 149912 RVA: 0x00362E24 File Offset: 0x00361024
		// (set) Token: 0x06024999 RID: 149913 RVA: 0x00362E67 File Offset: 0x00361067
		public TArray<FRawInputDeviceAxisProperties> BluetoothAxisProperties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRawInputDeviceAxisProperties> result;
				if ((result = this._BluetoothAxisProperties) == null)
				{
					result = (this._BluetoothAxisProperties = new TArray<FRawInputDeviceAxisProperties>(base.NativePtr + (IntPtr)FRawInputDeviceConfiguration.__PropertyOffset_BluetoothAxisProperties, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BluetoothAxisProperties.CopyAssign(value);
			}
		}

		// Token: 0x17008D24 RID: 36132
		// (get) Token: 0x0602499A RID: 149914 RVA: 0x00362E78 File Offset: 0x00361078
		// (set) Token: 0x0602499B RID: 149915 RVA: 0x00362EBB File Offset: 0x003610BB
		public TArray<FRawInputDeviceButtonProperties> BluetoothButtonProperties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRawInputDeviceButtonProperties> result;
				if ((result = this._BluetoothButtonProperties) == null)
				{
					result = (this._BluetoothButtonProperties = new TArray<FRawInputDeviceButtonProperties>(base.NativePtr + (IntPtr)FRawInputDeviceConfiguration.__PropertyOffset_BluetoothButtonProperties, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BluetoothButtonProperties.CopyAssign(value);
			}
		}

		// Token: 0x17008D25 RID: 36133
		// (get) Token: 0x0602499C RID: 149916 RVA: 0x00362ECC File Offset: 0x003610CC
		// (set) Token: 0x0602499D RID: 149917 RVA: 0x00362F0F File Offset: 0x0036110F
		public TArray<FRawInputDeviceAxisButtonProperties> BluetoothAxisButtonProperties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRawInputDeviceAxisButtonProperties> result;
				if ((result = this._BluetoothAxisButtonProperties) == null)
				{
					result = (this._BluetoothAxisButtonProperties = new TArray<FRawInputDeviceAxisButtonProperties>(base.NativePtr + (IntPtr)FRawInputDeviceConfiguration.__PropertyOffset_BluetoothAxisButtonProperties, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BluetoothAxisButtonProperties.CopyAssign(value);
			}
		}

		// Token: 0x0602499E RID: 149918 RVA: 0x00362F1D File Offset: 0x0036111D
		public FRawInputDeviceConfiguration()
		{
		}

		// Token: 0x0602499F RID: 149919 RVA: 0x00362F28 File Offset: 0x00361128
		public FRawInputDeviceConfiguration(string VendorID, string ProductID, TArray<FRawInputDeviceAxisProperties> AxisProperties, TArray<FRawInputDeviceButtonProperties> ButtonProperties, TArray<FRawInputDeviceAxisButtonProperties> AxisButtonProperties, TArray<FRawInputDeviceAxisProperties> BluetoothAxisProperties, TArray<FRawInputDeviceButtonProperties> BluetoothButtonProperties, TArray<FRawInputDeviceAxisButtonProperties> BluetoothAxisButtonProperties)
		{
			this.VendorID = VendorID;
			this.ProductID = ProductID;
			this.AxisProperties = AxisProperties;
			this.ButtonProperties = ButtonProperties;
			this.AxisButtonProperties = AxisButtonProperties;
			this.BluetoothAxisProperties = BluetoothAxisProperties;
			this.BluetoothButtonProperties = BluetoothButtonProperties;
			this.BluetoothAxisButtonProperties = BluetoothAxisButtonProperties;
		}

		// Token: 0x060249A0 RID: 149920 RVA: 0x00362F78 File Offset: 0x00361178
		protected override IntPtr GetUStructPtr()
		{
			return FRawInputDeviceConfiguration.StaticStruct();
		}

		// Token: 0x060249A1 RID: 149921 RVA: 0x00362F84 File Offset: 0x00361184
		[NullableContext(2)]
		public FRawInputDeviceConfiguration(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060249A2 RID: 149922 RVA: 0x00362F8E File Offset: 0x0036118E
		public FRawInputDeviceConfiguration(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060249A3 RID: 149923 RVA: 0x00362F99 File Offset: 0x00361199
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRawInputDeviceConfiguration(Pointer, false, true);
		}

		// Token: 0x060249A4 RID: 149924 RVA: 0x00362FA3 File Offset: 0x003611A3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRawInputDeviceConfiguration(Pointer, MemoryOwner);
		}

		// Token: 0x04013AB6 RID: 80566
		public const string __ObjectPath = "/Script/RawInput.RawInputDeviceConfiguration";

		// Token: 0x04013AB7 RID: 80567
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013AB8 RID: 80568
		internal static int __PropertyOffset_VendorID;

		// Token: 0x04013AB9 RID: 80569
		internal static int __PropertyOffset_ProductID;

		// Token: 0x04013ABA RID: 80570
		internal static int __PropertyOffset_AxisProperties;

		// Token: 0x04013ABB RID: 80571
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRawInputDeviceAxisProperties> _AxisProperties;

		// Token: 0x04013ABC RID: 80572
		internal static int __PropertyOffset_ButtonProperties;

		// Token: 0x04013ABD RID: 80573
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRawInputDeviceButtonProperties> _ButtonProperties;

		// Token: 0x04013ABE RID: 80574
		internal static int __PropertyOffset_AxisButtonProperties;

		// Token: 0x04013ABF RID: 80575
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRawInputDeviceAxisButtonProperties> _AxisButtonProperties;

		// Token: 0x04013AC0 RID: 80576
		internal static int __PropertyOffset_BluetoothAxisProperties;

		// Token: 0x04013AC1 RID: 80577
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRawInputDeviceAxisProperties> _BluetoothAxisProperties;

		// Token: 0x04013AC2 RID: 80578
		internal static int __PropertyOffset_BluetoothButtonProperties;

		// Token: 0x04013AC3 RID: 80579
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRawInputDeviceButtonProperties> _BluetoothButtonProperties;

		// Token: 0x04013AC4 RID: 80580
		internal static int __PropertyOffset_BluetoothAxisButtonProperties;

		// Token: 0x04013AC5 RID: 80581
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRawInputDeviceAxisButtonProperties> _BluetoothAxisButtonProperties;
	}
}
