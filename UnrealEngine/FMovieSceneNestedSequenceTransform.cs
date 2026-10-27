using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002417 RID: 9239
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneNestedSequenceTransform")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FMovieSceneNestedSequenceTransform : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022A19 RID: 141849 RVA: 0x003336E1 File Offset: 0x003318E1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneNestedSequenceTransform._ScriptStructPtr != 0) ? FMovieSceneNestedSequenceTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneNestedSequenceTransform", ref FMovieSceneNestedSequenceTransform._ScriptStructPtr);
		}

		// Token: 0x17008546 RID: 34118
		// (get) Token: 0x06022A1A RID: 141850 RVA: 0x00333708 File Offset: 0x00331908
		// (set) Token: 0x06022A1B RID: 141851 RVA: 0x0033374B File Offset: 0x0033194B
		public FMovieSceneTimeTransform LinearTransform
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneTimeTransform result;
				if ((result = this._LinearTransform) == null)
				{
					result = (this._LinearTransform = new FMovieSceneTimeTransform(base.NativePtr + (IntPtr)FMovieSceneNestedSequenceTransform.__PropertyOffset_LinearTransform, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneTimeTransform.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneNestedSequenceTransform.__PropertyOffset_LinearTransform, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008547 RID: 34119
		// (get) Token: 0x06022A1C RID: 141852 RVA: 0x0033376C File Offset: 0x0033196C
		// (set) Token: 0x06022A1D RID: 141853 RVA: 0x003337AF File Offset: 0x003319AF
		public FMovieSceneTimeWarping Warping
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneTimeWarping result;
				if ((result = this._Warping) == null)
				{
					result = (this._Warping = new FMovieSceneTimeWarping(base.NativePtr + (IntPtr)FMovieSceneNestedSequenceTransform.__PropertyOffset_Warping, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneTimeWarping.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneNestedSequenceTransform.__PropertyOffset_Warping, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022A1E RID: 141854 RVA: 0x003337D0 File Offset: 0x003319D0
		public FMovieSceneNestedSequenceTransform()
		{
		}

		// Token: 0x06022A1F RID: 141855 RVA: 0x003337D8 File Offset: 0x003319D8
		public FMovieSceneNestedSequenceTransform(FMovieSceneTimeTransform LinearTransform, FMovieSceneTimeWarping Warping)
		{
			this.LinearTransform = LinearTransform;
			this.Warping = Warping;
		}

		// Token: 0x06022A20 RID: 141856 RVA: 0x003337EE File Offset: 0x003319EE
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneNestedSequenceTransform.StaticStruct();
		}

		// Token: 0x06022A21 RID: 141857 RVA: 0x003337FA File Offset: 0x003319FA
		[NullableContext(2)]
		public FMovieSceneNestedSequenceTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022A22 RID: 141858 RVA: 0x00333804 File Offset: 0x00331A04
		public FMovieSceneNestedSequenceTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022A23 RID: 141859 RVA: 0x0033380F File Offset: 0x00331A0F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneNestedSequenceTransform(Pointer, false, true);
		}

		// Token: 0x06022A24 RID: 141860 RVA: 0x00333819 File Offset: 0x00331A19
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneNestedSequenceTransform(Pointer, MemoryOwner);
		}

		// Token: 0x04012810 RID: 75792
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneNestedSequenceTransform";

		// Token: 0x04012811 RID: 75793
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012812 RID: 75794
		internal static int __PropertyOffset_LinearTransform;

		// Token: 0x04012813 RID: 75795
		[Nullable(2)]
		private FMovieSceneTimeTransform _LinearTransform;

		// Token: 0x04012814 RID: 75796
		internal static int __PropertyOffset_Warping;

		// Token: 0x04012815 RID: 75797
		[Nullable(2)]
		private FMovieSceneTimeWarping _Warping;
	}
}
