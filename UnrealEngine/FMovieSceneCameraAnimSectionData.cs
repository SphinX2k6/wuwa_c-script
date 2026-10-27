using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002346 RID: 9030
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneCameraAnimSectionData")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMovieSceneCameraAnimSectionData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602222C RID: 139820 RVA: 0x0032790B File Offset: 0x00325B0B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneCameraAnimSectionData._ScriptStructPtr != 0) ? FMovieSceneCameraAnimSectionData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneCameraAnimSectionData", ref FMovieSceneCameraAnimSectionData._ScriptStructPtr);
		}

		// Token: 0x170083D9 RID: 33753
		// (get) Token: 0x0602222D RID: 139821 RVA: 0x0032792F File Offset: 0x00325B2F
		// (set) Token: 0x0602222E RID: 139822 RVA: 0x00327943 File Offset: 0x00325B43
		[Nullable(2)]
		public unsafe UCameraAnim CameraAnim
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCameraAnim>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneCameraAnimSectionData.__PropertyOffset_CameraAnim);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneCameraAnimSectionData.__PropertyOffset_CameraAnim, value);
			}
		}

		// Token: 0x170083DA RID: 33754
		// (get) Token: 0x0602222F RID: 139823 RVA: 0x00327958 File Offset: 0x00325B58
		// (set) Token: 0x06022230 RID: 139824 RVA: 0x00327968 File Offset: 0x00325B68
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCameraAnimSectionData.__PropertyOffset_PlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCameraAnimSectionData.__PropertyOffset_PlayRate) = value;
			}
		}

		// Token: 0x170083DB RID: 33755
		// (get) Token: 0x06022231 RID: 139825 RVA: 0x00327979 File Offset: 0x00325B79
		// (set) Token: 0x06022232 RID: 139826 RVA: 0x00327989 File Offset: 0x00325B89
		public unsafe float PlayScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCameraAnimSectionData.__PropertyOffset_PlayScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCameraAnimSectionData.__PropertyOffset_PlayScale) = value;
			}
		}

		// Token: 0x170083DC RID: 33756
		// (get) Token: 0x06022233 RID: 139827 RVA: 0x0032799A File Offset: 0x00325B9A
		// (set) Token: 0x06022234 RID: 139828 RVA: 0x003279AA File Offset: 0x00325BAA
		public unsafe float BlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCameraAnimSectionData.__PropertyOffset_BlendInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCameraAnimSectionData.__PropertyOffset_BlendInTime) = value;
			}
		}

		// Token: 0x170083DD RID: 33757
		// (get) Token: 0x06022235 RID: 139829 RVA: 0x003279BB File Offset: 0x00325BBB
		// (set) Token: 0x06022236 RID: 139830 RVA: 0x003279CB File Offset: 0x00325BCB
		public unsafe float BlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCameraAnimSectionData.__PropertyOffset_BlendOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCameraAnimSectionData.__PropertyOffset_BlendOutTime) = value;
			}
		}

		// Token: 0x170083DE RID: 33758
		// (get) Token: 0x06022237 RID: 139831 RVA: 0x003279DC File Offset: 0x00325BDC
		// (set) Token: 0x06022238 RID: 139832 RVA: 0x003279EC File Offset: 0x00325BEC
		public unsafe bool bLooping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCameraAnimSectionData.__PropertyOffset_bLooping) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCameraAnimSectionData.__PropertyOffset_bLooping) = (value ? 1 : 0);
			}
		}

		// Token: 0x06022239 RID: 139833 RVA: 0x003279FD File Offset: 0x00325BFD
		public FMovieSceneCameraAnimSectionData()
		{
		}

		// Token: 0x0602223A RID: 139834 RVA: 0x00327A05 File Offset: 0x00325C05
		[NullableContext(1)]
		public FMovieSceneCameraAnimSectionData(UCameraAnim CameraAnim, float PlayRate, float PlayScale, float BlendInTime, float BlendOutTime, bool bLooping)
		{
			this.CameraAnim = CameraAnim;
			this.PlayRate = PlayRate;
			this.PlayScale = PlayScale;
			this.BlendInTime = BlendInTime;
			this.BlendOutTime = BlendOutTime;
			this.bLooping = bLooping;
		}

		// Token: 0x0602223B RID: 139835 RVA: 0x00327A3A File Offset: 0x00325C3A
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneCameraAnimSectionData.StaticStruct();
		}

		// Token: 0x0602223C RID: 139836 RVA: 0x00327A46 File Offset: 0x00325C46
		[NullableContext(2)]
		public FMovieSceneCameraAnimSectionData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602223D RID: 139837 RVA: 0x00327A50 File Offset: 0x00325C50
		public FMovieSceneCameraAnimSectionData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602223E RID: 139838 RVA: 0x00327A5B File Offset: 0x00325C5B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneCameraAnimSectionData(Pointer, false, true);
		}

		// Token: 0x0602223F RID: 139839 RVA: 0x00327A65 File Offset: 0x00325C65
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneCameraAnimSectionData(Pointer, MemoryOwner);
		}

		// Token: 0x04012384 RID: 74628
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneCameraAnimSectionData";

		// Token: 0x04012385 RID: 74629
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012386 RID: 74630
		internal static int __PropertyOffset_CameraAnim;

		// Token: 0x04012387 RID: 74631
		internal static int __PropertyOffset_PlayRate;

		// Token: 0x04012388 RID: 74632
		internal static int __PropertyOffset_PlayScale;

		// Token: 0x04012389 RID: 74633
		internal static int __PropertyOffset_BlendInTime;

		// Token: 0x0401238A RID: 74634
		internal static int __PropertyOffset_BlendOutTime;

		// Token: 0x0401238B RID: 74635
		internal static int __PropertyOffset_bLooping;
	}
}
