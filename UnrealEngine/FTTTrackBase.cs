using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200120D RID: 4621
	[UnrealObjectPath("/Script/Engine.TTTrackBase")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FTTTrackBase : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601104A RID: 69706 RVA: 0x0018F897 File Offset: 0x0018DA97
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTTTrackBase._ScriptStructPtr != 0) ? FTTTrackBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TTTrackBase", ref FTTTrackBase._ScriptStructPtr);
		}

		// Token: 0x17004276 RID: 17014
		// (get) Token: 0x0601104B RID: 69707 RVA: 0x0018F8BB File Offset: 0x0018DABB
		// (set) Token: 0x0601104C RID: 69708 RVA: 0x0018F8CF File Offset: 0x0018DACF
		public unsafe FName TrackName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTTTrackBase.__PropertyOffset_TrackName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTTTrackBase.__PropertyOffset_TrackName) = value;
			}
		}

		// Token: 0x17004277 RID: 17015
		// (get) Token: 0x0601104D RID: 69709 RVA: 0x0018F8E4 File Offset: 0x0018DAE4
		// (set) Token: 0x0601104E RID: 69710 RVA: 0x0018F8F4 File Offset: 0x0018DAF4
		public unsafe bool bIsExternalCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTTTrackBase.__PropertyOffset_bIsExternalCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTTTrackBase.__PropertyOffset_bIsExternalCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601104F RID: 69711 RVA: 0x0018F905 File Offset: 0x0018DB05
		public FTTTrackBase()
		{
		}

		// Token: 0x06011050 RID: 69712 RVA: 0x0018F90D File Offset: 0x0018DB0D
		public FTTTrackBase(FName TrackName, bool bIsExternalCurve, bool bIsExpanded, bool bIsCurveViewSynchronized)
		{
			this.TrackName = TrackName;
			this.bIsExternalCurve = bIsExternalCurve;
		}

		// Token: 0x06011051 RID: 69713 RVA: 0x0018F923 File Offset: 0x0018DB23
		protected override IntPtr GetUStructPtr()
		{
			return FTTTrackBase.StaticStruct();
		}

		// Token: 0x06011052 RID: 69714 RVA: 0x0018F92F File Offset: 0x0018DB2F
		[NullableContext(2)]
		public FTTTrackBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011053 RID: 69715 RVA: 0x0018F939 File Offset: 0x0018DB39
		public FTTTrackBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011054 RID: 69716 RVA: 0x0018F944 File Offset: 0x0018DB44
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTTTrackBase(Pointer, false, true);
		}

		// Token: 0x06011055 RID: 69717 RVA: 0x0018F94E File Offset: 0x0018DB4E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTTTrackBase(Pointer, MemoryOwner);
		}

		// Token: 0x040091C7 RID: 37319
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.TTTrackBase";

		// Token: 0x040091C8 RID: 37320
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040091C9 RID: 37321
		internal static int __PropertyOffset_TrackName;

		// Token: 0x040091CA RID: 37322
		internal static int __PropertyOffset_bIsExternalCurve;
	}
}
