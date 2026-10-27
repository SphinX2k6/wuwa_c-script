using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BBF RID: 7103
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSmartLightActor")]
	[UnrealStructLayout(1216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1216)]
	public class AKuroSmartLightActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B3E2 RID: 111586 RVA: 0x002827B0 File Offset: 0x002809B0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroSmartLightActor._ClassPtr;
		}

		// Token: 0x0601B3E3 RID: 111587 RVA: 0x002827BC File Offset: 0x002809BC
		public AKuroSmartLightActor() : this(BuiltinUtils.AllocNativeUObject(AKuroSmartLightActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B3E4 RID: 111588 RVA: 0x002827E4 File Offset: 0x002809E4
		public AKuroSmartLightActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroSmartLightActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006D6F RID: 28015
		// (get) Token: 0x0601B3E5 RID: 111589 RVA: 0x00282817 File Offset: 0x00280A17
		// (set) Token: 0x0601B3E6 RID: 111590 RVA: 0x00282827 File Offset: 0x00280A27
		public unsafe EKuroSmartLightActorDetectType DetectType
		{
			get
			{
				return (EKuroSmartLightActorDetectType)(*(base.NativePtr + (IntPtr)AKuroSmartLightActor.__PropertyOffset_DetectType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSmartLightActor.__PropertyOffset_DetectType) = (byte)value;
			}
		}

		// Token: 0x17006D70 RID: 28016
		// (get) Token: 0x0601B3E7 RID: 111591 RVA: 0x00282838 File Offset: 0x00280A38
		// (set) Token: 0x0601B3E8 RID: 111592 RVA: 0x0028284C File Offset: 0x00280A4C
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

		// Token: 0x17006D71 RID: 28017
		// (get) Token: 0x0601B3E9 RID: 111593 RVA: 0x00282861 File Offset: 0x00280A61
		// (set) Token: 0x0601B3EA RID: 111594 RVA: 0x00282875 File Offset: 0x00280A75
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

		// Token: 0x17006D72 RID: 28018
		// (get) Token: 0x0601B3EB RID: 111595 RVA: 0x0028288A File Offset: 0x00280A8A
		// (set) Token: 0x0601B3EC RID: 111596 RVA: 0x0028289A File Offset: 0x00280A9A
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

		// Token: 0x17006D73 RID: 28019
		// (get) Token: 0x0601B3ED RID: 111597 RVA: 0x002828AB File Offset: 0x00280AAB
		// (set) Token: 0x0601B3EE RID: 111598 RVA: 0x002828BB File Offset: 0x00280ABB
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

		// Token: 0x17006D74 RID: 28020
		// (get) Token: 0x0601B3EF RID: 111599 RVA: 0x002828CC File Offset: 0x00280ACC
		// (set) Token: 0x0601B3F0 RID: 111600 RVA: 0x002828DC File Offset: 0x00280ADC
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

		// Token: 0x17006D75 RID: 28021
		// (get) Token: 0x0601B3F1 RID: 111601 RVA: 0x002828ED File Offset: 0x00280AED
		// (set) Token: 0x0601B3F2 RID: 111602 RVA: 0x002828FD File Offset: 0x00280AFD
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

		// Token: 0x17006D76 RID: 28022
		// (get) Token: 0x0601B3F3 RID: 111603 RVA: 0x0028290E File Offset: 0x00280B0E
		// (set) Token: 0x0601B3F4 RID: 111604 RVA: 0x0028291E File Offset: 0x00280B1E
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

		// Token: 0x17006D77 RID: 28023
		// (get) Token: 0x0601B3F5 RID: 111605 RVA: 0x0028292F File Offset: 0x00280B2F
		// (set) Token: 0x0601B3F6 RID: 111606 RVA: 0x0028293F File Offset: 0x00280B3F
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

		// Token: 0x17006D78 RID: 28024
		// (get) Token: 0x0601B3F7 RID: 111607 RVA: 0x00282950 File Offset: 0x00280B50
		// (set) Token: 0x0601B3F8 RID: 111608 RVA: 0x00282960 File Offset: 0x00280B60
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

		// Token: 0x17006D79 RID: 28025
		// (get) Token: 0x0601B3F9 RID: 111609 RVA: 0x00282971 File Offset: 0x00280B71
		// (set) Token: 0x0601B3FA RID: 111610 RVA: 0x00282981 File Offset: 0x00280B81
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

		// Token: 0x17006D7A RID: 28026
		// (get) Token: 0x0601B3FB RID: 111611 RVA: 0x00282994 File Offset: 0x00280B94
		// (set) Token: 0x0601B3FC RID: 111612 RVA: 0x002829CD File Offset: 0x00280BCD
		public TArray<FKuroSmartLightCustomParameterFloat> CustomParameterFloats
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroSmartLightCustomParameterFloat> result;
				if ((result = this._CustomParameterFloats) == null)
				{
					result = (this._CustomParameterFloats = new TArray<FKuroSmartLightCustomParameterFloat>(base.NativePtr + (IntPtr)AKuroSmartLightActor.__PropertyOffset_CustomParameterFloats, this));
				}
				return result;
			}
			set
			{
				this.CustomParameterFloats.CopyAssign(value);
			}
		}

		// Token: 0x17006D7B RID: 28027
		// (get) Token: 0x0601B3FD RID: 111613 RVA: 0x002829DC File Offset: 0x00280BDC
		// (set) Token: 0x0601B3FE RID: 111614 RVA: 0x00282A15 File Offset: 0x00280C15
		public TArray<FKuroSmartLightCustomParameterLinearColor> CustomParameterLinearColors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroSmartLightCustomParameterLinearColor> result;
				if ((result = this._CustomParameterLinearColors) == null)
				{
					result = (this._CustomParameterLinearColors = new TArray<FKuroSmartLightCustomParameterLinearColor>(base.NativePtr + (IntPtr)AKuroSmartLightActor.__PropertyOffset_CustomParameterLinearColors, this));
				}
				return result;
			}
			set
			{
				this.CustomParameterLinearColors.CopyAssign(value);
			}
		}

		// Token: 0x17006D7C RID: 28028
		// (get) Token: 0x0601B3FF RID: 111615 RVA: 0x00282A23 File Offset: 0x00280C23
		// (set) Token: 0x0601B400 RID: 111616 RVA: 0x00282A37 File Offset: 0x00280C37
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

		// Token: 0x0601B401 RID: 111617 RVA: 0x00282A4C File Offset: 0x00280C4C
		public void TriggerLightOnEditorOnly()
		{
			AKuroSmartLightActor.__TriggerLightOnEditorOnly_Internal(base.NativePtr);
		}

		// Token: 0x0601B402 RID: 111618 RVA: 0x00282A59 File Offset: 0x00280C59
		public void TriggerLightOffEditorOnly()
		{
			AKuroSmartLightActor.__TriggerLightOffEditorOnly_Internal(base.NativePtr);
		}

		// Token: 0x0601B403 RID: 111619 RVA: 0x00282A66 File Offset: 0x00280C66
		public virtual void OnUpdateLightOn(float Time)
		{
			AKuroSmartLightActor.__OnUpdateLightOn_Internal(base.NativePtr, Time);
		}

		// Token: 0x0601B404 RID: 111620 RVA: 0x00282A74 File Offset: 0x00280C74
		protected virtual void OnUpdateLightOn_Implementation(float Time)
		{
			AKuroSmartLightActor.__OnUpdateLightOn_Implementation_Internal(base.NativePtr, Time);
		}

		// Token: 0x0601B405 RID: 111621 RVA: 0x00282A82 File Offset: 0x00280C82
		public virtual void OnUpdateLightOff(float Time)
		{
			AKuroSmartLightActor.__OnUpdateLightOff_Internal(base.NativePtr, Time);
		}

		// Token: 0x0601B406 RID: 111622 RVA: 0x00282A90 File Offset: 0x00280C90
		protected virtual void OnUpdateLightOff_Implementation(float Time)
		{
			AKuroSmartLightActor.__OnUpdateLightOff_Implementation_Internal(base.NativePtr, Time);
		}

		// Token: 0x0601B407 RID: 111623 RVA: 0x00282A9E File Offset: 0x00280C9E
		[NullableContext(2)]
		public void ApplyLightParametersToStaticMeshComponent(UStaticMeshComponent Component)
		{
			AKuroSmartLightActor.__ApplyLightParametersToStaticMeshComponent_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601B408 RID: 111624
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TriggerLightOnEditorOnly_Internal(IntPtr @this);

		// Token: 0x0601B409 RID: 111625
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TriggerLightOffEditorOnly_Internal(IntPtr @this);

		// Token: 0x0601B40A RID: 111626
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUpdateLightOn_Internal(IntPtr @this, float Time);

		// Token: 0x0601B40B RID: 111627
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUpdateLightOn_Implementation_Internal(IntPtr @this, float Time);

		// Token: 0x0601B40C RID: 111628
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUpdateLightOff_Internal(IntPtr @this, float Time);

		// Token: 0x0601B40D RID: 111629
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUpdateLightOff_Implementation_Internal(IntPtr @this, float Time);

		// Token: 0x0601B40E RID: 111630
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyLightParametersToStaticMeshComponent_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x0601B40F RID: 111631 RVA: 0x00282ABB File Offset: 0x00280CBB
		static AKuroSmartLightActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSmartLightActor");
		}

		// Token: 0x0601B410 RID: 111632 RVA: 0x00282AC9 File Offset: 0x00280CC9
		protected AKuroSmartLightActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EAD0 RID: 60112
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSmartLightActor";

		// Token: 0x0400EAD1 RID: 60113
		private static IntPtr _ClassPtr;

		// Token: 0x0400EAD2 RID: 60114
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EAD3 RID: 60115
		internal static int __PropertyOffset_DetectType;

		// Token: 0x0400EAD4 RID: 60116
		internal static int __PropertyOffset_DetectCenter;

		// Token: 0x0400EAD5 RID: 60117
		internal static int __PropertyOffset_DetectExtent;

		// Token: 0x0400EAD6 RID: 60118
		internal static int __PropertyOffset_DetectRadius;

		// Token: 0x0400EAD7 RID: 60119
		internal static int __PropertyOffset_Enabled;

		// Token: 0x0400EAD8 RID: 60120
		internal static int __PropertyOffset_LightIntensity;

		// Token: 0x0400EAD9 RID: 60121
		internal static int __PropertyOffset_LightUpTime;

		// Token: 0x0400EADA RID: 60122
		internal static int __PropertyOffset_LightUpDelay;

		// Token: 0x0400EADB RID: 60123
		internal static int __PropertyOffset_LightOffTime;

		// Token: 0x0400EADC RID: 60124
		internal static int __PropertyOffset_LightOffDelay;

		// Token: 0x0400EADD RID: 60125
		internal static int __PropertyOffset_LightUpdateExtraTime;

		// Token: 0x0400EADE RID: 60126
		internal static int __PropertyOffset_CustomParameterFloats;

		// Token: 0x0400EADF RID: 60127
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroSmartLightCustomParameterFloat> _CustomParameterFloats;

		// Token: 0x0400EAE0 RID: 60128
		internal static int __PropertyOffset_CustomParameterLinearColors;

		// Token: 0x0400EAE1 RID: 60129
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroSmartLightCustomParameterLinearColor> _CustomParameterLinearColors;

		// Token: 0x0400EAE2 RID: 60130
		internal static int __PropertyOffset_SceneRoot;

		// Token: 0x0200317A RID: 12666
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnUpdateLightOn_FunctionParams
		{
			// Token: 0x04016FAF RID: 94127
			[FieldOffset(0)]
			public float Time;
		}

		// Token: 0x0200317B RID: 12667
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnUpdateLightOff_FunctionParams
		{
			// Token: 0x04016FB0 RID: 94128
			[FieldOffset(0)]
			public float Time;
		}
	}
}
