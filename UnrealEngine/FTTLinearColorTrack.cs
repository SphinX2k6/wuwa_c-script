using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200120B RID: 4619
	[UnrealObjectPath("/Script/Engine.TTLinearColorTrack")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FTTLinearColorTrack : FTTPropertyTrack, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011036 RID: 69686 RVA: 0x0018F743 File Offset: 0x0018D943
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTTLinearColorTrack._ScriptStructPtr != 0) ? FTTLinearColorTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TTLinearColorTrack", ref FTTLinearColorTrack._ScriptStructPtr);
		}

		// Token: 0x17004274 RID: 17012
		// (get) Token: 0x06011037 RID: 69687 RVA: 0x0018F767 File Offset: 0x0018D967
		// (set) Token: 0x06011038 RID: 69688 RVA: 0x0018F77B File Offset: 0x0018D97B
		[Nullable(2)]
		public unsafe UCurveLinearColor CurveLinearColor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + FTTLinearColorTrack.__PropertyOffset_CurveLinearColor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FTTLinearColorTrack.__PropertyOffset_CurveLinearColor, value);
			}
		}

		// Token: 0x06011039 RID: 69689 RVA: 0x0018F790 File Offset: 0x0018D990
		public FTTLinearColorTrack()
		{
		}

		// Token: 0x0601103A RID: 69690 RVA: 0x0018F798 File Offset: 0x0018D998
		[NullableContext(1)]
		public FTTLinearColorTrack(UCurveLinearColor CurveLinearColor, FName PropertyName, FName TrackName, bool bIsExternalCurve, bool bIsExpanded, bool bIsCurveViewSynchronized)
		{
			this.CurveLinearColor = CurveLinearColor;
			base.PropertyName = PropertyName;
			base.TrackName = TrackName;
			base.bIsExternalCurve = bIsExternalCurve;
		}

		// Token: 0x0601103B RID: 69691 RVA: 0x0018F7BD File Offset: 0x0018D9BD
		protected override IntPtr GetUStructPtr()
		{
			return FTTLinearColorTrack.StaticStruct();
		}

		// Token: 0x0601103C RID: 69692 RVA: 0x0018F7C9 File Offset: 0x0018D9C9
		[NullableContext(2)]
		public FTTLinearColorTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601103D RID: 69693 RVA: 0x0018F7D3 File Offset: 0x0018D9D3
		public FTTLinearColorTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601103E RID: 69694 RVA: 0x0018F7DE File Offset: 0x0018D9DE
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTTLinearColorTrack(Pointer, false, true);
		}

		// Token: 0x0601103F RID: 69695 RVA: 0x0018F7E8 File Offset: 0x0018D9E8
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTTLinearColorTrack(Pointer, MemoryOwner);
		}

		// Token: 0x040091C1 RID: 37313
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TTLinearColorTrack";

		// Token: 0x040091C2 RID: 37314
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040091C3 RID: 37315
		internal static int __PropertyOffset_CurveLinearColor;
	}
}
