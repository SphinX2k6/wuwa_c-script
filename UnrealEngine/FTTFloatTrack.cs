using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200120A RID: 4618
	[UnrealObjectPath("/Script/Engine.TTFloatTrack")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FTTFloatTrack : FTTPropertyTrack, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601102C RID: 69676 RVA: 0x0018F695 File Offset: 0x0018D895
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTTFloatTrack._ScriptStructPtr != 0) ? FTTFloatTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TTFloatTrack", ref FTTFloatTrack._ScriptStructPtr);
		}

		// Token: 0x17004273 RID: 17011
		// (get) Token: 0x0601102D RID: 69677 RVA: 0x0018F6B9 File Offset: 0x0018D8B9
		// (set) Token: 0x0601102E RID: 69678 RVA: 0x0018F6CD File Offset: 0x0018D8CD
		[Nullable(2)]
		public unsafe UCurveFloat CurveFloat
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FTTFloatTrack.__PropertyOffset_CurveFloat);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FTTFloatTrack.__PropertyOffset_CurveFloat, value);
			}
		}

		// Token: 0x0601102F RID: 69679 RVA: 0x0018F6E2 File Offset: 0x0018D8E2
		public FTTFloatTrack()
		{
		}

		// Token: 0x06011030 RID: 69680 RVA: 0x0018F6EA File Offset: 0x0018D8EA
		[NullableContext(1)]
		public FTTFloatTrack(UCurveFloat CurveFloat, FName PropertyName, FName TrackName, bool bIsExternalCurve, bool bIsExpanded, bool bIsCurveViewSynchronized)
		{
			this.CurveFloat = CurveFloat;
			base.PropertyName = PropertyName;
			base.TrackName = TrackName;
			base.bIsExternalCurve = bIsExternalCurve;
		}

		// Token: 0x06011031 RID: 69681 RVA: 0x0018F70F File Offset: 0x0018D90F
		protected override IntPtr GetUStructPtr()
		{
			return FTTFloatTrack.StaticStruct();
		}

		// Token: 0x06011032 RID: 69682 RVA: 0x0018F71B File Offset: 0x0018D91B
		[NullableContext(2)]
		public FTTFloatTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011033 RID: 69683 RVA: 0x0018F725 File Offset: 0x0018D925
		public FTTFloatTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011034 RID: 69684 RVA: 0x0018F730 File Offset: 0x0018D930
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTTFloatTrack(Pointer, false, true);
		}

		// Token: 0x06011035 RID: 69685 RVA: 0x0018F73A File Offset: 0x0018D93A
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTTFloatTrack(Pointer, MemoryOwner);
		}

		// Token: 0x040091BE RID: 37310
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TTFloatTrack";

		// Token: 0x040091BF RID: 37311
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040091C0 RID: 37312
		internal static int __PropertyOffset_CurveFloat;
	}
}
