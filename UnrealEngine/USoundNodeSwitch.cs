using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200114F RID: 4431
	[UnrealObjectPath("/Script/Engine.SoundNodeSwitch")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class USoundNodeSwitch : USoundNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060102FA RID: 66298 RVA: 0x0017DA4B File Offset: 0x0017BC4B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundNodeSwitch._ClassPtr;
		}

		// Token: 0x060102FB RID: 66299 RVA: 0x0017DA58 File Offset: 0x0017BC58
		public USoundNodeSwitch() : this(BuiltinUtils.AllocNativeUObject(USoundNodeSwitch.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060102FC RID: 66300 RVA: 0x0017DA80 File Offset: 0x0017BC80
		[NullableContext(1)]
		public USoundNodeSwitch(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundNodeSwitch.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F63 RID: 16227
		// (get) Token: 0x060102FD RID: 66301 RVA: 0x0017DAB3 File Offset: 0x0017BCB3
		// (set) Token: 0x060102FE RID: 66302 RVA: 0x0017DAC7 File Offset: 0x0017BCC7
		public unsafe FName IntParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeSwitch.__PropertyOffset_IntParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeSwitch.__PropertyOffset_IntParameterName) = value;
			}
		}

		// Token: 0x060102FF RID: 66303 RVA: 0x0017DADC File Offset: 0x0017BCDC
		static USoundNodeSwitch()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundNodeSwitch");
		}

		// Token: 0x06010300 RID: 66304 RVA: 0x0017DAEA File Offset: 0x0017BCEA
		protected USoundNodeSwitch(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008B5E RID: 35678
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SoundNodeSwitch";

		// Token: 0x04008B5F RID: 35679
		private static IntPtr _ClassPtr;

		// Token: 0x04008B60 RID: 35680
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008B61 RID: 35681
		internal static int __PropertyOffset_IntParameterName;
	}
}
