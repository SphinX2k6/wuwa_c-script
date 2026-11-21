using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200056E RID: 1390
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_HitContextText")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UKSC_DA_HitContextText : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007E62 RID: 32354 RVA: 0x000BB4FA File Offset: 0x000B96FA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_HitContextText._ClassPtr;
		}

		// Token: 0x06007E63 RID: 32355 RVA: 0x000BB508 File Offset: 0x000B9708
		public UKSC_DA_HitContextText() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_HitContextText.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007E64 RID: 32356 RVA: 0x000BB530 File Offset: 0x000B9730
		[NullableContext(1)]
		public UKSC_DA_HitContextText(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_HitContextText.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06007E65 RID: 32357 RVA: 0x000BB563 File Offset: 0x000B9763
		static UKSC_DA_HitContextText()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_HitContextText");
		}

		// Token: 0x06007E66 RID: 32358 RVA: 0x000BB571 File Offset: 0x000B9771
		protected UKSC_DA_HitContextText(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003728 RID: 14120
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_HitContextText";

		// Token: 0x04003729 RID: 14121
		private static IntPtr _ClassPtr;

		// Token: 0x0400372A RID: 14122
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
