using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004DE RID: 1246
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSceneEffectActor")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class AKuroSceneEffectActor : AKuroEffectActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060075CB RID: 30155 RVA: 0x000AC319 File Offset: 0x000AA519
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroSceneEffectActor._ClassPtr;
		}

		// Token: 0x060075CC RID: 30156 RVA: 0x000AC328 File Offset: 0x000AA528
		public AKuroSceneEffectActor() : this(BuiltinUtils.AllocNativeUObject(AKuroSceneEffectActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060075CD RID: 30157 RVA: 0x000AC350 File Offset: 0x000AA550
		[NullableContext(1)]
		public AKuroSceneEffectActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroSceneEffectActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170016B8 RID: 5816
		// (get) Token: 0x060075CE RID: 30158 RVA: 0x000AC383 File Offset: 0x000AA583
		// (set) Token: 0x060075CF RID: 30159 RVA: 0x000AC393 File Offset: 0x000AA593
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

		// Token: 0x060075D0 RID: 30160 RVA: 0x000AC3A4 File Offset: 0x000AA5A4
		public virtual void OnReceiveShowSceneEffectActor()
		{
			AKuroSceneEffectActor.__OnReceiveShowSceneEffectActor_Internal(base.NativePtr);
		}

		// Token: 0x060075D1 RID: 30161 RVA: 0x000AC3B1 File Offset: 0x000AA5B1
		public virtual void OnReceiveHideSceneEffectActor()
		{
			AKuroSceneEffectActor.__OnReceiveHideSceneEffectActor_Internal(base.NativePtr);
		}

		// Token: 0x060075D2 RID: 30162 RVA: 0x000AC3BE File Offset: 0x000AA5BE
		public bool GetIsWorldPartitionActor()
		{
			return AKuroSceneEffectActor.__GetIsWorldPartitionActor_Internal(base.NativePtr);
		}

		// Token: 0x060075D3 RID: 30163
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnReceiveShowSceneEffectActor_Internal(IntPtr @this);

		// Token: 0x060075D4 RID: 30164
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnReceiveHideSceneEffectActor_Internal(IntPtr @this);

		// Token: 0x060075D5 RID: 30165
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIsWorldPartitionActor_Internal(IntPtr @this);

		// Token: 0x060075D6 RID: 30166 RVA: 0x000AC3CB File Offset: 0x000AA5CB
		static AKuroSceneEffectActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSceneEffectActor");
		}

		// Token: 0x060075D7 RID: 30167 RVA: 0x000AC3D9 File Offset: 0x000AA5D9
		protected AKuroSceneEffectActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040031B2 RID: 12722
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSceneEffectActor";

		// Token: 0x040031B3 RID: 12723
		private static IntPtr _ClassPtr;

		// Token: 0x040031B4 RID: 12724
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040031B5 RID: 12725
		internal static int __PropertyOffset_bIsSceneEffectHidden;
	}
}
