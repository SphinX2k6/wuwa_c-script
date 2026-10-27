using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D42 RID: 3394
	[UnrealObjectPath("/Script/Engine.LevelViewportInfo")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FLevelViewportInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B5DC RID: 46556 RVA: 0x001037D5 File Offset: 0x001019D5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLevelViewportInfo._ScriptStructPtr != 0) ? FLevelViewportInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LevelViewportInfo", ref FLevelViewportInfo._ScriptStructPtr);
		}

		// Token: 0x17002994 RID: 10644
		// (get) Token: 0x0600B5DD RID: 46557 RVA: 0x001037F9 File Offset: 0x001019F9
		// (set) Token: 0x0600B5DE RID: 46558 RVA: 0x0010380D File Offset: 0x00101A0D
		public unsafe FVector CamPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelViewportInfo.__PropertyOffset_CamPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelViewportInfo.__PropertyOffset_CamPosition) = value;
			}
		}

		// Token: 0x17002995 RID: 10645
		// (get) Token: 0x0600B5DF RID: 46559 RVA: 0x00103822 File Offset: 0x00101A22
		// (set) Token: 0x0600B5E0 RID: 46560 RVA: 0x00103836 File Offset: 0x00101A36
		public unsafe FRotator CamRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelViewportInfo.__PropertyOffset_CamRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelViewportInfo.__PropertyOffset_CamRotation) = value;
			}
		}

		// Token: 0x17002996 RID: 10646
		// (get) Token: 0x0600B5E1 RID: 46561 RVA: 0x0010384B File Offset: 0x00101A4B
		// (set) Token: 0x0600B5E2 RID: 46562 RVA: 0x0010385B File Offset: 0x00101A5B
		public unsafe float CamOrthoZoom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelViewportInfo.__PropertyOffset_CamOrthoZoom);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelViewportInfo.__PropertyOffset_CamOrthoZoom) = value;
			}
		}

		// Token: 0x17002997 RID: 10647
		// (get) Token: 0x0600B5E3 RID: 46563 RVA: 0x0010386C File Offset: 0x00101A6C
		// (set) Token: 0x0600B5E4 RID: 46564 RVA: 0x0010387C File Offset: 0x00101A7C
		public unsafe bool CamUpdated
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelViewportInfo.__PropertyOffset_CamUpdated) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelViewportInfo.__PropertyOffset_CamUpdated) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600B5E5 RID: 46565 RVA: 0x0010388D File Offset: 0x00101A8D
		public FLevelViewportInfo()
		{
		}

		// Token: 0x0600B5E6 RID: 46566 RVA: 0x00103895 File Offset: 0x00101A95
		public FLevelViewportInfo(FVector CamPosition, FRotator CamRotation, float CamOrthoZoom, bool CamUpdated)
		{
			this.CamPosition = CamPosition;
			this.CamRotation = CamRotation;
			this.CamOrthoZoom = CamOrthoZoom;
			this.CamUpdated = CamUpdated;
		}

		// Token: 0x0600B5E7 RID: 46567 RVA: 0x001038BA File Offset: 0x00101ABA
		protected override IntPtr GetUStructPtr()
		{
			return FLevelViewportInfo.StaticStruct();
		}

		// Token: 0x0600B5E8 RID: 46568 RVA: 0x001038C6 File Offset: 0x00101AC6
		[NullableContext(2)]
		public FLevelViewportInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B5E9 RID: 46569 RVA: 0x001038D0 File Offset: 0x00101AD0
		public FLevelViewportInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B5EA RID: 46570 RVA: 0x001038DB File Offset: 0x00101ADB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLevelViewportInfo(Pointer, false, true);
		}

		// Token: 0x0600B5EB RID: 46571 RVA: 0x001038E5 File Offset: 0x00101AE5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLevelViewportInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04005F94 RID: 24468
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.LevelViewportInfo";

		// Token: 0x04005F95 RID: 24469
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005F96 RID: 24470
		internal static int __PropertyOffset_CamPosition;

		// Token: 0x04005F97 RID: 24471
		internal static int __PropertyOffset_CamRotation;

		// Token: 0x04005F98 RID: 24472
		internal static int __PropertyOffset_CamOrthoZoom;

		// Token: 0x04005F99 RID: 24473
		internal static int __PropertyOffset_CamUpdated;
	}
}
