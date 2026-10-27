using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000233 RID: 563
	[UnrealObjectPath("/Script/AkAudio.AkPlatformInfo")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UAkPlatformInfo : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060020EF RID: 8431 RVA: 0x00030FBF File Offset: 0x0002F1BF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkPlatformInfo._ClassPtr;
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x00030FCC File Offset: 0x0002F1CC
		public UAkPlatformInfo() : this(BuiltinUtils.AllocNativeUObject(UAkPlatformInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x00030FF4 File Offset: 0x0002F1F4
		[NullableContext(1)]
		public UAkPlatformInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkPlatformInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x00031027 File Offset: 0x0002F227
		static UAkPlatformInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkPlatformInfo");
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x00031035 File Offset: 0x0002F235
		protected UAkPlatformInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000B1A RID: 2842
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkPlatformInfo";

		// Token: 0x04000B1B RID: 2843
		private static IntPtr _ClassPtr;

		// Token: 0x04000B1C RID: 2844
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
