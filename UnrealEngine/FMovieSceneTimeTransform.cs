using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200244A RID: 9290
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneTimeTransform")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FMovieSceneTimeTransform : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022D3D RID: 142653 RVA: 0x0033809E File Offset: 0x0033629E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneTimeTransform._ScriptStructPtr != 0) ? FMovieSceneTimeTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneTimeTransform", ref FMovieSceneTimeTransform._ScriptStructPtr);
		}

		// Token: 0x170085E9 RID: 34281
		// (get) Token: 0x06022D3E RID: 142654 RVA: 0x003380C2 File Offset: 0x003362C2
		// (set) Token: 0x06022D3F RID: 142655 RVA: 0x003380D2 File Offset: 0x003362D2
		public unsafe float TimeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneTimeTransform.__PropertyOffset_TimeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneTimeTransform.__PropertyOffset_TimeScale) = value;
			}
		}

		// Token: 0x170085EA RID: 34282
		// (get) Token: 0x06022D40 RID: 142656 RVA: 0x003380E4 File Offset: 0x003362E4
		// (set) Token: 0x06022D41 RID: 142657 RVA: 0x00338127 File Offset: 0x00336327
		public FFrameTime Offset
		{
			get
			{
				base.FastCheckIsValid();
				FFrameTime result;
				if ((result = this._Offset) == null)
				{
					result = (this._Offset = new FFrameTime(base.NativePtr + (IntPtr)FMovieSceneTimeTransform.__PropertyOffset_Offset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameTime.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneTimeTransform.__PropertyOffset_Offset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022D42 RID: 142658 RVA: 0x00338148 File Offset: 0x00336348
		public FMovieSceneTimeTransform()
		{
		}

		// Token: 0x06022D43 RID: 142659 RVA: 0x00338150 File Offset: 0x00336350
		public FMovieSceneTimeTransform(float TimeScale, FFrameTime Offset)
		{
			this.TimeScale = TimeScale;
			this.Offset = Offset;
		}

		// Token: 0x06022D44 RID: 142660 RVA: 0x00338166 File Offset: 0x00336366
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneTimeTransform.StaticStruct();
		}

		// Token: 0x06022D45 RID: 142661 RVA: 0x00338172 File Offset: 0x00336372
		[NullableContext(2)]
		public FMovieSceneTimeTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022D46 RID: 142662 RVA: 0x0033817C File Offset: 0x0033637C
		public FMovieSceneTimeTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022D47 RID: 142663 RVA: 0x00338187 File Offset: 0x00336387
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneTimeTransform(Pointer, false, true);
		}

		// Token: 0x06022D48 RID: 142664 RVA: 0x00338191 File Offset: 0x00336391
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneTimeTransform(Pointer, MemoryOwner);
		}

		// Token: 0x0401298B RID: 76171
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneTimeTransform";

		// Token: 0x0401298C RID: 76172
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401298D RID: 76173
		internal static int __PropertyOffset_TimeScale;

		// Token: 0x0401298E RID: 76174
		internal static int __PropertyOffset_Offset;

		// Token: 0x0401298F RID: 76175
		[Nullable(2)]
		private FFrameTime _Offset;
	}
}
