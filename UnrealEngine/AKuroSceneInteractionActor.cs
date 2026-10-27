using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BA7 RID: 7079
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSceneInteractionActor")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public class AKuroSceneInteractionActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B120 RID: 110880 RVA: 0x0027E29B File Offset: 0x0027C49B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroSceneInteractionActor._ClassPtr;
		}

		// Token: 0x0601B121 RID: 110881 RVA: 0x0027E2A8 File Offset: 0x0027C4A8
		public AKuroSceneInteractionActor() : this(BuiltinUtils.AllocNativeUObject(AKuroSceneInteractionActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B122 RID: 110882 RVA: 0x0027E2D0 File Offset: 0x0027C4D0
		[NullableContext(1)]
		public AKuroSceneInteractionActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroSceneInteractionActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601B123 RID: 110883 RVA: 0x0027E303 File Offset: 0x0027C503
		public virtual void OnSetState(EKuroSceneInteractionState TargetState, bool NeedTransition)
		{
			AKuroSceneInteractionActor.__OnSetState_Internal(base.NativePtr, TargetState, NeedTransition);
		}

		// Token: 0x0601B124 RID: 110884
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnSetState_Internal(IntPtr @this, EKuroSceneInteractionState TargetState, bool NeedTransition);

		// Token: 0x0601B125 RID: 110885 RVA: 0x0027E312 File Offset: 0x0027C512
		static AKuroSceneInteractionActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSceneInteractionActor");
		}

		// Token: 0x0601B126 RID: 110886 RVA: 0x0027E320 File Offset: 0x0027C520
		protected AKuroSceneInteractionActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E932 RID: 59698
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSceneInteractionActor";

		// Token: 0x0400E933 RID: 59699
		private static IntPtr _ClassPtr;

		// Token: 0x0400E934 RID: 59700
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x02003172 RID: 12658
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __OnSetState_FunctionParams
		{
			// Token: 0x04016FA1 RID: 94113
			[FieldOffset(0)]
			public EKuroSceneInteractionState TargetState;

			// Token: 0x04016FA2 RID: 94114
			[FieldOffset(1)]
			public bool NeedTransition;
		}
	}
}
