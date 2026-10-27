using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000F48 RID: 3912
	[UnrealObjectPath("/Script/Engine.ParticleEvent_GenerateInfo")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FParticleEvent_GenerateInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600D2F7 RID: 54007 RVA: 0x001353CE File Offset: 0x001335CE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FParticleEvent_GenerateInfo._ScriptStructPtr != 0) ? FParticleEvent_GenerateInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ParticleEvent_GenerateInfo", ref FParticleEvent_GenerateInfo._ScriptStructPtr);
		}

		// Token: 0x17003146 RID: 12614
		// (get) Token: 0x0600D2F8 RID: 54008 RVA: 0x001353F2 File Offset: 0x001335F2
		// (set) Token: 0x0600D2F9 RID: 54009 RVA: 0x00135406 File Offset: 0x00133606
		public unsafe TEnumAsByte<EParticleEventType> Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FParticleEvent_GenerateInfo.__PropertyOffset_Type);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FParticleEvent_GenerateInfo.__PropertyOffset_Type) = value;
			}
		}

		// Token: 0x17003147 RID: 12615
		// (get) Token: 0x0600D2FA RID: 54010 RVA: 0x0013541B File Offset: 0x0013361B
		// (set) Token: 0x0600D2FB RID: 54011 RVA: 0x0013542B File Offset: 0x0013362B
		public unsafe int Frequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FParticleEvent_GenerateInfo.__PropertyOffset_Frequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FParticleEvent_GenerateInfo.__PropertyOffset_Frequency) = value;
			}
		}

		// Token: 0x17003148 RID: 12616
		// (get) Token: 0x0600D2FC RID: 54012 RVA: 0x0013543C File Offset: 0x0013363C
		// (set) Token: 0x0600D2FD RID: 54013 RVA: 0x0013544C File Offset: 0x0013364C
		public unsafe int ParticleFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FParticleEvent_GenerateInfo.__PropertyOffset_ParticleFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FParticleEvent_GenerateInfo.__PropertyOffset_ParticleFrequency) = value;
			}
		}

		// Token: 0x17003149 RID: 12617
		// (get) Token: 0x0600D2FE RID: 54014 RVA: 0x0013545D File Offset: 0x0013365D
		// (set) Token: 0x0600D2FF RID: 54015 RVA: 0x00135476 File Offset: 0x00133676
		public unsafe bool FirstTimeOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FParticleEvent_GenerateInfo.__PropertyOffset_FirstTimeOnly) & FParticleEvent_GenerateInfo.__PropertyMask_FirstTimeOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FParticleEvent_GenerateInfo.__PropertyOffset_FirstTimeOnly) = ((*(base.NativePtr + (IntPtr)FParticleEvent_GenerateInfo.__PropertyOffset_FirstTimeOnly) & ~FParticleEvent_GenerateInfo.__PropertyMask_FirstTimeOnly) | (value ? FParticleEvent_GenerateInfo.__PropertyMask_FirstTimeOnly : 0));
			}
		}

		// Token: 0x1700314A RID: 12618
		// (get) Token: 0x0600D300 RID: 54016 RVA: 0x001354A6 File Offset: 0x001336A6
		// (set) Token: 0x0600D301 RID: 54017 RVA: 0x001354BF File Offset: 0x001336BF
		public unsafe bool LastTimeOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FParticleEvent_GenerateInfo.__PropertyOffset_LastTimeOnly) & FParticleEvent_GenerateInfo.__PropertyMask_LastTimeOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FParticleEvent_GenerateInfo.__PropertyOffset_LastTimeOnly) = ((*(base.NativePtr + (IntPtr)FParticleEvent_GenerateInfo.__PropertyOffset_LastTimeOnly) & ~FParticleEvent_GenerateInfo.__PropertyMask_LastTimeOnly) | (value ? FParticleEvent_GenerateInfo.__PropertyMask_LastTimeOnly : 0));
			}
		}

		// Token: 0x1700314B RID: 12619
		// (get) Token: 0x0600D302 RID: 54018 RVA: 0x001354EF File Offset: 0x001336EF
		// (set) Token: 0x0600D303 RID: 54019 RVA: 0x00135508 File Offset: 0x00133708
		public unsafe bool UseReflectedImpactVector
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FParticleEvent_GenerateInfo.__PropertyOffset_UseReflectedImpactVector) & FParticleEvent_GenerateInfo.__PropertyMask_UseReflectedImpactVector) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FParticleEvent_GenerateInfo.__PropertyOffset_UseReflectedImpactVector) = ((*(base.NativePtr + (IntPtr)FParticleEvent_GenerateInfo.__PropertyOffset_UseReflectedImpactVector) & ~FParticleEvent_GenerateInfo.__PropertyMask_UseReflectedImpactVector) | (value ? FParticleEvent_GenerateInfo.__PropertyMask_UseReflectedImpactVector : 0));
			}
		}

		// Token: 0x1700314C RID: 12620
		// (get) Token: 0x0600D304 RID: 54020 RVA: 0x00135538 File Offset: 0x00133738
		// (set) Token: 0x0600D305 RID: 54021 RVA: 0x00135551 File Offset: 0x00133751
		public unsafe bool bUseOrbitOffset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FParticleEvent_GenerateInfo.__PropertyOffset_bUseOrbitOffset) & FParticleEvent_GenerateInfo.__PropertyMask_bUseOrbitOffset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FParticleEvent_GenerateInfo.__PropertyOffset_bUseOrbitOffset) = ((*(base.NativePtr + (IntPtr)FParticleEvent_GenerateInfo.__PropertyOffset_bUseOrbitOffset) & ~FParticleEvent_GenerateInfo.__PropertyMask_bUseOrbitOffset) | (value ? FParticleEvent_GenerateInfo.__PropertyMask_bUseOrbitOffset : 0));
			}
		}

		// Token: 0x1700314D RID: 12621
		// (get) Token: 0x0600D306 RID: 54022 RVA: 0x00135581 File Offset: 0x00133781
		// (set) Token: 0x0600D307 RID: 54023 RVA: 0x00135595 File Offset: 0x00133795
		public unsafe FName CustomName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FParticleEvent_GenerateInfo.__PropertyOffset_CustomName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FParticleEvent_GenerateInfo.__PropertyOffset_CustomName) = value;
			}
		}

		// Token: 0x1700314E RID: 12622
		// (get) Token: 0x0600D308 RID: 54024 RVA: 0x001355AC File Offset: 0x001337AC
		// (set) Token: 0x0600D309 RID: 54025 RVA: 0x001355EF File Offset: 0x001337EF
		[Nullable(1)]
		public TArray<UParticleModuleEventSendToGame> ParticleModuleEventsToSendToGame
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UParticleModuleEventSendToGame> result;
				if ((result = this._ParticleModuleEventsToSendToGame) == null)
				{
					result = (this._ParticleModuleEventsToSendToGame = new TArray<UParticleModuleEventSendToGame>(base.NativePtr + (IntPtr)FParticleEvent_GenerateInfo.__PropertyOffset_ParticleModuleEventsToSendToGame, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ParticleModuleEventsToSendToGame.CopyAssign(value);
			}
		}

		// Token: 0x0600D30A RID: 54026 RVA: 0x001355FD File Offset: 0x001337FD
		public FParticleEvent_GenerateInfo()
		{
		}

		// Token: 0x0600D30B RID: 54027 RVA: 0x00135608 File Offset: 0x00133808
		public FParticleEvent_GenerateInfo(TEnumAsByte<EParticleEventType> Type, int Frequency, int ParticleFrequency, bool FirstTimeOnly, bool LastTimeOnly, bool UseReflectedImpactVector, bool bUseOrbitOffset, FName CustomName, [Nullable(1)] TArray<UParticleModuleEventSendToGame> ParticleModuleEventsToSendToGame)
		{
			this.Type = Type;
			this.Frequency = Frequency;
			this.ParticleFrequency = ParticleFrequency;
			this.FirstTimeOnly = FirstTimeOnly;
			this.LastTimeOnly = LastTimeOnly;
			this.UseReflectedImpactVector = UseReflectedImpactVector;
			this.bUseOrbitOffset = bUseOrbitOffset;
			this.CustomName = CustomName;
			this.ParticleModuleEventsToSendToGame = ParticleModuleEventsToSendToGame;
		}

		// Token: 0x0600D30C RID: 54028 RVA: 0x00135660 File Offset: 0x00133860
		protected override IntPtr GetUStructPtr()
		{
			return FParticleEvent_GenerateInfo.StaticStruct();
		}

		// Token: 0x0600D30D RID: 54029 RVA: 0x0013566C File Offset: 0x0013386C
		[NullableContext(2)]
		public FParticleEvent_GenerateInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D30E RID: 54030 RVA: 0x00135676 File Offset: 0x00133876
		public FParticleEvent_GenerateInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D30F RID: 54031 RVA: 0x00135681 File Offset: 0x00133881
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FParticleEvent_GenerateInfo(Pointer, false, true);
		}

		// Token: 0x0600D310 RID: 54032 RVA: 0x0013568B File Offset: 0x0013388B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FParticleEvent_GenerateInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400712C RID: 28972
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ParticleEvent_GenerateInfo";

		// Token: 0x0400712D RID: 28973
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400712E RID: 28974
		internal static int __PropertyOffset_Type;

		// Token: 0x0400712F RID: 28975
		internal static int __PropertyOffset_Frequency;

		// Token: 0x04007130 RID: 28976
		internal static int __PropertyOffset_ParticleFrequency;

		// Token: 0x04007131 RID: 28977
		internal static int __PropertyOffset_FirstTimeOnly;

		// Token: 0x04007132 RID: 28978
		internal static byte __PropertyMask_FirstTimeOnly;

		// Token: 0x04007133 RID: 28979
		internal static int __PropertyOffset_LastTimeOnly;

		// Token: 0x04007134 RID: 28980
		internal static byte __PropertyMask_LastTimeOnly;

		// Token: 0x04007135 RID: 28981
		internal static int __PropertyOffset_UseReflectedImpactVector;

		// Token: 0x04007136 RID: 28982
		internal static byte __PropertyMask_UseReflectedImpactVector;

		// Token: 0x04007137 RID: 28983
		internal static int __PropertyOffset_bUseOrbitOffset;

		// Token: 0x04007138 RID: 28984
		internal static byte __PropertyMask_bUseOrbitOffset;

		// Token: 0x04007139 RID: 28985
		internal static int __PropertyOffset_CustomName;

		// Token: 0x0400713A RID: 28986
		internal static int __PropertyOffset_ParticleModuleEventsToSendToGame;

		// Token: 0x0400713B RID: 28987
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UParticleModuleEventSendToGame> _ParticleModuleEventsToSendToGame;
	}
}
