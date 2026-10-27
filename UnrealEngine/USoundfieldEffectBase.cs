using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000369 RID: 873
	[UnrealObjectPath("/Script/AudioExtensions.SoundfieldEffectBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class USoundfieldEffectBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003031 RID: 12337 RVA: 0x0004AA99 File Offset: 0x00048C99
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundfieldEffectBase._ClassPtr;
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x06003032 RID: 12338 RVA: 0x0004AAA5 File Offset: 0x00048CA5
		// (set) Token: 0x06003033 RID: 12339 RVA: 0x0004AAB9 File Offset: 0x00048CB9
		[Nullable(2)]
		public unsafe USoundfieldEffectSettingsBase Settings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundfieldEffectSettingsBase>(base.NativePtr / (IntPtr)sizeof(void*) + USoundfieldEffectBase.__PropertyOffset_Settings);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USoundfieldEffectBase.__PropertyOffset_Settings, value);
			}
		}

		// Token: 0x06003034 RID: 12340 RVA: 0x0004AACE File Offset: 0x00048CCE
		static USoundfieldEffectBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioExtensions.SoundfieldEffectBase");
		}

		// Token: 0x06003035 RID: 12341 RVA: 0x0004AADC File Offset: 0x00048CDC
		protected USoundfieldEffectBase() : this(BuiltinUtils.AllocNativeUObject(USoundfieldEffectBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003036 RID: 12342 RVA: 0x0004AB04 File Offset: 0x00048D04
		protected USoundfieldEffectBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040014F7 RID: 5367
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioExtensions.SoundfieldEffectBase";

		// Token: 0x040014F8 RID: 5368
		private static IntPtr _ClassPtr;

		// Token: 0x040014F9 RID: 5369
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040014FA RID: 5370
		internal static int __PropertyOffset_Settings;
	}
}
