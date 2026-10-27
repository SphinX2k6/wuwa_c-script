using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001026 RID: 4134
	[UnrealObjectPath("/Script/Engine.PostProcessVolume")]
	[UnrealStructLayout(3744, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3744)]
	public class APostProcessVolume : AVolume, IUnrealUObject, IUnrealObject, IInterface_PostProcessVolume, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0600E89C RID: 59548 RVA: 0x00159900 File Offset: 0x00157B00
		public new static UClassStackOnlyPtr StaticClass()
		{
			return APostProcessVolume._ClassPtr;
		}

		// Token: 0x0600E89D RID: 59549 RVA: 0x0015990C File Offset: 0x00157B0C
		int IInterface_PostProcessVolume.InterfaceOffset()
		{
			return APostProcessVolume.__InterfaceOffset_IInterface_PostProcessVolume;
		}

		// Token: 0x0600E89E RID: 59550 RVA: 0x00159914 File Offset: 0x00157B14
		public APostProcessVolume() : this(BuiltinUtils.AllocNativeUObject(APostProcessVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600E89F RID: 59551 RVA: 0x0015993C File Offset: 0x00157B3C
		[NullableContext(1)]
		public APostProcessVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(APostProcessVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003851 RID: 14417
		// (get) Token: 0x0600E8A0 RID: 59552 RVA: 0x00159970 File Offset: 0x00157B70
		// (set) Token: 0x0600E8A1 RID: 59553 RVA: 0x001599A9 File Offset: 0x00157BA9
		[Nullable(1)]
		public FPostProcessSettings Settings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FPostProcessSettings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new FPostProcessSettings(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_Settings, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPostProcessSettings.StaticStruct(), base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003852 RID: 14418
		// (get) Token: 0x0600E8A2 RID: 59554 RVA: 0x001599CA File Offset: 0x00157BCA
		// (set) Token: 0x0600E8A3 RID: 59555 RVA: 0x001599DA File Offset: 0x00157BDA
		public unsafe float Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x17003853 RID: 14419
		// (get) Token: 0x0600E8A4 RID: 59556 RVA: 0x001599EB File Offset: 0x00157BEB
		// (set) Token: 0x0600E8A5 RID: 59557 RVA: 0x001599FB File Offset: 0x00157BFB
		public unsafe float BlendRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_BlendRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_BlendRadius) = value;
			}
		}

		// Token: 0x17003854 RID: 14420
		// (get) Token: 0x0600E8A6 RID: 59558 RVA: 0x00159A0C File Offset: 0x00157C0C
		// (set) Token: 0x0600E8A7 RID: 59559 RVA: 0x00159A1C File Offset: 0x00157C1C
		public unsafe float BlendWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_BlendWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_BlendWeight) = value;
			}
		}

		// Token: 0x17003855 RID: 14421
		// (get) Token: 0x0600E8A8 RID: 59560 RVA: 0x00159A2D File Offset: 0x00157C2D
		// (set) Token: 0x0600E8A9 RID: 59561 RVA: 0x00159A46 File Offset: 0x00157C46
		public unsafe bool bEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_bEnabled) & APostProcessVolume.__PropertyMask_bEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_bEnabled) = ((*(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_bEnabled) & ~APostProcessVolume.__PropertyMask_bEnabled) | (value ? APostProcessVolume.__PropertyMask_bEnabled : 0));
			}
		}

		// Token: 0x17003856 RID: 14422
		// (get) Token: 0x0600E8AA RID: 59562 RVA: 0x00159A76 File Offset: 0x00157C76
		// (set) Token: 0x0600E8AB RID: 59563 RVA: 0x00159A8F File Offset: 0x00157C8F
		public unsafe bool bUnbound
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_bUnbound) & APostProcessVolume.__PropertyMask_bUnbound) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_bUnbound) = ((*(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_bUnbound) & ~APostProcessVolume.__PropertyMask_bUnbound) | (value ? APostProcessVolume.__PropertyMask_bUnbound : 0));
			}
		}

		// Token: 0x17003857 RID: 14423
		// (get) Token: 0x0600E8AC RID: 59564 RVA: 0x00159ABF File Offset: 0x00157CBF
		// (set) Token: 0x0600E8AD RID: 59565 RVA: 0x00159AD8 File Offset: 0x00157CD8
		public unsafe bool bIsUISceneRendering
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_bIsUISceneRendering) & APostProcessVolume.__PropertyMask_bIsUISceneRendering) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_bIsUISceneRendering) = ((*(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_bIsUISceneRendering) & ~APostProcessVolume.__PropertyMask_bIsUISceneRendering) | (value ? APostProcessVolume.__PropertyMask_bIsUISceneRendering : 0));
			}
		}

		// Token: 0x17003858 RID: 14424
		// (get) Token: 0x0600E8AE RID: 59566 RVA: 0x00159B08 File Offset: 0x00157D08
		// (set) Token: 0x0600E8AF RID: 59567 RVA: 0x00159B21 File Offset: 0x00157D21
		public unsafe bool bIsEffectVolume
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_bIsEffectVolume) & APostProcessVolume.__PropertyMask_bIsEffectVolume) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_bIsEffectVolume) = ((*(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_bIsEffectVolume) & ~APostProcessVolume.__PropertyMask_bIsEffectVolume) | (value ? APostProcessVolume.__PropertyMask_bIsEffectVolume : 0));
			}
		}

		// Token: 0x17003859 RID: 14425
		// (get) Token: 0x0600E8B0 RID: 59568 RVA: 0x00159B51 File Offset: 0x00157D51
		// (set) Token: 0x0600E8B1 RID: 59569 RVA: 0x00159B61 File Offset: 0x00157D61
		public unsafe int CustomCullFlag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_CustomCullFlag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_CustomCullFlag) = value;
			}
		}

		// Token: 0x0600E8B2 RID: 59570 RVA: 0x00159B74 File Offset: 0x00157D74
		[NullableContext(2)]
		public void AddOrUpdateBlendable(IBlendableInterface InBlendableObject, float InWeight = 1f)
		{
			FScriptInterface fscriptInterface = new FScriptInterface(InBlendableObject, (InBlendableObject != null) ? InBlendableObject.InterfaceOffset() : 0);
			APostProcessVolume.__AddOrUpdateBlendable_Internal(base.NativePtr, fscriptInterface, InWeight);
		}

		// Token: 0x0600E8B3 RID: 59571
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddOrUpdateBlendable_Internal(IntPtr @this, in FScriptInterface InBlendableObject, float InWeight);

		// Token: 0x0600E8B4 RID: 59572 RVA: 0x00159BA3 File Offset: 0x00157DA3
		static APostProcessVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PostProcessVolume");
		}

		// Token: 0x0600E8B5 RID: 59573 RVA: 0x00159BB1 File Offset: 0x00157DB1
		protected APostProcessVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007E4A RID: 32330
		internal static int __InterfaceOffset_IInterface_PostProcessVolume;

		// Token: 0x04007E4B RID: 32331
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PostProcessVolume";

		// Token: 0x04007E4C RID: 32332
		private static IntPtr _ClassPtr;

		// Token: 0x04007E4D RID: 32333
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007E4E RID: 32334
		internal static int __PropertyOffset_Settings;

		// Token: 0x04007E4F RID: 32335
		[Nullable(2)]
		private FPostProcessSettings _Settings;

		// Token: 0x04007E50 RID: 32336
		internal static int __PropertyOffset_Priority;

		// Token: 0x04007E51 RID: 32337
		internal static int __PropertyOffset_BlendRadius;

		// Token: 0x04007E52 RID: 32338
		internal static int __PropertyOffset_BlendWeight;

		// Token: 0x04007E53 RID: 32339
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04007E54 RID: 32340
		internal static byte __PropertyMask_bEnabled;

		// Token: 0x04007E55 RID: 32341
		internal static int __PropertyOffset_bUnbound;

		// Token: 0x04007E56 RID: 32342
		internal static byte __PropertyMask_bUnbound;

		// Token: 0x04007E57 RID: 32343
		internal static int __PropertyOffset_bIsUISceneRendering;

		// Token: 0x04007E58 RID: 32344
		internal static byte __PropertyMask_bIsUISceneRendering;

		// Token: 0x04007E59 RID: 32345
		internal static int __PropertyOffset_bIsEffectVolume;

		// Token: 0x04007E5A RID: 32346
		internal static byte __PropertyMask_bIsEffectVolume;

		// Token: 0x04007E5B RID: 32347
		internal static int __PropertyOffset_CustomCullFlag;
	}
}
