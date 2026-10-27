using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002352 RID: 9042
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTrigger")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMovieSceneCameraShakeSourceTrigger : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060222BC RID: 139964 RVA: 0x0032875A File Offset: 0x0032695A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneCameraShakeSourceTrigger._ScriptStructPtr != 0) ? FMovieSceneCameraShakeSourceTrigger._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTrigger", ref FMovieSceneCameraShakeSourceTrigger._ScriptStructPtr);
		}

		// Token: 0x170083F9 RID: 33785
		// (get) Token: 0x060222BD RID: 139965 RVA: 0x0032877E File Offset: 0x0032697E
		// (set) Token: 0x060222BE RID: 139966 RVA: 0x00328792 File Offset: 0x00326992
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UCameraShakeBase> ShakeClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCameraShakeSourceTrigger.__PropertyOffset_ShakeClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCameraShakeSourceTrigger.__PropertyOffset_ShakeClass) = value;
			}
		}

		// Token: 0x170083FA RID: 33786
		// (get) Token: 0x060222BF RID: 139967 RVA: 0x003287A7 File Offset: 0x003269A7
		// (set) Token: 0x060222C0 RID: 139968 RVA: 0x003287B7 File Offset: 0x003269B7
		public unsafe float PlayScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCameraShakeSourceTrigger.__PropertyOffset_PlayScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCameraShakeSourceTrigger.__PropertyOffset_PlayScale) = value;
			}
		}

		// Token: 0x170083FB RID: 33787
		// (get) Token: 0x060222C1 RID: 139969 RVA: 0x003287C8 File Offset: 0x003269C8
		// (set) Token: 0x060222C2 RID: 139970 RVA: 0x003287D8 File Offset: 0x003269D8
		public unsafe ECameraShakePlaySpace PlaySpace
		{
			get
			{
				return (ECameraShakePlaySpace)(*(base.NativePtr + (IntPtr)FMovieSceneCameraShakeSourceTrigger.__PropertyOffset_PlaySpace));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCameraShakeSourceTrigger.__PropertyOffset_PlaySpace) = (byte)value;
			}
		}

		// Token: 0x170083FC RID: 33788
		// (get) Token: 0x060222C3 RID: 139971 RVA: 0x003287E9 File Offset: 0x003269E9
		// (set) Token: 0x060222C4 RID: 139972 RVA: 0x003287FD File Offset: 0x003269FD
		public unsafe FRotator UserDefinedPlaySpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCameraShakeSourceTrigger.__PropertyOffset_UserDefinedPlaySpace);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCameraShakeSourceTrigger.__PropertyOffset_UserDefinedPlaySpace) = value;
			}
		}

		// Token: 0x060222C5 RID: 139973 RVA: 0x00328812 File Offset: 0x00326A12
		public FMovieSceneCameraShakeSourceTrigger()
		{
		}

		// Token: 0x060222C6 RID: 139974 RVA: 0x0032881A File Offset: 0x00326A1A
		public FMovieSceneCameraShakeSourceTrigger([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> ShakeClass, float PlayScale, ECameraShakePlaySpace PlaySpace, FRotator UserDefinedPlaySpace)
		{
			this.ShakeClass = ShakeClass;
			this.PlayScale = PlayScale;
			this.PlaySpace = PlaySpace;
			this.UserDefinedPlaySpace = UserDefinedPlaySpace;
		}

		// Token: 0x060222C7 RID: 139975 RVA: 0x0032883F File Offset: 0x00326A3F
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneCameraShakeSourceTrigger.StaticStruct();
		}

		// Token: 0x060222C8 RID: 139976 RVA: 0x0032884B File Offset: 0x00326A4B
		[NullableContext(2)]
		public FMovieSceneCameraShakeSourceTrigger(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060222C9 RID: 139977 RVA: 0x00328855 File Offset: 0x00326A55
		public FMovieSceneCameraShakeSourceTrigger(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060222CA RID: 139978 RVA: 0x00328860 File Offset: 0x00326A60
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneCameraShakeSourceTrigger(Pointer, false, true);
		}

		// Token: 0x060222CB RID: 139979 RVA: 0x0032886A File Offset: 0x00326A6A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneCameraShakeSourceTrigger(Pointer, MemoryOwner);
		}

		// Token: 0x040123D5 RID: 74709
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTrigger";

		// Token: 0x040123D6 RID: 74710
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040123D7 RID: 74711
		internal static int __PropertyOffset_ShakeClass;

		// Token: 0x040123D8 RID: 74712
		internal static int __PropertyOffset_PlayScale;

		// Token: 0x040123D9 RID: 74713
		internal static int __PropertyOffset_PlaySpace;

		// Token: 0x040123DA RID: 74714
		internal static int __PropertyOffset_UserDefinedPlaySpace;
	}
}
