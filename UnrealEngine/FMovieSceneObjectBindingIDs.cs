using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200241B RID: 9243
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneObjectBindingIDs")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMovieSceneObjectBindingIDs : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022A3D RID: 141885 RVA: 0x00333A0A File Offset: 0x00331C0A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneObjectBindingIDs._ScriptStructPtr != 0) ? FMovieSceneObjectBindingIDs._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneObjectBindingIDs", ref FMovieSceneObjectBindingIDs._ScriptStructPtr);
		}

		// Token: 0x1700854B RID: 34123
		// (get) Token: 0x06022A3E RID: 141886 RVA: 0x00333A30 File Offset: 0x00331C30
		// (set) Token: 0x06022A3F RID: 141887 RVA: 0x00333A73 File Offset: 0x00331C73
		public TArray<FMovieSceneObjectBindingID> IDs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneObjectBindingID> result;
				if ((result = this._IDs) == null)
				{
					result = (this._IDs = new TArray<FMovieSceneObjectBindingID>(base.NativePtr + (IntPtr)FMovieSceneObjectBindingIDs.__PropertyOffset_IDs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.IDs.CopyAssign(value);
			}
		}

		// Token: 0x06022A40 RID: 141888 RVA: 0x00333A81 File Offset: 0x00331C81
		public FMovieSceneObjectBindingIDs()
		{
		}

		// Token: 0x06022A41 RID: 141889 RVA: 0x00333A89 File Offset: 0x00331C89
		public FMovieSceneObjectBindingIDs(TArray<FMovieSceneObjectBindingID> IDs)
		{
			this.IDs = IDs;
		}

		// Token: 0x06022A42 RID: 141890 RVA: 0x00333A98 File Offset: 0x00331C98
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneObjectBindingIDs.StaticStruct();
		}

		// Token: 0x06022A43 RID: 141891 RVA: 0x00333AA4 File Offset: 0x00331CA4
		[NullableContext(2)]
		public FMovieSceneObjectBindingIDs(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022A44 RID: 141892 RVA: 0x00333AAE File Offset: 0x00331CAE
		public FMovieSceneObjectBindingIDs(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022A45 RID: 141893 RVA: 0x00333AB9 File Offset: 0x00331CB9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneObjectBindingIDs(Pointer, false, true);
		}

		// Token: 0x06022A46 RID: 141894 RVA: 0x00333AC3 File Offset: 0x00331CC3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneObjectBindingIDs(Pointer, MemoryOwner);
		}

		// Token: 0x04012821 RID: 75809
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneObjectBindingIDs";

		// Token: 0x04012822 RID: 75810
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012823 RID: 75811
		internal static int __PropertyOffset_IDs;

		// Token: 0x04012824 RID: 75812
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneObjectBindingID> _IDs;
	}
}
