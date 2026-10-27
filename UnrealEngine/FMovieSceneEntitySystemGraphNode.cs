using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023EE RID: 9198
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEntitySystemGraphNode")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FMovieSceneEntitySystemGraphNode : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602285F RID: 141407 RVA: 0x0033118F File Offset: 0x0032F38F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEntitySystemGraphNode._ScriptStructPtr != 0) ? FMovieSceneEntitySystemGraphNode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEntitySystemGraphNode", ref FMovieSceneEntitySystemGraphNode._ScriptStructPtr);
		}

		// Token: 0x170084F9 RID: 34041
		// (get) Token: 0x06022860 RID: 141408 RVA: 0x003311B3 File Offset: 0x0032F3B3
		// (set) Token: 0x06022861 RID: 141409 RVA: 0x003311C7 File Offset: 0x0032F3C7
		[Nullable(2)]
		public unsafe UMovieSceneEntitySystem System
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneEntitySystem>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneEntitySystemGraphNode.__PropertyOffset_System);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneEntitySystemGraphNode.__PropertyOffset_System, value);
			}
		}

		// Token: 0x06022862 RID: 141410 RVA: 0x003311DC File Offset: 0x0032F3DC
		public FMovieSceneEntitySystemGraphNode()
		{
		}

		// Token: 0x06022863 RID: 141411 RVA: 0x003311E4 File Offset: 0x0032F3E4
		[NullableContext(1)]
		public FMovieSceneEntitySystemGraphNode(UMovieSceneEntitySystem System)
		{
			this.System = System;
		}

		// Token: 0x06022864 RID: 141412 RVA: 0x003311F3 File Offset: 0x0032F3F3
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEntitySystemGraphNode.StaticStruct();
		}

		// Token: 0x06022865 RID: 141413 RVA: 0x003311FF File Offset: 0x0032F3FF
		[NullableContext(2)]
		public FMovieSceneEntitySystemGraphNode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022866 RID: 141414 RVA: 0x00331209 File Offset: 0x0032F409
		public FMovieSceneEntitySystemGraphNode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022867 RID: 141415 RVA: 0x00331214 File Offset: 0x0032F414
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEntitySystemGraphNode(Pointer, false, true);
		}

		// Token: 0x06022868 RID: 141416 RVA: 0x0033121E File Offset: 0x0032F41E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEntitySystemGraphNode(Pointer, MemoryOwner);
		}

		// Token: 0x04012745 RID: 75589
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEntitySystemGraphNode";

		// Token: 0x04012746 RID: 75590
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012747 RID: 75591
		internal static int __PropertyOffset_System;
	}
}
