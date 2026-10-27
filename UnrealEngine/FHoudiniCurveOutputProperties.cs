using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020014BF RID: 5311
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniCurveOutputProperties")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FHoudiniCurveOutputProperties : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06013389 RID: 78729 RVA: 0x001C4527 File Offset: 0x001C2727
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHoudiniCurveOutputProperties._ScriptStructPtr != 0) ? FHoudiniCurveOutputProperties._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.HoudiniCurveOutputProperties", ref FHoudiniCurveOutputProperties._ScriptStructPtr);
		}

		// Token: 0x17004ABE RID: 19134
		// (get) Token: 0x0601338A RID: 78730 RVA: 0x001C454B File Offset: 0x001C274B
		// (set) Token: 0x0601338B RID: 78731 RVA: 0x001C455B File Offset: 0x001C275B
		public unsafe EHoudiniCurveOutputType CurveOutputType
		{
			get
			{
				return (EHoudiniCurveOutputType)(*(base.NativePtr + (IntPtr)FHoudiniCurveOutputProperties.__PropertyOffset_CurveOutputType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniCurveOutputProperties.__PropertyOffset_CurveOutputType) = (byte)value;
			}
		}

		// Token: 0x17004ABF RID: 19135
		// (get) Token: 0x0601338C RID: 78732 RVA: 0x001C456C File Offset: 0x001C276C
		// (set) Token: 0x0601338D RID: 78733 RVA: 0x001C457C File Offset: 0x001C277C
		public unsafe int NumPoints
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniCurveOutputProperties.__PropertyOffset_NumPoints);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniCurveOutputProperties.__PropertyOffset_NumPoints) = value;
			}
		}

		// Token: 0x17004AC0 RID: 19136
		// (get) Token: 0x0601338E RID: 78734 RVA: 0x001C458D File Offset: 0x001C278D
		// (set) Token: 0x0601338F RID: 78735 RVA: 0x001C459D File Offset: 0x001C279D
		public unsafe bool bClosed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniCurveOutputProperties.__PropertyOffset_bClosed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniCurveOutputProperties.__PropertyOffset_bClosed) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AC1 RID: 19137
		// (get) Token: 0x06013390 RID: 78736 RVA: 0x001C45AE File Offset: 0x001C27AE
		// (set) Token: 0x06013391 RID: 78737 RVA: 0x001C45BE File Offset: 0x001C27BE
		public unsafe EHoudiniCurveType CurveType
		{
			get
			{
				return (EHoudiniCurveType)(*(base.NativePtr + (IntPtr)FHoudiniCurveOutputProperties.__PropertyOffset_CurveType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniCurveOutputProperties.__PropertyOffset_CurveType) = (byte)value;
			}
		}

		// Token: 0x17004AC2 RID: 19138
		// (get) Token: 0x06013392 RID: 78738 RVA: 0x001C45CF File Offset: 0x001C27CF
		// (set) Token: 0x06013393 RID: 78739 RVA: 0x001C45DF File Offset: 0x001C27DF
		public unsafe EHoudiniCurveMethod CurveMethod
		{
			get
			{
				return (EHoudiniCurveMethod)(*(base.NativePtr + (IntPtr)FHoudiniCurveOutputProperties.__PropertyOffset_CurveMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniCurveOutputProperties.__PropertyOffset_CurveMethod) = (byte)value;
			}
		}

		// Token: 0x06013394 RID: 78740 RVA: 0x001C45F0 File Offset: 0x001C27F0
		public FHoudiniCurveOutputProperties()
		{
		}

		// Token: 0x06013395 RID: 78741 RVA: 0x001C45F8 File Offset: 0x001C27F8
		public FHoudiniCurveOutputProperties(EHoudiniCurveOutputType CurveOutputType, int NumPoints, bool bClosed, EHoudiniCurveType CurveType, EHoudiniCurveMethod CurveMethod)
		{
			this.CurveOutputType = CurveOutputType;
			this.NumPoints = NumPoints;
			this.bClosed = bClosed;
			this.CurveType = CurveType;
			this.CurveMethod = CurveMethod;
		}

		// Token: 0x06013396 RID: 78742 RVA: 0x001C4625 File Offset: 0x001C2825
		protected override IntPtr GetUStructPtr()
		{
			return FHoudiniCurveOutputProperties.StaticStruct();
		}

		// Token: 0x06013397 RID: 78743 RVA: 0x001C4631 File Offset: 0x001C2831
		[NullableContext(2)]
		public FHoudiniCurveOutputProperties(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06013398 RID: 78744 RVA: 0x001C463B File Offset: 0x001C283B
		public FHoudiniCurveOutputProperties(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013399 RID: 78745 RVA: 0x001C4646 File Offset: 0x001C2846
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHoudiniCurveOutputProperties(Pointer, false, true);
		}

		// Token: 0x0601339A RID: 78746 RVA: 0x001C4650 File Offset: 0x001C2850
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHoudiniCurveOutputProperties(Pointer, MemoryOwner);
		}

		// Token: 0x0400A612 RID: 42514
		[Nullable(1)]
		public const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniCurveOutputProperties";

		// Token: 0x0400A613 RID: 42515
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A614 RID: 42516
		internal static int __PropertyOffset_CurveOutputType;

		// Token: 0x0400A615 RID: 42517
		internal static int __PropertyOffset_NumPoints;

		// Token: 0x0400A616 RID: 42518
		internal static int __PropertyOffset_bClosed;

		// Token: 0x0400A617 RID: 42519
		internal static int __PropertyOffset_CurveType;

		// Token: 0x0400A618 RID: 42520
		internal static int __PropertyOffset_CurveMethod;
	}
}
