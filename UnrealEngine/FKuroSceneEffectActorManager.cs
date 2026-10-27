using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001BA6 RID: 7078
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSceneEffectActorManager")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FKuroSceneEffectActorManager : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B114 RID: 110868 RVA: 0x0027E180 File Offset: 0x0027C380
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroSceneEffectActorManager._ScriptStructPtr != 0) ? FKuroSceneEffectActorManager._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroSceneEffectActorManager", ref FKuroSceneEffectActorManager._ScriptStructPtr);
		}

		// Token: 0x17006C7B RID: 27771
		// (get) Token: 0x0601B115 RID: 110869 RVA: 0x0027E1A4 File Offset: 0x0027C3A4
		// (set) Token: 0x0601B116 RID: 110870 RVA: 0x0027E1E7 File Offset: 0x0027C3E7
		public TArray<AKuroSceneEffectActor> SceneEffectActorsHiding
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AKuroSceneEffectActor> result;
				if ((result = this._SceneEffectActorsHiding) == null)
				{
					result = (this._SceneEffectActorsHiding = new TArray<AKuroSceneEffectActor>(base.NativePtr + (IntPtr)FKuroSceneEffectActorManager.__PropertyOffset_SceneEffectActorsHiding, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SceneEffectActorsHiding.CopyAssign(value);
			}
		}

		// Token: 0x17006C7C RID: 27772
		// (get) Token: 0x0601B117 RID: 110871 RVA: 0x0027E1F8 File Offset: 0x0027C3F8
		// (set) Token: 0x0601B118 RID: 110872 RVA: 0x0027E23B File Offset: 0x0027C43B
		public TArray<AKuroSceneEffectActor> SceneEffectActorsShowing
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AKuroSceneEffectActor> result;
				if ((result = this._SceneEffectActorsShowing) == null)
				{
					result = (this._SceneEffectActorsShowing = new TArray<AKuroSceneEffectActor>(base.NativePtr + (IntPtr)FKuroSceneEffectActorManager.__PropertyOffset_SceneEffectActorsShowing, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SceneEffectActorsShowing.CopyAssign(value);
			}
		}

		// Token: 0x0601B119 RID: 110873 RVA: 0x0027E249 File Offset: 0x0027C449
		public FKuroSceneEffectActorManager()
		{
		}

		// Token: 0x0601B11A RID: 110874 RVA: 0x0027E251 File Offset: 0x0027C451
		public FKuroSceneEffectActorManager(TArray<AKuroSceneEffectActor> SceneEffectActorsHiding, TArray<AKuroSceneEffectActor> SceneEffectActorsShowing)
		{
			this.SceneEffectActorsHiding = SceneEffectActorsHiding;
			this.SceneEffectActorsShowing = SceneEffectActorsShowing;
		}

		// Token: 0x0601B11B RID: 110875 RVA: 0x0027E267 File Offset: 0x0027C467
		protected override IntPtr GetUStructPtr()
		{
			return FKuroSceneEffectActorManager.StaticStruct();
		}

		// Token: 0x0601B11C RID: 110876 RVA: 0x0027E273 File Offset: 0x0027C473
		[NullableContext(2)]
		public FKuroSceneEffectActorManager(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B11D RID: 110877 RVA: 0x0027E27D File Offset: 0x0027C47D
		public FKuroSceneEffectActorManager(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B11E RID: 110878 RVA: 0x0027E288 File Offset: 0x0027C488
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroSceneEffectActorManager(Pointer, false, true);
		}

		// Token: 0x0601B11F RID: 110879 RVA: 0x0027E292 File Offset: 0x0027C492
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroSceneEffectActorManager(Pointer, MemoryOwner);
		}

		// Token: 0x0400E92C RID: 59692
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSceneEffectActorManager";

		// Token: 0x0400E92D RID: 59693
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E92E RID: 59694
		internal static int __PropertyOffset_SceneEffectActorsHiding;

		// Token: 0x0400E92F RID: 59695
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AKuroSceneEffectActor> _SceneEffectActorsHiding;

		// Token: 0x0400E930 RID: 59696
		internal static int __PropertyOffset_SceneEffectActorsShowing;

		// Token: 0x0400E931 RID: 59697
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AKuroSceneEffectActor> _SceneEffectActorsShowing;
	}
}
