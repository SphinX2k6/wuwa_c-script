using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200087D RID: 2173
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBoneMeshActor")]
	[UnrealStructLayout(1280, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1280)]
	public class ABakedBoneMeshActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600764C RID: 30284 RVA: 0x000A9BEE File Offset: 0x000A7DEE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ABakedBoneMeshActor._ClassPtr;
		}

		// Token: 0x0600764D RID: 30285 RVA: 0x000A9BFC File Offset: 0x000A7DFC
		public ABakedBoneMeshActor() : this(BuiltinUtils.AllocNativeUObject(ABakedBoneMeshActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600764E RID: 30286 RVA: 0x000A9C24 File Offset: 0x000A7E24
		public ABakedBoneMeshActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABakedBoneMeshActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001BFF RID: 7167
		// (get) Token: 0x0600764F RID: 30287 RVA: 0x000A9C57 File Offset: 0x000A7E57
		// (set) Token: 0x06007650 RID: 30288 RVA: 0x000A9C67 File Offset: 0x000A7E67
		public unsafe float InstanceScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABakedBoneMeshActor.__PropertyOffset_InstanceScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABakedBoneMeshActor.__PropertyOffset_InstanceScale) = value;
			}
		}

		// Token: 0x17001C00 RID: 7168
		// (get) Token: 0x06007651 RID: 30289 RVA: 0x000A9C78 File Offset: 0x000A7E78
		// (set) Token: 0x06007652 RID: 30290 RVA: 0x000A9C88 File Offset: 0x000A7E88
		public unsafe int NumInstances
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABakedBoneMeshActor.__PropertyOffset_NumInstances);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABakedBoneMeshActor.__PropertyOffset_NumInstances) = value;
			}
		}

		// Token: 0x17001C01 RID: 7169
		// (get) Token: 0x06007653 RID: 30291 RVA: 0x000A9C9C File Offset: 0x000A7E9C
		// (set) Token: 0x06007654 RID: 30292 RVA: 0x000A9CD5 File Offset: 0x000A7ED5
		public TArray<FTransform> InstanceTransforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._InstanceTransforms) == null)
				{
					result = (this._InstanceTransforms = new TArray<FTransform>(base.NativePtr + (IntPtr)ABakedBoneMeshActor.__PropertyOffset_InstanceTransforms, this));
				}
				return result;
			}
			set
			{
				this.InstanceTransforms.CopyAssign(value);
			}
		}

		// Token: 0x17001C02 RID: 7170
		// (get) Token: 0x06007655 RID: 30293 RVA: 0x000A9CE3 File Offset: 0x000A7EE3
		// (set) Token: 0x06007656 RID: 30294 RVA: 0x000A9CF3 File Offset: 0x000A7EF3
		public unsafe bool bAllowTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABakedBoneMeshActor.__PropertyOffset_bAllowTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABakedBoneMeshActor.__PropertyOffset_bAllowTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x06007657 RID: 30295 RVA: 0x000A9D04 File Offset: 0x000A7F04
		public void UpdateDebugDrawState()
		{
			ABakedBoneMeshActor.__UpdateDebugDrawState_Internal(base.NativePtr);
		}

		// Token: 0x06007658 RID: 30296 RVA: 0x000A9D11 File Offset: 0x000A7F11
		public void SetLogicallyVisible(bool bVisible)
		{
			ABakedBoneMeshActor.__SetLogicallyVisible_Internal(base.NativePtr, bVisible);
		}

		// Token: 0x06007659 RID: 30297 RVA: 0x000A9D1F File Offset: 0x000A7F1F
		public bool IsLogicallyVisible()
		{
			return ABakedBoneMeshActor.__IsLogicallyVisible_Internal(base.NativePtr);
		}

		// Token: 0x0600765A RID: 30298 RVA: 0x000A9D2C File Offset: 0x000A7F2C
		[NullableContext(2)]
		public UBakedBoneMeshComponent GetBakedBoneMeshComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBakedBoneMeshComponent>(ABakedBoneMeshActor.__GetBakedBoneMeshComponent_Internal(base.NativePtr));
		}

		// Token: 0x0600765B RID: 30299 RVA: 0x000A9D3E File Offset: 0x000A7F3E
		public TArray<FTransform> GenerateInstanceTransformsByAreaType()
		{
			return new TArray<FTransform>(ABakedBoneMeshActor.__GenerateInstanceTransformsByAreaType_Internal(base.NativePtr), null);
		}

		// Token: 0x0600765C RID: 30300 RVA: 0x000A9D51 File Offset: 0x000A7F51
		public virtual void CreateRenderData()
		{
			ABakedBoneMeshActor.__CreateRenderData_Internal(base.NativePtr);
		}

		// Token: 0x0600765D RID: 30301 RVA: 0x000A9D5E File Offset: 0x000A7F5E
		public FBoxSphereBounds CalcBoundsByAreaType()
		{
			return ABakedBoneMeshActor.__CalcBoundsByAreaType_Internal(base.NativePtr);
		}

		// Token: 0x0600765E RID: 30302 RVA: 0x000A9D6B File Offset: 0x000A7F6B
		public void AddInstanceIndexInfo(int InTotalInstIndex, int InGroupIndex, int InSubInstIndex)
		{
			ABakedBoneMeshActor.__AddInstanceIndexInfo_Internal(base.NativePtr, InTotalInstIndex, InGroupIndex, InSubInstIndex);
		}

		// Token: 0x0600765F RID: 30303
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateDebugDrawState_Internal(IntPtr @this);

		// Token: 0x06007660 RID: 30304
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLogicallyVisible_Internal(IntPtr @this, bool bVisible);

		// Token: 0x06007661 RID: 30305
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLogicallyVisible_Internal(IntPtr @this);

		// Token: 0x06007662 RID: 30306
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBakedBoneMeshComponent_Internal(IntPtr @this);

		// Token: 0x06007663 RID: 30307
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GenerateInstanceTransformsByAreaType_Internal(IntPtr @this);

		// Token: 0x06007664 RID: 30308
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CreateRenderData_Internal(IntPtr @this);

		// Token: 0x06007665 RID: 30309
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds __CalcBoundsByAreaType_Internal(IntPtr @this);

		// Token: 0x06007666 RID: 30310
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddInstanceIndexInfo_Internal(IntPtr @this, int InTotalInstIndex, int InGroupIndex, int InSubInstIndex);

		// Token: 0x06007667 RID: 30311 RVA: 0x000A9D7B File Offset: 0x000A7F7B
		static ABakedBoneMeshActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BakedBoneMeshActor");
		}

		// Token: 0x06007668 RID: 30312 RVA: 0x000A9D89 File Offset: 0x000A7F89
		protected ABakedBoneMeshActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040038F9 RID: 14585
		public new const string __ObjectPath = "/Script/Engine.BakedBoneMeshActor";

		// Token: 0x040038FA RID: 14586
		private static IntPtr _ClassPtr;

		// Token: 0x040038FB RID: 14587
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040038FC RID: 14588
		internal static int __PropertyOffset_InstanceScale;

		// Token: 0x040038FD RID: 14589
		internal static int __PropertyOffset_NumInstances;

		// Token: 0x040038FE RID: 14590
		internal static int __PropertyOffset_InstanceTransforms;

		// Token: 0x040038FF RID: 14591
		[Nullable(2)]
		private TArray<FTransform> _InstanceTransforms;

		// Token: 0x04003900 RID: 14592
		internal static int __PropertyOffset_bAllowTick;
	}
}
