using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020021F9 RID: 8697
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkCameraFrameData")]
	[UnrealStructLayout(240, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FLiveLinkCameraFrameData : FLiveLinkTransformFrameData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602125F RID: 135775 RVA: 0x0030E132 File Offset: 0x0030C332
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkCameraFrameData._ScriptStructPtr != 0) ? FLiveLinkCameraFrameData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkCameraFrameData", ref FLiveLinkCameraFrameData._ScriptStructPtr);
		}

		// Token: 0x1700816A RID: 33130
		// (get) Token: 0x06021260 RID: 135776 RVA: 0x0030E156 File Offset: 0x0030C356
		// (set) Token: 0x06021261 RID: 135777 RVA: 0x0030E166 File Offset: 0x0030C366
		public unsafe float FieldOfView
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkCameraFrameData.__PropertyOffset_FieldOfView);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkCameraFrameData.__PropertyOffset_FieldOfView) = value;
			}
		}

		// Token: 0x1700816B RID: 33131
		// (get) Token: 0x06021262 RID: 135778 RVA: 0x0030E177 File Offset: 0x0030C377
		// (set) Token: 0x06021263 RID: 135779 RVA: 0x0030E187 File Offset: 0x0030C387
		public unsafe float AspectRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkCameraFrameData.__PropertyOffset_AspectRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkCameraFrameData.__PropertyOffset_AspectRatio) = value;
			}
		}

		// Token: 0x1700816C RID: 33132
		// (get) Token: 0x06021264 RID: 135780 RVA: 0x0030E198 File Offset: 0x0030C398
		// (set) Token: 0x06021265 RID: 135781 RVA: 0x0030E1A8 File Offset: 0x0030C3A8
		public unsafe float FocalLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkCameraFrameData.__PropertyOffset_FocalLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkCameraFrameData.__PropertyOffset_FocalLength) = value;
			}
		}

		// Token: 0x1700816D RID: 33133
		// (get) Token: 0x06021266 RID: 135782 RVA: 0x0030E1B9 File Offset: 0x0030C3B9
		// (set) Token: 0x06021267 RID: 135783 RVA: 0x0030E1C9 File Offset: 0x0030C3C9
		public unsafe float Aperture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkCameraFrameData.__PropertyOffset_Aperture);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkCameraFrameData.__PropertyOffset_Aperture) = value;
			}
		}

		// Token: 0x1700816E RID: 33134
		// (get) Token: 0x06021268 RID: 135784 RVA: 0x0030E1DA File Offset: 0x0030C3DA
		// (set) Token: 0x06021269 RID: 135785 RVA: 0x0030E1EA File Offset: 0x0030C3EA
		public unsafe float FocusDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkCameraFrameData.__PropertyOffset_FocusDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkCameraFrameData.__PropertyOffset_FocusDistance) = value;
			}
		}

		// Token: 0x1700816F RID: 33135
		// (get) Token: 0x0602126A RID: 135786 RVA: 0x0030E1FB File Offset: 0x0030C3FB
		// (set) Token: 0x0602126B RID: 135787 RVA: 0x0030E20B File Offset: 0x0030C40B
		public unsafe ELiveLinkCameraProjectionMode ProjectionMode
		{
			get
			{
				return (ELiveLinkCameraProjectionMode)(*(base.NativePtr + (IntPtr)FLiveLinkCameraFrameData.__PropertyOffset_ProjectionMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkCameraFrameData.__PropertyOffset_ProjectionMode) = (byte)value;
			}
		}

		// Token: 0x0602126C RID: 135788 RVA: 0x0030E21C File Offset: 0x0030C41C
		public FLiveLinkCameraFrameData()
		{
		}

		// Token: 0x0602126D RID: 135789 RVA: 0x0030E224 File Offset: 0x0030C424
		[NullableContext(1)]
		public FLiveLinkCameraFrameData(float FieldOfView, float AspectRatio, float FocalLength, float Aperture, float FocusDistance, ELiveLinkCameraProjectionMode ProjectionMode, FTransform Transform, FLiveLinkWorldTime WorldTime, FLiveLinkMetaData MetaData, TArray<float> PropertyValues)
		{
			this.FieldOfView = FieldOfView;
			this.AspectRatio = AspectRatio;
			this.FocalLength = FocalLength;
			this.Aperture = Aperture;
			this.FocusDistance = FocusDistance;
			this.ProjectionMode = ProjectionMode;
			base.Transform = Transform;
			base.WorldTime = WorldTime;
			base.MetaData = MetaData;
			base.PropertyValues = PropertyValues;
		}

		// Token: 0x0602126E RID: 135790 RVA: 0x0030E284 File Offset: 0x0030C484
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkCameraFrameData.StaticStruct();
		}

		// Token: 0x0602126F RID: 135791 RVA: 0x0030E290 File Offset: 0x0030C490
		[NullableContext(2)]
		public FLiveLinkCameraFrameData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021270 RID: 135792 RVA: 0x0030E29A File Offset: 0x0030C49A
		public FLiveLinkCameraFrameData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021271 RID: 135793 RVA: 0x0030E2A5 File Offset: 0x0030C4A5
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkCameraFrameData(Pointer, false, true);
		}

		// Token: 0x06021272 RID: 135794 RVA: 0x0030E2AF File Offset: 0x0030C4AF
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkCameraFrameData(Pointer, MemoryOwner);
		}

		// Token: 0x04011B01 RID: 72449
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkCameraFrameData";

		// Token: 0x04011B02 RID: 72450
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011B03 RID: 72451
		internal static int __PropertyOffset_FieldOfView;

		// Token: 0x04011B04 RID: 72452
		internal static int __PropertyOffset_AspectRatio;

		// Token: 0x04011B05 RID: 72453
		internal static int __PropertyOffset_FocalLength;

		// Token: 0x04011B06 RID: 72454
		internal static int __PropertyOffset_Aperture;

		// Token: 0x04011B07 RID: 72455
		internal static int __PropertyOffset_FocusDistance;

		// Token: 0x04011B08 RID: 72456
		internal static int __PropertyOffset_ProjectionMode;
	}
}
