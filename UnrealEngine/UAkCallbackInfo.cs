using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001F6 RID: 502
	[UnrealObjectPath("/Script/AkAudio.AkCallbackInfo")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UAkCallbackInfo : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001D80 RID: 7552 RVA: 0x0002BE06 File Offset: 0x0002A006
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkCallbackInfo._ClassPtr;
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x0002BE14 File Offset: 0x0002A014
		public UAkCallbackInfo() : this(BuiltinUtils.AllocNativeUObject(UAkCallbackInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x0002BE3C File Offset: 0x0002A03C
		[NullableContext(1)]
		public UAkCallbackInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkCallbackInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001D83 RID: 7555 RVA: 0x0002BE6F File Offset: 0x0002A06F
		// (set) Token: 0x06001D84 RID: 7556 RVA: 0x0002BE83 File Offset: 0x0002A083
		[Nullable(2)]
		public unsafe UAkComponent AkComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UAkCallbackInfo.__PropertyOffset_AkComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAkCallbackInfo.__PropertyOffset_AkComponent, value);
			}
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x0002BE98 File Offset: 0x0002A098
		static UAkCallbackInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkCallbackInfo");
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x0002BEA6 File Offset: 0x0002A0A6
		protected UAkCallbackInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040009BB RID: 2491
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkCallbackInfo";

		// Token: 0x040009BC RID: 2492
		private static IntPtr _ClassPtr;

		// Token: 0x040009BD RID: 2493
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040009BE RID: 2494
		internal static int __PropertyOffset_AkComponent;
	}
}
