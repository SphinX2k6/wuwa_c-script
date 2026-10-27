using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200120C RID: 4620
	[UnrealObjectPath("/Script/Engine.TTPropertyTrack")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FTTPropertyTrack : FTTTrackBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011040 RID: 69696 RVA: 0x0018F7F1 File Offset: 0x0018D9F1
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTTPropertyTrack._ScriptStructPtr != 0) ? FTTPropertyTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TTPropertyTrack", ref FTTPropertyTrack._ScriptStructPtr);
		}

		// Token: 0x17004275 RID: 17013
		// (get) Token: 0x06011041 RID: 69697 RVA: 0x0018F815 File Offset: 0x0018DA15
		// (set) Token: 0x06011042 RID: 69698 RVA: 0x0018F829 File Offset: 0x0018DA29
		public unsafe FName PropertyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTTPropertyTrack.__PropertyOffset_PropertyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTTPropertyTrack.__PropertyOffset_PropertyName) = value;
			}
		}

		// Token: 0x06011043 RID: 69699 RVA: 0x0018F83E File Offset: 0x0018DA3E
		public FTTPropertyTrack()
		{
		}

		// Token: 0x06011044 RID: 69700 RVA: 0x0018F846 File Offset: 0x0018DA46
		public FTTPropertyTrack(FName PropertyName, FName TrackName, bool bIsExternalCurve, bool bIsExpanded, bool bIsCurveViewSynchronized)
		{
			this.PropertyName = PropertyName;
			base.TrackName = TrackName;
			base.bIsExternalCurve = bIsExternalCurve;
		}

		// Token: 0x06011045 RID: 69701 RVA: 0x0018F863 File Offset: 0x0018DA63
		protected override IntPtr GetUStructPtr()
		{
			return FTTPropertyTrack.StaticStruct();
		}

		// Token: 0x06011046 RID: 69702 RVA: 0x0018F86F File Offset: 0x0018DA6F
		[NullableContext(2)]
		public FTTPropertyTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011047 RID: 69703 RVA: 0x0018F879 File Offset: 0x0018DA79
		public FTTPropertyTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011048 RID: 69704 RVA: 0x0018F884 File Offset: 0x0018DA84
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTTPropertyTrack(Pointer, false, true);
		}

		// Token: 0x06011049 RID: 69705 RVA: 0x0018F88E File Offset: 0x0018DA8E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTTPropertyTrack(Pointer, MemoryOwner);
		}

		// Token: 0x040091C4 RID: 37316
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TTPropertyTrack";

		// Token: 0x040091C5 RID: 37317
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040091C6 RID: 37318
		internal static int __PropertyOffset_PropertyName;
	}
}
