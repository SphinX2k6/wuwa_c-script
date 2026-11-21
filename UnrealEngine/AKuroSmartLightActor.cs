using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004E4 RID: 1252
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSmartLightActor")]
	[UnrealStructLayout(1216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1216)]
	public class AKuroSmartLightActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007625 RID: 30245 RVA: 0x000AC906 File Offset: 0x000AAB06
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroSmartLightActor._ClassPtr;
		}

		// Token: 0x06007626 RID: 30246 RVA: 0x000AC914 File Offset: 0x000AAB14
		public AKuroSmartLightActor() : this(BuiltinUtils.AllocNativeUObject(AKuroSmartLightActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007627 RID: 30247 RVA: 0x000AC93C File Offset: 0x000AAB3C
		[NullableContext(1)]
		public AKuroSmartLightActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroSmartLightActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170016C1 RID: 5825
		// (get) Token: 0x06007628 RID: 30248 RVA: 0x000AC96F File Offset: 0x000AAB6F
		// (set) Token: 0x06007629 RID: 30249 RVA: 0x000AC983 File Offset: 0x000AAB83
		public unsafe FVector DetectCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSmartLightActor.__PropertyOffset_DetectCenter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSmartLightActor.__PropertyOffset_DetectCenter) = value;
			}
		}

		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x0600762A RID: 30250 RVA: 0x000AC998 File Offset: 0x000AAB98
		// (set) Token: 0x0600762B RID: 30251 RVA: 0x000AC9AC File Offset: 0x000AABAC
		public unsafe FVector DetectExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSmartLightActor.__PropertyOffset_DetectExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSmartLightActor.__PropertyOffset_DetectExtent) = value;
			}
		}

		// Token: 0x170016C3 RID: 5827
		// (get) Token: 0x0600762C RID: 30252 RVA: 0x000AC9C1 File Offset: 0x000AABC1
		// (set) Token: 0x0600762D RID: 30253 RVA: 0x000AC9D1 File Offset: 0x000AABD1
		public unsafe float DetectRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSmartLightActor.__PropertyOffset_DetectRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSmartLightActor.__PropertyOffset_DetectRadius) = value;
			}
		}

		// Token: 0x170016C4 RID: 5828
		// (get) Token: 0x0600762E RID: 30254 RVA: 0x000AC9E2 File Offset: 0x000AABE2
		// (set) Token: 0x0600762F RID: 30255 RVA: 0x000AC9F2 File Offset: 0x000AABF2
		public unsafe bool Enabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSmartLightActor.__PropertyOffset_Enabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSmartLightActor.__PropertyOffset_Enabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x170016C5 RID: 5829
		// (get) Token: 0x06007630 RID: 30256 RVA: 0x000ACA03 File Offset: 0x000AAC03
		// (set) Token: 0x06007631 RID: 30257 RVA: 0x000ACA13 File Offset: 0x000AAC13
		public unsafe float LightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSmartLightActor.__PropertyOffset_LightIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSmartLightActor.__PropertyOffset_LightIntensity) = value;
			}
		}

		// Token: 0x170016C6 RID: 5830
		// (get) Token: 0x06007632 RID: 30258 RVA: 0x000ACA24 File Offset: 0x000AAC24
		// (set) Token: 0x06007633 RID: 30259 RVA: 0x000ACA34 File Offset: 0x000AAC34
		public unsafe float LightUpTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSmartLightActor.__PropertyOffset_LightUpTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSmartLightActor.__PropertyOffset_LightUpTime) = value;
			}
		}

		// Token: 0x170016C7 RID: 5831
		// (get) Token: 0x06007634 RID: 30260 RVA: 0x000ACA45 File Offset: 0x000AAC45
		// (set) Token: 0x06007635 RID: 30261 RVA: 0x000ACA55 File Offset: 0x000AAC55
		public unsafe float LightUpDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSmartLightActor.__PropertyOffset_LightUpDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSmartLightActor.__PropertyOffset_LightUpDelay) = value;
			}
		}

		// Token: 0x170016C8 RID: 5832
		// (get) Token: 0x06007636 RID: 30262 RVA: 0x000ACA66 File Offset: 0x000AAC66
		// (set) Token: 0x06007637 RID: 30263 RVA: 0x000ACA76 File Offset: 0x000AAC76
		public unsafe float LightOffTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSmartLightActor.__PropertyOffset_LightOffTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSmartLightActor.__PropertyOffset_LightOffTime) = value;
			}
		}

		// Token: 0x170016C9 RID: 5833
		// (get) Token: 0x06007638 RID: 30264 RVA: 0x000ACA87 File Offset: 0x000AAC87
		// (set) Token: 0x06007639 RID: 30265 RVA: 0x000ACA97 File Offset: 0x000AAC97
		public unsafe float LightOffDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSmartLightActor.__PropertyOffset_LightOffDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSmartLightActor.__PropertyOffset_LightOffDelay) = value;
			}
		}

		// Token: 0x170016CA RID: 5834
		// (get) Token: 0x0600763A RID: 30266 RVA: 0x000ACAA8 File Offset: 0x000AACA8
		// (set) Token: 0x0600763B RID: 30267 RVA: 0x000ACAB8 File Offset: 0x000AACB8
		public unsafe float LightUpdateExtraTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSmartLightActor.__PropertyOffset_LightUpdateExtraTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSmartLightActor.__PropertyOffset_LightUpdateExtraTime) = value;
			}
		}

		// Token: 0x170016CB RID: 5835
		// (get) Token: 0x0600763C RID: 30268 RVA: 0x000ACAC9 File Offset: 0x000AACC9
		// (set) Token: 0x0600763D RID: 30269 RVA: 0x000ACADD File Offset: 0x000AACDD
		[Nullable(2)]
		public unsafe USceneComponent SceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSmartLightActor.__PropertyOffset_SceneRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSmartLightActor.__PropertyOffset_SceneRoot, value);
			}
		}

		// Token: 0x0600763E RID: 30270 RVA: 0x000ACAF2 File Offset: 0x000AACF2
		public void TriggerLightOnEditorOnly()
		{
			AKuroSmartLightActor.__TriggerLightOnEditorOnly_Internal(base.NativePtr);
		}

		// Token: 0x0600763F RID: 30271 RVA: 0x000ACAFF File Offset: 0x000AACFF
		public void TriggerLightOffEditorOnly()
		{
			AKuroSmartLightActor.__TriggerLightOffEditorOnly_Internal(base.NativePtr);
		}

		// Token: 0x06007640 RID: 30272 RVA: 0x000ACB0C File Offset: 0x000AAD0C
		public virtual void OnUpdateLightOn(float Time)
		{
			AKuroSmartLightActor.__OnUpdateLightOn_Internal(base.NativePtr, Time);
		}

		// Token: 0x06007641 RID: 30273 RVA: 0x000ACB1A File Offset: 0x000AAD1A
		protected virtual void OnUpdateLightOn_Implementation(float Time)
		{
			AKuroSmartLightActor.__OnUpdateLightOn_Implementation_Internal(base.NativePtr, Time);
		}

		// Token: 0x06007642 RID: 30274 RVA: 0x000ACB28 File Offset: 0x000AAD28
		public virtual void OnUpdateLightOff(float Time)
		{
			AKuroSmartLightActor.__OnUpdateLightOff_Internal(base.NativePtr, Time);
		}

		// Token: 0x06007643 RID: 30275 RVA: 0x000ACB36 File Offset: 0x000AAD36
		protected virtual void OnUpdateLightOff_Implementation(float Time)
		{
			AKuroSmartLightActor.__OnUpdateLightOff_Implementation_Internal(base.NativePtr, Time);
		}

		// Token: 0x06007644 RID: 30276 RVA: 0x000ACB44 File Offset: 0x000AAD44
		[NullableContext(2)]
		public void ApplyLightParametersToStaticMeshComponent(UStaticMeshComponent Component)
		{
			AKuroSmartLightActor.__ApplyLightParametersToStaticMeshComponent_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007645 RID: 30277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TriggerLightOnEditorOnly_Internal(IntPtr @this);

		// Token: 0x06007646 RID: 30278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TriggerLightOffEditorOnly_Internal(IntPtr @this);

		// Token: 0x06007647 RID: 30279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUpdateLightOn_Internal(IntPtr @this, float Time);

		// Token: 0x06007648 RID: 30280
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUpdateLightOn_Implementation_Internal(IntPtr @this, float Time);

		// Token: 0x06007649 RID: 30281
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUpdateLightOff_Internal(IntPtr @this, float Time);

		// Token: 0x0600764A RID: 30282
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUpdateLightOff_Implementation_Internal(IntPtr @this, float Time);

		// Token: 0x0600764B RID: 30283
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyLightParametersToStaticMeshComponent_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x0600764C RID: 30284 RVA: 0x000ACB61 File Offset: 0x000AAD61
		static AKuroSmartLightActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSmartLightActor");
		}

		// Token: 0x0600764D RID: 30285 RVA: 0x000ACB6F File Offset: 0x000AAD6F
		protected AKuroSmartLightActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040031CD RID: 12749
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSmartLightActor";

		// Token: 0x040031CE RID: 12750
		private static IntPtr _ClassPtr;

		// Token: 0x040031CF RID: 12751
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040031D0 RID: 12752
		internal static int __PropertyOffset_DetectCenter;

		// Token: 0x040031D1 RID: 12753
		internal static int __PropertyOffset_DetectExtent;

		// Token: 0x040031D2 RID: 12754
		internal static int __PropertyOffset_DetectRadius;

		// Token: 0x040031D3 RID: 12755
		internal static int __PropertyOffset_Enabled;

		// Token: 0x040031D4 RID: 12756
		internal static int __PropertyOffset_LightIntensity;

		// Token: 0x040031D5 RID: 12757
		internal static int __PropertyOffset_LightUpTime;

		// Token: 0x040031D6 RID: 12758
		internal static int __PropertyOffset_LightUpDelay;

		// Token: 0x040031D7 RID: 12759
		internal static int __PropertyOffset_LightOffTime;

		// Token: 0x040031D8 RID: 12760
		internal static int __PropertyOffset_LightOffDelay;

		// Token: 0x040031D9 RID: 12761
		internal static int __PropertyOffset_LightUpdateExtraTime;

		// Token: 0x040031DA RID: 12762
		internal static int __PropertyOffset_SceneRoot;

		// Token: 0x02000C20 RID: 3104
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnUpdateLightOn_FunctionParams
		{
			// Token: 0x04005E68 RID: 24168
			[FieldOffset(0)]
			public float Time;
		}

		// Token: 0x02000C21 RID: 3105
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnUpdateLightOff_FunctionParams
		{
			// Token: 0x04005E69 RID: 24169
			[FieldOffset(0)]
			public float Time;
		}
	}
}
