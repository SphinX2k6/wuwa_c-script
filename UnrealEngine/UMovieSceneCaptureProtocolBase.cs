using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002313 RID: 8979
	[UnrealObjectPath("/Script/MovieSceneCapture.MovieSceneCaptureProtocolBase")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public abstract class UMovieSceneCaptureProtocolBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021FDA RID: 139226 RVA: 0x0032428A File Offset: 0x0032248A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneCaptureProtocolBase._ClassPtr;
		}

		// Token: 0x17008358 RID: 33624
		// (get) Token: 0x06021FDB RID: 139227 RVA: 0x00324296 File Offset: 0x00322496
		// (set) Token: 0x06021FDC RID: 139228 RVA: 0x003242A6 File Offset: 0x003224A6
		public unsafe EMovieSceneCaptureProtocolState State
		{
			get
			{
				return (EMovieSceneCaptureProtocolState)(*(base.NativePtr + (IntPtr)UMovieSceneCaptureProtocolBase.__PropertyOffset_State));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneCaptureProtocolBase.__PropertyOffset_State) = (byte)value;
			}
		}

		// Token: 0x06021FDD RID: 139229 RVA: 0x003242B7 File Offset: 0x003224B7
		public bool IsCapturing()
		{
			return UMovieSceneCaptureProtocolBase.__IsCapturing_Internal(base.NativePtr);
		}

		// Token: 0x06021FDE RID: 139230 RVA: 0x003242C4 File Offset: 0x003224C4
		public EMovieSceneCaptureProtocolState GetState()
		{
			return UMovieSceneCaptureProtocolBase.__GetState_Internal(base.NativePtr);
		}

		// Token: 0x06021FDF RID: 139231
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsCapturing_Internal(IntPtr @this);

		// Token: 0x06021FE0 RID: 139232
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EMovieSceneCaptureProtocolState __GetState_Internal(IntPtr @this);

		// Token: 0x06021FE1 RID: 139233 RVA: 0x003242D1 File Offset: 0x003224D1
		static UMovieSceneCaptureProtocolBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneCapture.MovieSceneCaptureProtocolBase");
		}

		// Token: 0x06021FE2 RID: 139234 RVA: 0x003242E0 File Offset: 0x003224E0
		protected UMovieSceneCaptureProtocolBase() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCaptureProtocolBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021FE3 RID: 139235 RVA: 0x00324308 File Offset: 0x00322508
		protected UMovieSceneCaptureProtocolBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401221D RID: 74269
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneCapture.MovieSceneCaptureProtocolBase";

		// Token: 0x0401221E RID: 74270
		private static IntPtr _ClassPtr;

		// Token: 0x0401221F RID: 74271
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012220 RID: 74272
		internal static int __PropertyOffset_State;
	}
}
