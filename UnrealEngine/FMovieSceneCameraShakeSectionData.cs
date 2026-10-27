using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200234D RID: 9037
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneCameraShakeSectionData")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMovieSceneCameraShakeSectionData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022283 RID: 139907 RVA: 0x0032818D File Offset: 0x0032638D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneCameraShakeSectionData._ScriptStructPtr != 0) ? FMovieSceneCameraShakeSectionData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneCameraShakeSectionData", ref FMovieSceneCameraShakeSectionData._ScriptStructPtr);
		}

		// Token: 0x170083EE RID: 33774
		// (get) Token: 0x06022284 RID: 139908 RVA: 0x003281B1 File Offset: 0x003263B1
		// (set) Token: 0x06022285 RID: 139909 RVA: 0x003281C5 File Offset: 0x003263C5
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UMatineeCameraShake> ShakeClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCameraShakeSectionData.__PropertyOffset_ShakeClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCameraShakeSectionData.__PropertyOffset_ShakeClass) = value;
			}
		}

		// Token: 0x170083EF RID: 33775
		// (get) Token: 0x06022286 RID: 139910 RVA: 0x003281DA File Offset: 0x003263DA
		// (set) Token: 0x06022287 RID: 139911 RVA: 0x003281EA File Offset: 0x003263EA
		public unsafe float PlayScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCameraShakeSectionData.__PropertyOffset_PlayScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCameraShakeSectionData.__PropertyOffset_PlayScale) = value;
			}
		}

		// Token: 0x170083F0 RID: 33776
		// (get) Token: 0x06022288 RID: 139912 RVA: 0x003281FB File Offset: 0x003263FB
		// (set) Token: 0x06022289 RID: 139913 RVA: 0x0032820B File Offset: 0x0032640B
		public unsafe ECameraShakePlaySpace PlaySpace
		{
			get
			{
				return (ECameraShakePlaySpace)(*(base.NativePtr + (IntPtr)FMovieSceneCameraShakeSectionData.__PropertyOffset_PlaySpace));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCameraShakeSectionData.__PropertyOffset_PlaySpace) = (byte)value;
			}
		}

		// Token: 0x170083F1 RID: 33777
		// (get) Token: 0x0602228A RID: 139914 RVA: 0x0032821C File Offset: 0x0032641C
		// (set) Token: 0x0602228B RID: 139915 RVA: 0x00328230 File Offset: 0x00326430
		public unsafe FRotator UserDefinedPlaySpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCameraShakeSectionData.__PropertyOffset_UserDefinedPlaySpace);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCameraShakeSectionData.__PropertyOffset_UserDefinedPlaySpace) = value;
			}
		}

		// Token: 0x0602228C RID: 139916 RVA: 0x00328245 File Offset: 0x00326445
		public FMovieSceneCameraShakeSectionData()
		{
		}

		// Token: 0x0602228D RID: 139917 RVA: 0x0032824D File Offset: 0x0032644D
		public FMovieSceneCameraShakeSectionData([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UMatineeCameraShake> ShakeClass, float PlayScale, ECameraShakePlaySpace PlaySpace, FRotator UserDefinedPlaySpace)
		{
			this.ShakeClass = ShakeClass;
			this.PlayScale = PlayScale;
			this.PlaySpace = PlaySpace;
			this.UserDefinedPlaySpace = UserDefinedPlaySpace;
		}

		// Token: 0x0602228E RID: 139918 RVA: 0x00328272 File Offset: 0x00326472
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneCameraShakeSectionData.StaticStruct();
		}

		// Token: 0x0602228F RID: 139919 RVA: 0x0032827E File Offset: 0x0032647E
		[NullableContext(2)]
		public FMovieSceneCameraShakeSectionData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022290 RID: 139920 RVA: 0x00328288 File Offset: 0x00326488
		public FMovieSceneCameraShakeSectionData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022291 RID: 139921 RVA: 0x00328293 File Offset: 0x00326493
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneCameraShakeSectionData(Pointer, false, true);
		}

		// Token: 0x06022292 RID: 139922 RVA: 0x0032829D File Offset: 0x0032649D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneCameraShakeSectionData(Pointer, MemoryOwner);
		}

		// Token: 0x040123B6 RID: 74678
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneCameraShakeSectionData";

		// Token: 0x040123B7 RID: 74679
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040123B8 RID: 74680
		internal static int __PropertyOffset_ShakeClass;

		// Token: 0x040123B9 RID: 74681
		internal static int __PropertyOffset_PlayScale;

		// Token: 0x040123BA RID: 74682
		internal static int __PropertyOffset_PlaySpace;

		// Token: 0x040123BB RID: 74683
		internal static int __PropertyOffset_UserDefinedPlaySpace;
	}
}
