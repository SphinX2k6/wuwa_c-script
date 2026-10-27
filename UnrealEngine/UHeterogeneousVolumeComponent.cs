using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C1C RID: 3100
	[UnrealObjectPath("/Script/Engine.HeterogeneousVolumeComponent")]
	[UnrealStructLayout(1712, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1712)]
	public class UHeterogeneousVolumeComponent : UMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009C93 RID: 40083 RVA: 0x000DEA4F File Offset: 0x000DCC4F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHeterogeneousVolumeComponent._ClassPtr;
		}

		// Token: 0x06009C94 RID: 40084 RVA: 0x000DEA5C File Offset: 0x000DCC5C
		public UHeterogeneousVolumeComponent() : this(BuiltinUtils.AllocNativeUObject(UHeterogeneousVolumeComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009C95 RID: 40085 RVA: 0x000DEA84 File Offset: 0x000DCC84
		[NullableContext(1)]
		public UHeterogeneousVolumeComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHeterogeneousVolumeComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002554 RID: 9556
		// (get) Token: 0x06009C96 RID: 40086 RVA: 0x000DEAB7 File Offset: 0x000DCCB7
		// (set) Token: 0x06009C97 RID: 40087 RVA: 0x000DEACB File Offset: 0x000DCCCB
		public unsafe FIntVector VolumeResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_VolumeResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_VolumeResolution) = value;
			}
		}

		// Token: 0x17002555 RID: 9557
		// (get) Token: 0x06009C98 RID: 40088 RVA: 0x000DEAE0 File Offset: 0x000DCCE0
		// (set) Token: 0x06009C99 RID: 40089 RVA: 0x000DEAF0 File Offset: 0x000DCCF0
		public unsafe float Frame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_Frame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_Frame) = value;
			}
		}

		// Token: 0x17002556 RID: 9558
		// (get) Token: 0x06009C9A RID: 40090 RVA: 0x000DEB01 File Offset: 0x000DCD01
		// (set) Token: 0x06009C9B RID: 40091 RVA: 0x000DEB11 File Offset: 0x000DCD11
		public unsafe float FrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_FrameRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_FrameRate) = value;
			}
		}

		// Token: 0x17002557 RID: 9559
		// (get) Token: 0x06009C9C RID: 40092 RVA: 0x000DEB22 File Offset: 0x000DCD22
		// (set) Token: 0x06009C9D RID: 40093 RVA: 0x000DEB32 File Offset: 0x000DCD32
		public unsafe float StartFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_StartFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_StartFrame) = value;
			}
		}

		// Token: 0x17002558 RID: 9560
		// (get) Token: 0x06009C9E RID: 40094 RVA: 0x000DEB43 File Offset: 0x000DCD43
		// (set) Token: 0x06009C9F RID: 40095 RVA: 0x000DEB53 File Offset: 0x000DCD53
		public unsafe float EndFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_EndFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_EndFrame) = value;
			}
		}

		// Token: 0x17002559 RID: 9561
		// (get) Token: 0x06009CA0 RID: 40096 RVA: 0x000DEB64 File Offset: 0x000DCD64
		// (set) Token: 0x06009CA1 RID: 40097 RVA: 0x000DEB7D File Offset: 0x000DCD7D
		public unsafe bool bPlaying
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_bPlaying) & UHeterogeneousVolumeComponent.__PropertyMask_bPlaying) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_bPlaying) = ((*(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_bPlaying) & ~UHeterogeneousVolumeComponent.__PropertyMask_bPlaying) | (value ? UHeterogeneousVolumeComponent.__PropertyMask_bPlaying : 0));
			}
		}

		// Token: 0x1700255A RID: 9562
		// (get) Token: 0x06009CA2 RID: 40098 RVA: 0x000DEBAD File Offset: 0x000DCDAD
		// (set) Token: 0x06009CA3 RID: 40099 RVA: 0x000DEBC6 File Offset: 0x000DCDC6
		public unsafe bool bLooping
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_bLooping) & UHeterogeneousVolumeComponent.__PropertyMask_bLooping) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_bLooping) = ((*(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_bLooping) & ~UHeterogeneousVolumeComponent.__PropertyMask_bLooping) | (value ? UHeterogeneousVolumeComponent.__PropertyMask_bLooping : 0));
			}
		}

		// Token: 0x1700255B RID: 9563
		// (get) Token: 0x06009CA4 RID: 40100 RVA: 0x000DEBF6 File Offset: 0x000DCDF6
		// (set) Token: 0x06009CA5 RID: 40101 RVA: 0x000DEC06 File Offset: 0x000DCE06
		public unsafe uint MipLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_MipLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_MipLevel) = (int)value;
			}
		}

		// Token: 0x1700255C RID: 9564
		// (get) Token: 0x06009CA6 RID: 40102 RVA: 0x000DEC17 File Offset: 0x000DCE17
		// (set) Token: 0x06009CA7 RID: 40103 RVA: 0x000DEC30 File Offset: 0x000DCE30
		public unsafe bool bIssueBlockingRequests
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_bIssueBlockingRequests) & UHeterogeneousVolumeComponent.__PropertyMask_bIssueBlockingRequests) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_bIssueBlockingRequests) = ((*(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_bIssueBlockingRequests) & ~UHeterogeneousVolumeComponent.__PropertyMask_bIssueBlockingRequests) | (value ? UHeterogeneousVolumeComponent.__PropertyMask_bIssueBlockingRequests : 0));
			}
		}

		// Token: 0x1700255D RID: 9565
		// (get) Token: 0x06009CA8 RID: 40104 RVA: 0x000DEC60 File Offset: 0x000DCE60
		// (set) Token: 0x06009CA9 RID: 40105 RVA: 0x000DEC70 File Offset: 0x000DCE70
		public unsafe float StepFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_StepFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_StepFactor) = value;
			}
		}

		// Token: 0x1700255E RID: 9566
		// (get) Token: 0x06009CAA RID: 40106 RVA: 0x000DEC81 File Offset: 0x000DCE81
		// (set) Token: 0x06009CAB RID: 40107 RVA: 0x000DEC91 File Offset: 0x000DCE91
		public unsafe float ShadowStepFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_ShadowStepFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_ShadowStepFactor) = value;
			}
		}

		// Token: 0x1700255F RID: 9567
		// (get) Token: 0x06009CAC RID: 40108 RVA: 0x000DECA2 File Offset: 0x000DCEA2
		// (set) Token: 0x06009CAD RID: 40109 RVA: 0x000DECB2 File Offset: 0x000DCEB2
		public unsafe float ShadowBiasFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_ShadowBiasFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_ShadowBiasFactor) = value;
			}
		}

		// Token: 0x17002560 RID: 9568
		// (get) Token: 0x06009CAE RID: 40110 RVA: 0x000DECC3 File Offset: 0x000DCEC3
		// (set) Token: 0x06009CAF RID: 40111 RVA: 0x000DECD3 File Offset: 0x000DCED3
		public unsafe float LightingDownsampleFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_LightingDownsampleFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_LightingDownsampleFactor) = value;
			}
		}

		// Token: 0x17002561 RID: 9569
		// (get) Token: 0x06009CB0 RID: 40112 RVA: 0x000DECE4 File Offset: 0x000DCEE4
		// (set) Token: 0x06009CB1 RID: 40113 RVA: 0x000DECF4 File Offset: 0x000DCEF4
		public unsafe float MaxTraceDistanceFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_MaxTraceDistanceFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_MaxTraceDistanceFactor) = value;
			}
		}

		// Token: 0x17002562 RID: 9570
		// (get) Token: 0x06009CB2 RID: 40114 RVA: 0x000DED05 File Offset: 0x000DCF05
		// (set) Token: 0x06009CB3 RID: 40115 RVA: 0x000DED15 File Offset: 0x000DCF15
		public unsafe float MaxStepCountFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_MaxStepCountFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_MaxStepCountFactor) = value;
			}
		}

		// Token: 0x17002563 RID: 9571
		// (get) Token: 0x06009CB4 RID: 40116 RVA: 0x000DED26 File Offset: 0x000DCF26
		// (set) Token: 0x06009CB5 RID: 40117 RVA: 0x000DED3F File Offset: 0x000DCF3F
		public unsafe bool bReceivePointLights
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_bReceivePointLights) & UHeterogeneousVolumeComponent.__PropertyMask_bReceivePointLights) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_bReceivePointLights) = ((*(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_bReceivePointLights) & ~UHeterogeneousVolumeComponent.__PropertyMask_bReceivePointLights) | (value ? UHeterogeneousVolumeComponent.__PropertyMask_bReceivePointLights : 0));
			}
		}

		// Token: 0x17002564 RID: 9572
		// (get) Token: 0x06009CB6 RID: 40118 RVA: 0x000DED6F File Offset: 0x000DCF6F
		// (set) Token: 0x06009CB7 RID: 40119 RVA: 0x000DED88 File Offset: 0x000DCF88
		public unsafe bool bReceiveMainLight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_bReceiveMainLight) & UHeterogeneousVolumeComponent.__PropertyMask_bReceiveMainLight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_bReceiveMainLight) = ((*(base.NativePtr + (IntPtr)UHeterogeneousVolumeComponent.__PropertyOffset_bReceiveMainLight) & ~UHeterogeneousVolumeComponent.__PropertyMask_bReceiveMainLight) | (value ? UHeterogeneousVolumeComponent.__PropertyMask_bReceiveMainLight : 0));
			}
		}

		// Token: 0x17002565 RID: 9573
		// (get) Token: 0x06009CB8 RID: 40120 RVA: 0x000DEDB8 File Offset: 0x000DCFB8
		// (set) Token: 0x06009CB9 RID: 40121 RVA: 0x000DEDCC File Offset: 0x000DCFCC
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic MaterialInstanceDynamic
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + UHeterogeneousVolumeComponent.__PropertyOffset_MaterialInstanceDynamic);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHeterogeneousVolumeComponent.__PropertyOffset_MaterialInstanceDynamic, value);
			}
		}

		// Token: 0x06009CBA RID: 40122 RVA: 0x000DEDE1 File Offset: 0x000DCFE1
		public void SetStartFrame(float NewValue)
		{
			UHeterogeneousVolumeComponent.__SetStartFrame_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06009CBB RID: 40123 RVA: 0x000DEDEF File Offset: 0x000DCFEF
		public void SetReceivePointLights(bool NewValue)
		{
			UHeterogeneousVolumeComponent.__SetReceivePointLights_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06009CBC RID: 40124 RVA: 0x000DEDFD File Offset: 0x000DCFFD
		public void SetReceiveMainLight(bool NewValue)
		{
			UHeterogeneousVolumeComponent.__SetReceiveMainLight_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06009CBD RID: 40125 RVA: 0x000DEE0B File Offset: 0x000DD00B
		public void SetPlaying(bool NewValue)
		{
			UHeterogeneousVolumeComponent.__SetPlaying_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06009CBE RID: 40126 RVA: 0x000DEE19 File Offset: 0x000DD019
		public void SetMaxTraceDistanceFactor(float NewValue)
		{
			UHeterogeneousVolumeComponent.__SetMaxTraceDistanceFactor_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06009CBF RID: 40127 RVA: 0x000DEE27 File Offset: 0x000DD027
		public void SetMaxStepCountFactor(float NewValue)
		{
			UHeterogeneousVolumeComponent.__SetMaxStepCountFactor_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06009CC0 RID: 40128 RVA: 0x000DEE35 File Offset: 0x000DD035
		public void SetLooping(bool NewValue)
		{
			UHeterogeneousVolumeComponent.__SetLooping_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06009CC1 RID: 40129 RVA: 0x000DEE43 File Offset: 0x000DD043
		public void SetFrameRate(float NewValue)
		{
			UHeterogeneousVolumeComponent.__SetFrameRate_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06009CC2 RID: 40130 RVA: 0x000DEE51 File Offset: 0x000DD051
		public void SetFrame(float NewValue)
		{
			UHeterogeneousVolumeComponent.__SetFrame_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06009CC3 RID: 40131 RVA: 0x000DEE5F File Offset: 0x000DD05F
		public void SetEndFrame(float NewValue)
		{
			UHeterogeneousVolumeComponent.__SetEndFrame_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06009CC4 RID: 40132 RVA: 0x000DEE6D File Offset: 0x000DD06D
		public void Play()
		{
			UHeterogeneousVolumeComponent.__Play_Internal(base.NativePtr);
		}

		// Token: 0x06009CC5 RID: 40133
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartFrame_Internal(IntPtr @this, float NewValue);

		// Token: 0x06009CC6 RID: 40134
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetReceivePointLights_Internal(IntPtr @this, bool NewValue);

		// Token: 0x06009CC7 RID: 40135
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetReceiveMainLight_Internal(IntPtr @this, bool NewValue);

		// Token: 0x06009CC8 RID: 40136
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlaying_Internal(IntPtr @this, bool NewValue);

		// Token: 0x06009CC9 RID: 40137
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxTraceDistanceFactor_Internal(IntPtr @this, float NewValue);

		// Token: 0x06009CCA RID: 40138
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxStepCountFactor_Internal(IntPtr @this, float NewValue);

		// Token: 0x06009CCB RID: 40139
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLooping_Internal(IntPtr @this, bool NewValue);

		// Token: 0x06009CCC RID: 40140
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFrameRate_Internal(IntPtr @this, float NewValue);

		// Token: 0x06009CCD RID: 40141
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFrame_Internal(IntPtr @this, float NewValue);

		// Token: 0x06009CCE RID: 40142
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEndFrame_Internal(IntPtr @this, float NewValue);

		// Token: 0x06009CCF RID: 40143
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Play_Internal(IntPtr @this);

		// Token: 0x06009CD0 RID: 40144 RVA: 0x000DEE7A File Offset: 0x000DD07A
		static UHeterogeneousVolumeComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.HeterogeneousVolumeComponent");
		}

		// Token: 0x06009CD1 RID: 40145 RVA: 0x000DEE88 File Offset: 0x000DD088
		protected UHeterogeneousVolumeComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005668 RID: 22120
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.HeterogeneousVolumeComponent";

		// Token: 0x04005669 RID: 22121
		private static IntPtr _ClassPtr;

		// Token: 0x0400566A RID: 22122
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400566B RID: 22123
		internal static int __PropertyOffset_VolumeResolution;

		// Token: 0x0400566C RID: 22124
		internal static int __PropertyOffset_Frame;

		// Token: 0x0400566D RID: 22125
		internal static int __PropertyOffset_FrameRate;

		// Token: 0x0400566E RID: 22126
		internal static int __PropertyOffset_StartFrame;

		// Token: 0x0400566F RID: 22127
		internal static int __PropertyOffset_EndFrame;

		// Token: 0x04005670 RID: 22128
		internal static int __PropertyOffset_bPlaying;

		// Token: 0x04005671 RID: 22129
		internal static byte __PropertyMask_bPlaying;

		// Token: 0x04005672 RID: 22130
		internal static int __PropertyOffset_bLooping;

		// Token: 0x04005673 RID: 22131
		internal static byte __PropertyMask_bLooping;

		// Token: 0x04005674 RID: 22132
		internal static int __PropertyOffset_MipLevel;

		// Token: 0x04005675 RID: 22133
		internal static int __PropertyOffset_bIssueBlockingRequests;

		// Token: 0x04005676 RID: 22134
		internal static byte __PropertyMask_bIssueBlockingRequests;

		// Token: 0x04005677 RID: 22135
		internal static int __PropertyOffset_StepFactor;

		// Token: 0x04005678 RID: 22136
		internal static int __PropertyOffset_ShadowStepFactor;

		// Token: 0x04005679 RID: 22137
		internal static int __PropertyOffset_ShadowBiasFactor;

		// Token: 0x0400567A RID: 22138
		internal static int __PropertyOffset_LightingDownsampleFactor;

		// Token: 0x0400567B RID: 22139
		internal static int __PropertyOffset_MaxTraceDistanceFactor;

		// Token: 0x0400567C RID: 22140
		internal static int __PropertyOffset_MaxStepCountFactor;

		// Token: 0x0400567D RID: 22141
		internal static int __PropertyOffset_bReceivePointLights;

		// Token: 0x0400567E RID: 22142
		internal static byte __PropertyMask_bReceivePointLights;

		// Token: 0x0400567F RID: 22143
		internal static int __PropertyOffset_bReceiveMainLight;

		// Token: 0x04005680 RID: 22144
		internal static byte __PropertyMask_bReceiveMainLight;

		// Token: 0x04005681 RID: 22145
		internal static int __PropertyOffset_MaterialInstanceDynamic;
	}
}
