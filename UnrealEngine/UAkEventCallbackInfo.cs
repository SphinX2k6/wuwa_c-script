using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000202 RID: 514
	[UnrealObjectPath("/Script/AkAudio.AkEventCallbackInfo")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UAkEventCallbackInfo : UAkCallbackInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001E3E RID: 7742 RVA: 0x0002CD8D File Offset: 0x0002AF8D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkEventCallbackInfo._ClassPtr;
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x0002CD9C File Offset: 0x0002AF9C
		public UAkEventCallbackInfo() : this(BuiltinUtils.AllocNativeUObject(UAkEventCallbackInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x0002CDC4 File Offset: 0x0002AFC4
		[NullableContext(1)]
		public UAkEventCallbackInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkEventCallbackInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06001E41 RID: 7745 RVA: 0x0002CDF7 File Offset: 0x0002AFF7
		// (set) Token: 0x06001E42 RID: 7746 RVA: 0x0002CE07 File Offset: 0x0002B007
		public unsafe int PlayingID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkEventCallbackInfo.__PropertyOffset_PlayingID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkEventCallbackInfo.__PropertyOffset_PlayingID) = value;
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06001E43 RID: 7747 RVA: 0x0002CE18 File Offset: 0x0002B018
		// (set) Token: 0x06001E44 RID: 7748 RVA: 0x0002CE28 File Offset: 0x0002B028
		public unsafe int EventID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkEventCallbackInfo.__PropertyOffset_EventID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkEventCallbackInfo.__PropertyOffset_EventID) = value;
			}
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x0002CE39 File Offset: 0x0002B039
		static UAkEventCallbackInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkEventCallbackInfo");
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x0002CE47 File Offset: 0x0002B047
		protected UAkEventCallbackInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000A09 RID: 2569
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkEventCallbackInfo";

		// Token: 0x04000A0A RID: 2570
		private static IntPtr _ClassPtr;

		// Token: 0x04000A0B RID: 2571
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000A0C RID: 2572
		internal static int __PropertyOffset_PlayingID;

		// Token: 0x04000A0D RID: 2573
		internal static int __PropertyOffset_EventID;
	}
}
