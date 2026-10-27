using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000242 RID: 578
	[UnrealObjectPath("/Script/AkAudio.AkSpatialAudioSettings")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FAkSpatialAudioSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600223D RID: 8765 RVA: 0x00032D33 File Offset: 0x00030F33
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkSpatialAudioSettings._ScriptStructPtr != 0) ? FAkSpatialAudioSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkSpatialAudioSettings", ref FAkSpatialAudioSettings._ScriptStructPtr);
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x0600223E RID: 8766 RVA: 0x00032D57 File Offset: 0x00030F57
		// (set) Token: 0x0600223F RID: 8767 RVA: 0x00032D67 File Offset: 0x00030F67
		public unsafe uint MaxSoundPropagationDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSpatialAudioSettings.__PropertyOffset_MaxSoundPropagationDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSpatialAudioSettings.__PropertyOffset_MaxSoundPropagationDepth) = (int)value;
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06002240 RID: 8768 RVA: 0x00032D78 File Offset: 0x00030F78
		// (set) Token: 0x06002241 RID: 8769 RVA: 0x00032D88 File Offset: 0x00030F88
		public unsafe float MovementThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSpatialAudioSettings.__PropertyOffset_MovementThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSpatialAudioSettings.__PropertyOffset_MovementThreshold) = value;
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06002242 RID: 8770 RVA: 0x00032D99 File Offset: 0x00030F99
		// (set) Token: 0x06002243 RID: 8771 RVA: 0x00032DA9 File Offset: 0x00030FA9
		public unsafe uint NumberOfPrimaryRays
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSpatialAudioSettings.__PropertyOffset_NumberOfPrimaryRays);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSpatialAudioSettings.__PropertyOffset_NumberOfPrimaryRays) = (int)value;
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06002244 RID: 8772 RVA: 0x00032DBA File Offset: 0x00030FBA
		// (set) Token: 0x06002245 RID: 8773 RVA: 0x00032DCA File Offset: 0x00030FCA
		public unsafe uint ReflectionOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSpatialAudioSettings.__PropertyOffset_ReflectionOrder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSpatialAudioSettings.__PropertyOffset_ReflectionOrder) = (int)value;
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06002246 RID: 8774 RVA: 0x00032DDB File Offset: 0x00030FDB
		// (set) Token: 0x06002247 RID: 8775 RVA: 0x00032DEB File Offset: 0x00030FEB
		public unsafe uint DiffractionOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSpatialAudioSettings.__PropertyOffset_DiffractionOrder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSpatialAudioSettings.__PropertyOffset_DiffractionOrder) = (int)value;
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06002248 RID: 8776 RVA: 0x00032DFC File Offset: 0x00030FFC
		// (set) Token: 0x06002249 RID: 8777 RVA: 0x00032E0C File Offset: 0x0003100C
		public unsafe uint DiffractionOnReflectionsOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSpatialAudioSettings.__PropertyOffset_DiffractionOnReflectionsOrder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSpatialAudioSettings.__PropertyOffset_DiffractionOnReflectionsOrder) = (int)value;
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x0600224A RID: 8778 RVA: 0x00032E1D File Offset: 0x0003101D
		// (set) Token: 0x0600224B RID: 8779 RVA: 0x00032E2D File Offset: 0x0003102D
		public unsafe float MaximumPathLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSpatialAudioSettings.__PropertyOffset_MaximumPathLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSpatialAudioSettings.__PropertyOffset_MaximumPathLength) = value;
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x0600224C RID: 8780 RVA: 0x00032E3E File Offset: 0x0003103E
		// (set) Token: 0x0600224D RID: 8781 RVA: 0x00032E4E File Offset: 0x0003104E
		public unsafe float CPULimitPercentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSpatialAudioSettings.__PropertyOffset_CPULimitPercentage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSpatialAudioSettings.__PropertyOffset_CPULimitPercentage) = value;
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x0600224E RID: 8782 RVA: 0x00032E5F File Offset: 0x0003105F
		// (set) Token: 0x0600224F RID: 8783 RVA: 0x00032E6F File Offset: 0x0003106F
		public unsafe uint LoadBalancingSpread
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSpatialAudioSettings.__PropertyOffset_LoadBalancingSpread);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSpatialAudioSettings.__PropertyOffset_LoadBalancingSpread) = (int)value;
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06002250 RID: 8784 RVA: 0x00032E80 File Offset: 0x00031080
		// (set) Token: 0x06002251 RID: 8785 RVA: 0x00032E90 File Offset: 0x00031090
		public unsafe bool EnableGeometricDiffractionAndTransmission
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSpatialAudioSettings.__PropertyOffset_EnableGeometricDiffractionAndTransmission) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSpatialAudioSettings.__PropertyOffset_EnableGeometricDiffractionAndTransmission) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06002252 RID: 8786 RVA: 0x00032EA1 File Offset: 0x000310A1
		// (set) Token: 0x06002253 RID: 8787 RVA: 0x00032EB1 File Offset: 0x000310B1
		public unsafe bool CalcEmitterVirtualPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSpatialAudioSettings.__PropertyOffset_CalcEmitterVirtualPosition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSpatialAudioSettings.__PropertyOffset_CalcEmitterVirtualPosition) = (value ? 1 : 0);
			}
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x00032EC2 File Offset: 0x000310C2
		public FAkSpatialAudioSettings()
		{
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x00032ECC File Offset: 0x000310CC
		public FAkSpatialAudioSettings(uint MaxSoundPropagationDepth, float MovementThreshold, uint NumberOfPrimaryRays, uint ReflectionOrder, uint DiffractionOrder, uint DiffractionOnReflectionsOrder, float MaximumPathLength, float CPULimitPercentage, uint LoadBalancingSpread, bool EnableGeometricDiffractionAndTransmission, bool CalcEmitterVirtualPosition)
		{
			this.MaxSoundPropagationDepth = MaxSoundPropagationDepth;
			this.MovementThreshold = MovementThreshold;
			this.NumberOfPrimaryRays = NumberOfPrimaryRays;
			this.ReflectionOrder = ReflectionOrder;
			this.DiffractionOrder = DiffractionOrder;
			this.DiffractionOnReflectionsOrder = DiffractionOnReflectionsOrder;
			this.MaximumPathLength = MaximumPathLength;
			this.CPULimitPercentage = CPULimitPercentage;
			this.LoadBalancingSpread = LoadBalancingSpread;
			this.EnableGeometricDiffractionAndTransmission = EnableGeometricDiffractionAndTransmission;
			this.CalcEmitterVirtualPosition = CalcEmitterVirtualPosition;
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x00032F34 File Offset: 0x00031134
		protected override IntPtr GetUStructPtr()
		{
			return FAkSpatialAudioSettings.StaticStruct();
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x00032F40 File Offset: 0x00031140
		[NullableContext(2)]
		public FAkSpatialAudioSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x00032F4A File Offset: 0x0003114A
		public FAkSpatialAudioSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x00032F55 File Offset: 0x00031155
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkSpatialAudioSettings(Pointer, false, true);
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x00032F5F File Offset: 0x0003115F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkSpatialAudioSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04000BC5 RID: 3013
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.AkSpatialAudioSettings";

		// Token: 0x04000BC6 RID: 3014
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000BC7 RID: 3015
		internal static int __PropertyOffset_MaxSoundPropagationDepth;

		// Token: 0x04000BC8 RID: 3016
		internal static int __PropertyOffset_MovementThreshold;

		// Token: 0x04000BC9 RID: 3017
		internal static int __PropertyOffset_NumberOfPrimaryRays;

		// Token: 0x04000BCA RID: 3018
		internal static int __PropertyOffset_ReflectionOrder;

		// Token: 0x04000BCB RID: 3019
		internal static int __PropertyOffset_DiffractionOrder;

		// Token: 0x04000BCC RID: 3020
		internal static int __PropertyOffset_DiffractionOnReflectionsOrder;

		// Token: 0x04000BCD RID: 3021
		internal static int __PropertyOffset_MaximumPathLength;

		// Token: 0x04000BCE RID: 3022
		internal static int __PropertyOffset_CPULimitPercentage;

		// Token: 0x04000BCF RID: 3023
		internal static int __PropertyOffset_LoadBalancingSpread;

		// Token: 0x04000BD0 RID: 3024
		internal static int __PropertyOffset_EnableGeometricDiffractionAndTransmission;

		// Token: 0x04000BD1 RID: 3025
		internal static int __PropertyOffset_CalcEmitterVirtualPosition;
	}
}
