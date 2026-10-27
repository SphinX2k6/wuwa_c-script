using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012B2 RID: 4786
	[UnrealObjectPath("/Script/FieldSystemEngine.FieldSystemComponent")]
	[UnrealStructLayout(1616, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1616)]
	public class UFieldSystemComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601186F RID: 71791 RVA: 0x0019B84F File Offset: 0x00199A4F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFieldSystemComponent._ClassPtr;
		}

		// Token: 0x06011870 RID: 71792 RVA: 0x0019B85C File Offset: 0x00199A5C
		public UFieldSystemComponent() : this(BuiltinUtils.AllocNativeUObject(UFieldSystemComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011871 RID: 71793 RVA: 0x0019B884 File Offset: 0x00199A84
		[NullableContext(1)]
		public UFieldSystemComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFieldSystemComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700446A RID: 17514
		// (get) Token: 0x06011872 RID: 71794 RVA: 0x0019B8B7 File Offset: 0x00199AB7
		// (set) Token: 0x06011873 RID: 71795 RVA: 0x0019B8CB File Offset: 0x00199ACB
		[Nullable(2)]
		public unsafe UFieldSystem FieldSystem
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFieldSystem>(base.NativePtr / (IntPtr)sizeof(void*) + UFieldSystemComponent.__PropertyOffset_FieldSystem);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UFieldSystemComponent.__PropertyOffset_FieldSystem, value);
			}
		}

		// Token: 0x1700446B RID: 17515
		// (get) Token: 0x06011874 RID: 71796 RVA: 0x0019B8E0 File Offset: 0x00199AE0
		// (set) Token: 0x06011875 RID: 71797 RVA: 0x0019B919 File Offset: 0x00199B19
		[Nullable(1)]
		public TArray<TSoftObjectPtr<AChaosSolverActor>> SupportedSolvers
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<AChaosSolverActor>> result;
				if ((result = this._SupportedSolvers) == null)
				{
					result = (this._SupportedSolvers = new TArray<TSoftObjectPtr<AChaosSolverActor>>(base.NativePtr + (IntPtr)UFieldSystemComponent.__PropertyOffset_SupportedSolvers, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SupportedSolvers.CopyAssign(value);
			}
		}

		// Token: 0x06011876 RID: 71798 RVA: 0x0019B927 File Offset: 0x00199B27
		public void ResetFieldSystem()
		{
			UFieldSystemComponent.__ResetFieldSystem_Internal(base.NativePtr);
		}

		// Token: 0x06011877 RID: 71799 RVA: 0x0019B934 File Offset: 0x00199B34
		public void ApplyUniformVectorFalloffForce(bool Enabled, FVector Position, FVector Direction, float Radius, float Magnitude)
		{
			UFieldSystemComponent.__ApplyUniformVectorFalloffForce_Internal(base.NativePtr, Enabled, Position, Direction, Radius, Magnitude);
		}

		// Token: 0x06011878 RID: 71800 RVA: 0x0019B948 File Offset: 0x00199B48
		public void ApplyStrainField(bool Enabled, FVector Position, float Radius, float Magnitude, int Iterations)
		{
			UFieldSystemComponent.__ApplyStrainField_Internal(base.NativePtr, Enabled, Position, Radius, Magnitude, Iterations);
		}

		// Token: 0x06011879 RID: 71801 RVA: 0x0019B95C File Offset: 0x00199B5C
		public void ApplyStayDynamicField(bool Enabled, FVector Position, float Radius)
		{
			UFieldSystemComponent.__ApplyStayDynamicField_Internal(base.NativePtr, Enabled, Position, Radius);
		}

		// Token: 0x0601187A RID: 71802 RVA: 0x0019B96C File Offset: 0x00199B6C
		public void ApplyRadialVectorFalloffForce(bool Enabled, FVector Position, float Radius, float Magnitude)
		{
			UFieldSystemComponent.__ApplyRadialVectorFalloffForce_Internal(base.NativePtr, Enabled, Position, Radius, Magnitude);
		}

		// Token: 0x0601187B RID: 71803 RVA: 0x0019B97E File Offset: 0x00199B7E
		public void ApplyRadialForce(bool Enabled, FVector Position, float Magnitude)
		{
			UFieldSystemComponent.__ApplyRadialForce_Internal(base.NativePtr, Enabled, Position, Magnitude);
		}

		// Token: 0x0601187C RID: 71804 RVA: 0x0019B98E File Offset: 0x00199B8E
		[NullableContext(2)]
		public void ApplyPhysicsField(bool Enabled, EFieldPhysicsType Target, UFieldSystemMetaData MetaData, UFieldNodeBase Field)
		{
			UFieldSystemComponent.__ApplyPhysicsField_Internal(base.NativePtr, Enabled, Target, (MetaData != null) ? MetaData.NativePtr : IntPtr.Zero, (Field != null) ? Field.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601187D RID: 71805 RVA: 0x0019B9C4 File Offset: 0x00199BC4
		public void ApplyLinearForce(bool Enabled, FVector Direction, float Magnitude)
		{
			UFieldSystemComponent.__ApplyLinearForce_Internal(base.NativePtr, Enabled, Direction, Magnitude);
		}

		// Token: 0x0601187E RID: 71806 RVA: 0x0019B9D4 File Offset: 0x00199BD4
		[NullableContext(2)]
		public void AddFieldCommand(bool Enabled, EFieldPhysicsType Target, UFieldSystemMetaData MetaData, UFieldNodeBase Field)
		{
			UFieldSystemComponent.__AddFieldCommand_Internal(base.NativePtr, Enabled, Target, (MetaData != null) ? MetaData.NativePtr : IntPtr.Zero, (Field != null) ? Field.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601187F RID: 71807
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetFieldSystem_Internal(IntPtr @this);

		// Token: 0x06011880 RID: 71808
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyUniformVectorFalloffForce_Internal(IntPtr @this, bool Enabled, FVector Position, FVector Direction, float Radius, float Magnitude);

		// Token: 0x06011881 RID: 71809
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyStrainField_Internal(IntPtr @this, bool Enabled, FVector Position, float Radius, float Magnitude, int Iterations);

		// Token: 0x06011882 RID: 71810
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyStayDynamicField_Internal(IntPtr @this, bool Enabled, FVector Position, float Radius);

		// Token: 0x06011883 RID: 71811
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyRadialVectorFalloffForce_Internal(IntPtr @this, bool Enabled, FVector Position, float Radius, float Magnitude);

		// Token: 0x06011884 RID: 71812
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyRadialForce_Internal(IntPtr @this, bool Enabled, FVector Position, float Magnitude);

		// Token: 0x06011885 RID: 71813
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyPhysicsField_Internal(IntPtr @this, bool Enabled, TEnumAsByte<EFieldPhysicsType> Target, IntPtr MetaData, IntPtr Field);

		// Token: 0x06011886 RID: 71814
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyLinearForce_Internal(IntPtr @this, bool Enabled, FVector Direction, float Magnitude);

		// Token: 0x06011887 RID: 71815
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddFieldCommand_Internal(IntPtr @this, bool Enabled, TEnumAsByte<EFieldPhysicsType> Target, IntPtr MetaData, IntPtr Field);

		// Token: 0x06011888 RID: 71816 RVA: 0x0019BA0A File Offset: 0x00199C0A
		static UFieldSystemComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FieldSystemEngine.FieldSystemComponent");
		}

		// Token: 0x06011889 RID: 71817 RVA: 0x0019BA18 File Offset: 0x00199C18
		protected UFieldSystemComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009645 RID: 38469
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FieldSystemEngine.FieldSystemComponent";

		// Token: 0x04009646 RID: 38470
		private static IntPtr _ClassPtr;

		// Token: 0x04009647 RID: 38471
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009648 RID: 38472
		internal static int __PropertyOffset_FieldSystem;

		// Token: 0x04009649 RID: 38473
		internal static int __PropertyOffset_SupportedSolvers;

		// Token: 0x0400964A RID: 38474
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<AChaosSolverActor>> _SupportedSolvers;
	}
}
