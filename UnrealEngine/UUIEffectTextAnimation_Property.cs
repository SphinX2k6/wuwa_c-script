using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002156 RID: 8534
	[UnrealObjectPath("/Script/LGUI.UIEffectTextAnimation_Property")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UUIEffectTextAnimation_Property : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060202E9 RID: 131817 RVA: 0x002FD026 File Offset: 0x002FB226
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectTextAnimation_Property._ClassPtr;
		}

		// Token: 0x060202EA RID: 131818 RVA: 0x002FD032 File Offset: 0x002FB232
		static UUIEffectTextAnimation_Property()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectTextAnimation_Property");
		}

		// Token: 0x060202EB RID: 131819 RVA: 0x002FD040 File Offset: 0x002FB240
		protected UUIEffectTextAnimation_Property() : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_Property.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060202EC RID: 131820 RVA: 0x002FD068 File Offset: 0x002FB268
		protected UUIEffectTextAnimation_Property(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040114D4 RID: 70868
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectTextAnimation_Property";

		// Token: 0x040114D5 RID: 70869
		private static IntPtr _ClassPtr;

		// Token: 0x040114D6 RID: 70870
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
