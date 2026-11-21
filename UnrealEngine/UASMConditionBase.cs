using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000822 RID: 2082
	[UnrealObjectPath("/Script/SMSystem.ASMConditionBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UASMConditionBase : UASMConfigBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B603 RID: 46595 RVA: 0x0012183E File Offset: 0x0011FA3E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UASMConditionBase._ClassPtr;
		}

		// Token: 0x17002215 RID: 8725
		// (get) Token: 0x0600B604 RID: 46596 RVA: 0x0012184A File Offset: 0x0011FA4A
		// (set) Token: 0x0600B605 RID: 46597 RVA: 0x0012185A File Offset: 0x0011FA5A
		public unsafe bool Reverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UASMConditionBase.__PropertyOffset_Reverse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UASMConditionBase.__PropertyOffset_Reverse) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600B606 RID: 46598 RVA: 0x0012186B File Offset: 0x0011FA6B
		static UASMConditionBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.ASMConditionBase");
		}

		// Token: 0x0600B607 RID: 46599 RVA: 0x0012187C File Offset: 0x0011FA7C
		protected UASMConditionBase() : this(BuiltinUtils.AllocNativeUObject(UASMConditionBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B608 RID: 46600 RVA: 0x001218A4 File Offset: 0x0011FAA4
		protected UASMConditionBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400523F RID: 21055
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.ASMConditionBase";

		// Token: 0x04005240 RID: 21056
		private static IntPtr _ClassPtr;

		// Token: 0x04005241 RID: 21057
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005242 RID: 21058
		internal static int __PropertyOffset_Reverse;
	}
}
