using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011F0 RID: 4592
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.TimelineVectorTrack")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FTimelineVectorTrack : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010EE8 RID: 69352 RVA: 0x0018DB77 File Offset: 0x0018BD77
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTimelineVectorTrack._ScriptStructPtr != 0) ? FTimelineVectorTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TimelineVectorTrack", ref FTimelineVectorTrack._ScriptStructPtr);
		}

		// Token: 0x1700422C RID: 16940
		// (get) Token: 0x06010EE9 RID: 69353 RVA: 0x0018DB9B File Offset: 0x0018BD9B
		// (set) Token: 0x06010EEA RID: 69354 RVA: 0x0018DBAF File Offset: 0x0018BDAF
		[Nullable(2)]
		public unsafe UCurveVector VectorCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + FTimelineVectorTrack.__PropertyOffset_VectorCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FTimelineVectorTrack.__PropertyOffset_VectorCurve, value);
			}
		}

		// Token: 0x1700422D RID: 16941
		// (get) Token: 0x06010EEB RID: 69355 RVA: 0x0018DBC4 File Offset: 0x0018BDC4
		// (set) Token: 0x06010EEC RID: 69356 RVA: 0x0018DC07 File Offset: 0x0018BE07
		public FOnTimelineVector InterpFunc
		{
			get
			{
				base.FastCheckIsValid();
				FOnTimelineVector result;
				if ((result = this._InterpFunc) == null)
				{
					result = (this._InterpFunc = new FOnTimelineVector(base.NativePtr + (IntPtr)FTimelineVectorTrack.__PropertyOffset_InterpFunc, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)FTimelineVectorTrack.__PropertyOffset_InterpFunc, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700422E RID: 16942
		// (get) Token: 0x06010EED RID: 69357 RVA: 0x0018DC28 File Offset: 0x0018BE28
		// (set) Token: 0x06010EEE RID: 69358 RVA: 0x0018DC3C File Offset: 0x0018BE3C
		public unsafe FName TrackName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTimelineVectorTrack.__PropertyOffset_TrackName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTimelineVectorTrack.__PropertyOffset_TrackName) = value;
			}
		}

		// Token: 0x1700422F RID: 16943
		// (get) Token: 0x06010EEF RID: 69359 RVA: 0x0018DC51 File Offset: 0x0018BE51
		// (set) Token: 0x06010EF0 RID: 69360 RVA: 0x0018DC65 File Offset: 0x0018BE65
		public unsafe FName VectorPropertyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTimelineVectorTrack.__PropertyOffset_VectorPropertyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTimelineVectorTrack.__PropertyOffset_VectorPropertyName) = value;
			}
		}

		// Token: 0x06010EF1 RID: 69361 RVA: 0x0018DC7A File Offset: 0x0018BE7A
		public FTimelineVectorTrack()
		{
		}

		// Token: 0x06010EF2 RID: 69362 RVA: 0x0018DC82 File Offset: 0x0018BE82
		public FTimelineVectorTrack(UCurveVector VectorCurve, FOnTimelineVector InterpFunc, FName TrackName, FName VectorPropertyName)
		{
			this.VectorCurve = VectorCurve;
			this.InterpFunc = InterpFunc;
			this.TrackName = TrackName;
			this.VectorPropertyName = VectorPropertyName;
		}

		// Token: 0x06010EF3 RID: 69363 RVA: 0x0018DCA7 File Offset: 0x0018BEA7
		protected override IntPtr GetUStructPtr()
		{
			return FTimelineVectorTrack.StaticStruct();
		}

		// Token: 0x06010EF4 RID: 69364 RVA: 0x0018DCB3 File Offset: 0x0018BEB3
		[NullableContext(2)]
		public FTimelineVectorTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010EF5 RID: 69365 RVA: 0x0018DCBD File Offset: 0x0018BEBD
		public FTimelineVectorTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010EF6 RID: 69366 RVA: 0x0018DCC8 File Offset: 0x0018BEC8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTimelineVectorTrack(Pointer, false, true);
		}

		// Token: 0x06010EF7 RID: 69367 RVA: 0x0018DCD2 File Offset: 0x0018BED2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTimelineVectorTrack(Pointer, MemoryOwner);
		}

		// Token: 0x04009122 RID: 37154
		public const string __ObjectPath = "/Script/Engine.TimelineVectorTrack";

		// Token: 0x04009123 RID: 37155
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009124 RID: 37156
		internal static int __PropertyOffset_VectorCurve;

		// Token: 0x04009125 RID: 37157
		internal static int __PropertyOffset_InterpFunc;

		// Token: 0x04009126 RID: 37158
		[Nullable(2)]
		private FOnTimelineVector _InterpFunc;

		// Token: 0x04009127 RID: 37159
		internal static int __PropertyOffset_TrackName;

		// Token: 0x04009128 RID: 37160
		internal static int __PropertyOffset_VectorPropertyName;
	}
}
