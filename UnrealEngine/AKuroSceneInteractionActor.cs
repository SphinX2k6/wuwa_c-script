using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004DF RID: 1247
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSceneInteractionActor")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public class AKuroSceneInteractionActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060075D8 RID: 30168 RVA: 0x000AC3E2 File Offset: 0x000AA5E2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroSceneInteractionActor._ClassPtr;
		}

		// Token: 0x060075D9 RID: 30169 RVA: 0x000AC3F0 File Offset: 0x000AA5F0
		public AKuroSceneInteractionActor() : this(BuiltinUtils.AllocNativeUObject(AKuroSceneInteractionActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060075DA RID: 30170 RVA: 0x000AC418 File Offset: 0x000AA618
		[NullableContext(1)]
		public AKuroSceneInteractionActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroSceneInteractionActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060075DB RID: 30171 RVA: 0x000AC44B File Offset: 0x000AA64B
		public virtual void OnSetState(EKuroSceneInteractionState TargetState, bool NeedTransition)
		{
			AKuroSceneInteractionActor.__OnSetState_Internal(base.NativePtr, TargetState, NeedTransition);
		}

		// Token: 0x060075DC RID: 30172
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnSetState_Internal(IntPtr @this, EKuroSceneInteractionState TargetState, bool NeedTransition);

		// Token: 0x060075DD RID: 30173 RVA: 0x000AC45A File Offset: 0x000AA65A
		static AKuroSceneInteractionActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSceneInteractionActor");
		}

		// Token: 0x060075DE RID: 30174 RVA: 0x000AC468 File Offset: 0x000AA668
		protected AKuroSceneInteractionActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040031B6 RID: 12726
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSceneInteractionActor";

		// Token: 0x040031B7 RID: 12727
		private static IntPtr _ClassPtr;

		// Token: 0x040031B8 RID: 12728
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x02000C1F RID: 3103
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __OnSetState_FunctionParams
		{
			// Token: 0x04005E66 RID: 24166
			[FieldOffset(0)]
			public EKuroSceneInteractionState TargetState;

			// Token: 0x04005E67 RID: 24167
			[FieldOffset(1)]
			public bool NeedTransition;
		}
	}
}
