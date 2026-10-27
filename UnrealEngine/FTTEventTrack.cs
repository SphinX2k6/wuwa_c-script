using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001209 RID: 4617
	[UnrealObjectPath("/Script/Engine.TTEventTrack")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FTTEventTrack : FTTTrackBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011020 RID: 69664 RVA: 0x0018F5BE File Offset: 0x0018D7BE
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTTEventTrack._ScriptStructPtr != 0) ? FTTEventTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TTEventTrack", ref FTTEventTrack._ScriptStructPtr);
		}

		// Token: 0x17004271 RID: 17009
		// (get) Token: 0x06011021 RID: 69665 RVA: 0x0018F5E2 File Offset: 0x0018D7E2
		// (set) Token: 0x06011022 RID: 69666 RVA: 0x0018F5F6 File Offset: 0x0018D7F6
		public unsafe FName FunctionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTTEventTrack.__PropertyOffset_FunctionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTTEventTrack.__PropertyOffset_FunctionName) = value;
			}
		}

		// Token: 0x17004272 RID: 17010
		// (get) Token: 0x06011023 RID: 69667 RVA: 0x0018F60B File Offset: 0x0018D80B
		// (set) Token: 0x06011024 RID: 69668 RVA: 0x0018F61F File Offset: 0x0018D81F
		[Nullable(2)]
		public unsafe UCurveFloat CurveKeys
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FTTEventTrack.__PropertyOffset_CurveKeys);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FTTEventTrack.__PropertyOffset_CurveKeys, value);
			}
		}

		// Token: 0x06011025 RID: 69669 RVA: 0x0018F634 File Offset: 0x0018D834
		public FTTEventTrack()
		{
		}

		// Token: 0x06011026 RID: 69670 RVA: 0x0018F63C File Offset: 0x0018D83C
		[NullableContext(1)]
		public FTTEventTrack(FName FunctionName, UCurveFloat CurveKeys, FName TrackName, bool bIsExternalCurve, bool bIsExpanded, bool bIsCurveViewSynchronized)
		{
			this.FunctionName = FunctionName;
			this.CurveKeys = CurveKeys;
			base.TrackName = TrackName;
			base.bIsExternalCurve = bIsExternalCurve;
		}

		// Token: 0x06011027 RID: 69671 RVA: 0x0018F661 File Offset: 0x0018D861
		protected override IntPtr GetUStructPtr()
		{
			return FTTEventTrack.StaticStruct();
		}

		// Token: 0x06011028 RID: 69672 RVA: 0x0018F66D File Offset: 0x0018D86D
		[NullableContext(2)]
		public FTTEventTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011029 RID: 69673 RVA: 0x0018F677 File Offset: 0x0018D877
		public FTTEventTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601102A RID: 69674 RVA: 0x0018F682 File Offset: 0x0018D882
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTTEventTrack(Pointer, false, true);
		}

		// Token: 0x0601102B RID: 69675 RVA: 0x0018F68C File Offset: 0x0018D88C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTTEventTrack(Pointer, MemoryOwner);
		}

		// Token: 0x040091BA RID: 37306
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TTEventTrack";

		// Token: 0x040091BB RID: 37307
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040091BC RID: 37308
		internal static int __PropertyOffset_FunctionName;

		// Token: 0x040091BD RID: 37309
		internal static int __PropertyOffset_CurveKeys;
	}
}
