using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D4D RID: 7501
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_BuffEffectBase")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public abstract class UKSC_DA_BuffEffectBase : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CBBB RID: 117691 RVA: 0x002A7928 File Offset: 0x002A5B28
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_BuffEffectBase._ClassPtr;
		}

		// Token: 0x170073A0 RID: 29600
		// (get) Token: 0x0601CBBC RID: 117692 RVA: 0x002A7934 File Offset: 0x002A5B34
		// (set) Token: 0x0601CBBD RID: 117693 RVA: 0x002A7948 File Offset: 0x002A5B48
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UKSC_BuffEffectBase> RuntimeClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_BuffEffectBase.__PropertyOffset_RuntimeClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_BuffEffectBase.__PropertyOffset_RuntimeClass) = value;
			}
		}

		// Token: 0x0601CBBE RID: 117694 RVA: 0x002A795D File Offset: 0x002A5B5D
		static UKSC_DA_BuffEffectBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_BuffEffectBase");
		}

		// Token: 0x0601CBBF RID: 117695 RVA: 0x002A796C File Offset: 0x002A5B6C
		protected UKSC_DA_BuffEffectBase() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_BuffEffectBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CBC0 RID: 117696 RVA: 0x002A7994 File Offset: 0x002A5B94
		protected UKSC_DA_BuffEffectBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F945 RID: 63813
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_BuffEffectBase";

		// Token: 0x0400F946 RID: 63814
		private static IntPtr _ClassPtr;

		// Token: 0x0400F947 RID: 63815
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F948 RID: 63816
		internal static int __PropertyOffset_RuntimeClass;
	}
}
