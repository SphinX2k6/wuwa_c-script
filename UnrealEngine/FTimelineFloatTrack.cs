using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011ED RID: 4589
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.TimelineFloatTrack")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FTimelineFloatTrack : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010EA3 RID: 69283 RVA: 0x0018D48A File Offset: 0x0018B68A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTimelineFloatTrack._ScriptStructPtr != 0) ? FTimelineFloatTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TimelineFloatTrack", ref FTimelineFloatTrack._ScriptStructPtr);
		}

		// Token: 0x17004214 RID: 16916
		// (get) Token: 0x06010EA4 RID: 69284 RVA: 0x0018D4AE File Offset: 0x0018B6AE
		// (set) Token: 0x06010EA5 RID: 69285 RVA: 0x0018D4C2 File Offset: 0x0018B6C2
		[Nullable(2)]
		public unsafe UCurveFloat FloatCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FTimelineFloatTrack.__PropertyOffset_FloatCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FTimelineFloatTrack.__PropertyOffset_FloatCurve, value);
			}
		}

		// Token: 0x17004215 RID: 16917
		// (get) Token: 0x06010EA6 RID: 69286 RVA: 0x0018D4D8 File Offset: 0x0018B6D8
		// (set) Token: 0x06010EA7 RID: 69287 RVA: 0x0018D51B File Offset: 0x0018B71B
		public FOnTimelineFloat InterpFunc
		{
			get
			{
				base.FastCheckIsValid();
				FOnTimelineFloat result;
				if ((result = this._InterpFunc) == null)
				{
					result = (this._InterpFunc = new FOnTimelineFloat(base.NativePtr + (IntPtr)FTimelineFloatTrack.__PropertyOffset_InterpFunc, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)FTimelineFloatTrack.__PropertyOffset_InterpFunc, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004216 RID: 16918
		// (get) Token: 0x06010EA8 RID: 69288 RVA: 0x0018D53C File Offset: 0x0018B73C
		// (set) Token: 0x06010EA9 RID: 69289 RVA: 0x0018D550 File Offset: 0x0018B750
		public unsafe FName TrackName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTimelineFloatTrack.__PropertyOffset_TrackName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTimelineFloatTrack.__PropertyOffset_TrackName) = value;
			}
		}

		// Token: 0x17004217 RID: 16919
		// (get) Token: 0x06010EAA RID: 69290 RVA: 0x0018D565 File Offset: 0x0018B765
		// (set) Token: 0x06010EAB RID: 69291 RVA: 0x0018D579 File Offset: 0x0018B779
		public unsafe FName FloatPropertyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTimelineFloatTrack.__PropertyOffset_FloatPropertyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTimelineFloatTrack.__PropertyOffset_FloatPropertyName) = value;
			}
		}

		// Token: 0x06010EAC RID: 69292 RVA: 0x0018D58E File Offset: 0x0018B78E
		public FTimelineFloatTrack()
		{
		}

		// Token: 0x06010EAD RID: 69293 RVA: 0x0018D596 File Offset: 0x0018B796
		public FTimelineFloatTrack(UCurveFloat FloatCurve, FOnTimelineFloat InterpFunc, FName TrackName, FName FloatPropertyName)
		{
			this.FloatCurve = FloatCurve;
			this.InterpFunc = InterpFunc;
			this.TrackName = TrackName;
			this.FloatPropertyName = FloatPropertyName;
		}

		// Token: 0x06010EAE RID: 69294 RVA: 0x0018D5BB File Offset: 0x0018B7BB
		protected override IntPtr GetUStructPtr()
		{
			return FTimelineFloatTrack.StaticStruct();
		}

		// Token: 0x06010EAF RID: 69295 RVA: 0x0018D5C7 File Offset: 0x0018B7C7
		[NullableContext(2)]
		public FTimelineFloatTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010EB0 RID: 69296 RVA: 0x0018D5D1 File Offset: 0x0018B7D1
		public FTimelineFloatTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010EB1 RID: 69297 RVA: 0x0018D5DC File Offset: 0x0018B7DC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTimelineFloatTrack(Pointer, false, true);
		}

		// Token: 0x06010EB2 RID: 69298 RVA: 0x0018D5E6 File Offset: 0x0018B7E6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTimelineFloatTrack(Pointer, MemoryOwner);
		}

		// Token: 0x040090F8 RID: 37112
		public const string __ObjectPath = "/Script/Engine.TimelineFloatTrack";

		// Token: 0x040090F9 RID: 37113
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040090FA RID: 37114
		internal static int __PropertyOffset_FloatCurve;

		// Token: 0x040090FB RID: 37115
		internal static int __PropertyOffset_InterpFunc;

		// Token: 0x040090FC RID: 37116
		[Nullable(2)]
		private FOnTimelineFloat _InterpFunc;

		// Token: 0x040090FD RID: 37117
		internal static int __PropertyOffset_TrackName;

		// Token: 0x040090FE RID: 37118
		internal static int __PropertyOffset_FloatPropertyName;
	}
}
