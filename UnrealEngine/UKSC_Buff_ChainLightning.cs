using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D0F RID: 7439
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_ChainLightning")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UKSC_Buff_ChainLightning : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C970 RID: 117104 RVA: 0x002A4393 File Offset: 0x002A2593
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_ChainLightning._ClassPtr;
		}

		// Token: 0x0601C971 RID: 117105 RVA: 0x002A43A0 File Offset: 0x002A25A0
		public UKSC_Buff_ChainLightning() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ChainLightning.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C972 RID: 117106 RVA: 0x002A43C8 File Offset: 0x002A25C8
		[NullableContext(1)]
		public UKSC_Buff_ChainLightning(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ChainLightning.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700731F RID: 29471
		// (get) Token: 0x0601C973 RID: 117107 RVA: 0x002A43FB File Offset: 0x002A25FB
		// (set) Token: 0x0601C974 RID: 117108 RVA: 0x002A440F File Offset: 0x002A260F
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_ChainLightning DaBuff_ChainLightning_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_ChainLightning>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ChainLightning.__PropertyOffset_DaBuff_ChainLightning_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ChainLightning.__PropertyOffset_DaBuff_ChainLightning_, value);
			}
		}

		// Token: 0x0601C975 RID: 117109 RVA: 0x002A4424 File Offset: 0x002A2624
		static UKSC_Buff_ChainLightning()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_ChainLightning");
		}

		// Token: 0x0601C976 RID: 117110 RVA: 0x002A4432 File Offset: 0x002A2632
		protected UKSC_Buff_ChainLightning(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F7F6 RID: 63478
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_ChainLightning";

		// Token: 0x0400F7F7 RID: 63479
		private static IntPtr _ClassPtr;

		// Token: 0x0400F7F8 RID: 63480
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F7F9 RID: 63481
		internal static int __PropertyOffset_DaBuff_ChainLightning_;
	}
}
