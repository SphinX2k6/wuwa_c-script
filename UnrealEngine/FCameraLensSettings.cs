using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000472 RID: 1138
	[UnrealObjectPath("/Script/CinematicCamera.CameraLensSettings")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FCameraLensSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003CD6 RID: 15574 RVA: 0x0005B920 File Offset: 0x00059B20
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCameraLensSettings._ScriptStructPtr != 0) ? FCameraLensSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CinematicCamera.CameraLensSettings", ref FCameraLensSettings._ScriptStructPtr);
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x06003CD7 RID: 15575 RVA: 0x0005B944 File Offset: 0x00059B44
		// (set) Token: 0x06003CD8 RID: 15576 RVA: 0x0005B954 File Offset: 0x00059B54
		public unsafe float MinFocalLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraLensSettings.__PropertyOffset_MinFocalLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraLensSettings.__PropertyOffset_MinFocalLength) = value;
			}
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06003CD9 RID: 15577 RVA: 0x0005B965 File Offset: 0x00059B65
		// (set) Token: 0x06003CDA RID: 15578 RVA: 0x0005B975 File Offset: 0x00059B75
		public unsafe float MaxFocalLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraLensSettings.__PropertyOffset_MaxFocalLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraLensSettings.__PropertyOffset_MaxFocalLength) = value;
			}
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06003CDB RID: 15579 RVA: 0x0005B986 File Offset: 0x00059B86
		// (set) Token: 0x06003CDC RID: 15580 RVA: 0x0005B996 File Offset: 0x00059B96
		public unsafe float MinFStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraLensSettings.__PropertyOffset_MinFStop);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraLensSettings.__PropertyOffset_MinFStop) = value;
			}
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06003CDD RID: 15581 RVA: 0x0005B9A7 File Offset: 0x00059BA7
		// (set) Token: 0x06003CDE RID: 15582 RVA: 0x0005B9B7 File Offset: 0x00059BB7
		public unsafe float MaxFStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraLensSettings.__PropertyOffset_MaxFStop);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraLensSettings.__PropertyOffset_MaxFStop) = value;
			}
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06003CDF RID: 15583 RVA: 0x0005B9C8 File Offset: 0x00059BC8
		// (set) Token: 0x06003CE0 RID: 15584 RVA: 0x0005B9D8 File Offset: 0x00059BD8
		public unsafe float MinimumFocusDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraLensSettings.__PropertyOffset_MinimumFocusDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraLensSettings.__PropertyOffset_MinimumFocusDistance) = value;
			}
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06003CE1 RID: 15585 RVA: 0x0005B9E9 File Offset: 0x00059BE9
		// (set) Token: 0x06003CE2 RID: 15586 RVA: 0x0005B9F9 File Offset: 0x00059BF9
		public unsafe int DiaphragmBladeCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraLensSettings.__PropertyOffset_DiaphragmBladeCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraLensSettings.__PropertyOffset_DiaphragmBladeCount) = value;
			}
		}

		// Token: 0x06003CE3 RID: 15587 RVA: 0x0005BA0A File Offset: 0x00059C0A
		public FCameraLensSettings()
		{
		}

		// Token: 0x06003CE4 RID: 15588 RVA: 0x0005BA12 File Offset: 0x00059C12
		public FCameraLensSettings(float MinFocalLength, float MaxFocalLength, float MinFStop, float MaxFStop, float MinimumFocusDistance, int DiaphragmBladeCount)
		{
			this.MinFocalLength = MinFocalLength;
			this.MaxFocalLength = MaxFocalLength;
			this.MinFStop = MinFStop;
			this.MaxFStop = MaxFStop;
			this.MinimumFocusDistance = MinimumFocusDistance;
			this.DiaphragmBladeCount = DiaphragmBladeCount;
		}

		// Token: 0x06003CE5 RID: 15589 RVA: 0x0005BA47 File Offset: 0x00059C47
		protected override IntPtr GetUStructPtr()
		{
			return FCameraLensSettings.StaticStruct();
		}

		// Token: 0x06003CE6 RID: 15590 RVA: 0x0005BA53 File Offset: 0x00059C53
		[NullableContext(2)]
		public FCameraLensSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003CE7 RID: 15591 RVA: 0x0005BA5D File Offset: 0x00059C5D
		public FCameraLensSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003CE8 RID: 15592 RVA: 0x0005BA68 File Offset: 0x00059C68
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCameraLensSettings(Pointer, false, true);
		}

		// Token: 0x06003CE9 RID: 15593 RVA: 0x0005BA72 File Offset: 0x00059C72
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCameraLensSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04001C87 RID: 7303
		[Nullable(1)]
		public const string __ObjectPath = "/Script/CinematicCamera.CameraLensSettings";

		// Token: 0x04001C88 RID: 7304
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001C89 RID: 7305
		internal static int __PropertyOffset_MinFocalLength;

		// Token: 0x04001C8A RID: 7306
		internal static int __PropertyOffset_MaxFocalLength;

		// Token: 0x04001C8B RID: 7307
		internal static int __PropertyOffset_MinFStop;

		// Token: 0x04001C8C RID: 7308
		internal static int __PropertyOffset_MaxFStop;

		// Token: 0x04001C8D RID: 7309
		internal static int __PropertyOffset_MinimumFocusDistance;

		// Token: 0x04001C8E RID: 7310
		internal static int __PropertyOffset_DiaphragmBladeCount;
	}
}
