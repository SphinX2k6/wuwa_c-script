using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000CE RID: 206
	[UnrealObjectPath("/Script/AkAudio.AkSwitchValue")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UAkSwitchValue : UAkGroupValue, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000F2C RID: 3884 RVA: 0x0001772F File Offset: 0x0001592F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkSwitchValue._ClassPtr;
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x0001773C File Offset: 0x0001593C
		public UAkSwitchValue() : this(BuiltinUtils.AllocNativeUObject(UAkSwitchValue.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x00017764 File Offset: 0x00015964
		[NullableContext(1)]
		public UAkSwitchValue(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkSwitchValue.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x00017797 File Offset: 0x00015997
		static UAkSwitchValue()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkSwitchValue");
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x000177A5 File Offset: 0x000159A5
		protected UAkSwitchValue(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000310 RID: 784
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkSwitchValue";

		// Token: 0x04000311 RID: 785
		private static IntPtr _ClassPtr;

		// Token: 0x04000312 RID: 786
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
