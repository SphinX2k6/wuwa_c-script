using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200026B RID: 619
	[UnrealObjectPath("/Script/Engine.PredictProjectilePathParams")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FPredictProjectilePathParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003D76 RID: 15734 RVA: 0x00058A69 File Offset: 0x00056C69
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPredictProjectilePathParams._ScriptStructPtr != 0) ? FPredictProjectilePathParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PredictProjectilePathParams", ref FPredictProjectilePathParams._ScriptStructPtr);
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06003D77 RID: 15735 RVA: 0x00058A8D File Offset: 0x00056C8D
		// (set) Token: 0x06003D78 RID: 15736 RVA: 0x00058AA1 File Offset: 0x00056CA1
		public unsafe FVector StartLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_StartLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_StartLocation) = value;
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06003D79 RID: 15737 RVA: 0x00058AB6 File Offset: 0x00056CB6
		// (set) Token: 0x06003D7A RID: 15738 RVA: 0x00058ACA File Offset: 0x00056CCA
		public unsafe FVector LaunchVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_LaunchVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_LaunchVelocity) = value;
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06003D7B RID: 15739 RVA: 0x00058ADF File Offset: 0x00056CDF
		// (set) Token: 0x06003D7C RID: 15740 RVA: 0x00058AEF File Offset: 0x00056CEF
		public unsafe bool bTraceWithCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_bTraceWithCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_bTraceWithCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06003D7D RID: 15741 RVA: 0x00058B00 File Offset: 0x00056D00
		// (set) Token: 0x06003D7E RID: 15742 RVA: 0x00058B10 File Offset: 0x00056D10
		public unsafe float ProjectileRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_ProjectileRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_ProjectileRadius) = value;
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06003D7F RID: 15743 RVA: 0x00058B21 File Offset: 0x00056D21
		// (set) Token: 0x06003D80 RID: 15744 RVA: 0x00058B31 File Offset: 0x00056D31
		public unsafe float MaxSimTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_MaxSimTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_MaxSimTime) = value;
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06003D81 RID: 15745 RVA: 0x00058B42 File Offset: 0x00056D42
		// (set) Token: 0x06003D82 RID: 15746 RVA: 0x00058B52 File Offset: 0x00056D52
		public unsafe bool bTraceWithChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_bTraceWithChannel) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_bTraceWithChannel) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06003D83 RID: 15747 RVA: 0x00058B63 File Offset: 0x00056D63
		// (set) Token: 0x06003D84 RID: 15748 RVA: 0x00058B77 File Offset: 0x00056D77
		public unsafe TEnumAsByte<ECollisionChannel> TraceChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_TraceChannel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_TraceChannel) = value;
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06003D85 RID: 15749 RVA: 0x00058B8C File Offset: 0x00056D8C
		// (set) Token: 0x06003D86 RID: 15750 RVA: 0x00058BCF File Offset: 0x00056DCF
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EObjectTypeQuery>> result;
				if ((result = this._ObjectTypes) == null)
				{
					result = (this._ObjectTypes = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_ObjectTypes, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.ObjectTypes.CopyAssign(value);
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06003D87 RID: 15751 RVA: 0x00058BE0 File Offset: 0x00056DE0
		// (set) Token: 0x06003D88 RID: 15752 RVA: 0x00058C23 File Offset: 0x00056E23
		[Nullable(1)]
		public TArray<AActor> ActorsToIgnore
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._ActorsToIgnore) == null)
				{
					result = (this._ActorsToIgnore = new TArray<AActor>(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_ActorsToIgnore, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ActorsToIgnore.CopyAssign(value);
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06003D89 RID: 15753 RVA: 0x00058C31 File Offset: 0x00056E31
		// (set) Token: 0x06003D8A RID: 15754 RVA: 0x00058C41 File Offset: 0x00056E41
		public unsafe float SimFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_SimFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_SimFrequency) = value;
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06003D8B RID: 15755 RVA: 0x00058C52 File Offset: 0x00056E52
		// (set) Token: 0x06003D8C RID: 15756 RVA: 0x00058C62 File Offset: 0x00056E62
		public unsafe float OverrideGravityZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_OverrideGravityZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_OverrideGravityZ) = value;
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06003D8D RID: 15757 RVA: 0x00058C73 File Offset: 0x00056E73
		// (set) Token: 0x06003D8E RID: 15758 RVA: 0x00058C87 File Offset: 0x00056E87
		public unsafe TEnumAsByte<EDrawDebugTrace> DrawDebugType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_DrawDebugType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_DrawDebugType) = value;
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06003D8F RID: 15759 RVA: 0x00058C9C File Offset: 0x00056E9C
		// (set) Token: 0x06003D90 RID: 15760 RVA: 0x00058CAC File Offset: 0x00056EAC
		public unsafe float DrawDebugTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_DrawDebugTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_DrawDebugTime) = value;
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06003D91 RID: 15761 RVA: 0x00058CBD File Offset: 0x00056EBD
		// (set) Token: 0x06003D92 RID: 15762 RVA: 0x00058CCD File Offset: 0x00056ECD
		public unsafe bool bTraceComplex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_bTraceComplex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_bTraceComplex) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06003D93 RID: 15763 RVA: 0x00058CDE File Offset: 0x00056EDE
		// (set) Token: 0x06003D94 RID: 15764 RVA: 0x00058CEE File Offset: 0x00056EEE
		public unsafe bool bOverrideGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_bOverrideGravity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_bOverrideGravity) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06003D95 RID: 15765 RVA: 0x00058CFF File Offset: 0x00056EFF
		// (set) Token: 0x06003D96 RID: 15766 RVA: 0x00058D13 File Offset: 0x00056F13
		public unsafe FVector OverrideGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_OverrideGravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_OverrideGravity) = value;
			}
		}

		// Token: 0x06003D97 RID: 15767 RVA: 0x00058D28 File Offset: 0x00056F28
		public FPredictProjectilePathParams()
		{
		}

		// Token: 0x06003D98 RID: 15768 RVA: 0x00058D30 File Offset: 0x00056F30
		protected override IntPtr GetUStructPtr()
		{
			return FPredictProjectilePathParams.StaticStruct();
		}

		// Token: 0x06003D99 RID: 15769 RVA: 0x00058D3C File Offset: 0x00056F3C
		[NullableContext(2)]
		public FPredictProjectilePathParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003D9A RID: 15770 RVA: 0x00058D46 File Offset: 0x00056F46
		public FPredictProjectilePathParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003D9B RID: 15771 RVA: 0x00058D51 File Offset: 0x00056F51
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPredictProjectilePathParams(Pointer, false, true);
		}

		// Token: 0x06003D9C RID: 15772 RVA: 0x00058D5B File Offset: 0x00056F5B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPredictProjectilePathParams(Pointer, MemoryOwner);
		}

		// Token: 0x040017FA RID: 6138
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PredictProjectilePathParams";

		// Token: 0x040017FB RID: 6139
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040017FC RID: 6140
		internal static int __PropertyOffset_StartLocation;

		// Token: 0x040017FD RID: 6141
		internal static int __PropertyOffset_LaunchVelocity;

		// Token: 0x040017FE RID: 6142
		internal static int __PropertyOffset_bTraceWithCollision;

		// Token: 0x040017FF RID: 6143
		internal static int __PropertyOffset_ProjectileRadius;

		// Token: 0x04001800 RID: 6144
		internal static int __PropertyOffset_MaxSimTime;

		// Token: 0x04001801 RID: 6145
		internal static int __PropertyOffset_bTraceWithChannel;

		// Token: 0x04001802 RID: 6146
		internal static int __PropertyOffset_TraceChannel;

		// Token: 0x04001803 RID: 6147
		internal static int __PropertyOffset_ObjectTypes;

		// Token: 0x04001804 RID: 6148
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _ObjectTypes;

		// Token: 0x04001805 RID: 6149
		internal static int __PropertyOffset_ActorsToIgnore;

		// Token: 0x04001806 RID: 6150
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _ActorsToIgnore;

		// Token: 0x04001807 RID: 6151
		internal static int __PropertyOffset_SimFrequency;

		// Token: 0x04001808 RID: 6152
		internal static int __PropertyOffset_OverrideGravityZ;

		// Token: 0x04001809 RID: 6153
		internal static int __PropertyOffset_DrawDebugType;

		// Token: 0x0400180A RID: 6154
		internal static int __PropertyOffset_DrawDebugTime;

		// Token: 0x0400180B RID: 6155
		internal static int __PropertyOffset_bTraceComplex;

		// Token: 0x0400180C RID: 6156
		internal static int __PropertyOffset_bOverrideGravity;

		// Token: 0x0400180D RID: 6157
		internal static int __PropertyOffset_OverrideGravity;
	}
}
