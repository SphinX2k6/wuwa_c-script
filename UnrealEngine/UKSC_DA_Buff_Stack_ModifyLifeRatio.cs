using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D81 RID: 7553
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_Stack_ModifyLifeRatio")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class UKSC_DA_Buff_Stack_ModifyLifeRatio : UKSC_DA_Buff_Stack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CECA RID: 118474 RVA: 0x002AC0DE File Offset: 0x002AA2DE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_Stack_ModifyLifeRatio._ClassPtr;
		}

		// Token: 0x0601CECB RID: 118475 RVA: 0x002AC0EC File Offset: 0x002AA2EC
		public UKSC_DA_Buff_Stack_ModifyLifeRatio() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Stack_ModifyLifeRatio.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CECC RID: 118476 RVA: 0x002AC114 File Offset: 0x002AA314
		[NullableContext(1)]
		public UKSC_DA_Buff_Stack_ModifyLifeRatio(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Stack_ModifyLifeRatio.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170074A7 RID: 29863
		// (get) Token: 0x0601CECD RID: 118477 RVA: 0x002AC147 File Offset: 0x002AA347
		// (set) Token: 0x0601CECE RID: 118478 RVA: 0x002AC157 File Offset: 0x002AA357
		public unsafe int LifeRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Stack_ModifyLifeRatio.__PropertyOffset_LifeRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Stack_ModifyLifeRatio.__PropertyOffset_LifeRatio) = value;
			}
		}

		// Token: 0x0601CECF RID: 118479 RVA: 0x002AC168 File Offset: 0x002AA368
		static UKSC_DA_Buff_Stack_ModifyLifeRatio()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_Stack_ModifyLifeRatio");
		}

		// Token: 0x0601CED0 RID: 118480 RVA: 0x002AC176 File Offset: 0x002AA376
		protected UKSC_DA_Buff_Stack_ModifyLifeRatio(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB23 RID: 64291
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_Stack_ModifyLifeRatio";

		// Token: 0x0400FB24 RID: 64292
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB25 RID: 64293
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FB26 RID: 64294
		internal static int __PropertyOffset_LifeRatio;
	}
}
