using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000408 RID: 1032
	[UnrealObjectPath("/Script/KuroGameplay.KuroWaterInteractionComponent")]
	[UnrealStructLayout(2032, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2032)]
	public class UKuroWaterInteractionComponent : UStaticMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006503 RID: 25859 RVA: 0x000901FC File Offset: 0x0008E3FC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroWaterInteractionComponent._ClassPtr;
		}

		// Token: 0x06006504 RID: 25860 RVA: 0x00090208 File Offset: 0x0008E408
		public UKuroWaterInteractionComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroWaterInteractionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006505 RID: 25861 RVA: 0x00090230 File Offset: 0x0008E430
		[NullableContext(1)]
		public UKuroWaterInteractionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroWaterInteractionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x06006506 RID: 25862 RVA: 0x00090263 File Offset: 0x0008E463
		// (set) Token: 0x06006507 RID: 25863 RVA: 0x00090277 File Offset: 0x0008E477
		[Nullable(2)]
		public unsafe AActor Invoker
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroWaterInteractionComponent.__PropertyOffset_Invoker);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroWaterInteractionComponent.__PropertyOffset_Invoker, value);
			}
		}

		// Token: 0x06006508 RID: 25864 RVA: 0x0009028C File Offset: 0x0008E48C
		public virtual void HandleWaterDetectedTick(float DeltaTime, float WaterSurface, in FVectorDouble Location)
		{
			UKuroWaterInteractionComponent.__HandleWaterDetectedTick_Internal(base.NativePtr, DeltaTime, WaterSurface, Location);
		}

		// Token: 0x06006509 RID: 25865 RVA: 0x0009029C File Offset: 0x0008E49C
		public virtual void HandleWaterDetectedStart()
		{
			UKuroWaterInteractionComponent.__HandleWaterDetectedStart_Internal(base.NativePtr);
		}

		// Token: 0x0600650A RID: 25866 RVA: 0x000902A9 File Offset: 0x0008E4A9
		public virtual void HandleWaterDetectedEnd()
		{
			UKuroWaterInteractionComponent.__HandleWaterDetectedEnd_Internal(base.NativePtr);
		}

		// Token: 0x0600650B RID: 25867
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleWaterDetectedTick_Internal(IntPtr @this, float DeltaTime, float WaterSurface, in FVectorDouble Location);

		// Token: 0x0600650C RID: 25868
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleWaterDetectedStart_Internal(IntPtr @this);

		// Token: 0x0600650D RID: 25869
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleWaterDetectedEnd_Internal(IntPtr @this);

		// Token: 0x0600650E RID: 25870 RVA: 0x000902B6 File Offset: 0x0008E4B6
		static UKuroWaterInteractionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroWaterInteractionComponent");
		}

		// Token: 0x0600650F RID: 25871 RVA: 0x000902C4 File Offset: 0x0008E4C4
		protected UKuroWaterInteractionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002A83 RID: 10883
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroWaterInteractionComponent";

		// Token: 0x04002A84 RID: 10884
		private static IntPtr _ClassPtr;

		// Token: 0x04002A85 RID: 10885
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002A86 RID: 10886
		internal static int __PropertyOffset_Invoker;

		// Token: 0x02000AF2 RID: 2802
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __HandleWaterDetectedTick_FunctionParams
		{
			// Token: 0x04005B7E RID: 23422
			[FieldOffset(0)]
			public float DeltaTime;

			// Token: 0x04005B7F RID: 23423
			[FieldOffset(4)]
			public float WaterSurface;

			// Token: 0x04005B80 RID: 23424
			[FieldOffset(8)]
			public FVectorDouble Location;
		}
	}
}
