using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200021D RID: 541
	[UnrealObjectPath("/Script/AkAudio.AkMacPlatformInfo")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UAkMacPlatformInfo : UAkPlatformInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001FFE RID: 8190 RVA: 0x0002F71F File Offset: 0x0002D91F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkMacPlatformInfo._ClassPtr;
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x0002F72C File Offset: 0x0002D92C
		public UAkMacPlatformInfo() : this(BuiltinUtils.AllocNativeUObject(UAkMacPlatformInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x0002F754 File Offset: 0x0002D954
		[NullableContext(1)]
		public UAkMacPlatformInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkMacPlatformInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x0002F787 File Offset: 0x0002D987
		static UAkMacPlatformInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkMacPlatformInfo");
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x0002F795 File Offset: 0x0002D995
		protected UAkMacPlatformInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000AAE RID: 2734
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkMacPlatformInfo";

		// Token: 0x04000AAF RID: 2735
		private static IntPtr _ClassPtr;

		// Token: 0x04000AB0 RID: 2736
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
