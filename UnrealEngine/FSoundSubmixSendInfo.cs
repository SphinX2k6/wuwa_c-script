using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001156 RID: 4438
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundSubmixSendInfo")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FSoundSubmixSendInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601036D RID: 66413 RVA: 0x0017E4E5 File Offset: 0x0017C6E5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSoundSubmixSendInfo._ScriptStructPtr != 0) ? FSoundSubmixSendInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SoundSubmixSendInfo", ref FSoundSubmixSendInfo._ScriptStructPtr);
		}

		// Token: 0x17003F80 RID: 16256
		// (get) Token: 0x0601036E RID: 66414 RVA: 0x0017E509 File Offset: 0x0017C709
		// (set) Token: 0x0601036F RID: 66415 RVA: 0x0017E519 File Offset: 0x0017C719
		public unsafe ESendLevelControlMethod SendLevelControlMethod
		{
			get
			{
				return (ESendLevelControlMethod)(*(base.NativePtr + (IntPtr)FSoundSubmixSendInfo.__PropertyOffset_SendLevelControlMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundSubmixSendInfo.__PropertyOffset_SendLevelControlMethod) = (byte)value;
			}
		}

		// Token: 0x17003F81 RID: 16257
		// (get) Token: 0x06010370 RID: 66416 RVA: 0x0017E52A File Offset: 0x0017C72A
		// (set) Token: 0x06010371 RID: 66417 RVA: 0x0017E53A File Offset: 0x0017C73A
		public unsafe ESubmixSendStage SendStage
		{
			get
			{
				return (ESubmixSendStage)(*(base.NativePtr + (IntPtr)FSoundSubmixSendInfo.__PropertyOffset_SendStage));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundSubmixSendInfo.__PropertyOffset_SendStage) = (byte)value;
			}
		}

		// Token: 0x17003F82 RID: 16258
		// (get) Token: 0x06010372 RID: 66418 RVA: 0x0017E54B File Offset: 0x0017C74B
		// (set) Token: 0x06010373 RID: 66419 RVA: 0x0017E55F File Offset: 0x0017C75F
		[Nullable(2)]
		public unsafe USoundSubmixBase SoundSubmix
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundSubmixBase>(base.NativePtr / (IntPtr)sizeof(void*) + FSoundSubmixSendInfo.__PropertyOffset_SoundSubmix);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSoundSubmixSendInfo.__PropertyOffset_SoundSubmix, value);
			}
		}

		// Token: 0x17003F83 RID: 16259
		// (get) Token: 0x06010374 RID: 66420 RVA: 0x0017E574 File Offset: 0x0017C774
		// (set) Token: 0x06010375 RID: 66421 RVA: 0x0017E584 File Offset: 0x0017C784
		public unsafe float SendLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundSubmixSendInfo.__PropertyOffset_SendLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundSubmixSendInfo.__PropertyOffset_SendLevel) = value;
			}
		}

		// Token: 0x17003F84 RID: 16260
		// (get) Token: 0x06010376 RID: 66422 RVA: 0x0017E595 File Offset: 0x0017C795
		// (set) Token: 0x06010377 RID: 66423 RVA: 0x0017E5A5 File Offset: 0x0017C7A5
		public unsafe float MinSendLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundSubmixSendInfo.__PropertyOffset_MinSendLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundSubmixSendInfo.__PropertyOffset_MinSendLevel) = value;
			}
		}

		// Token: 0x17003F85 RID: 16261
		// (get) Token: 0x06010378 RID: 66424 RVA: 0x0017E5B6 File Offset: 0x0017C7B6
		// (set) Token: 0x06010379 RID: 66425 RVA: 0x0017E5C6 File Offset: 0x0017C7C6
		public unsafe float MaxSendLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundSubmixSendInfo.__PropertyOffset_MaxSendLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundSubmixSendInfo.__PropertyOffset_MaxSendLevel) = value;
			}
		}

		// Token: 0x17003F86 RID: 16262
		// (get) Token: 0x0601037A RID: 66426 RVA: 0x0017E5D7 File Offset: 0x0017C7D7
		// (set) Token: 0x0601037B RID: 66427 RVA: 0x0017E5E7 File Offset: 0x0017C7E7
		public unsafe float MinSendDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundSubmixSendInfo.__PropertyOffset_MinSendDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundSubmixSendInfo.__PropertyOffset_MinSendDistance) = value;
			}
		}

		// Token: 0x17003F87 RID: 16263
		// (get) Token: 0x0601037C RID: 66428 RVA: 0x0017E5F8 File Offset: 0x0017C7F8
		// (set) Token: 0x0601037D RID: 66429 RVA: 0x0017E608 File Offset: 0x0017C808
		public unsafe float MaxSendDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundSubmixSendInfo.__PropertyOffset_MaxSendDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundSubmixSendInfo.__PropertyOffset_MaxSendDistance) = value;
			}
		}

		// Token: 0x17003F88 RID: 16264
		// (get) Token: 0x0601037E RID: 66430 RVA: 0x0017E61C File Offset: 0x0017C81C
		// (set) Token: 0x0601037F RID: 66431 RVA: 0x0017E65F File Offset: 0x0017C85F
		public FRuntimeFloatCurve CustomSendLevelCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._CustomSendLevelCurve) == null)
				{
					result = (this._CustomSendLevelCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FSoundSubmixSendInfo.__PropertyOffset_CustomSendLevelCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FSoundSubmixSendInfo.__PropertyOffset_CustomSendLevelCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06010380 RID: 66432 RVA: 0x0017E680 File Offset: 0x0017C880
		public FSoundSubmixSendInfo()
		{
		}

		// Token: 0x06010381 RID: 66433 RVA: 0x0017E688 File Offset: 0x0017C888
		public FSoundSubmixSendInfo(ESendLevelControlMethod SendLevelControlMethod, ESubmixSendStage SendStage, USoundSubmixBase SoundSubmix, float SendLevel, float MinSendLevel, float MaxSendLevel, float MinSendDistance, float MaxSendDistance, FRuntimeFloatCurve CustomSendLevelCurve)
		{
			this.SendLevelControlMethod = SendLevelControlMethod;
			this.SendStage = SendStage;
			this.SoundSubmix = SoundSubmix;
			this.SendLevel = SendLevel;
			this.MinSendLevel = MinSendLevel;
			this.MaxSendLevel = MaxSendLevel;
			this.MinSendDistance = MinSendDistance;
			this.MaxSendDistance = MaxSendDistance;
			this.CustomSendLevelCurve = CustomSendLevelCurve;
		}

		// Token: 0x06010382 RID: 66434 RVA: 0x0017E6E0 File Offset: 0x0017C8E0
		protected override IntPtr GetUStructPtr()
		{
			return FSoundSubmixSendInfo.StaticStruct();
		}

		// Token: 0x06010383 RID: 66435 RVA: 0x0017E6EC File Offset: 0x0017C8EC
		[NullableContext(2)]
		public FSoundSubmixSendInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010384 RID: 66436 RVA: 0x0017E6F6 File Offset: 0x0017C8F6
		public FSoundSubmixSendInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010385 RID: 66437 RVA: 0x0017E701 File Offset: 0x0017C901
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSoundSubmixSendInfo(Pointer, false, true);
		}

		// Token: 0x06010386 RID: 66438 RVA: 0x0017E70B File Offset: 0x0017C90B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSoundSubmixSendInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04008B96 RID: 35734
		public const string __ObjectPath = "/Script/Engine.SoundSubmixSendInfo";

		// Token: 0x04008B97 RID: 35735
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008B98 RID: 35736
		internal static int __PropertyOffset_SendLevelControlMethod;

		// Token: 0x04008B99 RID: 35737
		internal static int __PropertyOffset_SendStage;

		// Token: 0x04008B9A RID: 35738
		internal static int __PropertyOffset_SoundSubmix;

		// Token: 0x04008B9B RID: 35739
		internal static int __PropertyOffset_SendLevel;

		// Token: 0x04008B9C RID: 35740
		internal static int __PropertyOffset_MinSendLevel;

		// Token: 0x04008B9D RID: 35741
		internal static int __PropertyOffset_MaxSendLevel;

		// Token: 0x04008B9E RID: 35742
		internal static int __PropertyOffset_MinSendDistance;

		// Token: 0x04008B9F RID: 35743
		internal static int __PropertyOffset_MaxSendDistance;

		// Token: 0x04008BA0 RID: 35744
		internal static int __PropertyOffset_CustomSendLevelCurve;

		// Token: 0x04008BA1 RID: 35745
		[Nullable(2)]
		private FRuntimeFloatCurve _CustomSendLevelCurve;
	}
}
