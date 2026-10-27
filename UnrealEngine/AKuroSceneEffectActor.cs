using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BA5 RID: 7077
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSceneEffectActor")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class AKuroSceneEffectActor : AKuroEffectActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B105 RID: 110853 RVA: 0x0027E05E File Offset: 0x0027C25E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroSceneEffectActor._ClassPtr;
		}

		// Token: 0x0601B106 RID: 110854 RVA: 0x0027E06C File Offset: 0x0027C26C
		public AKuroSceneEffectActor() : this(BuiltinUtils.AllocNativeUObject(AKuroSceneEffectActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B107 RID: 110855 RVA: 0x0027E094 File Offset: 0x0027C294
		public AKuroSceneEffectActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroSceneEffectActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006C79 RID: 27769
		// (get) Token: 0x0601B108 RID: 110856 RVA: 0x0027E0C7 File Offset: 0x0027C2C7
		// (set) Token: 0x0601B109 RID: 110857 RVA: 0x0027E0D7 File Offset: 0x0027C2D7
		public unsafe bool bIsSceneEffectHidden
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSceneEffectActor.__PropertyOffset_bIsSceneEffectHidden) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSceneEffectActor.__PropertyOffset_bIsSceneEffectHidden) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C7A RID: 27770
		// (get) Token: 0x0601B10A RID: 110858 RVA: 0x0027E0E8 File Offset: 0x0027C2E8
		// (set) Token: 0x0601B10B RID: 110859 RVA: 0x0027E121 File Offset: 0x0027C321
		public FNiagaraDiKuroRenderingParameters NiagaraDiKuroRenderingParameters
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraDiKuroRenderingParameters result;
				if ((result = this._NiagaraDiKuroRenderingParameters) == null)
				{
					result = (this._NiagaraDiKuroRenderingParameters = new FNiagaraDiKuroRenderingParameters(base.NativePtr + (IntPtr)AKuroSceneEffectActor.__PropertyOffset_NiagaraDiKuroRenderingParameters, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraDiKuroRenderingParameters.StaticStruct(), base.NativePtr + (IntPtr)AKuroSceneEffectActor.__PropertyOffset_NiagaraDiKuroRenderingParameters, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601B10C RID: 110860 RVA: 0x0027E142 File Offset: 0x0027C342
		public virtual void OnReceiveShowSceneEffectActor()
		{
			AKuroSceneEffectActor.__OnReceiveShowSceneEffectActor_Internal(base.NativePtr);
		}

		// Token: 0x0601B10D RID: 110861 RVA: 0x0027E14F File Offset: 0x0027C34F
		public virtual void OnReceiveHideSceneEffectActor()
		{
			AKuroSceneEffectActor.__OnReceiveHideSceneEffectActor_Internal(base.NativePtr);
		}

		// Token: 0x0601B10E RID: 110862 RVA: 0x0027E15C File Offset: 0x0027C35C
		public bool GetIsWorldPartitionActor()
		{
			return AKuroSceneEffectActor.__GetIsWorldPartitionActor_Internal(base.NativePtr);
		}

		// Token: 0x0601B10F RID: 110863
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnReceiveShowSceneEffectActor_Internal(IntPtr @this);

		// Token: 0x0601B110 RID: 110864
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnReceiveHideSceneEffectActor_Internal(IntPtr @this);

		// Token: 0x0601B111 RID: 110865
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIsWorldPartitionActor_Internal(IntPtr @this);

		// Token: 0x0601B112 RID: 110866 RVA: 0x0027E169 File Offset: 0x0027C369
		static AKuroSceneEffectActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSceneEffectActor");
		}

		// Token: 0x0601B113 RID: 110867 RVA: 0x0027E177 File Offset: 0x0027C377
		protected AKuroSceneEffectActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E926 RID: 59686
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSceneEffectActor";

		// Token: 0x0400E927 RID: 59687
		private static IntPtr _ClassPtr;

		// Token: 0x0400E928 RID: 59688
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E929 RID: 59689
		internal static int __PropertyOffset_bIsSceneEffectHidden;

		// Token: 0x0400E92A RID: 59690
		internal static int __PropertyOffset_NiagaraDiKuroRenderingParameters;

		// Token: 0x0400E92B RID: 59691
		[Nullable(2)]
		private FNiagaraDiKuroRenderingParameters _NiagaraDiKuroRenderingParameters;
	}
}
