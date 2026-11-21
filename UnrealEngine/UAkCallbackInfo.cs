using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000BD RID: 189
	[UnrealObjectPath("/Script/AkAudio.AkCallbackInfo")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UAkCallbackInfo : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000E0F RID: 3599 RVA: 0x00016065 File Offset: 0x00014265
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkCallbackInfo._ClassPtr;
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00016074 File Offset: 0x00014274
		public UAkCallbackInfo() : this(BuiltinUtils.AllocNativeUObject(UAkCallbackInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x0001609C File Offset: 0x0001429C
		[NullableContext(1)]
		public UAkCallbackInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkCallbackInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000E12 RID: 3602 RVA: 0x000160CF File Offset: 0x000142CF
		// (set) Token: 0x06000E13 RID: 3603 RVA: 0x000160E3 File Offset: 0x000142E3
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

		// Token: 0x06000E14 RID: 3604 RVA: 0x000160F8 File Offset: 0x000142F8
		static UAkCallbackInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkCallbackInfo");
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00016106 File Offset: 0x00014306
		protected UAkCallbackInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040002B3 RID: 691
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkCallbackInfo";

		// Token: 0x040002B4 RID: 692
		private static IntPtr _ClassPtr;

		// Token: 0x040002B5 RID: 693
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040002B6 RID: 694
		internal static int __PropertyOffset_AkComponent;
	}
}
