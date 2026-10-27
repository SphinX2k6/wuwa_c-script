using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017FF RID: 6143
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroDevice.DeviceHandle")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UDeviceHandle : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016BDF RID: 93151 RVA: 0x00212FB3 File Offset: 0x002111B3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDeviceHandle._ClassPtr;
		}

		// Token: 0x06016BE0 RID: 93152 RVA: 0x00212FC0 File Offset: 0x002111C0
		public UDeviceHandle() : this(BuiltinUtils.AllocNativeUObject(UDeviceHandle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016BE1 RID: 93153 RVA: 0x00212FE8 File Offset: 0x002111E8
		public UDeviceHandle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDeviceHandle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005BF2 RID: 23538
		// (get) Token: 0x06016BE2 RID: 93154 RVA: 0x0021301C File Offset: 0x0021121C
		// (set) Token: 0x06016BE3 RID: 93155 RVA: 0x00213055 File Offset: 0x00211255
		public FOnControllerConnectionChanged OnConnectionChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnControllerConnectionChanged result;
				if ((result = this._OnConnectionChanged) == null)
				{
					result = (this._OnConnectionChanged = new FOnControllerConnectionChanged(base.NativePtr + (IntPtr)UDeviceHandle.__PropertyOffset_OnConnectionChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UDeviceHandle.__PropertyOffset_OnConnectionChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17005BF3 RID: 23539
		// (get) Token: 0x06016BE4 RID: 93156 RVA: 0x00213078 File Offset: 0x00211278
		// (set) Token: 0x06016BE5 RID: 93157 RVA: 0x002130B1 File Offset: 0x002112B1
		public TArray<string> PidAndVidArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._PidAndVidArray) == null)
				{
					result = (this._PidAndVidArray = new TArray<string>(base.NativePtr + (IntPtr)UDeviceHandle.__PropertyOffset_PidAndVidArray, this));
				}
				return result;
			}
			set
			{
				this.PidAndVidArray.CopyAssign(value);
			}
		}

		// Token: 0x17005BF4 RID: 23540
		// (get) Token: 0x06016BE6 RID: 93158 RVA: 0x002130C0 File Offset: 0x002112C0
		// (set) Token: 0x06016BE7 RID: 93159 RVA: 0x002130F9 File Offset: 0x002112F9
		public TArray<string> DevicePathArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._DevicePathArray) == null)
				{
					result = (this._DevicePathArray = new TArray<string>(base.NativePtr + (IntPtr)UDeviceHandle.__PropertyOffset_DevicePathArray, this));
				}
				return result;
			}
			set
			{
				this.DevicePathArray.CopyAssign(value);
			}
		}

		// Token: 0x06016BE8 RID: 93160 RVA: 0x00213107 File Offset: 0x00211307
		public void Initialize()
		{
			UDeviceHandle.__Initialize_Internal(base.NativePtr);
		}

		// Token: 0x06016BE9 RID: 93161 RVA: 0x00213114 File Offset: 0x00211314
		public TArray<string> GetPidAndVidArray()
		{
			return new TArray<string>(UDeviceHandle.__GetPidAndVidArray_Internal(base.NativePtr), null);
		}

		// Token: 0x06016BEA RID: 93162 RVA: 0x00213127 File Offset: 0x00211327
		public void Clear()
		{
			UDeviceHandle.__Clear_Internal(base.NativePtr);
		}

		// Token: 0x06016BEB RID: 93163
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Initialize_Internal(IntPtr @this);

		// Token: 0x06016BEC RID: 93164
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPidAndVidArray_Internal(IntPtr @this);

		// Token: 0x06016BED RID: 93165
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Clear_Internal(IntPtr @this);

		// Token: 0x06016BEE RID: 93166 RVA: 0x00213134 File Offset: 0x00211334
		static UDeviceHandle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroDevice.DeviceHandle");
		}

		// Token: 0x06016BEF RID: 93167 RVA: 0x00213142 File Offset: 0x00211342
		protected UDeviceHandle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C580 RID: 50560
		public new const string __ObjectPath = "/Script/KuroDevice.DeviceHandle";

		// Token: 0x0400C581 RID: 50561
		private static IntPtr _ClassPtr;

		// Token: 0x0400C582 RID: 50562
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C583 RID: 50563
		internal static int __PropertyOffset_OnConnectionChanged;

		// Token: 0x0400C584 RID: 50564
		[Nullable(2)]
		private FOnControllerConnectionChanged _OnConnectionChanged;

		// Token: 0x0400C585 RID: 50565
		internal static int __PropertyOffset_PidAndVidArray;

		// Token: 0x0400C586 RID: 50566
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _PidAndVidArray;

		// Token: 0x0400C587 RID: 50567
		internal static int __PropertyOffset_DevicePathArray;

		// Token: 0x0400C588 RID: 50568
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _DevicePathArray;
	}
}
