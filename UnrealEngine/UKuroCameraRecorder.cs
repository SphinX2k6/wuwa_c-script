using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200165F RID: 5727
	[UnrealObjectPath("/Script/KuroAnim.KuroCameraRecorder")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UKuroCameraRecorder : UKuroTrackRecorder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014BF1 RID: 84977 RVA: 0x001E8240 File Offset: 0x001E6440
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCameraRecorder._ClassPtr;
		}

		// Token: 0x06014BF2 RID: 84978 RVA: 0x001E824C File Offset: 0x001E644C
		public UKuroCameraRecorder() : this(BuiltinUtils.AllocNativeUObject(UKuroCameraRecorder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014BF3 RID: 84979 RVA: 0x001E8274 File Offset: 0x001E6474
		[NullableContext(1)]
		public UKuroCameraRecorder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCameraRecorder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06014BF4 RID: 84980 RVA: 0x001E82A7 File Offset: 0x001E64A7
		static UKuroCameraRecorder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroCameraRecorder");
		}

		// Token: 0x06014BF5 RID: 84981 RVA: 0x001E82B5 File Offset: 0x001E64B5
		protected UKuroCameraRecorder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B4F3 RID: 46323
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroCameraRecorder";

		// Token: 0x0400B4F4 RID: 46324
		private static IntPtr _ClassPtr;

		// Token: 0x0400B4F5 RID: 46325
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
