using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020021FB RID: 8699
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkCameraStaticData")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FLiveLinkCameraStaticData : FLiveLinkTransformStaticData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021278 RID: 135800 RVA: 0x0030E336 File Offset: 0x0030C536
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkCameraStaticData._ScriptStructPtr != 0) ? FLiveLinkCameraStaticData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkCameraStaticData", ref FLiveLinkCameraStaticData._ScriptStructPtr);
		}

		// Token: 0x17008170 RID: 33136
		// (get) Token: 0x06021279 RID: 135801 RVA: 0x0030E35A File Offset: 0x0030C55A
		// (set) Token: 0x0602127A RID: 135802 RVA: 0x0030E36A File Offset: 0x0030C56A
		public unsafe bool bIsFieldOfViewSupported
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkCameraStaticData.__PropertyOffset_bIsFieldOfViewSupported) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkCameraStaticData.__PropertyOffset_bIsFieldOfViewSupported) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008171 RID: 33137
		// (get) Token: 0x0602127B RID: 135803 RVA: 0x0030E37B File Offset: 0x0030C57B
		// (set) Token: 0x0602127C RID: 135804 RVA: 0x0030E38B File Offset: 0x0030C58B
		public unsafe bool bIsAspectRatioSupported
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkCameraStaticData.__PropertyOffset_bIsAspectRatioSupported) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkCameraStaticData.__PropertyOffset_bIsAspectRatioSupported) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008172 RID: 33138
		// (get) Token: 0x0602127D RID: 135805 RVA: 0x0030E39C File Offset: 0x0030C59C
		// (set) Token: 0x0602127E RID: 135806 RVA: 0x0030E3AC File Offset: 0x0030C5AC
		public unsafe bool bIsFocalLengthSupported
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkCameraStaticData.__PropertyOffset_bIsFocalLengthSupported) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkCameraStaticData.__PropertyOffset_bIsFocalLengthSupported) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008173 RID: 33139
		// (get) Token: 0x0602127F RID: 135807 RVA: 0x0030E3BD File Offset: 0x0030C5BD
		// (set) Token: 0x06021280 RID: 135808 RVA: 0x0030E3CD File Offset: 0x0030C5CD
		public unsafe bool bIsProjectionModeSupported
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkCameraStaticData.__PropertyOffset_bIsProjectionModeSupported) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkCameraStaticData.__PropertyOffset_bIsProjectionModeSupported) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008174 RID: 33140
		// (get) Token: 0x06021281 RID: 135809 RVA: 0x0030E3DE File Offset: 0x0030C5DE
		// (set) Token: 0x06021282 RID: 135810 RVA: 0x0030E3EE File Offset: 0x0030C5EE
		public unsafe float FilmBackWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkCameraStaticData.__PropertyOffset_FilmBackWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkCameraStaticData.__PropertyOffset_FilmBackWidth) = value;
			}
		}

		// Token: 0x17008175 RID: 33141
		// (get) Token: 0x06021283 RID: 135811 RVA: 0x0030E3FF File Offset: 0x0030C5FF
		// (set) Token: 0x06021284 RID: 135812 RVA: 0x0030E40F File Offset: 0x0030C60F
		public unsafe float FilmBackHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkCameraStaticData.__PropertyOffset_FilmBackHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkCameraStaticData.__PropertyOffset_FilmBackHeight) = value;
			}
		}

		// Token: 0x17008176 RID: 33142
		// (get) Token: 0x06021285 RID: 135813 RVA: 0x0030E420 File Offset: 0x0030C620
		// (set) Token: 0x06021286 RID: 135814 RVA: 0x0030E430 File Offset: 0x0030C630
		public unsafe bool bIsApertureSupported
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkCameraStaticData.__PropertyOffset_bIsApertureSupported) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkCameraStaticData.__PropertyOffset_bIsApertureSupported) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008177 RID: 33143
		// (get) Token: 0x06021287 RID: 135815 RVA: 0x0030E441 File Offset: 0x0030C641
		// (set) Token: 0x06021288 RID: 135816 RVA: 0x0030E451 File Offset: 0x0030C651
		public unsafe bool bIsFocusDistanceSupported
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkCameraStaticData.__PropertyOffset_bIsFocusDistanceSupported) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkCameraStaticData.__PropertyOffset_bIsFocusDistanceSupported) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021289 RID: 135817 RVA: 0x0030E462 File Offset: 0x0030C662
		public FLiveLinkCameraStaticData()
		{
		}

		// Token: 0x0602128A RID: 135818 RVA: 0x0030E46C File Offset: 0x0030C66C
		[NullableContext(1)]
		public FLiveLinkCameraStaticData(bool bIsFieldOfViewSupported, bool bIsAspectRatioSupported, bool bIsFocalLengthSupported, bool bIsProjectionModeSupported, float FilmBackWidth, float FilmBackHeight, bool bIsApertureSupported, bool bIsFocusDistanceSupported, bool bIsLocationSupported, bool bIsRotationSupported, bool bIsScaleSupported, TArray<FName> PropertyNames)
		{
			this.bIsFieldOfViewSupported = bIsFieldOfViewSupported;
			this.bIsAspectRatioSupported = bIsAspectRatioSupported;
			this.bIsFocalLengthSupported = bIsFocalLengthSupported;
			this.bIsProjectionModeSupported = bIsProjectionModeSupported;
			this.FilmBackWidth = FilmBackWidth;
			this.FilmBackHeight = FilmBackHeight;
			this.bIsApertureSupported = bIsApertureSupported;
			this.bIsFocusDistanceSupported = bIsFocusDistanceSupported;
			base.bIsLocationSupported = bIsLocationSupported;
			base.bIsRotationSupported = bIsRotationSupported;
			base.bIsScaleSupported = bIsScaleSupported;
			base.PropertyNames = PropertyNames;
		}

		// Token: 0x0602128B RID: 135819 RVA: 0x0030E4DC File Offset: 0x0030C6DC
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkCameraStaticData.StaticStruct();
		}

		// Token: 0x0602128C RID: 135820 RVA: 0x0030E4E8 File Offset: 0x0030C6E8
		[NullableContext(2)]
		public FLiveLinkCameraStaticData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602128D RID: 135821 RVA: 0x0030E4F2 File Offset: 0x0030C6F2
		public FLiveLinkCameraStaticData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602128E RID: 135822 RVA: 0x0030E4FD File Offset: 0x0030C6FD
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkCameraStaticData(Pointer, false, true);
		}

		// Token: 0x0602128F RID: 135823 RVA: 0x0030E507 File Offset: 0x0030C707
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkCameraStaticData(Pointer, MemoryOwner);
		}

		// Token: 0x04011B0C RID: 72460
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkCameraStaticData";

		// Token: 0x04011B0D RID: 72461
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011B0E RID: 72462
		internal static int __PropertyOffset_bIsFieldOfViewSupported;

		// Token: 0x04011B0F RID: 72463
		internal static int __PropertyOffset_bIsAspectRatioSupported;

		// Token: 0x04011B10 RID: 72464
		internal static int __PropertyOffset_bIsFocalLengthSupported;

		// Token: 0x04011B11 RID: 72465
		internal static int __PropertyOffset_bIsProjectionModeSupported;

		// Token: 0x04011B12 RID: 72466
		internal static int __PropertyOffset_FilmBackWidth;

		// Token: 0x04011B13 RID: 72467
		internal static int __PropertyOffset_FilmBackHeight;

		// Token: 0x04011B14 RID: 72468
		internal static int __PropertyOffset_bIsApertureSupported;

		// Token: 0x04011B15 RID: 72469
		internal static int __PropertyOffset_bIsFocusDistanceSupported;
	}
}
