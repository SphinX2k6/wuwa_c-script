using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200120F RID: 4623
	[UnrealObjectPath("/Script/Engine.TTVectorTrack")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FTTVectorTrack : FTTPropertyTrack, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011062 RID: 69730 RVA: 0x0018FA0F File Offset: 0x0018DC0F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTTVectorTrack._ScriptStructPtr != 0) ? FTTVectorTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TTVectorTrack", ref FTTVectorTrack._ScriptStructPtr);
		}

		// Token: 0x1700427A RID: 17018
		// (get) Token: 0x06011063 RID: 69731 RVA: 0x0018FA33 File Offset: 0x0018DC33
		// (set) Token: 0x06011064 RID: 69732 RVA: 0x0018FA47 File Offset: 0x0018DC47
		[Nullable(2)]
		public unsafe UCurveVector CurveVector
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + FTTVectorTrack.__PropertyOffset_CurveVector);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FTTVectorTrack.__PropertyOffset_CurveVector, value);
			}
		}

		// Token: 0x06011065 RID: 69733 RVA: 0x0018FA5C File Offset: 0x0018DC5C
		public FTTVectorTrack()
		{
		}

		// Token: 0x06011066 RID: 69734 RVA: 0x0018FA64 File Offset: 0x0018DC64
		[NullableContext(1)]
		public FTTVectorTrack(UCurveVector CurveVector, FName PropertyName, FName TrackName, bool bIsExternalCurve, bool bIsExpanded, bool bIsCurveViewSynchronized)
		{
			this.CurveVector = CurveVector;
			base.PropertyName = PropertyName;
			base.TrackName = TrackName;
			base.bIsExternalCurve = bIsExternalCurve;
		}

		// Token: 0x06011067 RID: 69735 RVA: 0x0018FA89 File Offset: 0x0018DC89
		protected override IntPtr GetUStructPtr()
		{
			return FTTVectorTrack.StaticStruct();
		}

		// Token: 0x06011068 RID: 69736 RVA: 0x0018FA95 File Offset: 0x0018DC95
		[NullableContext(2)]
		public FTTVectorTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011069 RID: 69737 RVA: 0x0018FA9F File Offset: 0x0018DC9F
		public FTTVectorTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601106A RID: 69738 RVA: 0x0018FAAA File Offset: 0x0018DCAA
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTTVectorTrack(Pointer, false, true);
		}

		// Token: 0x0601106B RID: 69739 RVA: 0x0018FAB4 File Offset: 0x0018DCB4
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTTVectorTrack(Pointer, MemoryOwner);
		}

		// Token: 0x040091CF RID: 37327
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TTVectorTrack";

		// Token: 0x040091D0 RID: 37328
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040091D1 RID: 37329
		internal static int __PropertyOffset_CurveVector;
	}
}
