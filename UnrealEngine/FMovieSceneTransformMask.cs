using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023B1 RID: 9137
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneTransformMask")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FMovieSceneTransformMask : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602266E RID: 140910 RVA: 0x0032E192 File Offset: 0x0032C392
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneTransformMask._ScriptStructPtr != 0) ? FMovieSceneTransformMask._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneTransformMask", ref FMovieSceneTransformMask._ScriptStructPtr);
		}

		// Token: 0x17008493 RID: 33939
		// (get) Token: 0x0602266F RID: 140911 RVA: 0x0032E1B6 File Offset: 0x0032C3B6
		// (set) Token: 0x06022670 RID: 140912 RVA: 0x0032E1C6 File Offset: 0x0032C3C6
		public unsafe uint Mask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneTransformMask.__PropertyOffset_Mask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneTransformMask.__PropertyOffset_Mask) = (int)value;
			}
		}

		// Token: 0x06022671 RID: 140913 RVA: 0x0032E1D7 File Offset: 0x0032C3D7
		public FMovieSceneTransformMask()
		{
		}

		// Token: 0x06022672 RID: 140914 RVA: 0x0032E1DF File Offset: 0x0032C3DF
		public FMovieSceneTransformMask(uint Mask)
		{
			this.Mask = Mask;
		}

		// Token: 0x06022673 RID: 140915 RVA: 0x0032E1EE File Offset: 0x0032C3EE
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneTransformMask.StaticStruct();
		}

		// Token: 0x06022674 RID: 140916 RVA: 0x0032E1FA File Offset: 0x0032C3FA
		[NullableContext(2)]
		public FMovieSceneTransformMask(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022675 RID: 140917 RVA: 0x0032E204 File Offset: 0x0032C404
		public FMovieSceneTransformMask(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022676 RID: 140918 RVA: 0x0032E20F File Offset: 0x0032C40F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneTransformMask(Pointer, false, true);
		}

		// Token: 0x06022677 RID: 140919 RVA: 0x0032E219 File Offset: 0x0032C419
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneTransformMask(Pointer, MemoryOwner);
		}

		// Token: 0x040125DB RID: 75227
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneTransformMask";

		// Token: 0x040125DC RID: 75228
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040125DD RID: 75229
		internal static int __PropertyOffset_Mask;
	}
}
