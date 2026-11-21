using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000784 RID: 1924
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneObjectBindingIDs")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMovieSceneObjectBindingIDs : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A5F4 RID: 42484 RVA: 0x000F50FB File Offset: 0x000F32FB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneObjectBindingIDs._ScriptStructPtr != 0) ? FMovieSceneObjectBindingIDs._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneObjectBindingIDs", ref FMovieSceneObjectBindingIDs._ScriptStructPtr);
		}

		// Token: 0x17001ECE RID: 7886
		// (get) Token: 0x0600A5F5 RID: 42485 RVA: 0x000F5120 File Offset: 0x000F3320
		// (set) Token: 0x0600A5F6 RID: 42486 RVA: 0x000F5163 File Offset: 0x000F3363
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

		// Token: 0x0600A5F7 RID: 42487 RVA: 0x000F5171 File Offset: 0x000F3371
		public FMovieSceneObjectBindingIDs()
		{
		}

		// Token: 0x0600A5F8 RID: 42488 RVA: 0x000F5179 File Offset: 0x000F3379
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneObjectBindingIDs.StaticStruct();
		}

		// Token: 0x0600A5F9 RID: 42489 RVA: 0x000F5185 File Offset: 0x000F3385
		[NullableContext(2)]
		public FMovieSceneObjectBindingIDs(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A5FA RID: 42490 RVA: 0x000F518F File Offset: 0x000F338F
		public FMovieSceneObjectBindingIDs(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A5FB RID: 42491 RVA: 0x000F519A File Offset: 0x000F339A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneObjectBindingIDs(Pointer, false, true);
		}

		// Token: 0x0600A5FC RID: 42492 RVA: 0x000F51A4 File Offset: 0x000F33A4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneObjectBindingIDs(Pointer, MemoryOwner);
		}

		// Token: 0x04004710 RID: 18192
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneObjectBindingIDs";

		// Token: 0x04004711 RID: 18193
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004712 RID: 18194
		internal static int __PropertyOffset_IDs;

		// Token: 0x04004713 RID: 18195
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneObjectBindingID> _IDs;
	}
}
