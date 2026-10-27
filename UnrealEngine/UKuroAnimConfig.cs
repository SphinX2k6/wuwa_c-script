using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001653 RID: 5715
	[UnrealObjectPath("/Script/KuroAnim.KuroAnimConfig")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UKuroAnimConfig : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014922 RID: 84258 RVA: 0x001E415A File Offset: 0x001E235A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnimConfig._ClassPtr;
		}

		// Token: 0x06014923 RID: 84259 RVA: 0x001E4168 File Offset: 0x001E2368
		public UKuroAnimConfig() : this(BuiltinUtils.AllocNativeUObject(UKuroAnimConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014924 RID: 84260 RVA: 0x001E4190 File Offset: 0x001E2390
		[NullableContext(1)]
		public UKuroAnimConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnimConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170050FE RID: 20734
		// (get) Token: 0x06014925 RID: 84261 RVA: 0x001E41C3 File Offset: 0x001E23C3
		// (set) Token: 0x06014926 RID: 84262 RVA: 0x001E41D3 File Offset: 0x001E23D3
		public unsafe float DefaultFootOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimConfig.__PropertyOffset_DefaultFootOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimConfig.__PropertyOffset_DefaultFootOffset) = value;
			}
		}

		// Token: 0x170050FF RID: 20735
		// (get) Token: 0x06014927 RID: 84263 RVA: 0x001E41E4 File Offset: 0x001E23E4
		// (set) Token: 0x06014928 RID: 84264 RVA: 0x001E41F4 File Offset: 0x001E23F4
		public unsafe float DefaultHighHeelsOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimConfig.__PropertyOffset_DefaultHighHeelsOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimConfig.__PropertyOffset_DefaultHighHeelsOffset) = value;
			}
		}

		// Token: 0x06014929 RID: 84265 RVA: 0x001E4205 File Offset: 0x001E2405
		static UKuroAnimConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroAnimConfig");
		}

		// Token: 0x0601492A RID: 84266 RVA: 0x001E4213 File Offset: 0x001E2413
		protected UKuroAnimConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B3B4 RID: 46004
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroAnimConfig";

		// Token: 0x0400B3B5 RID: 46005
		private static IntPtr _ClassPtr;

		// Token: 0x0400B3B6 RID: 46006
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B3B7 RID: 46007
		internal static int __PropertyOffset_DefaultFootOffset;

		// Token: 0x0400B3B8 RID: 46008
		internal static int __PropertyOffset_DefaultHighHeelsOffset;
	}
}
