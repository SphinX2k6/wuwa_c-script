using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002451 RID: 9297
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneTrackIdentifier")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FMovieSceneTrackIdentifier : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022D9B RID: 142747 RVA: 0x003389A7 File Offset: 0x00336BA7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneTrackIdentifier._ScriptStructPtr != 0) ? FMovieSceneTrackIdentifier._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneTrackIdentifier", ref FMovieSceneTrackIdentifier._ScriptStructPtr);
		}

		// Token: 0x170085FE RID: 34302
		// (get) Token: 0x06022D9C RID: 142748 RVA: 0x003389CB File Offset: 0x00336BCB
		// (set) Token: 0x06022D9D RID: 142749 RVA: 0x003389DB File Offset: 0x00336BDB
		public unsafe uint Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneTrackIdentifier.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneTrackIdentifier.__PropertyOffset_Value) = (int)value;
			}
		}

		// Token: 0x06022D9E RID: 142750 RVA: 0x003389EC File Offset: 0x00336BEC
		public FMovieSceneTrackIdentifier()
		{
		}

		// Token: 0x06022D9F RID: 142751 RVA: 0x003389F4 File Offset: 0x00336BF4
		public FMovieSceneTrackIdentifier(uint Value)
		{
			this.Value = Value;
		}

		// Token: 0x06022DA0 RID: 142752 RVA: 0x00338A03 File Offset: 0x00336C03
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneTrackIdentifier.StaticStruct();
		}

		// Token: 0x06022DA1 RID: 142753 RVA: 0x00338A0F File Offset: 0x00336C0F
		[NullableContext(2)]
		public FMovieSceneTrackIdentifier(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022DA2 RID: 142754 RVA: 0x00338A19 File Offset: 0x00336C19
		public FMovieSceneTrackIdentifier(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022DA3 RID: 142755 RVA: 0x00338A24 File Offset: 0x00336C24
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneTrackIdentifier(Pointer, false, true);
		}

		// Token: 0x06022DA4 RID: 142756 RVA: 0x00338A2E File Offset: 0x00336C2E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneTrackIdentifier(Pointer, MemoryOwner);
		}

		// Token: 0x040129BE RID: 76222
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneTrackIdentifier";

		// Token: 0x040129BF RID: 76223
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040129C0 RID: 76224
		internal static int __PropertyOffset_Value;
	}
}
