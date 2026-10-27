using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F4A RID: 3914
	[UnrealObjectPath("/Script/Engine.ParticleModule")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UParticleModule : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D332 RID: 54066 RVA: 0x00135A3C File Offset: 0x00133C3C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModule._ClassPtr;
		}

		// Token: 0x1700315D RID: 12637
		// (get) Token: 0x0600D333 RID: 54067 RVA: 0x00135A48 File Offset: 0x00133C48
		// (set) Token: 0x0600D334 RID: 54068 RVA: 0x00135A61 File Offset: 0x00133C61
		public unsafe bool bSpawnModule
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bSpawnModule) & UParticleModule.__PropertyMask_bSpawnModule) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bSpawnModule) = ((*(base.NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bSpawnModule) & ~UParticleModule.__PropertyMask_bSpawnModule) | (value ? UParticleModule.__PropertyMask_bSpawnModule : 0));
			}
		}

		// Token: 0x1700315E RID: 12638
		// (get) Token: 0x0600D335 RID: 54069 RVA: 0x00135A91 File Offset: 0x00133C91
		// (set) Token: 0x0600D336 RID: 54070 RVA: 0x00135AAA File Offset: 0x00133CAA
		public unsafe bool bUpdateModule
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bUpdateModule) & UParticleModule.__PropertyMask_bUpdateModule) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bUpdateModule) = ((*(base.NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bUpdateModule) & ~UParticleModule.__PropertyMask_bUpdateModule) | (value ? UParticleModule.__PropertyMask_bUpdateModule : 0));
			}
		}

		// Token: 0x1700315F RID: 12639
		// (get) Token: 0x0600D337 RID: 54071 RVA: 0x00135ADA File Offset: 0x00133CDA
		// (set) Token: 0x0600D338 RID: 54072 RVA: 0x00135AF3 File Offset: 0x00133CF3
		public unsafe bool bFinalUpdateModule
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bFinalUpdateModule) & UParticleModule.__PropertyMask_bFinalUpdateModule) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bFinalUpdateModule) = ((*(base.NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bFinalUpdateModule) & ~UParticleModule.__PropertyMask_bFinalUpdateModule) | (value ? UParticleModule.__PropertyMask_bFinalUpdateModule : 0));
			}
		}

		// Token: 0x17003160 RID: 12640
		// (get) Token: 0x0600D339 RID: 54073 RVA: 0x00135B23 File Offset: 0x00133D23
		// (set) Token: 0x0600D33A RID: 54074 RVA: 0x00135B3C File Offset: 0x00133D3C
		public unsafe bool bUpdateForGPUEmitter
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bUpdateForGPUEmitter) & UParticleModule.__PropertyMask_bUpdateForGPUEmitter) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bUpdateForGPUEmitter) = ((*(base.NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bUpdateForGPUEmitter) & ~UParticleModule.__PropertyMask_bUpdateForGPUEmitter) | (value ? UParticleModule.__PropertyMask_bUpdateForGPUEmitter : 0));
			}
		}

		// Token: 0x17003161 RID: 12641
		// (get) Token: 0x0600D33B RID: 54075 RVA: 0x00135B6C File Offset: 0x00133D6C
		// (set) Token: 0x0600D33C RID: 54076 RVA: 0x00135B85 File Offset: 0x00133D85
		public unsafe bool bCurvesAsColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bCurvesAsColor) & UParticleModule.__PropertyMask_bCurvesAsColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bCurvesAsColor) = ((*(base.NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bCurvesAsColor) & ~UParticleModule.__PropertyMask_bCurvesAsColor) | (value ? UParticleModule.__PropertyMask_bCurvesAsColor : 0));
			}
		}

		// Token: 0x17003162 RID: 12642
		// (get) Token: 0x0600D33D RID: 54077 RVA: 0x00135BB5 File Offset: 0x00133DB5
		// (set) Token: 0x0600D33E RID: 54078 RVA: 0x00135BCE File Offset: 0x00133DCE
		public unsafe bool b3DDrawMode
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModule.__PropertyOffset_b3DDrawMode) & UParticleModule.__PropertyMask_b3DDrawMode) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModule.__PropertyOffset_b3DDrawMode) = ((*(base.NativePtr + (IntPtr)UParticleModule.__PropertyOffset_b3DDrawMode) & ~UParticleModule.__PropertyMask_b3DDrawMode) | (value ? UParticleModule.__PropertyMask_b3DDrawMode : 0));
			}
		}

		// Token: 0x17003163 RID: 12643
		// (get) Token: 0x0600D33F RID: 54079 RVA: 0x00135BFE File Offset: 0x00133DFE
		// (set) Token: 0x0600D340 RID: 54080 RVA: 0x00135C17 File Offset: 0x00133E17
		public unsafe bool bSupported3DDrawMode
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bSupported3DDrawMode) & UParticleModule.__PropertyMask_bSupported3DDrawMode) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bSupported3DDrawMode) = ((*(base.NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bSupported3DDrawMode) & ~UParticleModule.__PropertyMask_bSupported3DDrawMode) | (value ? UParticleModule.__PropertyMask_bSupported3DDrawMode : 0));
			}
		}

		// Token: 0x17003164 RID: 12644
		// (get) Token: 0x0600D341 RID: 54081 RVA: 0x00135C47 File Offset: 0x00133E47
		// (set) Token: 0x0600D342 RID: 54082 RVA: 0x00135C60 File Offset: 0x00133E60
		public unsafe bool bEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bEnabled) & UParticleModule.__PropertyMask_bEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bEnabled) = ((*(base.NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bEnabled) & ~UParticleModule.__PropertyMask_bEnabled) | (value ? UParticleModule.__PropertyMask_bEnabled : 0));
			}
		}

		// Token: 0x17003165 RID: 12645
		// (get) Token: 0x0600D343 RID: 54083 RVA: 0x00135C90 File Offset: 0x00133E90
		// (set) Token: 0x0600D344 RID: 54084 RVA: 0x00135CA9 File Offset: 0x00133EA9
		public unsafe bool bEditable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bEditable) & UParticleModule.__PropertyMask_bEditable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bEditable) = ((*(base.NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bEditable) & ~UParticleModule.__PropertyMask_bEditable) | (value ? UParticleModule.__PropertyMask_bEditable : 0));
			}
		}

		// Token: 0x17003166 RID: 12646
		// (get) Token: 0x0600D345 RID: 54085 RVA: 0x00135CD9 File Offset: 0x00133ED9
		// (set) Token: 0x0600D346 RID: 54086 RVA: 0x00135CF2 File Offset: 0x00133EF2
		public unsafe bool LODDuplicate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModule.__PropertyOffset_LODDuplicate) & UParticleModule.__PropertyMask_LODDuplicate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModule.__PropertyOffset_LODDuplicate) = ((*(base.NativePtr + (IntPtr)UParticleModule.__PropertyOffset_LODDuplicate) & ~UParticleModule.__PropertyMask_LODDuplicate) | (value ? UParticleModule.__PropertyMask_LODDuplicate : 0));
			}
		}

		// Token: 0x17003167 RID: 12647
		// (get) Token: 0x0600D347 RID: 54087 RVA: 0x00135D22 File Offset: 0x00133F22
		// (set) Token: 0x0600D348 RID: 54088 RVA: 0x00135D3B File Offset: 0x00133F3B
		public unsafe bool bSupportsRandomSeed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bSupportsRandomSeed) & UParticleModule.__PropertyMask_bSupportsRandomSeed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bSupportsRandomSeed) = ((*(base.NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bSupportsRandomSeed) & ~UParticleModule.__PropertyMask_bSupportsRandomSeed) | (value ? UParticleModule.__PropertyMask_bSupportsRandomSeed : 0));
			}
		}

		// Token: 0x17003168 RID: 12648
		// (get) Token: 0x0600D349 RID: 54089 RVA: 0x00135D6B File Offset: 0x00133F6B
		// (set) Token: 0x0600D34A RID: 54090 RVA: 0x00135D84 File Offset: 0x00133F84
		public unsafe bool bRequiresLoopingNotification
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bRequiresLoopingNotification) & UParticleModule.__PropertyMask_bRequiresLoopingNotification) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bRequiresLoopingNotification) = ((*(base.NativePtr + (IntPtr)UParticleModule.__PropertyOffset_bRequiresLoopingNotification) & ~UParticleModule.__PropertyMask_bRequiresLoopingNotification) | (value ? UParticleModule.__PropertyMask_bRequiresLoopingNotification : 0));
			}
		}

		// Token: 0x17003169 RID: 12649
		// (get) Token: 0x0600D34B RID: 54091 RVA: 0x00135DB4 File Offset: 0x00133FB4
		// (set) Token: 0x0600D34C RID: 54092 RVA: 0x00135DC4 File Offset: 0x00133FC4
		public unsafe byte LODValidity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModule.__PropertyOffset_LODValidity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModule.__PropertyOffset_LODValidity) = value;
			}
		}

		// Token: 0x0600D34D RID: 54093 RVA: 0x00135DD5 File Offset: 0x00133FD5
		static UParticleModule()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModule");
		}

		// Token: 0x0600D34E RID: 54094 RVA: 0x00135DE4 File Offset: 0x00133FE4
		protected UParticleModule() : this(BuiltinUtils.AllocNativeUObject(UParticleModule.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D34F RID: 54095 RVA: 0x00135E0C File Offset: 0x0013400C
		protected UParticleModule(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007155 RID: 29013
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModule";

		// Token: 0x04007156 RID: 29014
		private static IntPtr _ClassPtr;

		// Token: 0x04007157 RID: 29015
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007158 RID: 29016
		internal static int __PropertyOffset_bSpawnModule;

		// Token: 0x04007159 RID: 29017
		internal static byte __PropertyMask_bSpawnModule;

		// Token: 0x0400715A RID: 29018
		internal static int __PropertyOffset_bUpdateModule;

		// Token: 0x0400715B RID: 29019
		internal static byte __PropertyMask_bUpdateModule;

		// Token: 0x0400715C RID: 29020
		internal static int __PropertyOffset_bFinalUpdateModule;

		// Token: 0x0400715D RID: 29021
		internal static byte __PropertyMask_bFinalUpdateModule;

		// Token: 0x0400715E RID: 29022
		internal static int __PropertyOffset_bUpdateForGPUEmitter;

		// Token: 0x0400715F RID: 29023
		internal static byte __PropertyMask_bUpdateForGPUEmitter;

		// Token: 0x04007160 RID: 29024
		internal static int __PropertyOffset_bCurvesAsColor;

		// Token: 0x04007161 RID: 29025
		internal static byte __PropertyMask_bCurvesAsColor;

		// Token: 0x04007162 RID: 29026
		internal static int __PropertyOffset_b3DDrawMode;

		// Token: 0x04007163 RID: 29027
		internal static byte __PropertyMask_b3DDrawMode;

		// Token: 0x04007164 RID: 29028
		internal static int __PropertyOffset_bSupported3DDrawMode;

		// Token: 0x04007165 RID: 29029
		internal static byte __PropertyMask_bSupported3DDrawMode;

		// Token: 0x04007166 RID: 29030
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04007167 RID: 29031
		internal static byte __PropertyMask_bEnabled;

		// Token: 0x04007168 RID: 29032
		internal static int __PropertyOffset_bEditable;

		// Token: 0x04007169 RID: 29033
		internal static byte __PropertyMask_bEditable;

		// Token: 0x0400716A RID: 29034
		internal static int __PropertyOffset_LODDuplicate;

		// Token: 0x0400716B RID: 29035
		internal static byte __PropertyMask_LODDuplicate;

		// Token: 0x0400716C RID: 29036
		internal static int __PropertyOffset_bSupportsRandomSeed;

		// Token: 0x0400716D RID: 29037
		internal static byte __PropertyMask_bSupportsRandomSeed;

		// Token: 0x0400716E RID: 29038
		internal static int __PropertyOffset_bRequiresLoopingNotification;

		// Token: 0x0400716F RID: 29039
		internal static byte __PropertyMask_bRequiresLoopingNotification;

		// Token: 0x04007170 RID: 29040
		internal static int __PropertyOffset_LODValidity;
	}
}
