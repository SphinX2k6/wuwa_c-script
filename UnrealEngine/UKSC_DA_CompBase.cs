using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000569 RID: 1385
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_CompBase")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public abstract class UKSC_DA_CompBase : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007E22 RID: 32290 RVA: 0x000BAF54 File Offset: 0x000B9154
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_CompBase._ClassPtr;
		}

		// Token: 0x1700185B RID: 6235
		// (get) Token: 0x06007E23 RID: 32291 RVA: 0x000BAF60 File Offset: 0x000B9160
		// (set) Token: 0x06007E24 RID: 32292 RVA: 0x000BAF74 File Offset: 0x000B9174
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UKSC_CompBase> RuntimeClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_CompBase.__PropertyOffset_RuntimeClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_CompBase.__PropertyOffset_RuntimeClass) = value;
			}
		}

		// Token: 0x06007E25 RID: 32293 RVA: 0x000BAF89 File Offset: 0x000B9189
		static UKSC_DA_CompBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_CompBase");
		}

		// Token: 0x06007E26 RID: 32294 RVA: 0x000BAF98 File Offset: 0x000B9198
		protected UKSC_DA_CompBase() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_CompBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007E27 RID: 32295 RVA: 0x000BAFC0 File Offset: 0x000B91C0
		protected UKSC_DA_CompBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003702 RID: 14082
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_CompBase";

		// Token: 0x04003703 RID: 14083
		private static IntPtr _ClassPtr;

		// Token: 0x04003704 RID: 14084
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003705 RID: 14085
		internal static int __PropertyOffset_RuntimeClass;
	}
}
