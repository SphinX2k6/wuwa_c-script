using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000261 RID: 609
	[UnrealObjectPath("/Script/AkAudio.AkWinGDKPlatformInfo")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UAkWinGDKPlatformInfo : UAkPlatformInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060023A4 RID: 9124 RVA: 0x00034D1F File Offset: 0x00032F1F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkWinGDKPlatformInfo._ClassPtr;
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x00034D2C File Offset: 0x00032F2C
		public UAkWinGDKPlatformInfo() : this(BuiltinUtils.AllocNativeUObject(UAkWinGDKPlatformInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x00034D54 File Offset: 0x00032F54
		[NullableContext(1)]
		public UAkWinGDKPlatformInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkWinGDKPlatformInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x00034D87 File Offset: 0x00032F87
		static UAkWinGDKPlatformInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkWinGDKPlatformInfo");
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x00034D95 File Offset: 0x00032F95
		protected UAkWinGDKPlatformInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000C59 RID: 3161
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkWinGDKPlatformInfo";

		// Token: 0x04000C5A RID: 3162
		private static IntPtr _ClassPtr;

		// Token: 0x04000C5B RID: 3163
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
