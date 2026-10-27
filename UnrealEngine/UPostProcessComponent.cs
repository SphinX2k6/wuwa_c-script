using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001024 RID: 4132
	[UnrealObjectPath("/Script/Engine.PostProcessComponent")]
	[UnrealStructLayout(3200, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3200)]
	public class UPostProcessComponent : USceneComponent, IUnrealUObject, IUnrealObject, IInterface_PostProcessVolume, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0600E208 RID: 57864 RVA: 0x0014C2E2 File Offset: 0x0014A4E2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPostProcessComponent._ClassPtr;
		}

		// Token: 0x0600E209 RID: 57865 RVA: 0x0014C2EE File Offset: 0x0014A4EE
		int IInterface_PostProcessVolume.InterfaceOffset()
		{
			return UPostProcessComponent.__InterfaceOffset_IInterface_PostProcessVolume;
		}

		// Token: 0x0600E20A RID: 57866 RVA: 0x0014C2F8 File Offset: 0x0014A4F8
		public UPostProcessComponent() : this(BuiltinUtils.AllocNativeUObject(UPostProcessComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600E20B RID: 57867 RVA: 0x0014C320 File Offset: 0x0014A520
		[NullableContext(1)]
		public UPostProcessComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPostProcessComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003510 RID: 13584
		// (get) Token: 0x0600E20C RID: 57868 RVA: 0x0014C354 File Offset: 0x0014A554
		// (set) Token: 0x0600E20D RID: 57869 RVA: 0x0014C38D File Offset: 0x0014A58D
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
					result = (this._Settings = new FPostProcessSettings(base.NativePtr + (IntPtr)UPostProcessComponent.__PropertyOffset_Settings, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPostProcessSettings.StaticStruct(), base.NativePtr + (IntPtr)UPostProcessComponent.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003511 RID: 13585
		// (get) Token: 0x0600E20E RID: 57870 RVA: 0x0014C3AE File Offset: 0x0014A5AE
		// (set) Token: 0x0600E20F RID: 57871 RVA: 0x0014C3BE File Offset: 0x0014A5BE
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

		// Token: 0x17003512 RID: 13586
		// (get) Token: 0x0600E210 RID: 57872 RVA: 0x0014C3CF File Offset: 0x0014A5CF
		// (set) Token: 0x0600E211 RID: 57873 RVA: 0x0014C3DF File Offset: 0x0014A5DF
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

		// Token: 0x17003513 RID: 13587
		// (get) Token: 0x0600E212 RID: 57874 RVA: 0x0014C3F0 File Offset: 0x0014A5F0
		// (set) Token: 0x0600E213 RID: 57875 RVA: 0x0014C400 File Offset: 0x0014A600
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

		// Token: 0x17003514 RID: 13588
		// (get) Token: 0x0600E214 RID: 57876 RVA: 0x0014C411 File Offset: 0x0014A611
		// (set) Token: 0x0600E215 RID: 57877 RVA: 0x0014C42A File Offset: 0x0014A62A
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

		// Token: 0x17003515 RID: 13589
		// (get) Token: 0x0600E216 RID: 57878 RVA: 0x0014C45A File Offset: 0x0014A65A
		// (set) Token: 0x0600E217 RID: 57879 RVA: 0x0014C473 File Offset: 0x0014A673
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

		// Token: 0x17003516 RID: 13590
		// (get) Token: 0x0600E218 RID: 57880 RVA: 0x0014C4A3 File Offset: 0x0014A6A3
		// (set) Token: 0x0600E219 RID: 57881 RVA: 0x0014C4BC File Offset: 0x0014A6BC
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

		// Token: 0x17003517 RID: 13591
		// (get) Token: 0x0600E21A RID: 57882 RVA: 0x0014C4EC File Offset: 0x0014A6EC
		// (set) Token: 0x0600E21B RID: 57883 RVA: 0x0014C505 File Offset: 0x0014A705
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

		// Token: 0x17003518 RID: 13592
		// (get) Token: 0x0600E21C RID: 57884 RVA: 0x0014C535 File Offset: 0x0014A735
		// (set) Token: 0x0600E21D RID: 57885 RVA: 0x0014C545 File Offset: 0x0014A745
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

		// Token: 0x0600E21E RID: 57886 RVA: 0x0014C556 File Offset: 0x0014A756
		public void SetPriority(float InPriority)
		{
			UPostProcessComponent.__SetPriority_Internal(base.NativePtr, InPriority);
		}

		// Token: 0x0600E21F RID: 57887 RVA: 0x0014C564 File Offset: 0x0014A764
		[NullableContext(2)]
		public void AddOrUpdateBlendable(IBlendableInterface InBlendableObject, float InWeight = 1f)
		{
			FScriptInterface fscriptInterface = new FScriptInterface(InBlendableObject, (InBlendableObject != null) ? InBlendableObject.InterfaceOffset() : 0);
			UPostProcessComponent.__AddOrUpdateBlendable_Internal(base.NativePtr, fscriptInterface, InWeight);
		}

		// Token: 0x0600E220 RID: 57888
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPriority_Internal(IntPtr @this, float InPriority);

		// Token: 0x0600E221 RID: 57889
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddOrUpdateBlendable_Internal(IntPtr @this, in FScriptInterface InBlendableObject, float InWeight);

		// Token: 0x0600E222 RID: 57890 RVA: 0x0014C593 File Offset: 0x0014A793
		static UPostProcessComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PostProcessComponent");
		}

		// Token: 0x0600E223 RID: 57891 RVA: 0x0014C5A1 File Offset: 0x0014A7A1
		protected UPostProcessComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400794F RID: 31055
		internal static int __InterfaceOffset_IInterface_PostProcessVolume;

		// Token: 0x04007950 RID: 31056
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PostProcessComponent";

		// Token: 0x04007951 RID: 31057
		private static IntPtr _ClassPtr;

		// Token: 0x04007952 RID: 31058
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007953 RID: 31059
		internal static int __PropertyOffset_Settings;

		// Token: 0x04007954 RID: 31060
		[Nullable(2)]
		private FPostProcessSettings _Settings;

		// Token: 0x04007955 RID: 31061
		internal static int __PropertyOffset_Priority;

		// Token: 0x04007956 RID: 31062
		internal static int __PropertyOffset_BlendRadius;

		// Token: 0x04007957 RID: 31063
		internal static int __PropertyOffset_BlendWeight;

		// Token: 0x04007958 RID: 31064
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04007959 RID: 31065
		internal static byte __PropertyMask_bEnabled;

		// Token: 0x0400795A RID: 31066
		internal static int __PropertyOffset_bUnbound;

		// Token: 0x0400795B RID: 31067
		internal static byte __PropertyMask_bUnbound;

		// Token: 0x0400795C RID: 31068
		internal static int __PropertyOffset_bIsUISceneRendering;

		// Token: 0x0400795D RID: 31069
		internal static byte __PropertyMask_bIsUISceneRendering;

		// Token: 0x0400795E RID: 31070
		internal static int __PropertyOffset_bIsEffectVolume;

		// Token: 0x0400795F RID: 31071
		internal static byte __PropertyMask_bIsEffectVolume;

		// Token: 0x04007960 RID: 31072
		internal static int __PropertyOffset_CustomCullFlag;
	}
}
