using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F89 RID: 8073
	[UnrealObjectPath("/Script/Landscape.LandscapeSplineConnection")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FLandscapeSplineConnection : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EA76 RID: 125558 RVA: 0x002D9157 File Offset: 0x002D7357
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLandscapeSplineConnection._ScriptStructPtr != 0) ? FLandscapeSplineConnection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.LandscapeSplineConnection", ref FLandscapeSplineConnection._ScriptStructPtr);
		}

		// Token: 0x17007A12 RID: 31250
		// (get) Token: 0x0601EA77 RID: 125559 RVA: 0x002D917B File Offset: 0x002D737B
		// (set) Token: 0x0601EA78 RID: 125560 RVA: 0x002D918F File Offset: 0x002D738F
		[Nullable(2)]
		public unsafe ULandscapeSplineSegment Segment
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULandscapeSplineSegment>(base.NativePtr / (IntPtr)sizeof(void*) + FLandscapeSplineConnection.__PropertyOffset_Segment);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLandscapeSplineConnection.__PropertyOffset_Segment, value);
			}
		}

		// Token: 0x17007A13 RID: 31251
		// (get) Token: 0x0601EA79 RID: 125561 RVA: 0x002D91A4 File Offset: 0x002D73A4
		// (set) Token: 0x0601EA7A RID: 125562 RVA: 0x002D91BD File Offset: 0x002D73BD
		public unsafe bool End
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLandscapeSplineConnection.__PropertyOffset_End) & FLandscapeSplineConnection.__PropertyMask_End) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLandscapeSplineConnection.__PropertyOffset_End) = ((*(base.NativePtr + (IntPtr)FLandscapeSplineConnection.__PropertyOffset_End) & ~FLandscapeSplineConnection.__PropertyMask_End) | (value ? FLandscapeSplineConnection.__PropertyMask_End : 0));
			}
		}

		// Token: 0x0601EA7B RID: 125563 RVA: 0x002D91ED File Offset: 0x002D73ED
		public FLandscapeSplineConnection()
		{
		}

		// Token: 0x0601EA7C RID: 125564 RVA: 0x002D91F5 File Offset: 0x002D73F5
		[NullableContext(1)]
		public FLandscapeSplineConnection(ULandscapeSplineSegment Segment, bool End)
		{
			this.Segment = Segment;
			this.End = End;
		}

		// Token: 0x0601EA7D RID: 125565 RVA: 0x002D920B File Offset: 0x002D740B
		protected override IntPtr GetUStructPtr()
		{
			return FLandscapeSplineConnection.StaticStruct();
		}

		// Token: 0x0601EA7E RID: 125566 RVA: 0x002D9217 File Offset: 0x002D7417
		[NullableContext(2)]
		public FLandscapeSplineConnection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EA7F RID: 125567 RVA: 0x002D9221 File Offset: 0x002D7421
		public FLandscapeSplineConnection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EA80 RID: 125568 RVA: 0x002D922C File Offset: 0x002D742C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLandscapeSplineConnection(Pointer, false, true);
		}

		// Token: 0x0601EA81 RID: 125569 RVA: 0x002D9236 File Offset: 0x002D7436
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLandscapeSplineConnection(Pointer, MemoryOwner);
		}

		// Token: 0x04010922 RID: 67874
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Landscape.LandscapeSplineConnection";

		// Token: 0x04010923 RID: 67875
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010924 RID: 67876
		internal static int __PropertyOffset_Segment;

		// Token: 0x04010925 RID: 67877
		internal static int __PropertyOffset_End;

		// Token: 0x04010926 RID: 67878
		internal static byte __PropertyMask_End;
	}
}
