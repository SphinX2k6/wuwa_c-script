using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F90 RID: 8080
	[UnrealObjectPath("/Script/Landscape.LandscapeSplineSegmentConnection")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FLandscapeSplineSegmentConnection : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EAF4 RID: 125684 RVA: 0x002D9D76 File Offset: 0x002D7F76
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLandscapeSplineSegmentConnection._ScriptStructPtr != 0) ? FLandscapeSplineSegmentConnection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.LandscapeSplineSegmentConnection", ref FLandscapeSplineSegmentConnection._ScriptStructPtr);
		}

		// Token: 0x17007A3D RID: 31293
		// (get) Token: 0x0601EAF5 RID: 125685 RVA: 0x002D9D9A File Offset: 0x002D7F9A
		// (set) Token: 0x0601EAF6 RID: 125686 RVA: 0x002D9DAE File Offset: 0x002D7FAE
		[Nullable(2)]
		public unsafe ULandscapeSplineControlPoint ControlPoint
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULandscapeSplineControlPoint>(base.NativePtr / (IntPtr)sizeof(void*) + FLandscapeSplineSegmentConnection.__PropertyOffset_ControlPoint);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLandscapeSplineSegmentConnection.__PropertyOffset_ControlPoint, value);
			}
		}

		// Token: 0x17007A3E RID: 31294
		// (get) Token: 0x0601EAF7 RID: 125687 RVA: 0x002D9DC3 File Offset: 0x002D7FC3
		// (set) Token: 0x0601EAF8 RID: 125688 RVA: 0x002D9DD3 File Offset: 0x002D7FD3
		public unsafe float TangentLen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeSplineSegmentConnection.__PropertyOffset_TangentLen);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeSplineSegmentConnection.__PropertyOffset_TangentLen) = value;
			}
		}

		// Token: 0x17007A3F RID: 31295
		// (get) Token: 0x0601EAF9 RID: 125689 RVA: 0x002D9DE4 File Offset: 0x002D7FE4
		// (set) Token: 0x0601EAFA RID: 125690 RVA: 0x002D9DF8 File Offset: 0x002D7FF8
		public unsafe FName SocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeSplineSegmentConnection.__PropertyOffset_SocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeSplineSegmentConnection.__PropertyOffset_SocketName) = value;
			}
		}

		// Token: 0x0601EAFB RID: 125691 RVA: 0x002D9E0D File Offset: 0x002D800D
		public FLandscapeSplineSegmentConnection()
		{
		}

		// Token: 0x0601EAFC RID: 125692 RVA: 0x002D9E15 File Offset: 0x002D8015
		[NullableContext(1)]
		public FLandscapeSplineSegmentConnection(ULandscapeSplineControlPoint ControlPoint, float TangentLen, FName SocketName)
		{
			this.ControlPoint = ControlPoint;
			this.TangentLen = TangentLen;
			this.SocketName = SocketName;
		}

		// Token: 0x0601EAFD RID: 125693 RVA: 0x002D9E32 File Offset: 0x002D8032
		protected override IntPtr GetUStructPtr()
		{
			return FLandscapeSplineSegmentConnection.StaticStruct();
		}

		// Token: 0x0601EAFE RID: 125694 RVA: 0x002D9E3E File Offset: 0x002D803E
		[NullableContext(2)]
		public FLandscapeSplineSegmentConnection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EAFF RID: 125695 RVA: 0x002D9E48 File Offset: 0x002D8048
		public FLandscapeSplineSegmentConnection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EB00 RID: 125696 RVA: 0x002D9E53 File Offset: 0x002D8053
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLandscapeSplineSegmentConnection(Pointer, false, true);
		}

		// Token: 0x0601EB01 RID: 125697 RVA: 0x002D9E5D File Offset: 0x002D805D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLandscapeSplineSegmentConnection(Pointer, MemoryOwner);
		}

		// Token: 0x0401096E RID: 67950
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Landscape.LandscapeSplineSegmentConnection";

		// Token: 0x0401096F RID: 67951
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010970 RID: 67952
		internal static int __PropertyOffset_ControlPoint;

		// Token: 0x04010971 RID: 67953
		internal static int __PropertyOffset_TangentLen;

		// Token: 0x04010972 RID: 67954
		internal static int __PropertyOffset_SocketName;
	}
}
