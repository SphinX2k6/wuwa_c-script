using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D8A RID: 7562
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_CompBase")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public abstract class UKSC_DA_CompBase : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CF33 RID: 118579 RVA: 0x002ACA8A File Offset: 0x002AAC8A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_CompBase._ClassPtr;
		}

		// Token: 0x170074C5 RID: 29893
		// (get) Token: 0x0601CF34 RID: 118580 RVA: 0x002ACA96 File Offset: 0x002AAC96
		// (set) Token: 0x0601CF35 RID: 118581 RVA: 0x002ACAAA File Offset: 0x002AACAA
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

		// Token: 0x0601CF36 RID: 118582 RVA: 0x002ACABF File Offset: 0x002AACBF
		static UKSC_DA_CompBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_CompBase");
		}

		// Token: 0x0601CF37 RID: 118583 RVA: 0x002ACAD0 File Offset: 0x002AACD0
		protected UKSC_DA_CompBase() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_CompBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CF38 RID: 118584 RVA: 0x002ACAF8 File Offset: 0x002AACF8
		protected UKSC_DA_CompBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB62 RID: 64354
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_CompBase";

		// Token: 0x0400FB63 RID: 64355
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB64 RID: 64356
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FB65 RID: 64357
		internal static int __PropertyOffset_RuntimeClass;
	}
}
