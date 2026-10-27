using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200025A RID: 602
	[UnrealObjectPath("/Script/AkAudio.AkWinAnvilInitializationSettings")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UAkWinAnvilInitializationSettings : UAkWinGDKInitializationSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002363 RID: 9059 RVA: 0x0003456E File Offset: 0x0003276E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkWinAnvilInitializationSettings._ClassPtr;
		}

		// Token: 0x06002364 RID: 9060 RVA: 0x0003457C File Offset: 0x0003277C
		public UAkWinAnvilInitializationSettings() : this(BuiltinUtils.AllocNativeUObject(UAkWinAnvilInitializationSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002365 RID: 9061 RVA: 0x000345A4 File Offset: 0x000327A4
		[NullableContext(1)]
		public UAkWinAnvilInitializationSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkWinAnvilInitializationSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06002366 RID: 9062 RVA: 0x000345D7 File Offset: 0x000327D7
		static UAkWinAnvilInitializationSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkWinAnvilInitializationSettings");
		}

		// Token: 0x06002367 RID: 9063 RVA: 0x000345E5 File Offset: 0x000327E5
		protected UAkWinAnvilInitializationSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000C36 RID: 3126
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkWinAnvilInitializationSettings";

		// Token: 0x04000C37 RID: 3127
		private static IntPtr _ClassPtr;

		// Token: 0x04000C38 RID: 3128
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
