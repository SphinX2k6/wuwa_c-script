using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000268 RID: 616
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PostProcessComponent")]
	[UnrealStructLayout(3248, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3248)]
	public class UPostProcessComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060036BD RID: 14013 RVA: 0x0004D222 File Offset: 0x0004B422
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPostProcessComponent._ClassPtr;
		}

		// Token: 0x060036BE RID: 14014 RVA: 0x0004D230 File Offset: 0x0004B430
		public UPostProcessComponent() : this(BuiltinUtils.AllocNativeUObject(UPostProcessComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x0004D258 File Offset: 0x0004B458
		public UPostProcessComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPostProcessComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x060036C0 RID: 14016 RVA: 0x0004D28C File Offset: 0x0004B48C
		// (set) Token: 0x060036C1 RID: 14017 RVA: 0x0004D2C5 File Offset: 0x0004B4C5
		public FPostProcessSettings Settings
		{
			get
			{
				base.FastCheckIsValid();
				FPostProcessSettings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new FPostProcessSettings(base.NativePtr + (IntPtr)UPostProcessComponent.__PropertyOffset_Settings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPostProcessSettings.StaticStruct(), base.NativePtr + (IntPtr)UPostProcessComponent.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x060036C2 RID: 14018 RVA: 0x0004D2E6 File Offset: 0x0004B4E6
		// (set) Token: 0x060036C3 RID: 14019 RVA: 0x0004D2F6 File Offset: 0x0004B4F6
		public unsafe float Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPostProcessComponent.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPostProcessComponent.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x060036C4 RID: 14020 RVA: 0x0004D307 File Offset: 0x0004B507
		// (set) Token: 0x060036C5 RID: 14021 RVA: 0x0004D317 File Offset: 0x0004B517
		public unsafe float BlendRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPostProcessComponent.__PropertyOffset_BlendRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPostProcessComponent.__PropertyOffset_BlendRadius) = value;
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x060036C6 RID: 14022 RVA: 0x0004D328 File Offset: 0x0004B528
		// (set) Token: 0x060036C7 RID: 14023 RVA: 0x0004D338 File Offset: 0x0004B538
		public unsafe float BlendWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPostProcessComponent.__PropertyOffset_BlendWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPostProcessComponent.__PropertyOffset_BlendWeight) = value;
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x060036C8 RID: 14024 RVA: 0x0004D349 File Offset: 0x0004B549
		// (set) Token: 0x060036C9 RID: 14025 RVA: 0x0004D362 File Offset: 0x0004B562
		public unsafe bool bEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPostProcessComponent.__PropertyOffset_bEnabled) & UPostProcessComponent.__PropertyMask_bEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPostProcessComponent.__PropertyOffset_bEnabled) = ((*(base.NativePtr + (IntPtr)UPostProcessComponent.__PropertyOffset_bEnabled) & ~UPostProcessComponent.__PropertyMask_bEnabled) | (value ? UPostProcessComponent.__PropertyMask_bEnabled : 0));
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x060036CA RID: 14026 RVA: 0x0004D392 File Offset: 0x0004B592
		// (set) Token: 0x060036CB RID: 14027 RVA: 0x0004D3AB File Offset: 0x0004B5AB
		public unsafe bool bUnbound
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPostProcessComponent.__PropertyOffset_bUnbound) & UPostProcessComponent.__PropertyMask_bUnbound) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPostProcessComponent.__PropertyOffset_bUnbound) = ((*(base.NativePtr + (IntPtr)UPostProcessComponent.__PropertyOffset_bUnbound) & ~UPostProcessComponent.__PropertyMask_bUnbound) | (value ? UPostProcessComponent.__PropertyMask_bUnbound : 0));
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x060036CC RID: 14028 RVA: 0x0004D3DB File Offset: 0x0004B5DB
		// (set) Token: 0x060036CD RID: 14029 RVA: 0x0004D3F4 File Offset: 0x0004B5F4
		public unsafe bool bIsUISceneRendering
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPostProcessComponent.__PropertyOffset_bIsUISceneRendering) & UPostProcessComponent.__PropertyMask_bIsUISceneRendering) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPostProcessComponent.__PropertyOffset_bIsUISceneRendering) = ((*(base.NativePtr + (IntPtr)UPostProcessComponent.__PropertyOffset_bIsUISceneRendering) & ~UPostProcessComponent.__PropertyMask_bIsUISceneRendering) | (value ? UPostProcessComponent.__PropertyMask_bIsUISceneRendering : 0));
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x060036CE RID: 14030 RVA: 0x0004D424 File Offset: 0x0004B624
		// (set) Token: 0x060036CF RID: 14031 RVA: 0x0004D43D File Offset: 0x0004B63D
		public unsafe bool bIsEffectVolume
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPostProcessComponent.__PropertyOffset_bIsEffectVolume) & UPostProcessComponent.__PropertyMask_bIsEffectVolume) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPostProcessComponent.__PropertyOffset_bIsEffectVolume) = ((*(base.NativePtr + (IntPtr)UPostProcessComponent.__PropertyOffset_bIsEffectVolume) & ~UPostProcessComponent.__PropertyMask_bIsEffectVolume) | (value ? UPostProcessComponent.__PropertyMask_bIsEffectVolume : 0));
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x060036D0 RID: 14032 RVA: 0x0004D46D File Offset: 0x0004B66D
		// (set) Token: 0x060036D1 RID: 14033 RVA: 0x0004D47D File Offset: 0x0004B67D
		public unsafe int CustomCullFlag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPostProcessComponent.__PropertyOffset_CustomCullFlag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPostProcessComponent.__PropertyOffset_CustomCullFlag) = value;
			}
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x0004D48E File Offset: 0x0004B68E
		public void SetPriority(float InPriority)
		{
			UPostProcessComponent.__SetPriority_Internal(base.NativePtr, InPriority);
		}

		// Token: 0x060036D3 RID: 14035
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPriority_Internal(IntPtr @this, float InPriority);

		// Token: 0x060036D4 RID: 14036 RVA: 0x0004D49C File Offset: 0x0004B69C
		static UPostProcessComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PostProcessComponent");
		}

		// Token: 0x060036D5 RID: 14037 RVA: 0x0004D4AA File Offset: 0x0004B6AA
		protected UPostProcessComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040012DC RID: 4828
		public new const string __ObjectPath = "/Script/Engine.PostProcessComponent";

		// Token: 0x040012DD RID: 4829
		private static IntPtr _ClassPtr;

		// Token: 0x040012DE RID: 4830
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040012DF RID: 4831
		internal static int __PropertyOffset_Settings;

		// Token: 0x040012E0 RID: 4832
		[Nullable(2)]
		private FPostProcessSettings _Settings;

		// Token: 0x040012E1 RID: 4833
		internal static int __PropertyOffset_Priority;

		// Token: 0x040012E2 RID: 4834
		internal static int __PropertyOffset_BlendRadius;

		// Token: 0x040012E3 RID: 4835
		internal static int __PropertyOffset_BlendWeight;

		// Token: 0x040012E4 RID: 4836
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x040012E5 RID: 4837
		internal static byte __PropertyMask_bEnabled;

		// Token: 0x040012E6 RID: 4838
		internal static int __PropertyOffset_bUnbound;

		// Token: 0x040012E7 RID: 4839
		internal static byte __PropertyMask_bUnbound;

		// Token: 0x040012E8 RID: 4840
		internal static int __PropertyOffset_bIsUISceneRendering;

		// Token: 0x040012E9 RID: 4841
		internal static byte __PropertyMask_bIsUISceneRendering;

		// Token: 0x040012EA RID: 4842
		internal static int __PropertyOffset_bIsEffectVolume;

		// Token: 0x040012EB RID: 4843
		internal static byte __PropertyMask_bIsEffectVolume;

		// Token: 0x040012EC RID: 4844
		internal static int __PropertyOffset_CustomCullFlag;
	}
}
