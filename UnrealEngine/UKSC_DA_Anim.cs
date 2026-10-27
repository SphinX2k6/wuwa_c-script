using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D4A RID: 7498
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Anim")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public abstract class UKSC_DA_Anim : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CB6B RID: 117611 RVA: 0x002A7271 File Offset: 0x002A5471
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Anim._ClassPtr;
		}

		// Token: 0x1700737F RID: 29567
		// (get) Token: 0x0601CB6C RID: 117612 RVA: 0x002A727D File Offset: 0x002A547D
		// (set) Token: 0x0601CB6D RID: 117613 RVA: 0x002A7291 File Offset: 0x002A5491
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UKSC_Anim> RuntimeClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Anim.__PropertyOffset_RuntimeClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Anim.__PropertyOffset_RuntimeClass) = value;
			}
		}

		// Token: 0x0601CB6E RID: 117614 RVA: 0x002A72A6 File Offset: 0x002A54A6
		static UKSC_DA_Anim()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Anim");
		}

		// Token: 0x0601CB6F RID: 117615 RVA: 0x002A72B4 File Offset: 0x002A54B4
		protected UKSC_DA_Anim() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Anim.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CB70 RID: 117616 RVA: 0x002A72DC File Offset: 0x002A54DC
		protected UKSC_DA_Anim(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F917 RID: 63767
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Anim";

		// Token: 0x0400F918 RID: 63768
		private static IntPtr _ClassPtr;

		// Token: 0x0400F919 RID: 63769
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F91A RID: 63770
		internal static int __PropertyOffset_RuntimeClass;
	}
}
