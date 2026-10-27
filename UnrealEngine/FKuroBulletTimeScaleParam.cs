using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001703 RID: 5891
	[UnrealObjectPath("/Script/KuroBulletCore.KuroBulletTimeScaleParam")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroBulletTimeScaleParam : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601545F RID: 87135 RVA: 0x001F4486 File Offset: 0x001F2686
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBulletTimeScaleParam._ScriptStructPtr != 0) ? FKuroBulletTimeScaleParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.KuroBulletTimeScaleParam", ref FKuroBulletTimeScaleParam._ScriptStructPtr);
		}

		// Token: 0x17005424 RID: 21540
		// (get) Token: 0x06015460 RID: 87136 RVA: 0x001F44AA File Offset: 0x001F26AA
		// (set) Token: 0x06015461 RID: 87137 RVA: 0x001F44BA File Offset: 0x001F26BA
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletTimeScaleParam.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletTimeScaleParam.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x17005425 RID: 21541
		// (get) Token: 0x06015462 RID: 87138 RVA: 0x001F44CB File Offset: 0x001F26CB
		// (set) Token: 0x06015463 RID: 87139 RVA: 0x001F44DB File Offset: 0x001F26DB
		public unsafe float Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletTimeScaleParam.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletTimeScaleParam.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x17005426 RID: 21542
		// (get) Token: 0x06015464 RID: 87140 RVA: 0x001F44EC File Offset: 0x001F26EC
		// (set) Token: 0x06015465 RID: 87141 RVA: 0x001F44FC File Offset: 0x001F26FC
		public unsafe float TimeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletTimeScaleParam.__PropertyOffset_TimeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletTimeScaleParam.__PropertyOffset_TimeScale) = value;
			}
		}

		// Token: 0x17005427 RID: 21543
		// (get) Token: 0x06015466 RID: 87142 RVA: 0x001F450D File Offset: 0x001F270D
		// (set) Token: 0x06015467 RID: 87143 RVA: 0x001F4521 File Offset: 0x001F2721
		[Nullable(2)]
		public unsafe UCurveFloat TimeCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroBulletTimeScaleParam.__PropertyOffset_TimeCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroBulletTimeScaleParam.__PropertyOffset_TimeCurve, value);
			}
		}

		// Token: 0x06015468 RID: 87144 RVA: 0x001F4536 File Offset: 0x001F2736
		public FKuroBulletTimeScaleParam()
		{
		}

		// Token: 0x06015469 RID: 87145 RVA: 0x001F453E File Offset: 0x001F273E
		[NullableContext(1)]
		public FKuroBulletTimeScaleParam(float Duration, float Priority, float TimeScale, UCurveFloat TimeCurve)
		{
			this.Duration = Duration;
			this.Priority = Priority;
			this.TimeScale = TimeScale;
			this.TimeCurve = TimeCurve;
		}

		// Token: 0x0601546A RID: 87146 RVA: 0x001F4563 File Offset: 0x001F2763
		protected override IntPtr GetUStructPtr()
		{
			return FKuroBulletTimeScaleParam.StaticStruct();
		}

		// Token: 0x0601546B RID: 87147 RVA: 0x001F456F File Offset: 0x001F276F
		[NullableContext(2)]
		public FKuroBulletTimeScaleParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601546C RID: 87148 RVA: 0x001F4579 File Offset: 0x001F2779
		public FKuroBulletTimeScaleParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601546D RID: 87149 RVA: 0x001F4584 File Offset: 0x001F2784
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroBulletTimeScaleParam(Pointer, false, true);
		}

		// Token: 0x0601546E RID: 87150 RVA: 0x001F458E File Offset: 0x001F278E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroBulletTimeScaleParam(Pointer, MemoryOwner);
		}

		// Token: 0x0400B997 RID: 47511
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBulletCore.KuroBulletTimeScaleParam";

		// Token: 0x0400B998 RID: 47512
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B999 RID: 47513
		internal static int __PropertyOffset_Duration;

		// Token: 0x0400B99A RID: 47514
		internal static int __PropertyOffset_Priority;

		// Token: 0x0400B99B RID: 47515
		internal static int __PropertyOffset_TimeScale;

		// Token: 0x0400B99C RID: 47516
		internal static int __PropertyOffset_TimeCurve;
	}
}
