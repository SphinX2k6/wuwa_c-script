using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000239 RID: 569
	[UnrealObjectPath("/Script/AkAudio.AkPS5PlatformInfo")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UAkPS5PlatformInfo : UAkPlatformInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600213A RID: 8506 RVA: 0x0003164D File Offset: 0x0002F84D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkPS5PlatformInfo._ClassPtr;
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x0003165C File Offset: 0x0002F85C
		public UAkPS5PlatformInfo() : this(BuiltinUtils.AllocNativeUObject(UAkPS5PlatformInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600213C RID: 8508 RVA: 0x00031684 File Offset: 0x0002F884
		[NullableContext(1)]
		public UAkPS5PlatformInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkPS5PlatformInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x000316B7 File Offset: 0x0002F8B7
		static UAkPS5PlatformInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkPS5PlatformInfo");
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x000316C5 File Offset: 0x0002F8C5
		protected UAkPS5PlatformInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000B3C RID: 2876
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkPS5PlatformInfo";

		// Token: 0x04000B3D RID: 2877
		private static IntPtr _ClassPtr;

		// Token: 0x04000B3E RID: 2878
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
