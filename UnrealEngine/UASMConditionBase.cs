using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002867 RID: 10343
	[UnrealObjectPath("/Script/SMSystem.ASMConditionBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UASMConditionBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602655A RID: 157018 RVA: 0x003A3B7E File Offset: 0x003A1D7E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UASMConditionBase._ClassPtr;
		}

		// Token: 0x170093F7 RID: 37879
		// (get) Token: 0x0602655B RID: 157019 RVA: 0x003A3B8A File Offset: 0x003A1D8A
		// (set) Token: 0x0602655C RID: 157020 RVA: 0x003A3B9A File Offset: 0x003A1D9A
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

		// Token: 0x0602655D RID: 157021 RVA: 0x003A3BAB File Offset: 0x003A1DAB
		static UASMConditionBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.ASMConditionBase");
		}

		// Token: 0x0602655E RID: 157022 RVA: 0x003A3BBC File Offset: 0x003A1DBC
		protected UASMConditionBase() : this(BuiltinUtils.AllocNativeUObject(UASMConditionBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602655F RID: 157023 RVA: 0x003A3BE4 File Offset: 0x003A1DE4
		protected UASMConditionBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015053 RID: 86099
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.ASMConditionBase";

		// Token: 0x04015054 RID: 86100
		private static IntPtr _ClassPtr;

		// Token: 0x04015055 RID: 86101
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015056 RID: 86102
		internal static int __PropertyOffset_Reverse;
	}
}
