using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D37 RID: 7479
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_Stack_ModifyLifeRatio")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UKSC_Buff_Stack_ModifyLifeRatio : UKSC_Buff_Stack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CAA2 RID: 117410 RVA: 0x002A6017 File Offset: 0x002A4217
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_Stack_ModifyLifeRatio._ClassPtr;
		}

		// Token: 0x0601CAA3 RID: 117411 RVA: 0x002A6024 File Offset: 0x002A4224
		public UKSC_Buff_Stack_ModifyLifeRatio() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Stack_ModifyLifeRatio.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CAA4 RID: 117412 RVA: 0x002A604C File Offset: 0x002A424C
		[NullableContext(1)]
		public UKSC_Buff_Stack_ModifyLifeRatio(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Stack_ModifyLifeRatio.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007351 RID: 29521
		// (get) Token: 0x0601CAA5 RID: 117413 RVA: 0x002A607F File Offset: 0x002A427F
		// (set) Token: 0x0601CAA6 RID: 117414 RVA: 0x002A6093 File Offset: 0x002A4293
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_Stack_ModifyLifeRatio DaBuffStackModifyLifeRatio_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_Stack_ModifyLifeRatio>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Stack_ModifyLifeRatio.__PropertyOffset_DaBuffStackModifyLifeRatio_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Stack_ModifyLifeRatio.__PropertyOffset_DaBuffStackModifyLifeRatio_, value);
			}
		}

		// Token: 0x0601CAA7 RID: 117415 RVA: 0x002A60A8 File Offset: 0x002A42A8
		static UKSC_Buff_Stack_ModifyLifeRatio()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_Stack_ModifyLifeRatio");
		}

		// Token: 0x0601CAA8 RID: 117416 RVA: 0x002A60B6 File Offset: 0x002A42B6
		protected UKSC_Buff_Stack_ModifyLifeRatio(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F8A4 RID: 63652
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_Stack_ModifyLifeRatio";

		// Token: 0x0400F8A5 RID: 63653
		private static IntPtr _ClassPtr;

		// Token: 0x0400F8A6 RID: 63654
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F8A7 RID: 63655
		internal static int __PropertyOffset_DaBuffStackModifyLifeRatio_;
	}
}
