using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023ED RID: 9197
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEntitySystemGraph")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 312)]
	public class FMovieSceneEntitySystemGraph : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022855 RID: 141397 RVA: 0x003310BB File Offset: 0x0032F2BB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEntitySystemGraph._ScriptStructPtr != 0) ? FMovieSceneEntitySystemGraph._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEntitySystemGraph", ref FMovieSceneEntitySystemGraph._ScriptStructPtr);
		}

		// Token: 0x170084F8 RID: 34040
		// (get) Token: 0x06022856 RID: 141398 RVA: 0x003310E0 File Offset: 0x0032F2E0
		// (set) Token: 0x06022857 RID: 141399 RVA: 0x00331123 File Offset: 0x0032F323
		public FMovieSceneEntitySystemGraphNodes Nodes
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneEntitySystemGraphNodes result;
				if ((result = this._Nodes) == null)
				{
					result = (this._Nodes = new FMovieSceneEntitySystemGraphNodes(base.NativePtr + (IntPtr)FMovieSceneEntitySystemGraph.__PropertyOffset_Nodes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneEntitySystemGraphNodes.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneEntitySystemGraph.__PropertyOffset_Nodes, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022858 RID: 141400 RVA: 0x00331144 File Offset: 0x0032F344
		public FMovieSceneEntitySystemGraph()
		{
		}

		// Token: 0x06022859 RID: 141401 RVA: 0x0033114C File Offset: 0x0032F34C
		public FMovieSceneEntitySystemGraph(FMovieSceneEntitySystemGraphNodes Nodes)
		{
			this.Nodes = Nodes;
		}

		// Token: 0x0602285A RID: 141402 RVA: 0x0033115B File Offset: 0x0032F35B
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEntitySystemGraph.StaticStruct();
		}

		// Token: 0x0602285B RID: 141403 RVA: 0x00331167 File Offset: 0x0032F367
		[NullableContext(2)]
		public FMovieSceneEntitySystemGraph(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602285C RID: 141404 RVA: 0x00331171 File Offset: 0x0032F371
		public FMovieSceneEntitySystemGraph(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602285D RID: 141405 RVA: 0x0033117C File Offset: 0x0032F37C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEntitySystemGraph(Pointer, false, true);
		}

		// Token: 0x0602285E RID: 141406 RVA: 0x00331186 File Offset: 0x0032F386
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEntitySystemGraph(Pointer, MemoryOwner);
		}

		// Token: 0x04012741 RID: 75585
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEntitySystemGraph";

		// Token: 0x04012742 RID: 75586
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012743 RID: 75587
		internal static int __PropertyOffset_Nodes;

		// Token: 0x04012744 RID: 75588
		[Nullable(2)]
		private FMovieSceneEntitySystemGraphNodes _Nodes;
	}
}
