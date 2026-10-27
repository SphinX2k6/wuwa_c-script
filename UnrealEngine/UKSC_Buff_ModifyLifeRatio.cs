using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D26 RID: 7462
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_ModifyLifeRatio")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_Buff_ModifyLifeRatio : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CA29 RID: 117289 RVA: 0x002A54DF File Offset: 0x002A36DF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_ModifyLifeRatio._ClassPtr;
		}

		// Token: 0x0601CA2A RID: 117290 RVA: 0x002A54EC File Offset: 0x002A36EC
		public UKSC_Buff_ModifyLifeRatio() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ModifyLifeRatio.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CA2B RID: 117291 RVA: 0x002A5514 File Offset: 0x002A3714
		[NullableContext(1)]
		public UKSC_Buff_ModifyLifeRatio(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ModifyLifeRatio.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007340 RID: 29504
		// (get) Token: 0x0601CA2C RID: 117292 RVA: 0x002A5547 File Offset: 0x002A3747
		// (set) Token: 0x0601CA2D RID: 117293 RVA: 0x002A555B File Offset: 0x002A375B
		[Nullable(2)]
		public unsafe UKsc_Da_Buff_ModifyLifeRatio DaBuffModifyHpPercent_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKsc_Da_Buff_ModifyLifeRatio>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ModifyLifeRatio.__PropertyOffset_DaBuffModifyHpPercent_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ModifyLifeRatio.__PropertyOffset_DaBuffModifyHpPercent_, value);
			}
		}

		// Token: 0x0601CA2E RID: 117294 RVA: 0x002A5570 File Offset: 0x002A3770
		static UKSC_Buff_ModifyLifeRatio()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_ModifyLifeRatio");
		}

		// Token: 0x0601CA2F RID: 117295 RVA: 0x002A557E File Offset: 0x002A377E
		protected UKSC_Buff_ModifyLifeRatio(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F860 RID: 63584
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_ModifyLifeRatio";

		// Token: 0x0400F861 RID: 63585
		private static IntPtr _ClassPtr;

		// Token: 0x0400F862 RID: 63586
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F863 RID: 63587
		internal static int __PropertyOffset_DaBuffModifyHpPercent_;
	}
}
