using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009B8 RID: 2488
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DeviceProfile")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class UDeviceProfile : UTextureLODSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008C93 RID: 35987 RVA: 0x000C92C0 File Offset: 0x000C74C0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDeviceProfile._ClassPtr;
		}

		// Token: 0x06008C94 RID: 35988 RVA: 0x000C92CC File Offset: 0x000C74CC
		public UDeviceProfile() : this(BuiltinUtils.AllocNativeUObject(UDeviceProfile.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008C95 RID: 35989 RVA: 0x000C92F4 File Offset: 0x000C74F4
		public UDeviceProfile(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDeviceProfile.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002110 RID: 8464
		// (get) Token: 0x06008C96 RID: 35990 RVA: 0x000C9327 File Offset: 0x000C7527
		// (set) Token: 0x06008C97 RID: 35991 RVA: 0x000C933B File Offset: 0x000C753B
		public unsafe string DeviceType
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UDeviceProfile.__PropertyOffset_DeviceType)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UDeviceProfile.__PropertyOffset_DeviceType)), value);
			}
		}

		// Token: 0x17002111 RID: 8465
		// (get) Token: 0x06008C98 RID: 35992 RVA: 0x000C9350 File Offset: 0x000C7550
		// (set) Token: 0x06008C99 RID: 35993 RVA: 0x000C9364 File Offset: 0x000C7564
		public unsafe string BaseProfileName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UDeviceProfile.__PropertyOffset_BaseProfileName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UDeviceProfile.__PropertyOffset_BaseProfileName)), value);
			}
		}

		// Token: 0x17002112 RID: 8466
		// (get) Token: 0x06008C9A RID: 35994 RVA: 0x000C9379 File Offset: 0x000C7579
		// (set) Token: 0x06008C9B RID: 35995 RVA: 0x000C9389 File Offset: 0x000C7589
		public unsafe int DeviceScore
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDeviceProfile.__PropertyOffset_DeviceScore);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDeviceProfile.__PropertyOffset_DeviceScore) = value;
			}
		}

		// Token: 0x17002113 RID: 8467
		// (get) Token: 0x06008C9C RID: 35996 RVA: 0x000C939A File Offset: 0x000C759A
		// (set) Token: 0x06008C9D RID: 35997 RVA: 0x000C93AE File Offset: 0x000C75AE
		[Nullable(2)]
		public unsafe UObject Parent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + UDeviceProfile.__PropertyOffset_Parent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UDeviceProfile.__PropertyOffset_Parent, value);
			}
		}

		// Token: 0x17002114 RID: 8468
		// (get) Token: 0x06008C9E RID: 35998 RVA: 0x000C93C4 File Offset: 0x000C75C4
		// (set) Token: 0x06008C9F RID: 35999 RVA: 0x000C93FD File Offset: 0x000C75FD
		public TArray<string> CVars
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._CVars) == null)
				{
					result = (this._CVars = new TArray<string>(base.NativePtr + (IntPtr)UDeviceProfile.__PropertyOffset_CVars, this));
				}
				return result;
			}
			set
			{
				this.CVars.CopyAssign(value);
			}
		}

		// Token: 0x06008CA0 RID: 36000 RVA: 0x000C940B File Offset: 0x000C760B
		static UDeviceProfile()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DeviceProfile");
		}

		// Token: 0x06008CA1 RID: 36001 RVA: 0x000C9419 File Offset: 0x000C7619
		protected UDeviceProfile(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040042BC RID: 17084
		public new const string __ObjectPath = "/Script/Engine.DeviceProfile";

		// Token: 0x040042BD RID: 17085
		private static IntPtr _ClassPtr;

		// Token: 0x040042BE RID: 17086
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040042BF RID: 17087
		internal static int __PropertyOffset_DeviceType;

		// Token: 0x040042C0 RID: 17088
		internal static int __PropertyOffset_BaseProfileName;

		// Token: 0x040042C1 RID: 17089
		internal static int __PropertyOffset_DeviceScore;

		// Token: 0x040042C2 RID: 17090
		internal static int __PropertyOffset_Parent;

		// Token: 0x040042C3 RID: 17091
		internal static int __PropertyOffset_CVars;

		// Token: 0x040042C4 RID: 17092
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _CVars;
	}
}
