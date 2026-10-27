using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DA2 RID: 7586
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Move_Follow")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKSC_DA_Move_Follow : UKSC_DA_Move, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D037 RID: 118839 RVA: 0x002AE198 File Offset: 0x002AC398
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Move_Follow._ClassPtr;
		}

		// Token: 0x0601D038 RID: 118840 RVA: 0x002AE1A4 File Offset: 0x002AC3A4
		public UKSC_DA_Move_Follow() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Move_Follow.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D039 RID: 118841 RVA: 0x002AE1CC File Offset: 0x002AC3CC
		[NullableContext(1)]
		public UKSC_DA_Move_Follow(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Move_Follow.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D03A RID: 118842 RVA: 0x002AE1FF File Offset: 0x002AC3FF
		static UKSC_DA_Move_Follow()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Move_Follow");
		}

		// Token: 0x0601D03B RID: 118843 RVA: 0x002AE20D File Offset: 0x002AC40D
		protected UKSC_DA_Move_Follow(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FBFB RID: 64507
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Move_Follow";

		// Token: 0x0400FBFC RID: 64508
		private static IntPtr _ClassPtr;

		// Token: 0x0400FBFD RID: 64509
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
