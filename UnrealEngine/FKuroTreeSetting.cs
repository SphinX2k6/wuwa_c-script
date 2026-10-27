using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001BD3 RID: 7123
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroTreeSetting")]
	[UnrealStructLayout(56, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FKuroTreeSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B56B RID: 111979 RVA: 0x00284615 File Offset: 0x00282815
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroTreeSetting._ScriptStructPtr != 0) ? FKuroTreeSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroTreeSetting", ref FKuroTreeSetting._ScriptStructPtr);
		}

		// Token: 0x17006DDB RID: 28123
		// (get) Token: 0x0601B56C RID: 111980 RVA: 0x00284639 File Offset: 0x00282839
		// (set) Token: 0x0601B56D RID: 111981 RVA: 0x00284652 File Offset: 0x00282852
		public unsafe bool bOverride_LineRadius
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_bOverride_LineRadius) & FKuroTreeSetting.__PropertyMask_bOverride_LineRadius) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_bOverride_LineRadius) = ((*(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_bOverride_LineRadius) & ~FKuroTreeSetting.__PropertyMask_bOverride_LineRadius) | (value ? FKuroTreeSetting.__PropertyMask_bOverride_LineRadius : 0));
			}
		}

		// Token: 0x17006DDC RID: 28124
		// (get) Token: 0x0601B56E RID: 111982 RVA: 0x00284682 File Offset: 0x00282882
		// (set) Token: 0x0601B56F RID: 111983 RVA: 0x0028469B File Offset: 0x0028289B
		public unsafe bool bOverride_DistanceRatio
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_bOverride_DistanceRatio) & FKuroTreeSetting.__PropertyMask_bOverride_DistanceRatio) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_bOverride_DistanceRatio) = ((*(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_bOverride_DistanceRatio) & ~FKuroTreeSetting.__PropertyMask_bOverride_DistanceRatio) | (value ? FKuroTreeSetting.__PropertyMask_bOverride_DistanceRatio : 0));
			}
		}

		// Token: 0x17006DDD RID: 28125
		// (get) Token: 0x0601B570 RID: 111984 RVA: 0x002846CB File Offset: 0x002828CB
		// (set) Token: 0x0601B571 RID: 111985 RVA: 0x002846E4 File Offset: 0x002828E4
		public unsafe bool bOverride_LinePower
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_bOverride_LinePower) & FKuroTreeSetting.__PropertyMask_bOverride_LinePower) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_bOverride_LinePower) = ((*(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_bOverride_LinePower) & ~FKuroTreeSetting.__PropertyMask_bOverride_LinePower) | (value ? FKuroTreeSetting.__PropertyMask_bOverride_LinePower : 0));
			}
		}

		// Token: 0x17006DDE RID: 28126
		// (get) Token: 0x0601B572 RID: 111986 RVA: 0x00284714 File Offset: 0x00282914
		// (set) Token: 0x0601B573 RID: 111987 RVA: 0x0028472D File Offset: 0x0028292D
		public unsafe bool bOverride_NearColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_bOverride_NearColor) & FKuroTreeSetting.__PropertyMask_bOverride_NearColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_bOverride_NearColor) = ((*(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_bOverride_NearColor) & ~FKuroTreeSetting.__PropertyMask_bOverride_NearColor) | (value ? FKuroTreeSetting.__PropertyMask_bOverride_NearColor : 0));
			}
		}

		// Token: 0x17006DDF RID: 28127
		// (get) Token: 0x0601B574 RID: 111988 RVA: 0x0028475D File Offset: 0x0028295D
		// (set) Token: 0x0601B575 RID: 111989 RVA: 0x00284776 File Offset: 0x00282976
		public unsafe bool bOverride_FarColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_bOverride_FarColor) & FKuroTreeSetting.__PropertyMask_bOverride_FarColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_bOverride_FarColor) = ((*(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_bOverride_FarColor) & ~FKuroTreeSetting.__PropertyMask_bOverride_FarColor) | (value ? FKuroTreeSetting.__PropertyMask_bOverride_FarColor : 0));
			}
		}

		// Token: 0x17006DE0 RID: 28128
		// (get) Token: 0x0601B576 RID: 111990 RVA: 0x002847A6 File Offset: 0x002829A6
		// (set) Token: 0x0601B577 RID: 111991 RVA: 0x002847BF File Offset: 0x002829BF
		public unsafe bool bOverride_NearFarDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_bOverride_NearFarDistance) & FKuroTreeSetting.__PropertyMask_bOverride_NearFarDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_bOverride_NearFarDistance) = ((*(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_bOverride_NearFarDistance) & ~FKuroTreeSetting.__PropertyMask_bOverride_NearFarDistance) | (value ? FKuroTreeSetting.__PropertyMask_bOverride_NearFarDistance : 0));
			}
		}

		// Token: 0x17006DE1 RID: 28129
		// (get) Token: 0x0601B578 RID: 111992 RVA: 0x002847EF File Offset: 0x002829EF
		// (set) Token: 0x0601B579 RID: 111993 RVA: 0x00284808 File Offset: 0x00282A08
		public unsafe bool bOverride_Saturation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_bOverride_Saturation) & FKuroTreeSetting.__PropertyMask_bOverride_Saturation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_bOverride_Saturation) = ((*(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_bOverride_Saturation) & ~FKuroTreeSetting.__PropertyMask_bOverride_Saturation) | (value ? FKuroTreeSetting.__PropertyMask_bOverride_Saturation : 0));
			}
		}

		// Token: 0x17006DE2 RID: 28130
		// (get) Token: 0x0601B57A RID: 111994 RVA: 0x00284838 File Offset: 0x00282A38
		// (set) Token: 0x0601B57B RID: 111995 RVA: 0x00284848 File Offset: 0x00282A48
		public unsafe float LineRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_LineRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_LineRadius) = value;
			}
		}

		// Token: 0x17006DE3 RID: 28131
		// (get) Token: 0x0601B57C RID: 111996 RVA: 0x00284859 File Offset: 0x00282A59
		// (set) Token: 0x0601B57D RID: 111997 RVA: 0x00284869 File Offset: 0x00282A69
		public unsafe float DistanceRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_DistanceRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_DistanceRatio) = value;
			}
		}

		// Token: 0x17006DE4 RID: 28132
		// (get) Token: 0x0601B57E RID: 111998 RVA: 0x0028487A File Offset: 0x00282A7A
		// (set) Token: 0x0601B57F RID: 111999 RVA: 0x0028488A File Offset: 0x00282A8A
		public unsafe float LinePower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_LinePower);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_LinePower) = value;
			}
		}

		// Token: 0x17006DE5 RID: 28133
		// (get) Token: 0x0601B580 RID: 112000 RVA: 0x0028489B File Offset: 0x00282A9B
		// (set) Token: 0x0601B581 RID: 112001 RVA: 0x002848AF File Offset: 0x00282AAF
		public unsafe FLinearColor NearColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_NearColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_NearColor) = value;
			}
		}

		// Token: 0x17006DE6 RID: 28134
		// (get) Token: 0x0601B582 RID: 112002 RVA: 0x002848C4 File Offset: 0x00282AC4
		// (set) Token: 0x0601B583 RID: 112003 RVA: 0x002848D8 File Offset: 0x00282AD8
		public unsafe FLinearColor FarColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_FarColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_FarColor) = value;
			}
		}

		// Token: 0x17006DE7 RID: 28135
		// (get) Token: 0x0601B584 RID: 112004 RVA: 0x002848ED File Offset: 0x00282AED
		// (set) Token: 0x0601B585 RID: 112005 RVA: 0x002848FD File Offset: 0x00282AFD
		public unsafe float NearFarDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_NearFarDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_NearFarDistance) = value;
			}
		}

		// Token: 0x17006DE8 RID: 28136
		// (get) Token: 0x0601B586 RID: 112006 RVA: 0x0028490E File Offset: 0x00282B0E
		// (set) Token: 0x0601B587 RID: 112007 RVA: 0x0028491E File Offset: 0x00282B1E
		public unsafe float Saturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_Saturation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTreeSetting.__PropertyOffset_Saturation) = value;
			}
		}

		// Token: 0x0601B588 RID: 112008 RVA: 0x0028492F File Offset: 0x00282B2F
		public FKuroTreeSetting()
		{
		}

		// Token: 0x0601B589 RID: 112009 RVA: 0x00284938 File Offset: 0x00282B38
		public FKuroTreeSetting(bool bOverride_LineRadius, bool bOverride_DistanceRatio, bool bOverride_LinePower, bool bOverride_NearColor, bool bOverride_FarColor, bool bOverride_NearFarDistance, bool bOverride_Saturation, float LineRadius, float DistanceRatio, float LinePower, FLinearColor NearColor, FLinearColor FarColor, float NearFarDistance, float Saturation)
		{
			this.bOverride_LineRadius = bOverride_LineRadius;
			this.bOverride_DistanceRatio = bOverride_DistanceRatio;
			this.bOverride_LinePower = bOverride_LinePower;
			this.bOverride_NearColor = bOverride_NearColor;
			this.bOverride_FarColor = bOverride_FarColor;
			this.bOverride_NearFarDistance = bOverride_NearFarDistance;
			this.bOverride_Saturation = bOverride_Saturation;
			this.LineRadius = LineRadius;
			this.DistanceRatio = DistanceRatio;
			this.LinePower = LinePower;
			this.NearColor = NearColor;
			this.FarColor = FarColor;
			this.NearFarDistance = NearFarDistance;
			this.Saturation = Saturation;
		}

		// Token: 0x0601B58A RID: 112010 RVA: 0x002849B8 File Offset: 0x00282BB8
		protected override IntPtr GetUStructPtr()
		{
			return FKuroTreeSetting.StaticStruct();
		}

		// Token: 0x0601B58B RID: 112011 RVA: 0x002849C4 File Offset: 0x00282BC4
		[NullableContext(2)]
		public FKuroTreeSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B58C RID: 112012 RVA: 0x002849CE File Offset: 0x00282BCE
		public FKuroTreeSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B58D RID: 112013 RVA: 0x002849D9 File Offset: 0x00282BD9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroTreeSetting(Pointer, false, true);
		}

		// Token: 0x0601B58E RID: 112014 RVA: 0x002849E3 File Offset: 0x00282BE3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroTreeSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400EB81 RID: 60289
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroTreeSetting";

		// Token: 0x0400EB82 RID: 60290
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EB83 RID: 60291
		internal static int __PropertyOffset_bOverride_LineRadius;

		// Token: 0x0400EB84 RID: 60292
		internal static byte __PropertyMask_bOverride_LineRadius;

		// Token: 0x0400EB85 RID: 60293
		internal static int __PropertyOffset_bOverride_DistanceRatio;

		// Token: 0x0400EB86 RID: 60294
		internal static byte __PropertyMask_bOverride_DistanceRatio;

		// Token: 0x0400EB87 RID: 60295
		internal static int __PropertyOffset_bOverride_LinePower;

		// Token: 0x0400EB88 RID: 60296
		internal static byte __PropertyMask_bOverride_LinePower;

		// Token: 0x0400EB89 RID: 60297
		internal static int __PropertyOffset_bOverride_NearColor;

		// Token: 0x0400EB8A RID: 60298
		internal static byte __PropertyMask_bOverride_NearColor;

		// Token: 0x0400EB8B RID: 60299
		internal static int __PropertyOffset_bOverride_FarColor;

		// Token: 0x0400EB8C RID: 60300
		internal static byte __PropertyMask_bOverride_FarColor;

		// Token: 0x0400EB8D RID: 60301
		internal static int __PropertyOffset_bOverride_NearFarDistance;

		// Token: 0x0400EB8E RID: 60302
		internal static byte __PropertyMask_bOverride_NearFarDistance;

		// Token: 0x0400EB8F RID: 60303
		internal static int __PropertyOffset_bOverride_Saturation;

		// Token: 0x0400EB90 RID: 60304
		internal static byte __PropertyMask_bOverride_Saturation;

		// Token: 0x0400EB91 RID: 60305
		internal static int __PropertyOffset_LineRadius;

		// Token: 0x0400EB92 RID: 60306
		internal static int __PropertyOffset_DistanceRatio;

		// Token: 0x0400EB93 RID: 60307
		internal static int __PropertyOffset_LinePower;

		// Token: 0x0400EB94 RID: 60308
		internal static int __PropertyOffset_NearColor;

		// Token: 0x0400EB95 RID: 60309
		internal static int __PropertyOffset_FarColor;

		// Token: 0x0400EB96 RID: 60310
		internal static int __PropertyOffset_NearFarDistance;

		// Token: 0x0400EB97 RID: 60311
		internal static int __PropertyOffset_Saturation;
	}
}
