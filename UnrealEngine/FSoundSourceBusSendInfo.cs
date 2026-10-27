using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001153 RID: 4435
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundSourceBusSendInfo")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 184)]
	public class FSoundSourceBusSendInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010320 RID: 66336 RVA: 0x0017DDFA File Offset: 0x0017BFFA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSoundSourceBusSendInfo._ScriptStructPtr != 0) ? FSoundSourceBusSendInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SoundSourceBusSendInfo", ref FSoundSourceBusSendInfo._ScriptStructPtr);
		}

		// Token: 0x17003F6C RID: 16236
		// (get) Token: 0x06010321 RID: 66337 RVA: 0x0017DE1E File Offset: 0x0017C01E
		// (set) Token: 0x06010322 RID: 66338 RVA: 0x0017DE2E File Offset: 0x0017C02E
		public unsafe ESourceBusSendLevelControlMethod SourceBusSendLevelControlMethod
		{
			get
			{
				return (ESourceBusSendLevelControlMethod)(*(base.NativePtr + (IntPtr)FSoundSourceBusSendInfo.__PropertyOffset_SourceBusSendLevelControlMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundSourceBusSendInfo.__PropertyOffset_SourceBusSendLevelControlMethod) = (byte)value;
			}
		}

		// Token: 0x17003F6D RID: 16237
		// (get) Token: 0x06010323 RID: 66339 RVA: 0x0017DE3F File Offset: 0x0017C03F
		// (set) Token: 0x06010324 RID: 66340 RVA: 0x0017DE53 File Offset: 0x0017C053
		public unsafe USoundSourceBus SoundSourceBus
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundSourceBus>(base.NativePtr / (IntPtr)sizeof(void*) + FSoundSourceBusSendInfo.__PropertyOffset_SoundSourceBus);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSoundSourceBusSendInfo.__PropertyOffset_SoundSourceBus, value);
			}
		}

		// Token: 0x17003F6E RID: 16238
		// (get) Token: 0x06010325 RID: 66341 RVA: 0x0017DE68 File Offset: 0x0017C068
		// (set) Token: 0x06010326 RID: 66342 RVA: 0x0017DE7C File Offset: 0x0017C07C
		public unsafe UAudioBus AudioBus
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAudioBus>(base.NativePtr / (IntPtr)sizeof(void*) + FSoundSourceBusSendInfo.__PropertyOffset_AudioBus);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSoundSourceBusSendInfo.__PropertyOffset_AudioBus, value);
			}
		}

		// Token: 0x17003F6F RID: 16239
		// (get) Token: 0x06010327 RID: 66343 RVA: 0x0017DE91 File Offset: 0x0017C091
		// (set) Token: 0x06010328 RID: 66344 RVA: 0x0017DEA1 File Offset: 0x0017C0A1
		public unsafe float SendLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundSourceBusSendInfo.__PropertyOffset_SendLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundSourceBusSendInfo.__PropertyOffset_SendLevel) = value;
			}
		}

		// Token: 0x17003F70 RID: 16240
		// (get) Token: 0x06010329 RID: 66345 RVA: 0x0017DEB2 File Offset: 0x0017C0B2
		// (set) Token: 0x0601032A RID: 66346 RVA: 0x0017DEC2 File Offset: 0x0017C0C2
		public unsafe float MinSendLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundSourceBusSendInfo.__PropertyOffset_MinSendLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundSourceBusSendInfo.__PropertyOffset_MinSendLevel) = value;
			}
		}

		// Token: 0x17003F71 RID: 16241
		// (get) Token: 0x0601032B RID: 66347 RVA: 0x0017DED3 File Offset: 0x0017C0D3
		// (set) Token: 0x0601032C RID: 66348 RVA: 0x0017DEE3 File Offset: 0x0017C0E3
		public unsafe float MaxSendLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundSourceBusSendInfo.__PropertyOffset_MaxSendLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundSourceBusSendInfo.__PropertyOffset_MaxSendLevel) = value;
			}
		}

		// Token: 0x17003F72 RID: 16242
		// (get) Token: 0x0601032D RID: 66349 RVA: 0x0017DEF4 File Offset: 0x0017C0F4
		// (set) Token: 0x0601032E RID: 66350 RVA: 0x0017DF04 File Offset: 0x0017C104
		public unsafe float MinSendDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundSourceBusSendInfo.__PropertyOffset_MinSendDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundSourceBusSendInfo.__PropertyOffset_MinSendDistance) = value;
			}
		}

		// Token: 0x17003F73 RID: 16243
		// (get) Token: 0x0601032F RID: 66351 RVA: 0x0017DF15 File Offset: 0x0017C115
		// (set) Token: 0x06010330 RID: 66352 RVA: 0x0017DF25 File Offset: 0x0017C125
		public unsafe float MaxSendDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundSourceBusSendInfo.__PropertyOffset_MaxSendDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundSourceBusSendInfo.__PropertyOffset_MaxSendDistance) = value;
			}
		}

		// Token: 0x17003F74 RID: 16244
		// (get) Token: 0x06010331 RID: 66353 RVA: 0x0017DF38 File Offset: 0x0017C138
		// (set) Token: 0x06010332 RID: 66354 RVA: 0x0017DF7B File Offset: 0x0017C17B
		[Nullable(1)]
		public FRuntimeFloatCurve CustomSendLevelCurve
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._CustomSendLevelCurve) == null)
				{
					result = (this._CustomSendLevelCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FSoundSourceBusSendInfo.__PropertyOffset_CustomSendLevelCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FSoundSourceBusSendInfo.__PropertyOffset_CustomSendLevelCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06010333 RID: 66355 RVA: 0x0017DF9C File Offset: 0x0017C19C
		public FSoundSourceBusSendInfo()
		{
		}

		// Token: 0x06010334 RID: 66356 RVA: 0x0017DFA4 File Offset: 0x0017C1A4
		[NullableContext(1)]
		public FSoundSourceBusSendInfo(ESourceBusSendLevelControlMethod SourceBusSendLevelControlMethod, USoundSourceBus SoundSourceBus, UAudioBus AudioBus, float SendLevel, float MinSendLevel, float MaxSendLevel, float MinSendDistance, float MaxSendDistance, FRuntimeFloatCurve CustomSendLevelCurve)
		{
			this.SourceBusSendLevelControlMethod = SourceBusSendLevelControlMethod;
			this.SoundSourceBus = SoundSourceBus;
			this.AudioBus = AudioBus;
			this.SendLevel = SendLevel;
			this.MinSendLevel = MinSendLevel;
			this.MaxSendLevel = MaxSendLevel;
			this.MinSendDistance = MinSendDistance;
			this.MaxSendDistance = MaxSendDistance;
			this.CustomSendLevelCurve = CustomSendLevelCurve;
		}

		// Token: 0x06010335 RID: 66357 RVA: 0x0017DFFC File Offset: 0x0017C1FC
		protected override IntPtr GetUStructPtr()
		{
			return FSoundSourceBusSendInfo.StaticStruct();
		}

		// Token: 0x06010336 RID: 66358 RVA: 0x0017E008 File Offset: 0x0017C208
		public FSoundSourceBusSendInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010337 RID: 66359 RVA: 0x0017E012 File Offset: 0x0017C212
		public FSoundSourceBusSendInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010338 RID: 66360 RVA: 0x0017E01D File Offset: 0x0017C21D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSoundSourceBusSendInfo(Pointer, false, true);
		}

		// Token: 0x06010339 RID: 66361 RVA: 0x0017E027 File Offset: 0x0017C227
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSoundSourceBusSendInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04008B75 RID: 35701
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SoundSourceBusSendInfo";

		// Token: 0x04008B76 RID: 35702
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008B77 RID: 35703
		internal static int __PropertyOffset_SourceBusSendLevelControlMethod;

		// Token: 0x04008B78 RID: 35704
		internal static int __PropertyOffset_SoundSourceBus;

		// Token: 0x04008B79 RID: 35705
		internal static int __PropertyOffset_AudioBus;

		// Token: 0x04008B7A RID: 35706
		internal static int __PropertyOffset_SendLevel;

		// Token: 0x04008B7B RID: 35707
		internal static int __PropertyOffset_MinSendLevel;

		// Token: 0x04008B7C RID: 35708
		internal static int __PropertyOffset_MaxSendLevel;

		// Token: 0x04008B7D RID: 35709
		internal static int __PropertyOffset_MinSendDistance;

		// Token: 0x04008B7E RID: 35710
		internal static int __PropertyOffset_MaxSendDistance;

		// Token: 0x04008B7F RID: 35711
		internal static int __PropertyOffset_CustomSendLevelCurve;

		// Token: 0x04008B80 RID: 35712
		private FRuntimeFloatCurve _CustomSendLevelCurve;
	}
}
