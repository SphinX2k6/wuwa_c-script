using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024A7 RID: 9383
	[UnrealObjectPath("/Script/NavigationSystem.NavSystemConfigOverride")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class ANavSystemConfigOverride : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060231CA RID: 143818 RVA: 0x0033EC62 File Offset: 0x0033CE62
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANavSystemConfigOverride._ClassPtr;
		}

		// Token: 0x060231CB RID: 143819 RVA: 0x0033EC70 File Offset: 0x0033CE70
		public ANavSystemConfigOverride() : this(BuiltinUtils.AllocNativeUObject(ANavSystemConfigOverride.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060231CC RID: 143820 RVA: 0x0033EC98 File Offset: 0x0033CE98
		[NullableContext(1)]
		public ANavSystemConfigOverride(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ANavSystemConfigOverride.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170086E7 RID: 34535
		// (get) Token: 0x060231CD RID: 143821 RVA: 0x0033ECCB File Offset: 0x0033CECB
		// (set) Token: 0x060231CE RID: 143822 RVA: 0x0033ECDF File Offset: 0x0033CEDF
		[Nullable(2)]
		public unsafe UNavigationSystemConfig NavigationSystemConfig
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNavigationSystemConfig>(base.NativePtr / (IntPtr)sizeof(void*) + ANavSystemConfigOverride.__PropertyOffset_NavigationSystemConfig);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ANavSystemConfigOverride.__PropertyOffset_NavigationSystemConfig, value);
			}
		}

		// Token: 0x170086E8 RID: 34536
		// (get) Token: 0x060231CF RID: 143823 RVA: 0x0033ECF4 File Offset: 0x0033CEF4
		// (set) Token: 0x060231D0 RID: 143824 RVA: 0x0033ED04 File Offset: 0x0033CF04
		public unsafe ENavSystemOverridePolicy OverridePolicy
		{
			get
			{
				return (ENavSystemOverridePolicy)(*(base.NativePtr + (IntPtr)ANavSystemConfigOverride.__PropertyOffset_OverridePolicy));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANavSystemConfigOverride.__PropertyOffset_OverridePolicy) = (byte)value;
			}
		}

		// Token: 0x170086E9 RID: 34537
		// (get) Token: 0x060231D1 RID: 143825 RVA: 0x0033ED15 File Offset: 0x0033CF15
		// (set) Token: 0x060231D2 RID: 143826 RVA: 0x0033ED2E File Offset: 0x0033CF2E
		public unsafe bool bLoadOnClient
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavSystemConfigOverride.__PropertyOffset_bLoadOnClient) & ANavSystemConfigOverride.__PropertyMask_bLoadOnClient) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavSystemConfigOverride.__PropertyOffset_bLoadOnClient) = ((*(base.NativePtr + (IntPtr)ANavSystemConfigOverride.__PropertyOffset_bLoadOnClient) & ~ANavSystemConfigOverride.__PropertyMask_bLoadOnClient) | (value ? ANavSystemConfigOverride.__PropertyMask_bLoadOnClient : 0));
			}
		}

		// Token: 0x060231D3 RID: 143827 RVA: 0x0033ED5E File Offset: 0x0033CF5E
		static ANavSystemConfigOverride()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavSystemConfigOverride");
		}

		// Token: 0x060231D4 RID: 143828 RVA: 0x0033ED6C File Offset: 0x0033CF6C
		protected ANavSystemConfigOverride(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012BEA RID: 76778
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavSystemConfigOverride";

		// Token: 0x04012BEB RID: 76779
		private static IntPtr _ClassPtr;

		// Token: 0x04012BEC RID: 76780
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012BED RID: 76781
		internal static int __PropertyOffset_NavigationSystemConfig;

		// Token: 0x04012BEE RID: 76782
		internal static int __PropertyOffset_OverridePolicy;

		// Token: 0x04012BEF RID: 76783
		internal static int __PropertyOffset_bLoadOnClient;

		// Token: 0x04012BF0 RID: 76784
		internal static byte __PropertyMask_bLoadOnClient;
	}
}
