using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200197B RID: 6523
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGPUDrivenImposter.KuroGPUDrivenImposterComponent")]
	[UnrealStructLayout(928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 928)]
	public class UKuroGPUDrivenImposterComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018395 RID: 99221 RVA: 0x0023BA8A File Offset: 0x00239C8A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGPUDrivenImposterComponent._ClassPtr;
		}

		// Token: 0x06018396 RID: 99222 RVA: 0x0023BA98 File Offset: 0x00239C98
		public UKuroGPUDrivenImposterComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroGPUDrivenImposterComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018397 RID: 99223 RVA: 0x0023BAC0 File Offset: 0x00239CC0
		public UKuroGPUDrivenImposterComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGPUDrivenImposterComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170060E1 RID: 24801
		// (get) Token: 0x06018398 RID: 99224 RVA: 0x0023BAF3 File Offset: 0x00239CF3
		// (set) Token: 0x06018399 RID: 99225 RVA: 0x0023BB03 File Offset: 0x00239D03
		public unsafe bool bPreview
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGPUDrivenImposterComponent.__PropertyOffset_bPreview) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGPUDrivenImposterComponent.__PropertyOffset_bPreview) = (value ? 1 : 0);
			}
		}

		// Token: 0x170060E2 RID: 24802
		// (get) Token: 0x0601839A RID: 99226 RVA: 0x0023BB14 File Offset: 0x00239D14
		// (set) Token: 0x0601839B RID: 99227 RVA: 0x0023BB4D File Offset: 0x00239D4D
		public FPerPlatformFloat ImposterScreenSizeScaleLod0
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._ImposterScreenSizeScaleLod0) == null)
				{
					result = (this._ImposterScreenSizeScaleLod0 = new FPerPlatformFloat(base.NativePtr + (IntPtr)UKuroGPUDrivenImposterComponent.__PropertyOffset_ImposterScreenSizeScaleLod0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroGPUDrivenImposterComponent.__PropertyOffset_ImposterScreenSizeScaleLod0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060E3 RID: 24803
		// (get) Token: 0x0601839C RID: 99228 RVA: 0x0023BB70 File Offset: 0x00239D70
		// (set) Token: 0x0601839D RID: 99229 RVA: 0x0023BBA9 File Offset: 0x00239DA9
		public FPerPlatformFloat ImposterScreenSizeScaleLod1
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._ImposterScreenSizeScaleLod1) == null)
				{
					result = (this._ImposterScreenSizeScaleLod1 = new FPerPlatformFloat(base.NativePtr + (IntPtr)UKuroGPUDrivenImposterComponent.__PropertyOffset_ImposterScreenSizeScaleLod1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroGPUDrivenImposterComponent.__PropertyOffset_ImposterScreenSizeScaleLod1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060E4 RID: 24804
		// (get) Token: 0x0601839E RID: 99230 RVA: 0x0023BBCA File Offset: 0x00239DCA
		// (set) Token: 0x0601839F RID: 99231 RVA: 0x0023BBDA File Offset: 0x00239DDA
		public unsafe bool ImposterUseComtomBelowThr
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGPUDrivenImposterComponent.__PropertyOffset_ImposterUseComtomBelowThr) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGPUDrivenImposterComponent.__PropertyOffset_ImposterUseComtomBelowThr) = (value ? 1 : 0);
			}
		}

		// Token: 0x170060E5 RID: 24805
		// (get) Token: 0x060183A0 RID: 99232 RVA: 0x0023BBEC File Offset: 0x00239DEC
		// (set) Token: 0x060183A1 RID: 99233 RVA: 0x0023BC25 File Offset: 0x00239E25
		public FPerPlatformFloat ImposterBelowThr
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._ImposterBelowThr) == null)
				{
					result = (this._ImposterBelowThr = new FPerPlatformFloat(base.NativePtr + (IntPtr)UKuroGPUDrivenImposterComponent.__PropertyOffset_ImposterBelowThr, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroGPUDrivenImposterComponent.__PropertyOffset_ImposterBelowThr, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060E6 RID: 24806
		// (get) Token: 0x060183A2 RID: 99234 RVA: 0x0023BC46 File Offset: 0x00239E46
		// (set) Token: 0x060183A3 RID: 99235 RVA: 0x0023BC56 File Offset: 0x00239E56
		public unsafe bool bAllowInstancedStaticMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGPUDrivenImposterComponent.__PropertyOffset_bAllowInstancedStaticMesh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGPUDrivenImposterComponent.__PropertyOffset_bAllowInstancedStaticMesh) = (value ? 1 : 0);
			}
		}

		// Token: 0x060183A4 RID: 99236 RVA: 0x0023BC67 File Offset: 0x00239E67
		static UKuroGPUDrivenImposterComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGPUDrivenImposter.KuroGPUDrivenImposterComponent");
		}

		// Token: 0x060183A5 RID: 99237 RVA: 0x0023BC75 File Offset: 0x00239E75
		protected UKuroGPUDrivenImposterComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D1E8 RID: 53736
		public new const string __ObjectPath = "/Script/KuroGPUDrivenImposter.KuroGPUDrivenImposterComponent";

		// Token: 0x0400D1E9 RID: 53737
		private static IntPtr _ClassPtr;

		// Token: 0x0400D1EA RID: 53738
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D1EB RID: 53739
		internal static int __PropertyOffset_bPreview;

		// Token: 0x0400D1EC RID: 53740
		internal static int __PropertyOffset_ImposterScreenSizeScaleLod0;

		// Token: 0x0400D1ED RID: 53741
		[Nullable(2)]
		private FPerPlatformFloat _ImposterScreenSizeScaleLod0;

		// Token: 0x0400D1EE RID: 53742
		internal static int __PropertyOffset_ImposterScreenSizeScaleLod1;

		// Token: 0x0400D1EF RID: 53743
		[Nullable(2)]
		private FPerPlatformFloat _ImposterScreenSizeScaleLod1;

		// Token: 0x0400D1F0 RID: 53744
		internal static int __PropertyOffset_ImposterUseComtomBelowThr;

		// Token: 0x0400D1F1 RID: 53745
		internal static int __PropertyOffset_ImposterBelowThr;

		// Token: 0x0400D1F2 RID: 53746
		[Nullable(2)]
		private FPerPlatformFloat _ImposterBelowThr;

		// Token: 0x0400D1F3 RID: 53747
		internal static int __PropertyOffset_bAllowInstancedStaticMesh;
	}
}
