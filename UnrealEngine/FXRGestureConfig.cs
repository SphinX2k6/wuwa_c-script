using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001471 RID: 5233
	[UnrealObjectPath("/Script/HeadMountedDisplay.XRGestureConfig")]
	[UnrealStructLayout(6, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 6)]
	public class FXRGestureConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601315D RID: 78173 RVA: 0x001C12B6 File Offset: 0x001BF4B6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FXRGestureConfig._ScriptStructPtr != 0) ? FXRGestureConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HeadMountedDisplay.XRGestureConfig", ref FXRGestureConfig._ScriptStructPtr);
		}

		// Token: 0x17004A1E RID: 18974
		// (get) Token: 0x0601315E RID: 78174 RVA: 0x001C12DA File Offset: 0x001BF4DA
		// (set) Token: 0x0601315F RID: 78175 RVA: 0x001C12EA File Offset: 0x001BF4EA
		public unsafe bool bTap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXRGestureConfig.__PropertyOffset_bTap) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXRGestureConfig.__PropertyOffset_bTap) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A1F RID: 18975
		// (get) Token: 0x06013160 RID: 78176 RVA: 0x001C12FB File Offset: 0x001BF4FB
		// (set) Token: 0x06013161 RID: 78177 RVA: 0x001C130B File Offset: 0x001BF50B
		public unsafe bool bHold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXRGestureConfig.__PropertyOffset_bHold) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXRGestureConfig.__PropertyOffset_bHold) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A20 RID: 18976
		// (get) Token: 0x06013162 RID: 78178 RVA: 0x001C131C File Offset: 0x001BF51C
		// (set) Token: 0x06013163 RID: 78179 RVA: 0x001C132C File Offset: 0x001BF52C
		public unsafe ESpatialInputGestureAxis AxisGesture
		{
			get
			{
				return (ESpatialInputGestureAxis)(*(base.NativePtr + (IntPtr)FXRGestureConfig.__PropertyOffset_AxisGesture));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXRGestureConfig.__PropertyOffset_AxisGesture) = (byte)value;
			}
		}

		// Token: 0x17004A21 RID: 18977
		// (get) Token: 0x06013164 RID: 78180 RVA: 0x001C133D File Offset: 0x001BF53D
		// (set) Token: 0x06013165 RID: 78181 RVA: 0x001C134D File Offset: 0x001BF54D
		public unsafe bool bNavigationAxisX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXRGestureConfig.__PropertyOffset_bNavigationAxisX) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXRGestureConfig.__PropertyOffset_bNavigationAxisX) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A22 RID: 18978
		// (get) Token: 0x06013166 RID: 78182 RVA: 0x001C135E File Offset: 0x001BF55E
		// (set) Token: 0x06013167 RID: 78183 RVA: 0x001C136E File Offset: 0x001BF56E
		public unsafe bool bNavigationAxisY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXRGestureConfig.__PropertyOffset_bNavigationAxisY) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXRGestureConfig.__PropertyOffset_bNavigationAxisY) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A23 RID: 18979
		// (get) Token: 0x06013168 RID: 78184 RVA: 0x001C137F File Offset: 0x001BF57F
		// (set) Token: 0x06013169 RID: 78185 RVA: 0x001C138F File Offset: 0x001BF58F
		public unsafe bool bNavigationAxisZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXRGestureConfig.__PropertyOffset_bNavigationAxisZ) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXRGestureConfig.__PropertyOffset_bNavigationAxisZ) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601316A RID: 78186 RVA: 0x001C13A0 File Offset: 0x001BF5A0
		public FXRGestureConfig()
		{
		}

		// Token: 0x0601316B RID: 78187 RVA: 0x001C13A8 File Offset: 0x001BF5A8
		public FXRGestureConfig(bool bTap, bool bHold, ESpatialInputGestureAxis AxisGesture, bool bNavigationAxisX, bool bNavigationAxisY, bool bNavigationAxisZ)
		{
			this.bTap = bTap;
			this.bHold = bHold;
			this.AxisGesture = AxisGesture;
			this.bNavigationAxisX = bNavigationAxisX;
			this.bNavigationAxisY = bNavigationAxisY;
			this.bNavigationAxisZ = bNavigationAxisZ;
		}

		// Token: 0x0601316C RID: 78188 RVA: 0x001C13DD File Offset: 0x001BF5DD
		protected override IntPtr GetUStructPtr()
		{
			return FXRGestureConfig.StaticStruct();
		}

		// Token: 0x0601316D RID: 78189 RVA: 0x001C13E9 File Offset: 0x001BF5E9
		[NullableContext(2)]
		public FXRGestureConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601316E RID: 78190 RVA: 0x001C13F3 File Offset: 0x001BF5F3
		public FXRGestureConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601316F RID: 78191 RVA: 0x001C13FE File Offset: 0x001BF5FE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FXRGestureConfig(Pointer, false, true);
		}

		// Token: 0x06013170 RID: 78192 RVA: 0x001C1408 File Offset: 0x001BF608
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FXRGestureConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400A3B6 RID: 41910
		[Nullable(1)]
		public const string __ObjectPath = "/Script/HeadMountedDisplay.XRGestureConfig";

		// Token: 0x0400A3B7 RID: 41911
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A3B8 RID: 41912
		internal static int __PropertyOffset_bTap;

		// Token: 0x0400A3B9 RID: 41913
		internal static int __PropertyOffset_bHold;

		// Token: 0x0400A3BA RID: 41914
		internal static int __PropertyOffset_AxisGesture;

		// Token: 0x0400A3BB RID: 41915
		internal static int __PropertyOffset_bNavigationAxisX;

		// Token: 0x0400A3BC RID: 41916
		internal static int __PropertyOffset_bNavigationAxisY;

		// Token: 0x0400A3BD RID: 41917
		internal static int __PropertyOffset_bNavigationAxisZ;
	}
}
