using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200198F RID: 6543
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroImposter.KuroImposterComponent")]
	[UnrealStructLayout(928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 928)]
	public class UKuroImposterComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060184F4 RID: 99572 RVA: 0x0023D9AA File Offset: 0x0023BBAA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroImposterComponent._ClassPtr;
		}

		// Token: 0x060184F5 RID: 99573 RVA: 0x0023D9B8 File Offset: 0x0023BBB8
		public UKuroImposterComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroImposterComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060184F6 RID: 99574 RVA: 0x0023D9E0 File Offset: 0x0023BBE0
		public UKuroImposterComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroImposterComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006110 RID: 24848
		// (get) Token: 0x060184F7 RID: 99575 RVA: 0x0023DA13 File Offset: 0x0023BC13
		// (set) Token: 0x060184F8 RID: 99576 RVA: 0x0023DA23 File Offset: 0x0023BC23
		public unsafe bool bPreview
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroImposterComponent.__PropertyOffset_bPreview) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroImposterComponent.__PropertyOffset_bPreview) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006111 RID: 24849
		// (get) Token: 0x060184F9 RID: 99577 RVA: 0x0023DA34 File Offset: 0x0023BC34
		// (set) Token: 0x060184FA RID: 99578 RVA: 0x0023DA6D File Offset: 0x0023BC6D
		public FPerPlatformFloat ImposterScreenSizeScaleLod0
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._ImposterScreenSizeScaleLod0) == null)
				{
					result = (this._ImposterScreenSizeScaleLod0 = new FPerPlatformFloat(base.NativePtr + (IntPtr)UKuroImposterComponent.__PropertyOffset_ImposterScreenSizeScaleLod0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroImposterComponent.__PropertyOffset_ImposterScreenSizeScaleLod0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006112 RID: 24850
		// (get) Token: 0x060184FB RID: 99579 RVA: 0x0023DA90 File Offset: 0x0023BC90
		// (set) Token: 0x060184FC RID: 99580 RVA: 0x0023DAC9 File Offset: 0x0023BCC9
		public FPerPlatformFloat ImposterScreenSizeScaleLod1
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._ImposterScreenSizeScaleLod1) == null)
				{
					result = (this._ImposterScreenSizeScaleLod1 = new FPerPlatformFloat(base.NativePtr + (IntPtr)UKuroImposterComponent.__PropertyOffset_ImposterScreenSizeScaleLod1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroImposterComponent.__PropertyOffset_ImposterScreenSizeScaleLod1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006113 RID: 24851
		// (get) Token: 0x060184FD RID: 99581 RVA: 0x0023DAEA File Offset: 0x0023BCEA
		// (set) Token: 0x060184FE RID: 99582 RVA: 0x0023DAFA File Offset: 0x0023BCFA
		public unsafe bool ImposterUseComtomBelowThr
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroImposterComponent.__PropertyOffset_ImposterUseComtomBelowThr) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroImposterComponent.__PropertyOffset_ImposterUseComtomBelowThr) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006114 RID: 24852
		// (get) Token: 0x060184FF RID: 99583 RVA: 0x0023DB0C File Offset: 0x0023BD0C
		// (set) Token: 0x06018500 RID: 99584 RVA: 0x0023DB45 File Offset: 0x0023BD45
		public FPerPlatformFloat ImposterBelowThr
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._ImposterBelowThr) == null)
				{
					result = (this._ImposterBelowThr = new FPerPlatformFloat(base.NativePtr + (IntPtr)UKuroImposterComponent.__PropertyOffset_ImposterBelowThr, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroImposterComponent.__PropertyOffset_ImposterBelowThr, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06018501 RID: 99585 RVA: 0x0023DB66 File Offset: 0x0023BD66
		static UKuroImposterComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroImposter.KuroImposterComponent");
		}

		// Token: 0x06018502 RID: 99586 RVA: 0x0023DB74 File Offset: 0x0023BD74
		protected UKuroImposterComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D268 RID: 53864
		public new const string __ObjectPath = "/Script/KuroImposter.KuroImposterComponent";

		// Token: 0x0400D269 RID: 53865
		private static IntPtr _ClassPtr;

		// Token: 0x0400D26A RID: 53866
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D26B RID: 53867
		internal static int __PropertyOffset_bPreview;

		// Token: 0x0400D26C RID: 53868
		internal static int __PropertyOffset_ImposterScreenSizeScaleLod0;

		// Token: 0x0400D26D RID: 53869
		[Nullable(2)]
		private FPerPlatformFloat _ImposterScreenSizeScaleLod0;

		// Token: 0x0400D26E RID: 53870
		internal static int __PropertyOffset_ImposterScreenSizeScaleLod1;

		// Token: 0x0400D26F RID: 53871
		[Nullable(2)]
		private FPerPlatformFloat _ImposterScreenSizeScaleLod1;

		// Token: 0x0400D270 RID: 53872
		internal static int __PropertyOffset_ImposterUseComtomBelowThr;

		// Token: 0x0400D271 RID: 53873
		internal static int __PropertyOffset_ImposterBelowThr;

		// Token: 0x0400D272 RID: 53874
		[Nullable(2)]
		private FPerPlatformFloat _ImposterBelowThr;
	}
}
