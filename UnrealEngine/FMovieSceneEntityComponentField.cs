using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023E9 RID: 9193
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEntityComponentField")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FMovieSceneEntityComponentField : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022837 RID: 141367 RVA: 0x00330D75 File Offset: 0x0032EF75
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEntityComponentField._ScriptStructPtr != 0) ? FMovieSceneEntityComponentField._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEntityComponentField", ref FMovieSceneEntityComponentField._ScriptStructPtr);
		}

		// Token: 0x170084F2 RID: 34034
		// (get) Token: 0x06022838 RID: 141368 RVA: 0x00330D9C File Offset: 0x0032EF9C
		// (set) Token: 0x06022839 RID: 141369 RVA: 0x00330DDF File Offset: 0x0032EFDF
		public FMovieSceneEvaluationFieldEntityTree PersistentEntityTree
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneEvaluationFieldEntityTree result;
				if ((result = this._PersistentEntityTree) == null)
				{
					result = (this._PersistentEntityTree = new FMovieSceneEvaluationFieldEntityTree(base.NativePtr + (IntPtr)FMovieSceneEntityComponentField.__PropertyOffset_PersistentEntityTree, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneEvaluationFieldEntityTree.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneEntityComponentField.__PropertyOffset_PersistentEntityTree, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170084F3 RID: 34035
		// (get) Token: 0x0602283A RID: 141370 RVA: 0x00330E00 File Offset: 0x0032F000
		// (set) Token: 0x0602283B RID: 141371 RVA: 0x00330E43 File Offset: 0x0032F043
		public FMovieSceneEvaluationFieldEntityTree OneShotEntityTree
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneEvaluationFieldEntityTree result;
				if ((result = this._OneShotEntityTree) == null)
				{
					result = (this._OneShotEntityTree = new FMovieSceneEvaluationFieldEntityTree(base.NativePtr + (IntPtr)FMovieSceneEntityComponentField.__PropertyOffset_OneShotEntityTree, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneEvaluationFieldEntityTree.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneEntityComponentField.__PropertyOffset_OneShotEntityTree, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170084F4 RID: 34036
		// (get) Token: 0x0602283C RID: 141372 RVA: 0x00330E64 File Offset: 0x0032F064
		// (set) Token: 0x0602283D RID: 141373 RVA: 0x00330EA7 File Offset: 0x0032F0A7
		public TArray<FMovieSceneEvaluationFieldEntity> Entities
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneEvaluationFieldEntity> result;
				if ((result = this._Entities) == null)
				{
					result = (this._Entities = new TArray<FMovieSceneEvaluationFieldEntity>(base.NativePtr + (IntPtr)FMovieSceneEntityComponentField.__PropertyOffset_Entities, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Entities.CopyAssign(value);
			}
		}

		// Token: 0x170084F5 RID: 34037
		// (get) Token: 0x0602283E RID: 141374 RVA: 0x00330EB8 File Offset: 0x0032F0B8
		// (set) Token: 0x0602283F RID: 141375 RVA: 0x00330EFB File Offset: 0x0032F0FB
		public TArray<FMovieSceneEvaluationFieldEntityMetaData> EntityMetaData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneEvaluationFieldEntityMetaData> result;
				if ((result = this._EntityMetaData) == null)
				{
					result = (this._EntityMetaData = new TArray<FMovieSceneEvaluationFieldEntityMetaData>(base.NativePtr + (IntPtr)FMovieSceneEntityComponentField.__PropertyOffset_EntityMetaData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EntityMetaData.CopyAssign(value);
			}
		}

		// Token: 0x170084F6 RID: 34038
		// (get) Token: 0x06022840 RID: 141376 RVA: 0x00330F0C File Offset: 0x0032F10C
		// (set) Token: 0x06022841 RID: 141377 RVA: 0x00330F4F File Offset: 0x0032F14F
		public TArray<FMovieSceneEvaluationFieldSharedEntityMetaData> SharedMetaData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneEvaluationFieldSharedEntityMetaData> result;
				if ((result = this._SharedMetaData) == null)
				{
					result = (this._SharedMetaData = new TArray<FMovieSceneEvaluationFieldSharedEntityMetaData>(base.NativePtr + (IntPtr)FMovieSceneEntityComponentField.__PropertyOffset_SharedMetaData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SharedMetaData.CopyAssign(value);
			}
		}

		// Token: 0x06022842 RID: 141378 RVA: 0x00330F5D File Offset: 0x0032F15D
		public FMovieSceneEntityComponentField()
		{
		}

		// Token: 0x06022843 RID: 141379 RVA: 0x00330F65 File Offset: 0x0032F165
		public FMovieSceneEntityComponentField(FMovieSceneEvaluationFieldEntityTree PersistentEntityTree, FMovieSceneEvaluationFieldEntityTree OneShotEntityTree, TArray<FMovieSceneEvaluationFieldEntity> Entities, TArray<FMovieSceneEvaluationFieldEntityMetaData> EntityMetaData, TArray<FMovieSceneEvaluationFieldSharedEntityMetaData> SharedMetaData)
		{
			this.PersistentEntityTree = PersistentEntityTree;
			this.OneShotEntityTree = OneShotEntityTree;
			this.Entities = Entities;
			this.EntityMetaData = EntityMetaData;
			this.SharedMetaData = SharedMetaData;
		}

		// Token: 0x06022844 RID: 141380 RVA: 0x00330F92 File Offset: 0x0032F192
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEntityComponentField.StaticStruct();
		}

		// Token: 0x06022845 RID: 141381 RVA: 0x00330F9E File Offset: 0x0032F19E
		[NullableContext(2)]
		public FMovieSceneEntityComponentField(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022846 RID: 141382 RVA: 0x00330FA8 File Offset: 0x0032F1A8
		public FMovieSceneEntityComponentField(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022847 RID: 141383 RVA: 0x00330FB3 File Offset: 0x0032F1B3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEntityComponentField(Pointer, false, true);
		}

		// Token: 0x06022848 RID: 141384 RVA: 0x00330FBD File Offset: 0x0032F1BD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEntityComponentField(Pointer, MemoryOwner);
		}

		// Token: 0x0401272D RID: 75565
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEntityComponentField";

		// Token: 0x0401272E RID: 75566
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401272F RID: 75567
		internal static int __PropertyOffset_PersistentEntityTree;

		// Token: 0x04012730 RID: 75568
		[Nullable(2)]
		private FMovieSceneEvaluationFieldEntityTree _PersistentEntityTree;

		// Token: 0x04012731 RID: 75569
		internal static int __PropertyOffset_OneShotEntityTree;

		// Token: 0x04012732 RID: 75570
		[Nullable(2)]
		private FMovieSceneEvaluationFieldEntityTree _OneShotEntityTree;

		// Token: 0x04012733 RID: 75571
		internal static int __PropertyOffset_Entities;

		// Token: 0x04012734 RID: 75572
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneEvaluationFieldEntity> _Entities;

		// Token: 0x04012735 RID: 75573
		internal static int __PropertyOffset_EntityMetaData;

		// Token: 0x04012736 RID: 75574
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneEvaluationFieldEntityMetaData> _EntityMetaData;

		// Token: 0x04012737 RID: 75575
		internal static int __PropertyOffset_SharedMetaData;

		// Token: 0x04012738 RID: 75576
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneEvaluationFieldSharedEntityMetaData> _SharedMetaData;
	}
}
