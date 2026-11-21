using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000CC RID: 204
	[UnrealObjectPath("/Script/AkAudio.AkRtpc")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UAkRtpc : UAkAudioType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000F0E RID: 3854 RVA: 0x00017527 File Offset: 0x00015727
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkRtpc._ClassPtr;
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x00017534 File Offset: 0x00015734
		public UAkRtpc() : this(BuiltinUtils.AllocNativeUObject(UAkRtpc.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x0001755C File Offset: 0x0001575C
		[NullableContext(1)]
		public UAkRtpc(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkRtpc.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x0001758F File Offset: 0x0001578F
		static UAkRtpc()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkRtpc");
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x0001759D File Offset: 0x0001579D
		protected UAkRtpc(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000302 RID: 770
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkRtpc";

		// Token: 0x04000303 RID: 771
		private static IntPtr _ClassPtr;

		// Token: 0x04000304 RID: 772
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
