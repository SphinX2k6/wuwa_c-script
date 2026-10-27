using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D18 RID: 7448
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_Invisible")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKSC_Buff_Invisible : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C9B1 RID: 117169 RVA: 0x002A498B File Offset: 0x002A2B8B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_Invisible._ClassPtr;
		}

		// Token: 0x0601C9B2 RID: 117170 RVA: 0x002A4998 File Offset: 0x002A2B98
		public UKSC_Buff_Invisible() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Invisible.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C9B3 RID: 117171 RVA: 0x002A49C0 File Offset: 0x002A2BC0
		[NullableContext(1)]
		public UKSC_Buff_Invisible(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Invisible.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007328 RID: 29480
		// (get) Token: 0x0601C9B4 RID: 117172 RVA: 0x002A49F3 File Offset: 0x002A2BF3
		// (set) Token: 0x0601C9B5 RID: 117173 RVA: 0x002A4A07 File Offset: 0x002A2C07
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_Invisible DaBuffInvisible_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_Invisible>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Invisible.__PropertyOffset_DaBuffInvisible_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Invisible.__PropertyOffset_DaBuffInvisible_, value);
			}
		}

		// Token: 0x0601C9B6 RID: 117174 RVA: 0x002A4A1C File Offset: 0x002A2C1C
		static UKSC_Buff_Invisible()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_Invisible");
		}

		// Token: 0x0601C9B7 RID: 117175 RVA: 0x002A4A2A File Offset: 0x002A2C2A
		protected UKSC_Buff_Invisible(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F81A RID: 63514
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_Invisible";

		// Token: 0x0400F81B RID: 63515
		private static IntPtr _ClassPtr;

		// Token: 0x0400F81C RID: 63516
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F81D RID: 63517
		internal static int __PropertyOffset_DaBuffInvisible_;
	}
}
