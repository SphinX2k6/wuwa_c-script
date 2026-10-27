using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C0F RID: 7183
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.NiagaraDataInterfaceKuroRendering")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UNiagaraDataInterfaceKuroRendering : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601BB66 RID: 113510 RVA: 0x0028C966 File Offset: 0x0028AB66
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceKuroRendering._ClassPtr;
		}

		// Token: 0x0601BB67 RID: 113511 RVA: 0x0028C974 File Offset: 0x0028AB74
		public UNiagaraDataInterfaceKuroRendering() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceKuroRendering.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601BB68 RID: 113512 RVA: 0x0028C99C File Offset: 0x0028AB9C
		[NullableContext(1)]
		public UNiagaraDataInterfaceKuroRendering(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceKuroRendering.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006FC4 RID: 28612
		// (get) Token: 0x0601BB69 RID: 113513 RVA: 0x0028C9CF File Offset: 0x0028ABCF
		// (set) Token: 0x0601BB6A RID: 113514 RVA: 0x0028C9E3 File Offset: 0x0028ABE3
		public unsafe FName NiagaraCollectionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceKuroRendering.__PropertyOffset_NiagaraCollectionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceKuroRendering.__PropertyOffset_NiagaraCollectionName) = value;
			}
		}

		// Token: 0x0601BB6B RID: 113515
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetNiagaraRhythmGameNoteState(int Index, ERhythmGameNoteState State, float HoldingBrokeTime = 0f);

		// Token: 0x0601BB6C RID: 113516 RVA: 0x0028C9F8 File Offset: 0x0028ABF8
		public static void SetNiagaraRhythmGameNoteInfos([Nullable(new byte[]
		{
			2,
			1
		})] TArray<FRhythmGameNoteInfo> Infos, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<FRhythmGameTrackEvent> Events)
		{
			UNiagaraDataInterfaceKuroRendering.__SetNiagaraRhythmGameNoteInfos_Internal((Infos ?? new TArray<FRhythmGameNoteInfo>()).NativePtr, (Events ?? new TArray<FRhythmGameTrackEvent>()).NativePtr);
		}

		// Token: 0x0601BB6D RID: 113517
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetNiagaraRhythmGameGlobalTrackSpeed(float TrackSpeed);

		// Token: 0x0601BB6E RID: 113518
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetNiagaraRhythmGameGlobalTrackIndex(float CurrentTrackIndex);

		// Token: 0x0601BB6F RID: 113519
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetNiagaraRhythmGameGlobalTimeAndPos(float CentralPoint, float CurrentTimePoint);

		// Token: 0x0601BB70 RID: 113520
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetNiagaraRhythmGameGlobalBPM(float BPM);

		// Token: 0x0601BB71 RID: 113521
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearNiagaraRhythmGamePlayData();

		// Token: 0x0601BB72 RID: 113522
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraRhythmGameNoteInfos_Internal(IntPtr Infos, IntPtr Events);

		// Token: 0x0601BB73 RID: 113523 RVA: 0x0028CA1D File Offset: 0x0028AC1D
		static UNiagaraDataInterfaceKuroRendering()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.NiagaraDataInterfaceKuroRendering");
		}

		// Token: 0x0601BB74 RID: 113524 RVA: 0x0028CA2B File Offset: 0x0028AC2B
		protected UNiagaraDataInterfaceKuroRendering(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EE75 RID: 61045
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.NiagaraDataInterfaceKuroRendering";

		// Token: 0x0400EE76 RID: 61046
		private static IntPtr _ClassPtr;

		// Token: 0x0400EE77 RID: 61047
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EE78 RID: 61048
		internal static int __PropertyOffset_NiagaraCollectionName;
	}
}
