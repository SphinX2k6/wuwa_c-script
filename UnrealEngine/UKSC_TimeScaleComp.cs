using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E5A RID: 7770
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_TimeScaleComp")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UKSC_TimeScaleComp : UKSC_CompBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D967 RID: 121191 RVA: 0x002BAF4A File Offset: 0x002B914A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_TimeScaleComp._ClassPtr;
		}

		// Token: 0x0601D968 RID: 121192 RVA: 0x002BAF58 File Offset: 0x002B9158
		public UKSC_TimeScaleComp() : this(BuiltinUtils.AllocNativeUObject(UKSC_TimeScaleComp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D969 RID: 121193 RVA: 0x002BAF80 File Offset: 0x002B9180
		[NullableContext(1)]
		public UKSC_TimeScaleComp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_TimeScaleComp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D96A RID: 121194 RVA: 0x002BAFB3 File Offset: 0x002B91B3
		static UKSC_TimeScaleComp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_TimeScaleComp");
		}

		// Token: 0x0601D96B RID: 121195 RVA: 0x002BAFC1 File Offset: 0x002B91C1
		protected UKSC_TimeScaleComp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401009F RID: 65695
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_TimeScaleComp";

		// Token: 0x040100A0 RID: 65696
		private static IntPtr _ClassPtr;

		// Token: 0x040100A1 RID: 65697
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
