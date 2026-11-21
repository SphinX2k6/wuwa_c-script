using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000188 RID: 392
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBoneMeshActor")]
	[UnrealStructLayout(1280, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1280)]
	public class ABakedBoneMeshActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600192C RID: 6444 RVA: 0x00026276 File Offset: 0x00024476
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ABakedBoneMeshActor._ClassPtr;
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x00026284 File Offset: 0x00024484
		public ABakedBoneMeshActor() : this(BuiltinUtils.AllocNativeUObject(ABakedBoneMeshActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x000262AC File Offset: 0x000244AC
		public ABakedBoneMeshActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABakedBoneMeshActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x0600192F RID: 6447 RVA: 0x000262DF File Offset: 0x000244DF
		// (set) Token: 0x06001930 RID: 6448 RVA: 0x000262EF File Offset: 0x000244EF
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

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x00026300 File Offset: 0x00024500
		// (set) Token: 0x06001932 RID: 6450 RVA: 0x00026310 File Offset: 0x00024510
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

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06001933 RID: 6451 RVA: 0x00026324 File Offset: 0x00024524
		// (set) Token: 0x06001934 RID: 6452 RVA: 0x0002635D File Offset: 0x0002455D
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

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06001935 RID: 6453 RVA: 0x0002636B File Offset: 0x0002456B
		// (set) Token: 0x06001936 RID: 6454 RVA: 0x0002637B File Offset: 0x0002457B
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

		// Token: 0x06001937 RID: 6455 RVA: 0x0002638C File Offset: 0x0002458C
		public void UpdateDebugDrawState()
		{
			ABakedBoneMeshActor.__UpdateDebugDrawState_Internal(base.NativePtr);
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x00026399 File Offset: 0x00024599
		public void SetLogicallyVisible(bool bVisible)
		{
			ABakedBoneMeshActor.__SetLogicallyVisible_Internal(base.NativePtr, bVisible);
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x000263A7 File Offset: 0x000245A7
		public bool IsLogicallyVisible()
		{
			return ABakedBoneMeshActor.__IsLogicallyVisible_Internal(base.NativePtr);
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x000263B4 File Offset: 0x000245B4
		[NullableContext(2)]
		public UBakedBoneMeshComponent GetBakedBoneMeshComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBakedBoneMeshComponent>(ABakedBoneMeshActor.__GetBakedBoneMeshComponent_Internal(base.NativePtr));
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x000263C6 File Offset: 0x000245C6
		public TArray<FTransform> GenerateInstanceTransformsByAreaType()
		{
			return new TArray<FTransform>(ABakedBoneMeshActor.__GenerateInstanceTransformsByAreaType_Internal(base.NativePtr), null);
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x000263D9 File Offset: 0x000245D9
		public virtual void CreateRenderData()
		{
			ABakedBoneMeshActor.__CreateRenderData_Internal(base.NativePtr);
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x000263E6 File Offset: 0x000245E6
		public FBoxSphereBounds CalcBoundsByAreaType()
		{
			return ABakedBoneMeshActor.__CalcBoundsByAreaType_Internal(base.NativePtr);
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x000263F3 File Offset: 0x000245F3
		public void AddInstanceIndexInfo(int InTotalInstIndex, int InGroupIndex, int InSubInstIndex)
		{
			ABakedBoneMeshActor.__AddInstanceIndexInfo_Internal(base.NativePtr, InTotalInstIndex, InGroupIndex, InSubInstIndex);
		}

		// Token: 0x0600193F RID: 6463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateDebugDrawState_Internal(IntPtr @this);

		// Token: 0x06001940 RID: 6464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLogicallyVisible_Internal(IntPtr @this, bool bVisible);

		// Token: 0x06001941 RID: 6465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLogicallyVisible_Internal(IntPtr @this);

		// Token: 0x06001942 RID: 6466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBakedBoneMeshComponent_Internal(IntPtr @this);

		// Token: 0x06001943 RID: 6467
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GenerateInstanceTransformsByAreaType_Internal(IntPtr @this);

		// Token: 0x06001944 RID: 6468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CreateRenderData_Internal(IntPtr @this);

		// Token: 0x06001945 RID: 6469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds __CalcBoundsByAreaType_Internal(IntPtr @this);

		// Token: 0x06001946 RID: 6470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddInstanceIndexInfo_Internal(IntPtr @this, int InTotalInstIndex, int InGroupIndex, int InSubInstIndex);

		// Token: 0x06001947 RID: 6471 RVA: 0x00026403 File Offset: 0x00024603
		static ABakedBoneMeshActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BakedBoneMeshActor");
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00026411 File Offset: 0x00024611
		protected ABakedBoneMeshActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000818 RID: 2072
		public new const string __ObjectPath = "/Script/Engine.BakedBoneMeshActor";

		// Token: 0x04000819 RID: 2073
		private static IntPtr _ClassPtr;

		// Token: 0x0400081A RID: 2074
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400081B RID: 2075
		internal static int __PropertyOffset_InstanceScale;

		// Token: 0x0400081C RID: 2076
		internal static int __PropertyOffset_NumInstances;

		// Token: 0x0400081D RID: 2077
		internal static int __PropertyOffset_InstanceTransforms;

		// Token: 0x0400081E RID: 2078
		[Nullable(2)]
		private TArray<FTransform> _InstanceTransforms;

		// Token: 0x0400081F RID: 2079
		internal static int __PropertyOffset_bAllowTick;
	}
}
