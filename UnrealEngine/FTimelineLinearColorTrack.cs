using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011EE RID: 4590
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.TimelineLinearColorTrack")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FTimelineLinearColorTrack : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010EB3 RID: 69299 RVA: 0x0018D5EF File Offset: 0x0018B7EF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTimelineLinearColorTrack._ScriptStructPtr != 0) ? FTimelineLinearColorTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TimelineLinearColorTrack", ref FTimelineLinearColorTrack._ScriptStructPtr);
		}

		// Token: 0x17004218 RID: 16920
		// (get) Token: 0x06010EB4 RID: 69300 RVA: 0x0018D613 File Offset: 0x0018B813
		// (set) Token: 0x06010EB5 RID: 69301 RVA: 0x0018D627 File Offset: 0x0018B827
		[Nullable(2)]
		public unsafe UCurveLinearColor LinearColorCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + FTimelineLinearColorTrack.__PropertyOffset_LinearColorCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FTimelineLinearColorTrack.__PropertyOffset_LinearColorCurve, value);
			}
		}

		// Token: 0x17004219 RID: 16921
		// (get) Token: 0x06010EB6 RID: 69302 RVA: 0x0018D63C File Offset: 0x0018B83C
		// (set) Token: 0x06010EB7 RID: 69303 RVA: 0x0018D67F File Offset: 0x0018B87F
		public FOnTimelineLinearColor InterpFunc
		{
			get
			{
				base.FastCheckIsValid();
				FOnTimelineLinearColor result;
				if ((result = this._InterpFunc) == null)
				{
					result = (this._InterpFunc = new FOnTimelineLinearColor(base.NativePtr + (IntPtr)FTimelineLinearColorTrack.__PropertyOffset_InterpFunc, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)FTimelineLinearColorTrack.__PropertyOffset_InterpFunc, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700421A RID: 16922
		// (get) Token: 0x06010EB8 RID: 69304 RVA: 0x0018D6A0 File Offset: 0x0018B8A0
		// (set) Token: 0x06010EB9 RID: 69305 RVA: 0x0018D6B4 File Offset: 0x0018B8B4
		public unsafe FName TrackName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTimelineLinearColorTrack.__PropertyOffset_TrackName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTimelineLinearColorTrack.__PropertyOffset_TrackName) = value;
			}
		}

		// Token: 0x1700421B RID: 16923
		// (get) Token: 0x06010EBA RID: 69306 RVA: 0x0018D6C9 File Offset: 0x0018B8C9
		// (set) Token: 0x06010EBB RID: 69307 RVA: 0x0018D6DD File Offset: 0x0018B8DD
		public unsafe FName LinearColorPropertyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTimelineLinearColorTrack.__PropertyOffset_LinearColorPropertyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTimelineLinearColorTrack.__PropertyOffset_LinearColorPropertyName) = value;
			}
		}

		// Token: 0x06010EBC RID: 69308 RVA: 0x0018D6F2 File Offset: 0x0018B8F2
		public FTimelineLinearColorTrack()
		{
		}

		// Token: 0x06010EBD RID: 69309 RVA: 0x0018D6FA File Offset: 0x0018B8FA
		public FTimelineLinearColorTrack(UCurveLinearColor LinearColorCurve, FOnTimelineLinearColor InterpFunc, FName TrackName, FName LinearColorPropertyName)
		{
			this.LinearColorCurve = LinearColorCurve;
			this.InterpFunc = InterpFunc;
			this.TrackName = TrackName;
			this.LinearColorPropertyName = LinearColorPropertyName;
		}

		// Token: 0x06010EBE RID: 69310 RVA: 0x0018D71F File Offset: 0x0018B91F
		protected override IntPtr GetUStructPtr()
		{
			return FTimelineLinearColorTrack.StaticStruct();
		}

		// Token: 0x06010EBF RID: 69311 RVA: 0x0018D72B File Offset: 0x0018B92B
		[NullableContext(2)]
		public FTimelineLinearColorTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010EC0 RID: 69312 RVA: 0x0018D735 File Offset: 0x0018B935
		public FTimelineLinearColorTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010EC1 RID: 69313 RVA: 0x0018D740 File Offset: 0x0018B940
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTimelineLinearColorTrack(Pointer, false, true);
		}

		// Token: 0x06010EC2 RID: 69314 RVA: 0x0018D74A File Offset: 0x0018B94A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTimelineLinearColorTrack(Pointer, MemoryOwner);
		}

		// Token: 0x040090FF RID: 37119
		public const string __ObjectPath = "/Script/Engine.TimelineLinearColorTrack";

		// Token: 0x04009100 RID: 37120
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009101 RID: 37121
		internal static int __PropertyOffset_LinearColorCurve;

		// Token: 0x04009102 RID: 37122
		internal static int __PropertyOffset_InterpFunc;

		// Token: 0x04009103 RID: 37123
		[Nullable(2)]
		private FOnTimelineLinearColor _InterpFunc;

		// Token: 0x04009104 RID: 37124
		internal static int __PropertyOffset_TrackName;

		// Token: 0x04009105 RID: 37125
		internal static int __PropertyOffset_LinearColorPropertyName;
	}
}
